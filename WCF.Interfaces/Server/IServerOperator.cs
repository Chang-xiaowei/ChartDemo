using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCF.Datas;

namespace WCF.Interfaces
{
    [ServiceContract(SessionMode = SessionMode.Required,
                     CallbackContract = typeof(IServerCallback))]
    public interface IServerOperator
    {
        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = false)]
        void Join(ClientData client);

        [OperationContract(IsOneWay = true, IsInitiating = true, IsTerminating = true)]
        void Exit();

        [OperationContract(IsOneWay = true, IsInitiating = false, IsTerminating = false)]
        void Add(double x, double y);

        [OperationContract(IsOneWay = true)]
        void Send(string testBeatHea);//为了测试心跳
    }
}
