using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;


namespace WindowsFormsApplication17
{
    internal partial class ОсновнаяФорма : Form
    {
        internal ОсновнаяФорма()
        {
            InitializeComponent();
            _Form1 = this;
        }              
        ItemComparerString itemComparerString = new ItemComparerString();
        ItemComparerInt itemComparerInt = new ItemComparerInt();
        ItemComparerDate itemComparerDate = new ItemComparerDate();

        class ItemComparerString : IComparer
        {
            int columnIndex = 0;
            bool sortAscending = true;

            public int ColumnIndex
            {
                set
                {

                    if (columnIndex == value)

                        sortAscending = !sortAscending;
                    else
                    {
                        columnIndex = value;
                        sortAscending = true;
                    }
                }
            }

            public int Compare(object x, object y)
            {
                string value1 = ((ListViewItem)x).SubItems[columnIndex].Text;

                string value2 = ((ListViewItem)y).SubItems[columnIndex].Text;
                return String.Compare(value1, value2) * (sortAscending ? 1 : -1);
            }
        }

        class ItemComparerInt : IComparer
        {
            int columnIndex = 0;
            bool sortAscending = true;

            public int ColumnIndex
            {
                set
                {

                    if (columnIndex == value)

                        sortAscending = !sortAscending;
                    else
                    {

                        columnIndex = value;
                        sortAscending = true;
                    }
                }
            }

            public int Compare(object x, object y)
            {
                int retuuuurn = 0;

                string value1 = ((ListViewItem)x).SubItems[columnIndex].Text;

                int IntValue1 = Convert.ToInt32(value1);
                string value2 = ((ListViewItem)y).SubItems[columnIndex].Text;
                int IntValue2 = Convert.ToInt32(value2);

                if (IntValue1 > IntValue2)
                {
                    retuuuurn = -1;
                }
                if (IntValue1 == IntValue2)
                {
                    retuuuurn = 0;
                }
                if (IntValue1 < IntValue2)
                {
                    retuuuurn = 1;
                }

                return retuuuurn * (sortAscending ? 1 : -1);
            }
        }

        class ItemComparerDate : IComparer
        {
            int columnIndex = 0;
            bool sortAscending = true;

            public int ColumnIndex
            {
                set
                {

                    if (columnIndex == value)

                        sortAscending = !sortAscending;
                    else
                    {

                        columnIndex = value;
                        sortAscending = true;
                    }
                }
            }

            public int Compare(object x, object y)
            {
                int retuuuurn = 0;
                DateTime c1 = new DateTime();
                DateTime c2 = new DateTime();

                string value1 = ((ListViewItem)x).SubItems[columnIndex].Text;

                c1 = Convert.ToDateTime(value1);

                string value2 = ((ListViewItem)y).SubItems[columnIndex].Text;
                c2 = Convert.ToDateTime(value2);

                if (c1 > c2)
                {
                    retuuuurn = -1;
                }
                if (c1 == c2)
                {
                    retuuuurn = 0;
                }
                if (c1 < c2)
                {
                    retuuuurn = 1;
                }

                return retuuuurn * (sortAscending ? 1 : -1);
            }
        }

