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
            //doc.Saved = true;
            //doc.RoutingSlip.Subject = "CAMS Patient Documents";
            //doc.RoutingSlip.AddRecipient(txt_email.Text);
            doc.SendMail();
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
