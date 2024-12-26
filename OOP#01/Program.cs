using System.Drawing;

namespace OOP_01
{
    internal class Program
    {

        // 1)
        enum WeekDays: byte 
            {
               Monday,Tuesday,Wednesday,Thursday,Friday,Saturday,Sunday 
            }

        // 2)
        class Person
        {
           public String Name;
           public int Age;
        }

        // 3)

        enum Seasons : byte
        {
            Spring, Summer, Autumn, Winter
        }

        // 4)

        enum Permissions
        {
            Read = 1,
            Write = 2,
            Delete = 4,
            Execute = 8
        }

        // 5)

        enum Colors
        {
            Red, Green, Blue
        }

        // 6)

        public class Points
        {
             double X;
             double Y;
        }


        static void Main(string[] args)
        {

            //===== (1)


            //WeekDays[] daysOfWeek = (WeekDays[])Enum.GetValues(typeof(WeekDays));
            //foreach (WeekDays day in daysOfWeek)
            //{
            //    Console.WriteLine(day);
            //}


            //===== (2)


            //Person[] persons = new Person[3];


            //persons[0].Name = "Ahmed";
            //persons[0].Age = 25;

            //persons[1].Name = "Boda";
            //persons[1].Age = 20;

            //persons[2].Name = "Aya";
            //persons[2].Age = 35;



            //foreach (Person person in persons)
            //{
            //    Console.WriteLine("Name: {0}, Age: {1}", person.Name, person.Age);
            //}


            //===== (3)


            //Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter):");
            //string inputSeason = Console.ReadLine();

            //Seasons season;

            //if (Enum.TryParse(inputSeason, true, out season))
            //{
            //    switch (season)
            //    {
            //        case Seasons.Spring:
            //            Console.WriteLine("Spring: March - May");
            //            break;
            //        case Seasons.Summer:
            //            Console.WriteLine("Summer: June - August");
            //            break;
            //        case Seasons.Autumn:
            //            Console.WriteLine("Autumn: September - November");
            //            break;
            //        case Seasons.Winter:
            //            Console.WriteLine("Winter: December - February");
            //            break;
            //        default:
            //            Console.WriteLine("Invalid season entered.");
            //            break;
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("Invalid season entered.");
            //}


            //===== (4)


            //Permissions userPermissions = Permissions.Read | Permissions.Write;


            //userPermissions |= Permissions.Execute;


            //bool hasDeletePermission = (userPermissions & Permissions.Delete) == Permissions.Delete;
            //Console.WriteLine("Has Delete Permission: " + hasDeletePermission);


            //userPermissions &= ~Permissions.Write;


            //hasDeletePermission = (userPermissions & Permissions.Write) == Permissions.Write;
            //Console.WriteLine("Has Write Permission: " + hasDeletePermission);


            //===== (5)

            //Console.Write("Enter The Name Of The Colour: ");
            //String inputColor = Console.ReadLine();

            //Colors color;

            //if (Enum.TryParse(inputColor, true, out color))
            //{
            //    Console.WriteLine($"{inputColor} is a primary color.");
            //}
            //else
            //{
            //    Console.WriteLine($"{inputColor} is not a primary color.");
            //}


            //===== (6)


            //Console.WriteLine("Enter Values for point 1 (X Y):");
            //string[] point1Input = Console.ReadLine().Split(' ');

            //Console.WriteLine("Enter Values for point 2 (X Y):");
            //string[] point2Input = Console.ReadLine().Split(' ');

            //// Parse input coordinates
            //if (double.TryParse(point1Input[0], out double x1) && double.TryParse(point1Input[1], out double y1) &&
            //    double.TryParse(point2Input[0], out double x2) && double.TryParse(point2Input[1], out double y2))
            //{
            //    // Create Point objects
            //    Point point1 = new Point { X = (int)x1, Y = (int)y1 };
            //    Point point2 = new Point { X = (int)x2, Y = (int)y2 };

            //    // Calculate distance using distance formula
            //    double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

            //    Console.WriteLine($"Distance between points: {distance:F2}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid input");
            //}


            //===== (7)

            //Person[] persons = new Person[3];

            //for (int i = 0; i < persons.Length; i++)
            //{
            //    Console.WriteLine($"Enter details for person {i + 1}:");
            //    Console.Write("Name: ");
            //    persons[i].Name = Console.ReadLine();

            //    Console.Write("Age: ");
            //    if (!int.TryParse(Console.ReadLine(), out persons[i].Age))
            //    {
            //        Console.WriteLine("Invalid age. Please enter a valid integer.");
            //        i--; 
            //    }
            //}

            
            //int oldestPersonIndex = 0;
            //for (int i = 1; i < persons.Length; i++)
            //{
            //    if (persons[i].Age > persons[oldestPersonIndex].Age)
            //    {
            //        oldestPersonIndex = i;
            //    }
            //}

            
            //Console.WriteLine("\nOldest Person:");
            //Console.WriteLine($"Name: {persons[oldestPersonIndex].Name}");
            //Console.WriteLine($"Age: {persons[oldestPersonIndex].Age}");












        }
    }
    }

