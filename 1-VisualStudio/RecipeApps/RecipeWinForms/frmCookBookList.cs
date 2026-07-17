using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForm
{
    public partial class frmCookbookList : Form
    {
        public frmCookbookList()
        {
            InitializeComponent();
            LoadList();
            gCookBookList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            btnNewCookbook.Click += BtnNewCookbook_Click;
            gCookBookList.CellDoubleClick += GCookBookList_CellDoubleClick;
            gCookBookList.KeyDown += GCookBookList_KeyDown;
            gCookBookList.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            gCookBookList.AllowUserToAddRows = false;
            gCookBookList.ReadOnly = true;
        }
        private void LoadList()
        {
            gCookBookList.DataSource = CookBookClass.GetCookBookList();
            gCookBookList.Columns["CookBookId"].Visible = false;
        }
        private void GetCookBookList()
        {
            frmDashboard main = (frmDashboard)this.MdiParent;
            main.OpenForm(typeof(frmCookbook), 0);
        }

        private void OpenCookBook()
        {
            Application.UseWaitCursor = true;

            try
            {
                if (gCookBookList.CurrentRow == null) return;

                int cookbookid = Convert.ToInt32(gCookBookList.CurrentRow.Cells["CookBookId"].Value);

                frmDashboard main = (frmDashboard)this.MdiParent;
                main.OpenForm(typeof(frmCookbook), cookbookid);
            }
            finally
            {
                Application.UseWaitCursor = false;
            }
        }
        private void GCookBookList_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                OpenCookBook();
            }
        }
        private void GCookBookList_CellDoubleClick(object? sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                OpenCookBook();
            }
        }

        private void BtnNewCookbook_Click(object? sender, EventArgs e)
        {
            GetCookBookList();
        }

    }
}
