using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Threading;

namespace EnumsHelper
{
    public static class EnumsHelperExtensions
    {
        /// <summary>
        /// Gets the data annotation value from the TEnum type description
        /// </summary>
        /// <typeparam name="TEnum">Enum type</typeparam>
        /// <param name="value">Enum value</param>
        /// <returns>Data annotation value from the TEnum type description</returns>
        public static string GetDescription<TEnum>(this TEnum value) where TEnum : struct, Enum
        {
            string description = string.Empty;

            TEnum[] enumValues = (TEnum[])Enum.GetValues(typeof(TEnum));

            if (!enumValues.Contains(value)) return description;

            FieldInfo fieldInfo = typeof(TEnum).GetField(value.ToString());

            if (fieldInfo != null)
            {
                object[] descriptions = fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
                description = ((DescriptionAttribute)descriptions.FirstOrDefault())?.Description;
            }

            return description;
        }

        /// <summary>
        /// Gets the data annotation value from the TEnum type color
        /// </summary>
        /// <typeparam name="TEnum">Enum type</typeparam>
        /// <param name="value">Enum value</param>
        /// <param name="name">Color name</param>
        /// <returns>Data annotation value from the TEnum type color</returns>
        public static string GetColor<TEnum>(this TEnum value, string name) where TEnum : struct, Enum
        {
            string color = string.Empty;

            if (string.IsNullOrWhiteSpace(name)) return color;

            TEnum[] enumValues = (TEnum[])Enum.GetValues(typeof(TEnum));

            if (!enumValues.Contains(value)) return color;

            FieldInfo fieldInfo = typeof(TEnum).GetField(value.ToString());

            if (fieldInfo != null)
            {
                ColorAttribute[] colors = (ColorAttribute[])fieldInfo.GetCustomAttributes(typeof(ColorAttribute), false);
                color = colors.FirstOrDefault(x => x.Name.Equals(name))?.Color;
            }

            return color;
        }

        /// <summary>
        /// Gets the day of the week formatted as text
        /// </summary>
        /// <param name="value">Day of week</param>
        /// <returns>The day of the week formatted as text</returns>
        public static string GetFormattedDayOfWeek(this DayOfWeek value)
        {
            string dayOfWeek = string.Empty;

            DayOfWeek[] enumValues = (DayOfWeek[])Enum.GetValues(typeof(DayOfWeek));

            if (!enumValues.Contains(value)) return dayOfWeek;

            dayOfWeek = DateTime.MinValue.AddDays(6).AddDays((double)value).ToString("dddd");
            dayOfWeek = Thread.CurrentThread.CurrentCulture.TextInfo.ToTitleCase(dayOfWeek);

            return dayOfWeek;
        }
    }
}
