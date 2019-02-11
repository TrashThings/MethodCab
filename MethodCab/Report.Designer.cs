namespace MethodCab
{
    partial class FReport
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ExcelExport1Btn = new System.Windows.Forms.Button();
            this.pk_prepodCombo = new System.Windows.Forms.ComboBox();
            this.prepodBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.methodCabDataSet = new MethodCab.MethodCabDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.ExcelExport2Btn = new System.Windows.Forms.Button();
            this.pk_prepod_pckBtn = new System.Windows.Forms.Button();
            this.pk_prepod_pckEndDTP = new System.Windows.Forms.DateTimePicker();
            this.pk_prepod_pckStartDTP = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pk_prepod_pckCombo = new System.Windows.Forms.ComboBox();
            this.pckBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dataGridView5 = new System.Windows.Forms.DataGridView();
            this.panel5 = new System.Windows.Forms.Panel();
            this.ExcelExport3Btn = new System.Windows.Forms.Button();
            this.pk_pckBtn = new System.Windows.Forms.Button();
            this.pk_pckEndDTP = new System.Windows.Forms.DateTimePicker();
            this.pk_pckStartDTP = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.ExcelExport4Btn = new System.Windows.Forms.Button();
            this.plan_pkBtn = new System.Windows.Forms.Button();
            this.pk_yearText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ExcelExport5Btn = new System.Windows.Forms.Button();
            this.plan_internBtn = new System.Windows.Forms.Button();
            this.intern_yearText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.qualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qualificationTableAdapter = new MethodCab.MethodCabDataSetTableAdapters.qualificationTableAdapter();
            this.selectqualificationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.select_qualificationTableAdapter = new MethodCab.MethodCabDataSetTableAdapters.select_qualificationTableAdapter();
            this.prepodTableAdapter = new MethodCab.MethodCabDataSetTableAdapters.prepodTableAdapter();
            this.methodCabDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pckTableAdapter = new MethodCab.MethodCabDataSetTableAdapters.pckTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepodBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodCabDataSet)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckBindingSource)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).BeginInit();
            this.panel5.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.panel3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectqualificationBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodCabDataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(968, 536);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pk_yearText_KeyPress);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(960, 510);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Повышение квалификации преподавателя";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 51);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(954, 456);
            this.dataGridView1.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ExcelExport1Btn);
            this.panel1.Controls.Add(this.pk_prepodCombo);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 48);
            this.panel1.TabIndex = 0;
            // 
            // ExcelExport1Btn
            // 
            this.ExcelExport1Btn.Location = new System.Drawing.Point(440, 13);
            this.ExcelExport1Btn.Name = "ExcelExport1Btn";
            this.ExcelExport1Btn.Size = new System.Drawing.Size(103, 23);
            this.ExcelExport1Btn.TabIndex = 7;
            this.ExcelExport1Btn.Text = "Экспорт в Excel";
            this.ExcelExport1Btn.UseVisualStyleBackColor = true;
            this.ExcelExport1Btn.Click += new System.EventHandler(this.ExcelExport1Btn_Click);
            // 
            // pk_prepodCombo
            // 
            this.pk_prepodCombo.DataSource = this.prepodBindingSource;
            this.pk_prepodCombo.DisplayMember = "name_prepod";
            this.pk_prepodCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pk_prepodCombo.FormattingEnabled = true;
            this.pk_prepodCombo.Location = new System.Drawing.Point(172, 16);
            this.pk_prepodCombo.Name = "pk_prepodCombo";
            this.pk_prepodCombo.Size = new System.Drawing.Size(189, 21);
            this.pk_prepodCombo.TabIndex = 1;
            this.pk_prepodCombo.ValueMember = "id_prepod";
            this.pk_prepodCombo.SelectedIndexChanged += new System.EventHandler(this.pk_prepodCombo_SelectedIndexChanged);
            // 
            // prepodBindingSource
            // 
            this.prepodBindingSource.DataMember = "prepod";
            this.prepodBindingSource.DataSource = this.methodCabDataSet;
            // 
            // methodCabDataSet
            // 
            this.methodCabDataSet.DataSetName = "MethodCabDataSet";
            this.methodCabDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Преподаватель:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Controls.Add(this.panel2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(960, 510);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Повышение квалификации преподавателей ПЦК";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(3, 51);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(954, 456);
            this.dataGridView2.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ExcelExport2Btn);
            this.panel2.Controls.Add(this.pk_prepod_pckBtn);
            this.panel2.Controls.Add(this.pk_prepod_pckEndDTP);
            this.panel2.Controls.Add(this.pk_prepod_pckStartDTP);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.pk_prepod_pckCombo);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(954, 48);
            this.panel2.TabIndex = 1;
            // 
            // ExcelExport2Btn
            // 
            this.ExcelExport2Btn.Location = new System.Drawing.Point(788, 12);
            this.ExcelExport2Btn.Name = "ExcelExport2Btn";
            this.ExcelExport2Btn.Size = new System.Drawing.Size(103, 23);
            this.ExcelExport2Btn.TabIndex = 8;
            this.ExcelExport2Btn.Text = "Экспорт в Excel";
            this.ExcelExport2Btn.UseVisualStyleBackColor = true;
            this.ExcelExport2Btn.Click += new System.EventHandler(this.ExcelExport2Btn_Click);
            // 
            // pk_prepod_pckBtn
            // 
            this.pk_prepod_pckBtn.Location = new System.Drawing.Point(696, 12);
            this.pk_prepod_pckBtn.Name = "pk_prepod_pckBtn";
            this.pk_prepod_pckBtn.Size = new System.Drawing.Size(75, 23);
            this.pk_prepod_pckBtn.TabIndex = 6;
            this.pk_prepod_pckBtn.Text = "Показать";
            this.pk_prepod_pckBtn.UseVisualStyleBackColor = true;
            this.pk_prepod_pckBtn.Click += new System.EventHandler(this.pk_prepod_pckBtn_Click);
            // 
            // pk_prepod_pckEndDTP
            // 
            this.pk_prepod_pckEndDTP.Location = new System.Drawing.Point(525, 15);
            this.pk_prepod_pckEndDTP.Name = "pk_prepod_pckEndDTP";
            this.pk_prepod_pckEndDTP.Size = new System.Drawing.Size(139, 20);
            this.pk_prepod_pckEndDTP.TabIndex = 5;
            // 
            // pk_prepod_pckStartDTP
            // 
            this.pk_prepod_pckStartDTP.Location = new System.Drawing.Point(321, 15);
            this.pk_prepod_pckStartDTP.Name = "pk_prepod_pckStartDTP";
            this.pk_prepod_pckStartDTP.Size = new System.Drawing.Size(139, 20);
            this.pk_prepod_pckStartDTP.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(495, 17);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "По:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "С:";
            // 
            // pk_prepod_pckCombo
            // 
            this.pk_prepod_pckCombo.DataSource = this.pckBindingSource;
            this.pk_prepod_pckCombo.DisplayMember = "name_spec";
            this.pk_prepod_pckCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.pk_prepod_pckCombo.FormattingEnabled = true;
            this.pk_prepod_pckCombo.Location = new System.Drawing.Point(85, 14);
            this.pk_prepod_pckCombo.Name = "pk_prepod_pckCombo";
            this.pk_prepod_pckCombo.Size = new System.Drawing.Size(189, 21);
            this.pk_prepod_pckCombo.TabIndex = 1;
            this.pk_prepod_pckCombo.ValueMember = "id_pck";
            // 
            // pckBindingSource
            // 
            this.pckBindingSource.DataMember = "pck";
            this.pckBindingSource.DataSource = this.methodCabDataSet;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "ПЦК:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dataGridView5);
            this.tabPage3.Controls.Add(this.panel5);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(960, 510);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Повышение квалификации по ПЦК";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dataGridView5
            // 
            this.dataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView5.Location = new System.Drawing.Point(3, 51);
            this.dataGridView5.Name = "dataGridView5";
            this.dataGridView5.Size = new System.Drawing.Size(954, 456);
            this.dataGridView5.TabIndex = 4;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.ExcelExport3Btn);
            this.panel5.Controls.Add(this.pk_pckBtn);
            this.panel5.Controls.Add(this.pk_pckEndDTP);
            this.panel5.Controls.Add(this.pk_pckStartDTP);
            this.panel5.Controls.Add(this.label9);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(954, 48);
            this.panel5.TabIndex = 3;
            // 
            // ExcelExport3Btn
            // 
            this.ExcelExport3Btn.Location = new System.Drawing.Point(699, 12);
            this.ExcelExport3Btn.Name = "ExcelExport3Btn";
            this.ExcelExport3Btn.Size = new System.Drawing.Size(103, 23);
            this.ExcelExport3Btn.TabIndex = 8;
            this.ExcelExport3Btn.Text = "Экспорт в Excel";
            this.ExcelExport3Btn.UseVisualStyleBackColor = true;
            this.ExcelExport3Btn.Click += new System.EventHandler(this.ExcelExport3Btn_Click);
            // 
            // pk_pckBtn
            // 
            this.pk_pckBtn.Location = new System.Drawing.Point(608, 12);
            this.pk_pckBtn.Name = "pk_pckBtn";
            this.pk_pckBtn.Size = new System.Drawing.Size(75, 23);
            this.pk_pckBtn.TabIndex = 6;
            this.pk_pckBtn.Text = "Показать";
            this.pk_pckBtn.UseVisualStyleBackColor = true;
            this.pk_pckBtn.Click += new System.EventHandler(this.pk_pckBtn_Click);
            // 
            // pk_pckEndDTP
            // 
            this.pk_pckEndDTP.Location = new System.Drawing.Point(437, 15);
            this.pk_pckEndDTP.Name = "pk_pckEndDTP";
            this.pk_pckEndDTP.Size = new System.Drawing.Size(139, 20);
            this.pk_pckEndDTP.TabIndex = 5;
            // 
            // pk_pckStartDTP
            // 
            this.pk_pckStartDTP.Location = new System.Drawing.Point(233, 15);
            this.pk_pckStartDTP.Name = "pk_pckStartDTP";
            this.pk_pckStartDTP.Size = new System.Drawing.Size(139, 20);
            this.pk_pckStartDTP.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(407, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(24, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "По:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(210, 17);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(17, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "С:";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridView3);
            this.tabPage4.Controls.Add(this.panel3);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(960, 510);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "План повышения квалификации";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 51);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(954, 456);
            this.dataGridView3.TabIndex = 2;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.ExcelExport4Btn);
            this.panel3.Controls.Add(this.plan_pkBtn);
            this.panel3.Controls.Add(this.pk_yearText);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(3, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(954, 48);
            this.panel3.TabIndex = 1;
            // 
            // ExcelExport4Btn
            // 
            this.ExcelExport4Btn.Location = new System.Drawing.Point(661, 14);
            this.ExcelExport4Btn.Name = "ExcelExport4Btn";
            this.ExcelExport4Btn.Size = new System.Drawing.Size(103, 23);
            this.ExcelExport4Btn.TabIndex = 8;
            this.ExcelExport4Btn.Text = "Экспорт в Excel";
            this.ExcelExport4Btn.UseVisualStyleBackColor = true;
            this.ExcelExport4Btn.Click += new System.EventHandler(this.ExcelExport4Btn_Click);
            // 
            // plan_pkBtn
            // 
            this.plan_pkBtn.Location = new System.Drawing.Point(570, 14);
            this.plan_pkBtn.Name = "plan_pkBtn";
            this.plan_pkBtn.Size = new System.Drawing.Size(75, 23);
            this.plan_pkBtn.TabIndex = 4;
            this.plan_pkBtn.Text = "Показать";
            this.plan_pkBtn.UseVisualStyleBackColor = true;
            this.plan_pkBtn.Click += new System.EventHandler(this.plan_pkBtn_Click);
            // 
            // pk_yearText
            // 
            this.pk_yearText.Location = new System.Drawing.Point(422, 16);
            this.pk_yearText.MaxLength = 4;
            this.pk_yearText.Name = "pk_yearText";
            this.pk_yearText.Size = new System.Drawing.Size(83, 20);
            this.pk_yearText.TabIndex = 3;
            this.pk_yearText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pk_yearText_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(511, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "План повышения квалификации на";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.dataGridView4);
            this.tabPage5.Controls.Add(this.panel4);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(960, 510);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "План стажировок";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView4.Location = new System.Drawing.Point(3, 51);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.Size = new System.Drawing.Size(954, 456);
            this.dataGridView4.TabIndex = 4;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ExcelExport5Btn);
            this.panel4.Controls.Add(this.plan_internBtn);
            this.panel4.Controls.Add(this.intern_yearText);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(954, 48);
            this.panel4.TabIndex = 3;
            // 
            // ExcelExport5Btn
            // 
            this.ExcelExport5Btn.Location = new System.Drawing.Point(662, 14);
            this.ExcelExport5Btn.Name = "ExcelExport5Btn";
            this.ExcelExport5Btn.Size = new System.Drawing.Size(103, 23);
            this.ExcelExport5Btn.TabIndex = 8;
            this.ExcelExport5Btn.Text = "Экспорт в Excel";
            this.ExcelExport5Btn.UseVisualStyleBackColor = true;
            this.ExcelExport5Btn.Click += new System.EventHandler(this.ExcelExport5Btn_Click);
            // 
            // plan_internBtn
            // 
            this.plan_internBtn.Location = new System.Drawing.Point(570, 14);
            this.plan_internBtn.Name = "plan_internBtn";
            this.plan_internBtn.Size = new System.Drawing.Size(75, 23);
            this.plan_internBtn.TabIndex = 4;
            this.plan_internBtn.Text = "Показать";
            this.plan_internBtn.UseVisualStyleBackColor = true;
            this.plan_internBtn.Click += new System.EventHandler(this.plan_internBtn_Click);
            // 
            // intern_yearText
            // 
            this.intern_yearText.Location = new System.Drawing.Point(422, 16);
            this.intern_yearText.MaxLength = 4;
            this.intern_yearText.Name = "intern_yearText";
            this.intern_yearText.Size = new System.Drawing.Size(83, 20);
            this.intern_yearText.TabIndex = 3;
            this.intern_yearText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.pk_yearText_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(511, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "год";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(304, 19);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "План стажировок на";
            // 
            // qualificationBindingSource
            // 
            this.qualificationBindingSource.DataMember = "qualification";
            this.qualificationBindingSource.DataSource = this.methodCabDataSet;
            // 
            // qualificationTableAdapter
            // 
            this.qualificationTableAdapter.ClearBeforeFill = true;
            // 
            // selectqualificationBindingSource
            // 
            this.selectqualificationBindingSource.DataMember = "select_qualification";
            this.selectqualificationBindingSource.DataSource = this.methodCabDataSet;
            // 
            // select_qualificationTableAdapter
            // 
            this.select_qualificationTableAdapter.ClearBeforeFill = true;
            // 
            // prepodTableAdapter
            // 
            this.prepodTableAdapter.ClearBeforeFill = true;
            // 
            // methodCabDataSetBindingSource
            // 
            this.methodCabDataSetBindingSource.DataSource = this.methodCabDataSet;
            this.methodCabDataSetBindingSource.Position = 0;
            // 
            // pckTableAdapter
            // 
            this.pckTableAdapter.ClearBeforeFill = true;
            // 
            // FReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 536);
            this.Controls.Add(this.tabControl1);
            this.Name = "FReport";
            this.Text = "Методический кабинет: Повышение квалификации и стажировки (отчёты)";
            this.Load += new System.EventHandler(this.FReport_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.prepodBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodCabDataSet)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pckBindingSource)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView5)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectqualificationBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.methodCabDataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox pk_prepodCombo;
        private System.Windows.Forms.Label label1;
        private MethodCabDataSet methodCabDataSet;
        private System.Windows.Forms.BindingSource qualificationBindingSource;
        private MethodCabDataSetTableAdapters.qualificationTableAdapter qualificationTableAdapter;
        private System.Windows.Forms.BindingSource selectqualificationBindingSource;
        private MethodCabDataSetTableAdapters.select_qualificationTableAdapter select_qualificationTableAdapter;
        private System.Windows.Forms.BindingSource prepodBindingSource;
        private MethodCabDataSetTableAdapters.prepodTableAdapter prepodTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ComboBox pk_prepod_pckCombo;
        private System.Windows.Forms.BindingSource methodCabDataSetBindingSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource pckBindingSource;
        private MethodCabDataSetTableAdapters.pckTableAdapter pckTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button pk_prepod_pckBtn;
        private System.Windows.Forms.DateTimePicker pk_prepod_pckEndDTP;
        private System.Windows.Forms.DateTimePicker pk_prepod_pckStartDTP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox pk_yearText;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.Button plan_pkBtn;
        private System.Windows.Forms.DataGridView dataGridView4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button plan_internBtn;
        private System.Windows.Forms.TextBox intern_yearText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView5;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button pk_pckBtn;
        private System.Windows.Forms.DateTimePicker pk_pckEndDTP;
        private System.Windows.Forms.DateTimePicker pk_pckStartDTP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button ExcelExport1Btn;
        private System.Windows.Forms.Button ExcelExport2Btn;
        private System.Windows.Forms.Button ExcelExport3Btn;
        private System.Windows.Forms.Button ExcelExport4Btn;
        private System.Windows.Forms.Button ExcelExport5Btn;
    }
}