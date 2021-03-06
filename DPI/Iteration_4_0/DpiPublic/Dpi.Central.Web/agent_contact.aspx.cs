using System;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using Dpi.Central.Web.Controls;
using DPI.Components;

namespace Dpi.Central.Web
{
    public class AgentContactPage : BasePage
    {
        #region Controls

        protected HtmlInputText _nameTextBox;
        protected HtmlInputText _companyTextBox;
        protected HtmlInputText _locationNumberTextBox;
        protected HtmlInputText _altPhoneNumberTextBox;
        protected HtmlInputText _phoneNumberTextBox;
        protected HtmlInputText _addressTextBox;
        protected HtmlInputText _cityTextBox;
        protected HtmlInputText _zipTextBox;
        protected HtmlInputCheckBox _pphpCheckBox;
        protected HtmlInputCheckBox _ppldCheckBox;
        protected HtmlInputCheckBox _ppcCheckBox;
        protected HtmlInputCheckBox _ppmcCheckBox;
        protected HtmlInputCheckBox _ppiCheckBox;
        protected HtmlInputCheckBox _bpCheckBox;
        protected HtmlTextArea _messageTextArea;
        protected Button _submitButton;
        protected HtmlInputText _emailTextBox;
        protected Dpi.Central.Web.Controls.Footer _footer;
        protected HtmlSelect _stateSelect;

        #endregion

        #region Web Form Designer generated code

        protected override void OnInit(EventArgs e)
        {
            //
            // CODEGEN: This call is required by the ASP.NET Web Form Designer.
            //
            InitializeComponent();
            base.OnInit(e);
        }

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._submitButton.Click += new System.EventHandler(this._submitButton_Click);

        }

        #endregion

        #region Event Handlers

        private void _submitButton_Click(object sender, EventArgs e)
        {
            string name = _nameTextBox.Value;
            string company = _companyTextBox.Value;
            string locationNumber = _locationNumberTextBox.Value;
            string email = _emailTextBox.Value;
            string phoneNumber = _phoneNumberTextBox.Value;
            string altPhoneNumber = _altPhoneNumberTextBox.Value == string.Empty
                ? "None given..." : _altPhoneNumberTextBox.Value;
            string address = _addressTextBox.Value;
            string city = _cityTextBox.Value;
            string zip = _zipTextBox.Value;
            string state = _stateSelect.Value;
            bool pphp = _pphpCheckBox.Checked;
            bool ppld = _ppldCheckBox.Checked;
            bool ppc = _ppcCheckBox.Checked;
            bool ppmc = _ppmcCheckBox.Checked;
            bool ppi = _ppiCheckBox.Checked;
            bool bp = _bpCheckBox.Checked;
            string message = _messageTextArea.Value;

            string body;

            body = "Name: " + name + "\n";
            body += "Company Name: " + company + "\n";
            body += "Number of locations: " + locationNumber + "\n";
            body += "E-Mail Address: " + email + "\n";
            body += "Phone Number: " + phoneNumber + "\n";
            body += "Alternate Phone Number: " + altPhoneNumber + "\n";
            body += "Address: " + address + "\n";
            body += "City: " + city + "\n";
            body += "State: " + state + "\n";
            body += "Zip Code: " + zip + "\n\n";
            body += "Interested in: ";

            if (pphp) {
                body += "Pre-Paid Home Phone, ";
            }
            if (ppld) {
                body += "Long Distance, ";
            }
            if (ppc) {
                body += "Pre-Paid Cellular, ";
            }
            if (ppmc) {
                body += "Pre-Paid MasterCard, ";
            }
            if (ppi) {
                body += "Pre-Paid Internet, ";
            }
            if (bp) {
                body += "Bill Pay Services, ";
            }

            body += "\nMessage: " + message;

            MailMessage msg = new MailMessage();

            msg.AddEmailTo("potentialagents@dpiteleconnect.com");
            msg.EmailFrom = email;
            msg.EmailSubject = "dPi Website Agent Inquiry";
            msg.EmailMessage = body;

            msg.SendMail();
        }

        #endregion
    }
}