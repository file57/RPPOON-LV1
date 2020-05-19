using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZAD3
{
    class Program
    {
        static void Main(string[] args)
        {
            Note zabiljeska1 = new Note();
            Note zabiljeska2 = new Note("ovaj text", "Veliki autor");
            Note zabiljeska3 = new Note("Jos jedan text", 5, "Mali autor");

            Console.WriteLine("autor zabiljeske1 je {0}, a tekst joj je {1};\n", zabiljeska1.getAuthor(), zabiljeska1.getText());
            Console.WriteLine("autor zabiljeske2 je {0}, a tekst joj je {1};\n", zabiljeska2.getAuthor(), zabiljeska2.getText());
            Console.WriteLine("autor zabiljeske3 je {0}, a tekst joj je {1};\n", zabiljeska3.getAuthor(), zabiljeska3.getText());

        }
    }
}
