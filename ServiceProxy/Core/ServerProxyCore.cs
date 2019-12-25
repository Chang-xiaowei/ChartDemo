using ServiceProxy.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Utility.Tools;
using WCF.Datas;

namespace ServiceProxy
{
    public class ServerProxyCore
    {
        #region - Variables 
        private  ClientData mCurrentClientData = null;
        private ServerServiceProxy mServerServiceProxy = ServerServiceProxy.GetInstance();
        private static ServerProxyCore mInstance = new ServerProxyCore();
        private static ClientCore mCore = ClientCore.GetInstance();
        #endregion

        #region - Properties -
        public ClientData CurrentClient
        {
            get { return mCurrentClientData; }
        }
        #endregion

        #region - Constructors -
        public ServerProxyCore()
        {
            mCurrentClientData = new ClientData();
            mCurrentClientData.IP = PubFunHelper.GetLocalIP();
            mCurrentClientData.Name= Dns.GetHostName();           
            Join();
        }
        #endregion

        #region - public Functions -
        public static ServerProxyCore GetInStance()
        {
            return mInstance;
        }
        public void Add(double x,double y)
        {
            mCore.Add(x,y);
        }
        public void Join()
        {
            mServerServiceProxy.Join(mCurrentClientData);
        }
        public void Exit()
        {
            mServerServiceProxy.Exit();
        }        
        #endregion

        #region - Private Functions -
        private void ConnectServerHeat()
        {
            while (true)
            {
                try
                {
                    mServerServiceProxy.TestBeatHeart();

                }
                catch (Exception)
                {

                    throw;
                }
            }
        }
        #endregion

        #region - Private Functions -

        #endregion

        #region - Events Functions -

        #endregion

    }
}
