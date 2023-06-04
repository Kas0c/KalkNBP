namespace KalkNBP
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
            label2 = new Label();
            label3 = new Label();
            EURRate = new TextBox();
            USDRate = new TextBox();
            JPYRate = new TextBox();
            label4 = new Label();
            PLNAmount = new TextBox();
            EURradioButton = new RadioButton();
            USDradioButton = new RadioButton();
            JPYradioButton = new RadioButton();
            Exchange = new TextBox();
            label5 = new Label();
            ExchangeBtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(102, 258);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 0;
            label1.Text = "Kurs EUR";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(284, 258);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 1;
            label2.Text = "Kurs USD";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(466, 258);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 2;
            label3.Text = "Kurs JPY";
            // 
            // EURRate
            // 
            EURRate.Location = new Point(162, 255);
            EURRate.Name = "EURRate";
            EURRate.Size = new Size(100, 23);
            EURRate.TabIndex = 3;
            // 
            // USDRate
            // 
            USDRate.Location = new Point(344, 255);
            USDRate.Name = "USDRate";
            USDRate.Size = new Size(100, 23);
            USDRate.TabIndex = 4;
            // 
            // JPYRate
            // 
            JPYRate.Location = new Point(523, 255);
            JPYRate.Name = "JPYRate";
            JPYRate.Size = new Size(100, 23);
            JPYRate.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 84);
            label4.Name = "label4";
            label4.Size = new Size(65, 15);
            label4.TabIndex = 6;
            label4.Text = "Kwota PLN";
            // 
            // PLNAmount
            // 
            PLNAmount.Location = new Point(226, 102);
            PLNAmount.Name = "PLNAmount";
            PLNAmount.Size = new Size(100, 23);
            PLNAmount.TabIndex = 7;
            // 
            // EURradioButton
            // 
            EURradioButton.AutoSize = true;
            EURradioButton.Location = new Point(360, 131);
            EURradioButton.Name = "EURradioButton";
            EURradioButton.Size = new Size(46, 19);
            EURradioButton.TabIndex = 8;
            EURradioButton.TabStop = true;
            EURradioButton.Text = "EUR";
            EURradioButton.UseVisualStyleBackColor = true;
            // 
            // USDradioButton
            // 
            USDradioButton.AutoSize = true;
            USDradioButton.Location = new Point(359, 156);
            USDradioButton.Name = "USDradioButton";
            USDradioButton.Size = new Size(47, 19);
            USDradioButton.TabIndex = 9;
            USDradioButton.TabStop = true;
            USDradioButton.Text = "USD";
            USDradioButton.UseVisualStyleBackColor = true;
            // 
            // JPYradioButton
            // 
            JPYradioButton.AutoSize = true;
            JPYradioButton.Location = new Point(359, 181);
            JPYradioButton.Name = "JPYradioButton";
            JPYradioButton.Size = new Size(43, 19);
            JPYradioButton.TabIndex = 10;
            JPYradioButton.TabStop = true;
            JPYradioButton.Text = "JPY";
            JPYradioButton.UseVisualStyleBackColor = true;
            // 
            // Exchange
            // 
            Exchange.Location = new Point(360, 102);
            Exchange.Name = "Exchange";
            Exchange.Size = new Size(100, 23);
            Exchange.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(360, 84);
            label5.Name = "label5";
            label5.Size = new Size(65, 15);
            label5.TabIndex = 12;
            label5.Text = "Otrzymasz:";
            // 
            // ExchangeBtn
            // 
            ExchangeBtn.Location = new Point(466, 102);
            ExchangeBtn.Name = "ExchangeBtn";
            ExchangeBtn.Size = new Size(75, 23);
            ExchangeBtn.TabIndex = 13;
            ExchangeBtn.Text = "Przelicz";
            ExchangeBtn.UseVisualStyleBackColor = true;
            ExchangeBtn.Click += ExchangeBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(716, 369);
            Controls.Add(ExchangeBtn);
            Controls.Add(label5);
            Controls.Add(Exchange);
            Controls.Add(JPYradioButton);
            Controls.Add(USDradioButton);
            Controls.Add(EURradioButton);
            Controls.Add(PLNAmount);
            Controls.Add(label4);
            Controls.Add(JPYRate);
            Controls.Add(USDRate);
            Controls.Add(EURRate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += GetRates;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox EURRate;
        private TextBox USDRate;
        private TextBox JPYRate;
        private Label label4;
        private TextBox PLNAmount;
        private RadioButton EURradioButton;
        private RadioButton USDradioButton;
        private RadioButton JPYradioButton;
        private TextBox Exchange;
        private Label label5;
        private Button ExchangeBtn;
    }
}