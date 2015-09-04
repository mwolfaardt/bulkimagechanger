
namespace BulkImageChanger.Connector.Crm.Model
{

    using Microsoft.Practices.Prism.Mvvm;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using System.ComponentModel.DataAnnotations;

    public class CrmAuthenticationModel : BindableBase
    {
        private string username;
        private string password;

        public AuthenticationType AuthenticationType { get; set; }
        public DeploymentType DeploymentType { get; set; }

        public string Server { get; set; }
        public string Port { get; set; }

        [Required(ErrorMessage="Username is required")]
        public string Username
        {
            get { return username; }
            set
            {
                SetProperty(ref username, value);
                OnPropertyChanged("Username");
            }
        }

        [Required]
        public string Password
        {
            get { return password; }
            set
            {
                SetProperty(ref password, value);
            }
        }

        public string Domain { get; set; }

        public bool UseSsl { get; set; }

    }

    public enum DeploymentType { OnPremise, Online, Office365 };

    public enum AuthenticationType { ActiveDirectory, IFD }
}

