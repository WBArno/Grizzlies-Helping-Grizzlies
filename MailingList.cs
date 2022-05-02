using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grizzlies_Helping_Grizzlies
{
    internal class MailingList
    {
        public string EmailAddress { get; set; }

        public MailingList()
        {
            EmailAddress = "";
        }
        public MailingList(string emailAddress)
        {
            EmailAddress = emailAddress;
        }
    }
}
