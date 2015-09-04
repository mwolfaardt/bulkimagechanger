namespace BulkImageChanger.ViewModels
{
    using BulkImageChanger.Model;
    using BulkImageChanger.Views;
    using Microsoft.Practices.Prism.Commands;
    using Microsoft.Practices.Prism.Mvvm;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.Windows.Input;

    public class CrmAuthenticationModel : BindableBase
    {
        private CrmAuthentication crmAuthentication;
        public ICommand AuthenticateCommand { get; private set; }


        public CrmAuthentication CrmAuthentication
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
        public CrmAuthenticationModel()
        {
            this.crmAuthentication = new CrmAuthentication();
            this.AuthenticateCommand = new DelegateCommand<object>(this.Authenticate);
        }

        private void Authenticate(Object obj)
        {
            
        }
        
    }
}
