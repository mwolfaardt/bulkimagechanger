
namespace BulkImageChanger.ViewModels
{

    using BulkImageChanger.Connector.Crm.ViewModels;
using BulkImageChanger.Connector.Crm.Views;
using BulkImageChanger.ViewModels;
using BulkImageChanger.Views;
using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

    public class ToolbarViewModel : BindableBase
    {
        
        public ToolbarViewModel()
        {
            this.ConnectCommand = new DelegateCommand<Object>(this.OnConnect);
          //  this.CrmAuthenticationViewModel = new CrmAuthenticationViewModel();
        }

        public ICommand ConnectCommand { get; private set; }
        public CrmAuthenticationViewModel CrmAuthenticationViewModel { get; private set; }
      


        private void OnConnect(Object obj)
        {
            //this.CrmAuthenticationViewRequest.Raise(new Notification());
            CrmAuthenticationView cav = new CrmAuthenticationView();
            //CrmAuthenticationViewModel cavm = new CrmAuthenticationViewModel();
            cav.Show();

            
        }
    }
}
