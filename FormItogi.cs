using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kollok
{
    public partial class FormItogi : Form
    {
        public FormItogi(int PRICEITOG)
        {
            InitializeComponent();
            labelItogi.Text = $"ИТОГОВАЯ ЦЕНА --------- {PRICEITOG} рублей";
        }

        private void FormItogi_Load(object sender, EventArgs e)
        {
        }

        private void labelItogi_Click(object sender, EventArgs e)
        {

        }
    }
}
