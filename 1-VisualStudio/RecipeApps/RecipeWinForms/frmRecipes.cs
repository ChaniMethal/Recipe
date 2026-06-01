using System.Data;
using System.Diagnostics;

namespace RecipeWinForms
{
    public partial class frmRecipes : Form
    {
        DataTable dtrecipe = new DataTable();
        BindingSource bindsource = new BindingSource();
        public frmRecipes()
        {
            InitializeComponent();
            btnSave.Click += BtnSave_Click;
            btnDelete.Click += BtnDelete_Click;
        }
        

        public void ShowForm(int RecipeId)
        {
            dtrecipe = Recipe.Load(RecipeId);
            bindsource.DataSource = dtrecipe;
            if (RecipeId == 0 )
            {
                dtrecipe.Rows.Add();
                dtrecipe.Rows[0]["DateCreated"] = DateTime.Today;
            }
            DataTable dtcuisines = Recipe.GetCuisineList();
            DataTable dtusername = Recipe.GetUserList();
            /*WindowsFormsUtility.SetControlBinding(txtRecipeName, bindsource);
            WindowsFormsUtility.SetListBinding(lstCuisineName, dtcuisines, dtrecipe, "Cuisine");
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, dtrecipe, "User");
            WindowsFormsUtility.SetControlBinding(txtCalories, bindsource);
            WindowsFormsUtility.SetControlBinding(dtpDateCreated, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDateArchived, bindsource);
            WindowsFormsUtility.SetControlBinding(txtDatePublished, bindsource);
            WindowsFormsUtility.SetControlBinding(txtRecipeStatus, bindsource);*/
            this.Show();

        }
        
        private void Save()
        {
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
                Recipe.Save(dtrecipe);
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
        private void Delete()
        {
            var response = MessageBox.Show("Are you sure you want to delete this Recipe?", "Recipe", MessageBoxButtons.YesNo);
            if (response == DialogResult.No)
            {
                return;
            }
            Application.UseWaitCursor = true;
            try
            {
                Recipe.Delete(dtrecipe);
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

        private void BtnDelete_Click(object? sender, EventArgs e)
        {
            Delete();
        }

        private void BtnSave_Click(object? sender, EventArgs e)
        {
            Save();
        }
    }
}


