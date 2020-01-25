using System;
using System.Windows.Forms;
using FacebookWrapper;



// $G$ THE-001 (-7) your grade on diagrams document - 93. please see comments inside the document. (50% of your grade).



namespace Ex02.UI
{
    public class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            Clipboard.SetText("designpatterns");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}