        void СортировкаКолонн(object sender, ColumnClickEventArgs e)
        {
            if (sender.Equals(ЛистПоставки))
            {
                if ((e.Column.ToString() == "4") || (e.Column.ToString() == "1"))
                {
                    itemComparerInt.ColumnIndex = e.Column;
                    ЛистПоставки.ListViewItemSorter = itemComparerInt;
                    ((ListView)sender).Sort();
                }
                else
                {
                    if (e.Column.ToString() == "0")
                    {
                        itemComparerDate.ColumnIndex = e.Column;
                        ЛистПоставки.ListViewItemSorter = itemComparerDate;
                        ((ListView)sender).Sort();
                    }
                    else
                    {
                        itemComparerString.ColumnIndex = e.Column;
                        ЛистПоставки.ListViewItemSorter = itemComparerString;
                        ((ListView)sender).Sort();
                    }
                }

            }
            if (sender.Equals(ЛистПродажи))
            {
                if ((e.Column.ToString() == "4")|| (e.Column.ToString() == "1"))
                {
                    itemComparerInt.ColumnIndex = e.Column;
                    ЛистПродажи.ListViewItemSorter = itemComparerInt;
                    ((ListView)sender).Sort();
                }
                else
                {
                    if (e.Column.ToString() == "0")
                    {
                        itemComparerDate.ColumnIndex = e.Column;
                        ЛистПродажи.ListViewItemSorter = itemComparerDate;
                        ((ListView)sender).Sort();
                    }
                    else
                    {
                        itemComparerString.ColumnIndex = e.Column;
                        ЛистПродажи.ListViewItemSorter = itemComparerString;

                        ((ListView)sender).Sort();
                    }
                }
            }
            if (sender.Equals(ЛистОстатка))
            {
                
                    if ((e.Column.ToString() == "0") || (e.Column.ToString() == "4") || (e.Column.ToString() == "5"))
                    {
                        itemComparerInt.ColumnIndex = e.Column;
                        ЛистОстатка.ListViewItemSorter = itemComparerInt;
                        ((ListView)sender).Sort();
                    }
                    else
                    {
                        
                            itemComparerString.ColumnIndex = e.Column;
                            ЛистОстатка.ListViewItemSorter = itemComparerString;
                            ((ListView)sender).Sort();                        
                    }                
            }
        }
        internal class Postup
            {
                public string Date;
                public int Number;
                public string Naimen;
                public string Postavka;
                public int Price;
                public string Place;
            }
        

            internal class Postup1
            {
                public string Date;
                public int Number;
                public int Articul;
                public string Naimen;
                public string Kategoria;
                public string Platforma;
                public string Postavka;
                public int Kolvo;
                public int Price;
                public string Place;

                internal void Write(BinaryWriter sk)
                {
                    sk.Write(Date);
                    sk.Write(Number);
                    sk.Write(Articul);
                    sk.Write(Naimen);
                    sk.Write(Kategoria);
                    sk.Write(Platforma);
                    sk.Write(Postavka);
                    sk.Write(Kolvo);
                    sk.Write(Price);
                    sk.Write(Place);
                }


                internal void Read(BinaryReader red)
                {
                    Date = red.ReadString();
                    Number = red.ReadInt32();
                    Articul = red.ReadInt32();
                    Naimen = red.ReadString();
                    Kategoria = red.ReadString();
                    Platforma = red.ReadString();
                    Postavka = red.ReadString();
                    Kolvo = red.ReadInt32();
                    Price = red.ReadInt32();
                    Place = red.ReadString();
                }
            }

            internal class Prodaja
            {
                public string Date;
                public int Number;
                public int Articul;
                public string Naimen;
                public string Kategoria;
                public string Platforma;
                public string Postavka;
                public string Oplata;
                public int Kolvo;
                public int Price;
                public string Place;
            }
            internal class Prodaja1
            {
                public string Date;
                public int Number;
                public int Articul;
                public string Naimen;
                public string Kategoria;
                public string Platforma;
                public string Postavka;
                public string Oplata;
                public int Kolvo;
                public int Price;
                public string Place;


                internal void Writes(BinaryWriter se)
                {
                    se.Write(Date);
                    se.Write(Number);
                    se.Write(Articul);
                    se.Write(Naimen);
                    se.Write(Kategoria);
                    se.Write(Platforma);
                    se.Write(Postavka);
                    se.Write(Oplata);
                    se.Write(Kolvo);
                    se.Write(Price);
                    se.Write(Place);
                }
                internal void Reads(BinaryReader reds)
                {
                    Date = reds.ReadString();
                    Number = reds.ReadInt32();
                    Articul = reds.ReadInt32();
                    Naimen = reds.ReadString();
                    Kategoria = reds.ReadString();
                    Platforma = reds.ReadString();
                    Postavka = reds.ReadString();
                    Oplata = reds.ReadString();
                    Kolvo = reds.ReadInt32();
                    Price = reds.ReadInt32();
                    Place = reds.ReadString();
                }
            }
            internal List<Postup1> postup1 = new List<Postup1>();
            
