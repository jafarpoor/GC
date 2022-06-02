using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GcService.Model
{
    public class Person : IDisposable
    {
        ~Person()
        {
            Console.WriteLine("person class Finalize");
        }

        public void Dispose()
        {
            Console.WriteLine("person class Dispose");
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
       
    }
}
