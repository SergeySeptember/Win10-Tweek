namespace Win10_Tweek
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
            checkBoxArrow = new CheckBox();
            buttonApply = new Button();
            SuspendLayout();
            // 
            // checkBoxArrow
            // 
            checkBoxArrow.AutoSize = true;
            checkBoxArrow.Location = new Point(34, 36);
            checkBoxArrow.Name = "checkBoxArrow";
            checkBoxArrow.Size = new Size(168, 19);
            checkBoxArrow.TabIndex = 2;
            checkBoxArrow.Text = "Удалить стрелки ярлыков";
            checkBoxArrow.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            buttonApply.Location = new Point(74, 207);
            buttonApply.Name = "buttonApply";
            buttonApply.Size = new Size(86, 23);
            buttonApply.TabIndex = 3;
            buttonApply.Text = "Применить";
            buttonApply.UseVisualStyleBackColor = true;
            buttonApply.Click += buttonApply_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(235, 242);
            Controls.Add(buttonApply);
            Controls.Add(checkBoxArrow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CheckBox checkBoxArrow;
        private Button buttonApply;
    }
}