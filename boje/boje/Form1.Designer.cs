namespace boje
{
    partial class FormaBoje
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
            this.PoljeZaUnos1 = new System.Windows.Forms.TextBox();
            this.labelaUunos1 = new System.Windows.Forms.Label();
            this.poljeZaUnos2 = new System.Windows.Forms.TextBox();
            this.PoljeZaUnos3 = new System.Windows.Forms.TextBox();
            this.labelaZaUnos2 = new System.Windows.Forms.Label();
            this.labelaZaUnos3 = new System.Windows.Forms.Label();
            this.GumbUnos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PoljeZaUnos1
            // 
            this.PoljeZaUnos1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoljeZaUnos1.Location = new System.Drawing.Point(240, 12);
            this.PoljeZaUnos1.Name = "PoljeZaUnos1";
            this.PoljeZaUnos1.Size = new System.Drawing.Size(130, 20);
            this.PoljeZaUnos1.TabIndex = 0;
            // 
            // labelaUunos1
            // 
            this.labelaUunos1.Location = new System.Drawing.Point(240, 39);
            this.labelaUunos1.Name = "labelaUunos1";
            this.labelaUunos1.Size = new System.Drawing.Size(130, 23);
            this.labelaUunos1.TabIndex = 1;
            this.labelaUunos1.Text = "Unesite prvi broj:";
            // 
            // poljeZaUnos2
            // 
            this.poljeZaUnos2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.poljeZaUnos2.Location = new System.Drawing.Point(391, 12);
            this.poljeZaUnos2.Name = "poljeZaUnos2";
            this.poljeZaUnos2.Size = new System.Drawing.Size(130, 20);
            this.poljeZaUnos2.TabIndex = 2;
            // 
            // PoljeZaUnos3
            // 
            this.PoljeZaUnos3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PoljeZaUnos3.Location = new System.Drawing.Point(538, 12);
            this.PoljeZaUnos3.Name = "PoljeZaUnos3";
            this.PoljeZaUnos3.Size = new System.Drawing.Size(130, 20);
            this.PoljeZaUnos3.TabIndex = 3;
            // 
            // labelaZaUnos2
            // 
            this.labelaZaUnos2.Location = new System.Drawing.Point(388, 35);
            this.labelaZaUnos2.Name = "labelaZaUnos2";
            this.labelaZaUnos2.Size = new System.Drawing.Size(130, 23);
            this.labelaZaUnos2.TabIndex = 4;
            this.labelaZaUnos2.Text = "Unesite drugi broj:";
            // 
            // labelaZaUnos3
            // 
            this.labelaZaUnos3.Location = new System.Drawing.Point(538, 35);
            this.labelaZaUnos3.Name = "labelaZaUnos3";
            this.labelaZaUnos3.Size = new System.Drawing.Size(130, 23);
            this.labelaZaUnos3.TabIndex = 5;
            this.labelaZaUnos3.Text = "Unesite treći broj:";
            // 
            // GumbUnos
            // 
            this.GumbUnos.Location = new System.Drawing.Point(391, 88);
            this.GumbUnos.Name = "GumbUnos";
            this.GumbUnos.Size = new System.Drawing.Size(75, 23);
            this.GumbUnos.TabIndex = 6;
            this.GumbUnos.Text = "Unesi boje";
            this.GumbUnos.UseVisualStyleBackColor = true;
            this.GumbUnos.Click += new System.EventHandler(this.GumbUnos_Click);
            // 
            // FormaBoje
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 145);
            this.Controls.Add(this.GumbUnos);
            this.Controls.Add(this.labelaZaUnos3);
            this.Controls.Add(this.labelaZaUnos2);
            this.Controls.Add(this.PoljeZaUnos3);
            this.Controls.Add(this.poljeZaUnos2);
            this.Controls.Add(this.labelaUunos1);
            this.Controls.Add(this.PoljeZaUnos1);
            this.Name = "FormaBoje";
            this.Text = "FormaBoje";
            this.Load += new System.EventHandler(this.FormaBoje_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox PoljeZaUnos1;
        private System.Windows.Forms.Label labelaUunos1;
        private System.Windows.Forms.TextBox poljeZaUnos2;
        private System.Windows.Forms.TextBox PoljeZaUnos3;
        private System.Windows.Forms.Label labelaZaUnos2;
        private System.Windows.Forms.Label labelaZaUnos3;
        private System.Windows.Forms.Button GumbUnos;
    }
}

