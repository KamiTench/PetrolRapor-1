namespace Petrol
{
    partial class AnaForm
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.anaRezervBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.petrolSatisSistemiDataSet = new Petrol.PetrolSatisSistemiDataSet();
            this.anaRezervTableAdapter = new Petrol.PetrolSatisSistemiDataSetTableAdapters.AnaRezervTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.şubeYönetimiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubeleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.şubeEkleDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelleriListeleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personelEkleDüzenleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakıtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakıtSatışıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yakıtStokDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.anaRezervToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rezervDurumuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.taleplerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(377, 384);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // anaRezervBindingSource
            // 
            this.anaRezervBindingSource.DataMember = "AnaRezerv";
            this.anaRezervBindingSource.DataSource = this.petrolSatisSistemiDataSet;
            // 
            // petrolSatisSistemiDataSet
            // 
            this.petrolSatisSistemiDataSet.DataSetName = "PetrolSatisSistemiDataSet";
            this.petrolSatisSistemiDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // anaRezervTableAdapter
            // 
            this.anaRezervTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şubeYönetimiToolStripMenuItem,
            this.personelToolStripMenuItem,
            this.yakıtToolStripMenuItem,
            this.anaRezervToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // şubeYönetimiToolStripMenuItem
            // 
            this.şubeYönetimiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.şubeleriListeleToolStripMenuItem,
            this.şubeEkleDüzenleToolStripMenuItem});
            this.şubeYönetimiToolStripMenuItem.Name = "şubeYönetimiToolStripMenuItem";
            this.şubeYönetimiToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.şubeYönetimiToolStripMenuItem.Text = "Şubeler";
            this.şubeYönetimiToolStripMenuItem.Click += new System.EventHandler(this.şubeYönetimiToolStripMenuItem_Click);
            // 
            // şubeleriListeleToolStripMenuItem
            // 
            this.şubeleriListeleToolStripMenuItem.Name = "şubeleriListeleToolStripMenuItem";
            this.şubeleriListeleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.şubeleriListeleToolStripMenuItem.Text = "Şubeleri Listele";
            // 
            // şubeEkleDüzenleToolStripMenuItem
            // 
            this.şubeEkleDüzenleToolStripMenuItem.Name = "şubeEkleDüzenleToolStripMenuItem";
            this.şubeEkleDüzenleToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.şubeEkleDüzenleToolStripMenuItem.Text = "Şube Ekle/Düzenle";
            // 
            // personelToolStripMenuItem
            // 
            this.personelToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personelleriListeleToolStripMenuItem,
            this.personelEkleDüzenleToolStripMenuItem});
            this.personelToolStripMenuItem.Name = "personelToolStripMenuItem";
            this.personelToolStripMenuItem.Size = new System.Drawing.Size(82, 24);
            this.personelToolStripMenuItem.Text = "Personel ";
            this.personelToolStripMenuItem.Click += new System.EventHandler(this.personelToolStripMenuItem_Click);
            // 
            // personelleriListeleToolStripMenuItem
            // 
            this.personelleriListeleToolStripMenuItem.Name = "personelleriListeleToolStripMenuItem";
            this.personelleriListeleToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.personelleriListeleToolStripMenuItem.Text = "Personelleri Listele";
            // 
            // personelEkleDüzenleToolStripMenuItem
            // 
            this.personelEkleDüzenleToolStripMenuItem.Name = "personelEkleDüzenleToolStripMenuItem";
            this.personelEkleDüzenleToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.personelEkleDüzenleToolStripMenuItem.Text = "Personel Ekle/Düzenle";
            // 
            // yakıtToolStripMenuItem
            // 
            this.yakıtToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yakıtSatışıToolStripMenuItem,
            this.yakıtStokDurumuToolStripMenuItem});
            this.yakıtToolStripMenuItem.Name = "yakıtToolStripMenuItem";
            this.yakıtToolStripMenuItem.Size = new System.Drawing.Size(54, 24);
            this.yakıtToolStripMenuItem.Text = "Yakıt";
            this.yakıtToolStripMenuItem.Click += new System.EventHandler(this.yakıtToolStripMenuItem_Click);
            // 
            // yakıtSatışıToolStripMenuItem
            // 
            this.yakıtSatışıToolStripMenuItem.Name = "yakıtSatışıToolStripMenuItem";
            this.yakıtSatışıToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.yakıtSatışıToolStripMenuItem.Text = "Yakıt Satışı";
            // 
            // yakıtStokDurumuToolStripMenuItem
            // 
            this.yakıtStokDurumuToolStripMenuItem.Name = "yakıtStokDurumuToolStripMenuItem";
            this.yakıtStokDurumuToolStripMenuItem.Size = new System.Drawing.Size(213, 26);
            this.yakıtStokDurumuToolStripMenuItem.Text = "Yakıt Stok Durumu";
            // 
            // anaRezervToolStripMenuItem
            // 
            this.anaRezervToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rezervDurumuToolStripMenuItem,
            this.taleplerToolStripMenuItem});
            this.anaRezervToolStripMenuItem.Name = "anaRezervToolStripMenuItem";
            this.anaRezervToolStripMenuItem.Size = new System.Drawing.Size(97, 24);
            this.anaRezervToolStripMenuItem.Text = "Ana Rezerv";
            this.anaRezervToolStripMenuItem.Click += new System.EventHandler(this.anaRezervToolStripMenuItem_Click);
            // 
            // rezervDurumuToolStripMenuItem
            // 
            this.rezervDurumuToolStripMenuItem.Name = "rezervDurumuToolStripMenuItem";
            this.rezervDurumuToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.rezervDurumuToolStripMenuItem.Text = "Rezerv Durumu";
            // 
            // taleplerToolStripMenuItem
            // 
            this.taleplerToolStripMenuItem.Name = "taleplerToolStripMenuItem";
            this.taleplerToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.taleplerToolStripMenuItem.Text = "Talepler";
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.çıkışToolStripMenuItem.Text = "Çıkış";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 347);
            this.panel1.TabIndex = 3;
            // 
            // AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AnaForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.anaRezervBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.petrolSatisSistemiDataSet)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private PetrolSatisSistemiDataSet petrolSatisSistemiDataSet;
        private System.Windows.Forms.BindingSource anaRezervBindingSource;
        private PetrolSatisSistemiDataSetTableAdapters.AnaRezervTableAdapter anaRezervTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem şubeYönetimiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakıtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anaRezervToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personelEkleDüzenleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakıtSatışıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem yakıtStokDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rezervDurumuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem taleplerToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem şubeleriListeleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem şubeEkleDüzenleToolStripMenuItem;
    }
}

