
namespace Kalendář_EOW
{
    partial class kalendarEOW
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
            this.ciselnikDen = new System.Windows.Forms.NumericUpDown();
            this.ciselnikRok = new System.Windows.Forms.NumericUpDown();
            this.ciselnikMesic = new System.Windows.Forms.NumericUpDown();
            this.popisekDen = new System.Windows.Forms.Label();
            this.popisekRok = new System.Windows.Forms.Label();
            this.popisekMesic = new System.Windows.Forms.Label();
            this.tlacitkoZrusit = new System.Windows.Forms.Button();
            this.tlacitkoOK = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikRok)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikMesic)).BeginInit();
            this.SuspendLayout();
            // 
            // ciselnikDen
            // 
            this.ciselnikDen.Location = new System.Drawing.Point(98, 16);
            this.ciselnikDen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ciselnikDen.Maximum = new decimal(new int[] {
            69,
            0,
            0,
            0});
            this.ciselnikDen.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ciselnikDen.Name = "ciselnikDen";
            this.ciselnikDen.Size = new System.Drawing.Size(90, 20);
            this.ciselnikDen.TabIndex = 1;
            this.ciselnikDen.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ciselnikRok
            // 
            this.ciselnikRok.Location = new System.Drawing.Point(98, 62);
            this.ciselnikRok.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ciselnikRok.Maximum = new decimal(new int[] {
            4500,
            0,
            0,
            0});
            this.ciselnikRok.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.ciselnikRok.Name = "ciselnikRok";
            this.ciselnikRok.Size = new System.Drawing.Size(90, 20);
            this.ciselnikRok.TabIndex = 5;
            this.ciselnikRok.Value = new decimal(new int[] {
            3500,
            0,
            0,
            0});
            // 
            // ciselnikMesic
            // 
            this.ciselnikMesic.Location = new System.Drawing.Point(98, 39);
            this.ciselnikMesic.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.ciselnikMesic.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
            this.ciselnikMesic.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ciselnikMesic.Name = "ciselnikMesic";
            this.ciselnikMesic.Size = new System.Drawing.Size(90, 20);
            this.ciselnikMesic.TabIndex = 3;
            this.ciselnikMesic.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // popisekDen
            // 
            this.popisekDen.AutoSize = true;
            this.popisekDen.Location = new System.Drawing.Point(29, 18);
            this.popisekDen.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisekDen.Name = "popisekDen";
            this.popisekDen.Size = new System.Drawing.Size(27, 13);
            this.popisekDen.TabIndex = 0;
            this.popisekDen.Text = "Den";
            // 
            // popisekRok
            // 
            this.popisekRok.AutoSize = true;
            this.popisekRok.Location = new System.Drawing.Point(29, 63);
            this.popisekRok.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisekRok.Name = "popisekRok";
            this.popisekRok.Size = new System.Drawing.Size(27, 13);
            this.popisekRok.TabIndex = 4;
            this.popisekRok.Text = "Rok";
            // 
            // popisekMesic
            // 
            this.popisekMesic.AutoSize = true;
            this.popisekMesic.Location = new System.Drawing.Point(29, 41);
            this.popisekMesic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.popisekMesic.Name = "popisekMesic";
            this.popisekMesic.Size = new System.Drawing.Size(37, 13);
            this.popisekMesic.TabIndex = 2;
            this.popisekMesic.Text = "Měsíc";
            // 
            // tlacitkoZrusit
            // 
            this.tlacitkoZrusit.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.tlacitkoZrusit.Location = new System.Drawing.Point(32, 91);
            this.tlacitkoZrusit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlacitkoZrusit.Name = "tlacitkoZrusit";
            this.tlacitkoZrusit.Size = new System.Drawing.Size(75, 41);
            this.tlacitkoZrusit.TabIndex = 6;
            this.tlacitkoZrusit.Text = "Zpět";
            this.tlacitkoZrusit.UseVisualStyleBackColor = true;
            this.tlacitkoZrusit.Click += new System.EventHandler(this.tlacitkoZrusit_Click);
            // 
            // tlacitkoOK
            // 
            this.tlacitkoOK.Location = new System.Drawing.Point(112, 91);
            this.tlacitkoOK.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tlacitkoOK.Name = "tlacitkoOK";
            this.tlacitkoOK.Size = new System.Drawing.Size(75, 41);
            this.tlacitkoOK.TabIndex = 7;
            this.tlacitkoOK.Text = "OK";
            this.tlacitkoOK.UseVisualStyleBackColor = true;
            this.tlacitkoOK.Click += new System.EventHandler(this.tlacitkoOK_Click);
            // 
            // kalendarEOW
            // 
            this.AcceptButton = this.tlacitkoOK;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.tlacitkoZrusit;
            this.ClientSize = new System.Drawing.Size(214, 151);
            this.Controls.Add(this.tlacitkoOK);
            this.Controls.Add(this.tlacitkoZrusit);
            this.Controls.Add(this.popisekMesic);
            this.Controls.Add(this.popisekRok);
            this.Controls.Add(this.popisekDen);
            this.Controls.Add(this.ciselnikMesic);
            this.Controls.Add(this.ciselnikRok);
            this.Controls.Add(this.ciselnikDen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "kalendarEOW";
            this.ShowInTaskbar = false;
            this.Text = "Kalendář EOW";
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikRok)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikMesic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown ciselnikDen;
        private System.Windows.Forms.NumericUpDown ciselnikRok;
        private System.Windows.Forms.NumericUpDown ciselnikMesic;
        private System.Windows.Forms.Label popisekDen;
        private System.Windows.Forms.Label popisekRok;
        private System.Windows.Forms.Label popisekMesic;
        private System.Windows.Forms.Button tlacitkoZrusit;
        private System.Windows.Forms.Button tlacitkoOK;
    }
}