using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using ChatServiceMDW;
using System.Timers;

namespace ChatServiceMDW
{
   [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    public class CChat : IChat,ILogin
    {
       DataHelper dataHelper;
        // private List<Player> players;
        List<string> playerslist = new List<string>();
        private static readonly List<IChatCallback> subscribers = new List<IChatCallback>();
       private static readonly List<IChatCallback> privareSubscribers = new List<IChatCallback>();

       public CChat()
       {
           //players = new List<Player>();
           dataHelper = new DataHelper();
       }

       public int Login(string username,string pass)
       {
            int temp;
            temp = dataHelper.LogIn(username, pass);
            return temp;
        }
     
       bool IChat.Subscribe()
       {
           try
           {
               IChatCallback chatCallBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
               if (!subscribers.Contains(chatCallBack))
               
                   subscribers.Add(chatCallBack);
                   return true;
               
           }
           catch 
           {
               return false;
           }
       }
       bool IChat.UnSubscribe()
       {
           try
           {
               IChatCallback callback = OperationContext.Current.GetCallbackChannel<IChatCallback>();
               if (subscribers.Contains(callback))
                   subscribers.Remove(callback);
               return true;
           }
           catch
           {
               return false;
           }
       }
       void IChat.AddMessage(string playerName,string message)
       {
           subscribers.ForEach(delegate(IChatCallback callback)
           {
               if (((ICommunicationObject)callback).State == CommunicationState.Opened)
               {
                   callback.onMessageAdded(DateTime.Now, playerName, message);
                   
               }
               else
               {
                   subscribers.Remove(callback);
               }
           });

       }


       public int CreateAnAccount(string username, string password, string firstname)
       {
            int temp;
            temp=dataHelper.CreateAnAccount(username, password, firstname);
            return temp;
       }

        public List<string> ListOfOnlinePlayers()
        {
            playerslist = dataHelper.ListOfOnlinePlayers();
            return playerslist;
        }

        public List<string> ListOfAllPlayers()
        {
           playerslist = dataHelper.ListOfAllPlayers();
            return playerslist;
        }

        public string PlayerStats(string username)
        {
            string temp;
            temp = dataHelper.PlayerStats(username);
            return temp;
        }

        public void PlayerOffline(string username, int offline)
        {
            dataHelper.PlayerOffline(username,offline);
        }
     
        //public List<Player> GetOnlinePlayers()
        //{
        //    return players;
        //}

        public void FireEvent(string playerName)
       {
           subscribers.ForEach(delegate(IChatCallback callback)
           {
               if (((ICommunicationObject)callback).State == CommunicationState.Opened)
               {
                   callback.OnOnline(playerName);

               }
               else
               {
                   subscribers.Remove(callback);
               }
           });

       }
       public bool PrivateSubscribe()
       {
           try
           {
               IChatCallback chatCallBack = OperationContext.Current.GetCallbackChannel<IChatCallback>();
               if (!privareSubscribers.Contains(chatCallBack))
                   privareSubscribers.Add(chatCallBack);
               return true;

           }
           catch
           {
               return false;
           }
       }


       public void AddPrivateMessage(string playerName, string message)
       {

           privareSubscribers.ForEach(delegate(IChatCallback callback)
           {
               if (((ICommunicationObject)callback).State == CommunicationState.Opened)
               {
                   callback.onMessageAdded(DateTime.Now, playerName, message);

               }
               else
               {
                   privareSubscribers.Remove(callback);
               }
           });
       }
    }
}
