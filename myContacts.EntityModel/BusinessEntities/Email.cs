using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myContacts.EntityModel.BusinessEntities
{
    public class Email
    {
        public EmailType Type { get; set; }
        public string Address { get; set; }
    }
}
