using System.ComponentModel;

namespace Domain.Enums
{
    public enum Gender
    {
        [Description("Erkek")]
        Male = 1,
        [Description("Kadın")]
        Female = 2
    }
}

//var desc = typeof(TestType)
//   .GetField(TestType.BloodPressure.ToString())
//   .GetCustomAttribute<DescriptionAttribute>()?.Description;
