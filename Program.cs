using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;


namespace cityDistance
{
    class Program
    {
        public static City[] cities = new City[10];
        static void Main(string[] args)
        {
            initializeArray();
            findDistance();
            
            Console.ReadLine();
        }
       public class City
       {
            public float x;
            public float y;
            public string name;
       }
       
       public static void initializeArray()
       {
            for(int i = 0; i < cities.Length; i++)
            {
                cities[i] = new City();
            }       
            //Coordinates y
            cities[0].y = 30.335f;//Saint-Petersburg           
            cities[1].y = 139.731f;//Tokyo
            cities[2].y = 37.617f;//Moscow
            cities[3].y = 116.407f;//Bejing
            cities[4].y = -0.127f;//London
            cities[5].y = 2.352f;//Paris
            cities[6].y = -74.005f;//New York
            cities[7].y = -99.133f;//Mexico
            cities[8].y = 31.235f;//Kair
            cities[9].y = 103.819f;//Singapur
            //Coordinates x
            cities[0].x = 59.934f;//Saint-Petersburg 
            cities[1].x = 35.709f;//Tokyo             
            cities[2].x = 55.755f;//Moscow
            cities[3].x = 39.904f;//Bejing
            cities[4].x = 51.507f;//London
            cities[5].x = 48.856f;//Paris
            cities[6].x = 40.712f;//New York
            cities[7].x = 19.432f;//Mexico
            cities[8].x = 30.044f;//Kair
            cities[9].x = 1.352f;//Singapur                                             
            //Names of the ctites
            cities[0].name = "Saint-Petersburg";
            cities[1].name = "Tokyo";
            cities[2].name = "Moscow";
            cities[3].name = "Bejing";
            cities[4].name = "London";
            cities[5].name = "Paris";
            cities[6].name = "New York";
            cities[7].name = "Mexico";
            cities[8].name = "Kair";
            cities[9].name = "Singapur";
       }
        public static void findDistance()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine(FiggleFonts.Standard.Render("                                cityDistance"));
            Console.WriteLine("0.Saint-Petersburg\t1.Tokyo\t                2.Moscow\t3.Bejing\t4.London\t\n5.Paris                 6.New York\t        7.Mexico\t8.Kair\t        9.Singapur");
            Console.ForegroundColor = ConsoleColor.Green;

            string choice;
            int index1 = 0;
            int index2 = 0;
            float c;
            float c2;
            double result;
            int result2;
            while (true)
            {
                Console.WriteLine("Please select the number of first city");
                Console.ForegroundColor = ConsoleColor.Magenta;
                choice = Console.ReadLine();
                for(int i = 0; i < cities.Length; i++)
                {
                    
                    if (choice == i.ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You selected {cities[i].name}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Coordinates:{cities[i].x}-x and {cities[i].y}-y");
                        Console.WriteLine("\nPlease select the number of second city");
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        index1 = i;
                        choice = Console.ReadLine();
                        break;
                    }
                  
                   
                    
                        
                    
                }
                for (int j = 0; j < cities.Length; j++)
                {
                    if(choice == j.ToString())
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"You selected {cities[j].name}");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine($"Coordinates:{cities[j].x}-x and {cities[j].y}-y");                        
                        index2 = j;                       
                        break;

                    }
                   
                   
                }
                Console.WriteLine();
                c = (cities[index2].x - cities[index1].x) * (cities[index2].x - cities[index1].x);
                c2 = (cities[index2].y - cities[index1].y) * (cities[index2].y - cities[index1].y);
                result = Convert.ToDouble(Math.Sqrt(c + c2));
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($@"The distance between {cities[index1].name} and {cities[index2].name} is {result}");
                result2 = Convert.ToInt32(Math.Truncate(result));
                result2 *= 100;
                Console.WriteLine($@"This is about {result2} km");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("Do you want to  continue[y/n]");
                choice = Console.ReadLine();
                if (choice == "y"||choice == "Y")
                {
                    continue;

                }
                else
                {
                    Environment.Exit(0);
                }
                
                
            }
            
        }

    }
}
