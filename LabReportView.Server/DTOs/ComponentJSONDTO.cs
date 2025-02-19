namespace LabReportView.Server.DTOs
{
    public class ComponentJSONDTO
    {
        public int? ComponentId { get; set; }
        public string? ComponentName { get; set; }
        public string? Unit { get; set; }
        public string? ValueType { get; set; }
        public string? ControlType { get; set; }
        public string? Range { get; set; }
        public string? RangeDescription { get; set; }
        public string? Method { get; set; }
        public object? ValueLookup { get; set; }
        public double? MinValue { get; set; }
        public double? MaxValue { get; set; }
        public string? DisplayName { get; set; }
        public int? DisplaySequence { get; set; }
        public int? IndentationCount { get; set; }
        public bool? ShowInSheet { get; set; }
        public int? ComponentMapId { get; set; }
        public string? MaleRange { get; set; }
        public string? FemaleRange { get; set; }
        public string? ChildRange { get; set; }
        public string? GroupName { get; set; }
        public int? ValuePrecision { get; set; }
    }
}
