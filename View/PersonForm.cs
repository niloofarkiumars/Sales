
using ApplicationService.Dtos.Person;
using ApplicationService.Services;
using View.Helpers;

namespace View
{
    /// <summary>
    /// Provides the user interface for creating, editing, viewing, and deleting people.
    /// </summary>
    public partial class PersonForm : Form
    {
        /// <summary>Application service used to persist person data.</summary>
        private readonly PersonServiceApplication _personApplicationService;

        /// <summary>Contains the identifier of the person being edited, or null for a new person.</summary>
        private int? _editingId;

        /// <summary>Color used for edit actions in the data grid.</summary>
        private static readonly Color EditColor = Color.FromArgb(37, 99, 235);
        /// <summary>Color used for delete actions in the data grid.</summary>
        private static readonly Color DeleteColor = Color.FromArgb(220, 38, 38);

        /// <summary>
        /// Initializes the person form, input validation, and data grid behavior.
        /// </summary>
        public PersonForm()
        {
            InitializeComponent();
            txtNationalId.KeyPress +=InputValidationHelper.AllowDigitsOnly;
            txtFirstName.KeyPress += InputValidationHelper.AllowLettersSpacesAndDots;
            txtLastName.KeyPress += InputValidationHelper.AllowLettersSpacesAndDots;
            dgvPerson.AutoGenerateColumns = false;
            _personApplicationService = new PersonServiceApplication();
        }

        /// <summary>Loads people when the form is displayed.</summary>
        private void Form1_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        #region [- Buttons -]

        /// <summary>Closes the form and returns to the main window.</summary>
        private void btnBack_Click(object? sender, EventArgs e)
        {
            Close(); // later this returns to the main page
        }

        /// <summary>Clears the current input and reloads people.</summary>
        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        /// <summary>Validates and saves a new person or updates the selected person.</summary>
        private void btnSave_Click(object? sender, EventArgs e)
        {
            var nationalId = txtNationalId.Text;
            var firstName = txtFirstName.Text.Trim();
            var lastName = txtLastName.Text.Trim();

            if (nationalId.Length == 0 || firstName.Length == 0 || lastName.Length == 0)
            {
                MessageBox.Show("Please fill in all three fields.", "Missing data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (_editingId is int id)
                {
                    var putPersonDto = new PutPersonDto
                    {
                        NationalId = nationalId,
                        FirstName = firstName,
                        LastName = lastName
                    };
                    _personApplicationService.Put(id, putPersonDto);
                    MessageBox.Show("Person updated successfully.");
                }
                else
                {
                    var postPersonDto = new PostPersonDto
                    {
                        NationalId = nationalId,
                        FirstName = firstName,
                        LastName = lastName
                    };
                    _personApplicationService.Post(postPersonDto);
                    MessageBox.Show("Person saved successfully.");
                }

                ClearInputs();
                LoadData();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }
        #endregion

        #region [- Grid -]

        /// <summary>Starts editing or deletion when an action cell is clicked.</summary>
        private void dgvPerson_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvPerson.Rows[e.RowIndex].DataBoundItem is not GetPersonDto person) return;

            if (e.ColumnIndex == colEdit.Index) StartEdit(person);
            else if (e.ColumnIndex == colDelete.Index) DeletePerson(person);
        }

        /// <summary>Draws edit and delete icons inside the corresponding grid cells.</summary>
        private void dgvPerson_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            bool isEdit = e.ColumnIndex == colEdit.Index;
            bool isDelete = e.ColumnIndex == colDelete.Index;
            if (!isEdit && !isDelete) return;

            e.Paint(e.CellBounds, DataGridViewPaintParts.Background
                                | DataGridViewPaintParts.Border
                                | DataGridViewPaintParts.SelectionBackground);

            using var font = new Font("Segoe MDL2 Assets", 12F);
            TextRenderer.DrawText(e.Graphics!, isEdit ? "\uE70F" : "\uE74D", font, e.CellBounds,
                isEdit ? EditColor : DeleteColor,
                TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter | TextFormatFlags.NoPadding);

            e.Handled = true;
        }

        /// <summary>Displays a hand cursor when the pointer enters an action cell.</summary>
        private void dgvPerson_CellMouseEnter(object? sender, DataGridViewCellEventArgs e)
        {
            bool isAction = e.RowIndex >= 0 &&
                            (e.ColumnIndex == colEdit.Index || e.ColumnIndex == colDelete.Index);
            dgvPerson.Cursor = isAction ? Cursors.Hand : Cursors.Default;
        }

        /// <summary>Restores the default cursor when the pointer leaves a grid cell.</summary>
        private void dgvPerson_CellMouseLeave(object? sender, DataGridViewCellEventArgs e)
        {
            dgvPerson.Cursor = Cursors.Default;
        }

        /// <summary>Applies action tooltips and clears the grid selection after binding.</summary>
        private void dgvPerson_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvPerson.Rows)
            {
                row.Cells[colEdit.Index].ToolTipText = "Edit";
                row.Cells[colDelete.Index].ToolTipText = "Delete";
            }
            dgvPerson.ClearSelection();
        }
        #endregion

        #region [- Helpers -]

        /// <summary>Loads all people into the data grid.</summary>
        private void LoadData()
        {
            try
            {
                dgvPerson.DataSource = _personApplicationService.GetAll();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        /// <summary>Copies a person's values into the input controls for editing.</summary>
        /// <param name="person">The person selected for editing.</param>
        private void StartEdit(GetPersonDto person)
        {
            _editingId = person.Id;
            txtNationalId.Text = person.NationalId;
            txtFirstName.Text = person.FirstName;
            txtLastName.Text = person.LastName;
            btnSave.Text = "Update";
            txtNationalId.Focus();
        }

        /// <summary>Confirms and deletes a person.</summary>
        /// <param name="person">The person selected for deletion.</param>
        private void DeletePerson(GetPersonDto person)
        {
            var answer = MessageBox.Show($"Delete {person.FirstName} {person.LastName}?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            try
            {
                var deletePersonDto = new DeletePersonDto { Id = person.Id };
                _personApplicationService.Delete(deletePersonDto);
                if (_editingId == person.Id) ClearInputs();
                LoadData();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        /// <summary>Resets the form to new-person entry mode.</summary>
        private void ClearInputs()
        {
            _editingId = null;
            txtNationalId.Clear();
            txtFirstName.Clear();
            txtLastName.Clear();
            btnSave.Text = "Save";
        }

        /// <summary>Displays an exception message and its base exception message.</summary>
        /// <param name="ex">The exception to display.</param>
        private static void ShowError(Exception ex)
        {
            var baseMessage = ex.GetBaseException().Message;
            var message = ex.Message == baseMessage
                ? baseMessage
                : ex.Message + Environment.NewLine + Environment.NewLine + baseMessage;

            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}