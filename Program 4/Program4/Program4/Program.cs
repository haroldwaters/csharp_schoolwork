using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static int reqCount = 0;

        static void Main(string[] args)
        {
            requirementText();
            Console.Title="Program-4";
            Console.WriteLine("This is Program-4");

            requirementText();
            int numCars = 0;
            Console.Write("How many automobiles would you like to make? ");
            numCars = int.Parse(Console.ReadLine());
            Automobile[] cars = new Automobile[numCars];

            string make, model, color;
            for(int i = 0; i < numCars; i++)
            {
                Console.Write("Make: ");
                make = Console.ReadLine(); 
                Console.Write("Model: ");
                model = Console.ReadLine(); 
                Console.Write("Color: ");
                color = Console.ReadLine();

                cars[i] = new Automobile(make, model, color);
                Console.Write("Set automobile speed: ");
                cars[i].setSpeed(int.Parse(Console.ReadLine()));

                Console.WriteLine("You created a {2} {0} {1} travelling at {3}kph.", make,model,color,cars[i].getSpeed());
            }

            requirementText();
            Restaurant res = new Restaurant();
            Console.WriteLine(res.ToString());

            requirementText();
            int numPainting;
            Console.Write("How many Paintings would you like to make? ");
            numPainting = int.Parse(Console.ReadLine());
            Painting[] paintings = new Painting[numPainting];
            string artist, genre, country;
            int year;
            double wholesaleprice;
            for (int i = 0; i < numPainting; i++)
            {

                Console.Write("Artist: ");
                artist = Console.ReadLine();
                Console.Write("Genre: ");
                genre = Console.ReadLine();
                Console.Write("Country: ");
                country = Console.ReadLine();
                Console.Write("Year: ");
                year = int.Parse(Console.ReadLine());
                Console.Write("Wholesale Price: ");
                wholesaleprice = double.Parse(Console.ReadLine());
                paintings[i] = new Painting(artist, genre, country, year, wholesaleprice);
                Console.WriteLine(paintings[i].ToString());
            }


            requirementText();
            Console.WriteLine("Thank you for running Program-4");
            Console.ReadKey(true);


        }

        static void requirementText()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Requirement " + (++reqCount));
            Console.ResetColor();
        }
    }


    class Automobile
    {
        private string make;
        private string model;
        private string color;
        private int speed;

        public Automobile()
        {
            make = "Toyota";
            model = "Corrolla";
            color = "White";
            speed = 100;
        }

        public Automobile(String paramMake, String paramModel, String paramColor)
        {
            make = paramMake;
            model = paramModel;
            color = paramColor;
        }


        public string getMake()
        {
            return make;
        }
        public string getModel()
        {
            return model;
        }
        public string getColor()
        {
            return color;
        }
        public int getSpeed()
        {
            return speed;
        }

        public void setMake(string paramMake)
        {
            make = paramMake;
        }
        public void setModel(string paramModel)
        {
            model = paramModel;
        }
        public void setColor(string paramColor)
        {
            color = paramColor;
        }
        public void setSpeed(int paramSpeed)
        {
            speed = paramSpeed;
        }

        public int increaseSpeed()
        {
            return ++speed;
        }
        public int decreaseSpeed()
        {
            return --speed;
        }

    }
}
