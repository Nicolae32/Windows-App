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
    public partial class NumberGuess : Form
    {
        Random num = new Random();
        public NumberGuess()
        {
            InitializeComponent();
            generate();
        }

        private void NumberGuess_Load(object sender, EventArgs e)
        {

        }
       
        private void generate()
        {
            int n = num.Next(1, 20);

        }
       
    }
}
