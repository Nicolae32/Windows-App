using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_App
{
    public partial class Quiz : Form
    {
        int punctaj;

        public Quiz()
        {
            InitializeComponent();
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
           

        }

        private void Quiz_Activated(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (rb1.Checked) { punctaj++; }
            if (rb2.Checked) { punctaj++; }
            if (rb3.Checked) { punctaj++; }
            if (rb4.Checked) { punctaj++; }
           
            MessageBox.Show("Ai răspuns corect la " + punctaj +" întrebări!", "Felicitări!", MessageBoxButtons.OK);

            punctaj = 0;
                 

        }
    }
}
