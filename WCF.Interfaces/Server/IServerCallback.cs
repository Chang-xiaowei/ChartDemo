using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace WCF.Interfaces
{
    public interface IServerCallback
    {
        [OperationContract(IsOneWay = true)]
        void Display(double result);
    }
}
