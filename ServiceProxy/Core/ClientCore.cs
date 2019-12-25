using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy.Core
{
   public sealed class ClientCore
    {
        //todo 从客户端拿到数据发送到服务器端
        #region - Variables 
        private static ClientCore mInstance = new ClientCore();
        #endregion

        #region - Properties -
        private ServerServiceProxy mServerServiceProxy = ServerServiceProxy.GetInstance();
        #endregion

        #region - Constructors -
        private ClientCore()
        {

        }
        #endregion

        #region - public Functions -
        public static ClientCore GetInstance()
        {
            return mInstance;
        }
        public void Add(double x,double y)
        {
            mServerServiceProxy.Add(x,y);
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
