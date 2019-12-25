using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Datas
{
    [DataContract] 
   public class ClientData
    {
        [DataMember]
        public string Name { get; set; }
        [DataMember]
        public string IP { get; set; }

        [DataMember]
        public string Port { get; set; }
    }
}
