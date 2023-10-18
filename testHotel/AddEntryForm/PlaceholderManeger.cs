using System.Drawing;
using System.Windows.Forms;

namespace testHotel.AddEntryForm
{
    public static class PlaceholderManeger
    {
        public static void AddPlaceHolderForTextBox(this TextBox tb, string placeHolderText)
        {
            tb.ForeColor = Color.Gray;

            tb.Text = placeHolderText;

            tb.Enter += (s, e) =>
            {
                if (tb.Text == placeHolderText)
                {
                    tb.Text = "";

                    tb.ForeColor = Color.Black;
                }
            };
            tb.Leave += (s, e) =>
            {
                if (tb.Text == "")
                {
                    tb.ForeColor = Color.Gray;

                    tb.Text = placeHolderText;
                }
            };  
        }

        public static void AddPlaceHolderForComboBoc(this ComboBox cb, string placeHolderText)
        {
            cb.Items.Add(placeHolderText);
            cb. Text = placeHolderText;

            cb.Enter += (s, e) =>
            {
                if (cb.Items.Contains(placeHolderText))
                {
                    cb.Items.Remove(placeHolderText);
                }
            };
        }
    }

}
