using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;

namespace Dalworth.Windows.PendingTransactionDetails
{
    public partial class PendingTransactionDetailsView : BaseControl
    {
        public PendingTransactionDetailsView()
        {
            InitializeComponent();
        }

        protected override void ApplyUIResources(System.Globalization.CultureInfo cultureInfo)
        {
            base.ApplyUIResources(cultureInfo);

            Text = "Transaction Details";
        }
    }
}