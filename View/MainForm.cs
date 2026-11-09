namespace View
{
    /// <summary>
    /// Provides the main navigation window for the application.
    /// </summary>
    public partial class MainForm : Form
    {
        /// <summary>Indicates whether the navigation menu is expanded.</summary>
        private bool _menuExpanded = true;
        /// <summary>Stores the expanded menu width for subsequent animations.</summary>
        private int _menuWidth;

        /// <summary>
        /// Initializes the main window and its controls.
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
        }

        #region [- Menu -]

        /// <summary>
        /// Toggles the navigation menu between its expanded and collapsed states.
        /// </summary>
        private void btnMenu_Click(object? sender, EventArgs e)
        {
            if (_menuWidth == 0) _menuWidth = pnlMenu.Width;

            _menuExpanded = !_menuExpanded;
            menuTimer.Start();
        }

        /// <summary>
        /// Moves the navigation menu toward its current target width.
        /// </summary>
        private void menuTimer_Tick(object? sender, EventArgs e)
        {
            const int step = 40;
            int target = _menuExpanded ? _menuWidth : 0;

            if (pnlMenu.Width < target)
                pnlMenu.Width = Math.Min(pnlMenu.Width + step, target);
            else if (pnlMenu.Width > target)
                pnlMenu.Width = Math.Max(pnlMenu.Width - step, target);

            if (pnlMenu.Width == target)
                menuTimer.Stop();
        }

        /// <summary>
        /// Opens the product management window.
        /// </summary>
        private void btnMenuProducts_Click(object? sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }

        /// <summary>
        /// Opens the person management window.
        /// </summary>
        private void btnMenuPersons_Click(object? sender, EventArgs e)
        {
            OpenForm(new PersonForm());
        }
        #endregion

        #region [- Helpers -]

        /// <summary>
        /// Displays a child form modally while temporarily hiding the main window.
        /// </summary>
        /// <param name="form">The child form to display.</param>
        private void OpenForm(Form form)
        {
            Hide();
            using (form)
            {
                form.ShowDialog();
            }
            Show();
        }
        #endregion
    }
}