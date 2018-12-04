﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Expense
{
    public abstract class Expense
    {
        public int Id;
        public DateTime Date;
        public int Amount;
        public string Title;
        public string Description;
    }
}
