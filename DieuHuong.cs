namespace LAB02_DACBIET
{
    public partial class DieuHuong : Form
    {
        public DieuHuong()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Lab02_Bai01 form = new Lab02_Bai01();
            form.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Lab02_Bai02 form = new Lab02_Bai02();
            form.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Lab02_Bai03 form = new Lab02_Bai03();
            form.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Lab02_Bai04 form = new Lab02_Bai04();
            form.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Lab02_Bai05 form = new Lab02_Bai05();
            form.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Lab02_Bai06 form = new Lab02_Bai06();
            form.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Lab02_Bai07 form = new Lab02_Bai07();
            form.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
