using CPUFramework;
using Microsoft.Data.SqlClient;
using System.Data;

namespace RecipeWinForm
{
    public partial class frmChangeStatus : Form
    {
        int RecipeId = 0;
        DataTable dtrecipe = new DataTable();
        BindingSource bindsource = new BindingSource();
        public frmChangeStatus()
        {
            InitializeComponent();

            SetButtonsEnabled();

            txtArchived.TextChanged += TxtArchived_TextChanged;
            txtDrafted.TextChanged += TxtDrafted_TextChanged;
            txtPublished.TextChanged += TxtPublished_TextChanged;

            btnDraft.Click += BtnDraft_Click;
            btnArchive.Click += BtnArchive_Click;
            btnPublish.Click += BtnPublish_Click;
        }
        private void SetRecipeInfo()
        {
            if(dtrecipe.Rows.Count == 0)
            {
                return;
            }

            lblHeader.Text = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeName");

            string status = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus");
            lblSubHeader.Text = "Current Status: " + status;
        }
        private DateTime GetStatusDate(string status)
        {
            if (status == "draft")
            {
                return DateTime.Parse(txtDrafted.Text);
            }
            else if (status == "publish")
            {
                return DateTime.Parse(txtPublished.Text);
            }
            else
            {
                return DateTime.Parse(txtArchived.Text);
            }
        }
        public void ShowForm(int recipeidval)
        {
            RecipeId = recipeidval;
            this.Tag = RecipeId;

            dtrecipe = RecipeClass.Load(RecipeId);
            bindsource.DataSource = dtrecipe;

            SetRecipeInfo();
            SetButtonsEnabled();

            this.Show();
        }
        private bool ConfirmStatusChange(string status)
        {
            var response = MessageBox.Show(
                "Are you sure you want to change this recipe to " + status + "?",
                Application.ProductName, MessageBoxButtons.YesNo);

            return response == DialogResult.Yes;
        }
        private void SaveStatusChange(string status)
        {
            SqlCommand cmd = SQLUtility.GetSqlCommand("RecipeChangeStatus");
            cmd.Parameters["@RecipeId"].Value = RecipeId;
            cmd.Parameters["@RecipeStatus"].Value = status;
            cmd.Parameters["@StatusDate"].Value = GetStatusDate(status);
            SQLUtility.ExecuteSQL(cmd);

        }
        private void ChangeStatus(string status)
        {
            if(ConfirmStatusChange(status) == false)
            {
                return;
            }

            try
            {
                SaveStatusChange(status);

                dtrecipe = RecipeClass.Load(RecipeId);
                bindsource.DataSource = dtrecipe;

                SetButtonsEnabled();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, Application.ProductName);
            }
        }
        private void CurrentStatusDisabledButtons()
        {
            string status = SQLUtility.GetValueFromFirstRowAsString(dtrecipe, "RecipeStatus").ToLower();

            if (status == "draft")
            {
                btnDraft.Enabled = false;
            }

            if (status == "published")
            {
                btnPublish.Enabled = false;
            }

            if (status == "archived")
            {
                btnArchive.Enabled = false;
            }
        }
        private void SetButtonsEnabled()
        {
            EnableButton(txtDrafted, btnDraft);
            EnableButton(txtPublished, btnPublish);
            EnableButton(txtArchived, btnArchive);

            CurrentStatusDisabledButtons();
        }
        private void EnableButton(TextBox txt, Button btn)
        {
            if (txt.Text.Trim() == "")
            {
                btn.Enabled = false;
                btn.BackColor = Color.LightSteelBlue;
            }
            else
            {
                btn.Enabled = true;
                btn.BackColor = Color.SteelBlue;
            }
        }
        private void TxtPublished_TextChanged(object? sender, EventArgs e)
        {
            SetButtonsEnabled();
        }

        private void TxtDrafted_TextChanged(object? sender, EventArgs e)
        {
            SetButtonsEnabled();
        }

        private void TxtArchived_TextChanged(object? sender, EventArgs e)
        {
            SetButtonsEnabled();
        }


        private void BtnPublish_Click(object? sender, EventArgs e)
        {
            ChangeStatus("publish");
        }

        private void BtnArchive_Click(object? sender, EventArgs e)
        {
            ChangeStatus("archive");
        }

        private void BtnDraft_Click(object? sender, EventArgs e)
        {
            ChangeStatus("draft");
        }
    }
}
