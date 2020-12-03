using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Text;

namespace Invoice_Creator
{
    public partial class InvoiceCreator : Form
    {
        private string[] latexTemplateFiles;
        private string latexText;

        public InvoiceCreator()
        {
            InitializeComponent();
            loadLatexTemplates();
        }
        private void loadLatexTemplates()
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] currentFiles = Directory.GetFiles(currentDirectory);
            latexTemplateFiles = currentFiles.Where(c => c.EndsWith(".tex")).ToArray();
            string[] latexTemplateFilesWithoutExt = latexTemplateFiles.Select(x => Path.GetFileNameWithoutExtension(x)).ToArray();
            
            comboBoxLatexTemplate.Items.AddRange(latexTemplateFilesWithoutExt);
            comboBoxLatexTemplate.SelectedIndex = 0;
        }

        private void insertData(string type, string data)
        {
            latexText = latexText.Replace("#" + type + "#", data);
        }

        private void btnCreateInvoice_Click(object sender, EventArgs e)
        {
            string latexTemplatePath = latexTemplateFiles[comboBoxLatexTemplate.SelectedIndex];
            latexText = File.ReadAllText(latexTemplatePath);

            insertData("ORGANIZATION", tbOrganization.Text);
            insertData("NAME", tbName.Text);
            insertData("SURNAME", tbSurname.Text);


            FileStream texFile = File.Create(Directory.GetCurrentDirectory() + "/output.tex");
            texFile.Write(UnicodeEncoding.Unicode.GetBytes(latexText),
        0, UnicodeEncoding.Unicode.GetByteCount(latexText));

            // Console.Out(insertData)
        }
    }
}
