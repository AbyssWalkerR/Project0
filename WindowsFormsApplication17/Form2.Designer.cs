namespace WindowsFormsApplication17
{
    partial class ФормаПоступления
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ДатаТекстБокс = new System.Windows.Forms.TextBox();
            this.ПоставщикКомбоБокс = new System.Windows.Forms.ComboBox();
            this.МестоПоставкКомбоБокс = new System.Windows.Forms.ComboBox();
            this.Календарь = new System.Windows.Forms.MonthCalendar();
            this.label5 = new System.Windows.Forms.Label();
            this.ЦенаТекстБокс = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ОформлениеПоступления = new System.Windows.Forms.Button();
            this.АртикулТекстБокс = new System.Windows.Forms.TextBox();
            this.НаименованиеТекстБокс = new System.Windows.Forms.TextBox();
            this.КоличествоТекстБокс = new System.Windows.Forms.TextBox();
            this.ПлатформаКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.КатегорияКомбоБокс = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Дата";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Поставщик";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 94);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Место поставки";
            // 
            // ДатаТекстБокс
            // 
            this.ДатаТекстБокс.Location = new System.Drawing.Point(264, 13);
            this.ДатаТекстБокс.Name = "ДатаТекстБокс";
            this.ДатаТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.ДатаТекстБокс.TabIndex = 5;
            this.ДатаТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ДатаТекстБокс_KeyPress);
            // 
            // ПоставщикКомбоБокс
            // 
            this.ПоставщикКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ПоставщикКомбоБокс.FormattingEnabled = true;
            this.ПоставщикКомбоБокс.Items.AddRange(new object[] {
            "БУКА",
            "СофтКлаб",
            "Кудос",
            "Centrum Games"});
            this.ПоставщикКомбоБокс.Location = new System.Drawing.Point(101, 64);
            this.ПоставщикКомбоБокс.Name = "ПоставщикКомбоБокс";
            this.ПоставщикКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.ПоставщикКомбоБокс.TabIndex = 6;
            // 
            // МестоПоставкКомбоБокс
            // 
            this.МестоПоставкКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.МестоПоставкКомбоБокс.FormattingEnabled = true;
            this.МестоПоставкКомбоБокс.Items.AddRange(new object[] {
            "Основной склад",
            "Дополнительный склад"});
            this.МестоПоставкКомбоБокс.Location = new System.Drawing.Point(101, 91);
            this.МестоПоставкКомбоБокс.Name = "МестоПоставкКомбоБокс";
            this.МестоПоставкКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.МестоПоставкКомбоБокс.TabIndex = 7;
            // 
            // Календарь
            // 
            this.Календарь.Location = new System.Drawing.Point(228, 35);
            this.Календарь.Name = "Календарь";
            this.Календарь.TabIndex = 8;
            this.Календарь.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.Календарь1_DateChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(162, 284);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Цена";
            // 
            // ЦенаТекстБокс
            // 
            this.ЦенаТекстБокс.Location = new System.Drawing.Point(201, 280);
            this.ЦенаТекстБокс.Name = "ЦенаТекстБокс";
            this.ЦенаТекстБокс.Size = new System.Drawing.Size(60, 20);
            this.ЦенаТекстБокс.TabIndex = 10;
            this.ЦенаТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ЦенаТекстБокс_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Календарь);
            this.groupBox1.Controls.Add(this.ДатаТекстБокс);
            this.groupBox1.Controls.Add(this.МестоПоставкКомбоБокс);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ПоставщикКомбоБокс);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(446, 210);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Поступление товара";
            // 
            // ОформлениеПоступления
            // 
            this.ОформлениеПоступления.Location = new System.Drawing.Point(201, 387);
            this.ОформлениеПоступления.Name = "ОформлениеПоступления";
            this.ОформлениеПоступления.Size = new System.Drawing.Size(166, 23);
            this.ОформлениеПоступления.TabIndex = 12;
            this.ОформлениеПоступления.Text = "Оформление поступления";
            this.ОформлениеПоступления.UseVisualStyleBackColor = true;
            this.ОформлениеПоступления.Click += new System.EventHandler(this.ОформлениеПоступления_Click);
            // 
            // АртикулТекстБокс
            // 
            this.АртикулТекстБокс.Location = new System.Drawing.Point(66, 230);
            this.АртикулТекстБокс.Name = "АртикулТекстБокс";
            this.АртикулТекстБокс.Size = new System.Drawing.Size(100, 20);
            this.АртикулТекстБокс.TabIndex = 13;
            this.АртикулТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.АртикулТекстБокс_KeyPress);
            // 
            // НаименованиеТекстБокс
            // 
            this.НаименованиеТекстБокс.Location = new System.Drawing.Point(267, 230);
            this.НаименованиеТекстБокс.Name = "НаименованиеТекстБокс";
            this.НаименованиеТекстБокс.Size = new System.Drawing.Size(151, 20);
            this.НаименованиеТекстБокс.TabIndex = 14;
            // 
            // КоличествоТекстБокс
            // 
            this.КоличествоТекстБокс.Location = new System.Drawing.Point(84, 280);
            this.КоличествоТекстБокс.Name = "КоличествоТекстБокс";
            this.КоличествоТекстБокс.Size = new System.Drawing.Size(51, 20);
            this.КоличествоТекстБокс.TabIndex = 15;
            this.КоличествоТекстБокс.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.КоличествоТекстБокс_KeyPress);
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
            this.ПлатформаКомбоБокс.Location = new System.Drawing.Point(288, 329);
            this.ПлатформаКомбоБокс.Name = "ПлатформаКомбоБокс";
            this.ПлатформаКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.ПлатформаКомбоБокс.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 233);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Артикул";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 233);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Наименование";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 284);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 19;
            this.label8.Text = "Количество";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(216, 332);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 13);
            this.label9.TabIndex = 20;
            this.label9.Text = "Платформа";
            // 
            // КатегорияКомбоБокс
            // 
            this.КатегорияКомбоБокс.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.КатегорияКомбоБокс.FormattingEnabled = true;
            this.КатегорияКомбоБокс.Items.AddRange(new object[] {
            "Аксессуары",
            "Консоли",
            "Игры"});
            this.КатегорияКомбоБокс.Location = new System.Drawing.Point(84, 329);
            this.КатегорияКомбоБокс.Name = "КатегорияКомбоБокс";
            this.КатегорияКомбоБокс.Size = new System.Drawing.Size(121, 21);
            this.КатегорияКомбоБокс.TabIndex = 21;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(12, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Категория";
            // 
            // ФормаПоступления
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 434);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.КатегорияКомбоБокс);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ПлатформаКомбоБокс);
            this.Controls.Add(this.КоличествоТекстБокс);
            this.Controls.Add(this.НаименованиеТекстБокс);
            this.Controls.Add(this.АртикулТекстБокс);
            this.Controls.Add(this.ОформлениеПоступления);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ЦенаТекстБокс);
            this.Controls.Add(this.label5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ФормаПоступления";
            this.Text = "Поступление";
            this.Load += new System.EventHandler(this.ФормаПоступления_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ДатаТекстБокс;
        private System.Windows.Forms.ComboBox ПоставщикКомбоБокс;
        private System.Windows.Forms.ComboBox МестоПоставкКомбоБокс;
        private System.Windows.Forms.MonthCalendar Календарь;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ЦенаТекстБокс;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button ОформлениеПоступления;
        private System.Windows.Forms.TextBox АртикулТекстБокс;
        private System.Windows.Forms.TextBox НаименованиеТекстБокс;
        private System.Windows.Forms.TextBox КоличествоТекстБокс;
        private System.Windows.Forms.ComboBox ПлатформаКомбоБокс;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox КатегорияКомбоБокс;
        private System.Windows.Forms.Label label10;
    }
}