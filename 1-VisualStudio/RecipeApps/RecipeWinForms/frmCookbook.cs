using CPUFramework;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForm
{
    public partial class frmCookbook : Form
    {
        DataTable dtcookbook = new DataTable();
        BindingSource bindsource = new BindingSource();
        int CookBookId = 0;
        string deletecolname = "deletecolname";
        public frmCookbook()
        {
            InitializeComponent();
            btnSaveCookbook.Click += BtnSaveCookbook_Click;
            btnDeleteCookbook.Click += BtnDeleteCookbook_Click;
            rdoActiveYes.CheckedChanged += RdoActiveYes_CheckedChanged;
            txtPrice.KeyPress += TxtPrice_KeyPress;
            gCookbookSuppers.DoubleClick += GCookbookSuppers_DoubleClick;
            gCookbookSuppers.CellContentClick += GCookbookSuppers_CellContentClick;
        }

        private void TxtPrice_KeyPress(object? sender, KeyPressEventArgs e)
        {
            CookBookClass.AllowOnlyNumbers(e);
        }

        private void GCookbookSuppers_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gCookbookSuppers.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteCookBookRecipe(e.RowIndex);
            }

        }

        private void DeleteCookBookRecipe(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gCookbookSuppers, rowIndex, "CookBookRecipeId");

            if (id > 0)
            {
                CookBookClass.DeleteRecipe(id);
                LoadCookBookRecipes();
            }
            else if (rowIndex >= 0)
            {
                gCookbookSuppers.Rows.RemoveAt(rowIndex);
            }
        }

        private void OpenRecipe()
        {
            if (gCookbookSuppers.CurrentRow == null)
            {
                return;
            }

            int recipeid = Convert.ToInt32(gCookbookSuppers.CurrentRow.Cells["RecipeId"].Value);

            frmMain main = (frmMain)this.MdiParent;
            main.OpenForm(typeof(frmRecipe), recipeid);
        }
        private void GCookbookSuppers_DoubleClick(object? sender, EventArgs e)
        {
            OpenRecipe();
        }

        public void ShowCookbookForm(int cookbookidval)
        {
            CookBookId = cookbookidval;
            dtpDateCreated.Enabled = CookBookId == 0;
            this.Tag = cookbookidval;

            dtcookbook = CookBookClass.Load(CookBookId);
            bindsource.DataSource = dtcookbook;
            if (CookBookId == 0)
            {
                dtcookbook.Rows.Add();
                dtcookbook.Rows[0]["DateCreated"] = DateTime.Today;
                dtcookbook.Rows[0]["Active"] = true;
            }
            DataTable dtusername = RecipeClass.GetUserList(true);
            WindowsFormsUtility.SetControlBinding(txtCookbookName, bindsource);
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtcookbook, "User");
            WindowsFormsUtility.SetControlBinding(txtPrice, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateCreated, bindsource);
            SetActiveButtons();
            LoadCookBookRecipes();
            this.Show();
        }
        
        private void LoadCookBookRecipes()
        {
            if (CookBookId == 0)
            {
                gCookbookSuppers.DataSource = null;
                return;
            }
            gCookbookSuppers.Columns.Clear();

            gCookbookSuppers.DataSource = CookBookClass.LoadRecipes(CookBookId);

            WindowsFormsUtility.AddComboBoxToGrid(gCookbookSuppers, DataMaintenance.GetDataList("Recipe"), "Recipe", "RecipeName");
            WindowsFormsUtility.AddDeleteButtonToGrid(gCookbookSuppers, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gCookbookSuppers, "CookBookRecipe");

            gCookbookSuppers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            gCookbookSuppers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this cookbook?", Application.ProductName, MessageBoxButtons.YesNo);

            if (response == DialogResult.No)
            {
                return;
            }

            try
            {
                bindsource.EndEdit();
                CookBookClass.Delete(dtcookbook);
                MessageBox.Show("Cookbook deleted.", Application.ProductName);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void Save()
        {
            var response = MessageBox.Show("Are you sure you want to save this cookbook?", Application.ProductName, MessageBoxButtons.YesNo);

            if (response == DialogResult.No)
            {
                return;
            }

            try
            {
                bindsource.EndEdit();
                CookBookClass.Save(dtcookbook);
                MessageBox.Show("Cookbook saved.", Application.ProductName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void SetActiveButtons()
        {
            bool active = Convert.ToBoolean(dtcookbook.Rows[0]["Active"]);

            rdoActiveYes.Checked = active;
            rdoActiveNo.Checked = !active;
        }
        private void RdoActiveYes_CheckedChanged(object? sender, EventArgs e)
        {
            if (dtcookbook.Rows.Count > 0)
            {
                dtcookbook.Rows[0]["Active"] = rdoActiveYes.Checked;
            }
        }

        private void BtnDeleteCookbook_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSaveCookbook_Click(object? sender, EventArgs e)
        {
            Save();
        }

    }
}
