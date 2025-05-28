namespace pr6
{
    public partial class Pr6_9 : Form
    {
        public Pr6_9()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {

            try
            {
                string[] inputs = textBoxInput.Text.Split([' ', ',']);
                int[] numbers = Array.ConvertAll(inputs, int.Parse);

                var result = MaxMinAvg.FindMinMaxAvg(numbers);
                labelResult.Text = ($"Минимальное значение: {result.min}, " +
                    $"\nМаксимальное значение: {result.max}, " +
                    $"\nСреднее значение: {result.avg}");
            }

            catch (FormatException)
            {
                MessageBox.Show(
                    "Введите только целые числа, разделенные пробелами или запятыми",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

            catch (OverflowException)
            {
                MessageBox.Show(
                    "Введено слишком большое или слишком маленькое число",
                    "Ошибка ввода",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Произошла ошибка: {ex.Message}",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }



        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            textBoxInput.Clear();
            labelResult.Text = string.Empty;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }
    class MaxMinAvg
    {
        public static (int min, int max, float avg) FindMinMaxAvg(params int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return (0, 0, 0); 
            }

            int min = numbers[0];
            int max = numbers[0];
            float avg = 0;

            foreach (int num in numbers)
            {
                if (num < min) min = num;
                if (num > max) max = num;
                avg += num;
            }
                 
            avg = ((float)Math.Round(avg / numbers.Length, 2));


            return (min, max, avg);
        }

    }

}
