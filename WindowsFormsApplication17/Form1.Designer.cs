namespace WindowsFormsApplication17
{
    partial class ОсновнаяФорма
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.Вкладки = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.ВывестиПоступившиеТовары = new System.Windows.Forms.Button();
            this.ЗагрузитьИзФайла = new System.Windows.Forms.Button();
            this.ОчиститьЛист1 = new System.Windows.Forms.Button();
            this.ДобавитьНовоеПоступление = new System.Windows.Forms.Button();
            this.ЛистПоставки = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.ОбщаяСуммаПродажи = new System.Windows.Forms.Label();
            this.ОтчетПоПродажам = new System.Windows.Forms.Button();
            this.Обновить2Лист = new System.Windows.Forms.Button();
            this.ЛистПродажи = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Очистить2Лист = new System.Windows.Forms.Button();
            this.ОформлениеПродажи = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.ПоискТекстБокс = new System.Windows.Forms.TextBox();
            this.СоздатьФайл = new System.Windows.Forms.Button();
            this.СохранитьВФайл = new System.Windows.Forms.Button();
            this.ОбщаяСуммаОставшихсяТоваров = new System.Windows.Forms.Label();
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
            this.Очистить3Лист = new System.Windows.Forms.Button();
            this.Обновить3Лист = new System.Windows.Forms.Button();
            this.ЛистОстатка = new System.Windows.Forms.ListView();
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.Вкладки.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Вкладки
            // 
            this.Вкладки.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Вкладки.Controls.Add(this.tabPage1);
            this.Вкладки.Controls.Add(this.tabPage2);
            this.Вкладки.Controls.Add(this.tabPage3);
            this.Вкладки.Location = new System.Drawing.Point(2, 3);
            this.Вкладки.Name = "Вкладки";
            this.Вкладки.SelectedIndex = 0;
            this.Вкладки.Size = new System.Drawing.Size(703, 402);
            this.Вкладки.TabIndex = 0;
            this.Вкладки.SelectedIndexChanged += new System.EventHandler(this.ПереключениеВкладки);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.ВывестиПоступившиеТовары);
            this.tabPage1.Controls.Add(this.ЗагрузитьИзФайла);
            this.tabPage1.Controls.Add(this.ОчиститьЛист1);
            this.tabPage1.Controls.Add(this.ДобавитьНовоеПоступление);
            this.tabPage1.Controls.Add(this.ЛистПоставки);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(695, 376);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Поступление товара";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // ВывестиПоступившиеТовары
            // 
            this.ВывестиПоступившиеТовары.Location = new System.Drawing.Point(117, 8);
            this.ВывестиПоступившиеТовары.Name = "ВывестиПоступившиеТовары";
            this.ВывестиПоступившиеТовары.Size = new System.Drawing.Size(82, 23);
            this.ВывестиПоступившиеТовары.TabIndex = 5;
            this.ВывестиПоступившиеТовары.Text = "Поступление";
            this.ВывестиПоступившиеТовары.UseVisualStyleBackColor = true;
            this.ВывестиПоступившиеТовары.Click += new System.EventHandler(this.ВывестиПоступившиеТовары_Click);
            // 
            // ЗагрузитьИзФайла
            // 
            this.ЗагрузитьИзФайла.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ЗагрузитьИзФайла.Location = new System.Drawing.Point(231, 8);
            this.ЗагрузитьИзФайла.Name = "ЗагрузитьИзФайла";
            this.ЗагрузитьИзФайла.Size = new System.Drawing.Size(133, 23);
            this.ЗагрузитьИзФайла.TabIndex = 4;
            this.ЗагрузитьИзФайла.Text = "Загрузка из файла";
            this.ЗагрузитьИзФайла.UseVisualStyleBackColor = true;
            this.ЗагрузитьИзФайла.Click += new System.EventHandler(this.ЗагрузитьИзФайла_Click);
            // 
            // ОчиститьЛист1
            // 
            this.ОчиститьЛист1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьЛист1.Location = new System.Drawing.Point(45, 8);
            this.ОчиститьЛист1.Name = "ОчиститьЛист1";
            this.ОчиститьЛист1.Size = new System.Drawing.Size(30, 23);
            this.ОчиститьЛист1.TabIndex = 3;
            this.ОчиститьЛист1.Text = "-";
            this.ОчиститьЛист1.UseVisualStyleBackColor = true;
            this.ОчиститьЛист1.Click += new System.EventHandler(this.ОчиститьЛист1_Click);
            // 
            // ДобавитьНовоеПоступление
            // 
            this.ДобавитьНовоеПоступление.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ДобавитьНовоеПоступление.BackColor = System.Drawing.Color.Transparent;
            this.ДобавитьНовоеПоступление.Location = new System.Drawing.Point(6, 8);
            this.ДобавитьНовоеПоступление.Name = "ДобавитьНовоеПоступление";
            this.ДобавитьНовоеПоступление.Size = new System.Drawing.Size(33, 23);
            this.ДобавитьНовоеПоступление.TabIndex = 1;
            this.ДобавитьНовоеПоступление.Text = "+";
            this.ДобавитьНовоеПоступление.UseVisualStyleBackColor = false;
            this.ДобавитьНовоеПоступление.Click += new System.EventHandler(this.ДобавитьНовоеПоступление_Click);
            // 
            // ЛистПоставки
            // 
            this.ЛистПоставки.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ЛистПоставки.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6});
            this.ЛистПоставки.FullRowSelect = true;
            this.ЛистПоставки.GridLines = true;
            this.ЛистПоставки.Location = new System.Drawing.Point(6, 37);
            this.ЛистПоставки.Name = "ЛистПоставки";
            this.ЛистПоставки.Size = new System.Drawing.Size(689, 336);
            this.ЛистПоставки.TabIndex = 0;
            this.ЛистПоставки.UseCompatibleStateImageBehavior = false;
            this.ЛистПоставки.View = System.Windows.Forms.View.Details;
            this.ЛистПоставки.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.СортировкаКолонн);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Дата";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Номер";
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Наименование";
            this.columnHeader3.Width = 227;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Поставщик";
            this.columnHeader4.Width = 112;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Сумма";
            this.columnHeader5.Width = 97;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Место доставки";
            this.columnHeader6.Width = 145;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ОбщаяСуммаПродажи);
            this.tabPage2.Controls.Add(this.ОтчетПоПродажам);
            this.tabPage2.Controls.Add(this.Обновить2Лист);
            this.tabPage2.Controls.Add(this.ЛистПродажи);
            this.tabPage2.Controls.Add(this.Очистить2Лист);
            this.tabPage2.Controls.Add(this.ОформлениеПродажи);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(695, 376);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продажа";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ОбщаяСуммаПродажи
            // 
            this.ОбщаяСуммаПродажи.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОбщаяСуммаПродажи.AutoSize = true;
            this.ОбщаяСуммаПродажи.Location = new System.Drawing.Point(457, 11);
            this.ОбщаяСуммаПродажи.Name = "ОбщаяСуммаПродажи";
            this.ОбщаяСуммаПродажи.Size = new System.Drawing.Size(125, 13);
            this.ОбщаяСуммаПродажи.TabIndex = 5;
            this.ОбщаяСуммаПродажи.Text = "Общая сумма продажи";
            // 
            // ОтчетПоПродажам
            // 
            this.ОтчетПоПродажам.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОтчетПоПродажам.Location = new System.Drawing.Point(265, 6);
            this.ОтчетПоПродажам.Name = "ОтчетПоПродажам";
            this.ОтчетПоПродажам.Size = new System.Drawing.Size(144, 23);
            this.ОтчетПоПродажам.TabIndex = 4;
            this.ОтчетПоПродажам.Text = "Отчет по продажам";
            this.ОтчетПоПродажам.UseVisualStyleBackColor = true;
            this.ОтчетПоПродажам.Click += new System.EventHandler(this.ОтчетПоПродажам_Click);
            // 
            // Обновить2Лист
            // 
            this.Обновить2Лист.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Обновить2Лист.Location = new System.Drawing.Point(98, 6);
            this.Обновить2Лист.Name = "Обновить2Лист";
            this.Обновить2Лист.Size = new System.Drawing.Size(75, 23);
            this.Обновить2Лист.TabIndex = 3;
            this.Обновить2Лист.Text = "Продажи";
            this.Обновить2Лист.UseVisualStyleBackColor = true;
            this.Обновить2Лист.Click += new System.EventHandler(this.Обновить2Лист_Click);
            // 
            // ЛистПродажи
            // 
            this.ЛистПродажи.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ЛистПродажи.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.ЛистПродажи.FullRowSelect = true;
            this.ЛистПродажи.GridLines = true;
            this.ЛистПродажи.Location = new System.Drawing.Point(3, 35);
            this.ЛистПродажи.Name = "ЛистПродажи";
            this.ЛистПродажи.Size = new System.Drawing.Size(689, 336);
            this.ЛистПродажи.TabIndex = 2;
            this.ЛистПродажи.UseCompatibleStateImageBehavior = false;
            this.ЛистПродажи.View = System.Windows.Forms.View.Details;
            this.ЛистПродажи.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.СортировкаКолонн);
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Дата";
            this.columnHeader7.Width = 80;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Номер";
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Наименование";
            this.columnHeader9.Width = 227;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Форма оплаты";
            this.columnHeader10.Width = 112;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Сумма";
            this.columnHeader11.Width = 97;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Склад";
            this.columnHeader12.Width = 145;
            // 
            // Очистить2Лист
            // 
            this.Очистить2Лист.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Очистить2Лист.Location = new System.Drawing.Point(54, 6);
            this.Очистить2Лист.Name = "Очистить2Лист";
            this.Очистить2Лист.Size = new System.Drawing.Size(29, 23);
            this.Очистить2Лист.TabIndex = 1;
            this.Очистить2Лист.Text = "-";
            this.Очистить2Лист.UseVisualStyleBackColor = true;
            this.Очистить2Лист.Click += new System.EventHandler(this.Очистить2Лист_Click);
            // 
            // ОформлениеПродажи
            // 
            this.ОформлениеПродажи.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОформлениеПродажи.Location = new System.Drawing.Point(21, 6);
            this.ОформлениеПродажи.Name = "ОформлениеПродажи";
            this.ОформлениеПродажи.Size = new System.Drawing.Size(27, 23);
            this.ОформлениеПродажи.TabIndex = 0;
            this.ОформлениеПродажи.Text = "+";
            this.ОформлениеПродажи.UseVisualStyleBackColor = true;
            this.ОформлениеПродажи.Click += new System.EventHandler(this.ОформлениеПродажи_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label1);
            this.tabPage3.Controls.Add(this.ПоискТекстБокс);
            this.tabPage3.Controls.Add(this.СоздатьФайл);
            this.tabPage3.Controls.Add(this.СохранитьВФайл);
            this.tabPage3.Controls.Add(this.ОбщаяСуммаОставшихсяТоваров);
            this.tabPage3.Controls.Add(this.ОчиститьАртикул);
            this.tabPage3.Controls.Add(this.ОчиститьПлатформа);
            this.tabPage3.Controls.Add(this.ОчиститьКатегория);
            this.tabPage3.Controls.Add(this.label7);
            this.tabPage3.Controls.Add(this.АртикулТекстБокс);
            this.tabPage3.Controls.Add(this.ПлатформаКомбоБокс);
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.КатегорияКомбоБокс);
            this.tabPage3.Controls.Add(this.label5);
            this.tabPage3.Controls.Add(this.ОчиститьСклад);
            this.tabPage3.Controls.Add(this.СкладКомбоБокс);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Controls.Add(this.Очистить3Лист);
            this.tabPage3.Controls.Add(this.Обновить3Лист);
            this.tabPage3.Controls.Add(this.ЛистОстатка);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(695, 376);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Наличие";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "Поиск";
            // 
            // ПоискТекстБокс
            // 
            this.ПоискТекстБокс.Location = new System.Drawing.Point(388, 77);
            this.ПоискТекстБокс.Name = "ПоискТекстБокс";
            this.ПоискТекстБокс.Size = new System.Drawing.Size(174, 20);
            this.ПоискТекстБокс.TabIndex = 53;
            this.ПоискТекстБокс.TextChanged += new System.EventHandler(this.ПоискТекстБокс_TextChanged);
            // 
            // СоздатьФайл
            // 
            this.СоздатьФайл.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.СоздатьФайл.Location = new System.Drawing.Point(568, 35);
            this.СоздатьФайл.Name = "СоздатьФайл";
            this.СоздатьФайл.Size = new System.Drawing.Size(119, 23);
            this.СоздатьФайл.TabIndex = 52;
            this.СоздатьФайл.Text = "Создать файл";
            this.СоздатьФайл.UseVisualStyleBackColor = true;
            this.СоздатьФайл.Click += new System.EventHandler(this.СоздатьФайл_Click);
            // 
            // СохранитьВФайл
            // 
            this.СохранитьВФайл.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.СохранитьВФайл.Location = new System.Drawing.Point(568, 62);
            this.СохранитьВФайл.Name = "СохранитьВФайл";
            this.СохранитьВФайл.Size = new System.Drawing.Size(119, 23);
            this.СохранитьВФайл.TabIndex = 51;
            this.СохранитьВФайл.Text = "Сохранить в файл";
            this.СохранитьВФайл.UseVisualStyleBackColor = true;
            this.СохранитьВФайл.Click += new System.EventHandler(this.СохранитьВфайл_Click);
            // 
            // ОбщаяСуммаОставшихсяТоваров
            // 
            this.ОбщаяСуммаОставшихсяТоваров.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОбщаяСуммаОставшихсяТоваров.AutoSize = true;
            this.ОбщаяСуммаОставшихсяТоваров.Location = new System.Drawing.Point(404, 7);
            this.ОбщаяСуммаОставшихсяТоваров.Name = "ОбщаяСуммаОставшихсяТоваров";
            this.ОбщаяСуммаОставшихсяТоваров.Size = new System.Drawing.Size(122, 13);
            this.ОбщаяСуммаОставшихсяТоваров.TabIndex = 50;
            this.ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров";
            // 
            // ОчиститьАртикул
            // 
            this.ОчиститьАртикул.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьАртикул.Location = new System.Drawing.Point(338, 64);
            this.ОчиститьАртикул.Name = "ОчиститьАртикул";
            this.ОчиститьАртикул.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьАртикул.TabIndex = 49;
            this.ОчиститьАртикул.Text = "-";
            this.ОчиститьАртикул.UseVisualStyleBackColor = true;
            this.ОчиститьАртикул.Click += new System.EventHandler(this.ОчиститьАртикул_Click);
            // 
            // ОчиститьПлатформа
            // 
            this.ОчиститьПлатформа.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьПлатформа.Location = new System.Drawing.Point(359, 39);
            this.ОчиститьПлатформа.Name = "ОчиститьПлатформа";
            this.ОчиститьПлатформа.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьПлатформа.TabIndex = 48;
            this.ОчиститьПлатформа.Text = "-";
            this.ОчиститьПлатформа.UseVisualStyleBackColor = true;
            this.ОчиститьПлатформа.Click += new System.EventHandler(this.ОчиститьПлатформа_Click);
            // 
            // ОчиститьКатегория
            // 
            this.ОчиститьКатегория.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьКатегория.Location = new System.Drawing.Point(359, 7);
            this.ОчиститьКатегория.Name = "ОчиститьКатегория";
            this.ОчиститьКатегория.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьКатегория.TabIndex = 47;
            this.ОчиститьКатегория.Text = "-";
            this.ОчиститьКатегория.UseVisualStyleBackColor = true;
            this.ОчиститьКатегория.Click += new System.EventHandler(this.ОчиститьКатегория_Click);
            // 
            // label7
            // 
            this.label7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(169, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Артикул";
            // 
            // АртикулТекстБокс
            // 
            this.АртикулТекстБокс.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.АртикулТекстБокс.Location = new System.Drawing.Point(232, 66);
            this.АртикулТекстБокс.Name = "АртикулТекстБокс";
            this.АртикулТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.АртикулТекстБокс.TabIndex = 45;
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
            this.ПлатформаКомбоБокс.Location = new System.Drawing.Point(232, 39);
            this.ПлатформаКомбоБокс.Name = "ПлатформаКомбоБокс";
            this.ПлатформаКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.ПлатформаКомбоБокс.TabIndex = 44;
            this.ПлатформаКомбоБокс.SelectionChangeCommitted += new System.EventHandler(this.ПлатформаКомбоБокс_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(166, 42);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 43;
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
            this.КатегорияКомбоБокс.Location = new System.Drawing.Point(232, 9);
            this.КатегорияКомбоБокс.Name = "КатегорияКомбоБокс";
            this.КатегорияКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.КатегорияКомбоБокс.TabIndex = 42;
            this.КатегорияКомбоБокс.SelectionChangeCommitted += new System.EventHandler(this.КатегорияКомбоБокс_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(166, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Категория";
            // 
            // ОчиститьСклад
            // 
            this.ОчиститьСклад.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ОчиститьСклад.Location = new System.Drawing.Point(132, 61);
            this.ОчиститьСклад.Name = "ОчиститьСклад";
            this.ОчиститьСклад.Size = new System.Drawing.Size(24, 23);
            this.ОчиститьСклад.TabIndex = 40;
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
            this.СкладКомбоБокс.Location = new System.Drawing.Point(5, 61);
            this.СкладКомбоБокс.Name = "СкладКомбоБокс";
            this.СкладКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.СкладКомбоБокс.TabIndex = 39;
            this.СкладКомбоБокс.SelectionChangeCommitted += new System.EventHandler(this.СкладКомбоБокс_SelectionChangeCommitted);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(40, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 38;
            this.label3.Text = "Склад";
            // 
            // Очистить3Лист
            // 
            this.Очистить3Лист.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Очистить3Лист.Location = new System.Drawing.Point(97, 8);
            this.Очистить3Лист.Name = "Очистить3Лист";
            this.Очистить3Лист.Size = new System.Drawing.Size(29, 23);
            this.Очистить3Лист.TabIndex = 4;
            this.Очистить3Лист.Text = "-";
            this.Очистить3Лист.UseVisualStyleBackColor = true;
            this.Очистить3Лист.Click += new System.EventHandler(this.Очистить3Лист_Click);
            // 
            // Обновить3Лист
            // 
            this.Обновить3Лист.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Обновить3Лист.Location = new System.Drawing.Point(6, 8);
            this.Обновить3Лист.Name = "Обновить3Лист";
            this.Обновить3Лист.Size = new System.Drawing.Size(75, 23);
            this.Обновить3Лист.TabIndex = 3;
            this.Обновить3Лист.Text = "Остаток";
            this.Обновить3Лист.UseVisualStyleBackColor = true;
            this.Обновить3Лист.Click += new System.EventHandler(this.Обновить3Лист_Click);
            // 
            // ЛистОстатка
            // 
            this.ЛистОстатка.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19});
            this.ЛистОстатка.FullRowSelect = true;
            this.ЛистОстатка.GridLines = true;
            this.ЛистОстатка.Location = new System.Drawing.Point(3, 103);
            this.ЛистОстатка.Name = "ЛистОстатка";
            this.ЛистОстатка.Size = new System.Drawing.Size(689, 270);
            this.ЛистОстатка.TabIndex = 1;
            this.ЛистОстатка.UseCompatibleStateImageBehavior = false;
            this.ЛистОстатка.View = System.Windows.Forms.View.Details;
            this.ЛистОстатка.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.СортировкаКолонн);
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Артикул";
            this.columnHeader13.Width = 92;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Наименование";
            this.columnHeader14.Width = 125;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Категория";
            this.columnHeader15.Width = 117;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Платформа";
            this.columnHeader16.Width = 112;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "Цена";
            this.columnHeader17.Width = 69;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "Количество";
            this.columnHeader18.Width = 78;
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "Склад";
            this.columnHeader19.Width = 86;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Загрузить";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.RestoreDirectory = true;
            this.saveFileDialog1.Title = "Сохранить в";
            // 
            // ОсновнаяФорма
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 405);
            this.Controls.Add(this.Вкладки);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ОсновнаяФорма";
            this.Text = "Складской учет";
            this.Load += new System.EventHandler(this.Загрузка1Формы);
            this.Вкладки.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Вкладки;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.Button ДобавитьНовоеПоступление;
        internal System.Windows.Forms.ListView ЛистПоставки;
        private System.Windows.Forms.Button ОчиститьЛист1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        internal System.Windows.Forms.ListView ЛистПродажи;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button Очистить2Лист;
        private System.Windows.Forms.Button ОформлениеПродажи;
        private System.Windows.Forms.Button Обновить2Лист;
        private System.Windows.Forms.Button Очистить3Лист;
        private System.Windows.Forms.Button Обновить3Лист;
        internal System.Windows.Forms.ListView ЛистОстатка;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.Button ОтчетПоПродажам;
        private System.Windows.Forms.Button ОчиститьСклад;
        private System.Windows.Forms.ComboBox СкладКомбоБокс;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button ОчиститьАртикул;
        private System.Windows.Forms.Button ОчиститьПлатформа;
        private System.Windows.Forms.Button ОчиститьКатегория;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox АртикулТекстБокс;
        private System.Windows.Forms.ComboBox ПлатформаКомбоБокс;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox КатегорияКомбоБокс;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label ОбщаяСуммаОставшихсяТоваров;
        internal System.Windows.Forms.Label ОбщаяСуммаПродажи;
        private System.Windows.Forms.Button ЗагрузитьИзФайла;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button СохранитьВФайл;
        private System.Windows.Forms.Button СоздатьФайл;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.Button ВывестиПоступившиеТовары;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ПоискТекстБокс;
    }
}

