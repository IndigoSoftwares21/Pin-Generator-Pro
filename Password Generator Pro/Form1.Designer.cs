namespace Password_Generator_Pro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.output = new System.Windows.Forms.TextBox();
            this.gen = new System.Windows.Forms.Button();
            this.Copy = new System.Windows.Forms.Button();
            this.panel = new System.Windows.Forms.FlowLayoutPanel();
            this.copied = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // output
            // 
            this.output.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.output.Location = new System.Drawing.Point(12, 12);
            this.output.Name = "output";
            this.output.Size = new System.Drawing.Size(235, 39);
            this.output.TabIndex = 0;
            this.output.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.output.TextChanged += new System.EventHandler(this.output_TextChanged);
            // 
            // gen
            // 
            this.gen.BackColor = System.Drawing.Color.Yellow;
            this.gen.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gen.Location = new System.Drawing.Point(78, 158);
            this.gen.Name = "gen";
            this.gen.Size = new System.Drawing.Size(97, 34);
            this.gen.TabIndex = 1;
            this.gen.Text = "Generate";
            this.gen.UseVisualStyleBackColor = false;
            this.gen.Click += new System.EventHandler(this.gen_Click);
            // 
            // Copy
            // 
            this.Copy.BackColor = System.Drawing.Color.Indigo;
            this.Copy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copy.ForeColor = System.Drawing.Color.White;
            this.Copy.Location = new System.Drawing.Point(12, 80);
            this.Copy.Name = "Copy";
            this.Copy.Size = new System.Drawing.Size(77, 27);
            this.Copy.TabIndex = 2;
            this.Copy.Text = "Copy";
            this.Copy.UseVisualStyleBackColor = false;
            this.Copy.Click += new System.EventHandler(this.Copy_Click);
            // 
            // panel
            // 
            this.panel.BackColor = System.Drawing.Color.Red;
            this.panel.Controls.Add(this.copied);
            this.panel.Location = new System.Drawing.Point(12, 57);
            this.panel.Name = "panel";
            this.panel.Size = new System.Drawing.Size(199, 17);
            this.panel.TabIndex = 3;
            this.panel.Visible = false;
            // 
            // copied
            // 
            this.copied.AutoSize = true;
            this.copied.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copied.ForeColor = System.Drawing.Color.White;
            this.copied.Location = new System.Drawing.Point(3, 0);
            this.copied.Name = "copied";
            this.copied.Size = new System.Drawing.Size(134, 17);
            this.copied.TabIndex = 0;
            this.copied.Text = "Copied To ClipBoard!";
            this.copied.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Indigo;
            this.label1.Location = new System.Drawing.Point(15, 245);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "BROUGHT TO YOU BY INDIGO SOFTWARES";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 267);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel);
            this.Controls.Add(this.Copy);
            this.Controls.Add(this.gen);
            this.Controls.Add(this.output);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Pin Generator";
            this.panel.ResumeLayout(false);
            this.panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox output;
        private System.Windows.Forms.Button gen;
        private System.Windows.Forms.Button Copy;
        private System.Windows.Forms.FlowLayoutPanel panel;
        private System.Windows.Forms.Label copied;
        private System.Windows.Forms.Label label1;
    }
}

