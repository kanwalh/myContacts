using System;
using System.Collections.Generic;

namespace myContacts.EntityModel.BusinessEntities
{
    public class Contact
    {
        public string Id { get; set; }

        #region "Primary Details"
        public ContactType Type { get; set; }
        public string DisplayName { get; set; }
        public string GivenName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public List<Phone> Personal { get; set; }
        public List<Address> Addresses { get; set; }
        public List<Email> PersonalEmails { get; set; }
        #endregion

        #region "Professional"
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string YomiCompany { get; set; }
        public string Department { get; set; }
        public List<Address> OfficeLocations { get; set; }
        public string Profession { get; set; }
        public List<Phone> Business { get; set; }
        public List<Email> BusinessEmails { get; set; }
        #endregion

        #region "Contact Management"
        public bool IsFavorite { get; set; }
        public List<Relation> Relations { get; set; }
        public string Notes { get; set; }
        #endregion

        #region "Extended Properties"
        public List<string> Websites { get; set; }
        #endregion

    }
}
