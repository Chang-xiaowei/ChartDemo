using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.ServiceModel;
using WCF.Datas;
using WCF.Interfaces;

namespace ChatServerModule
{

    [ServiceBehavior(InstanceContextMode =InstanceContextMode.Single,
                     AddressFilterMode=AddressFilterMode.Any,
                     ConcurrencyMode = ConcurrencyMode.Multiple)]
    public class ServerOperatorService : IServerOperator,IDisposable
    {
        #region - Variables 
        private List<string> mClientListenList = new List<string>();
        private ServerCore mServerCore = ServerCore.GetInstance();
        private ConcurrentDictionary<string,ClientData> mClientDatadics = new ConcurrentDictionary<string, ClientData>();//管理多个客户端队列
        #endregion

        #region - Properties -

        #endregion
            
        #region - Constructors -

        #endregion

        #region - public Functions -
        //public void Add(double x, double y)
        //{
        //    double result = x + y;
        //    OperationContext.Current.GetCallbackChannel<IServerCallback>().Display(result);           
        //}

        public void Dispose()
        {
            //
        }

        public void Exit()
        {
            string sessionId = OperationContext.Current.SessionId;
            mClientDatadics.TryRemove(sessionId, out ClientData clientData);
            Console.WriteLine($"Exit Connction {DateTime.Now.ToString()}: Name :{clientData.Name }: IP: {clientData.IP}");
        }

        public void Join(ClientData client)
        {
            string sessionID = OperationContext.Current.SessionId;
            if (mClientDatadics.ContainsKey(sessionID))
            {
                Trace.WriteLine($"Existed Client  Name :[{client.Name}] IP:[{client.IP}]");
                return;
            }
            mClientDatadics.TryAdd(sessionID, client);            
            Console.WriteLine("*********************======连接服务的个数****************");
            Console.WriteLine($"[{DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}] Join  Name [{client.Name}] IP [{client.IP}]");
            Console.WriteLine("Listener count:" + mClientDatadics.Count().ToString());         
        }

        public void Send(string msg)
        {
            OperationContext.Current.GetCallbackChannel<IServerCallback>().SendData(msg);
            mServerCore.Send(msg);//发送给其他客户端
        }
        #endregion

        #region - Private Functions -

        #endregion

        #region - Private Functions -

        #endregion

        #region - Events Functions -

        #endregion


    }
}
