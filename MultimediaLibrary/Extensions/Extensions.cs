using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MultimediaLibrary.Extensions
{
    public static class Extensions
    {
        public static string GetDisplayName(this System.Enum enumValue)
        {
            try
            {
                return enumValue.GetType()
                        .GetMember(enumValue.ToString())
                        .First()
                        .GetCustomAttribute<DisplayAttribute>()
                        .Name;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
