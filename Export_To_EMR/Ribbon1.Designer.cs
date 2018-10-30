namespace Export_To_EMR
{
    partial class Ribbon1 : Microsoft.Office.Tools.Ribbon.RibbonBase
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        public Ribbon1()
            : base(Globals.Factory.GetRibbonFactory())
        {
            InitializeComponent();
        }

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Ribbon1));
            this.tab1 = this.Factory.CreateRibbonTab();
            this.ribbongroup = this.Factory.CreateRibbonGroup();
            this.btnExport_to_EMR = this.Factory.CreateRibbonButton();
            this.btn_send_documents = this.Factory.CreateRibbonButton();
            this.tab1.SuspendLayout();
            this.ribbongroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // tab1
            // 
            this.tab1.ControlId.ControlIdType = Microsoft.Office.Tools.Ribbon.RibbonControlIdType.Office;
            this.tab1.Groups.Add(this.ribbongroup);
            this.tab1.Label = "TabAddIns";
            this.tab1.Name = "tab1";
            // 
            // ribbongroup
            // 
            this.ribbongroup.Items.Add(this.btn_send_documents);
            this.ribbongroup.Items.Add(this.btnExport_to_EMR);
            this.ribbongroup.Label = "CAMS";
            this.ribbongroup.Name = "ribbongroup";
            // 
            // btnExport_to_EMR
            // 
            this.btnExport_to_EMR.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btnExport_to_EMR.Image = ((System.Drawing.Image)(resources.GetObject("btnExport_to_EMR.Image")));
            this.btnExport_to_EMR.Label = "Export to EMR";
            this.btnExport_to_EMR.Name = "btnExport_to_EMR";
            this.btnExport_to_EMR.ShowImage = true;
            this.btnExport_to_EMR.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btnExport_to_EMR_Click);
            // 
            // btn_send_documents
            // 
            this.btn_send_documents.ControlSize = Microsoft.Office.Core.RibbonControlSize.RibbonControlSizeLarge;
            this.btn_send_documents.Image = ((System.Drawing.Image)(resources.GetObject("btn_send_documents.Image")));
            this.btn_send_documents.Label = "Send Patient Documents";
            this.btn_send_documents.Name = "btn_send_documents";
            this.btn_send_documents.ShowImage = true;
            this.btn_send_documents.Click += new Microsoft.Office.Tools.Ribbon.RibbonControlEventHandler(this.btn_send_documents_Click);
            // 
            // Ribbon1
            // 
            this.Name = "Ribbon1";
            this.RibbonType = "Microsoft.Word.Document";
            this.Tabs.Add(this.tab1);
            this.Load += new Microsoft.Office.Tools.Ribbon.RibbonUIEventHandler(this.Ribbon1_Load);
            this.tab1.ResumeLayout(false);
            this.tab1.PerformLayout();
            this.ribbongroup.ResumeLayout(false);
            this.ribbongroup.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal Microsoft.Office.Tools.Ribbon.RibbonTab tab1;
        internal Microsoft.Office.Tools.Ribbon.RibbonGroup ribbongroup;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btnExport_to_EMR;
        internal Microsoft.Office.Tools.Ribbon.RibbonButton btn_send_documents;
    }

    partial class ThisRibbonCollection
    {
        internal Ribbon1 Ribbon1
        {
            get { return this.GetRibbon<Ribbon1>(); }
        }
    }
}
