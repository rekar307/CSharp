namespace GuGuDanAll
{
    partial class Form1
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
            label1 = new Label();
            button_run = new Button();
            textBox_res = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 17);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 0;
            label1.Text = "구구단 전체를 보여드립니다.";
            // 
            // button_run
            // 
            button_run.Location = new Point(245, 13);
            button_run.Name = "button_run";
            button_run.Size = new Size(75, 23);
            button_run.TabIndex = 1;
            button_run.Text = "실행";
            button_run.UseVisualStyleBackColor = true;
            button_run.Click += button_run_Click;
            // 
            // textBox_res
            // 
            textBox_res.Location = new Point(27, 50);
            textBox_res.Multiline = true;
            textBox_res.Name = "textBox_res";
            textBox_res.ScrollBars = ScrollBars.Vertical;
            textBox_res.Size = new Size(293, 161);
            textBox_res.TabIndex = 2;
            textBox_res.TextAlign = HorizontalAlignment.Center;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(342, 236);
            Controls.Add(textBox_res);
            Controls.Add(button_run);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button button_run;
        private TextBox textBox_res;
    }
}