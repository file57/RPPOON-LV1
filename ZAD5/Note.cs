using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD5
{
    class Note
    {
        private String text;
        private String author;
        private int importance_level;

        public Note(string text, int importance_level, string author)
        {
            this.text = text;
            this.importance_level = importance_level;
            this.author = author;
        }
        public Note()
        {
            this.text = "Tekst";
            this.importance_level = 5;
            this.author = "Autor";
        }
        public Note(string text, string author)
        {
            this.text = text;
            this.importance_level = 2;
            this.author = author;
        }
        public String Text
        {
            get { return this.text; }
            set { this.text = value; }
        }
        public int Importance_level
        {
            get { return this.importance_level; }
            set { this.importance_level = value; }
        }
        public String Author
        {
            get { return this.author; }
            private set { this.author = value; }
        }
        public override string ToString()
        {
            return "tekst: " + text + ", autor: " + author + ", razina vaznosti: " + importance_level + "\n";
        }
    }
}
