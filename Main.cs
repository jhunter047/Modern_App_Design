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

namespace Modern_App_Design
{
    public partial class mainForm : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;


        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd,
        int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        public mainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
       

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
                if (e.Button == MouseButtons.Left)
                {
                    ReleaseCapture();
                    SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
                }
        }




        /// <summary>
        /// Code for the Exit button 
        /// </summary>    
        //When the button is clicked exit the application 
        private void ExitButton_Click(object sender, EventArgs e)
        {
            if (System.Windows.Forms.Application.MessageLoop)
            {
                // WinForms app
                System.Windows.Forms.Application.Exit();
            }
            else
            {
                // Console app
                System.Environment.Exit(1);
            }
        }

        //When the mouse (over) enters the button
        private void ExitButton_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to red. 
            ExitButton.BackColor = Color.Red; 
        }

        //When the mouse (Over) exits the button
        private void ExitButton_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to black
            ExitButton.BackColor = Color.Black;
        }

        /// <summary>
        /// Code for the Maximise button
        /// </summary>
        //When the button is clicked maximize the application
        private void button2_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Maximized)
            {
                //if windows state is maximized set the windows state to normal
                this.WindowState = FormWindowState.Normal; 
            }
            else
            {
                //if windows state is not maximized, maximize the window
                this.WindowState = FormWindowState.Maximized;
            }
        }

        //When the mouse (over) enters the button
        private void button2_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            button2.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            button2.BackColor = Color.Black;
        }

        /// <summary>
        /// Code for the Minimize button
        /// </summary>
        //When the button is clicked minimize the application
        private void button3_Click(object sender, EventArgs e)
        {
            //if windows state is maximized set the windows state to normal
            this.WindowState = FormWindowState.Minimized;
        }

        //When the mouse (over) enters the button
        private void button3_MouseEnter(object sender, EventArgs e)
        {
            //Change the button color to Dim Gray
            button3.BackColor = Color.DimGray;
        }

        //When the mouse (over) exits the button
        private void button3_MouseLeave(object sender, EventArgs e)
        {
            //Change the button color to Black
            button3.BackColor = Color.Black;
        }
    }
}


        
    