            internal List<Prodaja> prodaja = new List<Prodaja>();
            internal List<Prodaja1> prodaja1 = new List<Prodaja1>();
            internal List<Postup> postup = new List<Postup>();
            internal static ОсновнаяФорма _Form1;
            internal int c;
            internal int k;
            internal int d = 0;
            int sz = 0;

            private void Загрузка1Формы(object sender, EventArgs e)
            {
            _Form1.MaximizeBox = false;

            ToolTip t = new ToolTip();
                t.SetToolTip(ДобавитьНовоеПоступление, "Оформить новое поступление");
                ToolTip p = new ToolTip();
                p.SetToolTip(ОформлениеПродажи, "Оформить продажу");

            }

        private void ПереключениеВкладки(object sender, EventArgs e)
        {
            if (c < 0)
            {
                c = 0;
            }
            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + c.ToString();
            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + k.ToString();
            ЛистПродажи.Items.Clear();
            foreach (Prodaja1 p in prodaja1)
            {



                ListViewItem a = new ListViewItem();
                a.Text = p.Date.ToString();

                a.SubItems.Add(p.Number.ToString());
                a.SubItems.Add(p.Naimen.ToString());
                a.SubItems.Add(p.Oplata);
                a.SubItems.Add((p.Price).ToString());
                a.SubItems.Add(p.Place);
                ЛистПродажи.Items.Add(a);
            }
            ЛистОстатка.Items.Clear();
            foreach (Postup1 v in postup1)
            {
                ListViewItem a = new ListViewItem();
                a.Text = v.Articul.ToString();

                a.SubItems.Add(v.Naimen.ToString());
                a.SubItems.Add(v.Kategoria.ToString());
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Place);
                ЛистОстатка.Items.Add(a);
            }
            ЛистПоставки.Items.Clear();
            foreach (Postup1 l in postup1)
            {
                ListViewItem a = new ListViewItem();
                a.Text = l.Date.ToString();

                a.SubItems.Add(l.Number.ToString());
                a.SubItems.Add(l.Naimen.ToString());
                a.SubItems.Add(l.Postavka);
                a.SubItems.Add(l.Price.ToString());
                a.SubItems.Add(l.Place);
                ЛистПоставки.Items.Add(a);
            }
        }

            private void ДобавитьНовоеПоступление_Click(object sender, EventArgs e)
            {
            
            d = d + 1;
            ФормаПоступления frm = new ФормаПоступления();
                frm.ShowDialog(this);           
                postup.Clear();
            }

            private void ОчиститьЛист1_Click(object sender, EventArgs e)
            {                
                ЛистПоставки.Items.Clear();                
            }

