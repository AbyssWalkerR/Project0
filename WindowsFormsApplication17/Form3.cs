using System;
using System.Collections;
using System.Windows.Forms;
using static WindowsFormsApplication17.ОсновнаяФорма;

namespace WindowsFormsApplication17
{
    public partial class ФормаПродажи : Form
    {
        public ФормаПродажи()
        {
            InitializeComponent();
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

        void СортировкаКолонны(object sender, ColumnClickEventArgs e)
        {
            if (sender.Equals(ЛистТоваровНаПродажу))
            {
                if ((e.Column.ToString() == "0") || (e.Column.ToString() == "4") || (e.Column.ToString() == "5"))
                {
                    itemComparerInt.ColumnIndex = e.Column;
                    ЛистТоваровНаПродажу.ListViewItemSorter = itemComparerInt;
                    ((ListView)sender).Sort();
                }
                else
                {


                    { 
                        itemComparerString.ColumnIndex = e.Column;
                        ЛистТоваровНаПродажу.ListViewItemSorter = itemComparerString;
                        ((ListView)sender).Sort();
                    }
                }
            }
        }



        private void Загрузка3Формы(object sender, EventArgs e)
        {
            MaximizeBox = false;
            foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
            {



                ListViewItem a = new ListViewItem();
                a.Text = v.Articul.ToString();

                a.SubItems.Add(v.Naimen.ToString());
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                ЛистТоваровНаПродажу.Items.Add(a);
            }



        }



        private void СкладКомбоБокс_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (СкладКомбоБокс.SelectedItem != null)
            {

                switch (СкладКомбоБокс.SelectedItem.ToString())
                {
                    case "Основной склад":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Place.ToString() == "Основной склад")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "Дополнительный склад":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Place.ToString() == "Дополнительный склад")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                }

            }
        }

        private void ОчиститьСклад_Click(object sender, EventArgs e)
        {
            ЛистТоваровНаПродажу.Items.Clear();
            СкладКомбоБокс.Text = null;
            foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Articul.ToString();

                a.SubItems.Add(v.Naimen.ToString());
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                ЛистТоваровНаПродажу.Items.Add(a);

            }
        }

        private void КатегорияКомбоБокс_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (КатегорияКомбоБокс.SelectedItem != null)
            {

                switch (КатегорияКомбоБокс.SelectedItem.ToString())
                {
                    case "Аксессуары":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Kategoria.ToString() == "Аксессуары")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "Консоли":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Kategoria.ToString() == "Консоли")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "Игры":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Kategoria.ToString() == "Игры")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                }

            }
        }

        private void ОчиститьКатегорию_Click(object sender, EventArgs e)
        {
            ЛистТоваровНаПродажу.Items.Clear();
            КатегорияКомбоБокс.Text = null;
            foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Articul.ToString();

                a.SubItems.Add(v.Naimen.ToString());
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                ЛистТоваровНаПродажу.Items.Add(a);

            }
        }

        private void ОчиститьПлатформу_Click(object sender, EventArgs e)
        {
            ЛистТоваровНаПродажу.Items.Clear();
            ПлатформаКомбоБокс.Text = null;
            foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Articul.ToString();

                a.SubItems.Add(v.Naimen.ToString());
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                ЛистТоваровНаПродажу.Items.Add(a);

            }
        }

        private void ОчиститьАртикул_Click(object sender, EventArgs e)
        {
            ЛистТоваровНаПродажу.Items.Clear();
            АртикулТекстБокс.Text = null;
            foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Articul.ToString();

                a.SubItems.Add(v.Naimen.ToString());
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                ЛистТоваровНаПродажу.Items.Add(a);

            }
        }

        private void ПлатформаКомбоБокс_SelectionChangeCommitted(object sender, EventArgs e)
        {
            if (ПлатформаКомбоБокс.SelectedItem != null)
            {

                switch (ПлатформаКомбоБокс.SelectedItem.ToString())
                {
                    case "Nintendo Switch":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "Nintendo Switch")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "Nintendo 3DS":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "Nintendo 3DS")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "Xbox One":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "Xbox One")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "Xbox 360":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "Xbox 360")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "PlayStation 4":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "PlayStation 4")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "PlayStation 3":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "PlayStation 3")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "PlayStation 2":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "PlayStation 2")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "PSP":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "PSP")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "PS Vita":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "PS Vita")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;

                    case "PC":
                        ЛистТоваровНаПродажу.Items.Clear();
                        foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                        {
                            if (v.Platforma.ToString() == "PC")
                            {
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Articul.ToString();

                                a.SubItems.Add(v.Naimen.ToString());
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                ЛистТоваровНаПродажу.Items.Add(a);
                            }
                        }
                        break;



                }

            }
        }

        private void АртикулТекстБокс_TextChanged(object sender, EventArgs e)
        {
            if (АртикулТекстБокс.Text != null)
            {
                ЛистТоваровНаПродажу.Items.Clear();
                foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                {
                    if (v.Articul.ToString().IndexOf(АртикулТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        ListViewItem a = new ListViewItem();
                        a.Text = v.Articul.ToString();

                        a.SubItems.Add(v.Naimen.ToString());
                        a.SubItems.Add(v.Kategoria);
                        a.SubItems.Add(v.Platforma);
                        a.SubItems.Add(v.Kolvo.ToString());
                        a.SubItems.Add(v.Price.ToString());
                        ЛистТоваровНаПродажу.Items.Add(a);
                    }
                }

            }
        }

        private void Оформитьпродажу_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(КоличествоТекстБокс.Text) || string.IsNullOrWhiteSpace(АртикулТекстБокс.Text) || (Формаоплатыкомбобокс.SelectedItem == null)  || string.IsNullOrWhiteSpace(ДатаТекстБокс.Text))
            {
                MessageBox.Show("Укажите количество, артикул товара,способ оплаты, номер и дату продажи", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {

                foreach (Postup1 v in ОсновнаяФорма._Form1.postup1)
                {
                    if ((v.Articul.ToString() == АртикулТекстБокс.Text.ToString()) && (v.Kolvo - Int32.Parse(КоличествоТекстБокс.Text) == 0))
                    {
                        ОсновнаяФорма._Form1.prodaja.Add(new Prodaja());

                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Date = ДатаТекстБокс.Text;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Number = _Form1.r;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Articul = Int32.Parse(АртикулТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Naimen = v.Naimen;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Kategoria = v.Kategoria;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Platforma = v.Platforma;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Postavka = v.Postavka;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Oplata = Формаоплатыкомбобокс.Text;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Kolvo = Int32.Parse(КоличествоТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Price = v.Price * v.Kolvo;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Place = v.Place;

                        foreach (Prodaja p in ОсновнаяФорма._Form1.prodaja)
                        {



                            ListViewItem a = new ListViewItem();
                            a.Text = p.Date.ToString();

                            a.SubItems.Add(p.Number.ToString());
                            a.SubItems.Add(p.Naimen.ToString());
                            a.SubItems.Add(p.Oplata);
                            a.SubItems.Add(p.Price.ToString());
                            a.SubItems.Add(p.Place);
                            ОсновнаяФорма._Form1.ЛистПродажи.Items.Add(a);
                        }


                        ОсновнаяФорма._Form1.prodaja1.Add(new Prodaja1());
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Date = ДатаТекстБокс.Text;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Number = _Form1.r;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Articul = Int32.Parse(АртикулТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Naimen = v.Naimen;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Kategoria = v.Kategoria;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Platforma = v.Platforma;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Postavka = v.Postavka;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Oplata = Формаоплатыкомбобокс.Text;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Kolvo = Int32.Parse(КоличествоТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Price = v.Price;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Place = v.Place;

                        ОсновнаяФорма._Form1.postup1.Remove(v);
                        ОсновнаяФорма._Form1.k += v.Price * v.Kolvo;
                        ОсновнаяФорма._Form1.c -= v.Price * v.Kolvo;
                        break;


                    }
                    if ((v.Articul.ToString() == АртикулТекстБокс.Text.ToString()) && (v.Kolvo - Int32.Parse(КоличествоТекстБокс.Text) > 0))
                    {

                        ОсновнаяФорма._Form1.prodaja.Add(new Prodaja());

                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Date = ДатаТекстБокс.Text;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Number = _Form1.r;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Articul = Int32.Parse(АртикулТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Naimen = v.Naimen;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Kategoria = v.Kategoria;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Platforma = v.Platforma;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Postavka = v.Postavka;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Oplata = Формаоплатыкомбобокс.Text;
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Kolvo = Int32.Parse(КоличествоТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Price = v.Price * Int32.Parse(КоличествоТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja[ОсновнаяФорма._Form1.prodaja.Count - 1].Place = v.Place;

                        foreach (Prodaja p in ОсновнаяФорма._Form1.prodaja)
                        {



                            ListViewItem a = new ListViewItem();
                            a.Text = p.Date.ToString();

                            a.SubItems.Add(p.Number.ToString());
                            a.SubItems.Add(p.Naimen.ToString());
                            a.SubItems.Add(p.Oplata);
                            a.SubItems.Add(p.Price.ToString());
                            a.SubItems.Add(p.Place);
                            ОсновнаяФорма._Form1.ЛистПродажи.Items.Add(a);
                        }




                        ОсновнаяФорма._Form1.prodaja1.Add(new Prodaja1());
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Date = ДатаТекстБокс.Text;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Number = _Form1.r;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Articul = Int32.Parse(АртикулТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Naimen = v.Naimen;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Kategoria = v.Kategoria;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Platforma = v.Platforma;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Postavka = v.Postavka;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Oplata = Формаоплатыкомбобокс.Text;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Kolvo = Int32.Parse(КоличествоТекстБокс.Text);
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Price = v.Price;
                        ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Place = v.Place;

                        v.Kolvo =v.Kolvo - Int32.Parse(КоличествоТекстБокс.Text);
                        ОсновнаяФорма._Form1.k += v.Price * Int32.Parse(КоличествоТекстБокс.Text);
                        ОсновнаяФорма._Form1.c -= v.Price * Int32.Parse(КоличествоТекстБокс.Text);
                        break;


                    }
                    if ((v.Articul.ToString() == АртикулТекстБокс.Text.ToString()) && (v.Kolvo - Int32.Parse(КоличествоТекстБокс.Text)<0 ))
                    {

                        MessageBox.Show("На складе нет такого количества", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
                        break;
                    }
                }
                _Form1.ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + _Form1.k.ToString();
                ЛистТоваровНаПродажу.Items.Clear();                
                ФормаПродажи.ActiveForm.Close();
            }
        }

        

        private void ДатаТекстБокс_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
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

        private void КоличествоТекстБокс_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void Календарь2_DateChanged(object sender, DateRangeEventArgs e)
        {
            ДатаТекстБокс.Text = Календарь.SelectionRange.Start.ToShortDateString();
        }
    }
}
