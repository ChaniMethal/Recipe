using System.Configuration;
using RecipeWinForm.Properties;

namespace RecipeWinForm
{
    public partial class frmLogin : Form
    {
        bool loginsucces = false;
        public frmLogin()
        {
            InitializeComponent();
            btnLogin.Click += BtnLogin_Click;
            btnCancel.Click += BtnCancel_Click;
        }

        public bool ShowLogin()
        {
#if DEBUG
            this.Text = this.Text + " -Dev";
#endif
            txtUser.Text = Settings.Default.user;
            this.ShowDialog();
            return loginsucces;
        }
        private void BtnCancel_Click(object? sender, EventArgs e)
        {
            this.Close();
        }
        private void BtnLogin_Click(object? sender, EventArgs e)
        {
            try
            {
                string connstringkey = "";
#if DEBUG
                connstringkey = "devconn";
#else
                connstringkey = "liveconn";
#endif
                string connstring = ConfigurationManager.ConnectionStrings[connstringkey].ConnectionString;
                DBManager.SetConnectionString(connstring, true, txtUser.Text, txtPassword.Text);
                loginsucces = true;
                Settings.Default.user = txtUser.Text;
                Settings.Default.Save();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Login. Try again.");
                return;
            }
        }
    }
    
}
