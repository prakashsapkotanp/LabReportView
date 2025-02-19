using System.ComponentModel.DataAnnotations;

namespace LabReportView.Server.Models
{
    public class AdminParametersModel
    {
        [Key]
        public int? ParameterId { get; set; }
        public string? ParameterGroupName { get; set; }
        public string? ParameterName { get; set; }
        public string? ParameterValue { get; set; }
        public string? ValueDataType { get; set; }
        public string? Description { get; set; }
        public string? ParameterType { get; set; }
        public string? ValueLookUpList { get; set; }
    }
}
