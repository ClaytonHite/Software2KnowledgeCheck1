using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Software2KnowledgeCheck1
{
    internal class ConstructionLogic
    {

        public void CreateBuilding(Building building, City city)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<Building>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                city.Buildings.Add(building);
                if(building is Apartment)
                {
                    Console.WriteLine("We made an Apartment.");
                }
                if (building is HighRise)
                {
                    Console.WriteLine("We made a HighRise.");
                }
            }
        }
        public bool ConstructBuilding<T>(List<string> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    if (material == "concrete")
                    {
                        // start laying foundation
                    }
                    else if (material == "Steel")
                    {
                        // Start building structure
                    }
                    // etc etc...

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
