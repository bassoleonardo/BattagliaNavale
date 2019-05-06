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
    public partial class Lobby : Form
    {
        public Lobby()
        {
            InitializeComponent();
        }

        private void btn_start_Click(object sender, EventArgs e)// mettere che quando si posizionano le navi viene fuori il nome e non giocatore 1 e 2
        {
            string nome1 = Convert.ToString(txt_player1.Text);
            string nome2 = Convert.ToString(txt_player2.Text);
            if (nome1 == "" || nome2 == "")
            {
                MessageBox.Show("Per favore inserire i nomi");
            }
            else
            {
                Coordinate cor = new Coordinate();
                cor.Show();
            }
        }
    }
}
