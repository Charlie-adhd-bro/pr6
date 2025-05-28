using static System.Runtime.InteropServices.JavaScript.JSType;

namespace pr6
{
    public partial class Pr6_8 : Form
    {
        public Pr6_8()
        {
            InitializeComponent();
        }

        private void buttonResult_Click(object sender, EventArgs e)
        {
            ClassWithStatic classWithStatic = new();
            labelResult.Text = "Текущее значение статического поля: " 
                + ClassWithStatic.PlusOne().ToString();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            labelResult.Text = string.Empty;
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            new MainForm().Show();
        }
    }

    class ClassWithStatic
    {
        private static int num = 0;

        public static int PlusOne()
        {
            int current = num;
            num++;
            return current;
        }
    }
}
