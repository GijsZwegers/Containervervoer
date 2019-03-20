using System.Collections.Generic;

namespace Containervervoer.Classes
{
    /// <summary>
    /// Deckplace[0] is Width Deckplace[1] is Length
    /// </summary>
    public class DeckPlace
    {
        //X is length Y is width
        public int[] Location { get; set; }
        public int Weight { get; set; }

        public List<Container> Containers { get; set; } = new List<Container>();

        public DeckPlace(int x, int y, int weight)
        {
            Location = new int[] { x, y };
            Weight = weight;
        }

        public bool CheckIfContainerCanBeAdded(Container container)
        {
            if (Weight - container.Weight < 0)
                return false;

            return true;
        }

        public bool AddContainer(Container container)
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

        public bool RemoveContainer(Container container)
        {
            if (!Containers.Remove(container))
                return false;

            //Add the weight of the container back to the Deckplace
            Weight = Weight + container.Weight;

            return true;
        }

        //public List<Container> SortConainers(List<Container> containers)
        //{
        //    return Containers;
        //}
    }
}