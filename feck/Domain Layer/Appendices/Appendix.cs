using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Appendices
{
    public abstract class Appendix : ISavable
    {
        protected static string ConnectionString = Properties.Settings1.Default.DB_ConnectionString;
        public int Id { get; internal set; }
        public readonly string Title;

        protected Appendix(string title)
        {
            Title = title;
        }

        public abstract void Save();
    }
}
