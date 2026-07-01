using CPUFramework;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeWinForm
{
    public partial class frmCloneRecipe : Form
    {
        public frmCloneRecipe()
        {
            InitializeComponent();
            btnClone.Click += BtnClone_Click;
            LoadRecipes();
        }
        private void LoadRecipes()
        {
            DataTable dtrecipe = DataMaintenance.GetDataList("Recipe");

            lstRecipe.DataSource = dtrecipe;
            lstRecipe.DisplayMember = "RecipeName";
            lstRecipe.ValueMember = "RecipeId";
        }
        private void BtnClone_Click(object? sender, EventArgs e)
        {
            if(lstRecipe.SelectedValue == null)
            {
                return;
            }

            int recipeid = (int)lstRecipe.SelectedValue;
            int newrecipeid = RecipeClass.Clone(recipeid);

            frmDashboard main = (frmDashboard)this.MdiParent;
            main.OpenForm(typeof(frmRecipe), newrecipeid);

            this.Close();
        }
    }
}
