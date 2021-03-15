
namespace WindowsFormsApp1
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridViewREISCH = new System.Windows.Forms.DataGridView();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewEISCH = new System.Windows.Forms.DataGridView();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewLICH = new System.Windows.Forms.DataGridView();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewBLISCH = new System.Windows.Forms.DataGridView();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dataGridViewRandomArrayKeys = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label11 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.buttonLICH_Ara = new System.Windows.Forms.Button();
            this.buttonEISCH_Ara = new System.Windows.Forms.Button();
            this.buttonBLISCH_Ara = new System.Windows.Forms.Button();
            this.buttonREISCH_Ara = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.labelPerfBLISCH = new System.Windows.Forms.Label();
            this.labelPerfLICH = new System.Windows.Forms.Label();
            this.labelPerfEISCH = new System.Windows.Forms.Label();
            this.labelPerfREISCH = new System.Windows.Forms.Label();
            this.textBoxRandomKeysDiziBoyutu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.primaryAreaSize = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.labelAvrLICH = new System.Windows.Forms.Label();
            this.labelAvrEISCH = new System.Windows.Forms.Label();
            this.labelAvrBLISCH = new System.Windows.Forms.Label();
            this.labelAvrREISCH = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.TotalAreaSize = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.PackingFactorSize = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewREISCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEISCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLICH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBLISCH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandomArrayKeys)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(15, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 51);
            this.button1.TabIndex = 0;
            this.button1.Text = "Create Array with Random Keys\r\n";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridViewREISCH
            // 
            this.dataGridViewREISCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewREISCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column12,
            this.Column13,
            this.Column14,
            this.Column15});
            this.dataGridViewREISCH.Location = new System.Drawing.Point(827, 157);
            this.dataGridViewREISCH.Name = "dataGridViewREISCH";
            this.dataGridViewREISCH.Size = new System.Drawing.Size(213, 289);
            this.dataGridViewREISCH.TabIndex = 1;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Index";
            this.Column12.Name = "Column12";
            this.Column12.Width = 40;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Record";
            this.Column13.Name = "Column13";
            this.Column13.Width = 45;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Link";
            this.Column14.Name = "Column14";
            this.Column14.Width = 45;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Probe";
            this.Column15.Name = "Column15";
            this.Column15.Width = 40;
            // 
            // dataGridViewEISCH
            // 
            this.dataGridViewEISCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEISCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column17});
            this.dataGridViewEISCH.Location = new System.Drawing.Point(389, 156);
            this.dataGridViewEISCH.Name = "dataGridViewEISCH";
            this.dataGridViewEISCH.Size = new System.Drawing.Size(213, 290);
            this.dataGridViewEISCH.TabIndex = 2;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Index";
            this.Column3.Name = "Column3";
            this.Column3.Width = 40;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Record";
            this.Column4.Name = "Column4";
            this.Column4.Width = 45;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Link";
            this.Column5.Name = "Column5";
            this.Column5.Width = 45;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Probe";
            this.Column17.Name = "Column17";
            this.Column17.Width = 40;
            // 
            // dataGridViewLICH
            // 
            this.dataGridViewLICH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLICH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column18});
            this.dataGridViewLICH.Location = new System.Drawing.Point(170, 156);
            this.dataGridViewLICH.Name = "dataGridViewLICH";
            this.dataGridViewLICH.Size = new System.Drawing.Size(213, 290);
            this.dataGridViewLICH.TabIndex = 3;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Index";
            this.Column6.Name = "Column6";
            this.Column6.Width = 40;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Record";
            this.Column7.Name = "Column7";
            this.Column7.Width = 45;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Link";
            this.Column8.Name = "Column8";
            this.Column8.Width = 45;
            // 
            // Column18
            // 
            this.Column18.HeaderText = "Probe";
            this.Column18.Name = "Column18";
            this.Column18.Width = 40;
            // 
            // dataGridViewBLISCH
            // 
            this.dataGridViewBLISCH.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBLISCH.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column16});
            this.dataGridViewBLISCH.Location = new System.Drawing.Point(608, 156);
            this.dataGridViewBLISCH.Name = "dataGridViewBLISCH";
            this.dataGridViewBLISCH.Size = new System.Drawing.Size(213, 289);
            this.dataGridViewBLISCH.TabIndex = 4;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Index";
            this.Column9.Name = "Column9";
            this.Column9.Width = 40;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Record";
            this.Column10.Name = "Column10";
            this.Column10.Width = 45;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Link";
            this.Column11.Name = "Column11";
            this.Column11.Width = 45;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Probe";
            this.Column16.Name = "Column16";
            this.Column16.Width = 40;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1065, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(552, 52);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(100, 20);
            this.textBoxSearch.TabIndex = 9;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(888, 52);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(118, 20);
            this.textBox3.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(249, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 12;
            this.label2.Text = "LICH";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(898, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(85, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "REISCH";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(666, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 24);
            this.label5.TabIndex = 17;
            this.label5.Text = "BLISCH";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(464, 129);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 24);
            this.label6.TabIndex = 18;
            this.label6.Text = "EISCH";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label9.Location = new System.Drawing.Point(536, 15);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(116, 18);
            this.label9.TabIndex = 21;
            this.label9.Text = "Search Number ";
            // 
            // dataGridViewRandomArrayKeys
            // 
            this.dataGridViewRandomArrayKeys.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRandomArrayKeys.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            this.dataGridViewRandomArrayKeys.Location = new System.Drawing.Point(3, 157);
            this.dataGridViewRandomArrayKeys.Name = "dataGridViewRandomArrayKeys";
            this.dataGridViewRandomArrayKeys.Size = new System.Drawing.Size(161, 289);
            this.dataGridViewRandomArrayKeys.TabIndex = 24;
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.Column1.HeaderText = "Index";
            this.Column1.Name = "Column1";
            this.Column1.Width = 58;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Keys";
            this.Column2.MinimumWidth = 3;
            this.Column2.Name = "Column2";
            this.Column2.Width = 60;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label11.Location = new System.Drawing.Point(31, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(114, 20);
            this.label11.TabIndex = 25;
            this.label11.Text = "RandomKeys";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(414, 15);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(116, 32);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sort";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(956, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 23);
            this.label1.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label7.Location = new System.Drawing.Point(1042, 18);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(142, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Probe of Serch Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label10.Location = new System.Drawing.Point(885, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(110, 30);
            this.label10.TabIndex = 23;
            this.label10.Text = "The address of  \r\nSearched Value";
            // 
            // buttonLICH_Ara
            // 
            this.buttonLICH_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonLICH_Ara.Location = new System.Drawing.Point(693, 8);
            this.buttonLICH_Ara.Name = "buttonLICH_Ara";
            this.buttonLICH_Ara.Size = new System.Drawing.Size(155, 23);
            this.buttonLICH_Ara.TabIndex = 27;
            this.buttonLICH_Ara.Text = "Search on LICH";
            this.buttonLICH_Ara.UseVisualStyleBackColor = true;
            this.buttonLICH_Ara.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonEISCH_Ara
            // 
            this.buttonEISCH_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonEISCH_Ara.Location = new System.Drawing.Point(693, 37);
            this.buttonEISCH_Ara.Name = "buttonEISCH_Ara";
            this.buttonEISCH_Ara.Size = new System.Drawing.Size(155, 23);
            this.buttonEISCH_Ara.TabIndex = 28;
            this.buttonEISCH_Ara.Text = "Search on EISCH";
            this.buttonEISCH_Ara.UseVisualStyleBackColor = true;
            this.buttonEISCH_Ara.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonBLISCH_Ara
            // 
            this.buttonBLISCH_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonBLISCH_Ara.Location = new System.Drawing.Point(693, 62);
            this.buttonBLISCH_Ara.Name = "buttonBLISCH_Ara";
            this.buttonBLISCH_Ara.Size = new System.Drawing.Size(155, 23);
            this.buttonBLISCH_Ara.TabIndex = 29;
            this.buttonBLISCH_Ara.Text = "Search on BLISCH";
            this.buttonBLISCH_Ara.UseVisualStyleBackColor = true;
            this.buttonBLISCH_Ara.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonREISCH_Ara
            // 
            this.buttonREISCH_Ara.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.buttonREISCH_Ara.Location = new System.Drawing.Point(693, 91);
            this.buttonREISCH_Ara.Name = "buttonREISCH_Ara";
            this.buttonREISCH_Ara.Size = new System.Drawing.Size(155, 23);
            this.buttonREISCH_Ara.TabIndex = 30;
            this.buttonREISCH_Ara.Text = "Search on REISCH";
            this.buttonREISCH_Ara.UseVisualStyleBackColor = true;
            this.buttonREISCH_Ara.Click += new System.EventHandler(this.button6_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.Location = new System.Drawing.Point(0, 472);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(146, 32);
            this.label13.TabIndex = 34;
            this.label13.Text = "PERFORMANCE--->\r\n(Processing Time)";
            // 
            // labelPerfBLISCH
            // 
            this.labelPerfBLISCH.AutoSize = true;
            this.labelPerfBLISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPerfBLISCH.Location = new System.Drawing.Point(665, 472);
            this.labelPerfBLISCH.Name = "labelPerfBLISCH";
            this.labelPerfBLISCH.Size = new System.Drawing.Size(126, 13);
            this.labelPerfBLISCH.TabIndex = 39;
            this.labelPerfBLISCH.Text = "BLISCH Performance";
            // 
            // labelPerfLICH
            // 
            this.labelPerfLICH.AutoSize = true;
            this.labelPerfLICH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPerfLICH.Location = new System.Drawing.Point(218, 474);
            this.labelPerfLICH.Name = "labelPerfLICH";
            this.labelPerfLICH.Size = new System.Drawing.Size(110, 13);
            this.labelPerfLICH.TabIndex = 40;
            this.labelPerfLICH.Text = "LICH Performance";
            // 
            // labelPerfEISCH
            // 
            this.labelPerfEISCH.AutoSize = true;
            this.labelPerfEISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPerfEISCH.Location = new System.Drawing.Point(443, 474);
            this.labelPerfEISCH.Name = "labelPerfEISCH";
            this.labelPerfEISCH.Size = new System.Drawing.Size(119, 13);
            this.labelPerfEISCH.TabIndex = 41;
            this.labelPerfEISCH.Text = "EISCH Performance";
            // 
            // labelPerfREISCH
            // 
            this.labelPerfREISCH.AutoSize = true;
            this.labelPerfREISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPerfREISCH.Location = new System.Drawing.Point(879, 472);
            this.labelPerfREISCH.Name = "labelPerfREISCH";
            this.labelPerfREISCH.Size = new System.Drawing.Size(128, 13);
            this.labelPerfREISCH.TabIndex = 42;
            this.labelPerfREISCH.Text = "REISCH Performance";
            // 
            // textBoxRandomKeysDiziBoyutu
            // 
            this.textBoxRandomKeysDiziBoyutu.Location = new System.Drawing.Point(35, 37);
            this.textBoxRandomKeysDiziBoyutu.Name = "textBoxRandomKeysDiziBoyutu";
            this.textBoxRandomKeysDiziBoyutu.Size = new System.Drawing.Size(103, 20);
            this.textBoxRandomKeysDiziBoyutu.TabIndex = 43;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(23, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(133, 32);
            this.label3.TabIndex = 44;
            this.label3.Text = "Length of Random\r\n    Keys Array";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label8.Location = new System.Drawing.Point(188, 51);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(140, 16);
            this.label8.TabIndex = 45;
            this.label8.Text = "Primary Area Size :";
            // 
            // primaryAreaSize
            // 
            this.primaryAreaSize.AutoSize = true;
            this.primaryAreaSize.Location = new System.Drawing.Point(346, 54);
            this.primaryAreaSize.Name = "primaryAreaSize";
            this.primaryAreaSize.Size = new System.Drawing.Size(37, 13);
            this.primaryAreaSize.TabIndex = 46;
            this.primaryAreaSize.Text = "00000";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label12.Location = new System.Drawing.Point(3, 534);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(169, 16);
            this.label12.TabIndex = 47;
            this.label12.Text = "AVARAGE PROBES--->";
            // 
            // labelAvrLICH
            // 
            this.labelAvrLICH.AutoSize = true;
            this.labelAvrLICH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAvrLICH.Location = new System.Drawing.Point(218, 534);
            this.labelAvrLICH.Name = "labelAvrLICH";
            this.labelAvrLICH.Size = new System.Drawing.Size(103, 13);
            this.labelAvrLICH.TabIndex = 48;
            this.labelAvrLICH.Text = "AVRofProbsLICH";
            // 
            // labelAvrEISCH
            // 
            this.labelAvrEISCH.AutoSize = true;
            this.labelAvrEISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAvrEISCH.Location = new System.Drawing.Point(443, 534);
            this.labelAvrEISCH.Name = "labelAvrEISCH";
            this.labelAvrEISCH.Size = new System.Drawing.Size(112, 13);
            this.labelAvrEISCH.TabIndex = 49;
            this.labelAvrEISCH.Text = "AVRofProbsEISCH";
            // 
            // labelAvrBLISCH
            // 
            this.labelAvrBLISCH.AutoSize = true;
            this.labelAvrBLISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAvrBLISCH.Location = new System.Drawing.Point(667, 536);
            this.labelAvrBLISCH.Name = "labelAvrBLISCH";
            this.labelAvrBLISCH.Size = new System.Drawing.Size(119, 13);
            this.labelAvrBLISCH.TabIndex = 50;
            this.labelAvrBLISCH.Text = "AVRofProbsBLISCH";
            // 
            // labelAvrREISCH
            // 
            this.labelAvrREISCH.AutoSize = true;
            this.labelAvrREISCH.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelAvrREISCH.Location = new System.Drawing.Point(885, 534);
            this.labelAvrREISCH.Name = "labelAvrREISCH";
            this.labelAvrREISCH.Size = new System.Drawing.Size(121, 13);
            this.labelAvrREISCH.TabIndex = 51;
            this.labelAvrREISCH.Text = "AVRofProbsREISCH";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.Location = new System.Drawing.Point(185, 86);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(209, 13);
            this.label14.TabIndex = 52;
            this.label14.Text = "Table Size(Nearest Prime Number) :";
            // 
            // TotalAreaSize
            // 
            this.TotalAreaSize.AutoSize = true;
            this.TotalAreaSize.Location = new System.Drawing.Point(400, 86);
            this.TotalAreaSize.Name = "TotalAreaSize";
            this.TotalAreaSize.Size = new System.Drawing.Size(37, 13);
            this.TotalAreaSize.TabIndex = 53;
            this.TotalAreaSize.Text = "00000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label15.Location = new System.Drawing.Point(192, 25);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(136, 16);
            this.label15.TabIndex = 54;
            this.label15.Text = "Packing Factor     :";
            // 
            // PackingFactorSize
            // 
            this.PackingFactorSize.AutoSize = true;
            this.PackingFactorSize.Location = new System.Drawing.Point(346, 28);
            this.PackingFactorSize.Name = "PackingFactorSize";
            this.PackingFactorSize.Size = new System.Drawing.Size(37, 13);
            this.PackingFactorSize.TabIndex = 55;
            this.PackingFactorSize.Text = "00000";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label16.Location = new System.Drawing.Point(1046, 242);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(147, 40);
            this.label16.TabIndex = 56;
            this.label16.Text = "Ali Hadi Altungök\r\n181180760";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 560);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.PackingFactorSize);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.TotalAreaSize);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.labelAvrREISCH);
            this.Controls.Add(this.labelAvrBLISCH);
            this.Controls.Add(this.labelAvrEISCH);
            this.Controls.Add(this.labelAvrLICH);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.primaryAreaSize);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxRandomKeysDiziBoyutu);
            this.Controls.Add(this.labelPerfREISCH);
            this.Controls.Add(this.labelPerfEISCH);
            this.Controls.Add(this.labelPerfLICH);
            this.Controls.Add(this.labelPerfBLISCH);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.buttonREISCH_Ara);
            this.Controls.Add(this.buttonBLISCH_Ara);
            this.Controls.Add(this.buttonEISCH_Ara);
            this.Controls.Add(this.buttonLICH_Ara);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.dataGridViewRandomArrayKeys);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBoxSearch);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridViewBLISCH);
            this.Controls.Add(this.dataGridViewLICH);
            this.Controls.Add(this.dataGridViewEISCH);
            this.Controls.Add(this.dataGridViewREISCH);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewREISCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEISCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLICH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBLISCH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRandomArrayKeys)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridViewREISCH;
        private System.Windows.Forms.DataGridView dataGridViewEISCH;
        private System.Windows.Forms.DataGridView dataGridViewLICH;
        private System.Windows.Forms.DataGridView dataGridViewBLISCH;
       
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dataGridViewRandomArrayKeys;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button buttonLICH_Ara;
        private System.Windows.Forms.Button buttonEISCH_Ara;
        private System.Windows.Forms.Button buttonBLISCH_Ara;
        private System.Windows.Forms.Button buttonREISCH_Ara;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label labelPerfBLISCH;
        private System.Windows.Forms.Label labelPerfLICH;
        private System.Windows.Forms.Label labelPerfEISCH;
        private System.Windows.Forms.Label labelPerfREISCH;
        private System.Windows.Forms.TextBox textBoxRandomKeysDiziBoyutu;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column18;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label primaryAreaSize;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label labelAvrLICH;
        private System.Windows.Forms.Label labelAvrEISCH;
        private System.Windows.Forms.Label labelAvrBLISCH;
        private System.Windows.Forms.Label labelAvrREISCH;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label TotalAreaSize;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label PackingFactorSize;
        private System.Windows.Forms.Label label16;
    }
}

