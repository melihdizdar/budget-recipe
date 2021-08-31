namespace ButceTarif
{
    partial class Form_Tarif
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dg_tarif = new System.Windows.Forms.DataGridView();
            this.btn_geridon = new System.Windows.Forms.Button();
            this.Pictures_Panel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.dg_tarif)).BeginInit();
            this.SuspendLayout();
            // 
            // dg_tarif
            // 
            this.dg_tarif.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dg_tarif.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Snow;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dg_tarif.DefaultCellStyle = dataGridViewCellStyle2;
            this.dg_tarif.Location = new System.Drawing.Point(12, 12);
            this.dg_tarif.Name = "dg_tarif";
            this.dg_tarif.Size = new System.Drawing.Size(842, 382);
            this.dg_tarif.TabIndex = 0;
            // 
            // btn_geridon
            // 
            this.btn_geridon.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_geridon.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_geridon.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_geridon.Location = new System.Drawing.Point(783, 511);
            this.btn_geridon.Name = "btn_geridon";
            this.btn_geridon.Size = new System.Drawing.Size(71, 32);
            this.btn_geridon.TabIndex = 9;
            this.btn_geridon.Text = "Geri Dön";
            this.btn_geridon.UseVisualStyleBackColor = false;
            this.btn_geridon.Click += new System.EventHandler(this.button1_Click);
            // 
            // Pictures_Panel
            // 
            this.Pictures_Panel.Location = new System.Drawing.Point(12, 400);
            this.Pictures_Panel.Name = "Pictures_Panel";
            this.Pictures_Panel.Size = new System.Drawing.Size(840, 105);
            this.Pictures_Panel.TabIndex = 11;
            // 
            // Form_Tarif
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(864, 548);
            this.Controls.Add(this.Pictures_Panel);
            this.Controls.Add(this.btn_geridon);
            this.Controls.Add(this.dg_tarif);
            this.Name = "Form_Tarif";
            this.Text = "Bütçe Tarif";
            this.Load += new System.EventHandler(this.Form_Tarif_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dg_tarif)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dg_tarif;
        private System.Windows.Forms.Button btn_geridon;
        private System.Windows.Forms.FlowLayoutPanel Pictures_Panel;
    }
}