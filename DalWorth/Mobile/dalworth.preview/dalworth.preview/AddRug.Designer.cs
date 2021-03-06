namespace dalworth.preview
{
    partial class AddRug
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.menuItem1 = new System.Windows.Forms.MenuItem();
            this.m_menuCancel = new System.Windows.Forms.MenuItem();
            this.m_menuDone = new System.Windows.Forms.MenuItem();
            this.m_cmbShape = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.m_lblSquareFootage = new System.Windows.Forms.Label();
            this.m_lblDimenstion = new System.Windows.Forms.Label();
            this.m_txtWidth = new System.Windows.Forms.TextBox();
            this.m_txtHeight = new System.Windows.Forms.TextBox();
            this.m_lblMultiply = new System.Windows.Forms.Label();
            this.m_lblDiameter = new System.Windows.Forms.Label();
            this.m_txtDiameter = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.m_lblCleanCost = new System.Windows.Forms.Label();
            this.m_chkProtector = new System.Windows.Forms.CheckBox();
            this.m_chkPadding = new System.Windows.Forms.CheckBox();
            this.m_chkMothRepel = new System.Windows.Forms.CheckBox();
            this.m_chkRap = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.m_curOther = new QuickBooksAgent.Windows.UI.Controls.CurrencyEdit();
            this.m_lblProtectorCost = new System.Windows.Forms.Label();
            this.m_lblPaddingCost = new System.Windows.Forms.Label();
            this.m_lblMothRepelCost = new System.Windows.Forms.Label();
            this.m_lblRapCost = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.m_lblTotalCost = new System.Windows.Forms.Label();
            this.m_lblTaxAmount = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.m_lblTotal = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.m_lblJobTotal = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenu1
            // 
            this.mainMenu1.MenuItems.Add(this.menuItem1);
            this.mainMenu1.MenuItems.Add(this.m_menuDone);
            // 
            // menuItem1
            // 
            this.menuItem1.MenuItems.Add(this.m_menuCancel);
            this.menuItem1.Text = "Menu";
            // 
            // m_menuCancel
            // 
            this.m_menuCancel.Text = "Cancel";
            this.m_menuCancel.Click += new System.EventHandler(this.OnCancelClick);
            // 
            // m_menuDone
            // 
            this.m_menuDone.Text = "Done";
            this.m_menuDone.Click += new System.EventHandler(this.OnDoneClick);
            // 
            // m_cmbShape
            // 
            this.m_cmbShape.Items.Add("Rectangle");
            this.m_cmbShape.Items.Add("Round");
            this.m_cmbShape.Location = new System.Drawing.Point(57, 3);
            this.m_cmbShape.Name = "m_cmbShape";
            this.m_cmbShape.Size = new System.Drawing.Size(101, 22);
            this.m_cmbShape.TabIndex = 0;
            this.m_cmbShape.SelectedIndexChanged += new System.EventHandler(this.OnShapeChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.Text = "Shape";
            // 
            // m_lblSquareFootage
            // 
            this.m_lblSquareFootage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblSquareFootage.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.m_lblSquareFootage.Location = new System.Drawing.Point(164, 5);
            this.m_lblSquareFootage.Name = "m_lblSquareFootage";
            this.m_lblSquareFootage.Size = new System.Drawing.Size(73, 20);
            this.m_lblSquareFootage.Text = "15.00 SF";
            this.m_lblSquareFootage.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblDimenstion
            // 
            this.m_lblDimenstion.Location = new System.Drawing.Point(3, 29);
            this.m_lblDimenstion.Name = "m_lblDimenstion";
            this.m_lblDimenstion.Size = new System.Drawing.Size(64, 20);
            this.m_lblDimenstion.Text = "Dimension";
            // 
            // m_txtWidth
            // 
            this.m_txtWidth.Location = new System.Drawing.Point(94, 28);
            this.m_txtWidth.Name = "m_txtWidth";
            this.m_txtWidth.Size = new System.Drawing.Size(64, 21);
            this.m_txtWidth.TabIndex = 4;
            this.m_txtWidth.TextChanged += new System.EventHandler(this.OnWidthChanged);
            // 
            // m_txtHeight
            // 
            this.m_txtHeight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_txtHeight.Location = new System.Drawing.Point(173, 28);
            this.m_txtHeight.Name = "m_txtHeight";
            this.m_txtHeight.Size = new System.Drawing.Size(64, 21);
            this.m_txtHeight.TabIndex = 5;
            this.m_txtHeight.TextChanged += new System.EventHandler(this.OnHeightChanged);
            // 
            // m_lblMultiply
            // 
            this.m_lblMultiply.Location = new System.Drawing.Point(161, 30);
            this.m_lblMultiply.Name = "m_lblMultiply";
            this.m_lblMultiply.Size = new System.Drawing.Size(11, 20);
            this.m_lblMultiply.Text = "x";
            // 
            // m_lblDiameter
            // 
            this.m_lblDiameter.Location = new System.Drawing.Point(3, 29);
            this.m_lblDiameter.Name = "m_lblDiameter";
            this.m_lblDiameter.Size = new System.Drawing.Size(64, 20);
            this.m_lblDiameter.Text = "Diameter";
            // 
            // m_txtDiameter
            // 
            this.m_txtDiameter.Location = new System.Drawing.Point(94, 28);
            this.m_txtDiameter.Name = "m_txtDiameter";
            this.m_txtDiameter.Size = new System.Drawing.Size(64, 21);
            this.m_txtDiameter.TabIndex = 10;
            this.m_txtDiameter.TextChanged += new System.EventHandler(this.OnDiameterChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label5.Location = new System.Drawing.Point(5, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 20);
            this.label5.Text = "Clean";
            // 
            // m_lblCleanCost
            // 
            this.m_lblCleanCost.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblCleanCost.Location = new System.Drawing.Point(86, 54);
            this.m_lblCleanCost.Name = "m_lblCleanCost";
            this.m_lblCleanCost.Size = new System.Drawing.Size(66, 19);
            this.m_lblCleanCost.Text = "$15.00";
            this.m_lblCleanCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_chkProtector
            // 
            this.m_chkProtector.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.m_chkProtector.Location = new System.Drawing.Point(0, 0);
            this.m_chkProtector.Name = "m_chkProtector";
            this.m_chkProtector.Size = new System.Drawing.Size(72, 20);
            this.m_chkProtector.TabIndex = 14;
            this.m_chkProtector.Text = "Protector";
            this.m_chkProtector.CheckStateChanged += new System.EventHandler(this.OnProtectorChanged);
            // 
            // m_chkPadding
            // 
            this.m_chkPadding.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.m_chkPadding.Location = new System.Drawing.Point(0, 0);
            this.m_chkPadding.Name = "m_chkPadding";
            this.m_chkPadding.Size = new System.Drawing.Size(66, 20);
            this.m_chkPadding.TabIndex = 15;
            this.m_chkPadding.Text = "Padding";
            this.m_chkPadding.CheckStateChanged += new System.EventHandler(this.OnPaddingChanged);
            // 
            // m_chkMothRepel
            // 
            this.m_chkMothRepel.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.m_chkMothRepel.Location = new System.Drawing.Point(0, 0);
            this.m_chkMothRepel.Name = "m_chkMothRepel";
            this.m_chkMothRepel.Size = new System.Drawing.Size(83, 20);
            this.m_chkMothRepel.TabIndex = 16;
            this.m_chkMothRepel.Text = "Moth Repel";
            this.m_chkMothRepel.CheckStateChanged += new System.EventHandler(this.OnMothRepelChanged);
            // 
            // m_chkRap
            // 
            this.m_chkRap.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.m_chkRap.Location = new System.Drawing.Point(0, 0);
            this.m_chkRap.Name = "m_chkRap";
            this.m_chkRap.Size = new System.Drawing.Size(50, 20);
            this.m_chkRap.TabIndex = 17;
            this.m_chkRap.Text = "Rap";
            this.m_chkRap.CheckStateChanged += new System.EventHandler(this.OnRapChanged);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label7.Location = new System.Drawing.Point(6, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 20);
            this.label7.Text = "Other, $";
            // 
            // m_curOther
            // 
            this.m_curOther.Location = new System.Drawing.Point(88, 144);
            this.m_curOther.Name = "m_curOther";
            this.m_curOther.Size = new System.Drawing.Size(64, 20);
            this.m_curOther.TabIndex = 22;
            this.m_curOther.TextChanged += new System.EventHandler(this.OnOtherAmountChanged);
            // 
            // m_lblProtectorCost
            // 
            this.m_lblProtectorCost.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblProtectorCost.Location = new System.Drawing.Point(86, 70);
            this.m_lblProtectorCost.Name = "m_lblProtectorCost";
            this.m_lblProtectorCost.Size = new System.Drawing.Size(66, 19);
            this.m_lblProtectorCost.Text = "$15.00";
            this.m_lblProtectorCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblPaddingCost
            // 
            this.m_lblPaddingCost.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblPaddingCost.Location = new System.Drawing.Point(86, 88);
            this.m_lblPaddingCost.Name = "m_lblPaddingCost";
            this.m_lblPaddingCost.Size = new System.Drawing.Size(66, 19);
            this.m_lblPaddingCost.Text = "$15.00";
            this.m_lblPaddingCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblMothRepelCost
            // 
            this.m_lblMothRepelCost.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblMothRepelCost.Location = new System.Drawing.Point(86, 106);
            this.m_lblMothRepelCost.Name = "m_lblMothRepelCost";
            this.m_lblMothRepelCost.Size = new System.Drawing.Size(66, 19);
            this.m_lblMothRepelCost.Text = "$15.00";
            this.m_lblMothRepelCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblRapCost
            // 
            this.m_lblRapCost.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblRapCost.Location = new System.Drawing.Point(86, 124);
            this.m_lblRapCost.Name = "m_lblRapCost";
            this.m_lblRapCost.Size = new System.Drawing.Size(66, 19);
            this.m_lblRapCost.Text = "$15.00";
            this.m_lblRapCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label2.Location = new System.Drawing.Point(161, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 20);
            this.label2.Text = "Sub Total:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblTotalCost
            // 
            this.m_lblTotalCost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblTotalCost.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblTotalCost.Location = new System.Drawing.Point(158, 85);
            this.m_lblTotalCost.Name = "m_lblTotalCost";
            this.m_lblTotalCost.Size = new System.Drawing.Size(79, 20);
            this.m_lblTotalCost.Text = "$200.00";
            this.m_lblTotalCost.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblTaxAmount
            // 
            this.m_lblTaxAmount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblTaxAmount.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblTaxAmount.Location = new System.Drawing.Point(158, 116);
            this.m_lblTaxAmount.Name = "m_lblTaxAmount";
            this.m_lblTaxAmount.Size = new System.Drawing.Size(79, 20);
            this.m_lblTaxAmount.Text = "$20.00";
            this.m_lblTaxAmount.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label12.Location = new System.Drawing.Point(161, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(76, 20);
            this.label12.Text = "Tax:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Regular);
            this.label13.Location = new System.Drawing.Point(154, 132);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(83, 20);
            this.label13.Text = "Total:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // m_lblTotal
            // 
            this.m_lblTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblTotal.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.m_lblTotal.Location = new System.Drawing.Point(158, 146);
            this.m_lblTotal.Name = "m_lblTotal";
            this.m_lblTotal.Size = new System.Drawing.Size(79, 20);
            this.m_lblTotal.Text = "$207.00";
            this.m_lblTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_chkProtector);
            this.panel1.Location = new System.Drawing.Point(3, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(83, 20);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.m_chkPadding);
            this.panel2.Location = new System.Drawing.Point(3, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(83, 20);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.m_chkMothRepel);
            this.panel3.Location = new System.Drawing.Point(3, 103);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(83, 20);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.m_chkRap);
            this.panel4.Location = new System.Drawing.Point(3, 121);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(83, 20);
            // 
            // m_lblJobTotal
            // 
            this.m_lblJobTotal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.m_lblJobTotal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.m_lblJobTotal.Location = new System.Drawing.Point(154, 167);
            this.m_lblJobTotal.Name = "m_lblJobTotal";
            this.m_lblJobTotal.Size = new System.Drawing.Size(83, 20);
            this.m_lblJobTotal.Text = "$207.00";
            this.m_lblJobTotal.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.Location = new System.Drawing.Point(69, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.Text = "Job Total:";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // AddRug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 268);
            this.Controls.Add(this.m_lblJobTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.m_lblTotal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.m_lblTaxAmount);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.m_lblTotalCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.m_lblRapCost);
            this.Controls.Add(this.m_lblMothRepelCost);
            this.Controls.Add(this.m_lblPaddingCost);
            this.Controls.Add(this.m_lblProtectorCost);
            this.Controls.Add(this.m_curOther);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.m_lblCleanCost);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.m_txtDiameter);
            this.Controls.Add(this.m_lblDiameter);
            this.Controls.Add(this.m_lblMultiply);
            this.Controls.Add(this.m_txtHeight);
            this.Controls.Add(this.m_txtWidth);
            this.Controls.Add(this.m_lblDimenstion);
            this.Controls.Add(this.m_lblSquareFootage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.m_cmbShape);
            this.Menu = this.mainMenu1;
            this.Name = "AddRug";
            this.Text = "0231 Add Rug";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuItem m_menuCancel;
        private System.Windows.Forms.MenuItem m_menuDone;
        private System.Windows.Forms.ComboBox m_cmbShape;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label m_lblSquareFootage;
        private System.Windows.Forms.Label m_lblDimenstion;
        private System.Windows.Forms.TextBox m_txtWidth;
        private System.Windows.Forms.TextBox m_txtHeight;
        private System.Windows.Forms.Label m_lblMultiply;
        private System.Windows.Forms.Label m_lblDiameter;
        private System.Windows.Forms.TextBox m_txtDiameter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label m_lblCleanCost;
        private System.Windows.Forms.CheckBox m_chkProtector;
        private System.Windows.Forms.CheckBox m_chkPadding;
        private System.Windows.Forms.CheckBox m_chkMothRepel;
        private System.Windows.Forms.CheckBox m_chkRap;
        private System.Windows.Forms.Label label7;
        private QuickBooksAgent.Windows.UI.Controls.CurrencyEdit m_curOther;
        private System.Windows.Forms.Label m_lblProtectorCost;
        private System.Windows.Forms.Label m_lblPaddingCost;
        private System.Windows.Forms.Label m_lblMothRepelCost;
        private System.Windows.Forms.Label m_lblRapCost;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label m_lblTotalCost;
        private System.Windows.Forms.Label m_lblTaxAmount;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label m_lblTotal;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.MenuItem menuItem1;
        private System.Windows.Forms.Label m_lblJobTotal;
        private System.Windows.Forms.Label label4;
    }
}