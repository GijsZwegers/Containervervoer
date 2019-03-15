using Containervervoer.Classes.Enumerations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Containervervoer.Classes
{
    public class Ship
    {

        public int Lenght { get; private set; }
        public int Width { get; private set; }
        public int ShipMaxWeight { get; private set; }

        public int MaxDeckLoad = 150000;
        private int Valuablemultiplier = 2;

        public List<DeckPlace> DeckPlaces { get; set; } = new List<DeckPlace>();

        public Ship(int length, int width)
        {
            Lenght = length;    //Double?
            Width = width * 2;      //Double?

            ShipMaxWeight = Lenght * Width * MaxDeckLoad;


            //X = length Y = width
            for (int x = 0; x < Lenght; x++)
            {
                for (int y = 0; y < Width; y++)
                {
                    DeckPlace deckPlace = new DeckPlace(x,y, MaxDeckLoad);
                    DeckPlaces.Add(deckPlace);
                }
            }
        }

        public void PlaceValuableContainers(List<Container> valuableContainers)
        {
            List<DeckPlace> deckPlacesForValuableContainers = new List<DeckPlace>();
            if (Lenght > 0)
            {
                deckPlacesForValuableContainers.AddRange(DeckPlaces.Where(d => d.Location[0] == DeckPlaces.Max(p => p.Location[0])).ToList());
            }

            deckPlacesForValuableContainers.AddRange(DeckPlaces.Where(d => d.Location[0] == 0).ToList());

            for (int i = 0; i < valuableContainers.Count(); i++)
            {
                deckPlacesForValuableContainers[i].AddContainer(valuableContainers[i]);
            }
        }

        public void PlaceCooledContainers(List<Container> cooledContainers)
        {
            List<DeckPlace> deckPlacesForCooledContainers = new List<DeckPlace>(DeckPlaces.Where(d => d.Location[0] == 0));

            int iNumberOfDeckplaces = deckPlacesForCooledContainers.Count();
            int iDeckplace = 0;
            foreach (Container container in cooledContainers)
            {
                if (iDeckplace > iNumberOfDeckplaces)
                {
                    iDeckplace = 0;
                }
                while (!deckPlacesForCooledContainers[iDeckplace].AddContainer(container)))
                {
                    iDeckplace++;
                    if (iDeckplace > iNumberOfDeckplaces)
                    {
                        iDeckplace = 0;
                    }
                }

                iDeckplace++;
            }
        }
            
        public void PlaceNormalContainers(List<Container> valuableContainers)
        {

        }

        public ValidationResponse CheckPossibilityForSolution(List<Container> containers)
        {
            ValidationResponse response = new ValidationResponse()
            {
                Successful = false
            };

            if (!CheckWeight(containers))
            {
                response.Information = "Het totaalgewicht van de containers is niet genoeg.";
                return response;
            }

            var numberOfValuableContainers = containers.Count(x => x.Type.Equals(ContainerType.Valuable));

            if (!CheckIfThereIsEnoughPlaceForValuableContainers(numberOfValuableContainers))
            {
                response.Information = "Er zijn niet genoeg plaatsen op de boot om de waardevolle containers kwijt te kunnen.";
                return response;
            }

            if (!CheckIfCooledContainerCanBePlacedOnFrontDeckPlace(containers))
            {
                response.Information = "Er is niet genoeg plaats voor de gekoelde containers";
                return response;
            }

            response.Successful = true;
            return response;
        }

        private bool CheckWeight(List<Container> containers)
        {

            int dada = containers.Sum(o => o.Weight);
            if (!((ShipMaxWeight / 2) < containers.Sum(o => o.Weight)))
                return false;

            return true;
        }

        private bool CheckIfThereIsEnoughPlaceForValuableContainers(int numberOfValuableContainers)
        {
            if (this.Lenght < 0)
                Valuablemultiplier = 1;

            if (Width * Valuablemultiplier < numberOfValuableContainers)
            {
                return false;
            }

            return true;
        }

        private List<Container> AddLowestContainersInWeightToFrontDeck(List<Container> containers)
        {
            List<Container> ValuableContainersOnFront = containers.Where(c => c.Type.Equals(ContainerType.Valuable)).OrderBy(c => c.Weight)
                 .Take(containers.Count(x => x.Type.Equals(ContainerType.Valuable)) - Width).ToList();  //takes the containers that needs to be on front
            return ValuableContainersOnFront;
        }

        private bool CheckIfCooledContainerCanBePlacedOnFrontDeckPlace(List<Container> containers)
        {
            List<DeckPlace> deckPlacesOnFront = DeckPlaces.Where(d => d.Location[0] == 0).ToList();
            List<Container> ValuableContainersOnFront = AddLowestContainersInWeightToFrontDeck(containers);
            List<Container> CooledContainers = containers.Where(c => c.Type.Equals(ContainerType.Cooled)).ToList();

            if (ValuableContainersOnFront.Count() > deckPlacesOnFront.Count())
                return false;

            for (int d = 0; d < ValuableContainersOnFront.Count(); d++)
            {
                if (!deckPlacesOnFront[d].CheckIfContainerCanBeAdded(ValuableContainersOnFront[d]))
                    return false;
            }

            int p = 0;


            foreach (var cooledcontainer in CooledContainers)
            {
                if (deckPlacesOnFront.Count() > p)
                {
                    if (!DeckPlaces[p].CheckIfContainerCanBeAdded(cooledcontainer))
                        p++;
                }
                else
                    return false;
            }

            return true;
        }

    }
}
