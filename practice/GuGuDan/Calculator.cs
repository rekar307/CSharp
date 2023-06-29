namespace PeopleMngr
{
    public partial class Calculator : Form
    {
        public Calculator()
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
                    textBox_res.AppendText(textBox_num.Text + " x " + i + " = " + (n * i) + "\r\n");
                }
            }
            else
            {
                textBox_res.Text = "유효한 숫자를 입력하세요";
                textBox_num.Text = "";
                textBox_num.Focus();
            }
        }
    }
}