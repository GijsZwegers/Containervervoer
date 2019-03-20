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
        public List<Container> containers { get; set; } = new List<Container>();
        public Ship ship { get; private set; }

        private List<Container> ValuableContainers { get; set; }
        private List<Container> CooledContainers { get; set; }
        private List<Container> NormalContainers { get; set; }

        public void RunContainervervoerSetup()
        {
            if (ship != null)
            {
                CheckIfSolutionIsPossible();
                TryPlaceAllContainersOnShip();
                CheckIfShipIsCorrectlyBalanced();
            }
        }

        private bool CheckIfShipIsCorrectlyBalanced()
        {
            int test = containers.Sum(o => o.Weight);
            Tuple<int, int> WeightOfShipSides = ship.GetLoadOfShipSides();
            double percentage = CalculateDiffrecnceInPercentage(WeightOfShipSides.Item1, WeightOfShipSides.Item2);
            if (!(percentage < 60 && percentage > 40 || percentage > -60 && percentage < -40))
                return false;

            return true;
        }

        private double CalculateDiffrecnceInPercentage(double left, double right)
        {
            return ((left - right) / right) * 100;
        }

        private void CheckIfSolutionIsPossible()
        {
            ValidationResponse response = ship.CheckPossibilityForSolution(containers);
            if (!response.Successful)
            {
                throw new NotImplementedException(message: response.Information);
            }
        }

        public void AddMultipleContainers(List<Container> containerlist)
        {
            containers.AddRange(containerlist);
        }

        public void TryPlaceAllContainersOnShip()
        {
            ship.PlaceValuableContainers(GetContainersFromListOnContainerType(ContainerType.Valuable));
            ship.PlaceCooledContainers(GetContainersFromListOnContainerType(ContainerType.Cooled));
            ship.PlaceNormalContainers(GetContainersFromListOnContainerType(ContainerType.Normal));
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
