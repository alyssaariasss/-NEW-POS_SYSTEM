using MongoDB.Bson;
using MongoDB.Driver;
using POS_SYSTEM.DATABASE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace POS_SYSTEM
{
    public partial class _1manager : Form
    {
        static MongoClient client = new MongoClient();
        static IMongoDatabase db = client.GetDatabase("POSLoginDB");
        static IMongoCollection<manager> collection = db.GetCollection<manager>("Manager");

        public void ReadAllDocuments()
        {
            List<manager> list = collection.AsQueryable().ToList<manager>();
            dataGridView2.DataSource = list;
            idtb.Text = dataGridView2.Rows[0].Cells[0].Value.ToString();
            datetb.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            intb.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            outtb.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
        }

        public _1manager()
        {
            InitializeComponent();
            ReadAllDocuments();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            List<manager> list = collection.AsQueryable().ToList<manager>();
            dataGridView2.DataSource = list;
            datetb.Text = dataGridView2.Rows[0].Cells[1].Value.ToString();
            intb.Text = dataGridView2.Rows[0].Cells[2].Value.ToString();
            outtb.Text = dataGridView2.Rows[0].Cells[3].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            manager m = new manager(datetb.Text, intb.Text, outtb.Text);
            collection.InsertOne(m);
            ReadAllDocuments();
        }

    }
}
