using System;
using System.Collections.Generic;
using System.Linq;
using Classes;
using DB;
using System.Data.Entity.SqlServer;

namespace DAL
{
    public class DBChat
    {
        #region Variables

        private ChatEntities ch = new ChatEntities();

        #endregion

        #region Properties

        public Users _User { get; set; }

        #endregion

        #region Methods

        /// <summary>
        /// a never used function that fix nuget package problem
        /// </summary>
        internal static class MissingDllHack
        {
            // Must reference a type in EntityFramework.SqlServer.dll so that this dll will be
            // included in the output folder of referencing projects without requiring a direct 
            // dependency on Entity Framework. See http://stackoverflow.com/a/22315164/1141360.
            private static SqlProviderServices instance = SqlProviderServices.Instance;
        }

        /// <summary>
        /// Checks the if the user is in the DB and returns information about him:
        /// "-2" - username taken or user connected. "-1" - new user. other - user exists and returns his info.
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User CheckName(User user)
        {
            foreach (var currentUser in ch.Users)
            {
                if (currentUser.UserName.ToLower() == user.NickName.ToLower()
                    && currentUser.Name.ToLower() == user.Name.ToLower())
                {
                    if (currentUser.IsConnected == true)
                    {
                        // same user is allready connected:
                        user.Id = -2;
                        break;
                    }
                    user.Id = currentUser.ID;
                    user.LastConnectedDate = (DateTime)currentUser.LastConnectionDate;
                    _User = currentUser;
                    break;
                }

                //nickname taken:
                if (currentUser.UserName.ToLower() == user.NickName.ToLower())
                {
                    user.Id = -2;
                    break;
                }
            }
            if (user.Id == -2)
            {
                /* This case we know that the username 
                is taken and we want to let the client know that*/
            }
            else if (user.Id != 0)
            {
                ch.Entry(_User).Property(e => e.IsConnected).CurrentValue = true;
                ch.SaveChanges();
            }
            else
            {
                //create new user:
                user.Id = -1;
            }
            return user;
        }

        public void AddPrivateMessage(User _User, string userMessage, List<User> usersList)
        {
            foreach (var user in usersList)
            {
                Messages message = new Messages()
                {
                    MessageText = userMessage,
                    UserID = _User.Id,
                    RecipientID = user.Id,
                    SentDate = DateTime.Today,
                };
                ch.Messages.Add(message);
            }
            ch.SaveChanges();
        }

        public void AddMessage(string userMessage, User user)
        {
            Messages message = new Messages()
            {
                MessageText = userMessage,
                UserID = user.Id,
                SentDate = DateTime.Today,
            };
            ch.Messages.Add(message);
            ch.SaveChanges();
        }

        /// <summary>
        /// Checks that all users in DB are disconnected. if not, disconnecting them
        /// </summary>
        public void CheckAllConnections()
        {
            var DisconnectedUsers = ch.Users.Where(user => user.IsConnected == true);
            foreach (var user in DisconnectedUsers)
            {
                ch.Entry(user).Property(e => e.IsConnected).CurrentValue = false;
            }
            ch.SaveChanges();
        }

        /// <summary>
        /// inserts new user, 
        /// or finds the user in the db. 
        /// and sends the id to the server.
        /// id="-2" - username taken
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User InsertNewUser(User user)
        {
            user = CheckName(user);
            if (user.Id == -1)
            {
                Users newUser = new Users()
                {
                    Name = user.Name,
                    UserName = user.NickName,
                    IsConnected = true,
                };
                ch.Users.Add(newUser);
                ch.SaveChanges();
                user.Id = getID(user.NickName);
            }
            return user;
        }

        /// <summary>
        /// returns all the messages in the DB
        /// </summary>
        /// <returns></returns>
        public List<Message> GetMessages()
        {
            List<Message> messages = new List<Message>();
            foreach (var message in ch.Messages)
            {
                Message _message = new Message
                {
                    Id = message.ID,
                    MessageText = message.MessageText,
                    SentDate = message.SentDate,
                };
                if (message.RecipientID != null)
                {
                    var recipientName = ch.Users.FirstOrDefault(user => user.ID == message.RecipientID);
                    _message.RecipientName = recipientName.UserName;
                }
                var userName = ch.Users.FirstOrDefault(user => user.ID == message.UserID);
                _message.UserName = userName.UserName;
                messages.Add(_message);
            }
            return messages;
        }

        /// <summary>
        /// returns all the users in the DB
        /// </summary>
        /// <returns></returns>
        public List<User> GetUsers()
        {
            List<User> users = new List<User>();
            foreach (var user in ch.Users)
            {
                User use = new User
                {
                    Id = user.ID,
                    Name = user.Name,
                    NickName = user.UserName,
                };
                if (user.IsConnected == true)
                {
                    use.Status = "Connected";
                }
                else
                {
                    use.Status = "Disconnected";
                }
                users.Add(use);
            }
            return users;
        }

        /// <summary>
        /// returns the id of a specific username
        /// </summary>
        /// <param name="nickName"></param>
        /// <returns></returns>
        private int getID(string nickName)
        {
            var id = ch.Users.
            Where(x => x.UserName.ToLower() == nickName.ToLower()).
            Select(x => x.ID).First();
            return id;
        }

        /// <summary>
        /// asks the Db to disconnect a user
        /// </summary>
        /// <param name="id"></param>
        public void DisconnectUser(int id)
        {
            var user = ch.Users.FirstOrDefault(item => item.ID == id);
            ch.Entry(user).Property(e => e.IsConnected).CurrentValue = false;
            ch.Entry(user).Property(e => e.LastConnectionDate).CurrentValue = DateTime.Now;
            ch.SaveChanges();
        }

        #endregion
    }
}
