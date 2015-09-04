
namespace BulkImageChanger.Connector.Crm.ViewModels
{

    using BulkImageChanger.Connector.Crm.Model;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
    using Microsoft.Practices.Prism.Mvvm;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class CrmAuthenticationViewModel : BindableBase
    {
        private CrmAuthenticationModel crmAuthentication;
        public ICommand AuthenticateCommand { get; private set; }
        public ICommand CancelCommand { get; private set; }
      

        public CrmAuthenticationModel CrmAuthentication
        {
            get
            {
                return this.crmAuthentication;
            }
            set
            {
                SetProperty(ref this.crmAuthentication, value);
            }
        }
        public CrmAuthenticationViewModel()
        {
            this.crmAuthentication = new CrmAuthenticationModel();
            this.AuthenticateCommand = new DelegateCommand<object>(this.Authenticate);
            this.CancelCommand = new DelegateCommand<object>(this.Cancel);
           
        }

        private void Cancel(object obj)
        {
            string xx = "ss";
        }

        private void Authenticate(Object obj)
        {

        }
    }
}
