using System.Windows.Forms;

namespace Clients
{
    public partial class ClientList : Form
    {
        public ClientList()
        {
            InitializeComponent();
            InitData();
            Init();
        }

        private void Init()
        {
            _saveFormButton.Click += (s, e) =>
            {
                var saveClient = new SaveClient();
                saveClient.Show();
            };
        }

        private void InitData()
        {
            var clients = DataAccess.GetClients();
            _clientListView.SetObjects(clients);
        }
    }
}