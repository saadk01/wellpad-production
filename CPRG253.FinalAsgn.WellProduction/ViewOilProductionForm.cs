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
    public partial class ViewOilProductionForm : Form
    {
        private FacilityManager _wellPadHandler = null;

        public ViewOilProductionForm()
        {
            InitializeComponent();
            _wellPadHandler = FacilityManager.GetInstance();
            LoadWellPads();
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

        private void uxViewProduction_Click(object sender, EventArgs e)
        {
            var selectedProdWell = (ProductionWell)uxProdWell.SelectedItem;

            var productionLogs = selectedProdWell.DailyProduction.OrderByDescending(pr => pr.ProductionDate);

            uxProductionLog.Columns.Clear();
            uxProductionLog.Columns.Add("Date", 180);
            uxProductionLog.Columns.Add("Barrels", 135);

            uxProductionLog.Items.Clear();

            foreach (var dp in productionLogs)
            {
                var items = new string[] { dp.ProductionDate.ToString(), dp.BarrelsProduced.ToString() };
                var item = new ListViewItem(items);
                uxProductionLog.Items.Add(item);
            }
        }
    }
}
