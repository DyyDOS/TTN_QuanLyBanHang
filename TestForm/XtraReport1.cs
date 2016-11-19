using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace TestForm
{
    public partial class XtraReport1 : DevExpress.XtraReports.UI.XtraReport
    {
       
        public XtraReport1()
        {
            InitializeComponent();
        }
        public void BindData()
        {
          
        }
        private void xrTableCell7_SummaryGetResult(object sender, SummaryGetResultEventArgs e)
        {

        }

        private void xrTableCell7_SummaryReset(object sender, EventArgs e)
        {
            //tong = 0;
        }

        private void xrTableCell7_SummaryRowChanged(object sender, EventArgs e)
        {

        }

    }
}
