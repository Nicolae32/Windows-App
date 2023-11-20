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
    public partial class Uiua : Form
    {
        public Uiua()
        {
            InitializeComponent();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            richTextBox1.SaveFile("Acesta este rezumatul proiectului m.rtf", RichTextBoxStreamType.RichText);
        }
    }
}
