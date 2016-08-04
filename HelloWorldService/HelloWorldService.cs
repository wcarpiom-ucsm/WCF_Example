using System;
using System.Runtime.Serialization;
using System.ServiceModel;

namespace HelloWorldService
{
    [DataContract]
    public class Name
    {
        [DataMember]
        public string First;
        [DataMember]
        public string Last;
    }

    [ServiceContract]
    public interface IHelloWorld
    {
        [OperationContract]
        string SayHello(Name person);
    }

    public class HelloWorldService : IHelloWorld
    {
        public string SayHello(Name person)
        {
            return String.Format("Hello {0} {1}", person.First, person.Last);
        }
    }
}