﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TriviaClient.TriviaServer {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="CompositeType", Namespace="http://schemas.datacontract.org/2004/07/TriviaContract")]
    [System.SerializableAttribute()]
    public partial class CompositeType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool BoolValueField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string StringValueField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool BoolValue {
            get {
                return this.BoolValueField;
            }
            set {
                if ((this.BoolValueField.Equals(value) != true)) {
                    this.BoolValueField = value;
                    this.RaisePropertyChanged("BoolValue");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StringValue {
            get {
                return this.StringValueField;
            }
            set {
                if ((object.ReferenceEquals(this.StringValueField, value) != true)) {
                    this.StringValueField = value;
                    this.RaisePropertyChanged("StringValue");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Question", Namespace="http://schemas.datacontract.org/2004/07/TriviaContract")]
    [System.SerializableAttribute()]
    public partial class Question : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private TriviaClient.TriviaServer.Answer answerField;
        
        private int idField;
        
        private string questionTextField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public TriviaClient.TriviaServer.Answer answer {
            get {
                return this.answerField;
            }
            set {
                if ((object.ReferenceEquals(this.answerField, value) != true)) {
                    this.answerField = value;
                    this.RaisePropertyChanged("answer");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int id {
            get {
                return this.idField;
            }
            set {
                if ((this.idField.Equals(value) != true)) {
                    this.idField = value;
                    this.RaisePropertyChanged("id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string questionText {
            get {
                return this.questionTextField;
            }
            set {
                if ((object.ReferenceEquals(this.questionTextField, value) != true)) {
                    this.questionTextField = value;
                    this.RaisePropertyChanged("questionText");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Answer", Namespace="http://schemas.datacontract.org/2004/07/TriviaContract")]
    [System.SerializableAttribute()]
    public partial class Answer : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private string[] Ar_question_answersk__BackingFieldField;
        
        private bool[] Ar_resultsk__BackingFieldField;
        
        private int Question_idk__BackingFieldField;
        
        private string[] ar_question_answersField;
        
        private bool[] ar_resultsField;
        
        private int question_idField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Ar_question_answers>k__BackingField", IsRequired=true)]
        public string[] Ar_question_answersk__BackingField {
            get {
                return this.Ar_question_answersk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Ar_question_answersk__BackingFieldField, value) != true)) {
                    this.Ar_question_answersk__BackingFieldField = value;
                    this.RaisePropertyChanged("Ar_question_answersk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Ar_results>k__BackingField", IsRequired=true)]
        public bool[] Ar_resultsk__BackingField {
            get {
                return this.Ar_resultsk__BackingFieldField;
            }
            set {
                if ((object.ReferenceEquals(this.Ar_resultsk__BackingFieldField, value) != true)) {
                    this.Ar_resultsk__BackingFieldField = value;
                    this.RaisePropertyChanged("Ar_resultsk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="<Question_id>k__BackingField", IsRequired=true)]
        public int Question_idk__BackingField {
            get {
                return this.Question_idk__BackingFieldField;
            }
            set {
                if ((this.Question_idk__BackingFieldField.Equals(value) != true)) {
                    this.Question_idk__BackingFieldField = value;
                    this.RaisePropertyChanged("Question_idk__BackingField");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public string[] ar_question_answers {
            get {
                return this.ar_question_answersField;
            }
            set {
                if ((object.ReferenceEquals(this.ar_question_answersField, value) != true)) {
                    this.ar_question_answersField = value;
                    this.RaisePropertyChanged("ar_question_answers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool[] ar_results {
            get {
                return this.ar_resultsField;
            }
            set {
                if ((object.ReferenceEquals(this.ar_resultsField, value) != true)) {
                    this.ar_resultsField = value;
                    this.RaisePropertyChanged("ar_results");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int question_id {
            get {
                return this.question_idField;
            }
            set {
                if ((this.question_idField.Equals(value) != true)) {
                    this.question_idField = value;
                    this.RaisePropertyChanged("question_id");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="TriviaContract", ConfigurationName="TriviaServer.IGame", CallbackContract=typeof(TriviaClient.TriviaServer.IGameCallback))]
    public interface IGame {
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/GetData", ReplyAction="TriviaContract/IGame/GetDataResponse")]
        string GetData(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/GetData", ReplyAction="TriviaContract/IGame/GetDataResponse")]
        System.Threading.Tasks.Task<string> GetDataAsync(int value);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/GetDataUsingDataContract", ReplyAction="TriviaContract/IGame/GetDataUsingDataContractResponse")]
        TriviaClient.TriviaServer.CompositeType GetDataUsingDataContract(TriviaClient.TriviaServer.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/GetDataUsingDataContract", ReplyAction="TriviaContract/IGame/GetDataUsingDataContractResponse")]
        System.Threading.Tasks.Task<TriviaClient.TriviaServer.CompositeType> GetDataUsingDataContractAsync(TriviaClient.TriviaServer.CompositeType composite);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/setId", ReplyAction="TriviaContract/IGame/setIdResponse")]
        int setId();
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/setId", ReplyAction="TriviaContract/IGame/setIdResponse")]
        System.Threading.Tasks.Task<int> setIdAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/startGame", ReplyAction="TriviaContract/IGame/startGameResponse")]
        void startGame();
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/startGame", ReplyAction="TriviaContract/IGame/startGameResponse")]
        System.Threading.Tasks.Task startGameAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/getQuestion", ReplyAction="TriviaContract/IGame/getQuestionResponse")]
        TriviaClient.TriviaServer.Question getQuestion();
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/getQuestion", ReplyAction="TriviaContract/IGame/getQuestionResponse")]
        System.Threading.Tasks.Task<TriviaClient.TriviaServer.Question> getQuestionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/setReady", ReplyAction="TriviaContract/IGame/setReadyResponse")]
        void setReady(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/setReady", ReplyAction="TriviaContract/IGame/setReadyResponse")]
        System.Threading.Tasks.Task setReadyAsync(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/setAnswer", ReplyAction="TriviaContract/IGame/setAnswerResponse")]
        void setAnswer(int playerId, int answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/setAnswer", ReplyAction="TriviaContract/IGame/setAnswerResponse")]
        System.Threading.Tasks.Task setAnswerAsync(int playerId, int answer);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/leave", ReplyAction="TriviaContract/IGame/leaveResponse")]
        void leave(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/leave", ReplyAction="TriviaContract/IGame/leaveResponse")]
        System.Threading.Tasks.Task leaveAsync(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/restart", ReplyAction="TriviaContract/IGame/restartResponse")]
        void restart(int playerId);
        
        [System.ServiceModel.OperationContractAttribute(Action="TriviaContract/IGame/restart", ReplyAction="TriviaContract/IGame/restartResponse")]
        System.Threading.Tasks.Task restartAsync(int playerId);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="TriviaContract/IGame/startGameInClient")]
        void startGameInClient(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IGameChannel : TriviaClient.TriviaServer.IGame, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GameClient : System.ServiceModel.DuplexClientBase<TriviaClient.TriviaServer.IGame>, TriviaClient.TriviaServer.IGame {
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public GameClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public string GetData(int value) {
            return base.Channel.GetData(value);
        }
        
        public System.Threading.Tasks.Task<string> GetDataAsync(int value) {
            return base.Channel.GetDataAsync(value);
        }
        
        public TriviaClient.TriviaServer.CompositeType GetDataUsingDataContract(TriviaClient.TriviaServer.CompositeType composite) {
            return base.Channel.GetDataUsingDataContract(composite);
        }
        
        public System.Threading.Tasks.Task<TriviaClient.TriviaServer.CompositeType> GetDataUsingDataContractAsync(TriviaClient.TriviaServer.CompositeType composite) {
            return base.Channel.GetDataUsingDataContractAsync(composite);
        }
        
        public int setId() {
            return base.Channel.setId();
        }
        
        public System.Threading.Tasks.Task<int> setIdAsync() {
            return base.Channel.setIdAsync();
        }
        
        public void startGame() {
            base.Channel.startGame();
        }
        
        public System.Threading.Tasks.Task startGameAsync() {
            return base.Channel.startGameAsync();
        }
        
        public TriviaClient.TriviaServer.Question getQuestion() {
            return base.Channel.getQuestion();
        }
        
        public System.Threading.Tasks.Task<TriviaClient.TriviaServer.Question> getQuestionAsync() {
            return base.Channel.getQuestionAsync();
        }
        
        public void setReady(int playerId) {
            base.Channel.setReady(playerId);
        }
        
        public System.Threading.Tasks.Task setReadyAsync(int playerId) {
            return base.Channel.setReadyAsync(playerId);
        }
        
        public void setAnswer(int playerId, int answer) {
            base.Channel.setAnswer(playerId, answer);
        }
        
        public System.Threading.Tasks.Task setAnswerAsync(int playerId, int answer) {
            return base.Channel.setAnswerAsync(playerId, answer);
        }
        
        public void leave(int playerId) {
            base.Channel.leave(playerId);
        }
        
        public System.Threading.Tasks.Task leaveAsync(int playerId) {
            return base.Channel.leaveAsync(playerId);
        }
        
        public void restart(int playerId) {
            base.Channel.restart(playerId);
        }
        
        public System.Threading.Tasks.Task restartAsync(int playerId) {
            return base.Channel.restartAsync(playerId);
        }
    }
}
