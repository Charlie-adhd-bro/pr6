namespace pr6
{
    public partial class Pr6_2 : Form
    {
        public Pr6_2()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxStart.Text.Length == 1 && textBoxEnd.Text.Length == 1)
            {
                Symbols symbols = new Symbols();
                symbols.SetSymbols(textBoxStart.Text[0], textBoxEnd.Text[0]);
                symbols.DisplaySequence(labelResult);
            }
            else
            {
                MessageBox.Show("Введите по одному символу в каждое поле",
                              "Ошибка",
                              MessageBoxButtons.OK,
                              MessageBoxIcon.Error);
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxStart.Clear();
            textBoxEnd.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }

    class Symbols
    {
        private char start;
        private char end;

        public void SetSymbols(char start, char end)
        {
            this.start = start;
            this.end = end;
        }

        public void DisplaySequence(Label label)
        {
            int step = start <= end ? 1 : -1;
            int length = Math.Abs(end - start) + 1;
            string result = "Результат:\n";

            for (int i = 0; i < length; i++)
            {
                char current = (char)(start + i * step);
                
                if (i == length - 1)
                {
                    result += current;
                }
                else
                {
                    result += current + ", ";
                }
            }

            label.Text = result;
        }
    }
}

/*
namespace pr6
{
    public partial class Pr6_2 : Form
    {
        public Pr6_2()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            if (textBoxStart.Text.Length == 1 && textBoxEnd.Text.Length == 1)
            {
                char startChar = textBoxStart.Text[0];
                char endChar = textBoxEnd.Text[0];

                Symbols symbols = new Symbols(startChar, endChar, labelResult);
                symbols.GenerateSequence(); // Метод ничего не возвращает и не принимает аргументов
            }
            else
            {
                MessageBox.Show(
                    "Введите по одному символу в каждое поле!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxStart.Clear();
            textBoxEnd.Clear();
            labelResult.Text = "";
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainForm formMain = new MainForm();
            formMain.Show();
        }
    }

    class Symbols
    {
        private char start;
        private char end;
        private Label outputLabel; // Поле для вывода в Label

        // Конструктор (инициализирует поля)
        public Symbols(char start, char end, Label label)
        {
            this.start = start;
            this.end = end;
            this.outputLabel = label;
        }

        public void GenerateSequence()
        {
            int step = (start <= end) ? 1 : -1; // Шаг (возрастание или убывание)
            int length = Math.Abs(end - start) + 1;
            string result = "";

            for (int i = 0; i < length; i++)
            {
                char currentChar = (char)(start + i * step);
                result += currentChar + " "; 
            }

            outputLabel.Text = result.Trim(); // Выводим в Label
        }
    }
}
*/