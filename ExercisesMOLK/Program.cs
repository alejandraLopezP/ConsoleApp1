using System;
using System.Data;
using System.Runtime.CompilerServices;
using static System.Console;

namespace ExercisesMOLK
{
    class Program
    {
        private static void RunExerciseOne()
        {


            string name = "Alejandra", street = "Askebygatan 10", zip_city = "60345";

            //WriteLine("*******************");
            //WriteLine($"*   {Name}    *\n *     {street}      *\n *     {zip_city}  *\n");
            //WriteLine("*******************");
            BackgroundColor = ConsoleColor.Blue;//el color se establece antes del WriteLine sino no funciona
            ForegroundColor = ConsoleColor.Yellow;
            Clear();
            SetCursorPosition(15, 15);
            WriteLine("*******************");
            WriteLine("* {0,-16} *", name);
            WriteLine("* {0,-16} *", street);
            WriteLine("* {0,-16} *", zip_city);
            WriteLine("*******************");
            
            
            ReadLine();
        }

        private static void RunExerciseOneOne()
        {
             string name = "Alejandra", street = "Askebygatan 10", zip_city = "60345";

        
            BackgroundColor = ConsoleColor.Blue;//el color se establece antes del WriteLine sino no funciona
            ForegroundColor = ConsoleColor.Yellow;
            Clear();
            SetCursorPosition(15, 15);//esta posicion afecta al de abajo o sea a la linea de *******
            WriteLine("*******************");
            SetCursorPosition(15, 16);//varia la posicion porque si se pone todo en el 15 sale todo en 1 linea, una arriba de otro y solo se vera la 1era linea
            WriteLine("* {0,-16} *", name);
            SetCursorPosition(15, 17);
            WriteLine("* {0,-16} *", street);
            SetCursorPosition(15, 18);
            WriteLine("* {0,-16} *", zip_city);
            SetCursorPosition(15, 19);
            WriteLine("*******************");


            ReadLine();

        }

        private static void RunExerciseOneTwo()
        {
            string name = "Alejandra", street = "Askebygatan 10", zip_city = "60345";

            Write("Ange antal tecken från vänsterkanten: ");
            int left = int.Parse(ReadLine());
            Write("Ange antal tecken från översta kanten: ");
            int top = int.Parse(ReadLine());



            BackgroundColor = ConsoleColor.Blue;//el color se establece antes del WriteLine sino no funciona
            ForegroundColor = ConsoleColor.Yellow;
            Clear();
            SetCursorPosition(left, top);//esta posicion afecta al de abajo o sea a la linea de *******
            WriteLine("*******************");
            SetCursorPosition(left, top+1);//varia la posicion porque si se pone todo en el 15 sale todo en 1 linea, una arriba de otro y solo se vera la 1era linea
            WriteLine("* {0,-16} *", name);
            SetCursorPosition(left, top+2);
            WriteLine("* {0,-16} *", street);
            SetCursorPosition(left, top+3);
            WriteLine("* {0,-16} *", zip_city);
            SetCursorPosition(left, top+4);
            WriteLine("*******************");


            ReadLine();

        }
        private static void RunExerciseOneThree()
        {
            WriteLine("Introduce the diameter value: ");
            double diameter = double.Parse(ReadLine());
            double perimeter = Math.PI * diameter;
            double area = Math.Pow(Math.PI * (diameter / 2), 2);
            //double area = Math.PI * Math.Pow(2, radio);
            WriteLine($"A circle with diameter {diameter} has:");
            WriteLine("This perimeter value: " + perimeter.ToString("F2") );// el F2 es una funcion para q solo salgan 2 decimales
            WriteLine($"This area value: {area}");
            ReadLine();
        }

        private static void RunExerciseOneFive()
        {
            WriteLine("Introduce X1=");
            double x1 = double.Parse(ReadLine());
            WriteLine("Introduce Y1=");
            double y1 = double.Parse(ReadLine());
            WriteLine("Introduce X2=");
            double x2 = double.Parse(ReadLine());
            WriteLine("Introduce Y2=");
            double y2 = double.Parse(ReadLine());
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            WriteLine($"The distance between point1 and point2 is:{result}");
            ReadLine();
        }

