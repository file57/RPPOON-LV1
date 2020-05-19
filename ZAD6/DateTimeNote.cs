using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD6
{
    class DateTimeNote : Note
    {
        public DateTime dateTime { get; set; }

        public DateTimeNote() : base() { this.dateTime = DateTime.Now; }

        public DateTimeNote(string text, string author, int importance_level, DateTime dateTime) : base(text, importance_level, author)
        {
            this.dateTime = dateTime;
        }

        public override string ToString()
        {
            return base.ToString() + ", vrijeme zabilješke: " + this.dateTime;
        }
    }
}
