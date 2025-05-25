namespace pr6
{
    public partial class Pr6_1 : Form
    {
        public Pr6_1()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 1)
            {
                Symbol symbol = new Symbol();
                symbol.SetSymbol(textBox1.Text[0]);
                labelResult.Text = symbol.GetSymbolAndCode();
            }  
            else
            {
                MessageBox.Show(
                    "Введите один символ",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelResult.Text = null;
            textBox1.Clear();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm formMain = new MainForm();
            formMain.Show();
        }
    }
    class Symbol
    {
        private char symbol;

        public void SetSymbol(char s)
        {
            symbol = s;
        }

        public int GetCharCode()
        {
            return (int)symbol;
        }

        public string GetSymbolAndCode()
        {
            return $"Символ: {symbol}" +
                $"\nКод: {(int)symbol}";
        }
    }
}