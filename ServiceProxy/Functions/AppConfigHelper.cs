using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProxy
{
   public class AppConfigHelper
    {
        private string host = string.Empty;
        ///<summary>
        /// 主机地址
        /// Host = "192.168.0.122";
        ///</summary>
        public string Host
        {
            get
            {
                return host;
            }
            set
            {
                host = value;            
            }
        }

        private int port = 0;
        ///<summary>
        /// 端口号
        ///</summary>
        public int Port
        {
            get
            {
                return port;
            }
            set
            {
                port = value;
            }
        }

        public virtual EndpointAddress GetHotsUrl(EndpointAddress address)
        {
            // 若当前配置都是空的，就不用生成新的URL了。
            if (string.IsNullOrEmpty(Host) && (Port == 0))
            {
                return address;
            }
            // 判断当前配置的情况
            string endpointAddress = string.Empty;
            if (string.IsNullOrEmpty(Host))
            {
                Host = address.Uri.Host;
            }
            if (Port == 0)
            {
                Port = address.Uri.Port;
            }
            endpointAddress = address.Uri.Scheme + "://" + Host + ":" + Port.ToString() + address.Uri.LocalPath;
            address = new EndpointAddress(endpointAddress);
            return address;
        }
    }
}
