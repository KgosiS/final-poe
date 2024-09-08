using System.Windows;

namespace CMCS1
{
    public partial class LoginWindow : Window
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        // Event handler for Login Button click
        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string username = EmployeeIDTextBox.Text;
            string password = PasswordBox.Password;

            // Simulating role-based authentication with hard-coded data for demonstration
            // In a real-world scenario, you would query a database or authentication service.
            if (IsValidUser(username, password, out string role))
            {
                MessageBox.Show("Login successful!");

                // Open the appropriate window based on the user's role
                switch (role)
                {
                    case "Lecturer":
                        LecturerWindow lecturerWindow = new LecturerWindow();
                        lecturerWindow.Show();
                        break;

                    case "Coordinator":
                        CoordinatorWindow coordinatorWindow = new CoordinatorWindow();
                        coordinatorWindow.Show();
                        break;

                    case "Manager":
                        ManagerWindow managerWindow = new ManagerWindow();
                        managerWindow.Show();
                        break;

                    case "Admin":
                        AdminWindow adminWindow = new AdminWindow();
                        adminWindow.Show();
                        break;

                    default:
                        MessageBox.Show("Unknown role.");
                        break;
                }

                // Close the login window after successful login
                this.Close();
            }
            else
            {
                MessageBox.Show("Invalid username or password.");
            }
        }
        // Assuming you have a registration window class named RegisterWindow
        private void OpenRegisterWindow_Click(object sender, RoutedEventArgs e)
        {
            // Open the Register Window when the button is clicked
            RegisterWindow registerWindow = new RegisterWindow();
            registerWindow.Show();
        }

        // Function to validate user credentials and return the user's role
        private bool IsValidUser(string username, string password, out string role)
        {
            // Hard-coded example for demonstration. Replace this with actual authentication logic.
            role = string.Empty;

            // Example users (normally stored in a database)
            var users = new Dictionary<string, (string Password, string Role)>
            {
                { "lecturer", ("lecturer123", "Lecturer") },
                { "admin", ("admin123", "Admin") },
                { "coordinator", ("coord123", "Coordinator") },
                { "manager", ("manager123", "Manager") }
            };

            // Check if the user exists and password matches
            if (users.ContainsKey(username) && users[username].Password == password)
            {
                role = users[username].Role;
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
