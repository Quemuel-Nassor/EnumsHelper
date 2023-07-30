using System;

namespace EnumsHelper
{
    /// <summary>
    /// Specifies a description for a property or event.
    /// </summary>
    [AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
    public class ColorAttribute : Attribute
    {
        /// <summary>
        /// Gets the color name stored as color
        /// </summary>
        public string Name { get; }
        /// <summary>
        /// Gets the string (hex) color stored.
        /// </summary>
        public string Color { get; }

        /// <summary>
        /// Initializes a new instance of EnumsHelper.ColorAttribute.
        /// </summary>
        /// <param name="name">The color name</param>
        /// <param name="value">The color value</param>
        public ColorAttribute(string name, string value)
        {
            Name = name;
            Color = value;
        }
    }
}
