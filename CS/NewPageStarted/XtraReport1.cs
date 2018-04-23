using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace NewPageStarted {
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport {
        int pageCount = -1;
        public XtraReport1() {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e) {
            if (PrintingSystem.Document.PageCount != pageCount) {
                lblNewPage.Visible = true;                
                pageCount = PrintingSystem.Document.PageCount;
                lblNewPage.Text = "New page: " + (pageCount + 1);
            }
            else {
                lblNewPage.Visible = false;
            }
        }

    }
}
