using LabReportView.Server.ApplicationDbContext;
using LabReportView.Server.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace LabReportView.Server.Controllers.LabReport
{
    [Route("api/labReport")]
    [ApiController]
    public class LabReportController: ControllerBase
    {
        //private readonly ILabReportService _labReportService;
        //private readonly ILabReportServiceNew _labReportService;

        private readonly ILabReportServiceNew _labReportServiceNew;
        public LabReportController(ILabReportServiceNew labReportService)
        {
            _labReportServiceNew = labReportService;

        }
        [HttpGet]
        [Route("LabReportByRequisitionIds")]
        public IActionResult LabReportByRequisitionIds(long barCodeNumber)
        {
           //var result =   _labReportService.GetLabReportByRequisitionIds(barCodeNumber);
           var result = _labReportServiceNew.GetLabReportByBarcodeNumber(barCodeNumber);
            return Ok(result);
        }
    }
}
