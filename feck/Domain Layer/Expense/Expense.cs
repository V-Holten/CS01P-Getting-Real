using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public abstract class Expense
    {
        private DateTime Date;
        private int Amount;
        private string Title;
        private string Description;
    }
}
