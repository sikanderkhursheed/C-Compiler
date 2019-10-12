using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c_comp
{
    class parse
    {
        public void func(List <string> OnlyToken)
        {
            int count = 0;
            if (OnlyToken.ElementAt(count) == "type")
            {
                count++;
                if (OnlyToken.ElementAt(count) == "main")
                {
                    count++;
                    if(OnlyToken.ElementAt(count) == "Left Bracket")
                    {
                        count++;
                        if (OnlyToken.ElementAt(count) == "Right Bracket")
                        {
                            count++;
                            if (OnlyToken.ElementAt(count) == "Left Curly Bracket")
                            {
                                count++;
                            }
                            else
                            {
                                Console.WriteLine("Error at line {0}", count);
                            }
                        }
                        else
                        {
                            Console.WriteLine("Error at line {0}", count);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Error at line {0}", count);   
                    }
                }
                else
                {
                    Console.WriteLine("Error at line {0}", count);
                }
            }
            else
            {
                Console.WriteLine("Error at line {0}",count);
            }

        }
    }
}