            private void Обновить3Лист_Click(object sender, EventArgs e)
            {
            ЛистОстатка.Items.Clear();
            foreach (Postup1 v in postup1)
                {
                    ListViewItem a = new ListViewItem();
                    a.Text = v.Articul.ToString();

                    a.SubItems.Add(v.Naimen.ToString());
                    a.SubItems.Add(v.Kategoria.ToString());
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Place);
                    ЛистОстатка.Items.Add(a);
                }
            }
            internal int r = 0;
            private void ОформлениеПродажи_Click(object sender, EventArgs e)
            {
            
            r = r + 1;
            ФормаПродажи frm = new ФормаПродажи();
                frm.ShowDialog(this);
                prodaja.Clear();
            }

            private void Очистить2Лист_Click(object sender, EventArgs e)
            {
                foreach (ListViewItem eachItem in ЛистПродажи.SelectedItems)
                {
                    ЛистПродажи.Items.Remove(eachItem);
                }
            }

            private void Обновить2Лист_Click(object sender, EventArgs e)
            {
            ЛистПродажи.Items.Clear();
            foreach (Prodaja1 p in prodaja1)
                {
                    ListViewItem a = new ListViewItem();
                    a.Text = p.Date.ToString();

                    a.SubItems.Add(p.Number.ToString());
                    a.SubItems.Add(p.Naimen.ToString());
                    a.SubItems.Add(p.Oplata);
                    a.SubItems.Add(p.Price.ToString());
                    a.SubItems.Add(p.Place);
                    ЛистПродажи.Items.Add(a);
                }
            }

            private void Очистить3Лист_Click(object sender, EventArgs e)
            {
                ЛистОстатка.Items.Clear();
            }

            private void ОтчетПоПродажам_Click(object sender, EventArgs e)
            {
                ФормаОтчетаПоПродажам frm = new ФормаОтчетаПоПродажам();
                frm.ShowDialog(this);
            }

            private void СкладКомбоБокс_SelectionChangeCommitted(object sender, EventArgs e)
            {
                if (СкладКомбоБокс.SelectedItem != null)
                {

                    switch (СкладКомбоБокс.SelectedItem.ToString())
                    {
                        case "Основной склад":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Place.ToString() == "Основной склад")
                                {
                                sz += v.Price * v.Kolvo;
                                    ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "Дополнительный склад":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Place.ToString() == "Дополнительный склад")
                                {
                                sz += v.Price * v.Kolvo;
                                    ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;
                    }
                }
            }

            private void ОчиститьСклад_Click(object sender, EventArgs e)
            {
            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + c.ToString();
            ЛистОстатка.Items.Clear();
            СкладКомбоБокс.Text = null;
            sz = 0;
                foreach (Postup1 v in postup1)
                {

                    ListViewItem a = new ListViewItem();
                    a.Text = v.Articul.ToString();

                    a.SubItems.Add(v.Naimen.ToString());
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Place.ToString());
                    ЛистОстатка.Items.Add(a);

                }
            }

            private void КатегорияКомбоБокс_SelectionChangeCommitted(object sender, EventArgs e)
            {
                if (КатегорияКомбоБокс.SelectedItem != null)
                {

                    switch (КатегорияКомбоБокс.SelectedItem.ToString())
                    {
                        case "Аксессуары":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Kategoria.ToString() == "Аксессуары")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "Консоли":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                        foreach (Postup1 v in postup1)
                            {
                                if (v.Kategoria.ToString() == "Консоли")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "Игры":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                            {
                                if (v.Kategoria.ToString() == "Игры")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());                                    
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;
                    }

                }
            }

            private void ОчиститьКатегория_Click(object sender, EventArgs e)
            {
            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + c.ToString();
            ЛистОстатка.Items.Clear();
            КатегорияКомбоБокс.Text = null;
            sz = 0;
                foreach (Postup1 v in postup1)
                {

                    ListViewItem a = new ListViewItem();
                    a.Text = v.Articul.ToString();

                    a.SubItems.Add(v.Naimen.ToString());
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Place.ToString());
                    ЛистОстатка.Items.Add(a);

                }
            }

            private void ПлатформаКомбоБокс_SelectionChangeCommitted(object sender, EventArgs e)
            {
                if (ПлатформаКомбоБокс.SelectedItem != null)
                {

                    switch (ПлатформаКомбоБокс.SelectedItem.ToString())
                    {
                        case "Nintendo Switch":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "Nintendo Switch")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "Nintendo 3DS":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "Nintendo 3DS")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "Xbox One":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "Xbox One")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "Xbox 360":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "Xbox 360")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "PlayStation 4":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "PlayStation 4")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "PlayStation 3":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "PlayStation 3")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "PlayStation 2":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "PlayStation 2")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "PSP":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "PSP")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "PS Vita":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "PS Vita")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;

                        case "PC":
                            ЛистОстатка.Items.Clear();
                        sz = 0;
                            foreach (Postup1 v in postup1)
                            {
                                if (v.Platforma.ToString() == "PC")
                                {
                                sz += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                    a.Text = v.Articul.ToString();

                                    a.SubItems.Add(v.Naimen.ToString());
                                    a.SubItems.Add(v.Kategoria);
                                    a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Place.ToString());
                                ЛистОстатка.Items.Add(a);
                                }
                            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                        }
                            break;
                    }
                }
            }

            private void ОчиститьПлатформа_Click(object sender, EventArgs e)
            {
            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + c.ToString();
            ЛистОстатка.Items.Clear();
            ПлатформаКомбоБокс.Text = null;
            sz = 0;
                foreach (Postup1 v in postup1)
                {

                    ListViewItem a = new ListViewItem();
                    a.Text = v.Articul.ToString();

                    a.SubItems.Add(v.Naimen.ToString());
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Place.ToString());
                    ЛистОстатка.Items.Add(a);

                }
            }

            private void АртикулТекстБокс_KeyPress(object sender, KeyPressEventArgs e)
            {
                if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    System.Media.SystemSounds.Beep.Play();
                }
            }

        private void АртикулТекстБокс_TextChanged(object sender, EventArgs e)
        {
            
                ЛистОстатка.Items.Clear();
                sz = 0;
                foreach (Postup1 v in postup1)
                {

                    if (v.Articul.ToString().IndexOf(АртикулТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        sz += v.Price * v.Kolvo;
                        ListViewItem a = new ListViewItem();
                        a.Text = v.Articul.ToString();

                        a.SubItems.Add(v.Naimen.ToString());
                        a.SubItems.Add(v.Kategoria);
                        a.SubItems.Add(v.Platforma);
                        a.SubItems.Add(v.Price.ToString());
                        a.SubItems.Add(v.Kolvo.ToString());
                        a.SubItems.Add(v.Place.ToString());
                        ЛистОстатка.Items.Add(a);
                    }
                    ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
                }

            
        }

            private void ОчиститьАртикул_Click(object sender, EventArgs e)
            {
            ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + c.ToString();
            ЛистОстатка.Items.Clear();
            АртикулТекстБокс.Text = null;
                sz = 0;
                foreach (Postup1 v in postup1)
                {

                    ListViewItem a = new ListViewItem();
                    a.Text = v.Articul.ToString();

                    a.SubItems.Add(v.Naimen.ToString());
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Price.ToString());
                    a.SubItems.Add(v.Kolvo.ToString());
                    a.SubItems.Add(v.Place.ToString());
                    ЛистОстатка.Items.Add(a);

                }
            }

            string so;
            bool s = false;
            private void ЗагрузитьИзФайла_Click(object sender, EventArgs e)
            {
                openFileDialog1.InitialDirectory = Application.StartupPath;
                if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
            c = 0;
            d = 0;
            r = 0;
            ЛистПоставки.Items.Clear();
            ЛистОстатка.Items.Clear();
            ЛистПродажи.Items.Clear();
            postup1.Clear();
            prodaja1.Clear();
                s = true;
            int W, E;
                so = openFileDialog1.FileName;
                using (BinaryReader binRead = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.OpenOrCreate)))
                {

                W = binRead.ReadInt32();
                E = binRead.ReadInt32();
                    for (int i = 0; i < W; i++)
                    {
                        postup1.Add(new Postup1());

                        postup1[postup1.Count - 1].Read(binRead);
                    }
                    for (int i = 0; i < E; i++)
                    {
                        prodaja1.Add(new Prodaja1());

                        prodaja1[prodaja1.Count - 1].Reads(binRead);
                    }

                
                    binRead.Close();

                    foreach (Postup1 v in postup1)
                    {
                    if (v.Number>postup1.Count)
                    {
                        d = v.Number;
                    }
                    else { d = postup1.Count; }
                    ListViewItem a = new ListViewItem();
                        a.Text = v.Date.ToString();

                        a.SubItems.Add(v.Number.ToString());
                        a.SubItems.Add(v.Naimen.ToString());
                        a.SubItems.Add(v.Postavka);
                        a.SubItems.Add((v.Price*v.Kolvo).ToString());
                        a.SubItems.Add(v.Place);
                        ЛистПоставки.Items.Add(a);

                    ListViewItem b = new ListViewItem();
                    b.Text = v.Articul.ToString();

                    b.SubItems.Add(v.Naimen.ToString());
                    b.SubItems.Add(v.Kategoria.ToString());
                    b.SubItems.Add(v.Platforma);
                    b.SubItems.Add(v.Price.ToString());
                    b.SubItems.Add(v.Kolvo.ToString());
                    b.SubItems.Add(v.Place);
                    ЛистОстатка.Items.Add(b);
                    c += v.Price * v.Kolvo;
                }
                foreach (Prodaja1 p in prodaja1)
                {
                    if (p.Number > prodaja1.Count)
                    {
                        r = p.Number;
                    }
                    else { r = prodaja1.Count; }
                    
                    ListViewItem a = new ListViewItem();
                    a.Text = p.Date.ToString();

                    a.SubItems.Add(p.Number.ToString());
                    a.SubItems.Add(p.Articul.ToString());
                    a.SubItems.Add(p.Naimen.ToString());
                    a.SubItems.Add(p.Kategoria);
                    a.SubItems.Add(p.Platforma);
                    a.SubItems.Add(p.Postavka);
                    a.SubItems.Add(p.Oplata);
                    a.SubItems.Add(p.Kolvo.ToString());
                    a.SubItems.Add(p.Price.ToString());
                    a.SubItems.Add(p.Place);
                    ЛистПродажи.Items.Add(a);
                    k += p.Kolvo * p.Price;


                }
            }
            }

            private void СохранитьВфайл_Click(object sender, EventArgs e)
            {
                if (s == false)
                    MessageBox.Show("Создайте поток.");

                else
                {

                    using (BinaryWriter binWrite = new BinaryWriter(File.Open(so, FileMode.Create)))
                    {
                    int CountW = postup1.Count;
                    int CountE = prodaja1.Count;
                    binWrite.Write(CountW);
                    binWrite.Write(CountE);
                        foreach (Postup1 c in postup1)
                        {
                            c.Write(binWrite);
                        }                    
                    foreach (Prodaja1 y in prodaja1)
                    {
                        y.Writes(binWrite);
                    }                    
                }
                }
            }

            private void СоздатьФайл_Click(object sender, EventArgs e)
            {
                saveFileDialog1.InitialDirectory = Application.StartupPath;
                if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                    return;
                s = true;
                so = saveFileDialog1.FileName;

                FileStream fs = new FileStream(saveFileDialog1.FileName, FileMode.CreateNew, FileAccess.ReadWrite);
                fs.Close();
            }
        private void ВывестиПоступившиеТовары_Click(object sender, EventArgs e)
        {
            ЛистПоставки.Items.Clear();
            foreach (Postup1 v in postup1)
            {
                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Naimen.ToString());
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add((v.Price * v.Kolvo).ToString());
                a.SubItems.Add(v.Place);
                ЛистПоставки.Items.Add(a);
            }
            }

        private void ПоискТекстБокс_TextChanged(object sender, EventArgs e)
        {
            ЛистОстатка.Items.Clear();
            sz = 0;
            foreach (Postup1 v in postup1)
            {

                if ((v.Articul.ToString().IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Naimen.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Kategoria.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Platforma.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Kolvo.ToString().IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Price.ToString().IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Place.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    sz += v.Price * v.Kolvo;
                    ListViewItem a = new ListViewItem();
                    a.Text = v.Articul.ToString();

                    a.SubItems.Add(v.Naimen.ToString());
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Price.ToString());
                    a.SubItems.Add(v.Kolvo.ToString());
                    a.SubItems.Add(v.Place.ToString());
                    ЛистОстатка.Items.Add(a);
                }
                ОбщаяСуммаОставшихсяТоваров.Text = "Общая сумма товаров: " + sz.ToString();
            }
        }
    }
}


