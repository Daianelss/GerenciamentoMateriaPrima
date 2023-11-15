namespace GerenciamentoMateriaPrima.Utils
{
    public static class Validacao
    {
        public static void ValidarNumeros(object sender, KeyPressEventArgs e)
        {
            var textBox = sender as TextBox;

            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
                e.Handled = true;

            if ((e.KeyChar == ',') && (textBox.Text.Contains(',')))
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
    }
}
