using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BigForms
{
    public partial class GeneratorForm : Form
    {
        public GeneratorForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();

            this.Close();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var outputObject = Person.Generate();
            var json = "";

            if (isFormat.Checked)
            {
                json = JsonConvert.SerializeObject(outputObject, Formatting.Indented);
            }
            else
            {
                json = JsonConvert.SerializeObject(outputObject);
            }


            OutputTextBox.Text = json;
        }
    }
}
