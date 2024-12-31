using Newtonsoft.Json.Converters;

namespace DrawnFromSteel.Converters
{
    public class UtcDateTimeIsoJsonConverter : IsoDateTimeConverter
    {
        public UtcDateTimeIsoJsonConverter()
        {
            base.DateTimeFormat = "";
        }
    }
}
