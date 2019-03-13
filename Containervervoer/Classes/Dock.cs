using Containervervoer.Classes.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Classes
{
    class Dock
    {
        public List<Container> containers { get; private set; }
        public Ship ship { get; private set; }

        private List<Container> ValuableContainers { get; set; }
        private List<Container> CooledContainers { get; set; }
        private List<Container> NormalContainers { get; set; }

        public void RunContainervervoerSetup()
        {
            CheckIfSolutionIsPossible();
            TryPlaceAllContainersOnShip();
        }

        private void CheckIfSolutionIsPossible()
        {
            ValidationResponse response = ship.CheckPossibilityForSolution(containers);
            if (!response.Successful)
            {
                throw new NotImplementedException(message: response.Information);
            }
        }


        public void TryPlaceAllContainersOnShip()
        {
            ship.TryPlaceValuableContainers(GetContainersFromListOnContainerType(ContainerType.Valuable));
            ship.TryPlaceCooledContainers(GetContainersFromListOnContainerType(ContainerType.Cooled));
            ship.TryPlaceNormalContainers(GetContainersFromListOnContainerType(ContainerType.Normal));
        }

        private List<Container> GetContainersFromListOnContainerType(ContainerType containerType)
        {
            return containers.Where(c => c.Type.Equals(containerType)).ToList();
        }

        public void CreateShip(int Length, int Width)
        {
            ship = new Ship(Length, Width);
        }

        public void AddContainer(Container container)
        {
            containers.Add(container);
        }

        public void RemoveContainer(Container container)
        {
            containers.Remove(container);
        }
        
    }
}
