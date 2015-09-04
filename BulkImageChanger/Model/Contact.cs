using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkImageChanger.Model
{
    public class Contact
    {
        public Guid Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
    }
}
