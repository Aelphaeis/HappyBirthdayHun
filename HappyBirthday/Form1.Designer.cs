namespace HappyBirthday
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Stop = new System.Windows.Forms.Button();
            this.Play = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.Prev = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Stop);
            this.panel1.Controls.Add(this.Play);
            this.panel1.Controls.Add(this.Next);
            this.panel1.Controls.Add(this.Prev);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 450);
            this.panel1.TabIndex = 0;
            // 
            // Stop
            // 
            this.Stop.BackgroundImage = global::HappyBirthday.Properties.Resources.Stop_icon;
            this.Stop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stop.ForeColor = System.Drawing.Color.Transparent;
            this.Stop.Location = new System.Drawing.Point(28, 424);
            this.Stop.Name = "Stop";
            this.Stop.Size = new System.Drawing.Size(25, 25);
            this.Stop.TabIndex = 3;
            this.Stop.UseVisualStyleBackColor = true;
            this.Stop.Click += new System.EventHandler(this.Stop_Click);
            // 
            // Play
            // 
            this.Play.BackgroundImage = global::HappyBirthday.Properties.Resources.Play_icon;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Play.Location = new System.Drawing.Point(3, 424);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(25, 25);
            this.Play.TabIndex = 2;
            this.Play.UseVisualStyleBackColor = true;
            this.Play.Click += new System.EventHandler(this.Play_Click);
            // 
            // Next
            // 
            this.Next.BackColor = System.Drawing.Color.Transparent;
            this.Next.BackgroundImage = global::HappyBirthday.Resources.forward;
            this.Next.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Next.Location = new System.Drawing.Point(762, 196);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(35, 35);
            this.Next.TabIndex = 1;
            this.Next.UseVisualStyleBackColor = false;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // Prev
            // 
            this.Prev.BackColor = System.Drawing.Color.Transparent;
            this.Prev.BackgroundImage = global::HappyBirthday.Properties.Resources.back;
            this.Prev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Prev.FlatAppearance.BorderSize = 0;
            this.Prev.ForeColor = System.Drawing.Color.Transparent;
            this.Prev.Location = new System.Drawing.Point(3, 196);
            this.Prev.Margin = new System.Windows.Forms.Padding(0);
            this.Prev.Name = "Prev";
            this.Prev.Size = new System.Drawing.Size(35, 35);
            this.Prev.TabIndex = 0;
            this.Prev.UseVisualStyleBackColor = false;
            this.Prev.Click += new System.EventHandler(this.Prev_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 472);
            this.Controls.Add(this.panel1);
            this.DoubleBuffered = true;
            this.MaximumSize = new System.Drawing.Size(840, 510);
            this.MinimumSize = new System.Drawing.Size(840, 510);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Happy Birthday Hun";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Prev;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button Stop;
        private System.Windows.Forms.Button Play;
    }
}

