using System;
using System.Collections.Generic;
using System.Text;

namespace Dalworth.Controls
{
    public class CallMenuItem : System.Windows.Forms.MenuItem
    {
        private string m_altText;
        public string AltText
        {
            get { return m_altText; }
            set { m_altText = value; }
        }
    }
}