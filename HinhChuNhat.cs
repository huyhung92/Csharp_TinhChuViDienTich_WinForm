using System.Runtime.CompilerServices;

namespace Csharp_TinhChuViDienTich_WinForm
{
    public partial class HinhChuNhat : Form
    {
        public HinhChuNhat()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void tcv_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(dai.Text);
            b = Convert.ToDouble(rong.Text);
            kqcv.Text = tinhchuvi(a,b).ToString();
        }

        private void tdt_Click(object sender, EventArgs e)
        {
            double a, b;
            a = Convert.ToDouble(dai.Text);
            b = Convert.ToDouble(rong.Text);
            kqdt.Text = tinhdientich(a,b).ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private double tinhchuvi(double a, double b)
        {
            return (a + b) * 2;
        }

        private double tinhdientich(double a, double b)
        {
            return (a * b);
        }
    }   
}





