namespace pr6
{
    partial class Pr6_2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            flowLayoutPanel1 = new FlowLayoutPanel();
            buttonResult = new Button();
            buttonReset = new Button();
            buttonBack = new Button();
            labelResult = new Label();
            label3 = new Label();
            textBoxStart = new TextBox();
            label4 = new Label();
            textBoxEnd = new TextBox();
            label5 = new Label();
            flowLayoutPanel2 = new FlowLayoutPanel();
            flowLayoutPanel1.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoSize = true;
            flowLayoutPanel1.Controls.Add(label3);
            flowLayoutPanel1.Controls.Add(textBoxStart);
            flowLayoutPanel1.Controls.Add(label4);
            flowLayoutPanel1.Controls.Add(textBoxEnd);
            flowLayoutPanel1.Controls.Add(buttonResult);
            flowLayoutPanel1.Controls.Add(buttonReset);
            flowLayoutPanel1.Controls.Add(buttonBack);
            flowLayoutPanel1.Controls.Add(labelResult);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 67);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Padding = new Padding(10);
            flowLayoutPanel1.Size = new Size(296, 359);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // buttonResult
            // 
            buttonResult.AutoSize = true;
            buttonResult.Location = new Point(13, 103);
            buttonResult.Name = "buttonResult";
            buttonResult.Size = new Size(267, 35);
            buttonResult.TabIndex = 0;
            buttonResult.Text = "Результат";
            buttonResult.UseVisualStyleBackColor = true;
            buttonResult.Click += buttonResult_Click;
            // 
            // buttonReset
            // 
            buttonReset.AutoSize = true;
            buttonReset.Location = new Point(13, 144);
            buttonReset.Name = "buttonReset";
            buttonReset.Size = new Size(267, 35);
            buttonReset.TabIndex = 1;
            buttonReset.Text = "Сброс";
            buttonReset.UseVisualStyleBackColor = true;
            buttonReset.Click += buttonReset_Click;
            // 
            // buttonBack
            // 
            buttonBack.AutoSize = true;
            buttonBack.Location = new Point(13, 185);
            buttonBack.Name = "buttonBack";
            buttonBack.Size = new Size(267, 35);
            buttonBack.TabIndex = 2;
            buttonBack.Text = "Вернуться";
            buttonBack.UseVisualStyleBackColor = true;
            buttonBack.Click += buttonBack_Click;
            // 
            // labelResult
            // 
            labelResult.AutoSize = true;
            labelResult.Location = new Point(13, 223);
            labelResult.Name = "labelResult";
            labelResult.Size = new Size(0, 25);
            labelResult.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(16, 10);
            label3.Margin = new Padding(6, 0, 6, 0);
            label3.Name = "label3";
            label3.Size = new Size(151, 32);
            label3.TabIndex = 13;
            label3.Text = "Начало";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxStart
            // 
            textBoxStart.Location = new Point(179, 16);
            textBoxStart.Margin = new Padding(6);
            textBoxStart.Name = "textBoxStart";
            textBoxStart.Size = new Size(101, 33);
            textBoxStart.TabIndex = 10;
            // 
            // label4
            // 
            label4.Location = new Point(16, 55);
            label4.Margin = new Padding(6, 0, 6, 0);
            label4.Name = "label4";
            label4.Size = new Size(151, 32);
            label4.TabIndex = 14;
            label4.Text = "Конец";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // textBoxEnd
            // 
            textBoxEnd.Location = new Point(179, 61);
            textBoxEnd.Margin = new Padding(6);
            textBoxEnd.Name = "textBoxEnd";
            textBoxEnd.Size = new Size(101, 33);
            textBoxEnd.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Location = new Point(25, 21);
            label5.Margin = new Padding(6, 0, 6, 0);
            label5.Name = "label5";
            label5.Size = new Size(144, 25);
            label5.TabIndex = 3;
            label5.Text = "Вывод массива";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(label5);
            flowLayoutPanel2.Dock = DockStyle.Top;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Margin = new Padding(6);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Padding = new Padding(19, 21, 19, 21);
            flowLayoutPanel2.Size = new Size(296, 67);
            flowLayoutPanel2.TabIndex = 12;
            // 
            // Pr6_2
            // 
            AutoScaleDimensions = new SizeF(11F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 426);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(flowLayoutPanel2);
            Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            Margin = new Padding(5);
            Name = "Pr6_2";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pr6_2";
            flowLayoutPanel1.ResumeLayout(false);
            flowLayoutPanel1.PerformLayout();
            flowLayoutPanel2.ResumeLayout(false);
            flowLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanel1;
        private Button buttonResult;
        private Button buttonReset;
        private Button buttonBack;
        private Label labelResult;
        private Label label3;
        private TextBox textBoxStart;
        private Label label4;
        private TextBox textBoxEnd;
        private Label label5;
        private FlowLayoutPanel flowLayoutPanel2;
    }
}