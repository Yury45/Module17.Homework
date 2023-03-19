using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Module17.Homework
{
    internal class AccountPayroll : IAccount
    {
        public double Balance { get; set; }
        public double Interest { get; set; }

        public void CalculateInterests()
        {
            Interest = Balance * 0.5;

        }
    }
}
