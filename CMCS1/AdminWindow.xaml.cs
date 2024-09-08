using System.Windows;
using System.Windows.Controls;

namespace CMCS1
{
    public partial class AdminWindow : Window
    {
        public AdminWindow()
        {
            InitializeComponent();
            LoadUsers();
        }

        // Load initial users into the list
        private void LoadUsers()
        {
            var users = new[]
            {
                "User 1: Lecturer",
                "User 2: Coordinator",
                "User 3: Manager"
            };
            foreach (var user in users)
            {
                UsersListBox.Items.Add(user);
            }
        }

        // Event handler for searching users
        private void SearchUser_Click(object sender, RoutedEventArgs e)
        {
            string searchQuery = SearchUserTextBox.Text;
            MessageBox.Show($"Search result for '{searchQuery}'");
        }

        // Event handler for adding users
        private void AddUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Add new user functionality goes here.");
        }

        // Event handler for removing users
        private void RemoveUser_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Selected user removed successfully.");
        }

        // Event handler for generating reports
        private void GenerateReport_Click(object sender, RoutedEventArgs e)
        {
            string selectedReport = (ReportsComboBox.SelectedItem as ComboBoxItem).Content.ToString();
            MessageBox.Show($"Generating {selectedReport}...");
        }

        // Event handler for opening system settings
        private void OpenSettings_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening system settings...");
        }
    }
}
