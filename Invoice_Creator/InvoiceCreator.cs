using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invoice_Creator
{
		public partial class InvoiceCreator : Form
		{
				public InvoiceCreator()
				{
						InitializeComponent();
				}

				private void insertData(string type, string data)
				{

				}

				private void btnCreateInvoice_Click(object sender, EventArgs e)
				{
						string latexTemplate = comboBoxLatexTemplate.SelectedText;
				}
		}
}
