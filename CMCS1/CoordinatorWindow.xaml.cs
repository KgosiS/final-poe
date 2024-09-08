using System.Windows;

namespace CMCS1
{
    public partial class CoordinatorWindow : Window
    {
        public CoordinatorWindow()
        {
            InitializeComponent();
            LoadClaims();
        }

        private void LoadClaims()
        {
            // Sample data for claims, replace with actual data source
            var claims = new[]
            {
                new { ClaimId = "101", Lecturer = "John Doe", Status = "Pending" },
                new { ClaimId = "102", Lecturer = "Jane Smith", Status = "Approved" },
                new { ClaimId = "103", Lecturer = "Michael Brown", Status = "Rejected" }
            };

            ClaimsDataGrid.ItemsSource = claims;
        }

        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim approved successfully!");
        }

        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim rejected.");
        }

        private void ViewDocument_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Document opened for viewing.");
        }
    }
}
