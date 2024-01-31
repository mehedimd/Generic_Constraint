using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
using System.Text;
using System.Threading.Tasks;

namespace ConstraintGeneric
{
    internal class Student<T> 
    {
        public void Display(T msg)
        {
            Console.WriteLine(msg);
        }

    }
    class Test
    {
        public static void Main()
        {      
            Student<int> student = new Student<int>();
            student.Display(50);
            Student<string> student2 = new Student<string>();
            student2.Display("Hello World");
            

            Console.ReadKey();
        }
    }
}
