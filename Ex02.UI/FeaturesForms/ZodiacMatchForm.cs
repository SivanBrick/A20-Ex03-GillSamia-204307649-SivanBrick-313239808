using System;
using System.Globalization;
using System.Windows.Forms;
using Ex03.Logic;
using FacebookWrapper.ObjectModel;

namespace Ex03.UI
{
    public partial class ZodiacMatchForm : Form
    {
        private User m_LoggedInUser;
        private ZodiacSignManager m_MyZodiac;
        private string m_ErrorMsg = "OPPS! Something went wrong..";

        public ZodiacMatchForm(User i_LoggedInUser)
        {
            this.InitializeComponent();
            this.LoggedInUser = i_LoggedInUser;
            try
            {
                string currentUserBirthday = this.LoggedInUser.Birthday;
                if (currentUserBirthday.Length > 0)
                {
                    DateTime currentUserBirthdayDate = DateTime.ParseExact(currentUserBirthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                    this.MyZodiac = new ZodiacSignManager(currentUserBirthdayDate);
                    this.userZodiacSignLabel1.Text = this.MyZodiac.ZodiacSign;
                    this.zodiacHoroscopBox1.Text = this.MyZodiac.ZodiacHoroscop;
                }
            }
            catch (Exception ex)
            {
                findMatchButton1.Enabled = false;
                userZodiacSignLabel1.Text = "You cant play this geme, you need to fill your birthday:(";
                MessageBox.Show("You must have a valid birthday");
                throw new Exception(ex.Message);
            }
        }

        public User LoggedInUser { get; set; }

        public ZodiacSignManager MyZodiac { get; set; }

        public string ErrorMsg { get; set; }

        private void fetchZodiacSignFriends()
        {
            try
            {
                listBoxFriendsSign1.Items.Clear();
                listBoxFriendsSign1.DisplayMember = "Name";
                int counterZodiacMatches = 0;
                foreach (User friend in this.LoggedInUser.Friends)
                {
                    if (friend.Birthday != null && friend.Birthday.Length > 0)
                    {
                        string currentFriendBirthday = friend.Birthday;
                        if (currentFriendBirthday.Length < 6 && currentFriendBirthday.Length > 0)
                        {
                            currentFriendBirthday = currentFriendBirthday + "/2000";
                        }

                        DateTime currentFriendDate = DateTime.ParseExact(currentFriendBirthday, "MM/dd/yyyy", CultureInfo.InvariantCulture);
                        if (ZodiacSignManager.GetZodiacSign(currentFriendDate).Equals(this.MyZodiac.ZodiacSign))
                        {
                            counterZodiacMatches++;
                            listBoxFriendsSign1.Items.Add(friend);
                            friend.ReFetch(DynamicWrapper.eLoadOptions.Full);
                        }
                    }
                }

                if (counterZodiacMatches == 0)
                {
                    string noFriendsWithTheSameSign = string.Format("No Friends with Zodiac sign {0} to retrieve", this.MyZodiac.ZodiacSign);
                    listBoxFriendsSign1.Items.Add(noFriendsWithTheSameSign);
                }
            }
            catch (Exception ex)
            {
                this.listBoxFriendsSign1.Items.Add(string.Format("{0}..\n{1}", this.ErrorMsg, ex));
            }
        }

        private void FindMatchButton1_Click(object sender, EventArgs e)
        {
            this.fetchZodiacSignFriends();
        }
    }
}
