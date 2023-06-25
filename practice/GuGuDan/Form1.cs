namespace PeopleMngr
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            if (int.TryParse(textBox_num.Text, out int n))
            {
                textBox_res.Text = "";
                textBox_res.Multiline = true;
                for (int i = 1; i <= 9; ++i)
                {
                    textBox_res.Text += textBox_num.Text + " x " + i + " = " + (n * i) + Environment.NewLine;
                }
            }
            else
            {
                textBox_res.Text = "��ȿ�� ���ڸ� �Է��ϼ���";
                textBox_num.Text = "";
                textBox_num.Focus();
            }
        }
    }
}