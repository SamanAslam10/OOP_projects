namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.RosyBrown;

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string v1 = value1.Text;
            string v2 = value2.Text;

            int Value1 = int.Parse(v1);
            int Value2 = int.Parse(v2);

            int sum = Value1 + Value2;

            Result.Text = sum.ToString();

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            string v1 = value1.Text;
            string v2 = value2.Text;

            int Value1 = int.Parse(v1);
            int Value2 = int.Parse(v2);

            int subtract = Value1 - Value2;

            Result.Text = subtract.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.RosyBrown;
        }
    }
}
