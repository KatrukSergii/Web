using System;
using System.Collections.Generic;

namespace Models
{
    public class Contract
    {
        public string Id
        {
            get;
            set;
        }

        public string Number
        {
            get;
            set;
        }

        public DateTime FromDate
        {
            get;
            set;
        }

        public DateTime ToDate
        {
            get;
            set;
        }

        public List<ContractContactLink> LinkedContacts
        {
            get;
            set;
        } = new List<ContractContactLink>();
    }
}
