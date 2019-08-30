namespace wordMatchGame
{
    partial class Form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.label1 = new System.Windows.Forms.Label();
            this.lowBtn = new System.Windows.Forms.Button();
            this.mediumBtn = new System.Windows.Forms.Button();
            this.highBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Script MT Bold", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(184, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Select Level of Complexity";
            // 
            // lowBtn
            // 
            this.lowBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("lowBtn.BackgroundImage")));
            this.lowBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.lowBtn.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lowBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lowBtn.Location = new System.Drawing.Point(212, 103);
            this.lowBtn.Name = "lowBtn";
            this.lowBtn.Size = new System.Drawing.Size(100, 35);
            this.lowBtn.TabIndex = 1;
            this.lowBtn.Text = "LOW";
            this.lowBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lowBtn.UseVisualStyleBackColor = true;
            this.lowBtn.Click += new System.EventHandler(this.lowBtn_Click);
            // 
            // mediumBtn
            // 
            this.mediumBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("mediumBtn.BackgroundImage")));
            this.mediumBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.mediumBtn.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mediumBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mediumBtn.Location = new System.Drawing.Point(334, 139);
            this.mediumBtn.Name = "mediumBtn";
            this.mediumBtn.Size = new System.Drawing.Size(100, 35);
            this.mediumBtn.TabIndex = 2;
            this.mediumBtn.Text = "MEDIUM";
            this.mediumBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.mediumBtn.UseVisualStyleBackColor = true;
            this.mediumBtn.Click += new System.EventHandler(this.mediumBtn_Click);
            // 
            // highBtn
            // 
            this.highBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("highBtn.BackgroundImage")));
            this.highBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.highBtn.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.highBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.highBtn.Location = new System.Drawing.Point(460, 172);
            this.highBtn.Name = "highBtn";
            this.highBtn.Size = new System.Drawing.Size(100, 35);
            this.highBtn.TabIndex = 3;
            this.highBtn.Text = "HIGH";
            this.highBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.highBtn.UseVisualStyleBackColor = true;
            this.highBtn.Click += new System.EventHandler(this.highBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(584, 311);
            this.Controls.Add(this.highBtn);
            this.Controls.Add(this.mediumBtn);
            this.Controls.Add(this.lowBtn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.Text = "Word Match";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button lowBtn;
        private System.Windows.Forms.Button mediumBtn;
        private System.Windows.Forms.Button highBtn;
    }
}