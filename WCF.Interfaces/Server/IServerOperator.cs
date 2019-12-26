using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Datas;

namespace WCF.Interfaces
{
    [ServiceContract(Name = "ServerOperatorService",
                     SessionMode = SessionMode.Required,                   
                     CallbackContract = typeof(IServerCallback))]
    public interface IServerOperator
    {
        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
        void Join(ClientData client);

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = true)]
        void Exit();

        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
        void Add(double x, double y);

        [OperationContract(IsOneWay = true,IsInitiating =true,IsTerminating =false)]
        void Send(string testBeatHea);//为了测试心跳
    }
}
