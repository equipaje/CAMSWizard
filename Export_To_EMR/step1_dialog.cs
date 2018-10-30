using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


//----< Word Addin >---- 
using System.IO;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
//----</ Word Addin >---- 

namespace Export_To_EMR
{
    public partial class step1_dialog : Form
    {

        public step1_dialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //clicking on the Save as PDF button
        private void btn_PDF_Click(object sender, EventArgs e)
        {
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Trace.WriteLine("Save PDF button clicked");
           
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
        }

        private void EMR_export_dialog_Load(object sender, EventArgs e)
        {
            
        }

        //clicking the next button
        private void btn_next_Click(object sender, EventArgs e)
        {
            //hide all of the UI from step 1.
            btn_PDF.Hide();
            label1.Hide();
            label2.Hide();
         

        }
    }
}
