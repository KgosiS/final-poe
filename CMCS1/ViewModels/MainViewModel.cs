using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMCS1
{
    public class MainViewModel
    {
        public ObservableCollection<Claim> Claims { get; set; }

        public MainViewModel()
        {
            // Sample data for the Verify Claims tab
            Claims = new ObservableCollection<Claim>
            {
                new Claim { ClaimID = "1", LecturerName = "John Doe", HoursWorked = 35, HourlyRate = 150, TotalAmount = 5250, Status = "Pending" },
                new Claim { ClaimID = "2", LecturerName = "Jane Smith", HoursWorked = 40, HourlyRate = 160, TotalAmount = 6400, Status = "Approved" }
            };
        }
    }

    public class Claim
    {
        public string ClaimID { get; set; }
        public string LecturerName { get; set; }
        public int HoursWorked { get; set; }
        public int HourlyRate { get; set; }
        public int TotalAmount { get; set; }
        public string Status { get; set; }
    }
}
