namespace TestForm
{
    partial class FormThongKeHangTon
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraCharts.XYDiagram xyDiagram1 = new DevExpress.XtraCharts.XYDiagram();
            DevExpress.XtraCharts.Series series1 = new DevExpress.XtraCharts.Series();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            this.pR_THONGKE_SOLUONGCONTableAdapter = new TestForm.QuanLyBanHangDataSet1TableAdapters.PR_THONGKE_SOLUONGCONTableAdapter();
            this.pRTHONGKESOLUONGCONBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.quanLyBanHangDataSet1 = new TestForm.QuanLyBanHangDataSet1();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTHONGKESOLUONGCONBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // chartControl1
            // 
            this.chartControl1.DataAdapter = this.pR_THONGKE_SOLUONGCONTableAdapter;
            this.chartControl1.DataSource = this.pRTHONGKESOLUONGCONBindingSource;
            xyDiagram1.AxisX.VisibleInPanesSerializable = "-1";
            xyDiagram1.AxisY.VisibleInPanesSerializable = "-1";
            this.chartControl1.Diagram = xyDiagram1;
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            series1.ArgumentDataMember = "TenMH";
            series1.Name = "Tên MH";
            series1.ValueDataMembersSerializable = "SoLuongCon";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[] {
        series1};
            this.chartControl1.Size = new System.Drawing.Size(949, 579);
            this.chartControl1.TabIndex = 0;
            // 
            // pR_THONGKE_SOLUONGCONTableAdapter
            // 
            this.pR_THONGKE_SOLUONGCONTableAdapter.ClearBeforeFill = true;
            // 
            // pRTHONGKESOLUONGCONBindingSource
            // 
            this.pRTHONGKESOLUONGCONBindingSource.DataMember = "PR_THONGKE_SOLUONGCON";
            this.pRTHONGKESOLUONGCONBindingSource.DataSource = this.quanLyBanHangDataSet1;
            // 
            // quanLyBanHangDataSet1
            // 
            this.quanLyBanHangDataSet1.DataSetName = "QuanLyBanHangDataSet1";
            this.quanLyBanHangDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // FormThongKeHangTon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 579);
            this.Controls.Add(this.chartControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormThongKeHangTon";
            this.Text = "FormThongKeHangTon";
            this.Load += new System.EventHandler(this.FormThongKeHangTon_Load);
            ((System.ComponentModel.ISupportInitialize)(xyDiagram1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(series1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRTHONGKESOLUONGCONBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.quanLyBanHangDataSet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraCharts.ChartControl chartControl1;
        private QuanLyBanHangDataSet1TableAdapters.PR_THONGKE_SOLUONGCONTableAdapter pR_THONGKE_SOLUONGCONTableAdapter;
        private QuanLyBanHangDataSet1 quanLyBanHangDataSet1;
        private System.Windows.Forms.BindingSource pRTHONGKESOLUONGCONBindingSource;
    }
}