using System;
using System.ComponentModel;
using System.Linq;

namespace JC.Samples.MsiExecConsoleDemo.Extensions
{
    /// <summary>
    /// Provides Enum Extension Methods.
    /// </summary>
    public static class EnumExtensions
    {
        #region Methods

        /// <summary>
        /// Gets the Description attribute of an Enum.
        /// </summary>
        /// <param name="value">The Enum value</param>
        /// <returns>The Description of the Enum as a string, 
        /// or the ToString() representation of the Enum if a Description is unavailable</returns>
        public static string GetEnumDescription(this Enum value)
        {
            try
            {
                var fieldInfo  = value.GetType().GetField(value.ToString());
                var attributes = (DescriptionAttribute[])fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);

                if (attributes?.Any() == true) return attributes.First().Description;
                else return value.ToString();
            }
            catch
            {
                return value.ToString();
            }
        }

        #endregion
    }
}