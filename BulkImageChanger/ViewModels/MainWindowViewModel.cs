using Microsoft.Practices.Prism.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace BulkImageChanger.ViewModels
{
    public class MainWindowViewModel
    {
        public MainWindowViewModel()
        {
            this.SubmitCommand = new DelegateCommand<object>(this.OnSubmit);
            this.ResetCommand = new DelegateCommand<object>(this.OnReset);
            this.ContactViewModel = new ContactViewModel();
            this.ToolbarViewModel = new ToolbarViewModel();
        }

        public ICommand SubmitCommand { get; private set; }
        public ICommand ResetCommand { get; private set; }
        public ContactViewModel ContactViewModel { get; set; }
        public ToolbarViewModel ToolbarViewModel { get; set; }

        private void OnSubmit(Object obj)
        {

        }

        private void OnReset(Object obj)
        {

        }
    }
}
