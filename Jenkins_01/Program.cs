using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jenkins_01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage());
        }

        public static string createMessage()
        {
            return DateTime.Today.ToString("dd/MM/yyyy");
        }
    }
}
