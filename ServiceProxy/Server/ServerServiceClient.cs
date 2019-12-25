using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.Text;
using System.Threading.Tasks;
using WCF.Datas;
using WCF.Interfaces;

namespace ServiceProxy
{
    public sealed class ServerServiceClient : DuplexClientBase<IServerOperator>, IServerOperator
    {
        public ServerServiceClient(InstanceContext callBackInstance) : base(callBackInstance)
        {

        }

        public ServerServiceClient(InstanceContext callBackInstance, ServiceEndpoint endpoint) : base(callBackInstance, endpoint)
        {
            
        }
        public ServerServiceClient(InstanceContext callBackInstance, string endpointConfiguratonName) : base(callBackInstance, endpointConfiguratonName)
        {
        }
        public ServerServiceClient(InstanceContext callBackInstance, string endpointConfiguratonName, string remoteAddress) : base(callBackInstance, endpointConfiguratonName, remoteAddress)
        {

        }
        public void Join(ClientData client)
        {
            try
            {
                base.Channel.Join(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
        }
        public void Exit()
        {
            try
            {
                base.Channel.Exit();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);                
            }
           
        }
        public void Add(double x, double y)
        {
            base.Channel.Add(x, y);
        }
        public void Send(string testBeatHea)
        {
            base.Channel.Send(null);
        }
    }
}
