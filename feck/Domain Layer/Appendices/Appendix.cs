using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain_Layer.Appendices
{
    public abstract class Appendix : Entry
    {
        public readonly int Id;
        public readonly string Title;

        public Appendix(int id, string title)
        {
            Id = id;
            Title = title;
        }

        public Appendix(string title)
        {
            Title = title;
        }
    }
}
