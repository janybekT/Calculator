namespace Clients
{
    partial class ClientList
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientList));
          
            this._firstName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._dateOfBirth = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._region = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._address = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._phoneNumber = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._sex = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._email = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this._nattionality = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this._saveFormButton = new System.Windows.Forms.ToolStripButton();
            this.Open = new System.Windows.Forms.ToolStripLabel();
            this._lastName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            _clientListView = new BrightIdeasSoftware.ObjectListView();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(_clientListView)).BeginInit();
            this.SuspendLayout();
            // 
            // _firstName
            // 
            this._firstName.AspectName = "FirstName";
            this._firstName.CellPadding = null;
            this._firstName.Text = "First Name";
            this._firstName.Width = 72;
            // 
            // _dateOfBirth
            // 
            this._dateOfBirth.AspectName = "DateOfBirth";
            this._dateOfBirth.CellPadding = null;
            this._dateOfBirth.Text = "DateOfBirth";
            this._dateOfBirth.Width = 73;
            // 
            // _region
            // 
            this._region.AspectName = "Region";
            this._region.CellPadding = null;
            this._region.Text = "Region";
            // 
            // _address
            // 
            this._address.AspectName = "Address";
            this._address.CellPadding = null;
            this._address.Text = "Address";
            // 
            // _phoneNumber
            // 
            this._phoneNumber.AspectName = "PhoneNumber";
            this._phoneNumber.CellPadding = null;
            this._phoneNumber.Text = "PhoneNumber";
            this._phoneNumber.Width = 89;
            // 
            // _sex
            // 
            this._sex.AspectName = "Sex";
            this._sex.CellPadding = null;
            this._sex.Text = "Sex";
            // 
            // _email
            // 
            this._email.AspectName = "Email";
            this._email.CellPadding = null;
            this._email.Text = "Email";
            // 
            // _nattionality
            // 
            this._nattionality.AspectName = "Nattionality";
            this._nattionality.CellPadding = null;
            this._nattionality.Text = "Nattionality";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._saveFormButton,
            this.Open});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(669, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // _saveFormButton
            // 
            this._saveFormButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this._saveFormButton.Image = ((System.Drawing.Image)(resources.GetObject("_saveFormButton.Image")));
            this._saveFormButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this._saveFormButton.Name = "_saveFormButton";
            this._saveFormButton.Size = new System.Drawing.Size(23, 22);
            this._saveFormButton.Text = "toolStripButton1";
            // 
            // Open
            // 
            this.Open.Name = "Open";
            this.Open.Size = new System.Drawing.Size(36, 22);
            this.Open.Text = "Open";
            // 
            // _lastName
            // 
            this._lastName.AspectName = "LastName";
            this._lastName.CellPadding = null;
            this._lastName.Text = "Last Name";
            // 
            // _clientListView
            // 
            _clientListView.AllColumns.Add(this._firstName);
            _clientListView.AllColumns.Add(this._lastName);
            _clientListView.AllColumns.Add(this._dateOfBirth);
            _clientListView.AllColumns.Add(this._region);
            _clientListView.AllColumns.Add(this._address);
            _clientListView.AllColumns.Add(this._phoneNumber);
            _clientListView.AllColumns.Add(this._sex);
            _clientListView.AllColumns.Add(this._email);
            _clientListView.AllColumns.Add(this._nattionality);
            _clientListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this._firstName,
            this._lastName,
            this._dateOfBirth,
            this._region,
            this._address,
            this._phoneNumber,
            this._sex,
            this._email,
            this._nattionality});
            _clientListView.HasCollapsibleGroups = false;
            _clientListView.Location = new System.Drawing.Point(12, 27);
            _clientListView.Name = "_clientListView";
            _clientListView.ShowGroups = false;
            _clientListView.Size = new System.Drawing.Size(656, 298);
            _clientListView.SortGroupItemsByPrimaryColumn = false;
            _clientListView.TabIndex = 0;
            _clientListView.UseCompatibleStateImageBehavior = false;
            _clientListView.View = System.Windows.Forms.View.Details;
            // 
            // ClientList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 411);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(_clientListView);
            this.Name = "ClientList";
            this.Text = "ClientLIst";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(_clientListView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BrightIdeasSoftware.OLVColumn _firstName;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton _saveFormButton;
        private System.Windows.Forms.ToolStripLabel Open;
        private BrightIdeasSoftware.OLVColumn _dateOfBirth;
        private BrightIdeasSoftware.OLVColumn _region;
        private BrightIdeasSoftware.OLVColumn _address;
        private BrightIdeasSoftware.OLVColumn _phoneNumber;
        private BrightIdeasSoftware.OLVColumn _sex;
        private BrightIdeasSoftware.OLVColumn _email;
        private BrightIdeasSoftware.OLVColumn _nattionality;
        private BrightIdeasSoftware.OLVColumn _lastName;
        private BrightIdeasSoftware.ObjectListView _clientListView;
    }
}