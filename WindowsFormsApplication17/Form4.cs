using System;
using System.Collections;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using static WindowsFormsApplication17.ОсновнаяФорма;

namespace WindowsFormsApplication17
{
    public partial class ФормаОтчетаПоПродажам : Form
    {
        public ФормаОтчетаПоПродажам()
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
            if (sender.Equals(ЛистПроданныхТоваров))
            {
                if ((e.Column.ToString() == "1") || (e.Column.ToString() == "2") || (e.Column.ToString() == "8") || (e.Column.ToString() == "9"))
                {
                    itemComparerInt.ColumnIndex = e.Column;
                    ЛистПроданныхТоваров.ListViewItemSorter = itemComparerInt;
                    ((ListView)sender).Sort();
                }
                else
                {
                    if (e.Column.ToString() == "0")
                    {
                        itemComparerDate.ColumnIndex = e.Column;
                        ЛистПроданныхТоваров.ListViewItemSorter = itemComparerDate;
                        ((ListView)sender).Sort();
                    }
                    else
                    {
                        itemComparerString.ColumnIndex = e.Column;
                        ЛистПроданныхТоваров.ListViewItemSorter = itemComparerString;
                        ((ListView)sender).Sort();
                    }
                }
            }
        }
        private void Загрузка4Формы(object sender, EventArgs e)
        {
            MaximizeBox = false;
            foreach (Prodaja1 p in ОсновнаяФорма._Form1.prodaja1)
            {



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
                ЛистПроданныхТоваров.Items.Add(a);
            }

            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();

            
        }
        bool s = false;
        string so;
        private void СохранитьВФайл_Click(object sender, EventArgs e)
        {
            if (s == false)
                MessageBox.Show("Создайте поток.");

            else
            {
                using (BinaryWriter binWrite = new BinaryWriter(File.Open(so, FileMode.Create)))
                {
                    foreach (Prodaja1 c in ОсновнаяФорма._Form1.prodaja1)
                    {
                        c.Writes(binWrite);
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

        private void ОткрытьФайл_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Application.StartupPath;
            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)

                return;
            ОсновнаяФорма._Form1.prodaja1.Clear();
            ЛистПроданныхТоваров.Items.Clear();
            ОсновнаяФорма._Form1.k = 0;
            s = true;

            so = openFileDialog1.FileName;
            using (BinaryReader binRead = new BinaryReader(File.Open(openFileDialog1.FileName, FileMode.OpenOrCreate)))
            {
                while (binRead.PeekChar() > -1)
                {

                    ОсновнаяФорма._Form1.prodaja1.Add(new Prodaja1());

                    ОсновнаяФорма._Form1.prodaja1[ОсновнаяФорма._Form1.prodaja1.Count - 1].Reads(binRead);

                }
                binRead.Close();

                foreach (Prodaja1 p in ОсновнаяФорма._Form1.prodaja1)
                {



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
                    ЛистПроданныхТоваров.Items.Add(a);
                    ОсновнаяФорма._Form1.k += p.Kolvo * p.Price;

                   
                }
                
            }
        }

        int t = 0;
        private void СкладКомбоБокс_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (СкладКомбоБокс.SelectedItem != null)
            {

                switch (СкладКомбоБокс.SelectedItem.ToString())
                {
                    case "Основной склад":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Place.ToString() == "Основной склад")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                                
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Дополнительный склад":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Place.ToString() == "Дополнительный склад")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;
                }
            }
        }

