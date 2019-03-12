﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain_Layer.Appendices;

namespace Domain_Layer.Compensations
{
    public abstract class Compensation : ISavable
    {
        protected static readonly string ConnectionString = Properties.Settings1.Default.DB_ConnectionString;
        public int Id { get; internal set; }
        protected readonly List<Appendix> appendices = new List<Appendix>();
        public readonly string Title;
        internal readonly Employee Employee;

        protected Compensation(string title, Employee employee)
        {
            Title = title;
            Employee = employee;
        }

        public void AddAppendix(Appendix expense)
        {
            appendices.Add(expense);
        }

        public void RemoveAppendix(Appendix expense)
        {
            appendices.Remove(expense);
        }

        public abstract List<Appendix> GetAppendices();

        public int CountAppendices()
        {
            return appendices.Count;
        }

        public abstract void Save();
    }
}
