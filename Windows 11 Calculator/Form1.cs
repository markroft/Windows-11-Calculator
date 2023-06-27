using System.Runtime.InteropServices;

namespace Windows_11_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string a = "";
        string b = "";
        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_MouseEnter(object sender, EventArgs e)
        {
           label3.BackColor = Color.FromArgb(255,0,0);
           
        }

        private void label3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_MouseLeave(object sender, EventArgs e)
        {
            label3.BackColor = Color.FromArgb(32, 32, 34);

        }

        private void label5_MouseEnter(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(48,48,48);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseLeave(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(28,28,28);
        }

        private void label13_MouseEnter(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(28, 28, 28);
        }

        private void label13_MouseLeave(object sender, EventArgs e)
        {
            var lbl = (Label)sender;
            lbl.BackColor = Color.FromArgb(48, 48, 48);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HTCAPTION = 0x2;
        [DllImport("User32.dll")]
        public static extern bool ReleaseCapture();
        [DllImport("User32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HTCAPTION, 0);
            }
        }

        private void label13_Click(object sender, EventArgs e)
        {
            
           
        }

        private void label13_MouseClick(object sender, MouseEventArgs e)
        {

            if (label36.Text == "0")
            {
                label36.Text = "";
                var sighn = (Label)sender;

                label36.Text += sighn.Text;
            }
            else
            {
                var sighn = (Label)sender;

                label36.Text += sighn.Text;
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {
            var sighn = (Label)sender;
            if (label36.Text.Contains(sighn.Text)) { }
            else { label36.Text += sighn.Text; }


        }

        private void label8_Click(object sender, EventArgs e)
        {
            string displaytext = label36.Text;
            label36.Text = displaytext.Remove(displaytext.Length - 1, 1);
        }

        private void label6_Click(object sender, EventArgs e)
        {
            label36.Text = "";
        }

        private void label12_MouseClick(object sender, MouseEventArgs e)
        {
            var sighn = (Label)sender;
            a = label36.Text;
            label37.Text = label36.Text+sighn.Text;
            label36.Text = "";
        }

        private void label28_Click(object sender, EventArgs e)
        {
            if (label37.Text.Contains("+"))
            {
                label37.Text = label37.Text + label36.Text + "=";
                label36.Text = (int.Parse(a) + int.Parse(label36.Text)).ToString();
            }
            if (label37.Text.Contains("-"))
            {
                label37.Text = label37.Text + label36.Text + "=";
                label36.Text = (int.Parse(a) - int.Parse(label36.Text)).ToString();
            }
        }

        

        private void label7_Click(object sender, EventArgs e)
        {
            label37.Text = "";
            label36.Text = "";
        }
    }
}