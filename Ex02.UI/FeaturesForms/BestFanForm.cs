using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ex03.Logic;
using FacebookWrapper.ObjectModel;

namespace Ex03.UI
{
    public partial class BestFanForm : Form
    {
        private User m_LoggedInUser;
        private Ex03.Logic.Client m_Client;
        private List<BestFanItems> m_CheckBoxParametersOfFan;

        public BestFanForm (User i_LoggedInUser)
        {
            this.InitializeComponent();
            this.LoggedInUser = i_LoggedInUser;
            Client = new Client(i_LoggedInUser, this.userBindingSource);
            initCheckBox();
            initializeCheckBoxItems();
        }

        public User LoggedInUser { get => m_LoggedInUser; set => m_LoggedInUser = value; }

        public Client Client { get => m_Client; set => m_Client = value; }

        private void initCheckBox()
        {
            m_CheckBoxParametersOfFan = new List<BestFanItems>()
            {
                new BestFanItems {Text = "Photos Liker"  ,Command = m_Client.GetYourBestPhotosFan},
                new BestFanItems {Text = "Posts Liker" , Command = m_Client.GetYourBestPostFan }
            };
        }

        private void initializeCheckBoxItems()
        {
            foreach (BestFanItems item in m_CheckBoxParametersOfFan)
            {
                this.checkedListBoxParametersOfFan1.Items.Add(item.Text);
            }
        }


        private void findTheBestFanButton_Click(object sender, EventArgs e)
        {
            int selectedItem = this.checkedListBoxParametersOfFan1.SelectedIndex;


            if (selectedItem == -1)
            {
                MessageBox.Show("You must chose at least on option");
            }
            else
            {
                try
                {
                    m_CheckBoxParametersOfFan[selectedItem].Selected();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void checkedListBoxParametersOfFan1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int selectedItem = this.checkedListBoxParametersOfFan1.SelectedIndex;
            if (selectedItem == -1)
            {
                return;
            }
            for (int i = 0; i < checkedListBoxParametersOfFan1.Items.Count; i++)
            {
                this.checkedListBoxParametersOfFan1.SetItemCheckState(i, CheckState.Unchecked);
            }
            checkedListBoxParametersOfFan1.SetItemCheckState(selectedItem, CheckState.Checked);
        }
    }
}
