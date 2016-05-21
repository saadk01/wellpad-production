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
    public partial class AddWellPadForm : Form
    {
        private FacilityManager _wellPadHandler = null;

        public AddWellPadForm()
        {
            InitializeComponent();
            LoadProvinces();
            _wellPadHandler = FacilityManager.GetInstance();
        }

        private void LoadProvinces()
        {
            var provinces = FileHandler.GetProvinces();
            uxProvinces.DataSource = provinces;
        }

        private void uxCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uxAddWellPad_Click(object sender, EventArgs e)
        {
            try
            {
                int id;
                if (!int.TryParse(uxId.Text, out id))
                {
                    throw new Exception("ID can only be an integer value.");
                }

                // Validate ID to be unique
                IdValidator.ValidateWellPadId(_wellPadHandler.WellPadsCollection, id);

                string location = uxLocation.Text;
                if (!System.Text.RegularExpressions.Regex.IsMatch(location, @"^[a-zA-Z ]+$"))
                {
                    throw new Exception("Location can only contain alphabets.");
                }

                string province = uxProvinces.Text;

                // Create new well pad obj
                var wp = new WellPad();
                wp.Id = id;
                wp.Province = province;
                wp.Location = location;
                // Initialize this well pad's `Wells` property now. Injection/productions wells relevant to this well pad
                // will be aded here.
                wp.Wells = new List<IWell>();

                // Add to the main collection object
                _wellPadHandler.Add(wp);

                // Persist to file
                _wellPadHandler.Save();

                uxId.Text = "";
                uxLocation.Text = "";
            }
            catch(Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
    }
}
