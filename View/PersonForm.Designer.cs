namespace View
{
    partial class PersonForm
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
            pnlHeader = new Panel();
            btnRefresh = new Button();
            lblTitle = new Label();
            btnBack = new Button();
            pnlBody = new Panel();
            dgvPerson = new DataGridView();
            colId = new DataGridViewTextBoxColumn();
            colNationalId = new DataGridViewTextBoxColumn();
            colFirstName = new DataGridViewTextBoxColumn();
            colLastName = new DataGridViewTextBoxColumn();
            colEdit = new DataGridViewButtonColumn();
            colDelete = new DataGridViewButtonColumn();
            pnlSpacer = new Panel();
            pnlInput = new Panel();
            btnSave = new Button();
            txtLastName = new TextBox();
            txtFirstName = new TextBox();
            txtNationalId = new TextBox();
            lblLastName = new Label();
            lblFirstName = new Label();
            lblNationalId = new Label();
            toolTip1 = new ToolTip(components);
            pnlHeader.SuspendLayout();
            pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPerson).BeginInit();
            pnlInput.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(37, 99, 235);
            pnlHeader.Controls.Add(btnRefresh);
            pnlHeader.Controls.Add(lblTitle);
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
            btnRefresh.Text = "";
            toolTip1.SetToolTip(btnRefresh, "Refresh");
            btnRefresh.UseVisualStyleBackColor = false;
            btnRefresh.Click += btnRefresh_Click;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI Semibold", 16F);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(70, 14);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 37);
            lblTitle.TabIndex = 1;
            lblTitle.Text = "Persons";
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
            btnBack.Text = "";
            toolTip1.SetToolTip(btnBack, "Back");
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // pnlBody
            // 
            pnlBody.BackColor = Color.FromArgb(243, 244, 246);
            pnlBody.Controls.Add(dgvPerson);
            pnlBody.Controls.Add(pnlSpacer);
            pnlBody.Controls.Add(pnlInput);
            pnlBody.Dock = DockStyle.Fill;
            pnlBody.Location = new Point(0, 64);
            pnlBody.Name = "pnlBody";
            pnlBody.Padding = new Padding(20);
            pnlBody.Size = new Size(900, 536);
            pnlBody.TabIndex = 0;
            // 
            // dgvPerson
            // 
            dgvPerson.AllowUserToAddRows = false;
            dgvPerson.AllowUserToDeleteRows = false;
            dgvPerson.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(249, 250, 251);
            dgvPerson.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgvPerson.BackgroundColor = Color.White;
            dgvPerson.BorderStyle = BorderStyle.None;
            dgvPerson.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvPerson.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 10F);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle2.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(249, 250, 251);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(107, 114, 128);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvPerson.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgvPerson.ColumnHeadersHeight = 42;
            dgvPerson.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgvPerson.Columns.AddRange(new DataGridViewColumn[] { colId, colNationalId, colFirstName, colLastName, colEdit, colDelete });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.White;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.Padding = new Padding(8, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(219, 234, 254);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(31, 41, 55);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgvPerson.DefaultCellStyle = dataGridViewCellStyle3;
            dgvPerson.Dock = DockStyle.Fill;
            dgvPerson.EnableHeadersVisualStyles = false;
            dgvPerson.GridColor = Color.FromArgb(229, 231, 235);
            dgvPerson.Location = new Point(20, 146);
            dgvPerson.MultiSelect = false;
            dgvPerson.Name = "dgvPerson";
            dgvPerson.ReadOnly = true;
            dgvPerson.RowHeadersVisible = false;
            dgvPerson.RowHeadersWidth = 51;
            dgvPerson.RowTemplate.Height = 40;
            dgvPerson.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvPerson.Size = new Size(860, 370);
            dgvPerson.TabIndex = 2;
            dgvPerson.CellClick += dgvPerson_CellClick;
            dgvPerson.CellMouseEnter += dgvPerson_CellMouseEnter;
            dgvPerson.CellMouseLeave += dgvPerson_CellMouseLeave;
            dgvPerson.CellPainting += dgvPerson_CellPainting;
            dgvPerson.DataBindingComplete += dgvPerson_DataBindingComplete;
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
            // colNationalId
            // 
            colNationalId.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colNationalId.DataPropertyName = "NationalId";
            colNationalId.HeaderText = "National ID";
            colNationalId.MinimumWidth = 6;
            colNationalId.Name = "colNationalId";
            colNationalId.ReadOnly = true;
            // 
            // colFirstName
            // 
            colFirstName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colFirstName.DataPropertyName = "FirstName";
            colFirstName.HeaderText = "First Name";
            colFirstName.MinimumWidth = 6;
            colFirstName.Name = "colFirstName";
            colFirstName.ReadOnly = true;
            // 
            // colLastName
            // 
            colLastName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            colLastName.DataPropertyName = "LastName";
            colLastName.HeaderText = "Last Name";
            colLastName.MinimumWidth = 6;
            colLastName.Name = "colLastName";
            colLastName.ReadOnly = true;
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
            pnlInput.Controls.Add(txtLastName);
            pnlInput.Controls.Add(txtFirstName);
            pnlInput.Controls.Add(txtNationalId);
            pnlInput.Controls.Add(lblLastName);
            pnlInput.Controls.Add(lblFirstName);
            pnlInput.Controls.Add(lblNationalId);
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
            btnSave.TabIndex = 6;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtLastName
            // 
            txtLastName.BorderStyle = BorderStyle.FixedSingle;
            txtLastName.Location = new Point(500, 46);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(220, 27);
            txtLastName.TabIndex = 5;
            // 
            // txtFirstName
            // 
            txtFirstName.BorderStyle = BorderStyle.FixedSingle;
            txtFirstName.Location = new Point(260, 46);
            txtFirstName.Name = "txtFirstName";
            txtFirstName.Size = new Size(220, 27);
            txtFirstName.TabIndex = 4;
            // 
            // txtNationalId
            // 
            txtNationalId.BorderStyle = BorderStyle.FixedSingle;
            txtNationalId.Location = new Point(20, 46);
            txtNationalId.Name = "txtNationalId";
            txtNationalId.Size = new Size(220, 27);
            txtNationalId.TabIndex = 3;
            // 
            // lblLastName
            // 
            lblLastName.AutoSize = true;
            lblLastName.ForeColor = Color.FromArgb(107, 114, 128);
            lblLastName.Location = new Point(500, 18);
            lblLastName.Name = "lblLastName";
            lblLastName.Size = new Size(79, 20);
            lblLastName.TabIndex = 2;
            lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.ForeColor = Color.FromArgb(107, 114, 128);
            lblFirstName.Location = new Point(260, 18);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(80, 20);
            lblFirstName.TabIndex = 1;
            lblFirstName.Text = "First Name";
            // 
            // lblNationalId
            // 
            lblNationalId.AutoSize = true;
            lblNationalId.ForeColor = Color.FromArgb(107, 114, 128);
            lblNationalId.Location = new Point(20, 18);
            lblNationalId.Name = "lblNationalId";
            lblNationalId.Size = new Size(85, 20);
            lblNationalId.TabIndex = 0;
            lblNationalId.Text = "National ID";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(243, 244, 246);
            ClientSize = new Size(900, 600);
            Controls.Add(pnlBody);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(760, 480);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Persons";
            Load += Form1_Load;
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPerson).EndInit();
            pnlInput.ResumeLayout(false);
            pnlInput.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Button btnBack;
        private Label lblTitle;
        private Button btnRefresh;
        private Panel pnlBody;
        private Panel pnlSpacer;
        private Panel pnlInput;
        private Label lblNationalId;
        private Label lblFirstName;
        private Label lblLastName;
        private TextBox txtNationalId;
        private TextBox txtFirstName;
        private TextBox txtLastName;
        private Button btnSave;
        private DataGridView dgvPerson;
        private DataGridViewTextBoxColumn colId;
        private DataGridViewTextBoxColumn colNationalId;
        private DataGridViewTextBoxColumn colFirstName;
        private DataGridViewTextBoxColumn colLastName;
        private DataGridViewButtonColumn colEdit;
        private DataGridViewButtonColumn colDelete;
        private ToolTip toolTip1;
    }
}