
namespace _135_Forms_kutuphane_otomasyon
{
    partial class UyeSayfasi
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
            this.btn_ktpara = new System.Windows.Forms.Button();
            this.btn_ktpyenile = new System.Windows.Forms.Button();
            this.txt_ktpid = new System.Windows.Forms.TextBox();
            this.btn_cikis = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Kitapid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapismi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Kitapyazar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kitapdili = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yayinevi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tür = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sayfasayisi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.basimyil = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_ktpara
            // 
            this.btn_ktpara.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ktpara.Location = new System.Drawing.Point(286, 44);
            this.btn_ktpara.Name = "btn_ktpara";
            this.btn_ktpara.Size = new System.Drawing.Size(86, 29);
            this.btn_ktpara.TabIndex = 0;
            this.btn_ktpara.Text = "Ara";
            this.btn_ktpara.UseVisualStyleBackColor = true;
            this.btn_ktpara.Click += new System.EventHandler(this.btn_ktpara_Click);
            // 
            // btn_ktpyenile
            // 
            this.btn_ktpyenile.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_ktpyenile.Location = new System.Drawing.Point(437, 44);
            this.btn_ktpyenile.Name = "btn_ktpyenile";
            this.btn_ktpyenile.Size = new System.Drawing.Size(93, 29);
            this.btn_ktpyenile.TabIndex = 1;
            this.btn_ktpyenile.Text = "Yenile";
            this.btn_ktpyenile.UseVisualStyleBackColor = true;
            this.btn_ktpyenile.Click += new System.EventHandler(this.btn_ktpyenile_Click);
            // 
            // txt_ktpid
            // 
            this.txt_ktpid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txt_ktpid.Location = new System.Drawing.Point(378, 44);
            this.txt_ktpid.Name = "txt_ktpid";
            this.txt_ktpid.Size = new System.Drawing.Size(53, 29);
            this.txt_ktpid.TabIndex = 2;
            // 
            // btn_cikis
            // 
            this.btn_cikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_cikis.Location = new System.Drawing.Point(337, 383);
            this.btn_cikis.Name = "btn_cikis";
            this.btn_cikis.Size = new System.Drawing.Size(128, 46);
            this.btn_cikis.TabIndex = 4;
            this.btn_cikis.Text = "Çıkış";
            this.btn_cikis.UseVisualStyleBackColor = true;
            this.btn_cikis.Click += new System.EventHandler(this.btn_cikis_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Kitapid,
            this.kitapismi,
            this.Kitapyazar,
            this.kitapdili,
            this.yayinevi,
            this.tür,
            this.adet,
            this.sayfasayisi,
            this.basimyil});
            this.dataGridView1.Location = new System.Drawing.Point(30, 91);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(744, 276);
            this.dataGridView1.TabIndex = 5;
            // 
            // Kitapid
            // 
            this.Kitapid.HeaderText = "KİTAP ID";
            this.Kitapid.Name = "Kitapid";
            this.Kitapid.Width = 75;
            // 
            // kitapismi
            // 
            this.kitapismi.HeaderText = "KİTAP İSMİ ";
            this.kitapismi.Name = "kitapismi";
            // 
            // Kitapyazar
            // 
            this.Kitapyazar.HeaderText = "YAZARI";
            this.Kitapyazar.Name = "Kitapyazar";
            this.Kitapyazar.Width = 75;
            // 
            // kitapdili
            // 
            this.kitapdili.HeaderText = "DİL";
            this.kitapdili.Name = "kitapdili";
            this.kitapdili.Width = 75;
            // 
            // yayinevi
            // 
            this.yayinevi.HeaderText = "YAYINEVİ";
            this.yayinevi.Name = "yayinevi";
            this.yayinevi.Width = 75;
            // 
            // tür
            // 
            this.tür.HeaderText = "TÜR";
            this.tür.Name = "tür";
            this.tür.Width = 75;
            // 
            // adet
            // 
            this.adet.HeaderText = "ADET";
            this.adet.Name = "adet";
            this.adet.Width = 75;
            // 
            // sayfasayisi
            // 
            this.sayfasayisi.HeaderText = "SAYFA SAYİSİ";
            this.sayfasayisi.Name = "sayfasayisi";
            this.sayfasayisi.Width = 75;
            // 
            // basimyil
            // 
            this.basimyil.HeaderText = "BASIM YILI";
            this.basimyil.Name = "basimyil";
            this.basimyil.Width = 75;
            // 
            // UyeSayfasi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_cikis);
            this.Controls.Add(this.txt_ktpid);
            this.Controls.Add(this.btn_ktpyenile);
            this.Controls.Add(this.btn_ktpara);
            this.Name = "UyeSayfasi";
            this.Text = "UyeSayfasi";
            this.Load += new System.EventHandler(this.UyeSayfasi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_ktpara;
        private System.Windows.Forms.Button btn_ktpyenile;
        private System.Windows.Forms.TextBox txt_ktpid;
        private System.Windows.Forms.Button btn_cikis;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapid;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapismi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Kitapyazar;
        private System.Windows.Forms.DataGridViewTextBoxColumn kitapdili;
        private System.Windows.Forms.DataGridViewTextBoxColumn yayinevi;
        private System.Windows.Forms.DataGridViewTextBoxColumn tür;
        private System.Windows.Forms.DataGridViewTextBoxColumn adet;
        private System.Windows.Forms.DataGridViewTextBoxColumn sayfasayisi;
        private System.Windows.Forms.DataGridViewTextBoxColumn basimyil;
    }
}