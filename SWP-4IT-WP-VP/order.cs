using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWP_4IT_WP_VP
{
    public partial class order : Form
    {
        public static List<string> list = new List<string>();
        public order()
        {
            InitializeComponent();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            
        }

        private void order_Load(object sender, EventArgs e)
        {
            //Product p = new Product();
            //p.Name = ""
            //cb_product.Items.Add();

            //Tabelle mit Oberkategorien erstellen
            //Tabelle mit Unterkategorien erstellen
            //Unterkategorie mit primary key und secondary key (z.b shoes) erstellen
            //um das Programm clean zu machen
            cb_umbrellaTerm.Items.Add("shoes;");
            cb_umbrellaTerm.Items.Add("clothing;");
            cb_umbrellaTerm.Items.Add("apparel & equipment;");
            
            if(cb_umbrellaTerm.Text.Equals("shoes"))
            {
                cb_type.Items.Add("hiking shoes; ");
                cb_type.Items.Add("sports shoes; ");
                cb_type.Items.Add("winter shoes; ");
            }
            else if (cb_umbrellaTerm.Text.Equals("clothing"))
            {
                cb_type.Items.Add("outdoor clothing; ");
                cb_type.Items.Add("bycicle clothing; ");
                cb_type.Items.Add("sports clothing; ");
            }
            else if (cb_umbrellaTerm.Text.Equals("apparel & equipment"))
            {
                cb_type.Items.Add("sports equipment;");
                cb_type.Items.Add("running equipment;");
                cb_type.Items.Add("outdoor equipment;");
            }

            //if (cb_type.Text.Equals() "hiking shoes")
            //{
            //    cb_brand.Items.Add("Salomon; \n" +
            //                       "La Sportiva; \n" +
            //                       "Adidas;");
            //}

        }
    }
}
