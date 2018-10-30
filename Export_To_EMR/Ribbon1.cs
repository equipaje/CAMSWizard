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

            Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
            //This part opens the export to EMR dialog
            EMR_export_dialog dialog = new EMR_export_dialog();
            dialog.Show();

        }

        private void btn_send_documents_Click(object sender, RibbonControlEventArgs e)
        {
            //This part opens the send dialog
            send_form_dialog dialog = new send_form_dialog();
            dialog.Show();
        }
    }
}