        private static void RunExerciseTwo()
        {
            WriteLine("Introduce speed: ");
            int speed = int.Parse(ReadLine());

            if (speed <=30)
            {
                WriteLine("Du kör lagligt!");
            }
            else if (speed <= 40)
            {
                WriteLine("Du har kört för fort och får böta 2000 kr!");
            }
            else if (speed <= 50)
            {
                WriteLine("Du har kört för fort och får böta 3000 kr!");
            }
            else
            {
                WriteLine("Du har kört för fort och får böta 5000 kr! Dessutom bli du av med körkortet");
            }

            ReadLine();
        }

        private static void RunExerciseTwoOne()
        {
            WriteLine("Introduce speed: ");
            int speed = int.Parse(ReadLine());

            if (speed <= 30)
            {
                WriteLine("Tack! Du är en bra förare");
            }
            else if (speed > 30 && speed <= 40)
            {
                WriteLine("Du har kört för fort och får böta 2000 kr!");
            }
            else if (speed > 40 && speed <= 50)
            {
                WriteLine("Du har kört för fort och får böta 3000 kr!");
            }
            else
            {
                WriteLine("Du har kört för fort och får böta 5000 kr! Dessutom bli du av med körkortet");
            }
        }

        private static void RunExerciseTwoTwo()
        {
            WriteLine("Introduce speed: ");
            int speed = int.Parse(ReadLine());
            int resultSpeed = (speed-30);//no 50 por que?

            if (resultSpeed >= 16 && resultSpeed<= 20)
            {
                WriteLine("Hej då körkort för 1 mån!");
            }
            else if (resultSpeed >= 21 && resultSpeed <= 30)
            {
                WriteLine("Hej då körkort för 2 mån!");
            }
            else if (resultSpeed >= 31 && resultSpeed <= 40)
            {
                WriteLine("Hej då körkort för 3 mån!");
            }
            else if (resultSpeed >= 41 && resultSpeed <= 50)
            {
                WriteLine("Hej då körkort för 4 mån!");
            }
            else if (resultSpeed >= 51 && resultSpeed <= 60)
            {
                WriteLine("Hej då körkort för 5 mån!");
            }
            else if (resultSpeed >= 61 && resultSpeed <= 70)
            {
                WriteLine("Hej då körkort för 6 mån!");
            }
            else
            {
                WriteLine("Ta din cykel baby!");
            }

            ReadLine();

        }

        private static void RunExerciseTwoThree()
        {
            WriteLine("Introduce a positive integer number: ");
            int number = int.Parse(ReadLine());
           
          
            //is number even?
            if (number % 2 == 0 && number > 0)
            {
                Console.WriteLine("Talet {0} är jämnt.", number);
            }
            else if (number % 2 != 0 && number > 0)
            {
                WriteLine("Talet {0} är udda", number);
            }
            else
            {
                WriteLine("Sorry, write a positive integer number!");
            }


            //stop until user press a key
            Console.ReadKey();
        }

        private static void RunExerciseTwoFour()
        {
            string day;
            WriteLine("Skriv in veckodag: ");
            day = ReadLine().ToLower();
            //day = day.ToLower(); ESTE Y EL DE ARRIBA HACEN LO MISMO
            switch (day)
            {
                case "måndag": WriteLine(1); break;
                case "tisdag": WriteLine(2); break;
                case "onsdag": WriteLine(3); break;
                case "torsdag": WriteLine(4); break;
                case "fredag": WriteLine(5); break;
                case "lördag": WriteLine(6); break;
                case "söndag": WriteLine(7); break;
                default: WriteLine(-1); break;

            }

        }
        static void Main(string[] args)
        {

            bool keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseOneOne();
                            break;
                        case 3:
                            RunExerciseOneTwo();
                            break;
                        case 4:
                            RunExerciseOneThree();
                            break;
                        //case 5:
                        //    RunExerciseOneFour();
                        //    break;
                        case 6:
                            RunExerciseOneFive();
                            break;
                        case 7:
                            RunExerciseTwo();
                            break;
                        case 8:
                            RunExerciseTwoOne();
                            break;
                        case 9:
                            RunExerciseTwoTwo();
                            break;
                        case 10:
                            RunExerciseTwoThree();
                            break;
                        case 11:
                            RunExerciseTwoFour();
                            break;


                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue..");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch (Exception e)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(e.Message);
                    Console.ResetColor();
                }
            }

        }
    }

}

