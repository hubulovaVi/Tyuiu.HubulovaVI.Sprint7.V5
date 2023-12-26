
namespace Tyuiu.HubulovaVI.Sprint7
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.panelTitle_HVI = new System.Windows.Forms.Panel();
            this.buttonSaveFile_HVI = new System.Windows.Forms.Button();
            this.buttonOpenFile_HVI = new System.Windows.Forms.Button();
            this.labelTitle_HVI = new System.Windows.Forms.Label();
            this.buttonAdmin_HVI = new System.Windows.Forms.Button();
            this.panelMain_HVI = new System.Windows.Forms.Panel();
            this.tabControlMain_HVI = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridViewMatrix_HVI = new System.Windows.Forms.DataGridView();
            this.Articule_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.otdel_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountSklad_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountUpakovka_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CountUpakovok_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postavshik_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price_HVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.chart_HVI = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panelTable_HVI = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBoxFilter_HVI = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxPoiskName_HVI = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBoxNewItem_HVI = new System.Windows.Forms.GroupBox();
            this.buttonAddRow_HVI = new System.Windows.Forms.Button();
            this.textBoxPriceAdd_HVI = new System.Windows.Forms.TextBox();
            this.textBoxPostavshikAdd_HVI = new System.Windows.Forms.TextBox();
            this.textBoxCountUpakovokadd_HVI = new System.Windows.Forms.TextBox();
            this.textBoxCountUpaAdd_HVI = new System.Windows.Forms.TextBox();
            this.textBoxCountSkadAdd_HVI = new System.Windows.Forms.TextBox();
            this.textBoxNameAdd_HVI = new System.Windows.Forms.TextBox();
            this.textBoxOtdelAdd_HVI = new System.Windows.Forms.TextBox();
            this.textBoxArticuleAdd_HVI = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.openFileDialogButton_HVI = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialogMain_HVI = new System.Windows.Forms.SaveFileDialog();
            this.panelTitle_HVI.SuspendLayout();
            this.panelMain_HVI.SuspendLayout();
            this.tabControlMain_HVI.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_HVI)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart_HVI)).BeginInit();
            this.panelTable_HVI.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBoxNewItem_HVI.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelTitle_HVI
            // 
            this.panelTitle_HVI.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelTitle_HVI.Controls.Add(this.buttonSaveFile_HVI);
            this.panelTitle_HVI.Controls.Add(this.buttonOpenFile_HVI);
            this.panelTitle_HVI.Controls.Add(this.labelTitle_HVI);
            this.panelTitle_HVI.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitle_HVI.Location = new System.Drawing.Point(0, 0);
            this.panelTitle_HVI.Name = "panelTitle_HVI";
            this.panelTitle_HVI.Size = new System.Drawing.Size(1211, 62);
            this.panelTitle_HVI.TabIndex = 0;
            // 
            // buttonSaveFile_HVI
            // 
            this.buttonSaveFile_HVI.Location = new System.Drawing.Point(738, 12);
            this.buttonSaveFile_HVI.Name = "buttonSaveFile_HVI";
            this.buttonSaveFile_HVI.Size = new System.Drawing.Size(111, 38);
            this.buttonSaveFile_HVI.TabIndex = 2;
            this.buttonSaveFile_HVI.Text = "Сохранить файл";
            this.buttonSaveFile_HVI.UseVisualStyleBackColor = true;
            this.buttonSaveFile_HVI.Click += new System.EventHandler(this.buttonSaveFile_HVI_Click);
            // 
            // buttonOpenFile_HVI
            // 
            this.buttonOpenFile_HVI.Location = new System.Drawing.Point(619, 12);
            this.buttonOpenFile_HVI.Name = "buttonOpenFile_HVI";
            this.buttonOpenFile_HVI.Size = new System.Drawing.Size(111, 38);
            this.buttonOpenFile_HVI.TabIndex = 1;
            this.buttonOpenFile_HVI.Text = "Выбрать файл";
            this.buttonOpenFile_HVI.UseVisualStyleBackColor = true;
            this.buttonOpenFile_HVI.Click += new System.EventHandler(this.buttonOpenFile_HVI_Click);
            // 
            // labelTitle_HVI
            // 
            this.labelTitle_HVI.AutoSize = true;
            this.labelTitle_HVI.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTitle_HVI.Location = new System.Drawing.Point(12, 18);
            this.labelTitle_HVI.Name = "labelTitle_HVI";
            this.labelTitle_HVI.Size = new System.Drawing.Size(103, 25);
            this.labelTitle_HVI.TabIndex = 0;
            this.labelTitle_HVI.Text = "ГЛАВНАЯ";
            // 
            // buttonAdmin_HVI
            // 
            this.buttonAdmin_HVI.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonAdmin_HVI.BackgroundImage")));
            this.buttonAdmin_HVI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonAdmin_HVI.Location = new System.Drawing.Point(165, 466);
            this.buttonAdmin_HVI.Name = "buttonAdmin_HVI";
            this.buttonAdmin_HVI.Size = new System.Drawing.Size(54, 50);
            this.buttonAdmin_HVI.TabIndex = 2;
            this.buttonAdmin_HVI.UseVisualStyleBackColor = true;
            this.buttonAdmin_HVI.Click += new System.EventHandler(this.buttonAdmin_HVI_Click);
            // 
            // panelMain_HVI
            // 
            this.panelMain_HVI.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.panelMain_HVI.Controls.Add(this.tabControlMain_HVI);
            this.panelMain_HVI.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMain_HVI.Location = new System.Drawing.Point(0, 62);
            this.panelMain_HVI.Name = "panelMain_HVI";
            this.panelMain_HVI.Size = new System.Drawing.Size(979, 528);
            this.panelMain_HVI.TabIndex = 1;
            // 
            // tabControlMain_HVI
            // 
            this.tabControlMain_HVI.Controls.Add(this.tabPage1);
            this.tabControlMain_HVI.Controls.Add(this.tabPage2);
            this.tabControlMain_HVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain_HVI.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain_HVI.Name = "tabControlMain_HVI";
            this.tabControlMain_HVI.SelectedIndex = 0;
            this.tabControlMain_HVI.Size = new System.Drawing.Size(979, 528);
            this.tabControlMain_HVI.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dataGridViewMatrix_HVI);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(971, 502);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "База";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridViewMatrix_HVI
            // 
            this.dataGridViewMatrix_HVI.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewMatrix_HVI.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Articule_HVI,
            this.otdel_HVI,
            this.name_HVI,
            this.CountSklad_HVI,
            this.CountUpakovka_HVI,
            this.CountUpakovok_HVI,
            this.postavshik_HVI,
            this.price_HVI});
            this.dataGridViewMatrix_HVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewMatrix_HVI.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewMatrix_HVI.Name = "dataGridViewMatrix_HVI";
            this.dataGridViewMatrix_HVI.RowHeadersVisible = false;
            this.dataGridViewMatrix_HVI.Size = new System.Drawing.Size(965, 496);
            this.dataGridViewMatrix_HVI.TabIndex = 0;
            // 
            // Articule_HVI
            // 
            this.Articule_HVI.HeaderText = "Артикул";
            this.Articule_HVI.Name = "Articule_HVI";
            // 
            // otdel_HVI
            // 
            this.otdel_HVI.HeaderText = "Отдел";
            this.otdel_HVI.Name = "otdel_HVI";
            // 
            // name_HVI
            // 
            this.name_HVI.HeaderText = "Наименование товара";
            this.name_HVI.Name = "name_HVI";
            // 
            // CountSklad_HVI
            // 
            this.CountSklad_HVI.HeaderText = "Кол-во на складе";
            this.CountSklad_HVI.Name = "CountSklad_HVI";
            // 
            // CountUpakovka_HVI
            // 
            this.CountUpakovka_HVI.HeaderText = "Кол-во в упаковке";
            this.CountUpakovka_HVI.Name = "CountUpakovka_HVI";
            // 
            // CountUpakovok_HVI
            // 
            this.CountUpakovok_HVI.HeaderText = "Кол-во упаковок";
            this.CountUpakovok_HVI.Name = "CountUpakovok_HVI";
            // 
            // postavshik_HVI
            // 
            this.postavshik_HVI.HeaderText = "Поставщик";
            this.postavshik_HVI.Name = "postavshik_HVI";
            // 
            // price_HVI
            // 
            this.price_HVI.HeaderText = "Цена";
            this.price_HVI.Name = "price_HVI";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.chart_HVI);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(971, 502);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "График";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(562, 386);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 77);
            this.button3.TabIndex = 1;
            this.button3.Text = "Показать график";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // chart_HVI
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_HVI.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_HVI.Legends.Add(legend1);
            this.chart_HVI.Location = new System.Drawing.Point(34, 27);
            this.chart_HVI.Name = "chart_HVI";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_HVI.Series.Add(series1);
            this.chart_HVI.Size = new System.Drawing.Size(440, 449);
            this.chart_HVI.TabIndex = 0;
            this.chart_HVI.Text = "chart_HVI";
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(979, 62);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 528);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // panelTable_HVI
            // 
            this.panelTable_HVI.Controls.Add(this.buttonAdmin_HVI);
            this.panelTable_HVI.Controls.Add(this.groupBox2);
            this.panelTable_HVI.Controls.Add(this.groupBox1);
            this.panelTable_HVI.Controls.Add(this.groupBoxNewItem_HVI);
            this.panelTable_HVI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelTable_HVI.Location = new System.Drawing.Point(982, 62);
            this.panelTable_HVI.Name = "panelTable_HVI";
            this.panelTable_HVI.Size = new System.Drawing.Size(229, 528);
            this.panelTable_HVI.TabIndex = 3;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBoxFilter_HVI);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(7, 363);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(212, 88);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Сортировка";
            // 
            // comboBoxFilter_HVI
            // 
            this.comboBoxFilter_HVI.FormattingEnabled = true;
            this.comboBoxFilter_HVI.Items.AddRange(new object[] {
            "Молоко",
            "Бакалея",
            "Мясная гастрономия"});
            this.comboBoxFilter_HVI.Location = new System.Drawing.Point(12, 40);
            this.comboBoxFilter_HVI.Name = "comboBoxFilter_HVI";
            this.comboBoxFilter_HVI.Size = new System.Drawing.Size(121, 21);
            this.comboBoxFilter_HVI.TabIndex = 1;
            this.comboBoxFilter_HVI.SelectedIndexChanged += new System.EventHandler(this.comboBoxFilter_HVI_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 20);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "По отделу:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxPoiskName_HVI);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(7, 281);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(212, 76);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поиск";
            // 
            // textBoxPoiskName_HVI
            // 
            this.textBoxPoiskName_HVI.Location = new System.Drawing.Point(6, 42);
            this.textBoxPoiskName_HVI.Name = "textBoxPoiskName_HVI";
            this.textBoxPoiskName_HVI.Size = new System.Drawing.Size(138, 20);
            this.textBoxPoiskName_HVI.TabIndex = 1;
            this.textBoxPoiskName_HVI.TextChanged += new System.EventHandler(this.textBoxPoiskName_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(141, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "По наименованию товара:";
            // 
            // groupBoxNewItem_HVI
            // 
            this.groupBoxNewItem_HVI.Controls.Add(this.buttonAddRow_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxPriceAdd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxPostavshikAdd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxCountUpakovokadd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxCountUpaAdd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxCountSkadAdd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxNameAdd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxOtdelAdd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.textBoxArticuleAdd_HVI);
            this.groupBoxNewItem_HVI.Controls.Add(this.label8);
            this.groupBoxNewItem_HVI.Controls.Add(this.label7);
            this.groupBoxNewItem_HVI.Controls.Add(this.label6);
            this.groupBoxNewItem_HVI.Controls.Add(this.label5);
            this.groupBoxNewItem_HVI.Controls.Add(this.label4);
            this.groupBoxNewItem_HVI.Controls.Add(this.label3);
            this.groupBoxNewItem_HVI.Controls.Add(this.label2);
            this.groupBoxNewItem_HVI.Controls.Add(this.label1);
            this.groupBoxNewItem_HVI.Location = new System.Drawing.Point(7, 7);
            this.groupBoxNewItem_HVI.Name = "groupBoxNewItem_HVI";
            this.groupBoxNewItem_HVI.Size = new System.Drawing.Size(212, 268);
            this.groupBoxNewItem_HVI.TabIndex = 0;
            this.groupBoxNewItem_HVI.TabStop = false;
            this.groupBoxNewItem_HVI.Text = "Добавление товара";
            // 
            // buttonAddRow_HVI
            // 
            this.buttonAddRow_HVI.Location = new System.Drawing.Point(63, 234);
            this.buttonAddRow_HVI.Name = "buttonAddRow_HVI";
            this.buttonAddRow_HVI.Size = new System.Drawing.Size(96, 28);
            this.buttonAddRow_HVI.TabIndex = 16;
            this.buttonAddRow_HVI.Text = "Добавить";
            this.buttonAddRow_HVI.UseVisualStyleBackColor = true;
            this.buttonAddRow_HVI.Click += new System.EventHandler(this.buttonAddRow_HVI_Click);
            // 
            // textBoxPriceAdd_HVI
            // 
            this.textBoxPriceAdd_HVI.Location = new System.Drawing.Point(106, 202);
            this.textBoxPriceAdd_HVI.Name = "textBoxPriceAdd_HVI";
            this.textBoxPriceAdd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxPriceAdd_HVI.TabIndex = 15;
            // 
            // textBoxPostavshikAdd_HVI
            // 
            this.textBoxPostavshikAdd_HVI.Location = new System.Drawing.Point(106, 176);
            this.textBoxPostavshikAdd_HVI.Name = "textBoxPostavshikAdd_HVI";
            this.textBoxPostavshikAdd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxPostavshikAdd_HVI.TabIndex = 14;
            // 
            // textBoxCountUpakovokadd_HVI
            // 
            this.textBoxCountUpakovokadd_HVI.Location = new System.Drawing.Point(106, 151);
            this.textBoxCountUpakovokadd_HVI.Name = "textBoxCountUpakovokadd_HVI";
            this.textBoxCountUpakovokadd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountUpakovokadd_HVI.TabIndex = 13;
            // 
            // textBoxCountUpaAdd_HVI
            // 
            this.textBoxCountUpaAdd_HVI.Location = new System.Drawing.Point(106, 125);
            this.textBoxCountUpaAdd_HVI.Name = "textBoxCountUpaAdd_HVI";
            this.textBoxCountUpaAdd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountUpaAdd_HVI.TabIndex = 12;
            // 
            // textBoxCountSkadAdd_HVI
            // 
            this.textBoxCountSkadAdd_HVI.Location = new System.Drawing.Point(106, 97);
            this.textBoxCountSkadAdd_HVI.Name = "textBoxCountSkadAdd_HVI";
            this.textBoxCountSkadAdd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxCountSkadAdd_HVI.TabIndex = 11;
            // 
            // textBoxNameAdd_HVI
            // 
            this.textBoxNameAdd_HVI.Location = new System.Drawing.Point(106, 71);
            this.textBoxNameAdd_HVI.Name = "textBoxNameAdd_HVI";
            this.textBoxNameAdd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxNameAdd_HVI.TabIndex = 10;
            // 
            // textBoxOtdelAdd_HVI
            // 
            this.textBoxOtdelAdd_HVI.Location = new System.Drawing.Point(106, 45);
            this.textBoxOtdelAdd_HVI.Name = "textBoxOtdelAdd_HVI";
            this.textBoxOtdelAdd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxOtdelAdd_HVI.TabIndex = 9;
            // 
            // textBoxArticuleAdd_HVI
            // 
            this.textBoxArticuleAdd_HVI.Location = new System.Drawing.Point(106, 20);
            this.textBoxArticuleAdd_HVI.Name = "textBoxArticuleAdd_HVI";
            this.textBoxArticuleAdd_HVI.Size = new System.Drawing.Size(100, 20);
            this.textBoxArticuleAdd_HVI.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 200);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(33, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Цена";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 175);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(65, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Поставщик";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Кол-во упаковок";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Кол-во в упаковке";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Кол-во на складе";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "Наименование\r\nтовара\r\n";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Отдел";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Артикул";
            // 
            // openFileDialogButton_HVI
            // 
            this.openFileDialogButton_HVI.FileName = "openFileDialogButton_HVI";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 590);
            this.Controls.Add(this.panelTable_HVI);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelMain_HVI);
            this.Controls.Add(this.panelTitle_HVI);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Оптовая база";
            this.panelTitle_HVI.ResumeLayout(false);
            this.panelTitle_HVI.PerformLayout();
            this.panelMain_HVI.ResumeLayout(false);
            this.tabControlMain_HVI.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewMatrix_HVI)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart_HVI)).EndInit();
            this.panelTable_HVI.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBoxNewItem_HVI.ResumeLayout(false);
            this.groupBoxNewItem_HVI.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelTitle_HVI;
        private System.Windows.Forms.Label labelTitle_HVI;
        private System.Windows.Forms.Button buttonAdmin_HVI;
        private System.Windows.Forms.Panel panelMain_HVI;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panelTable_HVI;
        private System.Windows.Forms.Button buttonSaveFile_HVI;
        private System.Windows.Forms.Button buttonOpenFile_HVI;
        private System.Windows.Forms.TabControl tabControlMain_HVI;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewMatrix_HVI;
        private System.Windows.Forms.GroupBox groupBoxNewItem_HVI;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxOtdelAdd_HVI;
        private System.Windows.Forms.TextBox textBoxArticuleAdd_HVI;
        private System.Windows.Forms.TextBox textBoxPriceAdd_HVI;
        private System.Windows.Forms.TextBox textBoxPostavshikAdd_HVI;
        private System.Windows.Forms.TextBox textBoxCountUpakovokadd_HVI;
        private System.Windows.Forms.TextBox textBoxCountUpaAdd_HVI;
        private System.Windows.Forms.TextBox textBoxCountSkadAdd_HVI;
        private System.Windows.Forms.TextBox textBoxNameAdd_HVI;
        private System.Windows.Forms.Button buttonAddRow_HVI;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxPoiskName_HVI;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBoxFilter_HVI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_HVI;
        private System.Windows.Forms.OpenFileDialog openFileDialogButton_HVI;
        private System.Windows.Forms.SaveFileDialog saveFileDialogMain_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Articule_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn otdel_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountSklad_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountUpakovka_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn CountUpakovok_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn postavshik_HVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn price_HVI;
    }
}

