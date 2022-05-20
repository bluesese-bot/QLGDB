namespace QLGDB.Controller
{
    partial class fr_Themgiaidau
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fr_Themgiaidau));
            this.txt_mamua = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.time_thoigianketthuc = new System.Windows.Forms.DateTimePicker();
            this.txt_tenmua = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.time_thoigianbatdau = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.button_them = new System.Windows.Forms.Button();
            this.button_ok = new System.Windows.Forms.Button();
            this.button_xoa = new System.Windows.Forms.Button();
            this.button_sua = new System.Windows.Forms.Button();
            this.button_huy = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.msds = new ADGV.AdvancedDataGridView();
            this.tableLayoutPanel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msds)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_mamua
            // 
            this.txt_mamua.Location = new System.Drawing.Point(20, 7);
            this.txt_mamua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_mamua.Name = "txt_mamua";
            this.txt_mamua.Size = new System.Drawing.Size(132, 22);
            this.txt_mamua.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(790, 54);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Thời Gian Kết Thúc:";
            // 
            // time_thoigianketthuc
            // 
            this.time_thoigianketthuc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.time_thoigianketthuc.CustomFormat = "dd/MM/yyyy ";
            this.time_thoigianketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_thoigianketthuc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.time_thoigianketthuc.Location = new System.Drawing.Point(921, 51);
            this.time_thoigianketthuc.Margin = new System.Windows.Forms.Padding(4);
            this.time_thoigianketthuc.Name = "time_thoigianketthuc";
            this.time_thoigianketthuc.Size = new System.Drawing.Size(209, 22);
            this.time_thoigianketthuc.TabIndex = 10;
            this.time_thoigianketthuc.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // txt_tenmua
            // 
            this.txt_tenmua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_tenmua.Location = new System.Drawing.Point(165, 51);
            this.txt_tenmua.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tenmua.Name = "txt_tenmua";
            this.txt_tenmua.Size = new System.Drawing.Size(209, 22);
            this.txt_tenmua.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 54);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời Gian Bắt Đầu:";
            // 
            // time_thoigianbatdau
            // 
            this.time_thoigianbatdau.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.time_thoigianbatdau.CustomFormat = "dd/MM/yyyy";
            this.time_thoigianbatdau.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.time_thoigianbatdau.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.time_thoigianbatdau.Location = new System.Drawing.Point(543, 51);
            this.time_thoigianbatdau.Margin = new System.Windows.Forms.Padding(4);
            this.time_thoigianbatdau.Name = "time_thoigianbatdau";
            this.time_thoigianbatdau.Size = new System.Drawing.Size(209, 22);
            this.time_thoigianbatdau.TabIndex = 8;
            this.time_thoigianbatdau.Value = new System.DateTime(2022, 5, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Mùa Giải:";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel3.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 116F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(153, 116);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.tableLayoutPanel3);
            this.panel2.Controls.Add(this.txt_mamua);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(4, 4);
            this.panel2.Margin = new System.Windows.Forms.Padding(4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(153, 116);
            this.panel2.TabIndex = 11;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 7;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.60544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.60544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.60544F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.36735F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 4.081633F));
            this.tableLayoutPanel2.Controls.Add(this.label3, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.time_thoigianketthuc, 5, 0);
            this.tableLayoutPanel2.Controls.Add(this.txt_tenmua, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.time_thoigianbatdau, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(4, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1186, 124);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.msds, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 22.31544F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.7651F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 63.08725F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1194, 596);
            this.tableLayoutPanel1.TabIndex = 0;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 5;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel4.Controls.Add(this.button_them, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_ok, 3, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_xoa, 2, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_sua, 1, 0);
            this.tableLayoutPanel4.Controls.Add(this.button_huy, 4, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 135);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(1188, 81);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // button_them
            // 
            this.button_them.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_them.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_them.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_them.Image = ((System.Drawing.Image)(resources.GetObject("button_them.Image")));
            this.button_them.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_them.Location = new System.Drawing.Point(4, 7);
            this.button_them.Margin = new System.Windows.Forms.Padding(4);
            this.button_them.Name = "button_them";
            this.button_them.Size = new System.Drawing.Size(229, 67);
            this.button_them.TabIndex = 21;
            this.button_them.Text = "Thêm";
            this.button_them.UseVisualStyleBackColor = false;
            this.button_them.Click += new System.EventHandler(this.button_them_Click);
            // 
            // button_ok
            // 
            this.button_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_ok.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_ok.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_ok.Image = ((System.Drawing.Image)(resources.GetObject("button_ok.Image")));
            this.button_ok.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_ok.Location = new System.Drawing.Point(715, 7);
            this.button_ok.Margin = new System.Windows.Forms.Padding(4);
            this.button_ok.Name = "button_ok";
            this.button_ok.Size = new System.Drawing.Size(229, 67);
            this.button_ok.TabIndex = 24;
            this.button_ok.Text = "Xác Nhận";
            this.button_ok.UseVisualStyleBackColor = false;
            this.button_ok.Click += new System.EventHandler(this.button_ok_Click);
            // 
            // button_xoa
            // 
            this.button_xoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_xoa.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_xoa.Image = ((System.Drawing.Image)(resources.GetObject("button_xoa.Image")));
            this.button_xoa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_xoa.Location = new System.Drawing.Point(478, 7);
            this.button_xoa.Margin = new System.Windows.Forms.Padding(4);
            this.button_xoa.Name = "button_xoa";
            this.button_xoa.Size = new System.Drawing.Size(229, 67);
            this.button_xoa.TabIndex = 23;
            this.button_xoa.Text = "Xóa";
            this.button_xoa.UseVisualStyleBackColor = false;
            this.button_xoa.Click += new System.EventHandler(this.button_xoa_Click);
            // 
            // button_sua
            // 
            this.button_sua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_sua.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_sua.Image = ((System.Drawing.Image)(resources.GetObject("button_sua.Image")));
            this.button_sua.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_sua.Location = new System.Drawing.Point(241, 7);
            this.button_sua.Margin = new System.Windows.Forms.Padding(4);
            this.button_sua.Name = "button_sua";
            this.button_sua.Size = new System.Drawing.Size(229, 67);
            this.button_sua.TabIndex = 22;
            this.button_sua.Text = "Sửa";
            this.button_sua.UseVisualStyleBackColor = false;
            this.button_sua.Click += new System.EventHandler(this.button_sua_Click);
            // 
            // button_huy
            // 
            this.button_huy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.button_huy.BackColor = System.Drawing.Color.DarkTurquoise;
            this.button_huy.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_huy.Image = ((System.Drawing.Image)(resources.GetObject("button_huy.Image")));
            this.button_huy.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_huy.Location = new System.Drawing.Point(952, 7);
            this.button_huy.Margin = new System.Windows.Forms.Padding(4);
            this.button_huy.Name = "button_huy";
            this.button_huy.Size = new System.Drawing.Size(232, 67);
            this.button_huy.TabIndex = 25;
            this.button_huy.Text = "Hủy";
            this.button_huy.UseVisualStyleBackColor = false;
            this.button_huy.Click += new System.EventHandler(this.button_huy_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1194, 596);
            this.panel1.TabIndex = 2;
            // 
            // msds
            // 
            this.msds.AutoGenerateContextFilters = true;
            this.msds.BackgroundColor = System.Drawing.Color.White;
            this.msds.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.msds.DateWithTime = false;
            this.msds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.msds.Location = new System.Drawing.Point(3, 222);
            this.msds.Name = "msds";
            this.msds.RowHeadersWidth = 51;
            this.msds.RowTemplate.Height = 24;
            this.msds.Size = new System.Drawing.Size(1188, 371);
            this.msds.TabIndex = 2;
            this.msds.TimeFilter = false;
            this.msds.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.msds_CellClick);
            // 
            // fr_Themgiaidau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1194, 596);
            this.Controls.Add(this.panel1);
            this.Name = "fr_Themgiaidau";
            this.Text = "fr_Themgiaidau";
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.msds)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txt_mamua;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker time_thoigianketthuc;
        private System.Windows.Forms.TextBox txt_tenmua;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker time_thoigianbatdau;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.Button button_them;
        private System.Windows.Forms.Button button_ok;
        private System.Windows.Forms.Button button_xoa;
        private System.Windows.Forms.Button button_sua;
        private System.Windows.Forms.Button button_huy;
        private ADGV.AdvancedDataGridView msds;
    }
}