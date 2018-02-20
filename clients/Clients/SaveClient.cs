using System.Windows.Forms;

namespace Clients
{
    public partial class SaveClient : Form
    {
        public SaveClient()
        {
            InitializeComponent();
            InitEvents();
        }

        private void InitEvents()
        {
            _save.Enabled = false;
            _save.Click += (sender, e) => Save();
            _lastName.LostFocus += (s, e) => Validate();
            _firstName.LostFocus += (s, e) => Validate();
            _dateOfBirth.LostFocus += (s, e) => Validate();
            _region.LostFocus += (s, e) => Validate();
            _address.LostFocus += (s, e) => Validate();
            _phoneNumber.LostFocus += (s, e) => Validate();
            _sex.LostFocus += (s, e) => Validate();
            _email.LostFocus += (s, e) => Validate();
            _nationality.LostFocus += (s, e) => Validate();
        }

        private void Save()
        {
            var client = new Client
            {
                FirstName = _firstName.Text,
                LastName = _lastName.Text,
                DateOfBirth = _dateOfBirth.Value,
                Region = _region.Text,
                Address = _address.Text,
                PhoneNumber = _phoneNumber.Text,
                Sex = _sex.Text,
                Email = _email.Text,
                Nationality = _nationality.Text
            };
            DataAccess.Store(client);
            MessageBox.Show("Successfully!");
        }

        private void Validate()
        {
            if (_firstName.Text.Length <= 0) return;
            if (_lastName.Text.Length <= 0) return;
            if (_dateOfBirth.Text.Length <= 0) return;
            if (_region.Text.Length <= 0) return;
            if (_address.Text.Length <= 0) return;
            if (_phoneNumber.Text.Length <= 0) return;
            if (_sex.Text.Length <= 0) return;
            if (_email.Text.Length <= 0) return;
            if (_email.Text.Length <= 0) return;

            _save.Enabled = true;
        }

        private void SaveClient_Load(object sender, System.EventArgs e)
        {

        }
    }
}