        private void ОчиститьСклад_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            СкладКомбоБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {
                
                    ListViewItem a = new ListViewItem();
                    a.Text = v.Date.ToString();

                    a.SubItems.Add(v.Number.ToString());
                    a.SubItems.Add(v.Articul.ToString());
                    a.SubItems.Add(v.Naimen);
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Postavka);
                    a.SubItems.Add(v.Oplata);
                    a.SubItems.Add(v.Kolvo.ToString());
                    a.SubItems.Add(v.Price.ToString());
                    a.SubItems.Add(v.Place);
                    ЛистПроданныхТоваров.Items.Add(a);
                
            }
        }

        private void НомерТекстБокс_TextChanged(object sender, EventArgs e)
        {
            if (НомерТекстБокс.Text != "")
            {
                ЛистПроданныхТоваров.Items.Clear();
                t = 0;
                foreach (Prodaja1 v in _Form1.prodaja1)
                {

                    if (v.Number.ToString() == НомерТекстБокс.Text.ToString())
                    {
                        t += v.Price * v.Kolvo;
                        ListViewItem a = new ListViewItem();
                        a.Text = v.Date.ToString();

                        a.SubItems.Add(v.Number.ToString());
                        a.SubItems.Add(v.Articul.ToString());
                        a.SubItems.Add(v.Naimen);
                        a.SubItems.Add(v.Kategoria);
                        a.SubItems.Add(v.Platforma);
                        a.SubItems.Add(v.Postavka);
                        a.SubItems.Add(v.Oplata);
                        a.SubItems.Add(v.Kolvo.ToString());
                        a.SubItems.Add(v.Price.ToString());
                        a.SubItems.Add(v.Place);
                        ЛистПроданныхТоваров.Items.Add(a);
                    }
                    ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                }
            }

        }

        private void ОчиститьНомер_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            НомерТекстБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void КатегорияКомбоБокс_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (КатегорияКомбоБокс.SelectedItem != null)
            {

                switch (КатегорияКомбоБокс.SelectedItem.ToString())
                {
                    case "Аксессуары":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Kategoria.ToString() == "Аксессуары")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Консоли":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Kategoria.ToString() == "Консоли")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Игры":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Kategoria.ToString() == "Игры")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;
                }

            }
        }

        private void ОчиститьКатегория_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            КатегорияКомбоБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void ПлатформаКомбоБокс_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ПлатформаКомбоБокс.SelectedItem != null)
            {

                switch (ПлатформаКомбоБокс.SelectedItem.ToString())
                {
                    case "Nintendo Switch":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "Nintendo Switch")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Nintendo 3DS":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "Nintendo 3DS")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Xbox One":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "Xbox One")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Xbox 360":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "Xbox 360")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "PlayStation 4":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "PlayStation 4")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "PlayStation 3":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "PlayStation 3")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "PlayStation 2":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "PlayStation 2")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "PSP":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "PSP")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "PS Vita":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "PS Vita")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "PC":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Platforma.ToString() == "PC")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;
                }
            }
        }

        private void ОчиститьПлатформа_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            ПлатформаКомбоБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void АртикулТекстБокс_TextChanged(object sender, EventArgs e)
        {
            
                ЛистПроданныхТоваров.Items.Clear();
                t = 0;
                foreach (Prodaja1 v in _Form1.prodaja1)
                {
                
                    if (v.Articul.ToString().IndexOf(АртикулТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        t += v.Price * v.Kolvo;
                        ListViewItem a = new ListViewItem();
                        a.Text = v.Date.ToString();

                        a.SubItems.Add(v.Number.ToString());
                        a.SubItems.Add(v.Articul.ToString());
                        a.SubItems.Add(v.Naimen);
                        a.SubItems.Add(v.Kategoria);
                        a.SubItems.Add(v.Platforma);
                        a.SubItems.Add(v.Postavka);
                        a.SubItems.Add(v.Oplata);
                        a.SubItems.Add(v.Kolvo.ToString());
                        a.SubItems.Add(v.Price.ToString());
                        a.SubItems.Add(v.Place);
                        ЛистПроданныхТоваров.Items.Add(a);
                    }
                    ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                }
            
        }

        private void ОчиститьАртикул_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            АртикулТекстБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void ПоставкаКомбоБокс_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ПоставкаКомбоБокс.SelectedItem != null)
            {

                switch (ПоставкаКомбоБокс.SelectedItem.ToString())
                {
                    case "БУКА":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Postavka.ToString() == "БУКА")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "СофтКлаб":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Postavka.ToString() == "СофтКлаб")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Кудос":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Postavka.ToString() == "Кудос")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Centrum Games":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Postavka.ToString() == "Centrum Games")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;
                }

            }
        }

        private void ОчиститьПоставку_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            ПоставкаКомбоБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void ОплатаКомбоБокс_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ОплатаКомбоБокс.SelectedItem != null)
            {

                switch (ОплатаКомбоБокс.SelectedItem.ToString())
                {
                    case "Наличные":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Oplata.ToString() == "Наличные")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;

                    case "Безналичный расчет":
                        ЛистПроданныхТоваров.Items.Clear();
                        t = 0;
                        foreach (Prodaja1 v in _Form1.prodaja1)
                        {
                            if (v.Oplata.ToString() == "Безналичный расчет")
                            {
                                t += v.Price * v.Kolvo;
                                ListViewItem a = new ListViewItem();
                                a.Text = v.Date.ToString();

                                a.SubItems.Add(v.Number.ToString());
                                a.SubItems.Add(v.Articul.ToString());
                                a.SubItems.Add(v.Naimen);
                                a.SubItems.Add(v.Kategoria);
                                a.SubItems.Add(v.Platforma);
                                a.SubItems.Add(v.Postavka);
                                a.SubItems.Add(v.Oplata);
                                a.SubItems.Add(v.Kolvo.ToString());
                                a.SubItems.Add(v.Price.ToString());
                                a.SubItems.Add(v.Place);
                                ЛистПроданныхТоваров.Items.Add(a);
                            }
                            ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                        }
                        break;
                }
            }
        }

        private void ОчиститьОплату_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            ОплатаКомбоБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void КоличествоТекстБокс_TextChanged(object sender, EventArgs e)
        {
            if (КоличествоТекстБокс.Text != "")
            {
                ЛистПроданныхТоваров.Items.Clear();
                t = 0;
                foreach (Prodaja1 v in _Form1.prodaja1)
                {

                    if (v.Kolvo.ToString() == КоличествоТекстБокс.Text.ToString())
                    {
                        t += v.Price * v.Kolvo;
                        ListViewItem a = new ListViewItem();
                        a.Text = v.Date.ToString();

                        a.SubItems.Add(v.Number.ToString());
                        a.SubItems.Add(v.Articul.ToString());
                        a.SubItems.Add(v.Naimen);
                        a.SubItems.Add(v.Kategoria);
                        a.SubItems.Add(v.Platforma);
                        a.SubItems.Add(v.Postavka);
                        a.SubItems.Add(v.Oplata);
                        a.SubItems.Add(v.Kolvo.ToString());
                        a.SubItems.Add(v.Price.ToString());
                        a.SubItems.Add(v.Place);
                        ЛистПроданныхТоваров.Items.Add(a);
                    }
                    ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                }
            }
        }

        private void ОчиститьКоличество_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            КоличествоТекстБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void ЦенаТекстБокс_TextChanged(object sender, EventArgs e)
        {
            
                ЛистПроданныхТоваров.Items.Clear();
                t = 0;
                foreach (Prodaja1 v in _Form1.prodaja1)
                {

                    if (v.Price.ToString().IndexOf(ЦенаТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        t += v.Price * v.Kolvo;
                        ListViewItem a = new ListViewItem();
                        a.Text = v.Date.ToString();

                        a.SubItems.Add(v.Number.ToString());
                        a.SubItems.Add(v.Articul.ToString());
                        a.SubItems.Add(v.Naimen);
                        a.SubItems.Add(v.Kategoria);
                        a.SubItems.Add(v.Platforma);
                        a.SubItems.Add(v.Postavka);
                        a.SubItems.Add(v.Oplata);
                        a.SubItems.Add(v.Kolvo.ToString());
                        a.SubItems.Add(v.Price.ToString());
                        a.SubItems.Add(v.Place);
                        ЛистПроданныхТоваров.Items.Add(a);
                    }
                    ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
                }
            
        }

        private void ОчиститьЦену_Click(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            ЦенаТекстБокс.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

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

        private void ЦенаТекстБокс_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void НомерТекстБокс_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void Календарь_ValueChanged(object sender, EventArgs e)
        {
            ЛистПроданныхТоваров.Items.Clear();
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                if (v.Date.ToString() == Календарь.Text.ToString())
                {
                    t += v.Price * v.Kolvo;
                    ListViewItem a = new ListViewItem();
                    a.Text = v.Date.ToString();

                    a.SubItems.Add(v.Number.ToString());
                    a.SubItems.Add(v.Articul.ToString());
                    a.SubItems.Add(v.Naimen);
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Postavka);
                    a.SubItems.Add(v.Oplata);
                    a.SubItems.Add(v.Kolvo.ToString());
                    a.SubItems.Add(v.Price.ToString());
                    a.SubItems.Add(v.Place);
                    ЛистПроданныхТоваров.Items.Add(a);
                }
                ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
            }
        }

        private void ОчиститьКалендарь_Click_1(object sender, EventArgs e)
        {
            ОбщаяСуммаПродажи.Text = ОсновнаяФорма._Form1.ОбщаяСуммаПродажи.Text.ToString();
            ЛистПроданныхТоваров.Items.Clear();
            Календарь.Text = null;
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                ListViewItem a = new ListViewItem();
                a.Text = v.Date.ToString();

                a.SubItems.Add(v.Number.ToString());
                a.SubItems.Add(v.Articul.ToString());
                a.SubItems.Add(v.Naimen);
                a.SubItems.Add(v.Kategoria);
                a.SubItems.Add(v.Platforma);
                a.SubItems.Add(v.Postavka);
                a.SubItems.Add(v.Oplata);
                a.SubItems.Add(v.Kolvo.ToString());
                a.SubItems.Add(v.Price.ToString());
                a.SubItems.Add(v.Place);
                ЛистПроданныхТоваров.Items.Add(a);

            }
        }

        private void ПоискТекстБокс_TextChanged(object sender, EventArgs e)
        {
            ЛистПроданныхТоваров.Items.Clear();
            t = 0;
            foreach (Prodaja1 v in _Form1.prodaja1)
            {

                if ((v.Articul.ToString().IndexOf(ПоискТекстБокс.Text,StringComparison.OrdinalIgnoreCase)>=0) || (v.Date.ToString().IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Number.ToString().IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Naimen.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Kategoria.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Platforma.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Postavka.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Oplata.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Kolvo.ToString().IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Price.ToString().IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0) || (v.Place.IndexOf(ПоискТекстБокс.Text, StringComparison.OrdinalIgnoreCase) >= 0))
                {
                    t += v.Price * v.Kolvo;
                    ListViewItem a = new ListViewItem();
                    a.Text = v.Date.ToString();

                    a.SubItems.Add(v.Number.ToString());
                    a.SubItems.Add(v.Articul.ToString());
                    a.SubItems.Add(v.Naimen);
                    a.SubItems.Add(v.Kategoria);
                    a.SubItems.Add(v.Platforma);
                    a.SubItems.Add(v.Postavka);
                    a.SubItems.Add(v.Oplata);
                    a.SubItems.Add(v.Kolvo.ToString());
                    a.SubItems.Add(v.Price.ToString());
                    a.SubItems.Add(v.Place);
                    ЛистПроданныхТоваров.Items.Add(a);
                }
                ОбщаяСуммаПродажи.Text = "Общая сумма продажи: " + t.ToString();
            }
        }
    }
}
