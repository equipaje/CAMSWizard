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
    public partial class EMR_export_dialog : Form
    {
        private Word.Document doc = Globals.ThisAddIn.Application.ActiveDocument;
        private Word.Application WordApp = Globals.ThisAddIn.Application;
        private int currStep; //which step of the UI we're on

        public EMR_export_dialog()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        //clicking on the Save as PDF button
        private void btn_PDF_Click(object sender, EventArgs e)
        {  
            //string sfileName_Document = doc.Name;
            string sfileName = doc.Name.Substring(0, doc.Name.Length - 5); //remove the .docx file extension
            string sPath = doc.Path;
            string sFullpath_pdf = sPath + "\\" + sfileName + ".pdf";
            doc.ExportAsFixedFormat(sFullpath_pdf, Word.WdExportFormat.wdExportFormatPDF, OpenAfterExport: true);
        }

        private void EMR_export_dialog_Load(object sender, EventArgs e)
        {
            //hide all buttons that aren't part of step 1
            lbl_step2.Hide();
            lbl_step2_description.Hide();
            lbl_step3.Hide();
            lbl_step3_description.Hide();
            txtbx_EMR_Data.Hide();

            //make current step 1
            currStep = 1;
        }

        //clicking the next button
        private void btn_next_Click(object sender, EventArgs e)
        {
            //instantiate a list to store all of the form text responses
            List<string> currTextList = new List<string>();

            if (currStep == 1)
            {
                //hide step 1 UI
                btn_PDF.Hide();
                lbl_step1_description.Hide();
                lbl_step1.Hide();

                //Show step 2 UI
                lbl_step2.Show();
                lbl_step2_description.Show();

                WordApp.CommandBars.ExecuteMso("ConvertAllInkButton"); //change back to "Replay" if you don't have the right build

                //increment the current step
                currStep++;
            }
            else if(currStep == 2)
            {
                // Hide step 2 UI
                lbl_step2.Hide();
                lbl_step2_description.Hide();

                //Show step 3 UI
                // set the next button to Done
                lbl_step3.Show();
                lbl_step3_description.Show();
                txtbx_EMR_Data.Show();
                btn_next.Text = "Done";

                //increment current step
                currStep++;

                //get the text in the document and stick it into the text field
                currTextList = getPlainText();

                // add the form text to the UI textbox
                foreach (string entry in currTextList)
                {
                    txtbx_EMR_Data.AppendText(entry);
                }

                //Scroll the text box to the top
                txtbx_EMR_Data.SelectionStart = 0;
                txtbx_EMR_Data.ScrollToCaret();
                
            }
            else
            {
                Close();
            }

        }

        // returns a list of all of the strings that exist in text boxes in the current document
        private List<string> getPlainText()
        {
            List<string> textList = new List<string>(); //here is where we store all of the responses from the form
            
            foreach (Word.Range sentence in doc.Sentences)
            {
                if (sentence.ShapeRange.Count > 0) //if there are shapes
                {
                    foreach (Word.Shape shape in sentence.ShapeRange)
                    {
                        if (shape.Type == Microsoft.Office.Core.MsoShapeType.msoTextBox) //if it's a textbox
                        {
                            Word.ContentControls allContentControls = shape.TextFrame.TextRange.ContentControls; //get the collection of Content Controls in the shape

                            /*
                             * If there are check boxes, figure out which ones are checked and add that to the list
                             */
                            if (allContentControls.Count > 0) //if there are content controls
                            {
                                List<int> checkedBoxes = new List<int>(); //a list to store the numbers of the content controls that are checked
                                int num = 1; //to track which content control we're on
                                string finalString = "Rating: "; //this is what will be added to the text list

                                foreach (Word.ContentControl cc in allContentControls)
                                {
                                    if(cc.Checked == true)
                                    {
                                        checkedBoxes.Add(num);
                                        num++; 
                                    }
                                    else
                                    {
                                        num++;
                                    }
                                }

                                foreach (int i in checkedBoxes)
                                {
                                    Trace.WriteLine(i + " is checked");
                                    finalString = finalString + i + " ";
                                }

                                textList.Insert(0, finalString + "\n");
                            }

                            //otherwise, just add the text in the textbox to the list
                            else
                            {
                                textList.Insert(0, shape.TextFrame.TextRange.Text + "\n"); // prepend each object to the list so that the document will print top to bottom
                            }
                        }
                    }
                }
            }

            return textList;
        }
         
        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
