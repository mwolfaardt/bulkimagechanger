using BulkImageChanger.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BulkImageChanger.ViewModels
{
    public class ToolbarViewModel: BindableBase
    {
        public ToolbarViewModel()
        {
            this.ConnectCommand = new DelegateCommand<Object>(this.OnConnect);
        }

        public ICommand ConnectCommand { get; private set; }

        private void OnConnect(Object obj)
        {
            CrmAuthenticationView cav = new CrmAuthenticationView();
            cav.Show();
        }
    }
}
