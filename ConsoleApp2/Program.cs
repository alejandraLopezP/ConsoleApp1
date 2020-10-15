using System;
using static System.Console;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            //prints 25 integers from 0 till 24

            for (int i = 1; i <= 25; i++)
            {
                //is number even?
                if(i % 2 == 0)
                {
                    //print even numbers
                    Write(i + ", ");
                }
              
            }

            int j = 0;
            while (j < 100)
            {
                //is number dividable by 3?
                if(j % 3 == 0)
                {
                    //print even numbers
                    Write(j + ", ");
                }
                j++;//next number
            }

            //prints 80 numbers del 1 al 80 in 8 col y 10 filas(row) OTRO EJERCICIO-NO ESTA AQUI

            //Creat a random generator
            Random rnd = new Random();//esto es un OBJETO
            int randomNumber;

            for (int i = 0; i <= 100; i++)
            {
                //create a random number
                randomNumber = rnd.Next(1, 7);// en este caso toma del 1 al 6, o sea si quiero q tome el 7 debo decirle 8
                //PRINT RANDOM NUMBER
                Write(randomNumber + ", ");
            }
             

            ReadKey();


        }
    }
}
