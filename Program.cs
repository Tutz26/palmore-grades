using System;

namespace FizzBuzz_Plus
{
    class Program
    {
        static void Main(string[] args)
        {
           for(int i = 1; i < 100; i++){
               bool fizz = (i % 3 == 0);
               bool buzz = (i % 5 == 0);

                    switch(fizz, buzz)
                    {
                        case(true, false):
                                Console.WriteLine("Fizz");
                            break;
                        case(false, true):
                                Console.WriteLine("Buzz");
                            break;
                        case(true, true):
                                Console.WriteLine("FizzBuzz");
                            break;
                        case(false,false):
                                Console.WriteLine(i);
                            break;
                    }
           }
       
        }

    }
}

