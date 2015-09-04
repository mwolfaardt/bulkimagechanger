
namespace BulkImageChanger.Connector.Crm.Views
{

    using Microsoft.Practices.Prism.Interactivity.InteractionRequest;
    using Microsoft.Practices.Prism.Mvvm;
    using System;
    using System.Windows;
    using System.Windows.Controls;

    /// <summary>
    /// Interaction logic for CrmAuthentication.xaml
    /// </summary>
    public partial class CrmAuthenticationView : Window, IView
    {
        public CrmAuthenticationView()
        {
            InitializeComponent();
        }

        private void txt_Error(object sender, ValidationErrorEventArgs e)
        {
            if (e.Action == ValidationErrorEventAction.Added)
            {
                ((Control)sender).ToolTip = e.Error.ErrorContent.ToString();
            }
            else
            {
                ((Control)sender).ToolTip = "";
            }
        }
    }
}
