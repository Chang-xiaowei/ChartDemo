using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Utility.Tools;
using WCF.Datas;
using WCF.Interfaces;

namespace ServiceProxy
{
    public sealed class ServerServiceProxy : IServerOperator
    {
        #region - Variables 
        private ServerServiceClient mClientFactory = null;
        private static ServerServiceProxy mInstance =new ServerServiceProxy();
        private const string CLIENT_ENPOINT_NAME = "defaultEndpoint";
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -
        private ServerServiceProxy()
        {
          

        }
        #endregion

        #region - public Functions -
        public static ServerServiceProxy GetInstance()
        {
            return mInstance;
        }
        public void Join(ClientData client)
        {
            if (null != mClientFactory)
            {
                return;
            }
            mClientFactory = new ServerServiceClient(new InstanceContext(new ServerCallback()), CLIENT_ENPOINT_NAME);
            try
            {
                mClientFactory.Join(client);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void TestBeatHeart()
        {
            try
            {
                mClientFactory.Send(null);
            }
            catch (Exception ex)
            {

                Console.WriteLine("服务器连接失败"); ;
            }           
        }

        public void Exit()
        {
            if (null!= mClientFactory)
            {
                mClientFactory.Exit();
            }
        }
        public void Add(double x, double y)
        {
            mClientFactory.Add(x, y);
        }
       
        public void Send(string testBeatHeat)
        {
            mClientFactory.Send(testBeatHeat);
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
