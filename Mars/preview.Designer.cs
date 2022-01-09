namespace Mars
{
    partial class preview
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
            //Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            //this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.Database1DataSet5 = new Mars.Database1DataSet5();
            this.MarksBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.MarksTableAdapter = new Mars.Database1DataSet5TableAdapters.MarksTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            //this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            //reportDataSource1.Name = "DataSet1";
            //reportDataSource1.Value = this.MarksBindingSource;
            //this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            //this.reportViewer1.LocalReport.ReportEmbeddedResource = "Mars.Report1.rdlc";
            //this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            //this.reportViewer1.Name = "reportViewer1";
            //this.reportViewer1.Size = new System.Drawing.Size(1003, 464);
            //this.reportViewer1.TabIndex = 0;
            // 
            // Database1DataSet5
            // 
            this.Database1DataSet5.DataSetName = "Database1DataSet5";
            this.Database1DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // MarksBindingSource
            // 
            this.MarksBindingSource.DataMember = "Marks";
            this.MarksBindingSource.DataSource = this.Database1DataSet5;
            // 
            // MarksTableAdapter
            // 
            this.MarksTableAdapter.ClearBeforeFill = true;
            // 
            // preview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 464);
            //this.Controls.Add(this.reportViewer1);
            this.Name = "preview";
            this.Text = "preview";
            this.Load += new System.EventHandler(this.preview_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Database1DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarksBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        //private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource MarksBindingSource;
        private Database1DataSet5 Database1DataSet5;
        private Database1DataSet5TableAdapters.MarksTableAdapter MarksTableAdapter;

    }
}