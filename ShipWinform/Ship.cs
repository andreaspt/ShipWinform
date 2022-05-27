using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShipWinform
{
    class Ship
    {

        static int cyclespace = 3;
        static int carspace = 5;
        static int trucklespace = 11;
        static int trainspace = 17;

        public int CyclesCount { get; set; }
        public int CarsCount { get; set; }
        public int TrucksCount { get; set; }
        public int TrainsCount { get; set; }
        public int Capacity { get; set; }

        public Random rnd = new Random();




        public int GetShipLoad()
        {
            int fortio;
            fortio = CyclesCount * cyclespace + CarsCount * carspace + TrucksCount * trucklespace + TrainsCount * trainspace;
            return fortio;
        }


        public Ship()
        {
            CyclesCount = 0;
            CarsCount = 0;
            TrucksCount = 0;
            TrainsCount = 0;
            Capacity = rnd.Next(10)*cyclespace + rnd.Next(10) * carspace+ rnd.Next(10) * trucklespace + rnd.Next(10) * trainspace;

        }

        public int OverUnder()
        {   
            int overUnderNum=0;

            
            if (GetShipLoad() < Capacity)
            {
                overUnderNum = -1;

            }
            else
            {
                overUnderNum = 1;
            }
                                 
            return overUnderNum;
        }


        public int Diafora()
            {
        
        int diaf;
            diaf=GetShipLoad()- Capacity;
            return diaf;
                    
        }

        //public string ToStringA()
        //{
        //    string str;

        //    Console.WriteLine("The ship has " + str );

        //    return str;

        //}
    }
}
