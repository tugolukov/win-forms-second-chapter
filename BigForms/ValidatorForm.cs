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
    public partial class ValidatorForm : Form
    {
        public ValidatorForm()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            var form = new Form1();
            form.Show();

            this.Close();
        }

        private void ValidatorButton_Click(object sender, EventArgs e)
        {
            var json = inputTextBox.Text;

            try
            {
                dynamic obj = JsonConvert.DeserializeObject(json);
                json = JsonConvert.SerializeObject(obj, Formatting.Indented);
                outputTextBox.Text = json;
            }
            catch (Exception exception)
            {
                outputTextBox.Text = exception.Message;
            }
        }
    }
}
