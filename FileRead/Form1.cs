using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace FileRead
{
    public partial class fileRead : Form
    {
        int seeker = 0;
        public fileRead()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GetData();
        }

        private void GetData()
        {
            string[] fileData = File.ReadAllLines(@"C:\Users\lenovo\source\repos\FileRead\FileRead\bin\Debug\myDetails.txt");
            string[] parcedData = fileData[seeker].Split(',', '+', '#');
            txtName.Text = parcedData[0];
            txtPh.Text = parcedData[1];
            txtPlace.Text = parcedData[2];
            txtEmail.Text = parcedData[3];

            this.Text = (seeker + 1)+ "/"+ fileData.Length;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            seeker++;
            GetData();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            seeker--;
            GetData();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
