using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD2
{
    class Note
    {
        private String text;
        private String author;
        private int importance_level;
        
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
