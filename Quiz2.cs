using System;

using System.Collections.Generic;
namespace Test_2
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRose();
            PrintSunflower();
        }
        static void PrintRose()
        {
        
        }
        static void PrintSunflower()
        {

        }
        class Rose
        {
            public int ID;
            public string Plant;
            public string Explean;
            public int NumPlant;
            public string HighPlant;
            public string Circumference;
            public Rose(int id,string plant, string explean, int numplnt, string highplant, string circumferences)
            {
                this.ID = id;
                this.Plant = plant;
                this.Explean = explean;
                this.NumPlant = numplnt;
                this.HighPlant = highplant;
                this.Circumference = circumferences;
            }
        }
        class Sunflower
        {
            public int ID;
            public string Plant;
            public string Explean;
            public int NumPlant;
            public string HighPlant;
            public string Circumference;

            public Sunflower(int id, string plant, string explean, int numplnt, string highplant, string circumferences)
            {
                this.ID = id;
                this.Plant = plant;
                this.Explean = explean;
                this.NumPlant = numplnt;
                this.HighPlant = highplant;
                this.Circumference = circumferences;
            }

        }

    }
}
