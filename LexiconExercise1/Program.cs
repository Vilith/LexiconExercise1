/*
1. Registret skall kunna ta emot och lagra anställda med namn och lön. (Via inmatning i konsolen, inget krav på persistent lagring).
2. Programmet skall kunna skriva ut registret i en konsol.


Uppgift 1 - Vilka klasser bör ingå i programmet?
2 En klass för Anställda och en för Registret

Uppgift 2 - Vilka attribut och metoder bör ingå i dessa klasser?
Anställda.cs
string (anställda), double (lön) - Konstruktor (skapa anställda), ToString() för att skriva ut informationen

Registret.cs
List<> Anställda (Listan med de anställda)
"AddAnställda

Uppgift 3 - Skriva programmet.
*/

namespace LexiconExercise1
{
    internal class Program
    {
        static EmployeeRegister eR = new EmployeeRegister();
        static void Main(string[] args)
        {

            //EmployeeRegister register = new EmployeeRegister();

            while (true)
            {
                Console.WriteLine("""
                    Pick an option:

                    1. Add employee
                    2. Show register
                    3. Quit

                    """);

                string input = Console.ReadLine();

                switch (input)
                {
                    case "1":

                        Console.WriteLine("\nEnter name: ");
                            string name = Console.ReadLine();

                        Console.WriteLine("\nEnter salary: ");

                        if (double.TryParse(Console.ReadLine(), out double salary))
                        {
                            eR.AddEmployee(name, salary);
                            Console.WriteLine("\nEmployee added!");
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid input. Please try again!");
                        }
                        break;
                                                    

                    case "2":
                        
                        eR.PrintEmployees();
                        break;


                    case "3":

                        Console.WriteLine("Quitting program!");
                        break;


                    default:
                        Console.WriteLine("Invalid input!");
                        break;

                }
            }
        }
    }
}
