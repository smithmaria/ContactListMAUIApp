using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactListApp
{
    public class ContactGroup : List<Contact>
    {
        public string Key { get; set; }
        public ContactGroup(string key, List<Contact> contacts) : base(contacts)
        {
            Key = key;
        }
    }
}
