using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utility.Tools
{
    public static class PathHelper
    {
        public static string GetStartupPath()
        {
            return AppDomain.CurrentDomain.BaseDirectory;
        }
    }
}
