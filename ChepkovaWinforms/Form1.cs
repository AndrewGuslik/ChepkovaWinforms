using Microsoft.VisualBasic.Logging;
using System.Collections.Immutable;
using System.Threading.Tasks.Dataflow;

namespace ChepkovaWinforms
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        public string query, filter, sort;

        public Form1()
        {         
            InitializeComponent();
            showProducts();
        }

        private void showProducts()
        {
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(db.GetProduct().ToArray());
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            query = textBox1.Text;
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(db.GetProdQuery(query).ToArray());
            
        }

        private void textBox1_MouseDown(object sender, MouseEventArgs e)
        {
            string txt = textBox1.Text;
            if (txt == "¬ведите дл€ поиска")
            {
                textBox1.Clear();
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            filter = comboBox2.SelectedItem.ToString();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(db.GetProdFilter(filter).ToArray());
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sort = comboBox1.SelectedItem.ToString();
            flowLayoutPanel1.Controls.Clear();
            flowLayoutPanel1.Controls.AddRange(db.GetProdSort(sort).ToArray());
        }
    }
}