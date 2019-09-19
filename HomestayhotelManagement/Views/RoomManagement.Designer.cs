namespace HomestayhotelManagement.Views
{
    partial class RoomManagement
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
            this.grbRoomManagement = new System.Windows.Forms.GroupBox();
            this.btnSearchUser = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDeletRoom = new System.Windows.Forms.Button();
            this.btnUpdateRoom = new System.Windows.Forms.Button();
            this.btnSaveRoom = new System.Windows.Forms.Button();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label12 = new System.Windows.Forms.Label();
            this.txbSearch = new System.Windows.Forms.TextBox();
            this.grbRoomInfo = new System.Windows.Forms.GroupBox();
            this.flpanelImage = new System.Windows.Forms.FlowLayoutPanel();
            this.clbService = new System.Windows.Forms.CheckedListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txbRoomNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbDescription = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbRoomManagement.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).BeginInit();
            this.grbRoomInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbRoomManagement
            // 
            this.grbRoomManagement.BackColor = System.Drawing.SystemColors.Control;
            this.grbRoomManagement.Controls.Add(this.btnSearchUser);
            this.grbRoomManagement.Controls.Add(this.btnClear);
            this.grbRoomManagement.Controls.Add(this.btnDeletRoom);
            this.grbRoomManagement.Controls.Add(this.btnUpdateRoom);
            this.grbRoomManagement.Controls.Add(this.btnSaveRoom);
            this.grbRoomManagement.Controls.Add(this.dgvRooms);
            this.grbRoomManagement.Controls.Add(this.label12);
            this.grbRoomManagement.Controls.Add(this.txbSearch);
            this.grbRoomManagement.Controls.Add(this.grbRoomInfo);
            this.grbRoomManagement.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grbRoomManagement.Location = new System.Drawing.Point(0, 0);
            this.grbRoomManagement.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbRoomManagement.Name = "grbRoomManagement";
            this.grbRoomManagement.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.grbRoomManagement.Size = new System.Drawing.Size(1188, 701);
            this.grbRoomManagement.TabIndex = 1;
            this.grbRoomManagement.TabStop = false;
            this.grbRoomManagement.Text = "Quản Lý Phòng";
            // 
            // btnSearchUser
            // 
            this.btnSearchUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearchUser.Location = new System.Drawing.Point(1062, 16);
            this.btnSearchUser.Name = "btnSearchUser";
            this.btnSearchUser.Size = new System.Drawing.Size(119, 31);
            this.btnSearchUser.TabIndex = 36;
            this.btnSearchUser.Text = "Tìm";
            this.btnSearchUser.UseVisualStyleBackColor = true;
            this.btnSearchUser.Click += new System.EventHandler(this.btnSearchUser_Click);
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnClear.Location = new System.Drawing.Point(747, 435);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(120, 37);
            this.btnClear.TabIndex = 35;
            this.btnClear.Text = "Nhập lại";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDeletRoom
            // 
            this.btnDeletRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDeletRoom.Location = new System.Drawing.Point(605, 435);
            this.btnDeletRoom.Name = "btnDeletRoom";
            this.btnDeletRoom.Size = new System.Drawing.Size(120, 37);
            this.btnDeletRoom.TabIndex = 34;
            this.btnDeletRoom.Text = "Xóa";
            this.btnDeletRoom.UseVisualStyleBackColor = true;
            this.btnDeletRoom.Click += new System.EventHandler(this.btnDeletRoom_Click);
            // 
            // btnUpdateRoom
            // 
            this.btnUpdateRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnUpdateRoom.Location = new System.Drawing.Point(463, 435);
            this.btnUpdateRoom.Name = "btnUpdateRoom";
            this.btnUpdateRoom.Size = new System.Drawing.Size(120, 37);
            this.btnUpdateRoom.TabIndex = 33;
            this.btnUpdateRoom.Text = "Sửa";
            this.btnUpdateRoom.UseVisualStyleBackColor = true;
            this.btnUpdateRoom.Click += new System.EventHandler(this.btnUpdateRoom_Click);
            // 
            // btnSaveRoom
            // 
            this.btnSaveRoom.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSaveRoom.Location = new System.Drawing.Point(321, 435);
            this.btnSaveRoom.Name = "btnSaveRoom";
            this.btnSaveRoom.Size = new System.Drawing.Size(120, 37);
            this.btnSaveRoom.TabIndex = 32;
            this.btnSaveRoom.Text = "Thêm";
            this.btnSaveRoom.UseVisualStyleBackColor = true;
            this.btnSaveRoom.Click += new System.EventHandler(this.btnSaveRoom_Click);
            // 
            // dgvRooms
            // 
            this.dgvRooms.AutoGenerateColumns = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dgvRooms.DataSource = this.roomBindingSource;
            this.dgvRooms.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvRooms.Location = new System.Drawing.Point(4, 509);
            this.dgvRooms.MultiSelect = false;
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.Size = new System.Drawing.Size(1180, 187);
            this.dgvRooms.TabIndex = 31;
            this.dgvRooms.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRooms_RowEnter);
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            this.descriptionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomBindingSource
            // 
            this.roomBindingSource.DataSource = typeof(HomestayhotelManagement.ServiceReference1.Room);
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(737, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 19);
            this.label12.TabIndex = 29;
            this.label12.Text = "Tìm kiếm";
            // 
            // txbSearch
            // 
            this.txbSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txbSearch.Location = new System.Drawing.Point(808, 19);
            this.txbSearch.Name = "txbSearch";
            this.txbSearch.Size = new System.Drawing.Size(248, 26);
            this.txbSearch.TabIndex = 30;
            // 
            // grbRoomInfo
            // 
            this.grbRoomInfo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.grbRoomInfo.Controls.Add(this.flpanelImage);
            this.grbRoomInfo.Controls.Add(this.clbService);
            this.grbRoomInfo.Controls.Add(this.label4);
            this.grbRoomInfo.Controls.Add(this.txbRoomNumber);
            this.grbRoomInfo.Controls.Add(this.label1);
            this.grbRoomInfo.Controls.Add(this.label5);
            this.grbRoomInfo.Controls.Add(this.txbDescription);
            this.grbRoomInfo.Location = new System.Drawing.Point(220, 73);
            this.grbRoomInfo.Name = "grbRoomInfo";
            this.grbRoomInfo.Size = new System.Drawing.Size(748, 305);
            this.grbRoomInfo.TabIndex = 28;
            this.grbRoomInfo.TabStop = false;
            this.grbRoomInfo.Text = "Thông tin phòng";
            // 
            // flpanelImage
            // 
            this.flpanelImage.AutoScroll = true;
            this.flpanelImage.BackColor = System.Drawing.Color.LightGray;
            this.flpanelImage.Location = new System.Drawing.Point(404, 25);
            this.flpanelImage.Name = "flpanelImage";
            this.flpanelImage.Size = new System.Drawing.Size(338, 274);
            this.flpanelImage.TabIndex = 37;
            this.flpanelImage.Click += new System.EventHandler(this.flowLayoutPanel1_Click);
            // 
            // clbService
            // 
            this.clbService.CheckOnClick = true;
            this.clbService.FormattingEnabled = true;
            this.clbService.Location = new System.Drawing.Point(129, 178);
            this.clbService.Name = "clbService";
            this.clbService.Size = new System.Drawing.Size(253, 88);
            this.clbService.TabIndex = 37;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 7;
            this.label4.Text = "Số phòng";
            // 
            // txbRoomNumber
            // 
            this.txbRoomNumber.Location = new System.Drawing.Point(129, 38);
            this.txbRoomNumber.Name = "txbRoomNumber";
            this.txbRoomNumber.Size = new System.Drawing.Size(253, 26);
            this.txbRoomNumber.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(42, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 19);
            this.label5.TabIndex = 8;
            this.label5.Text = "Mô tả";
            // 
            // txbDescription
            // 
            this.txbDescription.Location = new System.Drawing.Point(129, 108);
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.Size = new System.Drawing.Size(253, 26);
            this.txbDescription.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 178);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Dịch vụ";
            // 
            // RoomManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.grbRoomManagement);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "RoomManagement";
            this.Size = new System.Drawing.Size(1188, 701);
            this.Load += new System.EventHandler(this.RoomManagement_Load);
            this.grbRoomManagement.ResumeLayout(false);
            this.grbRoomManagement.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomBindingSource)).EndInit();
            this.grbRoomInfo.ResumeLayout(false);
            this.grbRoomInfo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbRoomManagement;
        private System.Windows.Forms.Button btnSearchUser;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDeletRoom;
        private System.Windows.Forms.Button btnUpdateRoom;
        private System.Windows.Forms.Button btnSaveRoom;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txbSearch;
        private System.Windows.Forms.GroupBox grbRoomInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbRoomNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource roomBindingSource;
        private System.Windows.Forms.CheckedListBox clbService;
        private System.Windows.Forms.FlowLayoutPanel flpanelImage;
        private System.Windows.Forms.Label label1;
    }
}
