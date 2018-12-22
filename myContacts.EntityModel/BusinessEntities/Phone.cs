using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myContacts.EntityModel.BusinessEntities
{
    public class Phone
    {
        public PhoneType Type { get; set; }
        public string Number { get; set; }
    }
}
