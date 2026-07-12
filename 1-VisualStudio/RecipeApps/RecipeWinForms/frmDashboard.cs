using System.Data;

namespace RecipeWinForm
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
            mnuFileDashboard.Click += MnuFileDashboard_Click;
            mnuRecipeList.Click += MnuRecipeList_Click;
            mnuNewRecipe.Click += MnuNewRecipe_Click;
            mnuCloneARecipe.Click += MnuCloneARecipe_Click;
            mnuMealList.Click += MnuMealList_Click;
            mnuCookbookList.Click += MnuCookbookList_Click;
            mnuNewCookbook.Click += MnuNewCookbook_Click;
            mnuCookbookAutoCreate.Click += MnuCookbookAutoCreate_Click;
            mnuEditData.Click += MnuEditData_Click;
            mnuWindowCascade.Click += MnuWindowCascade_Click;
            mnuWindowTile.Click += MnuWindowTile_Click;
            btnRecipeList.Click += BtnRecipeList_Click;
            btnCookbookList.Click += BtnCookbookList_Click;
            btnMealList.Click += BtnMealList_Click;
            //this.Activated += FrmDashboard_Activated;
            this.Shown += FrmDashboard_Shown;
        }

        private void FrmDashboard_Shown(object? sender, EventArgs e)
        {
            frmLogin f = new() { StartPosition = FormStartPosition.CenterParent };
            bool b = f.ShowLogin();
            if(b == false)
            {
                this.Close();
                Application.Exit();
                return;
            }
            OpenForm(typeof(frmDashboard));
            BindData();
        }

        //private void FrmDashboard_Activated(object? sender, EventArgs e)
        //{
        //    BindData();
        //}
        private void SetText(DataTable dt, string recordtype, TextBox txt)
        {
            var rows = dt.Select($"DashboardType = '{recordtype}'");

            if (rows.Length > 0)
            {
                txt.Text = rows[0]["DashboardText"].ToString();
            }
        }
        private void BindData()
        {
            DataTable dt = DataMaintenance.GetDashboard();
            SetText(dt, "recipe", txtRecipes);
            SetText(dt, "meal", txtMeals);
            SetText(dt, "cookbook", txtCookBook);
        }
        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            bool b = WindowsFormsUtility.IsFormOpen(frmtype);

            if (b == false)
            {
                Form? newfrm = null;
                if (frmtype == typeof(frmRecipeList))
                {
                    frmRecipeList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmRecipe))
                {
                    frmRecipe f = new();
                    newfrm = f;
                    f.ShowForm(pkvalue);
                }
                else if (frmtype == typeof(frmCloneRecipe))
                {
                    frmCloneRecipe f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmMealList))
                {
                    frmMealList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbookList))
                {
                    frmCookbookList f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmCookbook))
                {
                    frmCookbook f = new();
                    newfrm = f;
                    f.ShowCookbookForm(pkvalue);
                }
                else if (frmtype == typeof(frmCreateCookbook))
                {
                    frmCreateCookbook f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmDataMaintenance))
                {
                    frmDataMaintenance f = new();
                    newfrm = f;
                }
                else if (frmtype == typeof(frmChangeStatus))
                {
                    frmChangeStatus f = new();
                    newfrm = f;
                }
                if (newfrm != null)
                {
                    tblMain.Visible = false;
                    newfrm.MdiParent = this;
                    newfrm.WindowState = FormWindowState.Maximized;
                    newfrm.FormClosed += Newfrm_FormClosed;
                    newfrm.TextChanged += Newfrm_TextChanged;
                    newfrm.Show();
                    mnuMain.Visible = true;
                    mnuMain.BringToFront();
                }
                WindowsFormsUtility.SetUpNav(tsMain);
            }
        }

        private void MnuWindowTile_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void MnuWindowCascade_Click(object? sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void Newfrm_TextChanged(object? sender, EventArgs e)
        {
           WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void Newfrm_FormClosed(object? sender, FormClosedEventArgs e)
        {
            WindowsFormsUtility.SetUpNav(tsMain);
        }
        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
        }
        private void MnuCookbookAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCreateCookbook));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }
        private void MnuCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }
        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }
       
        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
        private void MnuFileDashboard_Click(object? sender, EventArgs e)
        {
            tblMain.Visible = true;
            tblMain.BringToFront();
        }

        private void BtnMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void BtnCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void BtnRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }
    }
}
