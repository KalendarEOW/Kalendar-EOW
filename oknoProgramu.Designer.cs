
namespace Kalendář_EOW_Release
{
    partial class oknoProgramu
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.popisekDatumG = new System.Windows.Forms.Label();
            this.popisekDatumEOW = new System.Windows.Forms.Label();
            this.popisekDny = new System.Windows.Forms.Label();
            this.popisekLetG = new System.Windows.Forms.Label();
            this.poleLetG = new System.Windows.Forms.TextBox();
            this.poleEOW = new System.Windows.Forms.TextBox();
            this.poleG = new System.Windows.Forms.TextBox();
            this.ciselnikDny = new System.Windows.Forms.NumericUpDown();
            this.ukazatelChyb = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikDny)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukazatelChyb)).BeginInit();
            this.SuspendLayout();
            // 
            // popisekDatumG
            // 
            this.popisekDatumG.AutoSize = true;
            this.popisekDatumG.Location = new System.Drawing.Point(30, 35);
            this.popisekDatumG.Name = "popisekDatumG";
            this.popisekDatumG.Size = new System.Drawing.Size(167, 13);
            this.popisekDatumG.TabIndex = 1;
            this.popisekDatumG.Text = "Datum Gregoriánského kalendáře";
            // 
            // popisekDatumEOW
            // 
            this.popisekDatumEOW.AutoSize = true;
            this.popisekDatumEOW.Location = new System.Drawing.Point(30, 62);
            this.popisekDatumEOW.Name = "popisekDatumEOW";
            this.popisekDatumEOW.Size = new System.Drawing.Size(118, 13);
            this.popisekDatumEOW.TabIndex = 1;
            this.popisekDatumEOW.Text = "Datum EOW kalendáře";
            // 
            // popisekDny
            // 
            this.popisekDny.AutoSize = true;
            this.popisekDny.Location = new System.Drawing.Point(30, 118);
            this.popisekDny.Name = "popisekDny";
            this.popisekDny.Size = new System.Drawing.Size(104, 13);
            this.popisekDny.TabIndex = 1;
            this.popisekDny.Text = "Dnů do konce světa";
            // 
            // popisekLetG
            // 
            this.popisekLetG.AutoSize = true;
            this.popisekLetG.Location = new System.Drawing.Point(30, 149);
            this.popisekLetG.Name = "popisekLetG";
            this.popisekLetG.Size = new System.Drawing.Size(228, 13);
            this.popisekLetG.TabIndex = 1;
            this.popisekLetG.Text = "Let Gregoriánského kalendáře do konce světa";
            // 
            // poleLetG
            // 
            this.poleLetG.Location = new System.Drawing.Point(264, 145);
            this.poleLetG.Name = "poleLetG";
            this.poleLetG.ReadOnly = true;
            this.poleLetG.Size = new System.Drawing.Size(210, 20);
            this.poleLetG.TabIndex = 3;
            // 
            // poleEOW
            // 
            this.poleEOW.Location = new System.Drawing.Point(264, 59);
            this.poleEOW.Name = "poleEOW";
            this.poleEOW.ReadOnly = true;
            this.poleEOW.Size = new System.Drawing.Size(210, 20);
            this.poleEOW.TabIndex = 4;
            this.poleEOW.Click += new System.EventHandler(this.poleEOW_Click);
            // 
            // poleG
            // 
            this.poleG.Location = new System.Drawing.Point(264, 28);
            this.poleG.Name = "poleG";
            this.poleG.ReadOnly = true;
            this.poleG.Size = new System.Drawing.Size(210, 20);
            this.poleG.TabIndex = 5;
            this.poleG.Click += new System.EventHandler(this.poleDatumuG_Click);
            // 
            // ciselnikDny
            // 
            this.ciselnikDny.Location = new System.Drawing.Point(264, 114);
            this.ciselnikDny.Maximum = new decimal(new int[] {
            -1140850688,
            680719811,
            -1377379250,
            0});
            this.ciselnikDny.Minimum = new decimal(new int[] {
            -1140850688,
            680719811,
            -1377379250,
            -2147483648});
            this.ciselnikDny.Name = "ciselnikDny";
            this.ciselnikDny.Size = new System.Drawing.Size(210, 20);
            this.ciselnikDny.TabIndex = 6;
            this.ciselnikDny.ValueChanged += new System.EventHandler(this.ciselnikDny_ValueChanged);
            this.ciselnikDny.Validating += new System.ComponentModel.CancelEventHandler(this.ciselnikDny_Validating);
            this.ciselnikDny.Validated += new System.EventHandler(this.ciselnikDny_Validated);
            // 
            // ukazatelChyb
            // 
            this.ukazatelChyb.ContainerControl = this;
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(494, 184);
            this.Controls.Add(this.ciselnikDny);
            this.Controls.Add(this.poleG);
            this.Controls.Add(this.poleEOW);
            this.Controls.Add(this.poleLetG);
            this.Controls.Add(this.popisekDny);
            this.Controls.Add(this.popisekLetG);
            this.Controls.Add(this.popisekDatumEOW);
            this.Controls.Add(this.popisekDatumG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "oknoProgramu";
            this.Text = "Kalendář EOW";
            this.Load += new System.EventHandler(this.oknoProgramu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ciselnikDny)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ukazatelChyb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekDatumG;
        private System.Windows.Forms.Label popisekDatumEOW;
        private System.Windows.Forms.Label popisekDny;
        private System.Windows.Forms.Label popisekLetG;
        private System.Windows.Forms.TextBox poleLetG;
        private System.Windows.Forms.TextBox poleEOW;
        private System.Windows.Forms.TextBox poleG;
        private System.Windows.Forms.NumericUpDown ciselnikDny;
        private System.Windows.Forms.ErrorProvider ukazatelChyb;
    }
}

