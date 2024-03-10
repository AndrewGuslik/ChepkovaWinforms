using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ChepkovaWinforms
{
    public partial class ProductCard : UserControl
    {

        private int id { get; set; }
        private string articul { get; set; }
        private string prodName { get; set; }
        private int price { get; set; }
        private string image { get; set; }

        public ProductCard(int id, string articul, string prodName, int price, string image)
        {
            InitializeComponent();

            this.id = id;
            this.articul = articul;
            this.prodName = prodName;
            this.price = price;
            this.image = image;

            Iarticul.Text = articul;
            IprodName.Text = prodName;
            Iprice.Text = price.ToString();
        }
    }
}
