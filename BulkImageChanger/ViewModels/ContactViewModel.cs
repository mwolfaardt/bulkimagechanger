using BulkImageChanger.Model;
using Microsoft.Practices.Prism.Mvvm;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkImageChanger.ViewModels
{
    public class ContactViewModel : BindableBase
    {
        private Contact contact;

        public Contact Contact
        {
            get { return this.contact; }
            set { SetProperty(ref this.contact, value); }
        }

        public List<Contact> Contacts { get; private set; }


        public ContactViewModel()
        {
            this.Contact = new Contact();
            // Todo: get all contacts
            this.Contacts = DummyContact();
        }

        private List<Contact> DummyContact()
        {
            List<Contact> dc = new List<Model.Contact>();
            Contact c = new Contact
            {
                Email = "abc@abc.com",
                FullName = "John Doe"
            };
            dc.Add(c);
            c = new Contact
            {
                Email = "a11bc@abc.com",
                FullName = "Joe Apple"
            };
            dc.Add(c);
            return dc;
        }
    }
}
