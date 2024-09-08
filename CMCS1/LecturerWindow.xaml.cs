using Microsoft.Win32;
using System.Windows;

namespace CMCS1
{
    public partial class LecturerWindow : Window
    {
        public LecturerWindow()
        {
            InitializeComponent();
        }

        private void SubmitClaim_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Claim submitted successfully!");
        }

        private void BrowseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == true)
            {
                DocumentPathTextBox.Text = openFileDialog.FileName;
            }
        }

        private void UploadDocument_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Document uploaded successfully!");
        }
    }
}
