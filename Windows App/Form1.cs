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
    
       
    public Form1()
        {
            
           InitializeComponent();
            this.SetStyle(ControlStyles.ResizeRedraw, true);
            
        }
        private Form formactive = null;
        
            private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
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
            
        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {
            

        }
        private void button2_Click(object sender, EventArgs e)
        {
            FormOpen(new Quiz());
            
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {
            

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
            
        }

        private void button3_Paint(object sender, PaintEventArgs e)
        {
          
        }

        private void button1_Paint(object sender, PaintEventArgs e)
        {
            
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
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else if(this.WindowState == FormWindowState.Maximized)
            this.WindowState = FormWindowState.Normal;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormOpen(new Arborele());
            
        }
        private void button6_Click(object sender, EventArgs e)
        {
            FormOpen(new Arborele());

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void FormOpen(Form e)
        {
            if (formactive != null)
            {
                formactive.Close();
            }

            formactive = e;
            e.TopLevel = false;
            e.FormBorderStyle = FormBorderStyle.None;
            e.Dock = DockStyle.Fill;
            panel4.Controls.Add(e);
            e.Show();



        }

        private void button5_Click_1(object sender, EventArgs e)
        {
             FormOpen(new Poze());
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormOpen(new Uiua());
        }

        private void Nrges_Click(object sender, EventArgs e)
        {
            FormOpen(new NumberGuess());
        }
    }
    
}
