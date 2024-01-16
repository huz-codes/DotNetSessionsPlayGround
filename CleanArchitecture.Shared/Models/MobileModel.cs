namespace CleanArchitecture.Shared.Models
{
    public class MobileModel
    {
        public string id { get; set; } = string.Empty;
        public string name { get; set; } = string.Empty;
        public DateTimeOffset CreatedAt { get; set; }
        public Data Data { get; set; } = new();
    }

    public class Data
    {
        public string Color { get; set; } = string.Empty;
        public string Capacity { get; set; } = string.Empty;
        public int CapacityGB { get; set; }
        public float Price { get; set; }
        public string Generation { get; set; } = string.Empty;
        public int Year { get; set; }
        public string CPUmodel { get; set; } = string.Empty;
        public string Harddisksize { get; set; } = string.Empty;
        public string StrapColour { get; set; } = string.Empty;
        public string CaseSize { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public float Screensize { get; set; }
    }

}
