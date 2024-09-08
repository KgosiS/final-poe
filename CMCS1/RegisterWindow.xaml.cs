using System.Windows;
using System.Windows.Controls;

namespace CMCS1
{
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            string name = NameTextBox.Text;
            string surname = SurnameTextBox.Text;
            string employeeId = RoleComboBox.Text;
            string role = ((ComboBoxItem)RoleComboBox.SelectedItem)?.Content.ToString();

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(surname) || string.IsNullOrEmpty(employeeId) || string.IsNullOrEmpty(role))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }


            // Logic to handle the user registration can go here (save user data etc.)

            // Redirect to appropriate window based on role
            Window nextWindow;

            switch (role)
            {
                case "Lecturer":
                    nextWindow = new LecturerWindow();
                    break;
                case "Admin":
                    nextWindow = new AdminWindow();
                    break;
                case "Coordinator":
                    nextWindow = new CoordinatorWindow();
                    break;
                case "Manager":
                    nextWindow = new ManagerWindow();
                    break;
                default:
                    MessageBox.Show("Invalid role selected.");
                    return;
            }

            nextWindow.Show();
            this.Close();
        }
        private void OpenLoginWindow_Click(object sender, RoutedEventArgs e)
        {
            // Open the LoginWindow
            LoginWindow loginWindow = new LoginWindow();
            loginWindow.Show();

            // Close the RegisterWindow after opening LoginWindow
            this.Close();
        }

    }
}
