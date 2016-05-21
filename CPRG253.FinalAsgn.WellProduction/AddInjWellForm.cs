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
    public partial class AddInjWellForm : Form
    {
        private FacilityManager _wellPadHandler = null;

        public AddInjWellForm()
        {
            InitializeComponent();
            _wellPadHandler = FacilityManager.GetInstance();
            LoadWellPadsWaterTypes();
        }

        private void LoadWellPadsWaterTypes()
        {
            uxWellPads.DataSource = _wellPadHandler.WellPadsCollection;
            uxWellPads.DisplayMember = "Location";
            uxWellPads.ValueMember = "Id";

            uxWaterType.DataSource = Enum.GetValues(typeof(WaterType));
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxAddInjWell_Click(object sender, EventArgs e)
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
                IdValidator.ValidateInjectionWellId(relevantWellPad.Wells, id);

                // Create injection well object
                var injWell = (InjectionWell)WellFactory.Instance.InitializeWell(SubWellTypes.InjectionWell);
                injWell.Id = id;
                injWell.SpudDate = spudDate;
                injWell.WaterType = (WaterType)uxWaterType.SelectedValue;

                // Insert it to the IWell collection of the relevant well pad
                relevantWellPad.Wells.Add(injWell);

                // This inj well is already added to the relevant well pad. So persist to file
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
