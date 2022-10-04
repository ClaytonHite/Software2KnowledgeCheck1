using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    abstract class Building
    {
        public string Street { get; set; }
        public int StreetNumber { get; set; }

        public abstract void CreateBuilding(Building building, City city);
    }
}
