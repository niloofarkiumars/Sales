namespace View
{
    public partial class MainForm : Form
    {
        private bool _menuExpanded = true;
        private int _menuWidth;   // remembered the first time the menu is toggled

        public MainForm()
        {
            InitializeComponent();
        }

        #region [- Menu -]

        private void btnMenu_Click(object? sender, EventArgs e)
        {
            if (_menuWidth == 0) _menuWidth = pnlMenu.Width;

            _menuExpanded = !_menuExpanded;
            menuTimer.Start();
        }

        // Slides the side menu open / closed
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

        private void btnMenuProducts_Click(object? sender, EventArgs e)
        {
            OpenForm(new ProductForm());
        }

        private void btnMenuPersons_Click(object? sender, EventArgs e)
        {
            OpenForm(new PersonForm());
        }
        #endregion

        #region [- Helpers -]

        // Hides the main page while the form is open; its Back button closes it and we return here
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