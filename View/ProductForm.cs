using ApplicationService.Dtos.Product;
using ApplicationService.Services;

namespace View
{
    public partial class ProductForm : Form
    {
        private readonly ProductServiceApplication _productServiceApplication;

        // null = adding a new product, otherwise = id of the product being edited
        private int? _editingId;

        private static readonly Color EditColor = Color.FromArgb(37, 99, 235);
        private static readonly Color DeleteColor = Color.FromArgb(220, 38, 38);

        public ProductForm()
        {
            InitializeComponent();
            dgvProduct.AutoGenerateColumns = false;
            _productServiceApplication = new ProductServiceApplication();
        }

        private void ProductForm_Load(object? sender, EventArgs e)
        {
            LoadData();
        }

        #region [- Buttons -]

        private void btnBack_Click(object? sender, EventArgs e)
        {
            Close(); // later this returns to the main page
        }

        private void btnRefresh_Click(object? sender, EventArgs e)
        {
            ClearInputs();
            LoadData();
        }

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

            if (!decimal.TryParse(txtUnitPrice.Text.Trim(), out var unitPrice) || unitPrice < 0)
            {
                MessageBox.Show("Unit price must be a valid number (0 or more).", "Invalid data",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        private void dgvProduct_CellClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;
            if (dgvProduct.Rows[e.RowIndex].DataBoundItem is not GetProductDto product) return;

            if (e.ColumnIndex == colEdit.Index) StartEdit(product);
            else if (e.ColumnIndex == colDelete.Index) DeleteProduct(product);
        }

        // Draws the edit / delete icons inside the cells
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

        private void dgvProduct_CellMouseEnter(object? sender, DataGridViewCellEventArgs e)
        {
            bool isAction = e.RowIndex >= 0 &&
                            (e.ColumnIndex == colEdit.Index || e.ColumnIndex == colDelete.Index);
            dgvProduct.Cursor = isAction ? Cursors.Hand : Cursors.Default;
        }

        private void dgvProduct_CellMouseLeave(object? sender, DataGridViewCellEventArgs e)
        {
            dgvProduct.Cursor = Cursors.Default;
        }

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

        private void StartEdit(GetProductDto product)
        {
            _editingId = product.Id;
            txtCode.Text = product.Code;
            txtTitle.Text = product.Title;
            txtUnitPrice.Text = product.UnitPrice.ToString();
            txtQuantity.Text = product.Quantity.ToString();
            btnSave.Text = "Update";
            txtCode.Focus();
        }

        private void DeleteProduct(GetProductDto product)
        {
            var answer = MessageBox.Show($"Delete product {product.Title}?", "Confirm delete",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer != DialogResult.Yes) return;

            try
            {
                _productServiceApplication.Delete(product.Id);
                if (_editingId == product.Id) ClearInputs();
                LoadData();
            }
            catch (Exception ex)
            {
                ShowError(ex);
            }
        }

        private void ClearInputs()
        {
            _editingId = null;
            txtCode.Clear();
            txtTitle.Clear();
            txtUnitPrice.Clear();
            txtQuantity.Clear();
            btnSave.Text = "Save";
        }

        private static void ShowError(Exception ex)
        {
            MessageBox.Show(ex.GetBaseException().Message, "Error",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        #endregion
    }
}