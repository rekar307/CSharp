namespace GuGuDanAll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_run_Click(object sender, EventArgs e)
        {
            int num = 9;
            textBox_res.Text = "";
            textBox_res.Multiline = true;
            for (int i = 1; i < num; ++i)
            {
                for (int j = 1; j < num; ++j)
                {
                    textBox_res.Text += (i + " x " + j + " = " + i * j + "\r\n");
                }
                textBox_res.Text += "\r\n";
            }
        }
    }
}