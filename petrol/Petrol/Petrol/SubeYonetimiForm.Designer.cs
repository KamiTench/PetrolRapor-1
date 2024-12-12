using System.Windows.Forms;

namespace Petrol
{
    partial class SubeYonetimiForm
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
            this.components = new System.ComponentModel.Container();
            this.ıslemlerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolSatisSistemiDataSet = new Petrol.PetrolSatisSistemiDataSet();
            this.txtSubeAdres = new System.Windows.Forms.TextBox();
            this.btnSubeDuzenle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSubeEkle = new System.Windows.Forms.Button();
            this.btnSubeSil = new System.Windows.Forms.Button();
            this.txtSubeAd = new System.Windows.Forms.TextBox();
            this.subelerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.subelerTableAdapter = new Petrol.PetrolSatisSistemiDataSetTableAdapters.SubelerTableAdapter();
            this.subelerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.subelerBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.fKFirmalarSubeID3A81B327BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.firmalarTableAdapter = new Petrol.PetrolSatisSistemiDataSetTableAdapters.FirmalarTableAdapter();
            this.fKPersonellSubeI3D5E1FD2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.personellerTableAdapter = new Petrol.PetrolSatisSistemiDataSetTableAdapters.PersonellerTableAdapter();
            this.anaRezervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.anaRezervTableAdapter = new Petrol.PetrolSatisSistemiDataSetTableAdapters.AnaRezervTableAdapter();
            this.islemlerTableAdapter = new Petrol.PetrolSatisSistemiDataSetTableAdapters.IslemlerTableAdapter();
            this.subelerBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.petrolSatisSistemiDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakitlarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.yakitlarTableAdapter = new Petrol.PetrolSatisSistemiDataSetTableAdapters.YakitlarTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.subeIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ılDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adresDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subelerBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.txtIl = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSubeID = new System.Windows.Forms.TextBox();
            this.btnSubeGetir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ıslemlerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFirmalarSubeID3A81B327BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonellSubeI3D5E1FD2BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitlarBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource4)).BeginInit();
            this.SuspendLayout();
            // 
            // ıslemlerBindingSource
            // 
            this.ıslemlerBindingSource.DataMember = "Islemler";
            this.ıslemlerBindingSource.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // petrolSatisSistemiDataSet
            // 
            this.petrolSatisSistemiDataSet.DataSetName = "PetrolSatisSistemiDataSet";
            this.petrolSatisSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // txtSubeAdres
            // 
            this.txtSubeAdres.Location = new System.Drawing.Point(109, 147);
            this.txtSubeAdres.Name = "txtSubeAdres";
            this.txtSubeAdres.Size = new System.Drawing.Size(100, 22);
            this.txtSubeAdres.TabIndex = 1;
            // 
            // btnSubeDuzenle
            // 
            this.btnSubeDuzenle.Location = new System.Drawing.Point(217, 242);
            this.btnSubeDuzenle.Name = "btnSubeDuzenle";
            this.btnSubeDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnSubeDuzenle.TabIndex = 2;
            this.btnSubeDuzenle.Text = "Düzenle";
            this.btnSubeDuzenle.UseVisualStyleBackColor = true;
            this.btnSubeDuzenle.Click += new System.EventHandler(this.btnSubeDüzenle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Şube Adı";
            // 
            // btnSubeEkle
            // 
            this.btnSubeEkle.Location = new System.Drawing.Point(31, 243);
            this.btnSubeEkle.Name = "btnSubeEkle";
            this.btnSubeEkle.Size = new System.Drawing.Size(75, 23);
            this.btnSubeEkle.TabIndex = 4;
            this.btnSubeEkle.Text = "Ekle";
            this.btnSubeEkle.UseVisualStyleBackColor = true;
            this.btnSubeEkle.Click += new System.EventHandler(this.btnSubeEkle_Click);
            // 
            // btnSubeSil
            // 
            this.btnSubeSil.Location = new System.Drawing.Point(125, 243);
            this.btnSubeSil.Name = "btnSubeSil";
            this.btnSubeSil.Size = new System.Drawing.Size(75, 23);
            this.btnSubeSil.TabIndex = 5;
            this.btnSubeSil.Text = "Sil";
            this.btnSubeSil.UseVisualStyleBackColor = true;
            this.btnSubeSil.Click += new System.EventHandler(this.btnSubeSil_Click);
            // 
            // txtSubeAd
            // 
            this.txtSubeAd.Location = new System.Drawing.Point(109, 102);
            this.txtSubeAd.Name = "txtSubeAd";
            this.txtSubeAd.Size = new System.Drawing.Size(100, 22);
            this.txtSubeAd.TabIndex = 6;
            // 
            // subelerBindingSource
            // 
            this.subelerBindingSource.DataMember = "Subeler";
            this.subelerBindingSource.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // subelerTableAdapter
            // 
            this.subelerTableAdapter.ClearBeforeFill = true;
            // 
            // subelerBindingSource1
            // 
            this.subelerBindingSource1.DataMember = "Subeler";
            this.subelerBindingSource1.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // subelerBindingSource2
            // 
            this.subelerBindingSource2.DataMember = "Subeler";
            this.subelerBindingSource2.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // fKFirmalarSubeID3A81B327BindingSource
            // 
            this.fKFirmalarSubeID3A81B327BindingSource.DataMember = "FK__Firmalar__SubeID__3A81B327";
            this.fKFirmalarSubeID3A81B327BindingSource.DataSource = this.subelerBindingSource2;
            // 
            // firmalarTableAdapter
            // 
            this.firmalarTableAdapter.ClearBeforeFill = true;
            // 
            // fKPersonellSubeI3D5E1FD2BindingSource
            // 
            this.fKPersonellSubeI3D5E1FD2BindingSource.DataMember = "FK__Personell__SubeI__3D5E1FD2";
            this.fKPersonellSubeI3D5E1FD2BindingSource.DataSource = this.subelerBindingSource2;
            // 
            // personellerTableAdapter
            // 
            this.personellerTableAdapter.ClearBeforeFill = true;
            // 
            // anaRezervBindingSource
            // 
            this.anaRezervBindingSource.DataMember = "AnaRezerv";
            this.anaRezervBindingSource.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // anaRezervTableAdapter
            // 
            this.anaRezervTableAdapter.ClearBeforeFill = true;
            // 
            // islemlerTableAdapter
            // 
            this.islemlerTableAdapter.ClearBeforeFill = true;
            // 
            // subelerBindingSource3
            // 
            this.subelerBindingSource3.DataMember = "Subeler";
            this.subelerBindingSource3.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // petrolSatisSistemiDataSetBindingSource
            // 
            this.petrolSatisSistemiDataSetBindingSource.DataSource = this.petrolSatisSistemiDataSet;
            this.petrolSatisSistemiDataSetBindingSource.Position = 0;
            // 
            // yakitlarBindingSource
            // 
            this.yakitlarBindingSource.DataMember = "Yakitlar";
            this.yakitlarBindingSource.DataSource = this.petrolSatisSistemiDataSetBindingSource;
            // 
            // yakitlarTableAdapter
            // 
            this.yakitlarTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.subeIDDataGridViewTextBoxColumn,
            this.subeAdiDataGridViewTextBoxColumn,
            this.ılDataGridViewTextBoxColumn,
            this.adresDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.subelerBindingSource4;
            this.dataGridView1.Location = new System.Drawing.Point(298, 102);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(374, 225);
            this.dataGridView1.TabIndex = 7;
            // 
            // subeIDDataGridViewTextBoxColumn
            // 
            this.subeIDDataGridViewTextBoxColumn.DataPropertyName = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.HeaderText = "SubeID";
            this.subeIDDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeIDDataGridViewTextBoxColumn.Name = "subeIDDataGridViewTextBoxColumn";
            this.subeIDDataGridViewTextBoxColumn.ReadOnly = true;
            this.subeIDDataGridViewTextBoxColumn.Width = 125;
            // 
            // subeAdiDataGridViewTextBoxColumn
            // 
            this.subeAdiDataGridViewTextBoxColumn.DataPropertyName = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.HeaderText = "SubeAdi";
            this.subeAdiDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.subeAdiDataGridViewTextBoxColumn.Name = "subeAdiDataGridViewTextBoxColumn";
            this.subeAdiDataGridViewTextBoxColumn.Width = 125;
            // 
            // ılDataGridViewTextBoxColumn
            // 
            this.ılDataGridViewTextBoxColumn.DataPropertyName = "Il";
            this.ılDataGridViewTextBoxColumn.HeaderText = "Il";
            this.ılDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ılDataGridViewTextBoxColumn.Name = "ılDataGridViewTextBoxColumn";
            this.ılDataGridViewTextBoxColumn.Width = 125;
            // 
            // adresDataGridViewTextBoxColumn
            // 
            this.adresDataGridViewTextBoxColumn.DataPropertyName = "Adres";
            this.adresDataGridViewTextBoxColumn.HeaderText = "Adres";
            this.adresDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.adresDataGridViewTextBoxColumn.Name = "adresDataGridViewTextBoxColumn";
            this.adresDataGridViewTextBoxColumn.Width = 125;
            // 
            // subelerBindingSource4
            // 
            this.subelerBindingSource4.DataMember = "Subeler";
            this.subelerBindingSource4.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // txtIl
            // 
            this.txtIl.Location = new System.Drawing.Point(109, 191);
            this.txtIl.Name = "txtIl";
            this.txtIl.Size = new System.Drawing.Size(100, 22);
            this.txtIl.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(55, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Şube İli";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 16);
            this.label3.TabIndex = 10;
            this.label3.Text = "Şube Adresi";
            // 
            // txtSubeID
            // 
            this.txtSubeID.Location = new System.Drawing.Point(109, 36);
            this.txtSubeID.Name = "txtSubeID";
            this.txtSubeID.Size = new System.Drawing.Size(100, 22);
            this.txtSubeID.TabIndex = 11;
            // 
            // btnSubeGetir
            // 
            this.btnSubeGetir.Location = new System.Drawing.Point(235, 36);
            this.btnSubeGetir.Name = "btnSubeGetir";
            this.btnSubeGetir.Size = new System.Drawing.Size(75, 23);
            this.btnSubeGetir.TabIndex = 12;
            this.btnSubeGetir.Text = "Listele";
            this.btnSubeGetir.UseVisualStyleBackColor = true;
            this.btnSubeGetir.Click += new System.EventHandler(this.btnSubeGetir_Click);

            // 
            // SubeYonetimiForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubeGetir);
            this.Controls.Add(this.txtSubeID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIl);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSubeAd);
            this.Controls.Add(this.btnSubeSil);
            this.Controls.Add(this.btnSubeEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSubeDuzenle);
            this.Controls.Add(this.txtSubeAdres);
            this.Name = "SubeYonetimiForm";
            this.Text = "SubeYonetimiForm";
            ((System.ComponentModel.ISupportInitialize)(this.ıslemlerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKFirmalarSubeID3A81B327BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKPersonellSubeI3D5E1FD2BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.yakitlarBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.subelerBindingSource4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSubeAdres;
        private System.Windows.Forms.Button btnSubeDuzenle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSubeEkle;
        private System.Windows.Forms.Button btnSubeSil;
        private System.Windows.Forms.TextBox txtSubeAd;
        private PetrolSatisSistemiDataSet petrolSatisSistemiDataSet;
        private System.Windows.Forms.BindingSource subelerBindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.SubelerTableAdapter subelerTableAdapter;
        private System.Windows.Forms.BindingSource subelerBindingSource2;
        private System.Windows.Forms.BindingSource subelerBindingSource1;
        private System.Windows.Forms.BindingSource fKFirmalarSubeID3A81B327BindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.FirmalarTableAdapter firmalarTableAdapter;
        private System.Windows.Forms.BindingSource fKPersonellSubeI3D5E1FD2BindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.PersonellerTableAdapter personellerTableAdapter;
        private System.Windows.Forms.BindingSource anaRezervBindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.AnaRezervTableAdapter anaRezervTableAdapter;
        private System.Windows.Forms.BindingSource ıslemlerBindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.IslemlerTableAdapter islemlerTableAdapter;
        private System.Windows.Forms.BindingSource subelerBindingSource3;
        private System.Windows.Forms.BindingSource petrolSatisSistemiDataSetBindingSource;
        private System.Windows.Forms.BindingSource yakitlarBindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.YakitlarTableAdapter yakitlarTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ılDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adresDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource subelerBindingSource4;
        private System.Windows.Forms.TextBox txtIl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private TextBox txtSubeID;
        private Button btnSubeGetir;
    }
}