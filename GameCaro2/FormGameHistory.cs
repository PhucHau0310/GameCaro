using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro2
{
    public partial class FormGameHistory : Form
    {
        SqlCommand cmd;
        SqlDataAdapter adt;
        DataTable dt;
        Db db;

        public FormGameHistory()
        {
            InitializeComponent();
        }

        private void FormGameHistory_Load(object sender, EventArgs e)
        {
            db = new Db();
            try
            {
                db.con.Open();
                cmd = new SqlCommand("Select * from GameHistory", db.con);
                adt = new SqlDataAdapter(cmd);

                dt = new DataTable();
                adt.Fill(dt);

                dataGridView1.DataSource = dt;
                db.con.Close();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
