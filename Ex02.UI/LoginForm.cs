using System;
using System.Windows.Forms;

namespace Ex02.UI
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            this.InitializeComponent();
            FacebookWrapper.FacebookService.s_CollectionLimit = 200;
            FacebookWrapper.FacebookService.s_FbApiVersion = 2.8f;
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            try
            {
                Singleton.Instance.LoginAndInit();
                Form nextForm = new FacebookTabs();
                this.Hide();
                nextForm.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }   
        }
    }
}
