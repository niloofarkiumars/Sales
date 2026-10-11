namespace View
{
    partial class MainForm
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
            pnlHeader = new Panel();
            lblHeader = new Label();
            btnMenu = new Button();
            pnlMenu = new Panel();
            btnMenuPersons = new Button();
            btnMenuProducts = new Button();
            lblMenuTitle = new Label();
            pnlContent = new Panel();
            lblWelcome = new Label();
            lblHint = new Label();
            toolTip1 = new ToolTip(components);
            menuTimer = new System.Windows.Forms.Timer(components);
            pnlHeader.SuspendLayout();
            pnlMenu.SuspendLayout();
            pnlContent.SuspendLayout();
            SuspendLayout();
            // 
            // pnlHeader
            // 
            pnlHeader.BackColor = Color.FromArgb(37, 99, 235);
            pnlHeader.Controls.Add(lblHeader);
            pnlHeader.Controls.Add(btnMenu);
            pnlHeader.Dock = DockStyle.Top;
            pnlHeader.Location = new Point(0, 0);
            pnlHeader.Name = "pnlHeader";
            pnlHeader.Size = new Size(1000, 64);
            pnlHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI Semibold", 16F);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(70, 14);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(120, 37);
            lblHeader.TabIndex = 1;
            lblHeader.Text = "Main Page";
            // 
            // btnMenu
            // 
            btnMenu.BackColor = Color.Transparent;
            btnMenu.Cursor = Cursors.Hand;
            btnMenu.FlatAppearance.BorderSize = 0;
            btnMenu.FlatAppearance.MouseDownBackColor = Color.FromArgb(30, 64, 175);
            btnMenu.FlatAppearance.MouseOverBackColor = Color.FromArgb(29, 78, 216);
            btnMenu.FlatStyle = FlatStyle.Flat;
            btnMenu.Font = new Font("Segoe MDL2 Assets", 14F);
            btnMenu.ForeColor = Color.White;
            btnMenu.Location = new Point(12, 8);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(48, 48);
            btnMenu.TabIndex = 0;
            btnMenu.Text = "\uE700";
            toolTip1.SetToolTip(btnMenu, "Menu");
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btnMenu_Click;
            // 
            // pnlMenu
            // 
            pnlMenu.BackColor = Color.FromArgb(31, 41, 55);
            pnlMenu.Controls.Add(btnMenuPersons);
            pnlMenu.Controls.Add(btnMenuProducts);
            pnlMenu.Controls.Add(lblMenuTitle);
            pnlMenu.Dock = DockStyle.Left;
            pnlMenu.Location = new Point(0, 64);
            pnlMenu.Name = "pnlMenu";
            pnlMenu.Size = new Size(220, 556);
            pnlMenu.TabIndex = 1;
            // 
            // btnMenuPersons
            // 
            btnMenuPersons.BackColor = Color.FromArgb(31, 41, 55);
            btnMenuPersons.Cursor = Cursors.Hand;
            btnMenuPersons.Dock = DockStyle.Top;
            btnMenuPersons.FlatAppearance.BorderSize = 0;
            btnMenuPersons.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 24, 39);
            btnMenuPersons.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnMenuPersons.FlatStyle = FlatStyle.Flat;
            btnMenuPersons.Font = new Font("Segoe UI", 10.5F);
            btnMenuPersons.ForeColor = Color.White;
            btnMenuPersons.Location = new Point(0, 108);
            btnMenuPersons.Name = "btnMenuPersons";
            btnMenuPersons.Padding = new Padding(20, 0, 0, 0);
            btnMenuPersons.Size = new Size(220, 52);
            btnMenuPersons.TabIndex = 2;
            btnMenuPersons.Text = "Persons";
            btnMenuPersons.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuPersons.UseVisualStyleBackColor = false;
            btnMenuPersons.Click += btnMenuPersons_Click;
            // 
            // btnMenuProducts
            // 
            btnMenuProducts.BackColor = Color.FromArgb(31, 41, 55);
            btnMenuProducts.Cursor = Cursors.Hand;
            btnMenuProducts.Dock = DockStyle.Top;
            btnMenuProducts.FlatAppearance.BorderSize = 0;
            btnMenuProducts.FlatAppearance.MouseDownBackColor = Color.FromArgb(17, 24, 39);
            btnMenuProducts.FlatAppearance.MouseOverBackColor = Color.FromArgb(55, 65, 81);
            btnMenuProducts.FlatStyle = FlatStyle.Flat;
            btnMenuProducts.Font = new Font("Segoe UI", 10.5F);
            btnMenuProducts.ForeColor = Color.White;
            btnMenuProducts.Location = new Point(0, 56);
            btnMenuProducts.Name = "btnMenuProducts";
            btnMenuProducts.Padding = new Padding(20, 0, 0, 0);
            btnMenuProducts.Size = new Size(220, 52);
            btnMenuProducts.TabIndex = 1;
            btnMenuProducts.Text = "Products";
            btnMenuProducts.TextAlign = ContentAlignment.MiddleLeft;
            btnMenuProducts.UseVisualStyleBackColor = false;
            btnMenuProducts.Click += btnMenuProducts_Click;
            // 
            // lblMenuTitle
            // 
            lblMenuTitle.Dock = DockStyle.Top;
            lblMenuTitle.Font = new Font("Segoe UI Semibold", 9F);
            lblMenuTitle.ForeColor = Color.FromArgb(156, 163, 175);
            lblMenuTitle.Location = new Point(0, 0);
            lblMenuTitle.Name = "lblMenuTitle";
            lblMenuTitle.Padding = new Padding(20, 0, 0, 0);
            lblMenuTitle.Size = new Size(220, 56);
            lblMenuTitle.TabIndex = 0;
            lblMenuTitle.Text = "MENU";
            lblMenuTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // pnlContent
            // 
            pnlContent.BackColor = Color.FromArgb(243, 244, 246);
            pnlContent.Controls.Add(lblWelcome);
            pnlContent.Controls.Add(lblHint);
            pnlContent.Dock = DockStyle.Fill;
            pnlContent.Location = new Point(220, 64);
            pnlContent.Name = "pnlContent";
            pnlContent.Size = new Size(780, 556);
            pnlContent.TabIndex = 0;
            // 
            // lblWelcome
            // 
            lblWelcome.Dock = DockStyle.Fill;
            lblWelcome.Font = new Font("Segoe UI Semibold", 28F);
            lblWelcome.ForeColor = Color.FromArgb(31, 41, 55);
            lblWelcome.Location = new Point(0, 0);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(780, 506);
            lblWelcome.TabIndex = 0;
            lblWelcome.Text = "Welcome";
            lblWelcome.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblHint
            // 
            lblHint.Dock = DockStyle.Bottom;
            lblHint.ForeColor = Color.FromArgb(107, 114, 128);
            lblHint.Location = new Point(0, 506);
            lblHint.Name = "lblHint";
            lblHint.Size = new Size(780, 50);
            lblHint.TabIndex = 1;
            lblHint.Text = "Use the menu button (top left) to open Products or Persons.";
            lblHint.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // menuTimer
            // 
            menuTimer.Interval = 10;
            menuTimer.Tick += menuTimer_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 620);
            Controls.Add(pnlContent);
            Controls.Add(pnlMenu);
            Controls.Add(pnlHeader);
            MinimumSize = new Size(760, 480);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Main Page";
            pnlHeader.ResumeLayout(false);
            pnlHeader.PerformLayout();
            pnlMenu.ResumeLayout(false);
            pnlContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlHeader;
        private Label lblHeader;
        private Button btnMenu;
        private Panel pnlMenu;
        private Label lblMenuTitle;
        private Button btnMenuProducts;
        private Button btnMenuPersons;
        private Panel pnlContent;
        private Label lblWelcome;
        private Label lblHint;
        private ToolTip toolTip1;
        private System.Windows.Forms.Timer menuTimer;
    }
}