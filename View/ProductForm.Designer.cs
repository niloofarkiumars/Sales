namespace View
{
    partial class ProductForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            pnlHeader = new Panel();
            btnRefresh = new Button();
            lblHeader = new Label();
            btnBack = new Button();
            pnlBody = new Panel();
            dgvProduct = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colCode = new DataGridViewTextBoxColumn();
            colTitle = new DataGridViewTextBoxColumn();
            colUnitPrice = new DataGridViewTextBoxColumn();
            colQuantity = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlSpacer = new Panel();
            pnlInput = new Panel();
            btnSave = new Button();
            txtQuantity = new TextBox();
            txtUnitPrice = new TextBox();
            txtTitle = new TextBox();
            txtCode = new TextBox();
            lblQuantity = new Label();
            lblUnitPrice = new Label();
            lblProductTitle = new Label();
            lblCode = new Label();
            toolTip1 = new ToolTip(components);
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvProduct).BeginInit();
            pnlInput.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(37, 99, 235);
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(btnBack);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(900, 64);
            pnlHeader.TabIndex = 1;
            // 
            // btnRefresh
            // 
            btnRefresh.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnRefresh.BackColor = Color.Transparent;
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderSize = 0;
            btnRefresh.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btnRefresh.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe MDL2 Assets", 14F);
            btnRefresh.ForeColor = Color.White;
            btnRefresh.Location = new Point(840, 8);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(48, 48);
            btnRefresh.TabIndex = 2;
            btnRefresh.Text = "\uE72C";
            toolTip1.SetToolTip(btnRefresh, "Refresh");
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(70, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(112, 37);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Products";
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.Transparent;
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderSize = 0;
            btnBack.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btnBack.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe MDL2 Assets", 14F);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 8);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(48, 48);
            btnBack.TabIndex = 0;
            btnBack.Text = "\uE72B";
            toolTip1.SetToolTip(btnBack, "Back");
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(243, 244, 246);
            pnlBody.Controls.Add(dgvProduct);
            pnlBody.Controls.Add(pnlSpacer);
            pnlBody.Controls.Add(pnlInput);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 64);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20);
            pnlBody.Size = new Size(900, 536);
            pnlBody.TabIndex = 0;
            // 
            // dgvProduct
            // 
            dgvProduct.AllowUserToAddRows = false;
            dgvProduct.AllowUserToDeleteRows = false;
            dgvProduct.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 250, 251);
            dgvProduct.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvProduct.BackgroundColor = Color.White;
            dgvProduct.BorderStyle = BorderStyle.None;
            dgvProduct.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvProduct.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvProduct.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvProduct.ColumnHeadersHeight = 42;
            dgvProduct.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvProduct.Columns.AddRange(new DataGridViewColumn[] { colId, colCode, colTitle, colUnitPrice, colQuantity, colEdit, colDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvProduct.DefaultCellStyle = dataGridViewCellStyle3;
            dgvProduct.Dock = DockStyle.Fill;
            dgvProduct.EnableHeadersVisualStyles = false;
            dgvProduct.GridColor = Color.FromArgb(229, 231, 235);
            dgvProduct.Location = new Point(20, 146);
            dgvProduct.MultiSelect = false;
            dgvProduct.Name = "dgvProduct";
            dgvProduct.ReadOnly = true;
            dgvProduct.RowHeadersVisible = false;
            dgvProduct.RowHeadersWidth = 51;
            dgvProduct.RowTemplate.Height = 40;
            dgvProduct.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvProduct.Size = new Size(860, 370);
            dgvProduct.TabIndex = 2;
            dgvProduct.CellClick += dgvProduct_CellClick;
            dgvProduct.CellMouseEnter += dgvProduct_CellMouseEnter;
            dgvProduct.CellMouseLeave += dgvProduct_CellMouseLeave;
            dgvProduct.CellPainting += dgvProduct_CellPainting;
            dgvProduct.DataBindingComplete += dgvProduct_DataBindingComplete;
            // 
            // colId
            // 
            colId.DataPropertyName = "Id";
            colId.HeaderText = "Id";
            colId.MinimumWidth = 6;
            colId.Name = "colId";
            colId.ReadOnly = true;
            colId.Visible = false;
            // 
            // colCode
            // 
            colCode.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colCode.DataPropertyName = "Code";
            colCode.FillWeight = 100F;
            colCode.HeaderText = "Code";
            colCode.MinimumWidth = 6;
            colCode.Name = "colCode";
            colCode.ReadOnly = true;
            // 
            // colTitle
            // 
            colTitle.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colTitle.DataPropertyName = "Title";
            colTitle.FillWeight = 200F;
            colTitle.HeaderText = "Title";
            colTitle.MinimumWidth = 6;
            colTitle.Name = "colTitle";
            colTitle.ReadOnly = true;
            // 
            // colUnitPrice
            // 
            colUnitPrice.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colUnitPrice.DataPropertyName = "UnitPrice";
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            colUnitPrice.DefaultCellStyle = dataGridViewCellStyle4;
            colUnitPrice.FillWeight = 100F;
            colUnitPrice.HeaderText = "Unit Price";
            colUnitPrice.MinimumWidth = 6;
            colUnitPrice.Name = "colUnitPrice";
            colUnitPrice.ReadOnly = true;
            // 
            // colQuantity
            // 
            colQuantity.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colQuantity.DataPropertyName = "Quantity";
            colQuantity.FillWeight = 80F;
            colQuantity.HeaderText = "Quantity";
            colQuantity.MinimumWidth = 6;
            colQuantity.Name = "colQuantity";
            colQuantity.ReadOnly = true;
            // 
            // colEdit
            // 
            colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colEdit.HeaderText = "";
            colEdit.MinimumWidth = 6;
            colEdit.Name = "colEdit";
            colEdit.ReadOnly = true;
            colEdit.Resizable = DataGridViewTriState.False;
            colEdit.Width = 60;
            // 
            // colDelete
            // 
            colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            colDelete.HeaderText = "";
            colDelete.MinimumWidth = 6;
            colDelete.Name = "colDelete";
            colDelete.ReadOnly = true;
            colDelete.Resizable = DataGridViewTriState.False;
            colDelete.Width = 60;
            // 
            // pnlSpacer
            // 
            pnlSpacer.BackColor = Color.FromArgb(243, 244, 246);
            pnlSpacer.Dock = DockStyle.Top;
            pnlSpacer.Location = new Point(20, 130);
            pnlSpacer.Name = "pnlSpacer";
            pnlSpacer.Size = new Size(860, 16);
            pnlSpacer.TabIndex = 1;
            // 
            // pnlInput
            // 
            pnlInput.BackColor = Color.White;
            pnlInput.Controls.Add(btnSave);
            pnlInput.Controls.Add(txtQuantity);
            pnlInput.Controls.Add(txtUnitPrice);
            pnlInput.Controls.Add(txtTitle);
            pnlInput.Controls.Add(txtCode);
            pnlInput.Controls.Add(lblQuantity);
            pnlInput.Controls.Add(lblUnitPrice);
            pnlInput.Controls.Add(lblProductTitle);
            pnlInput.Controls.Add(lblCode);
            pnlInput.Dock = DockStyle.Top;
            pnlInput.Location = new Point(20, 20);
            pnlInput.Name = "pnlInput";
            pnlInput.Size = new Size(860, 110);
            pnlInput.TabIndex = 0;
            // 
            // btnSave
            // 
            btnSave.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnSave.BackColor = Color.FromArgb(22, 163, 74);
            btnSave.Cursor = Cursors.Hand;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatAppearance.MouseOverBackColor = Color.FromArgb(21, 128, 61);
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.ForeColor = Color.White;
            btnSave.Location = new Point(740, 43);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(100, 33);
            btnSave.TabIndex = 8;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtQuantity
            // 
            txtQuantity.BorderStyle = BorderStyle.FixedSingle;
            txtQuantity.Location = new Point(570, 46);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(130, 27);
            txtQuantity.TabIndex = 7;
            // 
            // txtUnitPrice
            // 
            txtUnitPrice.BorderStyle = BorderStyle.FixedSingle;
            txtUnitPrice.Location = new Point(420, 46);
            txtUnitPrice.Name = "txtUnitPrice";
            txtUnitPrice.Size = new Size(130, 27);
            txtUnitPrice.TabIndex = 6;
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Location = new Point(180, 46);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(220, 27);
            txtTitle.TabIndex = 5;
            // 
            // txtCode
            // 
            txtCode.BorderStyle = BorderStyle.FixedSingle;
            txtCode.Location = new Point(20, 46);
            txtCode.Name = "txtCode";
            txtCode.Size = new Size(140, 27);
            txtCode.TabIndex = 4;
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.ForeColor = Color.FromArgb(107, 114, 128);
            lblQuantity.Location = new Point(570, 18);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(66, 20);
            lblQuantity.TabIndex = 3;
            lblQuantity.Text = "Quantity";
            // 
            // lblUnitPrice
            // 
            lblUnitPrice.AutoSize = true;
            lblUnitPrice.ForeColor = Color.FromArgb(107, 114, 128);
            lblUnitPrice.Location = new Point(420, 18);
            lblUnitPrice.Name = "lblUnitPrice";
            lblUnitPrice.Size = new Size(76, 20);
            lblUnitPrice.TabIndex = 2;
            lblUnitPrice.Text = "Unit Price";
            // 
            // lblProductTitle
            // 
            lblProductTitle.AutoSize = true;
            lblProductTitle.ForeColor = Color.FromArgb(107, 114, 128);
            lblProductTitle.Location = new Point(180, 18);
            lblProductTitle.Name = "lblProductTitle";
            lblProductTitle.Size = new Size(38, 20);
            lblProductTitle.TabIndex = 1;
            lblProductTitle.Text = "Title";
            // 
            // lblCode
            // 
            lblCode.AutoSize = true;
            lblCode.ForeColor = Color.FromArgb(107, 114, 128);
            lblCode.Location = new Point(20, 18);
            lblCode.Name = "lblCode";
            lblCode.Size = new Size(23, 20);
            lblCode.TabIndex = 0;
            lblCode.Text = "Code";
            // 
            // ProductForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(900, 600);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(760, 480);
            Name = "ProductForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Products";
            Load += ProductForm_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvProduct).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnBack;
        private Label lblHeader;
        private Button btnRefresh;
        private Panel pnlBody;
        private Panel pnlSpacer;
        private Panel pnlInput;
        private Label lblCode;
        private Label lblProductTitle;
        private Label lblUnitPrice;
        private Label lblQuantity;
        private TextBox txtCode;
        private TextBox txtTitle;
        private TextBox txtUnitPrice;
        private TextBox txtQuantity;
        private Button btnSave;
        private DataGridView dgvProduct;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colCode;
        private DataGridViewTextBoxColumn colTitle;
        private DataGridViewTextBoxColumn colUnitPrice;
        private DataGridViewTextBoxColumn colQuantity;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private ToolTip toolTip1;
    }
}