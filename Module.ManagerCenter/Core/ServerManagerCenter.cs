using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module.ManagerCenter
{
    public class ServerManagerCenter
    {
        #region - Variables 
        private static ServerManagerCenter mInsance = new ServerManagerCenter();
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -
        private ServerManagerCenter()
        {

        }
        #endregion

        #region - public Functions -
        public static ServerManagerCenter GetInstance()
        {
            return mInsance;
        }
        public void Send (string data)
        {
            if (null==data )//客户端心跳
            {
                return;
            }
            //todo发送给其他客户端           
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
