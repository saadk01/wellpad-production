using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CPRG253.FinalAsgn.Domain;

namespace CPRG253.FinalAsgn.WellProduction
{
    public partial class Explorer : Form
    {
        private List<String> _provinces = null;

        public Explorer()
        {
            InitializeComponent();
            _provinces = FileHandler.GetProvinces();
            PopulateTree();
        }

        private void PopulateTree()
        {
            TreeNode rootNode = null;
            TreeNode provinceNode = null;
            TreeNode wellPadNode = null;
            TreeNode subWellNode = null;

            // Start populating tree
            rootNode = new TreeNode("Facilities");
            rootNode.Tag = _provinces;
            uxTree.Nodes.Add(rootNode);

            // Beneath root (Facilities), start populating provinces
            foreach (var prov in _provinces)
            {
                // Populate provinces
                provinceNode = new TreeNode(prov);
                var facilities = FacilityManager.GetInstance().WellPadsCollection.Where(p => p.Province == prov);
                provinceNode.Tag = facilities;
                rootNode.Nodes.Add(provinceNode);

                // For each province, start populating locations (well pads)
                foreach (var wellPad in facilities)
                {
                    wellPadNode = new TreeNode(wellPad.Location);
                    wellPadNode.Tag = wellPad.Wells;
                    provinceNode.Nodes.Add(wellPadNode);

                    // Now populate injection/production wells
                    foreach (var subWell in wellPad.Wells)
                    {
                        subWellNode = new TreeNode(subWell.SpudDate.ToString());
                        subWellNode.Tag = subWell;
                        wellPadNode.Nodes.Add(subWellNode);
                    }
                }
            }
        }

        private void uxTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (e.Node.Level)
            {
                case (0):
                    FormatFacilitiesSummary();
                    break;
                case (1):
                    FormatProvincesSummary(e.Node.Text);
                    break;
                case (2):
                    FormatLocationSummary(e.Node.Text, e.Node.Parent.Text);
                    break;
                case (3):
                    FormatSubWellSummary(e.Node.Tag);
                    break;
            }
        }

        // Populate list view for a given production/injection well
        private void FormatSubWellSummary(object tag)
        {
            uxDetails.Columns.Clear();
            uxDetails.Columns.Add("Type", 120);
            uxDetails.Columns.Add("Spud Date", 160);
            uxDetails.Columns.Add("Water Type", 140);
            uxDetails.Columns.Add("Barrels Produced", 140);

            uxDetails.Items.Clear();

            var subWell = (IWell)tag;

            // If it's injection well
            if (subWell.GetType() == typeof(InjectionWell))
            {
                var injW = (InjectionWell)subWell;
                var items = new string[] { "Injection Well", injW.SpudDate.ToString(), injW.WaterType.ToString(), "N/A" };
                var item = new ListViewItem(items);
                uxDetails.Items.Add(item);
            }
            // If it's production well
            else
            {
                var prodW = (ProductionWell)subWell;

                // Get overall count of barrels produced for this production well
                int barrelsProducedCount = 0;
                foreach (var barrels in prodW.DailyProduction)
                {
                    barrelsProducedCount += barrels.BarrelsProduced;
                }

                var items = new string[] { "Production Well", prodW.SpudDate.ToString(), "N/A", barrelsProducedCount.ToString() };
                var item = new ListViewItem(items);
                uxDetails.Items.Add(item);
            }
        }

        // Populate list view of a well pad (location)
        private void FormatLocationSummary(string location, string province)
        {
            uxDetails.Columns.Clear();
            uxDetails.Columns.Add("Type", 120);
            uxDetails.Columns.Add("Spud Date", 160);
            uxDetails.Columns.Add("Water Type", 140);
            uxDetails.Columns.Add("Barrels Produced", 140);

            uxDetails.Items.Clear();

            var provWellPads = FacilityManager.GetInstance().WellPadsCollection
                .Where(w => w.Province == province)
                .Where(w => w.Location == location);

            // Provide details of all injection/production wells in this well pad
            foreach (var wp in provWellPads)
            {
                // First get the injection wells specifically and present their details
                var injWells = wp.Wells.Where(w => w.GetType() == typeof(InjectionWell));
                foreach (var iw in injWells)
                {
                    var injW = (InjectionWell)iw;
                    var items = new string[] { "Injection Well", injW.SpudDate.ToString(), injW.WaterType.ToString(), "N/A" };
                    var item = new ListViewItem(items);
                    uxDetails.Items.Add(item);
                }

                // Now get the production wells and present their details
                var prodWells = wp.Wells.Where(w => w.GetType() == typeof(ProductionWell));
                
                foreach (var pw in prodWells)
                {
                    var prodW = (ProductionWell)pw;
                    // Get overall count of barrels produced for this production well
                    int barrelsProducedCount = 0;
                    foreach (var barrels in prodW.DailyProduction)
                    {
                        barrelsProducedCount += barrels.BarrelsProduced;
                    }

                    var items = new string[] { "Production Well", prodW.SpudDate.ToString(), "N/A", barrelsProducedCount.ToString() };
                    var item = new ListViewItem(items);
                    uxDetails.Items.Add(item);
                }
            }
        }

        // Provide list view of well pads within a province
        private void FormatProvincesSummary(string province)
        {
            uxDetails.Columns.Clear();
            uxDetails.Columns.Add("Location", 120);
            uxDetails.Columns.Add("Production Wells", 120);
            uxDetails.Columns.Add("Injection Wells", 120);

            uxDetails.Items.Clear();
            
            // Get the relevant object for the given province and get details of all well pads within it
            var provWellPads = FacilityManager.GetInstance().WellPadsCollection.Where(p => p.Province == province);
            foreach (var aWellPad in provWellPads)
            {
                int injWellsCount = aWellPad.Wells.Where(w => w.GetType() == typeof(InjectionWell)).Count();
                int prodWellsCount = aWellPad.Wells.Where(w => w.GetType() == typeof(ProductionWell)).Count();

                var items = new string[] { aWellPad.Location, prodWellsCount.ToString(), injWellsCount.ToString() };
                var item = new ListViewItem(items);
                uxDetails.Items.Add(item);
            }

        }

        // Provide list view of root node
        private void FormatFacilitiesSummary()
        {
            uxDetails.Columns.Clear();
            uxDetails.Columns.Add("Province", 120);
            uxDetails.Columns.Add("Well Pads", 120);
            uxDetails.Columns.Add("Production Wells", 140);
            uxDetails.Columns.Add("Injection Wells", 140);

            uxDetails.Items.Clear();
            foreach (var prov in _provinces)
            {
                int wellPadsCount = FacilityManager.GetInstance().WellPadsCollection.Count(p => p.Province == prov);
                var provWellPads = FacilityManager.GetInstance().WellPadsCollection.Where(p => p.Province == prov);

                int injWellsCount = 0, prodWellsCount = 0;
                foreach (var aWellPad in provWellPads)
                {
                    injWellsCount += aWellPad.Wells.Where(w => w.GetType() == typeof(InjectionWell)).Count();
                    prodWellsCount += aWellPad.Wells.Where(w => w.GetType() == typeof(ProductionWell)).Count();
                }
                
                var items = new string[] { prov, wellPadsCount.ToString(), prodWellsCount.ToString(), injWellsCount.ToString() };
                var item = new ListViewItem(items);
                uxDetails.Items.Add(item);
            }
        }
    }
}
