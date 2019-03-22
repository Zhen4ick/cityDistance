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
        //Для инициализации массива
       public static void initializeArray()
       {
            for(int i = 0; i < cities.Length; i++)
            {
                cities[i] = new City();
            }       
            //Координаты
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
                                 
            //Имена городов
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
            Console.WriteLine("0.Saint-Petersburg\t1.Tokyo\t2.Moscow\t3.Bejing\t4.London\t5.Paris\n6.New York\t        7.Mexico\t        " +
           "8.Kair\t        9.Singapur");
            string choice = Console.ReadLine();
            while (true)
            {
                //Логику сюды
            }
            
        }

    }
}
