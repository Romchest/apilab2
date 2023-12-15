namespace Client
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
            magicBtn = new Button();
            firstNumberInput = new TextBox();
            secondNumberInput = new TextBox();
            sumResult = new TextBox();
            multResult = new TextBox();
            SuspendLayout();
            // 
            // magicBtn
            // 
            magicBtn.Location = new Point(85, 78);
            magicBtn.Name = "magicBtn";
            magicBtn.Size = new Size(134, 23);
            magicBtn.TabIndex = 0;
            magicBtn.Text = "Get sum and mult";
            magicBtn.UseVisualStyleBackColor = true;
            magicBtn.Click += magicBtn_Click;
            // 
            // firstNumberInput
            // 
            firstNumberInput.Location = new Point(30, 37);
            firstNumberInput.Name = "firstNumberInput";
            firstNumberInput.Size = new Size(100, 23);
            firstNumberInput.TabIndex = 1;
            firstNumberInput.Text = "10";
            // 
            // secondNumberInput
            // 
            secondNumberInput.Location = new Point(170, 37);
            secondNumberInput.Name = "secondNumberInput";
            secondNumberInput.Size = new Size(100, 23);
            secondNumberInput.TabIndex = 2;
            secondNumberInput.Text = "20";
            // 
            // sumResult
            // 
            sumResult.Location = new Point(98, 120);
            sumResult.Name = "sumResult";
            sumResult.Size = new Size(100, 23);
            sumResult.TabIndex = 3;
            // 
            // multResult
            // 
            multResult.Location = new Point(98, 149);
            multResult.Name = "multResult";
            multResult.Size = new Size(100, 23);
            multResult.TabIndex = 4;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(301, 218);
            Controls.Add(multResult);
            Controls.Add(sumResult);
            Controls.Add(secondNumberInput);
            Controls.Add(firstNumberInput);
            Controls.Add(magicBtn);
            Name = "Form1";
            Text = "lab2";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button magicBtn;
        private TextBox firstNumberInput;
        private TextBox secondNumberInput;
        private TextBox sumResult;
        private TextBox multResult;
    }
}
