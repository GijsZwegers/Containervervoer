using Containervervoer.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Container = Containervervoer.Classes.Container;

namespace Containervervoer
{
    public partial class ConatainerVervoerForm : Form
    {
        public ConatainerVervoerForm()
        {
            InitializeComponent();
        }

        TestClass testClass = new TestClass();

        private void btStandardLoading_Click(object sender, EventArgs e)
        {
            lvContainers.Items.Clear();

            List<Container> containers = testClass.Setup();
            foreach (var item in containers)
            {
                ListViewItem lvi = new ListViewItem(item.Type.ToString());
                lvi.SubItems.Add(item.Weight.ToString());

                lvContainers.Items.Add(lvi);
            }

            lvContainers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            lvContainers.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);

            lbContainerCount.Text = "Aantal containers: " + containers.Count().ToString();
            lbtotalweight.Text = "Totale Gewicht Containers: " + containers.Sum(o => o.Weight).ToString();
        }

        private void lvContainers_ControlAdded(object sender, ControlEventArgs e)
        {
            lvContainers.Items.OfType<Container>().Select(o => o.Equals(Container));
        }

        private void CorrectShipWeight(object sender, EventArgs e)
        {
            Ship ship = new Ship(Convert.ToInt32(nmShipLength.Value), Convert.ToInt32(nmShipHeight.Value));
            lbShipCapacity.Text = ship.ShipMaxWeight.ToString();
        }

        private void btStart_Click(object sender, EventArgs e)
        {
            Ship ship = new Ship(Convert.ToInt32(nmShipLength.Value), Convert.ToInt32(nmShipHeight.Value));

            ShipForm boatForm = new ShipForm(ship.Lenght, ship.Width);
        }

        private void btTest_Click(object sender, EventArgs e)
        {
            TestClass testClass = new TestClass();
            Dock dock = new Dock();

            dock.CreateShip(2, 2);

            dock.AddMultipleContainers(testClass.Setup());
            dock.TryPlaceAllContainersOnShip();
            dock.RunContainervervoerSetup();
        }
    }
}
