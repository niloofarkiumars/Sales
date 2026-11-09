using ApplicationService.Dtos.Product;
using ApplicationService.Services;
using View.Helpers;
using System.Globalization;

namespace View
{
    /// <summary>
    /// Provides the user interface for creating, editing, viewing, and deleting products.
    /// </summary>
    public partial class ProductForm : Form
    {
        /// <summary>Application service used to persist product data.</summary>
        private readonly ProductServiceApplication _productServiceApplication;

        /// <summary>Contains the identifier of the product being edited, or null for a new product.</summary>
        private int? _editingId;

        /// <summary>Color used for edit actions in the data grid.</summary>
        private static readonly Color EditColor = Color.FromArgb(37, 99, 235);
        /// <summary>Color used for delete actions in the data grid.</summary>
        private static readonly Color DeleteColor = Color.FromArgb(220, 38, 38);

        /// <summary>
        /// Initializes the product form, input validation, and data grid behavior.
        /// </summary>
        public ProductForm()
        {
            InitializeComponent();
            txtQuantity.KeyPress += InputValidationHelper.AllowDigitsOnly;
            txtUnitPrice.KeyPress += InputValidationHelper.AllowDecimal;
            dgvProduct.AutoGenerateColumns = false;
            _productServiceApplication = new ProductServiceApplication();
        }

        /// <summary>Loads products when the form is displayed.</summary>
        private void ProductForm_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        #region [- Buttons -]

        /// <summary>Closes the form and returns to the main window.</summary>
        private void btnBack_Click(object? sender, EventArgs e)
        {
            Close(); // later this returns to the main page
        }

        /// <summary>Clears the current input and reloads products.</summary>
        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

        /// <summary>Validates and saves a new product or updates the selected product.</summary>
        private void btnSave_Click(object? sender, EventArgs e)
        {
            var code = txtCode.Text.Trim();
            var title = txtTitle.Text.Trim();

            if (code.Length == 0 || title.Length == 0)
            {
                MessageBox.Show("Please enter the code and the title.", "Missing data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse( txtUnitPrice.Text.Trim(), NumberStyles.AllowDecimalPoint,CultureInfo.CurrentCulture,out var unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Enter a valid non-negative price.");
                txtUnitPrice.Focus();
                return;
            }

            if (!int.TryParse(txtQuantity.Text.Trim(), out var quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a whole number (0 or more).", "Invalid data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtQuantity.Focus();
                return;
            }

            try
            {
                if (_editingId is int id)
                {
                    var putProductDto = new PutProductDto
                    {
                        Code = code,
                        Title = title,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    };
                    _productServiceApplication.Put(id, putProductDto);
                    MessageBox.Show("Product updated successfully.");
                }
                else
                {
                    var postProductDto = new PostProductDto
                    {
                        Code = code,
                        Title = title,
                        UnitPrice = unitPrice,
                        Quantity = quantity
                    };
                    _productServiceApplication.Post(postProductDto);
                    MessageBox.Show("Product saved successfully.");
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
        private void dgvProduct_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvProduct.Rows[e.RowIndex].DataBoundItem is not GetProductDto product) return;

            if (e.ColumnIndex == colEdit.Index) StartEdit(product);
            else if (e.ColumnIndex == colDelete.Index) DeleteProduct(product);
        }

        /// <summary>Draws edit and delete icons inside the corresponding grid cells.</summary>
        private void dgvProduct_CellPainting(object? sender, DataGridViewCellPaintingEventArgs e)
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
        private void dgvProduct_CellMouseEnter(object? sender, DataGridViewCellEventArgs e)
        {
            bool isAction = e.RowIndex >= 0 &&
                            (e.ColumnIndex == colEdit.Index || e.ColumnIndex == colDelete.Index);
            dgvProduct.Cursor = isAction ? Cursors.Hand : Cursors.Default;
        }

        /// <summary>Restores the default cursor when the pointer leaves a grid cell.</summary>
        private void dgvProduct_CellMouseLeave(object? sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Cursor = Cursors.Default;
        }

        /// <summary>Applies action tooltips and clears the grid selection after binding.</summary>
        private void dgvProduct_DataBindingComplete(object? sender, DataGridViewBindingCompleteEventArgs e)
        {
            foreach (DataGridViewRow row in dgvProduct.Rows)
            {
                row.Cells[colEdit.Index].ToolTipText = "Edit";
                row.Cells[colDelete.Index].ToolTipText = "Delete";
            }
            dgvProduct.ClearSelection();
        }
        #endregion

        #region [- Helpers -]

        /// <summary>Loads all products into the data grid.</summary>
        private void LoadData()
        {
            try
            {
                dgvProduct.DataSource = _productServiceApplication.GetAll();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        /// <summary>Copies a product's values into the input controls for editing.</summary>
        /// <param name="product">The product selected for editing.</param>
        private void StartEdit(GetProductDto product)
        {
            _editingId = product.Id;
            txtCode.Text = product.Code;
            txtTitle.Text = product.Title;
            txtUnitPrice.Text = product.UnitPrice.ToString(CultureInfo.CurrentCulture);
            txtQuantity.Text = product.Quantity.ToString();
            btnSave.Text = "Update";
            txtCode.Focus();
        }

        /// <summary>Confirms and deletes a product.</summary>
        /// <param name="product">The product selected for deletion.</param>
        private void DeleteProduct(GetProductDto product)
        {
            var answer = MessageBox.Show($"Delete product {product.Title}?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            try
            {
                var deleteProductDto = new DeleteProductDto { Id = product.Id };
                _productServiceApplication.Delete(deleteProductDto);
                if (_editingId == product.Id) ClearInputs();
                LoadData();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        /// <summary>Resets the form to new-product entry mode.</summary>
        private void ClearInputs()
        {
            _editingId = null;
            txtCode.Clear();
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
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