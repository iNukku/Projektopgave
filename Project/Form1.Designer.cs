namespace Project
{
    partial class Form1
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
            this.dice_label_1 = new System.Windows.Forms.Label();
            this.dice_label_2 = new System.Windows.Forms.Label();
            this.dice_label_3 = new System.Windows.Forms.Label();
            this.dice_label_4 = new System.Windows.Forms.Label();
            this.dice_label_5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dice_label_1
            // 
            this.dice_label_1.Location = new System.Drawing.Point(60, 60);
            this.dice_label_1.Name = "dice_label_1";
            this.dice_label_1.Size = new System.Drawing.Size(50, 50);
            this.dice_label_1.TabIndex = 0;
            this.dice_label_1.Text = "0";
            // 
            // dice_label_2
            // 
            this.dice_label_2.Location = new System.Drawing.Point(180, 60);
            this.dice_label_2.Name = "dice_label_2";
            this.dice_label_2.Size = new System.Drawing.Size(50, 50);
            this.dice_label_2.TabIndex = 1;
            this.dice_label_2.Text = "0";
            // 
            // dice_label_3
            // 
            this.dice_label_3.Location = new System.Drawing.Point(300, 60);
            this.dice_label_3.Name = "dice_label_3";
            this.dice_label_3.Size = new System.Drawing.Size(50, 50);
            this.dice_label_3.TabIndex = 2;
            this.dice_label_3.Text = "0";
            // 
            // dice_label_4
            // 
            this.dice_label_4.Location = new System.Drawing.Point(420, 60);
            this.dice_label_4.Name = "dice_label_4";
            this.dice_label_4.Size = new System.Drawing.Size(50, 50);
            this.dice_label_4.TabIndex = 3;
            this.dice_label_4.Text = "0";
            // 
            // dice_label_5
            // 
            this.dice_label_5.Location = new System.Drawing.Point(540, 60);
            this.dice_label_5.Name = "dice_label_5";
            this.dice_label_5.Size = new System.Drawing.Size(50, 50);
            this.dice_label_5.TabIndex = 4;
            this.dice_label_5.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 1144);
            this.Controls.Add(this.dice_label_5);
            this.Controls.Add(this.dice_label_4);
            this.Controls.Add(this.dice_label_3);
            this.Controls.Add(this.dice_label_2);
            this.Controls.Add(this.dice_label_1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label dice_label_1;
        private System.Windows.Forms.Label dice_label_2;
        private System.Windows.Forms.Label dice_label_3;
        private System.Windows.Forms.Label dice_label_4;
        private System.Windows.Forms.Label dice_label_5;
    }
}

