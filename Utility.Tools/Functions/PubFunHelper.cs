using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Tools
{
    public static class PubFunHelper
    {
        #region - Variables 

        #endregion

        #region - Properties -

        #endregion

        #region - Constructors -

        #endregion

        #region - public Functions -
        /// 获取本机IPV4地址
        /// </summary>
        /// <returns>IPV4</returns>
        public static string GetLocalIP()
        {
            try
            {
                string HostName = Dns.GetHostName(); //得到主机名
                IPHostEntry ipEntry = Dns.GetHostEntry(HostName);
                for (int i = 0; i < ipEntry.AddressList.Length; i++)
                {
                    //从IP地址列表中筛选出IPv4类型的IP地址
                    //AddressFamily.InterNetwork表示此IP为IPv4,
                    //AddressFamily.InterNetworkV6表示此地址为IPv6类型
                    if (ipEntry.AddressList[i].AddressFamily == AddressFamily.InterNetwork)
                    {
                        string result = ipEntry.AddressList[i].ToString();
                        return result;
                    }
                }
                return string.Empty;
            }
            catch (Exception ex)
            {
                return "获取本机IP出错:" + ex.Message.ToString();
            }
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

