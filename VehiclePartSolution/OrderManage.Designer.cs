namespace VehiclePartSolution
{
    partial class OrderManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.numOrderStockInCar = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClearInCar = new System.Windows.Forms.Button();
            this.btnAddtoCartInCar = new System.Windows.Forms.Button();
            this.comboBoxCarInCar = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYearInCar = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.numAvailableStockInCar = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.numPriceInCar = new System.Windows.Forms.NumericUpDown();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModelInCar = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.numOrderStockInParts = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxParts = new System.Windows.Forms.ComboBox();
            this.btnClearInParts = new System.Windows.Forms.Button();
            this.btnAddtoCartInParts = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtRemarkInParts = new System.Windows.Forms.TextBox();
            this.numPriceInParts = new System.Windows.Forms.NumericUpDown();
            this.numAvailableStockInParts = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCarInParts = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridViewCarParts = new System.Windows.Forms.DataGridView();
            this.btnTableClear = new System.Windows.Forms.Button();
            this.btnPlaceOrder = new System.Windows.Forms.Button();
            this.txtNetTotal = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.tabView.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderStockInCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableStockInCar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceInCar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderStockInParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceInParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableStockInParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 31);
            this.label1.TabIndex = 57;
            this.label1.Text = "Order Management";
            // 
            // tabView
            // 
            this.tabView.Controls.Add(this.tabPage1);
            this.tabView.Controls.Add(this.tabPage2);
            this.tabView.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabView.Location = new System.Drawing.Point(12, 43);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(386, 437);
            this.tabView.TabIndex = 58;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.numOrderStockInCar);
            this.tabPage1.Controls.Add(this.label13);
            this.tabPage1.Controls.Add(this.btnClearInCar);
            this.tabPage1.Controls.Add(this.btnAddtoCartInCar);
            this.tabPage1.Controls.Add(this.comboBoxCarInCar);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtYearInCar);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.numAvailableStockInCar);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.numPriceInCar);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtModelInCar);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(378, 404);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Car Order";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // numOrderStockInCar
            // 
            this.numOrderStockInCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOrderStockInCar.Location = new System.Drawing.Point(93, 263);
            this.numOrderStockInCar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOrderStockInCar.Name = "numOrderStockInCar";
            this.numOrderStockInCar.Size = new System.Drawing.Size(239, 26);
            this.numOrderStockInCar.TabIndex = 68;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(32, 265);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(52, 19);
            this.label13.TabIndex = 67;
            this.label13.Text = "Stock :";
            // 
            // btnClearInCar
            // 
            this.btnClearInCar.BackColor = System.Drawing.Color.White;
            this.btnClearInCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInCar.Location = new System.Drawing.Point(112, 325);
            this.btnClearInCar.Name = "btnClearInCar";
            this.btnClearInCar.Size = new System.Drawing.Size(97, 30);
            this.btnClearInCar.TabIndex = 66;
            this.btnClearInCar.Text = "Clear";
            this.btnClearInCar.UseVisualStyleBackColor = false;
            // 
            // btnAddtoCartInCar
            // 
            this.btnAddtoCartInCar.BackColor = System.Drawing.Color.White;
            this.btnAddtoCartInCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCartInCar.Location = new System.Drawing.Point(215, 325);
            this.btnAddtoCartInCar.Name = "btnAddtoCartInCar";
            this.btnAddtoCartInCar.Size = new System.Drawing.Size(117, 30);
            this.btnAddtoCartInCar.TabIndex = 65;
            this.btnAddtoCartInCar.Text = "Add To Cart";
            this.btnAddtoCartInCar.UseVisualStyleBackColor = false;
            this.btnAddtoCartInCar.Click += new System.EventHandler(this.btnAddtoCartInCar_Click);
            // 
            // comboBoxCarInCar
            // 
            this.comboBoxCarInCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCarInCar.FormattingEnabled = true;
            this.comboBoxCarInCar.Location = new System.Drawing.Point(93, 34);
            this.comboBoxCarInCar.Name = "comboBoxCarInCar";
            this.comboBoxCarInCar.Size = new System.Drawing.Size(239, 27);
            this.comboBoxCarInCar.TabIndex = 56;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(47, 37);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 19);
            this.label4.TabIndex = 55;
            this.label4.Text = "Car :";
            // 
            // txtYearInCar
            // 
            this.txtYearInCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearInCar.Location = new System.Drawing.Point(93, 169);
            this.txtYearInCar.Name = "txtYearInCar";
            this.txtYearInCar.ReadOnly = true;
            this.txtYearInCar.Size = new System.Drawing.Size(239, 26);
            this.txtYearInCar.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(40, 169);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 19);
            this.label11.TabIndex = 34;
            this.label11.Text = "Year :";
            // 
            // numAvailableStockInCar
            // 
            this.numAvailableStockInCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAvailableStockInCar.Location = new System.Drawing.Point(93, 215);
            this.numAvailableStockInCar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAvailableStockInCar.Name = "numAvailableStockInCar";
            this.numAvailableStockInCar.ReadOnly = true;
            this.numAvailableStockInCar.Size = new System.Drawing.Size(239, 26);
            this.numAvailableStockInCar.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(11, 217);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(74, 19);
            this.label10.TabIndex = 32;
            this.label10.Text = "A / Stock :";
            // 
            // numPriceInCar
            // 
            this.numPriceInCar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceInCar.Location = new System.Drawing.Point(93, 123);
            this.numPriceInCar.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPriceInCar.Name = "numPriceInCar";
            this.numPriceInCar.ReadOnly = true;
            this.numPriceInCar.Size = new System.Drawing.Size(239, 26);
            this.numPriceInCar.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(38, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 30;
            this.label9.Text = "Price :";
            // 
            // txtModelInCar
            // 
            this.txtModelInCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModelInCar.Location = new System.Drawing.Point(93, 77);
            this.txtModelInCar.Name = "txtModelInCar";
            this.txtModelInCar.ReadOnly = true;
            this.txtModelInCar.Size = new System.Drawing.Size(239, 26);
            this.txtModelInCar.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 15;
            this.label5.Text = "Model :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.numOrderStockInParts);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.comboBoxParts);
            this.tabPage2.Controls.Add(this.btnClearInParts);
            this.tabPage2.Controls.Add(this.btnAddtoCartInParts);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.txtRemarkInParts);
            this.tabPage2.Controls.Add(this.numPriceInParts);
            this.tabPage2.Controls.Add(this.numAvailableStockInParts);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.comboBoxCarInParts);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(378, 404);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Parts Order";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // numOrderStockInParts
            // 
            this.numOrderStockInParts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numOrderStockInParts.Location = new System.Drawing.Point(94, 297);
            this.numOrderStockInParts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numOrderStockInParts.Name = "numOrderStockInParts";
            this.numOrderStockInParts.Size = new System.Drawing.Size(244, 26);
            this.numOrderStockInParts.TabIndex = 67;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(11, 299);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 19);
            this.label12.TabIndex = 66;
            this.label12.Text = "A / Stock :";
            // 
            // comboBoxParts
            // 
            this.comboBoxParts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxParts.FormattingEnabled = true;
            this.comboBoxParts.Location = new System.Drawing.Point(94, 80);
            this.comboBoxParts.Name = "comboBoxParts";
            this.comboBoxParts.Size = new System.Drawing.Size(244, 27);
            this.comboBoxParts.TabIndex = 65;
            // 
            // btnClearInParts
            // 
            this.btnClearInParts.BackColor = System.Drawing.Color.White;
            this.btnClearInParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearInParts.Location = new System.Drawing.Point(118, 346);
            this.btnClearInParts.Name = "btnClearInParts";
            this.btnClearInParts.Size = new System.Drawing.Size(97, 30);
            this.btnClearInParts.TabIndex = 64;
            this.btnClearInParts.Text = "Clear";
            this.btnClearInParts.UseVisualStyleBackColor = false;
            // 
            // btnAddtoCartInParts
            // 
            this.btnAddtoCartInParts.BackColor = System.Drawing.Color.White;
            this.btnAddtoCartInParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddtoCartInParts.Location = new System.Drawing.Point(221, 346);
            this.btnAddtoCartInParts.Name = "btnAddtoCartInParts";
            this.btnAddtoCartInParts.Size = new System.Drawing.Size(117, 30);
            this.btnAddtoCartInParts.TabIndex = 63;
            this.btnAddtoCartInParts.Text = "Add To Cart";
            this.btnAddtoCartInParts.UseVisualStyleBackColor = false;
            this.btnAddtoCartInParts.Click += new System.EventHandler(this.btnAddtoCartInParts_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 19);
            this.label8.TabIndex = 62;
            this.label8.Text = "Remark :";
            // 
            // txtRemarkInParts
            // 
            this.txtRemarkInParts.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRemarkInParts.Location = new System.Drawing.Point(94, 177);
            this.txtRemarkInParts.Multiline = true;
            this.txtRemarkInParts.Name = "txtRemarkInParts";
            this.txtRemarkInParts.ReadOnly = true;
            this.txtRemarkInParts.Size = new System.Drawing.Size(244, 52);
            this.txtRemarkInParts.TabIndex = 61;
            // 
            // numPriceInParts
            // 
            this.numPriceInParts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numPriceInParts.Location = new System.Drawing.Point(94, 128);
            this.numPriceInParts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numPriceInParts.Name = "numPriceInParts";
            this.numPriceInParts.ReadOnly = true;
            this.numPriceInParts.Size = new System.Drawing.Size(244, 26);
            this.numPriceInParts.TabIndex = 60;
            // 
            // numAvailableStockInParts
            // 
            this.numAvailableStockInParts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numAvailableStockInParts.Location = new System.Drawing.Point(94, 248);
            this.numAvailableStockInParts.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.numAvailableStockInParts.Name = "numAvailableStockInParts";
            this.numAvailableStockInParts.ReadOnly = true;
            this.numAvailableStockInParts.Size = new System.Drawing.Size(244, 26);
            this.numAvailableStockInParts.TabIndex = 59;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(11, 250);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 19);
            this.label6.TabIndex = 58;
            this.label6.Text = "A / Stock :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 130);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 19);
            this.label7.TabIndex = 57;
            this.label7.Text = "Price :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(2, 83);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "Part Name :";
            // 
            // comboBoxCarInParts
            // 
            this.comboBoxCarInParts.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxCarInParts.FormattingEnabled = true;
            this.comboBoxCarInParts.Location = new System.Drawing.Point(94, 35);
            this.comboBoxCarInParts.Name = "comboBoxCarInParts";
            this.comboBoxCarInParts.Size = new System.Drawing.Size(244, 27);
            this.comboBoxCarInParts.TabIndex = 54;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "Car :";
            // 
            // dataGridViewCarParts
            // 
            this.dataGridViewCarParts.AllowUserToAddRows = false;
            this.dataGridViewCarParts.AllowUserToDeleteRows = false;
            this.dataGridViewCarParts.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarParts.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewCarParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCarParts.Location = new System.Drawing.Point(404, 65);
            this.dataGridViewCarParts.Name = "dataGridViewCarParts";
            this.dataGridViewCarParts.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewCarParts.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewCarParts.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders;
            this.dataGridViewCarParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCarParts.Size = new System.Drawing.Size(523, 415);
            this.dataGridViewCarParts.TabIndex = 59;
            // 
            // btnTableClear
            // 
            this.btnTableClear.BackColor = System.Drawing.Color.White;
            this.btnTableClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableClear.Location = new System.Drawing.Point(707, 568);
            this.btnTableClear.Name = "btnTableClear";
            this.btnTableClear.Size = new System.Drawing.Size(97, 30);
            this.btnTableClear.TabIndex = 66;
            this.btnTableClear.Text = "Clear Items";
            this.btnTableClear.UseVisualStyleBackColor = false;
            this.btnTableClear.Click += new System.EventHandler(this.btnTableClear_Click);
            // 
            // btnPlaceOrder
            // 
            this.btnPlaceOrder.BackColor = System.Drawing.Color.White;
            this.btnPlaceOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlaceOrder.Location = new System.Drawing.Point(810, 568);
            this.btnPlaceOrder.Name = "btnPlaceOrder";
            this.btnPlaceOrder.Size = new System.Drawing.Size(117, 30);
            this.btnPlaceOrder.TabIndex = 65;
            this.btnPlaceOrder.Text = "Place Order";
            this.btnPlaceOrder.UseVisualStyleBackColor = false;
            this.btnPlaceOrder.Click += new System.EventHandler(this.btnPlaceOrder_Click);
            // 
            // txtNetTotal
            // 
            this.txtNetTotal.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNetTotal.Location = new System.Drawing.Point(707, 530);
            this.txtNetTotal.Name = "txtNetTotal";
            this.txtNetTotal.ReadOnly = true;
            this.txtNetTotal.Size = new System.Drawing.Size(220, 32);
            this.txtNetTotal.TabIndex = 69;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label14.Location = new System.Drawing.Point(759, 496);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(116, 31);
            this.label14.TabIndex = 69;
            this.label14.Text = "Net Total";
            // 
            // OrderManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(951, 610);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtNetTotal);
            this.Controls.Add(this.btnTableClear);
            this.Controls.Add(this.dataGridViewCarParts);
            this.Controls.Add(this.btnPlaceOrder);
            this.Controls.Add(this.tabView);
            this.Controls.Add(this.label1);
            this.Name = "OrderManage";
            this.Text = "OrderManage";
            this.tabView.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderStockInCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableStockInCar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceInCar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderStockInParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceInParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numAvailableStockInParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCarParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewCarParts;
        private System.Windows.Forms.ComboBox comboBoxCarInParts;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numPriceInParts;
        private System.Windows.Forms.NumericUpDown numAvailableStockInParts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtRemarkInParts;
        private System.Windows.Forms.Button btnClearInParts;
        private System.Windows.Forms.Button btnAddtoCartInParts;
        private System.Windows.Forms.Button btnTableClear;
        private System.Windows.Forms.Button btnPlaceOrder;
        private System.Windows.Forms.TextBox txtModelInCar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numPriceInCar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.NumericUpDown numAvailableStockInCar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBoxCarInCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYearInCar;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnClearInCar;
        private System.Windows.Forms.Button btnAddtoCartInCar;
        private System.Windows.Forms.ComboBox comboBoxParts;
        private System.Windows.Forms.NumericUpDown numOrderStockInCar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown numOrderStockInParts;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNetTotal;
        private System.Windows.Forms.Label label14;
    }
}