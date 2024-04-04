using System;
using System.ComponentModel.DataAnnotations;
using System.Reflection;
using CarRental.Extensions;

public static class EnumHelper
{
    public static string GetDisplayValue(Enum value)
    {
        var field = value.GetType().GetField(value.ToString());

        var displayAttribute = field.GetCustomAttribute<DisplayAttribute>(false);
        if (displayAttribute != null)
        {
            return displayAttribute.GetName();
        }

        return value.ToString();
    }
}
