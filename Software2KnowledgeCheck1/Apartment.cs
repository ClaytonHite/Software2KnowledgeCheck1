using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class Apartment : Building
    {
        public Apartment(int numberOfUnits, int numberOfOpenUnits, bool hasParking, City city)
        {
            NumberOfUnits = numberOfUnits;
            NumberOfOpenUnits = numberOfOpenUnits;
            HasParking = hasParking;
            CreateBuilding(this, city);
        }
        public int NumberOfUnits { get; set; }
        public int NumberOfOpenUnits { get; set; }
        public bool HasParking { get; set; }

        public override void CreateBuilding(Building building, City city)
        {
            ConstructionLogic cL = new ConstructionLogic();
            cL.CreateBuilding(building, city);
        }
    }
}
