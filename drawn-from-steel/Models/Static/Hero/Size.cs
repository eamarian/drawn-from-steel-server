using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;

namespace DrawnFromSteel.Models.Static.Hero
{
    public enum SizeModifier
    {
        [Description("")]
        None,
        [Description("S")]
        Small,
        [Description("M")]
        Medium,
        [Description("L")]
        Large
    }

    public static class EnumExtension
    {
        public static string GetDescription(this Enum value)
        {
            FieldInfo? field = value.GetType().GetField(value.ToString());
            if (field == null)
            {
                return string.Empty;
            }

            DescriptionAttribute? attribute = Attribute.GetCustomAttribute(field, typeof(DescriptionAttribute)) as DescriptionAttribute;

            return attribute == null ? string.Empty : attribute.Description;
        }
    }

    [ComplexType]
    public class Size
    {
        public const int DEFAULT_SQUARES = 1;
        public const SizeModifier DEFAULT_SIZE_MODIFIER = SizeModifier.Medium;

        public int Squares { get; private set; }
        public SizeModifier Modifier { get; private set; } = SizeModifier.None;
        public bool IsDefault { get => Squares == DEFAULT_SQUARES && Modifier == DEFAULT_SIZE_MODIFIER; }

        public Size(int squares, SizeModifier modifier = SizeModifier.None)
        {
            switch (squares)
            {
                case <= 0:
                    throw new ArgumentOutOfRangeException(nameof(squares), "must be positive");
                case 1:
                    if (modifier == SizeModifier.None) throw new ArgumentException("Modifier must be specified if squares is 1.", nameof(modifier));
                    break;
                case > 1:
                    if (modifier != SizeModifier.None) throw new ArgumentException("Modifier can only be specified if squares is 1.", nameof(modifier));
                    break;
            }

            Squares = squares;
            Modifier = modifier;
        }

        public override string ToString()
        {
            return Squares.ToString() + Modifier.GetDescription();
        }
    }
}
