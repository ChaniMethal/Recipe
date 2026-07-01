using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RecipeWinForm
{
    public partial class frmCreateCookbook : Form
    {
        public frmCreateCookbook()
        {
            InitializeComponent();
            btnCreateCookbook.Click += BtnCreateCookbook_Click;
            LoadUsers();
        }

        private void LoadUsers()
        {
            DataTable dtusername = RecipeClass.GetUserList(true);
            WindowsFormsUtility.SetListBinding(lstUserName, dtusername, null, "User");
        }
        private void CreateCookBook()
        {
            int userid = (int)lstUserName.SelectedValue;

            int newcookbookid = CookBookClass.AutoCreate(userid);

            frmDashboard main = (frmDashboard)this.MdiParent;
            main.OpenForm(typeof(frmCookbook), newcookbookid);

            this.Close();
        }

        private void BtnCreateCookbook_Click(object? sender, EventArgs e)
        {
            try
            {
                CreateCookBook();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
    }
}
