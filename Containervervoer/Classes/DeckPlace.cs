using System.Collections.Generic;

namespace Containervervoer.Classes
{
    public class DeckPlace
    {
        //X is length Y is width
        public int[] Location { get; set; }
        public int Weight { get; set; }

        public List<Container> Containers { get; set; } = new List<Container>();

        public DeckPlace(int x, int y, int weight)
        {
            Location = new int[] { y, x };
            Weight = weight;
        }

        public bool addcontainer(Container container)
        {
            if (Weight - container.Weight < 0)
                return false;
            else
            {
                Weight = Weight - container.Weight;
            }

            Containers.Add(container);

            return true;
        }

        public List<Container> SortConainers(List<Container> containers)
        {
            //Hier komt een functie die de containers sorteert 

            return Containers;
        }
    }
}