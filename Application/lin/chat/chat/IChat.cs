using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace chat
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract(SessionMode=SessionMode.Allowed)]
    public interface Triva
    {
        [OperationContract]
        User ClientConnect(string username);
        [OperationContract]
        List<User> Getalluser();
        [OperationContract]
        List<ChatMessage> Getnewmessage(User user);
        [OperationContract]
        void Sendmessage(ChatMessage newmessage);

        [OperationContract]
        void Removeuser(User user);


        // TODO: Add your service operations here
    }
    [DataContract]
    public class User
    {
        private string name, ip, host;

        [DataMember]
        public string Host
        {
            get { return host; }
            set { host = value; }
        }
        [DataMember]
        public string Ip
        {
            get { return ip; }
            set { ip = value; }
        }
        [DataMember]
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

    }

    [DataContract]
    public class ChatMessage
    {
        private User user;
[DataMember]
public User User
{
  get { return user; }
  set { user = value; }
}
        private string message;
[DataMember]
public string Message
{
  get { return message; }
  set { message = value; }
}
        private DateTime date;
[DataMember]
public DateTime Date
{
  get { return date; }
  set { date = value; }
}

      
      
    }
   
    }

