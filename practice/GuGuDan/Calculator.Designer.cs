namespace PeopleMngr
{
    partial class Calculator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button_run = new Button();
            label1 = new Label();
            textBox_num = new TextBox();
            textBox_res = new TextBox();
            SuspendLayout();
            //
            // button_run
            //
            button_run.Location = new Point(218, 39);
            button_run.Name = "button_run";
            button_run.Size = new Size(138, 23);
            button_run.TabIndex = 0;
            button_run.Text = "구구단 N단 출력";
            button_run.UseVisualStyleBackColor = true;
            button_run.Click += button_run_Click;
            //
            // label1
            //
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(330, 15);
            label1.TabIndex = 1;
            label1.Text = "구구단의 N 단값 (1~9)을 입력하시고 버튼을 눌러주세요 ^^";
            //
            // textBox_num
            //
            textBox_num.Location = new Point(12, 40);
            textBox_num.Name = "textBox_num";
            textBox_num.Size = new Size(100, 23);
            textBox_num.TabIndex = 2;
            //
            // textBox_res
            //
            textBox_res.Location = new Point(13, 81);
            textBox_res.Multiline = true;
            textBox_res.Name = "textBox_res";
            textBox_res.ScrollBars = ScrollBars.Vertical;
            textBox_res.Size = new Size(344, 232);
            textBox_res.TabIndex = 3;
            textBox_res.TextAlign = HorizontalAlignment.Center;
            //
            // Caculator
            //
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(369, 325);
            Controls.Add(textBox_res);
            Controls.Add(textBox_num);
            Controls.Add(label1);
            Controls.Add(button_run);
            Name = "Caculator";
            Text = "Caculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button_run;
        private Label label1;
        private TextBox textBox_num;
        private TextBox textBox_res;
    }
}