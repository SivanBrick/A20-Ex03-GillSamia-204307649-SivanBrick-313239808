using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using FacebookWrapper.ObjectModel;

namespace Ex03.UI
{
    public class BestFanItems
    {
        public Action Command { get; set;}

        public String Text { get; set; }

        public virtual void Selected()
        {
            if (Command != null)
            {
                Command.Invoke();
            }
        }
    }
}
