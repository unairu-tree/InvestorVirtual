namespace InvestorVirtual.Common.Extensions;

using System.Reflection;
using System.ComponentModel.DataAnnotations;

public static class EnumNameExtensions
{
    /// <summary>
    /// A reflection-based extension method that retrieves the Display attribute's Name property for a given enum value.
    /// </summary>
    /// <param name="value"></param>
    /// <returns></returns>
    public static string GetDisplayName(this Enum value)
    {
        FieldInfo? field = value.GetType().GetField(value.ToString());
        DisplayAttribute? attribute = field?.GetCustomAttribute<DisplayAttribute>();

        // Returns a regular .ToString() representation of the enum value if the Display attribute is not found.
        return attribute?.Name ?? value.ToString();
    }
}