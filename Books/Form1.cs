using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace Books
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

        private void prestar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = DateTime.Now;
            int n = dtgv.Rows.Add();
            dtgv.Rows[n].Cells[0].Value = usuario.Text;
            dtgv.Rows[n].Cells[1].Value = libro.Text;

            usuario.Text = "";
            libro.Text = "";

           
        }
        
    }

}