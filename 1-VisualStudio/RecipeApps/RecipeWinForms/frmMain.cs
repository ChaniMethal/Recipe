using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForm
{
    public partial class frmMain : Form
    {
        public frmMain()
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

            Shown += FrmMain_Shown;
        }

        private void FrmMain_Shown(object? sender, EventArgs e)
        {
            frmLogin login = new()
            {
                StartPosition = FormStartPosition.CenterParent
            };

            if (login.ShowLogin() == false)
            {
                Application.Exit();
                return;
            }
        }

        public void OpenForm(Type frmtype, int pkvalue = 0)
        {
            Form? openForm = Application.OpenForms
                .Cast<Form>()
                .FirstOrDefault(f => f.GetType() == frmtype);

            if (openForm != null)
            {
                openForm.WindowState = FormWindowState.Maximized;
                openForm.Activate();

                if (openForm is frmDashboard dashboard)
                {
                    dashboard.BindData();
                }

                return;
            }

            Form? newfrm = null;

            if (frmtype == typeof(frmDashboard))
            {
                newfrm = new frmDashboard();
            }
            else if (frmtype == typeof(frmRecipeList))
            {
                newfrm = new frmRecipeList();
            }
            else if (frmtype == typeof(frmRecipe))
            {
                frmRecipe f = new();
                f.ShowForm(pkvalue);
                newfrm = f;
            }
            else if (frmtype == typeof(frmCloneRecipe))
            {
                newfrm = new frmCloneRecipe();
            }
            else if (frmtype == typeof(frmMealList))
            {
                newfrm = new frmMealList();
            }
            else if (frmtype == typeof(frmCookbookList))
            {
                newfrm = new frmCookbookList();
            }
            else if (frmtype == typeof(frmCookbook))
            {
                frmCookbook f = new();
                f.ShowCookbookForm(pkvalue);
                newfrm = f;
            }
            else if (frmtype == typeof(frmCreateCookbook))
            {
                newfrm = new frmCreateCookbook();
            }
            else if (frmtype == typeof(frmDataMaintenance))
            {
                newfrm = new frmDataMaintenance();
            }

            if (newfrm == null)
            {
                return;
            }

            newfrm.MdiParent = this;
            newfrm.WindowState = FormWindowState.Maximized;
            newfrm.FormClosed += Newfrm_FormClosed;
            newfrm.TextChanged += Newfrm_TextChanged;
            newfrm.Show();

            WindowsFormsUtility.SetUpNav(tsMain);
        }

        private void MnuFileDashboard_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDashboard));
        }

        private void MnuRecipeList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipeList));
        }

        private void MnuNewRecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmRecipe));
        }

        private void MnuCloneARecipe_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCloneRecipe));
        }

        private void MnuMealList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmMealList));
        }

        private void MnuCookbookList_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbookList));
        }

        private void MnuNewCookbook_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCookbook));
        }

        private void MnuCookbookAutoCreate_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmCreateCookbook));
        }

        private void MnuEditData_Click(object? sender, EventArgs e)
        {
            OpenForm(typeof(frmDataMaintenance));
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
    }
}