using System;
using System.Globalization;
using System.Windows.Data;
using System.Windows.Media;

namespace CMCS1.Converters
{
    public class StatusToColorConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            string status = value as string;

            switch (status)
            {
                case "Approved":
                    return new SolidColorBrush(Colors.Green);
                case "Rejected":
                    return new SolidColorBrush(Colors.Red);
                case "Pending":
                    return new SolidColorBrush(Colors.Orange);
                default:
                    return new SolidColorBrush(Colors.Gray);
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
