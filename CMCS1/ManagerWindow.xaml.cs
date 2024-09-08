using System;
using System.Windows;

namespace CMCS1
{
    public partial class ManagerWindow : Window
    {
        public ManagerWindow()
        {
            InitializeComponent();
            // You can load claims data into the DataGrid here
            LoadClaimsData();
        }

        private void LoadClaimsData()
        {
            // Sample data to display in the DataGrid
            var claims = new[]
            {
                new { ClaimId = "C001", EmployeeId = "E123", Status = "Pending" },
                new { ClaimId = "C002", EmployeeId = "E124", Status = "Pending" },
            };

            ClaimsDataGrid.ItemsSource = claims;
        }

        // Approve Claim Button Click
        private void ApproveClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Approved!", "Success", MessageBoxButton.OK, MessageBoxImage.Information);
            // Logic to approve the claim and update the status in the database goes here.
        }

        // Reject Claim Button Click
        private void RejectClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim Rejected.", "Status", MessageBoxButton.OK, MessageBoxImage.Information);
            // Logic to reject the claim and update the status in the database goes here.
        }

        // View Document Button Click
        private void ViewDocument_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Opening Document...", "Document", MessageBoxButton.OK, MessageBoxImage.Information);
            // Logic to open the selected document.
        }

        // Download Document Button Click
        private void DownloadDocument_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Document Downloaded!", "Download", MessageBoxButton.OK, MessageBoxImage.Information);
            // Logic to download the document.
        }
    }
}
