using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    abstract class Expense
    {
        public DateTime Date;
        public int Amount;
        public string Title;
        public string Description;
    }
}
