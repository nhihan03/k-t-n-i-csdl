using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ConnectSQL
{
    public partial class Form1 : Form
    {
        string connectionString = @"Data Source= DESKTOP-6NSFUQR\SQLEXPRESS;Initial Catalog=Tuan3;Intergarted Securiti=True";
        SqlConnection connection = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch { 
            }
    }
}
