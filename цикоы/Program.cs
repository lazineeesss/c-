using System;

namespace project
{

    class Program
    {

        static void Main()
        {
            /* for(int i = 200; i > 10; i++)
             {
                 Console.WriteLine("элемент: {0}", i);

             }*/
            /*  int i=0; 
               while(i <= 10)
               {
                   Console.WriteLine("элемент: {0}", i);
                   i++;    
               }*/

            /* bool isHasCar = true;
             while (isHasCar)
             {
                 string end = Console.ReadLine();
                 if(end == "end")
                     isHasCar = false;
             }*/
           /* byte i = 100;
            do
            {
                Console.WriteLine("element: " + i);
            } while (i <10);*/

            for(short i = 0; i < 10; i++)
            {

                //if(i >5 ) break;

                if(i%2 == 0)
                    continue;

                Console.WriteLine("element" +i);
            }

        }

    }

}