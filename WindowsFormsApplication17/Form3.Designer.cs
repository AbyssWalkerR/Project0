namespace WindowsFormsApplication17
{
    partial class ФормаПродажи
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Оформитьпродажу = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.КоличествоТекстБокс = new System.Windows.Forms.TextBox();
            this.ОчиститьАртикул = new System.Windows.Forms.Button();
            this.ОчиститьПлатформу = new System.Windows.Forms.Button();
            this.ОчиститьКатегорию = new System.Windows.Forms.Button();
            this.ОчиститьСклад = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.АртикулТекстБокс = new System.Windows.Forms.TextBox();
            this.ПлатформаКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.КатегорияКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ЛистТоваровНаПродажу = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Формаоплатыкомбобокс = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.СкладКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Календарь = new System.Windows.Forms.MonthCalendar();
            this.label2 = new System.Windows.Forms.Label();
            this.ДатаТекстБокс = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Оформитьпродажу);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.КоличествоТекстБокс);
            this.groupBox1.Controls.Add(this.ОчиститьАртикул);
            this.groupBox1.Controls.Add(this.ОчиститьПлатформу);
            this.groupBox1.Controls.Add(this.ОчиститьКатегорию);
            this.groupBox1.Controls.Add(this.ОчиститьСклад);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.АртикулТекстБокс);
            this.groupBox1.Controls.Add(this.ПлатформаКомбоБокс);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.КатегорияКомбоБокс);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.ЛистТоваровНаПродажу);
            this.groupBox1.Controls.Add(this.Формаоплатыкомбобокс);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.СкладКомбоБокс);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Календарь);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ДатаТекстБокс);
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(817, 398);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Продажа";
            // 
            // Оформитьпродажу
            // 
            this.Оформитьпродажу.Location = new System.Drawing.Point(671, 224);
            this.Оформитьпродажу.Name = "Оформитьпродажу";
            this.Оформитьпродажу.Size = new System.Drawing.Size(117, 23);
            this.Оформитьпродажу.TabIndex = 43;
            this.Оформитьпродажу.Text = "Оформить продажу";
            this.Оформитьпродажу.UseVisualStyleBackColor = true;
            this.Оформитьпродажу.Click += new System.EventHandler(this.Оформитьпродажу_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(362, 155);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 42;
            this.label8.Text = "Количество";
            // 
            // КоличествоТекстБокс
            // 
            this.КоличествоТекстБокс.Location = new System.Drawing.Point(434, 152);
            this.КоличествоТекстБокс.Name = "КоличествоТекстБокс";
            this.КоличествоТекстБокс.Size = new System.Drawing.Size(49, 20);
            this.КоличествоТекстБокс.TabIndex = 41;
            this.КоличествоТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.КоличествоТекстБокс_KeyPress);
            // 
            // ОчиститьАртикул
            // 
            this.ОчиститьАртикул.Location = new System.Drawing.Point(540, 124);
            this.ОчиститьАртикул.Name = "ОчиститьАртикул";
            this.ОчиститьАртикул.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьАртикул.TabIndex = 40;
            this.ОчиститьАртикул.Text = "-";
            this.ОчиститьАртикул.UseVisualStyleBackColor = true;
            this.ОчиститьАртикул.Click += new System.EventHandler(this.ОчиститьАртикул_Click);
            // 
            // ОчиститьПлатформу
            // 
            this.ОчиститьПлатформу.Location = new System.Drawing.Point(561, 96);
            this.ОчиститьПлатформу.Name = "ОчиститьПлатформу";
            this.ОчиститьПлатформу.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьПлатформу.TabIndex = 39;
            this.ОчиститьПлатформу.Text = "-";
            this.ОчиститьПлатформу.UseVisualStyleBackColor = true;
            this.ОчиститьПлатформу.Click += new System.EventHandler(this.ОчиститьПлатформу_Click);
            // 
            // ОчиститьКатегорию
            // 
            this.ОчиститьКатегорию.Location = new System.Drawing.Point(561, 67);
            this.ОчиститьКатегорию.Name = "ОчиститьКатегорию";
            this.ОчиститьКатегорию.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьКатегорию.TabIndex = 38;
            this.ОчиститьКатегорию.Text = "-";
            this.ОчиститьКатегорию.UseVisualStyleBackColor = true;
            this.ОчиститьКатегорию.Click += new System.EventHandler(this.ОчиститьКатегорию_Click);
            // 
            // ОчиститьСклад
            // 
            this.ОчиститьСклад.Location = new System.Drawing.Point(133, 83);
            this.ОчиститьСклад.Name = "ОчиститьСклад";
            this.ОчиститьСклад.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьСклад.TabIndex = 37;
            this.ОчиститьСклад.Text = "-";
            this.ОчиститьСклад.UseVisualStyleBackColor = true;
            this.ОчиститьСклад.Click += new System.EventHandler(this.ОчиститьСклад_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(371, 129);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 36;
            this.label7.Text = "Артикул";
            // 
            // АртикулТекстБокс
            // 
            this.АртикулТекстБокс.Location = new System.Drawing.Point(434, 126);
            this.АртикулТекстБокс.Name = "АртикулТекстБокс";
            this.АртикулТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.АртикулТекстБокс.TabIndex = 35;
            this.АртикулТекстБокс.TextChanged += new System.EventHandler(this.АртикулТекстБокс_TextChanged);
            this.АртикулТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.АртикулТекстБокс_KeyPress);
            // 
            // ПлатформаКомбоБокс
            // 
            this.ПлатформаКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ПлатформаКомбоБокс.FormattingEnabled = true;
            this.ПлатформаКомбоБокс.Items.AddRange(new object[] {
            "Nintendo Switch",
            "Nintendo 3DS",
            "Xbox One",
            "Xbox 360\t",
            "PlayStation 4",
            "PlayStation 3",
            "PlayStation 2",
            "PSP",
            "PS Vita",
            "PC"});
            this.ПлатформаКомбоБокс.Location = new System.Drawing.Point(434, 99);
            this.ПлатформаКомбоБокс.Name = "ПлатформаКомбоБокс";
            this.ПлатформаКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.ПлатформаКомбоБокс.TabIndex = 34;
            this.ПлатформаКомбоБокс.SelectionChangeCommitted += new System.EventHandler(this.ПлатформаКомбоБокс_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(368, 102);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Платформа";
            // 
            // КатегорияКомбоБокс
            // 
            this.КатегорияКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.КатегорияКомбоБокс.FormattingEnabled = true;
            this.КатегорияКомбоБокс.Items.AddRange(new object[] {
            "Аксессуары",
            "Консоли",
            "Игры"});
            this.КатегорияКомбоБокс.Location = new System.Drawing.Point(434, 69);
            this.КатегорияКомбоБокс.Name = "КатегорияКомбоБокс";
            this.КатегорияКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.КатегорияКомбоБокс.TabIndex = 32;
            this.КатегорияКомбоБокс.SelectionChangeCommitted += new System.EventHandler(this.КатегорияКомбоБокс_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(368, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 31;
            this.label5.Text = "Категория";
            // 
            // ЛистТоваровНаПродажу
            // 
            this.ЛистТоваровНаПродажу.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ЛистТоваровНаПродажу.FullRowSelect = true;
            this.ЛистТоваровНаПродажу.GridLines = true;
            this.ЛистТоваровНаПродажу.Location = new System.Drawing.Point(10, 224);
            this.ЛистТоваровНаПродажу.Name = "ЛистТоваровНаПродажу";
            this.ЛистТоваровНаПродажу.Size = new System.Drawing.Size(645, 153);
            this.ЛистТоваровНаПродажу.TabIndex = 30;
            this.ЛистТоваровНаПродажу.UseCompatibleStateImageBehavior = false;
            this.ЛистТоваровНаПродажу.View = System.Windows.Forms.View.Details;
            this.ЛистТоваровНаПродажу.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.СортировкаКолонны);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Артикул";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Наименование";
            this.columnHeader2.Width = 180;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Категория";
            this.columnHeader3.Width = 99;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Платформа";
            this.columnHeader4.Width = 98;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Остаток";
            this.columnHeader5.Width = 55;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Сумма";
            this.columnHeader6.Width = 145;
            // 
            // Формаоплатыкомбобокс
            // 
            this.Формаоплатыкомбобокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Формаоплатыкомбобокс.FormattingEnabled = true;
            this.Формаоплатыкомбобокс.Items.AddRange(new object[] {
            "Наличные",
            "Безналичный расчет"});
            this.Формаоплатыкомбобокс.Location = new System.Drawing.Point(10, 142);
            this.Формаоплатыкомбобокс.Name = "Формаоплатыкомбобокс";
            this.Формаоплатыкомбобокс.Size = new System.Drawing.Size(121, 21);
            this.Формаоплатыкомбобокс.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 126);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 13);
            this.label4.TabIndex = 28;
            this.label4.Text = "Форма оплаты";
            // 
            // СкладКомбоБокс
            // 
            this.СкладКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СкладКомбоБокс.FormattingEnabled = true;
            this.СкладКомбоБокс.Items.AddRange(new object[] {
            "Основной склад",
            "Дополнительный склад"});
            this.СкладКомбоБокс.Location = new System.Drawing.Point(6, 83);
            this.СкладКомбоБокс.Name = "СкладКомбоБокс";
            this.СкладКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.СкладКомбоБокс.TabIndex = 27;
            this.СкладКомбоБокс.SelectionChangeCommitted += new System.EventHandler(this.СкладКомбоБокс_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Склад";
            // 
            // Календарь
            // 
            this.Календарь.Location = new System.Drawing.Point(195, 50);
            this.Календарь.Name = "Календарь";
            this.Календарь.TabIndex = 25;
            this.Календарь.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Календарь2_DateChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(192, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Дата";
            // 
            // ДатаТекстБокс
            // 
            this.ДатаТекстБокс.Location = new System.Drawing.Point(231, 25);
            this.ДатаТекстБокс.Name = "ДатаТекстБокс";
            this.ДатаТекстБокс.Size = new System.Drawing.Size(128, 20);
            this.ДатаТекстБокс.TabIndex = 23;
            this.ДатаТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ДатаТекстБокс_KeyPress);
            // 
            // ФормаПродажи
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 414);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ФормаПродажи";
            this.Text = "Продажа";
            this.Load += new System.EventHandler(this.Загрузка3Формы);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox АртикулТекстБокс;
        private System.Windows.Forms.ComboBox ПлатформаКомбоБокс;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox КатегорияКомбоБокс;
        private System.Windows.Forms.Label label5;
        internal System.Windows.Forms.ListView ЛистТоваровНаПродажу;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ComboBox Формаоплатыкомбобокс;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox СкладКомбоБокс;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MonthCalendar Календарь;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ДатаТекстБокс;
        private System.Windows.Forms.Button ОчиститьСклад;
        private System.Windows.Forms.Button ОчиститьАртикул;
        private System.Windows.Forms.Button ОчиститьПлатформу;
        private System.Windows.Forms.Button ОчиститьКатегорию;
        private System.Windows.Forms.Button Оформитьпродажу;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox КоличествоТекстБокс;
    }
}