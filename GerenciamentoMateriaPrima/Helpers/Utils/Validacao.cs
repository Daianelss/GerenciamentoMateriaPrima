namespace GerenciamentoMateriaPrima.Helpers.Utils
{
    public static class Validacao
    {
        public static void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
                e.Handled = true;

            if (e.KeyChar == ',' && textBox.Text.Contains(','))
                e.Handled = true;

            if (!e.Handled && !char.IsControl(e.KeyChar))
            {
                textBox.Text += e.KeyChar;
                e.Handled = true;
            }

            if (textBox.Text.FirstOrDefault() == ',')
                textBox.Text = "0" + textBox.Text;

            textBox.SelectionStart = textBox.Text.Length;
        }

        public static void FormatarCampoNumero(object sender, EventArgs e)
        {
            var textBox = sender as TextBox;

            if (string.IsNullOrEmpty(textBox?.Text))
                textBox.Text = "0,00";
            else if (textBox.Text.LastOrDefault() == ',')
                textBox.Text = Convert.ToDouble(textBox.Text + '0').ToString("F2");
            else
                textBox.Text = Convert.ToDouble(textBox.Text).ToString("F2");
        }
    }
}
