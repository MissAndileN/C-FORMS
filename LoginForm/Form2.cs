using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginForm
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        DataHandler handler = new DataHandler();
        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Gymprogram gym = new Gymprogram(int.Parse(txtPID.Text),txtName.Text, txtDe.Text,  txtInst.Text,  txtSch.Text, int.Parse(txtCap.Text), txtDur.Text);
            handler.Register(gym.ProgramID, gym.ProgramName1, gym.Description1, gym.Instructor, gym.Schedule,    gym.Capacity1, gym.Duration);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = handler.SearchInstructor(txtInst.Text);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            handler.Delete(int.Parse(txtPID.Text)); 
        }

        private void button4_Click(object sender, EventArgs e)
        {
            handler.Update(int.Parse(txtPID.Text), txtName.Text, txtDe.Text, txtInst.Text, txtSch.Text, int.Parse(txtCap.Text), txtDur.Text);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

            New newmember = new New();
            newmember.ShowDialog();
        }

        
    }
}
