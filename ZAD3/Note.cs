using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
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

        private void setAuthor(String author)
        {
            this.author = author;
        }
        public void setText(String text)
        {
            this.text = text;
        }
        public void setImportance_level(int importance_level)
        {
            this.importance_level = importance_level;
        }
        public String getAuthor()
        {
            return author;
        }
        public String getText()
        {
            return text;
        }
        public int getImportance_level()
        {
            return importance_level;
        }
    }
}
