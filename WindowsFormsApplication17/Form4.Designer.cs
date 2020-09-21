namespace WindowsFormsApplication17
{
    partial class ФормаОтчетаПоПродажам
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
            this.ЛистПроданныхТоваров = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ОбщаяСуммаПродажи = new System.Windows.Forms.Label();
            this.СохранитьВФайл = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.СоздатьФайл = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.ОткрытьФайл = new System.Windows.Forms.Button();
            this.ОчиститьАртикул = new System.Windows.Forms.Button();
            this.ОчиститьПлатформа = new System.Windows.Forms.Button();
            this.ОчиститьКатегория = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.АртикулТекстБокс = new System.Windows.Forms.TextBox();
            this.ПлатформаКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.КатегорияКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.ОчиститьСклад = new System.Windows.Forms.Button();
            this.СкладКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ОчиститьНомер = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.НомерТекстБокс = new System.Windows.Forms.TextBox();
            this.ОчиститьПоставку = new System.Windows.Forms.Button();
            this.ПоставкаКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ОчиститьОплату = new System.Windows.Forms.Button();
            this.ОплатаКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ОчиститьКоличество = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.КоличествоТекстБокс = new System.Windows.Forms.TextBox();
            this.ОчиститьЦену = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.ЦенаТекстБокс = new System.Windows.Forms.TextBox();
            this.Календарь = new System.Windows.Forms.DateTimePicker();
            this.ОчиститьКалендарь = new System.Windows.Forms.Button();
            this.ПоискТекстБокс = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ЛистПроданныхТоваров
            // 
            this.ЛистПроданныхТоваров.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22});
            this.ЛистПроданныхТоваров.FullRowSelect = true;
            this.ЛистПроданныхТоваров.GridLines = true;
            this.ЛистПроданныхТоваров.Location = new System.Drawing.Point(0, 0);
            this.ЛистПроданныхТоваров.Name = "ЛистПроданныхТоваров";
            this.ЛистПроданныхТоваров.Size = new System.Drawing.Size(1044, 248);
            this.ЛистПроданныхТоваров.TabIndex = 3;
            this.ЛистПроданныхТоваров.UseCompatibleStateImageBehavior = false;
            this.ЛистПроданныхТоваров.View = System.Windows.Forms.View.Details;
            this.ЛистПроданныхТоваров.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.СортировкаКолонны);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Дата";
            this.columnHeader6.Width = 82;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Номер";
            this.columnHeader13.Width = 68;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Артикул";
            this.columnHeader14.Width = 66;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Наименование";
            this.columnHeader15.Width = 109;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Категория";
            this.columnHeader16.Width = 102;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Платформа";
            this.columnHeader17.Width = 93;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Поставка";
            this.columnHeader18.Width = 85;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Оплата";
            this.columnHeader19.Width = 87;
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "Количество";
            this.columnHeader20.Width = 98;
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "Цена";
            this.columnHeader21.Width = 88;
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "Склад";
            this.columnHeader22.Width = 173;
            // 
            // ОбщаяСуммаПродажи
            // 
            this.ОбщаяСуммаПродажи.AutoSize = true;
            this.ОбщаяСуммаПродажи.Location = new System.Drawing.Point(12, 383);
            this.ОбщаяСуммаПродажи.Name = "ОбщаяСуммаПродажи";
            this.ОбщаяСуммаПродажи.Size = new System.Drawing.Size(124, 13);
            this.ОбщаяСуммаПродажи.TabIndex = 4;
            this.ОбщаяСуммаПродажи.Text = "Обшая сумма продажи";
            // 
            // СохранитьВФайл
            // 
            this.СохранитьВФайл.Location = new System.Drawing.Point(545, 378);
            this.СохранитьВФайл.Name = "СохранитьВФайл";
            this.СохранитьВФайл.Size = new System.Drawing.Size(126, 23);
            this.СохранитьВФайл.TabIndex = 5;
            this.СохранитьВФайл.Text = "Сохранить в файл";
            this.СохранитьВФайл.UseVisualStyleBackColor = true;
            this.СохранитьВФайл.Click += new System.EventHandler(this.СохранитьВФайл_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Сохранить в";
            // 
            // СоздатьФайл
            // 
            this.СоздатьФайл.Location = new System.Drawing.Point(415, 378);
            this.СоздатьФайл.Name = "СоздатьФайл";
            this.СоздатьФайл.Size = new System.Drawing.Size(100, 23);
            this.СоздатьФайл.TabIndex = 6;
            this.СоздатьФайл.Text = "Создать файл";
            this.СоздатьФайл.UseVisualStyleBackColor = true;
            this.СоздатьФайл.Click += new System.EventHandler(this.СоздатьФайл_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Сохранить в ";
            // 
            // ОткрытьФайл
            // 
            this.ОткрытьФайл.Location = new System.Drawing.Point(705, 378);
            this.ОткрытьФайл.Name = "ОткрытьФайл";
            this.ОткрытьФайл.Size = new System.Drawing.Size(75, 23);
            this.ОткрытьФайл.TabIndex = 7;
            this.ОткрытьФайл.Text = "Открыть";
            this.ОткрытьФайл.UseVisualStyleBackColor = true;
            this.ОткрытьФайл.Click += new System.EventHandler(this.ОткрытьФайл_Click);
            // 
            // ОчиститьАртикул
            // 
            this.ОчиститьАртикул.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьАртикул.Location = new System.Drawing.Point(358, 324);
            this.ОчиститьАртикул.Name = "ОчиститьАртикул";
            this.ОчиститьАртикул.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьАртикул.TabIndex = 63;
            this.ОчиститьАртикул.Text = "-";
            this.ОчиститьАртикул.UseVisualStyleBackColor = true;
            this.ОчиститьАртикул.Click += new System.EventHandler(this.ОчиститьАртикул_Click);
            // 
            // ОчиститьПлатформа
            // 
            this.ОчиститьПлатформа.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьПлатформа.Location = new System.Drawing.Point(379, 299);
            this.ОчиститьПлатформа.Name = "ОчиститьПлатформа";
            this.ОчиститьПлатформа.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьПлатформа.TabIndex = 62;
            this.ОчиститьПлатформа.Text = "-";
            this.ОчиститьПлатформа.UseVisualStyleBackColor = true;
            this.ОчиститьПлатформа.Click += new System.EventHandler(this.ОчиститьПлатформа_Click);
            // 
            // ОчиститьКатегория
            // 
            this.ОчиститьКатегория.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьКатегория.Location = new System.Drawing.Point(379, 267);
            this.ОчиститьКатегория.Name = "ОчиститьКатегория";
            this.ОчиститьКатегория.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьКатегория.TabIndex = 61;
            this.ОчиститьКатегория.Text = "-";
            this.ОчиститьКатегория.UseVisualStyleBackColor = true;
            this.ОчиститьКатегория.Click += new System.EventHandler(this.ОчиститьКатегория_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(189, 329);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 60;
            this.label7.Text = "Артикул";
            // 
            // АртикулТекстБокс
            // 
            this.АртикулТекстБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.АртикулТекстБокс.Location = new System.Drawing.Point(252, 326);
            this.АртикулТекстБокс.Name = "АртикулТекстБокс";
            this.АртикулТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.АртикулТекстБокс.TabIndex = 59;
            this.АртикулТекстБокс.TextChanged += new System.EventHandler(this.АртикулТекстБокс_TextChanged);
            this.АртикулТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.АртикулТекстБокс_KeyPress);
            // 
            // ПлатформаКомбоБокс
            // 
            this.ПлатформаКомбоБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ПлатформаКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ПлатформаКомбоБокс.FormattingEnabled = true;
            this.ПлатформаКомбоБокс.Items.AddRange(new object[] {
            "Nintendo Switch",
            "Nintendo 3DS",
            "Xbox One",
            "Xbox 360",
            "PlayStation 4",
            "PlayStation 3",
            "PlayStation 2",
            "PSP",
            "PS Vita",
            "PC"});
            this.ПлатформаКомбоБокс.Location = new System.Drawing.Point(252, 299);
            this.ПлатформаКомбоБокс.Name = "ПлатформаКомбоБокс";
            this.ПлатформаКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.ПлатформаКомбоБокс.TabIndex = 58;
            this.ПлатформаКомбоБокс.SelectedIndexChanged += new System.EventHandler(this.ПлатформаКомбоБокс_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 302);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 57;
            this.label6.Text = "Платформа";
            // 
            // КатегорияКомбоБокс
            // 
            this.КатегорияКомбоБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.КатегорияКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.КатегорияКомбоБокс.FormattingEnabled = true;
            this.КатегорияКомбоБокс.Items.AddRange(new object[] {
            "Аксессуары",
            "Консоли",
            "Игры"});
            this.КатегорияКомбоБокс.Location = new System.Drawing.Point(252, 269);
            this.КатегорияКомбоБокс.Name = "КатегорияКомбоБокс";
            this.КатегорияКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.КатегорияКомбоБокс.TabIndex = 56;
            this.КатегорияКомбоБокс.SelectedIndexChanged += new System.EventHandler(this.КатегорияКомбоБокс_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(186, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 55;
            this.label5.Text = "Категория";
            // 
            // ОчиститьСклад
            // 
            this.ОчиститьСклад.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьСклад.Location = new System.Drawing.Point(139, 267);
            this.ОчиститьСклад.Name = "ОчиститьСклад";
            this.ОчиститьСклад.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьСклад.TabIndex = 54;
            this.ОчиститьСклад.Text = "-";
            this.ОчиститьСклад.UseVisualStyleBackColor = true;
            this.ОчиститьСклад.Click += new System.EventHandler(this.ОчиститьСклад_Click);
            // 
            // СкладКомбоБокс
            // 
            this.СкладКомбоБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.СкладКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.СкладКомбоБокс.FormattingEnabled = true;
            this.СкладКомбоБокс.Items.AddRange(new object[] {
            "Основной склад",
            "Дополнительный склад"});
            this.СкладКомбоБокс.Location = new System.Drawing.Point(12, 267);
            this.СкладКомбоБокс.Name = "СкладКомбоБокс";
            this.СкладКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.СкладКомбоБокс.TabIndex = 53;
            this.СкладКомбоБокс.SelectedIndexChanged += new System.EventHandler(this.СкладКомбоБокс_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 52;
            this.label3.Text = "Склад";
            // 
            // ОчиститьНомер
            // 
            this.ОчиститьНомер.Location = new System.Drawing.Point(118, 313);
            this.ОчиститьНомер.Name = "ОчиститьНомер";
            this.ОчиститьНомер.Size = new System.Drawing.Size(29, 23);
            this.ОчиститьНомер.TabIndex = 64;
            this.ОчиститьНомер.Text = "-";
            this.ОчиститьНомер.UseVisualStyleBackColor = true;
            this.ОчиститьНомер.Click += new System.EventHandler(this.ОчиститьНомер_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 299);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 65;
            this.label1.Text = "Номер";
            // 
            // НомерТекстБокс
            // 
            this.НомерТекстБокс.Location = new System.Drawing.Point(12, 315);
            this.НомерТекстБокс.Name = "НомерТекстБокс";
            this.НомерТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.НомерТекстБокс.TabIndex = 66;
            this.НомерТекстБокс.TextChanged += new System.EventHandler(this.НомерТекстБокс_TextChanged);
            this.НомерТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.НомерТекстБокс_KeyPress);
            // 
            // ОчиститьПоставку
            // 
            this.ОчиститьПоставку.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьПоставку.Location = new System.Drawing.Point(625, 265);
            this.ОчиститьПоставку.Name = "ОчиститьПоставку";
            this.ОчиститьПоставку.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьПоставку.TabIndex = 69;
            this.ОчиститьПоставку.Text = "-";
            this.ОчиститьПоставку.UseVisualStyleBackColor = true;
            this.ОчиститьПоставку.Click += new System.EventHandler(this.ОчиститьПоставку_Click);
            // 
            // ПоставкаКомбоБокс
            // 
            this.ПоставкаКомбоБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ПоставкаКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ПоставкаКомбоБокс.FormattingEnabled = true;
            this.ПоставкаКомбоБокс.Items.AddRange(new object[] {
            "БУКА",
            "СофтКлаб",
            "Кудос",
            "Centrum Games"});
            this.ПоставкаКомбоБокс.Location = new System.Drawing.Point(498, 267);
            this.ПоставкаКомбоБокс.Name = "ПоставкаКомбоБокс";
            this.ПоставкаКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.ПоставкаКомбоБокс.TabIndex = 68;
            this.ПоставкаКомбоБокс.SelectedIndexChanged += new System.EventHandler(this.ПоставкаКомбоБокс_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(432, 270);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 67;
            this.label2.Text = "Поставка";
            // 
            // ОчиститьОплату
            // 
            this.ОчиститьОплату.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьОплату.Location = new System.Drawing.Point(625, 294);
            this.ОчиститьОплату.Name = "ОчиститьОплату";
            this.ОчиститьОплату.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьОплату.TabIndex = 72;
            this.ОчиститьОплату.Text = "-";
            this.ОчиститьОплату.UseVisualStyleBackColor = true;
            this.ОчиститьОплату.Click += new System.EventHandler(this.ОчиститьОплату_Click);
            // 
            // ОплатаКомбоБокс
            // 
            this.ОплатаКомбоБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОплатаКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ОплатаКомбоБокс.FormattingEnabled = true;
            this.ОплатаКомбоБокс.Items.AddRange(new object[] {
            "Наличные",
            "Безналичный расчет"});
            this.ОплатаКомбоБокс.Location = new System.Drawing.Point(498, 296);
            this.ОплатаКомбоБокс.Name = "ОплатаКомбоБокс";
            this.ОплатаКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.ОплатаКомбоБокс.TabIndex = 71;
            this.ОплатаКомбоБокс.SelectedIndexChanged += new System.EventHandler(this.ОплатаКомбоБокс_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(432, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 70;
            this.label4.Text = "Оплата";
            // 
            // ОчиститьКоличество
            // 
            this.ОчиститьКоличество.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьКоличество.Location = new System.Drawing.Point(604, 325);
            this.ОчиститьКоличество.Name = "ОчиститьКоличество";
            this.ОчиститьКоличество.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьКоличество.TabIndex = 75;
            this.ОчиститьКоличество.Text = "-";
            this.ОчиститьКоличество.UseVisualStyleBackColor = true;
            this.ОчиститьКоличество.Click += new System.EventHandler(this.ОчиститьКоличество_Click);
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(422, 330);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 74;
            this.label8.Text = "Количество";
            // 
            // КоличествоТекстБокс
            // 
            this.КоличествоТекстБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.КоличествоТекстБокс.Location = new System.Drawing.Point(498, 327);
            this.КоличествоТекстБокс.Name = "КоличествоТекстБокс";
            this.КоличествоТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.КоличествоТекстБокс.TabIndex = 73;
            this.КоличествоТекстБокс.TextChanged += new System.EventHandler(this.КоличествоТекстБокс_TextChanged);
            this.КоличествоТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.КоличествоТекстБокс_KeyPress);
            // 
            // ОчиститьЦену
            // 
            this.ОчиститьЦену.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьЦену.Location = new System.Drawing.Point(829, 298);
            this.ОчиститьЦену.Name = "ОчиститьЦену";
            this.ОчиститьЦену.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьЦену.TabIndex = 81;
            this.ОчиститьЦену.Text = "-";
            this.ОчиститьЦену.UseVisualStyleBackColor = true;
            this.ОчиститьЦену.Click += new System.EventHandler(this.ОчиститьЦену_Click);
            // 
            // label10
            // 
            this.label10.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(684, 302);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(33, 13);
            this.label10.TabIndex = 80;
            this.label10.Text = "Цена";
            // 
            // ЦенаТекстБокс
            // 
            this.ЦенаТекстБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ЦенаТекстБокс.Location = new System.Drawing.Point(723, 300);
            this.ЦенаТекстБокс.Name = "ЦенаТекстБокс";
            this.ЦенаТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.ЦенаТекстБокс.TabIndex = 79;
            this.ЦенаТекстБокс.TextChanged += new System.EventHandler(this.ЦенаТекстБокс_TextChanged);
            this.ЦенаТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ЦенаТекстБокс_KeyPress);
            // 
            // Календарь
            // 
            this.Календарь.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Календарь.Location = new System.Drawing.Point(705, 268);
            this.Календарь.Name = "Календарь";
            this.Календарь.Size = new System.Drawing.Size(200, 20);
            this.Календарь.TabIndex = 82;
            this.Календарь.Value = new System.DateTime(2017, 5, 30, 12, 43, 44, 0);
            this.Календарь.ValueChanged += new System.EventHandler(this.Календарь_ValueChanged);
            // 
            // ОчиститьКалендарь
            // 
            this.ОчиститьКалендарь.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьКалендарь.Location = new System.Drawing.Point(911, 267);
            this.ОчиститьКалендарь.Name = "ОчиститьКалендарь";
            this.ОчиститьКалендарь.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьКалендарь.TabIndex = 83;
            this.ОчиститьКалендарь.Text = "-";
            this.ОчиститьКалендарь.UseVisualStyleBackColor = true;
            this.ОчиститьКалендарь.Click += new System.EventHandler(this.ОчиститьКалендарь_Click_1);
            // 
            // ПоискТекстБокс
            // 
            this.ПоискТекстБокс.Location = new System.Drawing.Point(139, 358);
            this.ПоискТекстБокс.Name = "ПоискТекстБокс";
            this.ПоискТекстБокс.Size = new System.Drawing.Size(186, 20);
            this.ПоискТекстБокс.TabIndex = 84;
            this.ПоискТекстБокс.TextChanged += new System.EventHandler(this.ПоискТекстБокс_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(98, 361);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(39, 13);
            this.label9.TabIndex = 85;
            this.label9.Text = "Поиск";
            // 
            // ФормаОтчетаПоПродажам
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1041, 405);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.ПоискТекстБокс);
            this.Controls.Add(this.ОчиститьКалендарь);
            this.Controls.Add(this.Календарь);
            this.Controls.Add(this.ОчиститьЦену);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.ЦенаТекстБокс);
            this.Controls.Add(this.ОчиститьКоличество);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.КоличествоТекстБокс);
            this.Controls.Add(this.ОчиститьОплату);
            this.Controls.Add(this.ОплатаКомбоБокс);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ОчиститьПоставку);
            this.Controls.Add(this.ПоставкаКомбоБокс);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.НомерТекстБокс);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ОчиститьНомер);
            this.Controls.Add(this.ОчиститьАртикул);
            this.Controls.Add(this.ОчиститьПлатформа);
            this.Controls.Add(this.ОчиститьКатегория);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.АртикулТекстБокс);
            this.Controls.Add(this.ПлатформаКомбоБокс);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.КатегорияКомбоБокс);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ОчиститьСклад);
            this.Controls.Add(this.СкладКомбоБокс);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ОткрытьФайл);
            this.Controls.Add(this.СоздатьФайл);
            this.Controls.Add(this.СохранитьВФайл);
            this.Controls.Add(this.ОбщаяСуммаПродажи);
            this.Controls.Add(this.ЛистПроданныхТоваров);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ФормаОтчетаПоПродажам";
            this.Text = "Отчет по продажам";
            this.Load += new System.EventHandler(this.Загрузка4Формы);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ListView ЛистПроданныхТоваров;
        private System.Windows.Forms.Label ОбщаяСуммаПродажи;
        private System.Windows.Forms.Button СохранитьВФайл;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button СоздатьФайл;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button ОткрытьФайл;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.Button ОчиститьАртикул;
        private System.Windows.Forms.Button ОчиститьПлатформа;
        private System.Windows.Forms.Button ОчиститьКатегория;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox АртикулТекстБокс;
        private System.Windows.Forms.ComboBox ПлатформаКомбоБокс;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox КатегорияКомбоБокс;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button ОчиститьСклад;
        private System.Windows.Forms.ComboBox СкладКомбоБокс;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ОчиститьНомер;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox НомерТекстБокс;
        private System.Windows.Forms.Button ОчиститьПоставку;
        private System.Windows.Forms.ComboBox ПоставкаКомбоБокс;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ОчиститьОплату;
        private System.Windows.Forms.ComboBox ОплатаКомбоБокс;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button ОчиститьКоличество;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox КоличествоТекстБокс;
        private System.Windows.Forms.Button ОчиститьЦену;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox ЦенаТекстБокс;
        private System.Windows.Forms.DateTimePicker Календарь;
        private System.Windows.Forms.Button ОчиститьКалендарь;
        private System.Windows.Forms.TextBox ПоискТекстБокс;
        private System.Windows.Forms.Label label9;
    }
}