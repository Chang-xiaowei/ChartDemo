using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Utility.WpfGUI
{
    public class CommandModel : ObservableObjBase
    {
        private ICommand mCommand = null;
        private bool mIsEnabled = false;
        public CommandModel()
        {

        }
        public ICommand Command
        {
            get { return mCommand; }
            set { SetProperty(ref mCommand, value); }
        }
        public bool IsEnable
        {
            get { return mIsEnabled; }
            set { SetProperty(ref mIsEnabled, value); }
        }

    }
}
