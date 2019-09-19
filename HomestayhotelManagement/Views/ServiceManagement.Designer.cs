namespace HomestayhotelManagement.Views
{
    partial class ServiceManagement
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.grbService = new System.Windows.Forms.GroupBox();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txbPriceService = new System.Windows.Forms.TextBox();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.txbServicename = new System.Windows.Forms.TextBox();
            this.dgvServiceManagement = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.serviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnAddService = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.btnDeleteService = new System.Windows.Forms.Button();
            this.btnClearService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearchService = new System.Windows.Forms.Button();
            this.txbSearchService = new System.Windows.Forms.TextBox();
            this.grbService.SuspendLayout();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceManagement)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // grbService
            // 
            this.grbService.Controls.Add(this.grbInfo);
            this.grbService.Controls.Add(this.dgvServiceManagement);
            this.grbService.Controls.Add(this.btnAddService);
            this.grbService.Controls.Add(this.btnUpdateService);
            this.grbService.Controls.Add(this.btnDeleteService);
            this.grbService.Controls.Add(this.btnClearService);
            this.grbService.Controls.Add(this.label1);
            this.grbService.Controls.Add(this.btnSearchService);
            this.grbService.Controls.Add(this.txbSearchService);
            this.grbService.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbService.Location = new System.Drawing.Point(0, 0);
            this.grbService.Name = "grbService";
            this.grbService.Size = new System.Drawing.Size(1188, 701);
            this.grbService.TabIndex = 1;
            this.grbService.TabStop = false;
            this.grbService.Text = "QUẢN LÝ DỊCH VỤ";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.label12);
            this.grbInfo.Controls.Add(this.label13);
            this.grbInfo.Controls.Add(this.label14);
            this.grbInfo.Controls.Add(this.txbPriceService);
            this.grbInfo.Controls.Add(this.txbDescription);
            this.grbInfo.Controls.Add(this.txbServicename);
            this.grbInfo.Location = new System.Drawing.Point(373, 76);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(442, 196);
            this.grbInfo.TabIndex = 42;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "Nhập thông tin";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(52, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(77, 19);
            this.label12.TabIndex = 44;
            this.label12.Text = "Giá dịch vụ";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(52, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 19);
            this.label13.TabIndex = 45;
            this.label13.Text = "Mô tả";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(52, 38);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 19);
            this.label14.TabIndex = 46;
            this.label14.Text = "Tên dịch vụ";
            // 
            // txbPriceService
            // 
            this.txbPriceService.Location = new System.Drawing.Point(137, 136);
            this.txbPriceService.Name = "txbPriceService";
            this.txbPriceService.Size = new System.Drawing.Size(253, 26);
            this.txbPriceService.TabIndex = 43;
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(137, 67);
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(253, 63);
            this.txbDescription.TabIndex = 42;
            // 
            // txbServicename
            // 
            this.txbServicename.Location = new System.Drawing.Point(137, 35);
            this.txbServicename.Name = "txbServicename";
            this.txbServicename.Size = new System.Drawing.Size(253, 26);
            this.txbServicename.TabIndex = 41;
            // 
            // dgvServiceManagement
            // 
            this.dgvServiceManagement.AutoGenerateColumns = false;
            this.dgvServiceManagement.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServiceManagement.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServiceManagement.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn});
            this.dgvServiceManagement.DataSource = this.serviceBindingSource;
            this.dgvServiceManagement.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvServiceManagement.Location = new System.Drawing.Point(3, 358);
            this.dgvServiceManagement.Name = "dgvServiceManagement";
            this.dgvServiceManagement.Size = new System.Drawing.Size(1182, 340);
            this.dgvServiceManagement.TabIndex = 41;
            this.dgvServiceManagement.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvServiceManagement_RowEnter);
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // serviceBindingSource
            // 
            this.serviceBindingSource.DataSource = typeof(HomestayhotelManagement.ServiceReference1.Service);
            // 
            // btnAddService
            // 
            this.btnAddService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAddService.Location = new System.Drawing.Point(341, 293);
            this.btnAddService.Name = "btnAddService";
            this.btnAddService.Size = new System.Drawing.Size(122, 40);
            this.btnAddService.TabIndex = 3;
            this.btnAddService.Text = "Thêm mới";
            this.btnAddService.UseVisualStyleBackColor = true;
            this.btnAddService.Click += new System.EventHandler(this.btnAddService_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUpdateService.Location = new System.Drawing.Point(469, 293);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(122, 40);
            this.btnUpdateService.TabIndex = 4;
            this.btnUpdateService.Text = "Sửa";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdateService_Click);
            // 
            // btnDeleteService
            // 
            this.btnDeleteService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnDeleteService.Location = new System.Drawing.Point(597, 293);
            this.btnDeleteService.Name = "btnDeleteService";
            this.btnDeleteService.Size = new System.Drawing.Size(122, 40);
            this.btnDeleteService.TabIndex = 5;
            this.btnDeleteService.Text = "Xóa";
            this.btnDeleteService.UseVisualStyleBackColor = true;
            this.btnDeleteService.Click += new System.EventHandler(this.btnDeleteService_Click);
            // 
            // btnClearService
            // 
            this.btnClearService.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearService.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnClearService.Location = new System.Drawing.Point(725, 293);
            this.btnClearService.Name = "btnClearService";
            this.btnClearService.Size = new System.Drawing.Size(122, 40);
            this.btnClearService.TabIndex = 6;
            this.btnClearService.Text = "Nhập lại";
            this.btnClearService.UseVisualStyleBackColor = true;
            this.btnClearService.Click += new System.EventHandler(this.btnClearService_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(738, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 19);
            this.label1.TabIndex = 28;
            this.label1.Text = "Tìm kiếm";
            // 
            // btnSearchService
            // 
            this.btnSearchService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchService.Location = new System.Drawing.Point(1063, 19);
            this.btnSearchService.Name = "btnSearchService";
            this.btnSearchService.Size = new System.Drawing.Size(119, 31);
            this.btnSearchService.TabIndex = 8;
            this.btnSearchService.Text = "Tìm";
            this.btnSearchService.UseVisualStyleBackColor = true;
            this.btnSearchService.Click += new System.EventHandler(this.btnSearchService_Click);
            // 
            // txbSearchService
            // 
            this.txbSearchService.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearchService.Location = new System.Drawing.Point(809, 19);
            this.txbSearchService.Name = "txbSearchService";
            this.txbSearchService.Size = new System.Drawing.Size(248, 26);
            this.txbSearchService.TabIndex = 7;
            // 
            // ServiceManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbService);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ServiceManagement";
            this.Size = new System.Drawing.Size(1188, 701);
            this.Load += new System.EventHandler(this.ServiceManagement_Load);
            this.grbService.ResumeLayout(false);
            this.grbService.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServiceManagement)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serviceBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbService;
        private System.Windows.Forms.BindingSource serviceBindingSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearchService;
        private System.Windows.Forms.TextBox txbSearchService;
        private System.Windows.Forms.DataGridView dgvServiceManagement;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button btnAddService;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Button btnDeleteService;
        private System.Windows.Forms.Button btnClearService;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txbPriceService;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.TextBox txbServicename;
    }
}
