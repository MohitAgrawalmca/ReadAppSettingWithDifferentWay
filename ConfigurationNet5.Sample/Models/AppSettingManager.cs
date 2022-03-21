namespace ConfigurationNet5.Sample.Models
{
    public class AppSettingManager
    {
        public Setting Settings { get; set; }

    }

    public class Setting
    {
        public string Config1 { get; set; }
        public string Config2 { get; set; }
        public string Config3 { get; set; }
    }
}
