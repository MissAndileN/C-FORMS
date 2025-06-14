using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class New : Form
    {
       
        public New()
        {
            InitializeComponent();
        }

        DataHandler dh = new DataHandler();
        private void New_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
           Members member = new Members( int.Parse(txtMID.Text),txtName.Text, txtSurname.Text, txtDOB.Text, txtGender.Text,txtPhonenumber.Text, txtAddress.Text , txtTrainingprogram.Text , txtStartdate.Text , txtEnddate.Text );
            dh.RegisterMembers(member.MemberID,member.Name, member.Surname, member.DOB1, member.Gender, member.Phonenumber, member.Address, member.Trainingprogram , member.Startdate , member.Enddate );
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            dh.UpdateMembers( int.Parse(txtMID.Text),txtName.Text, txtSurname.Text, txtDOB.Text, txtGender.Text, txtPhonenumber.Text, txtAddress.Text, txtTrainingprogram.Text, txtStartdate.Text, txtEnddate.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvNew.DataSource = dh.SearchMembers(int.Parse(txtMID.Text));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            dh.DeleteMembers(int.Parse(txtMID.Text));
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        
    }
}
