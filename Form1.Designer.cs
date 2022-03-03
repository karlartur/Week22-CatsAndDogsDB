namespace ColordDB
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
            this.Shades = new System.Windows.Forms.Label();
            this.listShades = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listShadeNames = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // Shades
            // 
            this.Shades.AutoSize = true;
            this.Shades.Location = new System.Drawing.Point(56, 42);
            this.Shades.Name = "Shades";
            this.Shades.Size = new System.Drawing.Size(43, 13);
            this.Shades.TabIndex = 0;
            this.Shades.Text = "Shades";
            // 
            // listShades
            // 
            this.listShades.FormattingEnabled = true;
            this.listShades.Location = new System.Drawing.Point(59, 139);
            this.listShades.Name = "listShades";
            this.listShades.Size = new System.Drawing.Size(120, 95);
            this.listShades.TabIndex = 1;
            this.listShades.SelectedIndexChanged += new System.EventHandler(this.listShades_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Shade Names";
            // 
            // listShadeNames
            // 
            this.listShadeNames.FormattingEnabled = true;
            this.listShadeNames.Location = new System.Drawing.Point(312, 139);
            this.listShadeNames.Name = "listShadeNames";
            this.listShadeNames.Size = new System.Drawing.Size(120, 95);
            this.listShadeNames.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listShadeNames);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listShades);
            this.Controls.Add(this.Shades);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Shades;
        private System.Windows.Forms.ListBox listShades;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listShadeNames;
    }
}

