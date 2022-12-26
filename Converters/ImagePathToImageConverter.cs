﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace BeautySalon1.Converters
{
    internal class ImagePathToImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is null)
            {
                // pack://siteoforigin:,,,/ выглядит не очень-то понятно

                return @"pack://siteoforigin:,,,/Assets/Images/Services/no_image.png";
            }

            var imageName = value.ToString();
            if (imageName.Contains("Услуги салона красоты"))
            {
                imageName = imageName.Substring(23);
            }    
            return $"pack://siteoforigin:,,,/Assets/Images/Services/{imageName}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
