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

using Outlook = Microsoft.Office.Interop.Outlook; 

namespace Export_To_EMR
{
    public partial class send_form_dialog : Form
    {
        private Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
        private Word.Application WordApp = Globals.ThisAddIn.Application;

        public send_form_dialog()
        {
            InitializeComponent();
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            //This opens outlook with a pdf attachment
            //doc.SendMail();

            //create a temp folder to put the pdf in
            string tempFolder = Path.GetTempPath();
            Directory.CreateDirectory(tempFolder);
            Trace.WriteLine("Here's where the temp folder is: " + tempFolder.ToString());

            //store the document as a pdf in the temp location
            //string sfileName_Document = doc.Name;
            string sfileName = doc.Name.Substring(0, doc.Name.Length - 5); //remove the .docx file extension
            string sFullpath_pdf = tempFolder + "\\" + sfileName + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: false); // you'll need a doc range here

            //create a new mail
            Outlook.Application OutlookApp = new Outlook.Application();
            Outlook.MailItem mail = (Outlook.MailItem)OutlookApp.CreateItem(Outlook.OlItemType.olMailItem);
            mail.Subject = "CAMS form";
            mail.Attachments.Add(sFullpath_pdf);
            mail.Display(true); //show the new Mail

        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
