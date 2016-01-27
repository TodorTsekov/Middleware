using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace chat
{
    [ServiceBehavior(InstanceContextMode=InstanceContextMode.Single)]
    public class Chat : Triva
    {
        private ChatLuncher mainluncher = new ChatLuncher();
        public User ClientConnect(string username)
        {
            return mainluncher.Addnewuser(new User() { Name = username });
        }

        public List<User> Getalluser()
        {
            return mainluncher.Connecteduser;
        }

        public List<ChatMessage> Getnewmessage(User user)
        {
            return mainluncher.Getnewmessage(user);
        }

        public void Sendmessage(ChatMessage newmessage)
        {
            mainluncher.Addnewmessage(newmessage);
        }

        public void Removeuser(User user)
        {
            mainluncher.Removeuser(user);
        }
    }
}
