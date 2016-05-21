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
    public partial class AddProdWellForm : Form
    {
        private FacilityManager _wellPadHandler = null;

        public AddProdWellForm()
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
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxAddProdWell_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(uxId.Text, out id))
                {
                    throw new Exception("ID can only be an integer value.");
                }

                var spudDate = uxSpudDate.Value;
                string wellPadLocation = uxWellPads.Text;
                int wellPadId = (int)uxWellPads.SelectedValue;

                // Get relevant well pad
                var relevantWellPad = _wellPadHandler.WellPadsCollection
                    .SingleOrDefault(wp => wp.Location == wellPadLocation && wp.Id == wellPadId);

                // Validate ID is unique
                IdValidator.ValidateProductionWellId(relevantWellPad.Wells, id);

                // Create production well object
                var prodWell = (ProductionWell)WellFactory.Instance.InitializeWell(SubWellTypes.ProductionWell);
                prodWell.Id = id;
                prodWell.SpudDate = spudDate;
                prodWell.DailyProduction = new List<IOilProduction>();

                // Insert it to the IWell collection of the relevant well pad
                relevantWellPad.Wells.Add(prodWell);

                // This prod well is already added to the relevant well pad. So persist to file
                _wellPadHandler.Save();

                uxId.Text = "";
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
