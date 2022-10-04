using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    class Program
    {
        static int ApartmentsToBuild = 15;
        static int HighRisesToBuild = 5;
        static void Main(string[] args)
        {
            City myCityToBuild = new City();

            for (int i = 0; i < ApartmentsToBuild; i++)
            {
                new Apartment(20, 10, true, myCityToBuild);
            }
            List<string> directory = new List<string>();
            for (int i = 0; i < HighRisesToBuild; i++)
            {
                new HighRise(40,"Clay", directory, myCityToBuild);
            }
            Console.ReadKey();

        }
    }
}