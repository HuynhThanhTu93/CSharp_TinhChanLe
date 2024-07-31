namespace CSharp_TinhChanLe
{
    public partial class Form1 : Form
    {
        int Min;
        int Max;
        int Sum = 0;
        int Tich = 1;
        int Chan;
        int Le;
        public Form1()
        {
            InitializeComponent();
        }
        private void LayThongTin()
        {
            try
            {
                Min = Convert.ToInt32(txtMin.Text);
                Max = Convert.ToInt32(txtMax.Text);
            }
            catch
            {
                MessageBox.Show("Phải nhập số thập phân hoặc số nguyên", "Thông báo lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtMin.Clear();
                txtMax.Clear();
            }
        }
        private void TinhTong()
        {
            LayThongTin();
            for (int i = Min; i <= Max; i++)
            {
                Sum += i;
            }
        }
        private void TinhTich()
        {
            LayThongTin();
            for (int i = Min; i <= Max; i++)
            {
                Tich *= i;
            }
        }
        private void TinhChan()
        {
            for (int i = 2; i <= Max; i += 2)
            {
                Chan += i;
            }
        }
        private void TinhLe()
        {
            for (int i = 1; i <= Max; i += 2)
            {
                Le += i;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LayThongTin();
            TinhTong();
            TinhTich();
            TinhChan();
            TinhLe  ();
            lblTong.Text = Sum.ToString();
            lblTich.Text = Tich.ToString();
            lblChan.Text = Chan.ToString();
            lblLe.Text = Le.ToString();
        }    

     }
}
