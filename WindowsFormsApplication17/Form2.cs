using System;
using System.Windows.Forms;
using static WindowsFormsApplication17.ОсновнаяФорма;

namespace WindowsFormsApplication17
{
    public partial class ФормаПоступления : Form
    {
        public ФормаПоступления()
        {
            InitializeComponent();
        }
      
        private void Календарь1_DateChanged(object sender, DateRangeEventArgs e)
        {
            ДатаТекстБокс.Text = Календарь.SelectionRange.Start.ToShortDateString();
        }
        
        private void ОформлениеПоступления_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(КоличествоТекстБокс.Text) || string.IsNullOrWhiteSpace(АртикулТекстБокс.Text)  || (ПоставщикКомбоБокс.SelectedItem == null) || (ПлатформаКомбоБокс.SelectedItem == null) || (КатегорияКомбоБокс.SelectedItem == null) || string.IsNullOrWhiteSpace(ДатаТекстБокс.Text) || string.IsNullOrWhiteSpace(ЦенаТекстБокс.Text) || (МестоПоставкКомбоБокс.SelectedItem == null))
            {
                MessageBox.Show("Не все поля заполнены", "Error",
   MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                
                _Form1.postup.Add(new Postup());

                ОсновнаяФорма._Form1.postup[ОсновнаяФорма._Form1.postup.Count - 1].Date = ДатаТекстБокс.Text;
                ОсновнаяФорма._Form1.postup[ОсновнаяФорма._Form1.postup.Count - 1].Number = _Form1.d;
                ОсновнаяФорма._Form1.postup[ОсновнаяФорма._Form1.postup.Count - 1].Naimen = НаименованиеТекстБокс.Text;
                ОсновнаяФорма._Form1.postup[ОсновнаяФорма._Form1.postup.Count - 1].Postavka = ПоставщикКомбоБокс.Text;
                ОсновнаяФорма._Form1.postup[ОсновнаяФорма._Form1.postup.Count - 1].Price = Int32.Parse(ЦенаТекстБокс.Text)*Int32.Parse(КоличествоТекстБокс.Text);
                ОсновнаяФорма._Form1.postup[ОсновнаяФорма._Form1.postup.Count - 1].Place = МестоПоставкКомбоБокс.Text;

                foreach (Postup v in ОсновнаяФорма._Form1.postup)
                {



                    ListViewItem a = new ListViewItem();
                    a.Text = v.Date.ToString();

                    a.SubItems.Add(v.Number.ToString());
                    a.SubItems.Add(v.Naimen.ToString());
                    a.SubItems.Add(v.Postavka);
                    a.SubItems.Add(v.Price.ToString());
                    a.SubItems.Add(v.Place);
                    ОсновнаяФорма._Form1.ЛистПоставки.Items.Add(a);
                }

                ОсновнаяФорма._Form1.postup1.Add(new Postup1());

                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Date = ДатаТекстБокс.Text;
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Number = _Form1.d;
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Articul = Int32.Parse(АртикулТекстБокс.Text);
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Naimen = НаименованиеТекстБокс.Text;
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Kategoria = КатегорияКомбоБокс.Text;
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Platforma = ПлатформаКомбоБокс.Text;
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Postavka = ПоставщикКомбоБокс.Text;
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Kolvo = Int32.Parse(КоличествоТекстБокс.Text);
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Price = Int32.Parse(ЦенаТекстБокс.Text);
                ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Place = МестоПоставкКомбоБокс.Text;

                ОсновнаяФорма._Form1.c += ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Kolvo* ОсновнаяФорма._Form1.postup1[ОсновнаяФорма._Form1.postup1.Count - 1].Price;
                ФормаПоступления.ActiveForm.Close();
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
        
        private void КоличествоТекстБокс_KeyPress(object sender, KeyPressEventArgs e)
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
        private void ДатаТекстБокс_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                System.Media.SystemSounds.Beep.Play();
            }
        }

        private void ФормаПоступления_Load(object sender, EventArgs e)
        {
            MaximizeBox = false;
        }
    }
}
