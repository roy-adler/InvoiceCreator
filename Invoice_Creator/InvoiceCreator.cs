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
        private string outputFile;

        public InvoiceCreator()
        {
            InitializeComponent();
            removeTempFiles();
            loadLatexTemplates();
            loadLastTemplate();
        }

        private void loadLastTemplate()
        {
            getFilesWithEnding(".fulltemplate");
        }

        private void removeTempFiles()
        {
            outputFile = Directory.GetCurrentDirectory() + "/output.tex";
            if (File.Exists(outputFile))
            {
                File.Delete(outputFile);
            }
        }

        private string[] getFilesWithEnding(string ending)
        {
            string currentDirectory = Directory.GetCurrentDirectory();
            string[] currentFiles = Directory.GetFiles(currentDirectory);
            return currentFiles.Where(file => file.EndsWith(ending)).ToArray();
        }
        private void loadLatexTemplates()
        {
            latexTemplateFiles = getFilesWithEnding(".tex");
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

            insertData("ORGANIZATION", tbOrganization.Text); // TODO: If empty then..?
            insertData("NAME", tbName.Text);
            insertData("SURNAME", tbSurname.Text);
            insertData("STREET", tbOrgStreet.Text);
            insertData("ZIPCODE", tbZipCode.Text);
            insertData("STATE", tbState.Text);
            insertData("EMAIL", "royadler@outlook.com"); // TODO: Insert E-Mail Textbox
            insertData("NUMBER", "1"); // TODO: Insert Invoice-Number Textbox
            insertData("DATE", "03.12.2020"); // TODO: Insert Datepicker

            insertData("TO_ORGANIZATION", tbOrganization.Text);
            insertData("TO_NAME", tbName.Text);
            insertData("TO_SURNAME", tbSurname.Text);
            insertData("TO_STREET", tbOrgStreet.Text);
            insertData("TO_ZIPCODE", tbZipCode.Text);
            insertData("TO_STATE", tbState.Text);

            FileStream texFile = File.Create(outputFile);
            texFile.Write(UnicodeEncoding.Unicode.GetBytes(latexText),
        0, UnicodeEncoding.Unicode.GetByteCount(latexText));
            texFile.Close();
            texFile.Dispose();
            // Console.Out(insertData)
        }

        
    }
}
