using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Drugstore.Dictionary
{
    public partial class CodeSuppliersForm : UserControl
    {
        public CodeSuppliersForm()
        {
            InitializeComponent();
        }

        private void tsbAdd_Click(object sender, EventArgs e)
        {
            CodeSupplierForm CSForm = new CodeSupplierForm();
            if (CSForm.ShowDialog() == DialogResult.OK)
                кодиПостачальниківTableAdapter.Fill(drugstoreDataSet.КодиПостачальників);
        }

        private void tsbDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
                if (MessageBox.Show("Видалити запис?", "Попередження", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    CodeSuppliers.deleteId(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value)); // Потрібно провірити
                    кодиПостачальниківTableAdapter.Fill(drugstoreDataSet.КодиПостачальників);
                }
        }

        private void tsbEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                CodeSupplierForm CSForm = new CodeSupplierForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
                if (CSForm.ShowDialog() == DialogResult.OK)
                    кодиПостачальниківTableAdapter.Fill(drugstoreDataSet.КодиПостачальників);
            }
        }

        private void CodeSuppliersForm_Load(object sender, EventArgs e)
        {
            кодиПостачальниківTableAdapter.Fill(drugstoreDataSet.КодиПостачальників);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodeSupplierForm CSForm = new CodeSupplierForm(Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value));
            if (CSForm.ShowDialog() == DialogResult.OK)
                кодиПостачальниківTableAdapter.Fill(drugstoreDataSet.КодиПостачальників);
        }

        private void tsbRefresh_Click(object sender, EventArgs e)
        {
            кодиПостачальниківTableAdapter.Fill(drugstoreDataSet.КодиПостачальників);
        }
    }
}
