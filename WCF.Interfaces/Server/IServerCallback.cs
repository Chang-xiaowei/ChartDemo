using System.ServiceModel;

namespace WCF.Interfaces
{
    [ServiceContract]
    public interface IServerCallback
    {
        [OperationContract(IsOneWay = true)]      
        void SendData(string msg);
    }
}
