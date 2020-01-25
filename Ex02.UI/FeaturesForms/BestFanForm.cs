using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ex02.Logic;
using FacebookWrapper.ObjectModel;

namespace Ex02.UI
{
    public partial class BestFanForm : Form
    {
        private User m_LoggedInUser;
        private Facade m_Facade;

        public BestFanForm (User i_LoggedInUser)
        {
            this.InitializeComponent();
            this.LoggedInUser = i_LoggedInUser;
            Facade = new Facade(i_LoggedInUser, this.userBindingSource);
        }

        public User LoggedInUser { get; set; }

        public Facade Facade { get; set; }

        private void FindTheBestFanButton_Click(object sender, EventArgs e)
        {
            List<string> parametersToCheck = new List<string>();
            
            for (int i = 0; i < this.checkedListBoxParametersOfFan1.Items.Count; i++)
            {
                if (this.checkedListBoxParametersOfFan1.GetItemChecked(i))
                {
                    parametersToCheck.Add(this.checkedListBoxParametersOfFan1.Items[i].ToString());
                }
            }

            if (parametersToCheck.Count == 0)
            {
                MessageBox.Show("You must chose at least on option");
            }
            else if (parametersToCheck.Contains("photos") && this.LoggedInUser.PhotosTaggedIn.Count == 0)
            {
                MessageBox.Show("Sorry, you don't have any photos - you can't play this game :(");
            }
            else if (parametersToCheck.Contains("posts") && this.LoggedInUser.Posts.Count == 0)
            {
                MessageBox.Show("Sorry, you don't have any posts - you can't play this game :(");
            }
            else
            {
                try
                {
                    this.Facade.FindYourBestFan(parametersToCheck);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }

            parametersToCheck.Clear();
        }
    }
}
