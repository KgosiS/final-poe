namespace CMCS1.ViewModels
{
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