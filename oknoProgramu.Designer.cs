
namespace Kalendář_EOW
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
            this.popisekDatumG = new System.Windows.Forms.Label();
            this.UkazatelDatumuG = new System.Windows.Forms.DateTimePicker();
            this.popisekDatumEOW = new System.Windows.Forms.Label();
            this.popisekDny = new System.Windows.Forms.Label();
            this.popisekLetG = new System.Windows.Forms.Label();
            this.poleDny = new System.Windows.Forms.TextBox();
            this.poleLetG = new System.Windows.Forms.TextBox();
            this.poleEOW = new System.Windows.Forms.TextBox();
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
            // UkazatelDatumuG
            // 
            this.UkazatelDatumuG.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.UkazatelDatumuG.Location = new System.Drawing.Point(264, 29);
            this.UkazatelDatumuG.Name = "UkazatelDatumuG";
            this.UkazatelDatumuG.Size = new System.Drawing.Size(200, 20);
            this.UkazatelDatumuG.TabIndex = 2;
            this.UkazatelDatumuG.Value = new System.DateTime(2022, 5, 17, 0, 0, 0, 0);
            this.UkazatelDatumuG.ValueChanged += new System.EventHandler(this.datumG_ValueChanged);
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
            this.popisekDny.Location = new System.Drawing.Point(30, 152);
            this.popisekDny.Name = "popisekDny";
            this.popisekDny.Size = new System.Drawing.Size(104, 13);
            this.popisekDny.TabIndex = 1;
            this.popisekDny.Text = "Dnů do konce světa";
            this.popisekDny.Visible = false;
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
            // poleDny
            // 
            this.poleDny.Location = new System.Drawing.Point(264, 145);
            this.poleDny.Name = "poleDny";
            this.poleDny.ReadOnly = true;
            this.poleDny.Size = new System.Drawing.Size(200, 20);
            this.poleDny.TabIndex = 3;
            this.poleDny.Visible = false;
            this.poleDny.TextChanged += new System.EventHandler(this.poleDny_TextChanged);
            // 
            // poleLetG
            // 
            this.poleLetG.Location = new System.Drawing.Point(264, 145);
            this.poleLetG.Name = "poleLetG";
            this.poleLetG.ReadOnly = true;
            this.poleLetG.Size = new System.Drawing.Size(200, 20);
            this.poleLetG.TabIndex = 3;
            // 
            // poleEOW
            // 
            this.poleEOW.Location = new System.Drawing.Point(264, 59);
            this.poleEOW.Name = "poleEOW";
            this.poleEOW.ReadOnly = true;
            this.poleEOW.Size = new System.Drawing.Size(200, 20);
            this.poleEOW.TabIndex = 4;
            this.poleEOW.Click += new System.EventHandler(this.poleEOW_Click);
            this.poleEOW.TextChanged += new System.EventHandler(this.poleEOW_TextChanged);
            // 
            // oknoProgramu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 184);
            this.Controls.Add(this.poleEOW);
            this.Controls.Add(this.poleLetG);
            this.Controls.Add(this.poleDny);
            this.Controls.Add(this.UkazatelDatumuG);
            this.Controls.Add(this.popisekDny);
            this.Controls.Add(this.popisekLetG);
            this.Controls.Add(this.popisekDatumEOW);
            this.Controls.Add(this.popisekDatumG);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "oknoProgramu";
            this.Text = "Kalendář EOW";
            this.Load += new System.EventHandler(this.oknoProgramu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label popisekDatumG;
        private System.Windows.Forms.DateTimePicker UkazatelDatumuG;
        private System.Windows.Forms.Label popisekDatumEOW;
        private System.Windows.Forms.Label popisekDny;
        private System.Windows.Forms.Label popisekLetG;
        private System.Windows.Forms.TextBox poleDny;
        private System.Windows.Forms.TextBox poleLetG;
        private System.Windows.Forms.TextBox poleEOW;
    }
}

