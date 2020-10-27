namespace WindowsFormsTrial
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
            this.btnclickme = new System.Windows.Forms.Button();
            this.lbGreetings = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnclickme
            // 
            this.btnclickme.Location = new System.Drawing.Point(306, 102);
            this.btnclickme.Name = "btnclickme";
            this.btnclickme.Size = new System.Drawing.Size(75, 23);
            this.btnclickme.TabIndex = 0;
            this.btnclickme.Text = "Click Me";
            this.btnclickme.UseVisualStyleBackColor = true;
            this.btnclickme.Click += new System.EventHandler(this.btnclickme_Click);
            // 
            // lbGreetings
            // 
            this.lbGreetings.AutoSize = true;
            this.lbGreetings.Location = new System.Drawing.Point(324, 168);
            this.lbGreetings.Name = "lbGreetings";
            this.lbGreetings.Size = new System.Drawing.Size(35, 13);
            this.lbGreetings.TabIndex = 1;
            this.lbGreetings.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbGreetings);
            this.Controls.Add(this.btnclickme);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnclickme;
        private System.Windows.Forms.Label lbGreetings;
    }
}

