using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase01
{
    class TryCatch
    {
        public void eskeler()
        {
            while (true)
            {
                System.Console.WriteLine("Ingresar un número");
                try
                {
                    int i = int.Parse(System.Console.ReadLine());
                    switch (i)
                    {
                        case 0:
                        case 1:
                        case 2:
                            {
                                System.Console.WriteLine("Low number");
                                break;
                            }
                        case 3:
                        case 4:
                        case 5:
                            {
                                System.Console.WriteLine("Medium number");
                                break;
                            }
                        default:
                            {
                                System.Console.WriteLine("Other number");
                                break;
                            }
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("Error! - " + e.Message);
                }
            }
        }
    }
}

