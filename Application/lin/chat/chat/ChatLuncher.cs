using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chat
{
    public class ChatLuncher
    {
        /// <summary>
        /// 
        /// </summary>
        private List<User> connecteduser = new List<User>();
        /// <summary>
        /// 
        /// </summary>
        private Dictionary<string, List<ChatMessage>> incoming = new Dictionary<string, List<ChatMessage>>();


        public List<User> Connecteduser
        {
            get { return connecteduser; }
            set { connecteduser = value; }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
        public User Addnewuser(User user)
        {
            var exist = from User a in this.connecteduser
                        where a.Name == user.Name
                        select a;
            if (exist.Count() == 0)
            {
                this.connecteduser.Add(user);
                incoming.Add(user.Name, new List<ChatMessage>()
                    {
                        new ChatMessage(){User=user,Date=DateTime.Now,Message="welcome to chat"}
                    });

                Console.WriteLine("\n " + user.Name + "connect");
                return user;
            }
            else
                return null;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="newmessage"></param>
        public void Addnewmessage(ChatMessage newmessage)
        {
            Console.WriteLine(newmessage.User.Name + "said" + newmessage.Message + "at" + newmessage.Date);
            foreach(var user in this.connecteduser)
            {
                incoming[user.Name].Add(newmessage);
            }
        }

        public List<ChatMessage> Getnewmessage(User user)
        {
            List<ChatMessage> mynewmessage = incoming[user.Name];
            incoming[user.Name]=new List<ChatMessage>();
            if(mynewmessage.Count>0)
                return mynewmessage;
            else
                return null;
        }
        public void Removeuser(User user)
        {
            this.connecteduser.RemoveAll(a => a.Name ==user.Name);
            ///
        }
    }
}
