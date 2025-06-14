using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void login_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text;
            string password = textBox2.Text;

            // Validate username and password
            bool isValid = LoginHandler.ValidateCredentials(username, password);

            if (isValid)
            {
                // Login successful
                MessageBox.Show("Login Successful!");

                New newmember = new New();
                newmember.ShowDialog();
            }
            else if(!isValid)
            {
                LoginHandler.attempt();
                admin unlock = new admin();
                unlock.ShowDialog();
            }
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            string path = @"username.txt";
            string username = textBox1.Text;
            string password = textBox2.Text;
            FileStream file = new FileStream(path, FileMode.Append);
            StreamWriter stream = new StreamWriter(file);
            stream.WriteLine(username +","+ password);
            MessageBox.Show("SignUp successful!");
            stream.Close();
            file.Close();


        }
    }   
}
