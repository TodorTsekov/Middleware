﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleDatabaseApplication.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="ChatCallbacks", ConfigurationName="ServiceReference1.IChat", CallbackContract=typeof(SimpleDatabaseApplication.ServiceReference1.IChatCallback))]
    public interface IChat {
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/AddMessage", ReplyAction="ChatCallbacks/IChat/AddMessageResponse")]
        void AddMessage(string playerName, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/AddMessage", ReplyAction="ChatCallbacks/IChat/AddMessageResponse")]
        System.Threading.Tasks.Task AddMessageAsync(string playerName, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/Subscribe", ReplyAction="ChatCallbacks/IChat/SubscribeResponse")]
        bool Subscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/Subscribe", ReplyAction="ChatCallbacks/IChat/SubscribeResponse")]
        System.Threading.Tasks.Task<bool> SubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/UnSubscribe", ReplyAction="ChatCallbacks/IChat/UnSubscribeResponse")]
        bool UnSubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/UnSubscribe", ReplyAction="ChatCallbacks/IChat/UnSubscribeResponse")]
        System.Threading.Tasks.Task<bool> UnSubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/PrivateSubscribe", ReplyAction="ChatCallbacks/IChat/PrivateSubscribeResponse")]
        bool PrivateSubscribe();
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/PrivateSubscribe", ReplyAction="ChatCallbacks/IChat/PrivateSubscribeResponse")]
        System.Threading.Tasks.Task<bool> PrivateSubscribeAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/AddPrivateMessage", ReplyAction="ChatCallbacks/IChat/AddPrivateMessageResponse")]
        void AddPrivateMessage(string playerName, string message);
        
        [System.ServiceModel.OperationContractAttribute(Action="ChatCallbacks/IChat/AddPrivateMessage", ReplyAction="ChatCallbacks/IChat/AddPrivateMessageResponse")]
        System.Threading.Tasks.Task AddPrivateMessageAsync(string playerName, string message);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="ChatCallbacks/IChat/onMessageAdded")]
        void onMessageAdded(System.DateTime timestamp, string playerName, string message);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="ChatCallbacks/IChat/OnOnline")]
        void OnOnline(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IChatChannel : SimpleDatabaseApplication.ServiceReference1.IChat, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ChatClient : System.ServiceModel.DuplexClientBase<SimpleDatabaseApplication.ServiceReference1.IChat>, SimpleDatabaseApplication.ServiceReference1.IChat {
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ChatClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void AddMessage(string playerName, string message) {
            base.Channel.AddMessage(playerName, message);
        }
        
        public System.Threading.Tasks.Task AddMessageAsync(string playerName, string message) {
            return base.Channel.AddMessageAsync(playerName, message);
        }
        
        public bool Subscribe() {
            return base.Channel.Subscribe();
        }
        
        public System.Threading.Tasks.Task<bool> SubscribeAsync() {
            return base.Channel.SubscribeAsync();
        }
        
        public bool UnSubscribe() {
            return base.Channel.UnSubscribe();
        }
        
        public System.Threading.Tasks.Task<bool> UnSubscribeAsync() {
            return base.Channel.UnSubscribeAsync();
        }
        
        public bool PrivateSubscribe() {
            return base.Channel.PrivateSubscribe();
        }
        
        public System.Threading.Tasks.Task<bool> PrivateSubscribeAsync() {
            return base.Channel.PrivateSubscribeAsync();
        }
        
        public void AddPrivateMessage(string playerName, string message) {
            base.Channel.AddPrivateMessage(playerName, message);
        }
        
        public System.Threading.Tasks.Task AddPrivateMessageAsync(string playerName, string message) {
            return base.Channel.AddPrivateMessageAsync(playerName, message);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="LoginContract", ConfigurationName="ServiceReference1.ILogin")]
    public interface ILogin {
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/Login", ReplyAction="LoginContract/ILogin/LoginResponse")]
        int Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/Login", ReplyAction="LoginContract/ILogin/LoginResponse")]
        System.Threading.Tasks.Task<int> LoginAsync(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/CreateAnAccount", ReplyAction="LoginContract/ILogin/CreateAnAccountResponse")]
        int CreateAnAccount(string username, string password, string firstname);
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/CreateAnAccount", ReplyAction="LoginContract/ILogin/CreateAnAccountResponse")]
        System.Threading.Tasks.Task<int> CreateAnAccountAsync(string username, string password, string firstname);
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/ListOfOnlinePlayers", ReplyAction="LoginContract/ILogin/ListOfOnlinePlayersResponse")]
        string[] ListOfOnlinePlayers();
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/ListOfOnlinePlayers", ReplyAction="LoginContract/ILogin/ListOfOnlinePlayersResponse")]
        System.Threading.Tasks.Task<string[]> ListOfOnlinePlayersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/ListOfAllPlayers", ReplyAction="LoginContract/ILogin/ListOfAllPlayersResponse")]
        string[] ListOfAllPlayers();
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/ListOfAllPlayers", ReplyAction="LoginContract/ILogin/ListOfAllPlayersResponse")]
        System.Threading.Tasks.Task<string[]> ListOfAllPlayersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/PlayerStats", ReplyAction="LoginContract/ILogin/PlayerStatsResponse")]
        string PlayerStats(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/PlayerStats", ReplyAction="LoginContract/ILogin/PlayerStatsResponse")]
        System.Threading.Tasks.Task<string> PlayerStatsAsync(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/PlayerOffline", ReplyAction="LoginContract/ILogin/PlayerOfflineResponse")]
        void PlayerOffline(string username, int offline);
        
        [System.ServiceModel.OperationContractAttribute(Action="LoginContract/ILogin/PlayerOffline", ReplyAction="LoginContract/ILogin/PlayerOfflineResponse")]
        System.Threading.Tasks.Task PlayerOfflineAsync(string username, int offline);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ILoginChannel : SimpleDatabaseApplication.ServiceReference1.ILogin, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class LoginClient : System.ServiceModel.ClientBase<SimpleDatabaseApplication.ServiceReference1.ILogin>, SimpleDatabaseApplication.ServiceReference1.ILogin {
        
        public LoginClient() {
        }
        
        public LoginClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public LoginClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public LoginClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Threading.Tasks.Task<int> LoginAsync(string username, string password) {
            return base.Channel.LoginAsync(username, password);
        }
        
        public int CreateAnAccount(string username, string password, string firstname) {
            return base.Channel.CreateAnAccount(username, password, firstname);
        }
        
        public System.Threading.Tasks.Task<int> CreateAnAccountAsync(string username, string password, string firstname) {
            return base.Channel.CreateAnAccountAsync(username, password, firstname);
        }
        
        public string[] ListOfOnlinePlayers() {
            return base.Channel.ListOfOnlinePlayers();
        }
        
        public System.Threading.Tasks.Task<string[]> ListOfOnlinePlayersAsync() {
            return base.Channel.ListOfOnlinePlayersAsync();
        }
        
        public string[] ListOfAllPlayers() {
            return base.Channel.ListOfAllPlayers();
        }
        
        public System.Threading.Tasks.Task<string[]> ListOfAllPlayersAsync() {
            return base.Channel.ListOfAllPlayersAsync();
        }
        
        public string PlayerStats(string username) {
            return base.Channel.PlayerStats(username);
        }
        
        public System.Threading.Tasks.Task<string> PlayerStatsAsync(string username) {
            return base.Channel.PlayerStatsAsync(username);
        }
        
        public void PlayerOffline(string username, int offline) {
            base.Channel.PlayerOffline(username, offline);
        }
        
        public System.Threading.Tasks.Task PlayerOfflineAsync(string username, int offline) {
            return base.Channel.PlayerOfflineAsync(username, offline);
        }
    }
}
