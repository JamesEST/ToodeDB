﻿using System;
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
        string filename;
   
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename =|DataDirectory|\AppData\Tooded.mdf; Integrated Security = True");
        SqlCommand cmd;
        SqlDataAdapter adapter, adapter2;
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
            pictureBox1.Image = Image.FromFile("../../Image/Piim.jpg");

            adapter2 = new SqlDataAdapter("SELECT Kategooria_nimetus FROM Kategooria", con);
            DataTable kat_table = new DataTable();
            adapter2.Fill(kat_table);
            foreach(DataRow row in kat_table.Rows)
            {
                comboBox1.Items.Add(row["Kategooria_nimetus"]);
            }

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
            if (ToodeBox.Text != "" && KogusBox.Text != "" && HindBox.Text != "" && comboBox1.SelectedItem != null)
            {
                cmd = new SqlCommand("INSERT INTO Toodetable(Toodenimetus,Kogus,Hind,Kategooria_Id) VALUES (@toode,@kogus,@hind,@kat)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@toode", ToodeBox.Text);
                cmd.Parameters.AddWithValue("@kogus", KogusBox.Text);
                cmd.Parameters.AddWithValue("@hind", HindBox.Text.Replace(',', '.'));
                cmd.Parameters.AddWithValue("@kat", (comboBox1.SelectedIndex + 1));
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Andme on lisatud");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (ToodeBox.Text != "" && KogusBox.Text != "" && HindBox.Text != "")
            {
                cmd = new SqlCommand("update ToodeTable set Toodenimetus=@toode,Kogus=@kogus,Hind=@hind where Id=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.Parameters.AddWithValue("@toode", ToodeBox.Text);
                cmd.Parameters.AddWithValue("@kogus", KogusBox.Text);
                cmd.Parameters.AddWithValue("@hind", HindBox.Text.Replace(',', '.'));
                cmd.ExecuteNonQuery();
                con.Close();
                DisplayData();
                ClearData();
                MessageBox.Show("Record Updated Successfully");
            }
            else
            {
                MessageBox.Show("Error");
            }
        }


        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            ToodeBox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            KogusBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            HindBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            string v = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            comboBox1.SelectedIndex = Int32.Parse(v);
            


        }

        private void btn_delete_Click(object sender, EventArgs e)
        {

            if (Id != 0)
            {
                cmd = new SqlCommand("delete ToodeTable where ID=@id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", Id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully!");
                DisplayData();
                ClearData();
            }
            else
            {
                MessageBox.Show("Please Select Record to Delete");
            }
        }

        private void ImgShow_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofg = new OpenFileDialog();
            ofg.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            if (ofg.ShowDialog() == DialogResult.OK)
            {
                filename = ofg.FileName;
                textBox1.Text = filename;
                cmd = new SqlCommand("update Toodetable set PictureStr=@Picturefile", con);
                con.Open();
                cmd.Parameters.AddWithValue("@Picturefile", textBox1.Text);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Successfully!");
                DisplayData();
                ClearData();
                pictureBox1.Image = Image.FromFile(filename);
            }

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
