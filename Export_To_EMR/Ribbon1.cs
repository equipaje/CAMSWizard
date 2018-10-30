using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

using System.Windows.Forms;
using Export_To_EMR;

//----< Word Addin >---- 
using System.IO;
using Microsoft.Office.Tools.Ribbon;
using Word = Microsoft.Office.Interop.Word;
//----</ Word Addin >---- 



namespace Export_To_EMR
{
    public partial class Ribbon1
    {
        private void Ribbon1_Load(object sender, RibbonUIEventArgs e)
        {

        }

        private void btnExport_to_EMR_Click(object sender, RibbonControlEventArgs e)
        {
            //This part exports the active doc to a PDF
            Trace.WriteLine("You clicked the button");
            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            Trace.WriteLine("You clicked the button");
            /*
            string sfileName_Document = doc.Name;
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName_Document + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
            */

            //This part is trying to get text from text boxes
            /*
            foreach (Word.Range sentence in doc.Sentences)
            {
                if (sentence.ShapeRange.Count > 0)
                {
                    foreach (Word.Shape shape in sentence.ShapeRange)
                        if (shape.Type == Microsoft.Office.Core.MsoShapeType.msoTextBox)
                            Trace.WriteLine(shape.TextFrame.TextRange.Text);
                }
                else
                    Trace.WriteLine(sentence.Text);
            }
            */

            //This part opens a dialog
            step1_dialog dialog = new step1_dialog();
            dialog.Show();





        }
    }
}
