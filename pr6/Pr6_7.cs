using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pr6
{
    public partial class Pr6_7 : Form
    {
        public Pr6_7()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            if (textBoxInput.Text.Length == 0)
            {
                MessageBox.Show(
                       "Текстовое поле пустое, введите как минимум одно значение",
                       "Ошибка ввода",
                       MessageBoxButtons.OK,
                       MessageBoxIcon.Error
                   );
                return;
            }

            char[] chars = textBoxInput.Text.ToCharArray();
            string text = textBoxInput.Text;

            CharAndString charAndString = new CharAndString();

            charAndString.StringOrChar(text);
            charAndString.StringOrChar('j');
            charAndString.output();

            charAndString.StringOrChar(chars[0]);
            charAndString.StringOrChar(chars);

            charAndString.output();
                
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();        
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }

    class CharAndString
    {
        private string Text = "";
        private char Symbol = 'ы';

        public void StringOrChar(char[] input)
        {
            if (input.Length > 1)
            {
                Text = System.String.Concat(input);
            }

            else
            {
                Symbol = input[0];
            }
        }

        public void StringOrChar(string input)
        {
            Text = input;
        }

        public void StringOrChar(char input)
        {
            Symbol = input;
        }

        public void output()
        {
            MessageBox.Show( $"Строка: {Text} \nСимвол: {Symbol}");
        }
    }
}
