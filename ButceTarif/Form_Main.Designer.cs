namespace ButceTarif
{
    partial class Form_Main
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
            this.btn_temizle = new System.Windows.Forms.Button();
            this.btn_sil = new System.Windows.Forms.Button();
            this.l_cesit = new System.Windows.Forms.Label();
            this.btn_ekle = new System.Windows.Forms.Button();
            this.tb_ekle = new System.Windows.Forms.TextBox();
            this.lb_cesit = new System.Windows.Forms.ListBox();
            this.btn_tlistele = new System.Windows.Forms.Button();
            this.l_butce = new System.Windows.Forms.Label();
            this.tb_butce = new System.Windows.Forms.TextBox();
            this.btn_mlistele = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_temizle
            // 
            this.btn_temizle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_temizle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_temizle.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_temizle.Location = new System.Drawing.Point(329, 75);
            this.btn_temizle.Name = "btn_temizle";
            this.btn_temizle.Size = new System.Drawing.Size(65, 23);
            this.btn_temizle.TabIndex = 82;
            this.btn_temizle.Text = "Temizle";
            this.btn_temizle.UseVisualStyleBackColor = false;
            this.btn_temizle.Click += new System.EventHandler(this.btn_temizle_Click);
            // 
            // btn_sil
            // 
            this.btn_sil.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_sil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_sil.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_sil.Location = new System.Drawing.Point(329, 46);
            this.btn_sil.Name = "btn_sil";
            this.btn_sil.Size = new System.Drawing.Size(65, 23);
            this.btn_sil.TabIndex = 81;
            this.btn_sil.Text = "Sil";
            this.btn_sil.UseVisualStyleBackColor = false;
            this.btn_sil.Click += new System.EventHandler(this.btn_sil_Click);
            // 
            // l_cesit
            // 
            this.l_cesit.AutoSize = true;
            this.l_cesit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_cesit.ForeColor = System.Drawing.SystemColors.Control;
            this.l_cesit.Location = new System.Drawing.Point(-1, 180);
            this.l_cesit.Name = "l_cesit";
            this.l_cesit.Size = new System.Drawing.Size(101, 13);
            this.l_cesit.TabIndex = 80;
            this.l_cesit.Text = "Çeşit Ekleyiniz : ";
            // 
            // btn_ekle
            // 
            this.btn_ekle.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_ekle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ekle.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_ekle.Location = new System.Drawing.Point(249, 175);
            this.btn_ekle.Name = "btn_ekle";
            this.btn_ekle.Size = new System.Drawing.Size(47, 23);
            this.btn_ekle.TabIndex = 79;
            this.btn_ekle.Text = "Ekle";
            this.btn_ekle.UseVisualStyleBackColor = false;
            this.btn_ekle.Click += new System.EventHandler(this.btn_ekle_Click);
            // 
            // tb_ekle
            // 
            this.tb_ekle.Location = new System.Drawing.Point(103, 177);
            this.tb_ekle.Name = "tb_ekle";
            this.tb_ekle.Size = new System.Drawing.Size(136, 20);
            this.tb_ekle.TabIndex = 78;
            // 
            // lb_cesit
            // 
            this.lb_cesit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.lb_cesit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lb_cesit.ForeColor = System.Drawing.SystemColors.Window;
            this.lb_cesit.FormattingEnabled = true;
            this.lb_cesit.Items.AddRange(new object[] {
            "Ana Yemek",
            "Tatli",
            "Meze"});
            this.lb_cesit.Location = new System.Drawing.Point(12, 63);
            this.lb_cesit.Name = "lb_cesit";
            this.lb_cesit.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lb_cesit.Size = new System.Drawing.Size(312, 95);
            this.lb_cesit.TabIndex = 77;
            // 
            // btn_tlistele
            // 
            this.btn_tlistele.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_tlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_tlistele.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_tlistele.Location = new System.Drawing.Point(326, 155);
            this.btn_tlistele.Name = "btn_tlistele";
            this.btn_tlistele.Size = new System.Drawing.Size(67, 47);
            this.btn_tlistele.TabIndex = 76;
            this.btn_tlistele.Text = "Tarif Listele";
            this.btn_tlistele.UseVisualStyleBackColor = false;
            this.btn_tlistele.Click += new System.EventHandler(this.btn_listele_Click);
            // 
            // l_butce
            // 
            this.l_butce.AutoSize = true;
            this.l_butce.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.l_butce.ForeColor = System.Drawing.SystemColors.Control;
            this.l_butce.Location = new System.Drawing.Point(67, 24);
            this.l_butce.Name = "l_butce";
            this.l_butce.Size = new System.Drawing.Size(110, 13);
            this.l_butce.TabIndex = 74;
            this.l_butce.Text = "Bütçenizi Giriniz : ";
            // 
            // tb_butce
            // 
            this.tb_butce.Location = new System.Drawing.Point(179, 21);
            this.tb_butce.Name = "tb_butce";
            this.tb_butce.Size = new System.Drawing.Size(92, 20);
            this.tb_butce.TabIndex = 75;
            // 
            // btn_mlistele
            // 
            this.btn_mlistele.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_mlistele.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_mlistele.ForeColor = System.Drawing.SystemColors.Control;
            this.btn_mlistele.Location = new System.Drawing.Point(327, 104);
            this.btn_mlistele.Name = "btn_mlistele";
            this.btn_mlistele.Size = new System.Drawing.Size(67, 47);
            this.btn_mlistele.TabIndex = 83;
            this.btn_mlistele.Text = "Menü Listele";
            this.btn_mlistele.UseVisualStyleBackColor = false;
            this.btn_mlistele.Click += new System.EventHandler(this.btn_mlistele_Click);
            // 
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(406, 223);
            this.Controls.Add(this.btn_mlistele);
            this.Controls.Add(this.btn_temizle);
            this.Controls.Add(this.btn_sil);
            this.Controls.Add(this.l_cesit);
            this.Controls.Add(this.btn_ekle);
            this.Controls.Add(this.tb_ekle);
            this.Controls.Add(this.lb_cesit);
            this.Controls.Add(this.btn_tlistele);
            this.Controls.Add(this.l_butce);
            this.Controls.Add(this.tb_butce);
            this.Name = "Form_Main";
            this.Text = "Bütçe Tarif";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_temizle;
        private System.Windows.Forms.Button btn_sil;
        private System.Windows.Forms.Label l_cesit;
        private System.Windows.Forms.Button btn_ekle;
        private System.Windows.Forms.TextBox tb_ekle;
        private System.Windows.Forms.ListBox lb_cesit;
        private System.Windows.Forms.Button btn_tlistele;
        private System.Windows.Forms.Label l_butce;
        private System.Windows.Forms.TextBox tb_butce;
        private System.Windows.Forms.Button btn_mlistele;
    }
}