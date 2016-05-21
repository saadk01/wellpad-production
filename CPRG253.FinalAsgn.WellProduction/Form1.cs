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
    public partial class Form1 : Form
    {
        Explorer _explorerView;
        AddWellPadForm _addWPForm;
        AddProdWellForm _addPWForm;
        AddInjWellForm _addIJForm;
        OilProductionForm _opForm;
        ViewOilProductionForm _vopForm;

        public Form1()
        {
            InitializeComponent();
        }

        private void explorerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_explorerView == null || _explorerView.IsDisposed)
            {
                _explorerView = new Explorer();
                _explorerView.MdiParent = this;
            }

            _explorerView.Show();
            _explorerView.BringToFront();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            explorerToolStripMenuItem_Click(sender, e);
        }

        private void wellPadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_addWPForm == null || _addWPForm.IsDisposed)
            {
                _addWPForm = new AddWellPadForm();
                _addWPForm.MdiParent = this;
            }

            _addWPForm.Show();
            _addWPForm.BringToFront();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            wellPadToolStripMenuItem_Click(sender, e);
        }

        private void productionWellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_addPWForm == null || _addPWForm.IsDisposed)
            {
                _addPWForm = new AddProdWellForm();
                _addPWForm.MdiParent = this;
            }

            _addPWForm.Show();
            _addPWForm.BringToFront();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            productionWellToolStripMenuItem_Click(sender, e);
        }

        private void injectionWellToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_addIJForm == null || _addIJForm.IsDisposed)
            {
                _addIJForm = new AddInjWellForm();
                _addIJForm.MdiParent = this;
            }

            _addIJForm.Show();
            _addIJForm.BringToFront();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            injectionWellToolStripMenuItem_Click(sender, e);
        }

        private void wellProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_opForm == null || _opForm.IsDisposed)
            {
                _opForm = new OilProductionForm();
                _opForm.MdiParent = this;
            }

            _opForm.Show();
            _opForm.BringToFront();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            wellProductionToolStripMenuItem_Click(sender, e);
        }

        private void viewWellProductionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_vopForm == null || _vopForm.IsDisposed)
            {
                _vopForm = new ViewOilProductionForm();
                _vopForm.MdiParent = this;
            }

            _vopForm.Show();
            _vopForm.BringToFront();
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            viewWellProductionToolStripMenuItem_Click(sender, e);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
