using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ToodeDB
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter;
        int Id = 0;
        public Form1()
        {
            InitializeComponent();
            DisplayData();
        }

        private void DisplayData()
        {
            con.Open();
            DataTable tabel = new DataTable();
            adapter = new SqlDataAdapter("SELECT *FROM Toodetable", con);
            adapter.Fill(tabel);
            dataGridView1.DataSource = tabel;
            con.Close();
         
        }
        private void ClearData()
        {
            Id = 0;
            ToodeBox.Text = "";
            KogusBox.Text = "";
            HindBox.Text = "";
        }

        //private void Form1_Load(object sender, EventArgs e)
        //{
            // TODO: This line of code loads data into the 'toodedDataSet.ToodeTable' table. You can move, or remove it, as needed.
        //    this.toodeTableTableAdapter.Fill(this.toodedDataSet.ToodeTable);

        //}

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(ToodeBox.Text != "" && KogusBox.Text != "" && HindBox.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Toodetable(Toodenimetus,Kogus,Hind) VALUES (@toode,@kogus,@hind)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@toode", ToodeBox.Text);
                cmd.Parameters.AddWithValue("@kogus", KogusBox.Text);
                cmd.Parameters.AddWithValue("@hind", HindBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andme on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ToodeBox.Text != "" && KogusBox.Text != "" && HindBox.Text != "")
            {
                cmd = new SqlCommand("INSERT INTO Toodetable(Toodenimetus,Kogus,Hind) SET Toodenimetus=@toode,Kogus=@kogus,Hind=@hind where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@toode", ToodeBox.Text);
                cmd.Parameters.AddWithValue("@kogus", KogusBox.Text);
                cmd.Parameters.AddWithValue("@hind", HindBox.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andme on lisatud");
            }
            else
            {
                MessageBox.Show("Viga");
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            ToodeBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            KogusBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            HindBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
