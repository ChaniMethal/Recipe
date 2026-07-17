using CPUFramework;
using System.Data;
using System.Diagnostics;

namespace RecipeWinForm
{
    public partial class frmRecipe : Form
    {
        DataTable dtrecipe = new DataTable();
        DataTable dtrecipeingredient = new DataTable();
        DataTable dtrecipesteps = new DataTable();
        string deletecolname = "deletecolname";
        BindingSource bindsource = new BindingSource();
        int RecipeId = 0;
        public frmRecipe()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
            btnChangeStatus.Click += BtnChangeStatus_Click;
            gIngredients.CellContentClick += GIngredients_CellContentClick;
            gSteps.CellContentClick += GSteps_CellContentClick;
            gIngredients.ScrollBars = ScrollBars.Both;
            gIngredients.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            gSteps.ScrollBars = ScrollBars.Both;
            gSteps.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
            btnSaveIngredient.Click += BtnSaveIngredient_Click;
            btnSaveSteps.Click += BtnSaveSteps_Click;
            txtCalories.KeyPress += TxtCalories_KeyPress;
            this.FormClosing += FrmRecipe_FormClosing;
        }



        public void ShowForm(int recipeidval)
        {
            RecipeId = recipeidval;
            this.Tag = RecipeId;

            dtrecipe = RecipeClass.Load(RecipeId);
            bindsource.DataSource = dtrecipe;
            if (RecipeId == 0 )
            {
                dtrecipe.Rows.Add();
                dtrecipe.Rows[0]["DateCreated"] = DateTime.Today;
            }
            DataTable dtcuisines = RecipeClass.GetCuisineList(true);
            DataTable dtusername = RecipeClass.GetUserList(true);
            WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisines, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtrecipe, "User");
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(lblRecipeStatus, bindsource);
            this.Text = GetRecipeDesc();
            LoadIngredients();
            LoadSteps();
            SetButtonsEnabledBasedOnNewRecord();
            this.Show();

        }

        private void SetButtonsEnabledBasedOnNewRecord()
        {
            bool b = RecipeId == 0 ? false : true;
            btnDelete.Enabled = b;
            btnSaveIngredient.Enabled = b;
            btnSaveSteps.Enabled = b;
            btnChangeStatus.Enabled = b;
        }

        private string GetRecipeDesc()
        {
            string value = "New Recipe";
            int pkvalue = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
            if (pkvalue > 0)
            {
                value = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");
            }
            return value;
        }
        private void SaveRecipeSteps()
        {
            try
            {
                gSteps.EndEdit();
                RecipeSteps.SaveTable(dtrecipesteps, RecipeId);
                LoadSteps();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void DeleteRecipeSteps(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gSteps, rowIndex, "PrepStepsId");
            if (id > 0)
            {
                try
                {
                    RecipeSteps.Delete(id);
                    LoadSteps();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (rowIndex >= 0)
            {
                gSteps.Rows.RemoveAt(rowIndex);
            }
        }
        private void LoadSteps()
        {
            dtrecipesteps = RecipeSteps.LoadByRecipeId(RecipeId);
            gSteps.Columns.Clear();
            gSteps.DataSource = dtrecipesteps;
            WindowsFormsUtility.AddDeleteButtonToGrid(gSteps, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gSteps, "PrepSteps");
        }

        private void LoadIngredients()
        {
            dtrecipeingredient = RecipeIngredient.LoadByRecipeId(RecipeId);
            gIngredients.Columns.Clear();
            gIngredients.DataSource = dtrecipeingredient;
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("Ingredient"), "Ingredient", "IngredientName");
            WindowsFormsUtility.AddComboBoxToGrid(gIngredients, DataMaintenance.GetDataList("MeasurementType"), "MeasurementType", "MeasurementType");
            WindowsFormsUtility.AddDeleteButtonToGrid(gIngredients, deletecolname);
            WindowsFormsUtility.FormatGridForEdit(gIngredients, "RecipeIngredient");
        }
        private void SaveRecipeIngredient()
        {
            try
            {
                gIngredients.EndEdit();
                RecipeIngredient.SaveTable(dtrecipeingredient, RecipeId);
                LoadIngredients();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }

        private void DeleteRecipeIngredient(int rowIndex)
        {
            int id = WindowsFormsUtility.GetIdFromGrid(gIngredients, rowIndex, "IngredientDescId");
            if (id > 0)
            {
                try
                {
                    RecipeIngredient.Delete(id);
                    LoadIngredients();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, Application.ProductName);
                }
            }
            else if (rowIndex >= 0)
            {
                gIngredients.Rows.RemoveAt(rowIndex);
            }
        }
        private bool Save()
        {
            bool b = false;
            dtrecipe.Rows[0].EndEdit();

            if (lstCuisineName.Text.Trim() == "")
            {
                dtrecipe.Rows[0]["CuisineId"] = 0;
            }

            if (lstUserName.Text.Trim() == "")
            {
                dtrecipe.Rows[0]["UserId"] = 0;
            }
            Application.UseWaitCursor = true;

            try
            {
                RecipeClass.Save(dtrecipe);
                b = true;

                bindsource.ResetBindings(false);
                RecipeId = SQLUtility.GetValueFromFirstRowAsInt(dtrecipe, "RecipeId");
                this.Tag = RecipeId;
                SetButtonsEnabledBasedOnNewRecord();
                this.Text = GetRecipeDesc();


                LoadIngredients();
                LoadSteps();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }

            return b;
        }
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", Application.ProductName, MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                RecipeClass.Delete(dtrecipe);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void ChangeStatus()
        {
            var response = MessageBox.Show("Are you sure you want to change the status of this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                frmChangeStatus frm = new frmChangeStatus();
                frm.MdiParent = this.MdiParent;
                frm.ShowForm(RecipeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Recipe");
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void FrmRecipe_FormClosing(object? sender, FormClosingEventArgs e)
        {
            bindsource.EndEdit();
            if (SQLUtility.TableHasChanges(dtrecipe))
            {
                var res = MessageBox.Show($"Do you want to save changes to {this.Text} before closing the form?", Application.ProductName, MessageBoxButtons.YesNoCancel);
                switch (res)
                {
                    case DialogResult.Yes:
                        bool b = Save();
                        if (b == false)
                        {
                            e.Cancel = true;
                            this.Activate();
                        }
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        this.Activate();
                        break;
                }
            }
        }
        private void BtnSaveSteps_Click(object? sender, EventArgs e)
        {
            SaveRecipeSteps();
        }

        private void BtnSaveIngredient_Click(object? sender, EventArgs e)
        {
            SaveRecipeIngredient();
        }
        private void BtnChangeStatus_Click(object? sender, EventArgs e)
        {
            ChangeStatus();
        }
        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
        private void GIngredients_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gIngredients.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteRecipeIngredient(e.RowIndex);
            }
        }
        private void GSteps_CellContentClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && gSteps.Columns[e.ColumnIndex].Name == deletecolname)
            {
                DeleteRecipeSteps(e.RowIndex);
            }
        }
        private void TxtCalories_KeyPress(object? sender, KeyPressEventArgs e)
        {
            Recipe.AllowOnlyNumbers(e);
        }
    }
}


