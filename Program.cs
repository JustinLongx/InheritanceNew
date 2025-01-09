namespace InheritanceNew
{
    public class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes



            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            var bigBird = new Bird();
            bigBird.FeatherColor = "Yellow";
            bigBird.CanFly = false;
            bigBird.WingSpan = 14;
            bigBird.BeakType = "Conical";

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Here are some of Big Bird's characteristic from the show!");
            Console.WriteLine("---------------------------------------------------------");
            Thread.Sleep(4000); // Pauses the program for 4 seconds (4000 milliseconds)
            Console.WriteLine($"- The color of his feathers are {bigBird.FeatherColor}.");
            Thread.Sleep(2000);
            Console.WriteLine($"Is it true he can fly? ...");
            Thread.Sleep(2000);
            Console.WriteLine($"...");
            Thread.Sleep(2000);
            Console.WriteLine($"- False!");
            Thread.Sleep(2000);
            Console.WriteLine($"- His wingspan is {bigBird.WingSpan} feet in length making him huge!");
            Thread.Sleep(3000);
            Console.WriteLine($"- The last cool characteristic for Big Bird is that he has a {bigBird.BeakType} shaped beak.");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var ninjaTurtle = new Reptile();
            ninjaTurtle.ScaleType = "Rugged";
            ninjaTurtle.IsColdBlooded = true;
            ninjaTurtle.IsVenomous = false;
            ninjaTurtle.Lifespan = 100;



            Thread.Sleep(3000);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine($"Now lets look at some cool facts about Ninja Turtles!");
            Console.WriteLine("---------------------------------------------------------");
            Thread.Sleep(4000);
            Console.WriteLine($"- The Ninja Turtles have {ninjaTurtle.ScaleType} scales.");
            Thread.Sleep(2000);
            Console.WriteLine($"Are they cold blooded? ...");
            Thread.Sleep(2000);
            Console.WriteLine($"...");
            Thread.Sleep(2000);
            Console.WriteLine($"- {ninjaTurtle.IsColdBlooded}!");
            Thread.Sleep(2000);
            Console.WriteLine($"Are they venomous? ...");
            Thread.Sleep(2000);
            Console.WriteLine($"...");
            Thread.Sleep(2000);
            Console.WriteLine($"- {ninjaTurtle.IsVenomous}!");
            Thread.Sleep(2000);
            Console.WriteLine($"- Like most larger species of turtle they can live to be {ninjaTurtle.Lifespan} over years old!");
            Thread.Sleep(2000);
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Please press the Enter key to exit. Thanks!");



            Console.ReadLine();
        }
    }
}
