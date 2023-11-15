using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Windows_App
{
    public partial class Form1 : Form
    {
        //1**Fac fereastra să poată fi mutată. 
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        //2**Fac colțurile la fereastră rotunjite.
        /*
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
         (
              int nLeftRect,
              int nTopRect,
              int nRightRect,
              int nBottomRect,
              int nWidthEllipse,
             int nHeightEllipse

          );
        */
        public Form1()
        {
            
           InitializeComponent();
            //2**
            //Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 25, 25));
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Ana are mere", "Ana are mere");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            DialogResult result = MessageBox.Show("Are you sure you want to quit the app ? ", "Exit the app", MessageBoxButtons.YesNo);
           if(result == DialogResult.Yes)
            {
                Application.Exit();
            
            }
            */
            Application.Exit();

        }

        private void Form1_MouseHover(object sender, EventArgs e)
        {
              
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            //1**
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //1**
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            //1**
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Minimizez fereastra.
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            Calculator s = new Calculator();
            s.TopLevel = false;
            panel4.Controls.Add(s);
            s.Show();
            
            
            button3.BackColor = button2.BackColor;
            button1.BackColor = button2.BackColor;
            panel6.BackColor = button2.BackColor;
            panel5.BackColor = button2.BackColor;
            panel7.BackColor = button2.BackColor;
           
            
            
           
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            panel5.BackColor = panel1.BackColor;

        }
        private void panel5_MouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {
            panel6.BackColor = panel1.BackColor;
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
            button3.BackColor = panel1.BackColor;
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            button1.BackColor = panel1.BackColor;
        }

        private void panel4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
            panel7.BackColor = panel1.BackColor;
        }
    }
    
}
