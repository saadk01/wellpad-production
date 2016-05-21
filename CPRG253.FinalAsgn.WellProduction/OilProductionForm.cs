using CPRG253.FinalAsgn.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CPRG253.FinalAsgn.WellProduction
{
    public partial class OilProductionForm : Form
    {
        private FacilityManager _wellPadHandler = null;
        private OilProduction _op;

        public OilProductionForm()
        {
            InitializeComponent();
        }

        private void OilProductionForm_Load(object sender, EventArgs e)
        {
            _wellPadHandler = FacilityManager.GetInstance();
            LoadWellPads();
            _op = (OilProduction)WellFactory.Instance.InitializeDailyProductionLog();
            _op.BarrelsOverFifty += Production_BarrelsOverFifty;
        }

        private void Production_BarrelsOverFifty(object sender, BarrelEventArgs args)
        {
            var display = string.Format("Congratulations! Production on {0} yielded {1} barrels.", args.ProducedOn, args.BarrelsQuantity);
            MessageBox.Show(display);
        }

        private void LoadWellPads()
        {
            uxWellPads.DataSource = _wellPadHandler.WellPadsCollection;
            uxWellPads.DisplayMember = "Location";
            uxWellPads.ValueMember = "Id";
            // Load production wells of the first location by default
            LoadProdWells(_wellPadHandler.WellPadsCollection[0].Location, _wellPadHandler.WellPadsCollection[0].Id);
        }

        private void LoadProdWells(string wellPadLocation, int wellPadId)
        {
            // Get this well pad object
            var relevantWellPad = _wellPadHandler.WellPadsCollection
                    .SingleOrDefault(wp => wp.Location == wellPadLocation && wp.Id == wellPadId);

            // Get this well pad's prod wells
            var prodWells = relevantWellPad.Wells.Where(w => w.GetType() == typeof(ProductionWell));

            // Refresh combobox and bind to prod wells (Clearing it is only possible because its data source is nulled earlier) 
            uxProdWell.Items.Clear();
            uxProdWell.DataSource = prodWells.ToList();
            uxProdWell.DisplayMember = "SpudDate";
            uxProdWell.ValueMember = "Id";
        }

        private void uxWellPads_SelectionChangeCommitted(object sender, EventArgs e)
        {
            // Populate production wells based on the well pad selected
            var selectedWellPad = (WellPad)uxWellPads.SelectedItem;
            // Set this combobox's data source to null so that it's possible to clear its current list to populate new one
            uxProdWell.DataSource = null;
            LoadProdWells(selectedWellPad.Location, selectedWellPad.Id);
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxAddOilProd_Click(object sender, EventArgs e)
        {
            try
            {
                int numOfBarrels;
                if (!int.TryParse(uxNumBarrels.Text, out numOfBarrels))
                {
                    throw new Exception("Number of barrels can only be an integer value.");
                }

                // Send these inputs to the _op for event evaluation
                _op.BarrelsProduced = numOfBarrels;
                _op.ProductionDate = uxProdDate.Value;

                // Create new oil prod obj; can't use _op here or values will be overridden when multiple logs are provided simultaneously
                var op = (OilProduction)WellFactory.Instance.InitializeDailyProductionLog();
                op.BarrelsProduced = numOfBarrels;
                op.ProductionDate = uxProdDate.Value;

                // Get relevant prod well and add this oil production to it
                var selectedProdWell = (ProductionWell)uxProdWell.SelectedItem;
                selectedProdWell.DailyProduction.Add(op);

                // Given prod well is already added to the relevant well pad. So persist the complete collection to file
                _wellPadHandler.Save();

                uxNumBarrels.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
