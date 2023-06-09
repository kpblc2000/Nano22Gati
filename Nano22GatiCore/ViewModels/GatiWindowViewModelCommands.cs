using Nano22GatiCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
            List<LayerToPassport> existNames;
            if (LayerNamesToPassportList != null)
            {
                existNames = new List<LayerToPassport>(LayerNamesToPassportList);
            }
            else
            {
                existNames = new List<LayerToPassport>();
            }
            existNames.Add(new LayerToPassport()
            {
                Name = p as string,
                Precision = SelectedPrecision,
            });
            LayerNamesToPassportList = new List<LayerToPassport>(existNames.OrderBy(o => o.Name));
        }

        public bool CanCopyLayerNameToPassportCommandExecute(object p)
        {
            string value = p as string;
            return !string.IsNullOrEmpty(value);
        }
    }
}
