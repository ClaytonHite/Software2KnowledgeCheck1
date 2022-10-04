using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class HighRise : Building
    {
        public HighRise(int numberOfStories, string ownerName, List<string> directory, City city)
        {
            NumberOfStories = numberOfStories;
            OwnerName = ownerName;
            Directory = directory;
            CreateBuilding(this, city);
        }

        public int NumberOfStories { get; set; }
        public string OwnerName { get; set; }
        public List<string> Directory  { get; set; }

        public override void CreateBuilding(Building building, City city)
        {
            ConstructionLogic cL = new ConstructionLogic();
            cL.CreateBuilding(building, city);
        }
    }
}
