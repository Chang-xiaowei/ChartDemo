using Module.ManagerCenter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatServerModule
{
    public class ServerCore
    {
        #region - Variables 
        private static ServerCore mInstance = new ServerCore();
        private static ServerManagerCenter mManageCenter = ServerManagerCenter.GetInstance();
        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -

        #endregion

        #region - public Functions -
        public static ServerCore GetInstance()
        {
            return mInstance;
        }
        public void Send(string data)
        {                    
            mManageCenter.Send(data);
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
