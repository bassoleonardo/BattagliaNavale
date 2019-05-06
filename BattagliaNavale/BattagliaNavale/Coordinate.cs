using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BattagliaNavale
{
    public partial class Coordinate : Form
    {
        string[] nomiNavi = {"portaerei", "corazzata", "cacciatortedimiele", "sommergibile", "guardacoste" };
        int[,] tabella = new int[12, 12];

        public Coordinate()
        {
            InitializeComponent();
            dataGridView1.ColumnCount = 12;
            dataGridView1.RowCount = 12;
            InitializeComponent();
            
            //creazione delle navi player1
            nave Portaerei = new nave();
            Portaerei = new nave(0, 6, nomiNavi);
            nave Corazzata = new nave();
            Corazzata = new nave(1, 5, nomiNavi);
            nave Cacciatorpediniere = new nave();
            Cacciatorpediniere = new nave(2, 4, nomiNavi);
            nave Sommergibile = new nave();
            Sommergibile = new nave(3, 3, nomiNavi);
            nave Guardecoste = new nave();
            Guardecoste = new nave(4, 2, nomiNavi);
            List<nave> player1 = new List<nave> { Portaerei, Corazzata, Cacciatorpediniere, Sommergibile, Guardecoste};
            
            //creazione delle navi player2
            nave Portaerei2 = new nave();
            Portaerei2 = new nave(0, 6, nomiNavi);
            nave Corazzata2 = new nave();
            Corazzata2 = new nave(1, 5, nomiNavi);
            nave Cacciatorpediniere2 = new nave();
            Cacciatorpediniere2 = new nave(2, 4, nomiNavi);
            nave Sommergibile2 = new nave();
            Sommergibile2 = new nave(3, 3, nomiNavi);
            nave Guardecoste2 = new nave();
            Guardecoste2 = new nave(4, 2, nomiNavi);
            List<nave> player2 = new List<nave> { Portaerei2, Corazzata2, Cacciatorpediniere2, Sommergibile2, Guardecoste2};
        }

        int xI = Convert.ToInt32(textBox1.Text);
        int xF = Convert.ToInt32(textBox2.Text);
        int yI = Convert.ToInt32(textBox3.Text);
        int yF = Convert.ToInt32(textBox4.Text);

        private void btn_coordinata_Click(object sender, EventArgs e)
        {
            PosizionaNavi();
        }

        public void PosizionaNavi()
        {
            int numNave = 1;
            /*int xI = Convert.ToInt32(textBox1.Text);
            int xF = Convert.ToInt32(textBox2.Text);
            int yI = Convert.ToInt32(textBox3.Text);
            int yF = Convert.ToInt32(textBox4.Text);*/
            if (numNave == 1)
            {
                lbl_naveInput.Text = "portaerei";
            }
            else if (numNave == 2)
            {
                lbl_naveInput.Text = "corazzata";
            }
            else if (numNave == 2)
            {
                lbl_naveInput.Text = "cacciatorpediniere";
            }
            else if (numNave == 2)
            {
                lbl_naveInput.Text = "sommergibile";
            }
            else if (numNave == 2)
            {
                lbl_naveInput.Text = "guardacoste";
            }
            numNave++;
            if (xI == xF)
            {
                RiempiTabella(yI, yF, xI);
            }
            else if (yI == yF)
            {
                RiempiTabella(xI, xF, yI);
            }
        }

        // Riempie la "linea" occupata dalla nave
        public void RiempiTabella(int inizio, int fine, int inizioStatico)
        {
            for (int i = inizio; i < fine; i++)
            {
                if (tabella[i, inizioStatico] == 1)
                {
                    // errore e mettere -- al tipo di nave e che da errore e che richieda nuove coordinate
                }
                else
                {
                    tabella[i, inizioStatico] = 1;
                }
            }
        }

        // Blocco lettere
        private void txtPrimoNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void Coordinate_Load(object sender, EventArgs e)
        {

        }
    }
}