using Containervervoer.Classes.Enumerations;

namespace Containervervoer.Classes
    
{
    public class Container
    {
        public ContainerType Type;
        public int Weight { get; set; }

        public Container(ContainerType containerType, int weight)
        {
            //Check if weight is correct else throw not ImplentedException
            if (weight < 4000 || weight > 30000)
            {
                throw new System.NotImplementedException("Gewicht kan niet onder de 4000 of onder de 30.000kg zijn");
            }

            Type = containerType;
            Weight = weight;
        }
    }
}