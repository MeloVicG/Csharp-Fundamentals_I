using System;

namespace FundamentalsI
{
    class Program
    {
        static void Main(string[] args)
        {
        // A.
        //     for(int i=1; i < 256 ; i++ ){
        //         Console.WriteLine(i);
        //     }
        // }

        //B.
            // for(int i=1; i<=100; i++){
            //     if(i % 3 == 0 && i % 5 == 0){
            //         continue;
            //     }
            //     if(i % 3 == 0){
            //         Console.WriteLine(i);
            //     }
            //     else if(i % 5 == 0){
            //         Console.WriteLine(i);
            //     }
            //     else{
            //         Console.WriteLine("nothing");
            //     }
            // }
        //C.
            string fizz = "Fizz";
            string buzz = "Buzz";
            for(int i=1; i<=16; i++){
                if(i % 3 == 0 && i % 5 == 0){
                    Console.WriteLine(fizz + buzz);
                    Console.WriteLine($"another way: {fizz}{buzz}");
                }
                if(i % 3 == 0){
                    Console.WriteLine(fizz);
                }
                else if(i % 5 == 0){
                    Console.WriteLine(buzz);
                }
                else{
                    Console.WriteLine(i);
                }
            }


        }
    }
}
