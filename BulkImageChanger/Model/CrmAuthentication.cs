using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkImageChanger.Model
{
    public class CrmAuthentication
    {
        public string Server { get; set; }

        public string Port { get; set; }

        public DeploymentType DeploymentType { get; set; }

        public AuthenticationType AuthenticationType { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }
        public string Domain { get; set; }
        public bool UseSsl { get; set; }

    }

    public enum DeploymentType { OnPremise, Online, Office365 };

    public enum AuthenticationType { ActiveDirectory, IFD }
}
