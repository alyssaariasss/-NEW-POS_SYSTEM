using MongoDB.Bson;
using MongoDB.Driver;
using POS_SYSTEM.DATABASE;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class Form7 : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("POSLoginDB");
        static IMongoCollection<adminsttngs> collection = db.GetCollection<adminsttngs>("AdminUS");

        public void ReadAllDocuments()
        {
            List<adminsttngs> list = collection.AsQueryable().ToList<adminsttngs>();
            dataGridView1.DataSource = list; 
            idtb.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            nametb.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            agetb.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            addtb.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            emailtb.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            numtb.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
        }

        public Form7()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<adminsttngs> list = collection.AsQueryable().ToList<adminsttngs>();
            dataGridView1.DataSource = list;
            idtb.Text = dataGridView1.Rows[0].Cells[0].Value.ToString();
            nametb.Text = dataGridView1.Rows[0].Cells[1].Value.ToString();
            agetb.Text = dataGridView1.Rows[0].Cells[2].Value.ToString();
            addtb.Text = dataGridView1.Rows[0].Cells[3].Value.ToString();
            emailtb.Text = dataGridView1.Rows[0].Cells[4].Value.ToString();
            numtb.Text = dataGridView1.Rows[0].Cells[5].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var editbttn = Builders<adminsttngs>.Update.Set("name", nametb.Text).Set("age", agetb.Text).Set("address", addtb.Text).Set("email", emailtb.Text).Set("contact", numtb.Text);
            collection.UpdateOne(s => s.Id == ObjectId.Parse(idtb.Text), editbttn);
            ReadAllDocuments();
            MessageBox.Show("Your settings have been updated!");

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            resetpass f13 = new resetpass();
            f13.ShowDialog();
        }
    }
}
