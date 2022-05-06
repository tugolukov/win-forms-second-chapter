namespace BigForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var generatorForm = new GeneratorForm();
            generatorForm.Show();

            this.Hide();
        }

        private void ValidateButton_Click(object sender, EventArgs e)
        {
            var form = new ValidatorForm();
            form.Show();

            this.Hide();
        }
    }
}