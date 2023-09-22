using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Data_Base_Students
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'data_base_studentsDataSet.tbstudent' table. You can move, or remove it, as needed.
            this.tbstudentTableAdapter.Fill(this.data_base_studentsDataSet.tbstudent);

        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            tbstudentBindingSource.AddNew();

            

       
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnSave_Click(object sender, EventArgs e)

        {
            tbstudentBindingSource.EndEdit();
            tbstudentTableAdapter.Update(data_base_studentsDataSet.tbstudent);



        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tbstudentBindingSource.RemoveCurrent();
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            tbstudentBindingSource.MoveLast();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            tbstudentBindingSource.MoveFirst();

        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            tbstudentBindingSource.MovePrevious();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            tbstudentBindingSource.CancelEdit();

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tbstudentBindingSource.MoveNext();

        }
    }
}
