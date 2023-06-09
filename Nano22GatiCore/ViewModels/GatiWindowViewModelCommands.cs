using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Nano22GatiCore.ViewModels
{
    public partial class GatiWindowViewModel
    {
        public ICommand CopyLayerNameToPassportCommand { get; }
        public void OnCopyLayerNameToPassportCommandExecuted(object p)
        {

        }

        public bool CanCopyLayerNameToPassportCommandExecute(object p)
        {
            string value = p as string;
            return !string.IsNullOrEmpty(value);
        }
    }
}
