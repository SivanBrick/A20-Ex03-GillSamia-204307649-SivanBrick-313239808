using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex03.UI
{
    internal class FactoryMethod
    {
        internal static Form FeatureFormCreator(User i_LoggedInUser, eFacebookFeatures i_FeatureChosen)
        {
            Form featureToForm = null;
            switch (i_FeatureChosen)
            {
                case (eFacebookFeatures.BestFan):
                    featureToForm = new BestFanForm(i_LoggedInUser);
                    break;
                case (eFacebookFeatures.ZodiacMatch):
                    featureToForm = new ZodiacMatchForm(i_LoggedInUser);
                    break;
                default:
                    MessageBox.Show("somthing went wrong..");
                    break;
            }

            return featureToForm;
        }
    }
}
