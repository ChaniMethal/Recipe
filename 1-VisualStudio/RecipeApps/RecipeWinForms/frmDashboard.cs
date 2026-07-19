using System.Data;

using System.Data;

namespace RecipeWinForm
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();

            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;

            Shown += FrmDashboard_Shown;
        }

        private void FrmDashboard_Shown(object? sender, EventArgs e)
        {
            BindData();
        }

        public void BindData()
        {
            DataTable dt = DataMaintenance.GetDashboard();

            SetText(dt, "recipe", txtRecipes);
            SetText(dt, "meal", txtMeals);
            SetText(dt, "cookbook", txtCookBook);
        }

        private void SetText(DataTable dt, string recordtype, TextBox txt)
        {
            DataRow[] rows =
                dt.Select($"DashboardType = '{recordtype}'");

            if (rows.Length > 0)
            {
                txt.Text = rows[0]["DashboardText"].ToString();
            }
        }

        private frmMain MainForm
        {
            get { return (frmMain)MdiParent; }
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            MainForm.OpenForm(typeof(frmRecipeList));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            MainForm.OpenForm(typeof(frmCookbookList));
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            MainForm.OpenForm(typeof(frmMealList));
        }
    }
}
