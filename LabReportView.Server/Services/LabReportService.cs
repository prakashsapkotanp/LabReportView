//using System.Data;
//using LabReportView.Server.ApplicationDbContext;
//using LabReportView.Server.DTOs;
//using LabReportView.Server.Enums;
//using LabReportView.Server.Interfaces;
//using LabReportView.Server.Models;
//using Microsoft.Data.SqlClient;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using static LabReportView.Server.Models.ReportLookUp;

//namespace LabReportView.Server.Services
//{
//    public class LabReportService : ILabReportService
//    {
//        //public static string CovidFileUrlCommon;
//        public List<EmployeeModel>? empList = new List<EmployeeModel>();
//        private readonly LabDbContext _labDbContext;
//        public static string CovidFileUrlCommon;

//        //public  string GetLabReportByRequisitionIds( long barcodeNumber)
//        //{
//        //    string connectionString = "Data Source=DESKTOP-2Q13LIC;Initial Catalog=DanpheEMR_LPH_LIVE;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";
//        //    DataTable dataTable = GetData(connectionString, barcodeNumber);
//        //    return dataTable.ToString();
//        //}


//        public object GetLabReportByBarcodeNumber(long barCodeNumber)
//        {
//            string connectionString = "Data Source=DESKTOP-2Q13LIC;Initial Catalog=DanpheEMR_LPH_LIVE;Integrated Security=True;MultipleActiveResultSets=true;TrustServerCertificate=True;";

//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                //using (SqlCommand command = new SqlCommand("SP_LAB_GetReportDetailsByBarCode", connection))
//                using (SqlCommand command = new SqlCommand("SP_LAB_GetReportDetailsByBarCode", connection))
//                {
//                    command.CommandType = CommandType.StoredProcedure;
//                    command.Parameters.AddWithValue("@BarCodeNumber", barCodeNumber.ToString());

//                    connection.Open();
//                    using (SqlDataReader reader = command.ExecuteReader())
//                    {
//                        if (reader.Read())
//                        {
//                            string jsonResult = reader.IsDBNull(0) ? null : reader.GetString(0);
//                            //var result = ConvertDataTableToJSON(jsonResult);
//                            //return result;
//                            return jsonResult; 
//                        }
//                    }
//                }
//            }
//            return null;
//        }

//        private  DataTable GetData(string connectionString, long barcodeNumber)
//        {
//            DataTable dataTable = new DataTable();
//            using (SqlConnection connection = new SqlConnection(connectionString))
//            {
//                using (SqlCommand command = new SqlCommand("SP_LAB_GetDenormalizedReportDetails", connection))
//                {
//                    command.CommandType = CommandType.StoredProcedure;
//                    command.Parameters.Add("@BarCodeNumber", SqlDbType.Int).Value = barcodeNumber;

//                    connection.Open();
//                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
//                    {
//                        adapter.Fill(dataTable);
//                    }
//                }
//            }
//            return dataTable;
//        }

//        private  string ConvertDataTableToJSON(DataTable dataTable)
//        {
//            if (dataTable == null || dataTable.Rows.Count == 0)
//            {
//                return JsonConvert.SerializeObject(new { Results = new { } }); 
//            }

//            var lookups = ExtractLookups(dataTable.Rows[0]);

//            // Extract Columns (assuming it's the same for all rows)
//            string columnsJson = dataTable.Rows[0]["ColSettingsJSON"]?.ToString() ?? "{\"Name\":true,\"Result\":true,\"Range\":true,\"Method\":true,\"Unit\":true,\"Remarks\":false}";

//            // Extract ReportId
//            int reportId = Convert.ToInt32(dataTable.Rows[0]["LabReportId"]);

//            // Extract Signatories (This part needs to be adjusted based on how signatories are stored. Assuming a single signatory for simplicity)
//            var signatories = ExtractSignatories(dataTable.Rows[0]);

//            // Extract Template Information
//            var templateInfo = ExtractTemplateInfo(dataTable);

//            // Extract Footer Text and Comments
//            string footerText = dataTable.Rows[0]["FooterText"]?.ToString() ?? "Please correlate with clinical significant. ";
//            string comments = dataTable.Rows[0]["LabReportComments"]?.ToString();

//            // Other properties
//            bool isPrinted = Convert.ToBoolean(dataTable.Rows[0]["IsPrinted"]);
//            DateTime createdOn = Convert.ToDateTime(dataTable.Rows[0]["CreatedOn"]);
//            int createdBy = Convert.ToInt32(dataTable.Rows[0]["CreatedBy"]);
//            DateTime reportCreatedOn = Convert.ToDateTime(dataTable.Rows[0]["ReportCreatedOn"]);
//            int reportCreatedBy = Convert.ToInt32(dataTable.Rows[0]["ReportCreatedBy"]);
//            int barCodeNumber = Convert.ToInt32(dataTable.Rows[0]["BarCodeNumber"]);
//            DateTime printedOn = Convert.ToDateTime(dataTable.Rows[0]["PrintedOn"]);
//            int printedBy = Convert.ToInt32(dataTable.Rows[0]["PrintedBy"]);
//            int printCount = Convert.ToInt32(dataTable.Rows[0]["PrintCount"]);
//            string printedByName = dataTable.Rows[0]["PrintedByName"]?.ToString();
//            bool hasInsurance = Convert.ToBoolean(dataTable.Rows[0]["HasInsurance"]);

//            var results = new
//            {
//                Header = dataTable.Rows[0]["HeaderText"]?.ToString() ?? "HAEMATOLOGY", // Default Header
//                Lookups = lookups,
//                Columns = columnsJson,
//                ReportId = reportId,
//                //Signatories = signatories,
//                TemplateId = templateInfo.TemplateId,
//                TemplateType = templateInfo.TemplateType,
//                TemplateHTML = templateInfo.TemplateHTML,
//                TemplateName = templateInfo.TemplateName,
//                FooterText = footerText,
//                Comments = comments,
//                IsPrinted = isPrinted,
//                ValidToPrint = true,
//                CreatedOn = createdOn,
//                CreatedBy = createdBy,
//                ReportCreatedOn = reportCreatedOn,
//                ReportCreatedBy = reportCreatedBy,
//                BarCodeNumber = barCodeNumber,
//                PrintedOn = printedOn,
//                PrintedBy = printedBy,
//                PrintCount = printCount,
//                PrintedByName = printedByName,
//                HasInsurance = hasInsurance,
//                Templates = new[] { templateInfo.Template }
//            };

//            return JsonConvert.SerializeObject(new { Results = results }, Newtonsoft.Json.Formatting.Indented);
//        }

//        private  dynamic ExtractLookups(DataRow row)
//        {
//            return new
//            {
//                PatientId = row["PatientId"],
//                PatientName = row["PatientName"]?.ToString(),
//                PatientCode = row["PatientCode"]?.ToString(),
//                Gender = row["Gender"]?.ToString(),
//                DOB = Convert.ToDateTime(row["DOB"]).ToString("yyyy-MM-ddTHH:mm:ss"),
//                PhoneNumber = row["PhoneNumber"]?.ToString(),
//                Address = row["Address"]?.ToString(),
//                MunicipalityName = row["MunicipalityName"]?.ToString(),
//                CountrySubDivisionName = row["CountrySubDivisionName"]?.ToString(),
//                ReferredById = row["ReferredById"],
//                ReferredBy = row["ProviderName"]?.ToString() ?? "SELF", // Default to SELF if null
//                ReceivingDate = Convert.ToDateTime(row["ReceivingDate"]).ToString("yyyy-MM-ddTHH:mm:ss"),
//                ReportingDate = Convert.ToDateTime(row["ReportingDate"]).ToString("yyyy-MM-ddTHH:mm:ss.fffffff"),
//                SampleDate = Convert.ToDateTime(row["SampleDate"]).ToString("yyyy-MM-ddTHH:mm:ss.f"),
//                SampleCode = row["SampleCode"],
//                VerifiedOn = Convert.ToDateTime(row["VerifiedOn"]).ToString("yyyy-MM-ddTHH:mm:ss.fff"),
//                SampleCodeFormatted = row["SampleCodeFormatted"]?.ToString(),
//                VisitType = row["VisitType"]?.ToString(),
//                RunNumberType = row["RunNumberType"]?.ToString(),
//                Specimen = row["Specimen"]?.ToString(),
//                LabTypeName = row["LabTypeName"]?.ToString()
//            };
//        }

//        private  dynamic ExtractSignatories(DataRow row)
//        {
//            // Assuming a single signatory for simplicity. Adjust if multiple signatories exist.

//            return new[] {
//            new {
//                EmployeeId = row["EmployeeId"], // Hardcoded, might need adjustment
//                EmployeeFullName = row["EmployeeFullName"], // Hardcoded, might need adjustment
//                Signature = row["Signature"], // Hardcoded, might need adjustment
//                SignatoryImageName =  row["SignatoryImageName"],
//                DisplaySequence =  row["DisplaySequence"],
//                Show =  row["Show"],
//            }
//        };
//        }

//        private static (int TemplateId, string TemplateName, string TemplateType, string TemplateHTML, dynamic Template) ExtractTemplateInfo(DataTable dataTable)
//        {
//            // Assuming same TemplateId, TemplateName, TemplateType, TemplateHTML for all rows.
//            DataRow row = dataTable.Rows[0];

//            int templateId = Convert.ToInt32(row["TemplateId"]);
//            string templateName = row["ReportTemplateName"]?.ToString() ?? "HEMATOLOGY"; // Default Name
//            string templateType = row["TemplateType"]?.ToString() ?? "normal";       // Default Type
//            string templateHTML = row["TemplateHTML"]?.ToString();

//            var tests = new List<dynamic>();
//            foreach (DataRow dataRow in dataTable.Rows)
//            {
//                tests.Add(ExtractTestInfo(dataRow));
//            }
//            // Group tests by TestName to avoid duplicates
//            var groupedTests = tests.GroupBy(t => t.TestName).Select(group => group.First()).ToList();

//            var template = new
//            {
//                TemplateId = templateId,
//                TemplateName = templateName,
//                TemplateType = templateType,
//                TemplateHtml = templateHTML,
//                HeaderText = row["HeaderText"]?.ToString() ?? "HAEMATOLOGY", // Default Header
//                FooterText = row["FooterText"]?.ToString() ?? "Please correlate with clinical significant. ", // Default Footer
//                TemplateColumns = dataTable.Rows[0]["ColSettingsJSON"]?.ToString() ?? "{\"Name\":true,\"Result\":true,\"Range\":true,\"Method\":true,\"Unit\":true,\"Remarks\":false}",
//                Tests = groupedTests
//            };

//            return (templateId, templateName, templateType, templateHTML, template);
//        }

//        private static dynamic ExtractTestInfo(DataRow row)
//        {
//            string testName = row["LabTestName"]?.ToString();
//            string reportingName = row["ReportingName"]?.ToString();
//            int requisitionId = Convert.ToInt32(row["RequisitionId"]);
//            int labTestId = Convert.ToInt32(row["LabTestId"]);

//            var componentJSON = ExtractComponentJSON(row);
//            var components = ExtractComponents(row);

//            bool hasNegativeResults = Convert.ToBoolean(row["HasNegativeResults"]);
//            string negativeResultText = row["NegativeResultText"]?.ToString();
//            DateTime requestDate = Convert.ToDateTime(row["CreatedOn"]);
//            string comments = row["Comments"]?.ToString();
//            int displaySequence = Convert.ToInt32(row["TestDisplaySequence"]);
//            string interpretation = row["Interpretation"]?.ToString();

//            string specimen = row["LabTestSpecimen"]?.ToString();
//            DateTime sampleCollectedOn = Convert.ToDateTime(row["SampleCreatedOn"]);
//            var vendorDetail = ExtractVendorDetail(row);
//            bool hasInsurance = Convert.ToBoolean(row["HasInsurance"]);
//            string billingStatus = row["BillingStatus"]?.ToString();
//            int verifiedBy = Convert.ToInt32(row["VerifiedBy"]);
//            DateTime verifiedOn = Convert.ToDateTime(row["VerifiedOn"]);
//            int resultingVendorId = Convert.ToInt32(row["ResultingVendorId"]);
//            int maxResultGroup = Convert.ToInt32(row["ResultGroup"]);
//            bool isLISApplicable = Convert.ToBoolean(row["IsLISApplicable"]);

//            return new
//            {
//                TestName = testName,
//                ReportingName = reportingName,
//                RequisitionId = requisitionId,
//                LabTestId = labTestId,
//                ComponentJSON = new[] { componentJSON }, // Adjusted to be an array
//                HasNegativeResults = hasNegativeResults,
//                NegativeResultText = negativeResultText,
//                RequestDate = requestDate.ToString("yyyy-MM-ddTHH:mm:ss.fff"),
//                Comments = comments,
//                DisplaySequence = displaySequence,
//                Interpretation = interpretation,
//                Components = new[] { components }, // Adjusted to be an array
//                Specimen = specimen,
//                SampleCollectedBy = "Bharat KC", //Hardcoded Value
//                SampleCollectedOn = sampleCollectedOn.ToString("yyyy-MM-ddTHH:mm:ss.f"),
//                VendorDetail = vendorDetail,
//                HasInsurance = hasInsurance,
//                BillingStatus = billingStatus,
//                VerifiedBy = verifiedBy,
//                VerifiedOn = verifiedOn.ToString("yyyy-MM-ddTHH:mm:ss.fff"),
//                ResultingVendorId = resultingVendorId,
//                MaxResultGroup = maxResultGroup,
//                IsLISApplicable = isLISApplicable
//            };
//        }

//        private static dynamic ExtractComponentJSON(DataRow row)
//        {
//            return new
//            {
//                ComponentId = row["ComponentId"],
//                ComponentName = row["ComponentName"]?.ToString(),
//                Unit = row["ComponentUnit"]?.ToString(),
//                ValueType = row["ValueType"]?.ToString(),
//                ControlType = row["ControlType"]?.ToString(),
//                Range = row["ComponentRange"]?.ToString(),
//                RangeDescription = row["ComponentRangeDescription"]?.ToString(),
//                Method = row["ComponentMethod"]?.ToString(),
//                ValueLookup = row["ValueLookup"],
//                MinValue = row["MinValue"],
//                MaxValue = row["MaxValue"],
//                DisplayName = row["DisplayName"]?.ToString(),
//                DisplaySequence = row["ComponentMapDisplaySequence"],
//                IndentationCount = row["IndentationCount"],
//                ShowInSheet = Convert.ToBoolean(row["ShowInSheet"]),
//                ComponentMapId = row["ComponentMapId"],
//                MaleRange = row["MaleRange"]?.ToString(),
//                FemaleRange = row["FemaleRange"]?.ToString(),
//                ChildRange = row["ChildRange"]?.ToString(),
//                GroupName = row["GroupName"]?.ToString(),
//                ValuePrecision = row["ValuePrecision"]
//            };
//        }

//        private static dynamic ExtractComponents(DataRow row)
//        {
//            return new
//            {
//                TestComponentResultId = row["TestComponentResultId"],
//                RequisitionId = 0,
//                LabTestId = 0,
//                Value = row["Value"]?.ToString(),
//                Unit = row["Unit"]?.ToString(),
//                Range = row["Range"]?.ToString(),
//                ComponentName = row["ComponentName"]?.ToString(),
//                ComponentId = (string)null,
//                Method = row["Method"]?.ToString(),
//                CreatedBy = (string)null,
//                CreatedOn = Convert.ToDateTime(row["CreatedOn"]).ToString("yyyy-MM-ddTHH:mm:ss.fff"),
//                ModifiedBy = (string)null,
//                ModifiedOn = (string)null,
//                Remarks = (string)null,
//                TemplateId = (string)null,
//                RangeDescription = row["RangeDescription"]?.ToString(),
//                LabRequisition = (string)null,
//                IsNegativeResult = (string)null,
//                NegativeResultText = (string)null,
//                IsAbnormal = row["IsAbnormal"],
//                LabReportId = (string)null,
//                IsActive = (string)null,
//                AbnormalType = row["AbnormalType"]?.ToString(),
//                ResultGroup = Convert.ToInt32(row["ResultGroup"])
//            };
//        }

//        private static dynamic ExtractVendorDetail(DataRow row)
//        {
//            return new
//            {
//                LabVendorId = 1, // Hardcoded Value
//                VendorCode = "INTERNAL", // Hardcoded Value
//                VendorName = "Lab Internal", // Hardcoded Value
//                IsExternal = false, // Hardcoded Value
//                ContactAddress = (string)null,
//                ContactNo = (string)null,
//                Email = (string)null,
//                Remarks = (string)null,
//                CreatedBy = 1, // Hardcoded Value
//                CreatedOn = "2019-05-19T22:00:48.87", // Hardcoded Value
//                IsActive = true, // Hardcoded Value
//                IsDefault = true // Hardcoded Value
//            };
//        }




//        //public DataTable GetData(long barCodeNumber)
//        //{
//        //    if (barCodeNumber <= 0)
//        //    {
//        //        throw new ArgumentException("Bar code number must be a positive value.");
//        //    }

//        //    var results = await _labDbContext.LabReports
//        //        .FromSqlInterpolated($"EXEC SP_LAB_GetDenormalizedReportDetails @BarCodeNumber = {barCodeNumber}")
//        //        .ToListAsync();

//        //    return results;
//        //}


//        //public object GetLabReportByRequisitionIds(long barCodeNumber)
//        //{
//        //    LabResultDenormalizedDTO report = new LabResultDenormalizedDTO();

//        //    using (SqlConnection connection = new SqlConnection(_labDbContext.Database.GetDbConnection().ConnectionString))
//        //    {
//        //        using (SqlCommand command = new SqlCommand("SP_LAB_GetDenormalizedReportDetails", connection))
//        //        {
//        //            command.CommandType = CommandType.StoredProcedure;
//        //            command.Parameters.AddWithValue("@RequisitionIdsCSV", barCodeNumber);

//        //            connection.Open();
//        //            using (SqlDataReader reader = command.ExecuteReader())
//        //            {
//        //                if (reader.HasRows)
//        //                {
//        //                    while (reader.Read())
//        //                    {
//        //                        // Populate Lookups
//        //                        if (report.Lookups == null)
//        //                        {
//        //                            report.Lookups = new LookupsDTO
//        //                            {
//        //                                PatientId = reader.GetInt32(reader.GetOrdinal("PatientId")),
//        //                                PatientName = reader.GetString(reader.GetOrdinal("PatientName")),
//        //                                PatientCode = reader.GetString(reader.GetOrdinal("PatientCode")),
//        //                                Gender = reader.GetString(reader.GetOrdinal("Gender")),
//        //                                DOB = reader.IsDBNull(reader.GetOrdinal("DOB")) ? (DateTime?)null : reader.GetDateTime(reader.GetOrdinal("DOB")),
//        //                                PhoneNumber = reader.GetString(reader.GetOrdinal("PhoneNumber")),
//        //                                Address = reader.GetString(reader.GetOrdinal("Address")),
//        //                                MunicipalityName = reader.GetString(reader.GetOrdinal("MunicipalityName")),
//        //                                CountrySubDivisionName = reader.GetString(reader.GetOrdinal("CountrySubDivisionName")),
//        //                                // Add other fields as necessary
//        //                            };
//        //                        }

//        //                        // Populate Templates
//        //                        if (report.Templates == null)
//        //                        {
//        //                            report.Templates = new List<TemplateDTO>();
//        //                        }

//        //                        TemplateDTO template = new TemplateDTO
//        //                        {
//        //                            TemplateId = reader.GetInt32(reader.GetOrdinal("TemplateId")),
//        //                            TemplateName = reader.GetString(reader.GetOrdinal("TemplateName")),
//        //                            TemplateType = reader.GetString(reader.GetOrdinal("TemplateType")),
//        //                            TemplateHtml = reader.GetString(reader.GetOrdinal("TemplateHTML")),
//        //                            HeaderText = reader.GetString(reader.GetOrdinal("HeaderText")),
//        //                            FooterText = reader.GetString(reader.GetOrdinal("FooterText")),
//        //                            TemplateColumns = reader.GetString(reader.GetOrdinal("ColSettingsJSON")),
//        //                            DisplaySequence = reader.GetInt32(reader.GetOrdinal("TemplateDisplaySequence")),
//        //                            Tests = new List<TestDTO>() // Initialize Tests list
//        //                        };

//        //                        // Populate Tests
//        //                        TestDTO test = new TestDTO
//        //                        {
//        //                            TestName = reader.GetString(reader.GetOrdinal("LabTestName")),
//        //                            ReportingName = reader.GetString(reader.GetOrdinal("ReportingName")),
//        //                            RequisitionId = reader.GetInt32(reader.GetOrdinal("RequisitionId")),
//        //                            LabTestId = reader.GetInt32(reader.GetOrdinal("LabTestId")),
//        //                            // Populate other fields as necessary
//        //                        };

//        //                        // Add the test to the template
//        //                        template.Tests.Add(test);

//        //                        // Add the template to the report
//        //                        report.Templates.Add(template);
//        //                    }
//        //                }
//        //            }
//        //        }
//        //    }

//        //    return report;
//        //}









//        //public async Task<object> GetLabReportByRequisitionIds(long barCodeNumber)
//        //{
//        //    if (barCodeNumber != null)
//        //    {
//        //        empList = await _labDbContext.Employee.ToListAsync();
//        //        LabReportVm labReport = GetLabReportVMForReqIds(barCodeNumber);

//        //        labReport.ValidToPrint = true;
//        //        return labReport;
//        //    }
//        //    else
//        //    {
//        //        throw new Exception("Bar code number cannot be null.");
//        //    }
//        //}
//        public LabReportVm GetLabReportVMForReqIds(long barCodeNumber)
//        {
//            List<LabResultDenormalizedDTO> resultsDenormalized = GetResultsDenormalized(barCodeNumber);
//            LabReportVm retReport = FormatResultsForLabReportVM(resultsDenormalized);
//            return retReport;
//        }
//        public List<LabResultDenormalizedDTO> GetResultsDenormalized(long barCodeNumber)
//        {
//            var resultDetails = (
//                //from req in _labDbContext.Requisitions.Where(b => b.BarCodeNumber == barCodeNumber)
//                //                     join pat in _labDbContext.Patients on req.PatientId equals pat.PatientId
//                //                     join test in _labDbContext.LabTests on req.LabTestId equals test.LabTestId
//                //                     join template in _labDbContext.LabReportTemplates on req.ReportTemplateId equals template.ReportTemplateID
//                //                     from doc in _labDbContext.Employee.Where(emp => emp.EmployeeId == req.PrescriberId).DefaultIfEmpty()
//                //                     from comp in _labDbContext.LabTestComponentResults.Where(cmp => cmp.RequisitionId == req.RequisitionId && cmp.IsActive == true).DefaultIfEmpty()
//                //                     from rept in _labDbContext.LabReports.Where(rpt => rpt.LabReportId == req.LabReportId).DefaultIfEmpty()
//                //                     from billitm in _labDbContext.BillingTransactionItems.Where(rpt => rpt.BillingTransactionItemId == req.BillingTransactionItemId).DefaultIfEmpty()
//                //                     from refDoc in _labDbContext.Employee.Where(emp => emp.EmployeeId == billitm.ReferredById).DefaultIfEmpty()

//                from req in _labDbContext.Requisitions.Where(b => b.BarCodeNumber == barCodeNumber).AsNoTracking()

//                join pat in _labDbContext.Patients.AsNoTracking() on req.PatientId equals pat.PatientId
//                join test in _labDbContext.LabTests on req.LabTestId equals test.LabTestId
//                join template in _labDbContext.LabReportTemplates on req.ReportTemplateId equals template.ReportTemplateID
//                //from doc in _labDbContext.Employee.Where(emp => emp.EmployeeId == req.PrescriberId).DefaultIfEmpty()
//                from comp in _labDbContext.LabTestComponentResults.Where(cmp => cmp.RequisitionId == req.RequisitionId).DefaultIfEmpty()
//                from rept in _labDbContext.LabReports.Where(rpt => rpt.LabReportId == req.LabReportId).DefaultIfEmpty()
//                    //Krishna, 24thJuly'23, Added below left joins to avoid firing linq within select
//                from subDivision in _labDbContext.CountrySubdivisions.Where(sd => sd.CountrySubDivisionId == pat.CountrySubDivisionId).DefaultIfEmpty()
//                from mun in _labDbContext.Municipalities.Where(m => m.MunicipalityId == pat.MunicipalityId).DefaultIfEmpty()

//                select new LabResultDenormalizedDTO()
//                {

//                    Email = pat.Email,
//                    LabTypeName = req.LabTypeName,
//                    PatientId = pat.PatientId,
//                    PatientName = pat.FirstName + " " + (string.IsNullOrEmpty(pat.MiddleName) ? "" : pat.MiddleName + " ") + pat.LastName,
//                    PatientCode = pat.PatientCode,
//                    Gender = pat.Gender,
//                    DOB = pat.DateOfBirth,
//                    PhoneNumber = pat.PhoneNumber,
//                    Address = pat.Address,
//                    CountrySubDivisionName = subDivision != null ? subDivision.CountrySubDivisionName : null,
//                    MunicipalityName = mun != null ? mun.MunicipalityName : null,
//                    ReferredById = (int?)req.ProviderId,
//                    //ReferredBy = rept == null ? (req.ProviderId != null ? (string.IsNullOrEmpty(doc.LongSignature) ? doc.FullName : doc.LongSignature) : "SELF") : rept.ReferredByDr,
//                    //ReceivingDate = rept == null ? ((req.RunNumberType.ToLower() == ENUM_LabRunNumType.histo || req.RunNumberType.ToLower() == ENUM_LabRunNumType.cyto) ? req.OrderDateTime : req.SampleCreatedOn) : rept.ReceivingDate,
//                    //ReportingDate = rept == null ? DateTime.Now : rept.ReportingDate,
//                    //SampleDate = req.SampleCreatedOn,
//                    //SampleCode = req.SampleCode,
//                    //SampleCodeFormatted = req.SampleCodeFormatted,
//                    //BillingStatus = req.BillingStatus,
//                    //Specimen = req.LabTestSpecimen,
//                    //ColSettingsJSON = template.ColSettingsJSON,
//                    //Comments = req.Comments,
//                    //LabReportComments = rept.Comments,
//                    //ComponentName = comp.ComponentName,
//                    //CreatedBy = req.CreatedBy,
//                    //CreatedOn = req.CreatedOn,
//                    //ReportCreatedBy = rept.CreatedBy,
//                    //ReportCreatedOn = rept.CreatedOn,
//                    //Description = template.Description,
//                    //DiagnosisId = req.DiagnosisId,
//                    //TestDisplaySequence = test.DisplaySequence,
//                    //FooterText = template.FooterText,
//                    //HasNegativeResults = test.HasNegativeResults.HasValue ? test.HasNegativeResults.Value : false,
//                    //HeaderText = template.HeaderText,
//                    //Interpretation = test.Interpretation,
//                    //IsAbnormal = comp.IsAbnormal,
//                    //AbnormalType = comp.AbnormalType,
//                    //IsActive_Test = test.IsActive,
//                    //IsDefault = template.IsDefault,
//                    //IsNegativeResult = comp.IsNegativeResult,
//                    //IsPrinted = rept.IsPrinted,
//                    //LabReportId = rept.LabReportId,
//                    //LabTestComponentsJSON = new object(),
//                    //LabTestId = test.LabTestId,
//                    //LabTestName = test.LabTestName,
//                    //LabTestSpecimen = test.LabTestSpecimen,
//                    //LabTestSpecimenSource = test.LabTestSpecimenSource,
//                    //Method = comp.Method,
//                    //ModifiedBy = req.ModifiedBy,
//                    //ModifiedOn = req.ModifiedOn,
//                    //NegativeResultText = test.NegativeResultText,
//                    //OrderDateTime = req.OrderDateTime,
//                    //OrderStatus = req.OrderStatus,
//                    //PatientVisitId = req.PatientVisitId,
//                    //ProviderId = req.ProviderId,
//                    //ProviderName = req.ProviderName,
//                    //Range = comp.Range,
//                    RangeDescription = comp.RangeDescription,
//                    //ReferredByDr = rept.ReferredByDr,
//                    //Remarks = comp.Remarks,
//                    //ReportingName = test.ReportingName,
//                    //ReportTemplateId = template.ReportTemplateID,
//                    //ReportTemplateName = template.ReportTemplateName,
//                    //ReportTemplateShortName = template.ReportTemplateShortName,
//                    //RequisitionId = req.RequisitionId,
//                    //RequisitionRemarks = req.RequisitionRemarks,
//                    //ResultGroup = comp.ResultGroup,
//                    //ResultingVendorId = req.ResultingVendorId,
//                    //SampleCreatedBy = req.SampleCreatedBy,
//                    //SampleCreatedOn = req.SampleCreatedOn,
//                    //Signatories = rept.Signatories,
//                    //VerifiedBy = req.VerifiedBy,
//                    //VerifiedOn = req.VerifiedOn,
//                    //TemplateHTML = template.TemplateHTML,
//                    //TemplateId = template.ReportTemplateID,
//                    //TemplateType = template.TemplateType,
//                    //Unit = comp.Unit,
//                    //Urgency = req.Urgency,
//                    Value = comp.Value,
//                    TestComponentResultId = comp.TestComponentResultId,
//                    IsActive_Component = comp.IsActive.HasValue ? comp.IsActive : true,
//                    VisitType = req.VisitType,
//                    RunNumberType = req.RunNumberType,
//                    TemplateDisplaySequence = template.DisplaySequence,
//                    //HasInsurance = req.HasInsurance,
//                    PrintCount = rept.PrintCount,
//                    PrintedBy = rept.PrintedBy,
//                    PrintedOn = rept.PrintedOn,
//                    PrintedByName = "",
//                    CovidFileUrl = string.IsNullOrEmpty(CovidFileUrlCommon) ? "" : CovidFileUrlCommon.Replace("GGLFILEUPLOADID", req.GoogleFileIdForCovid),
//                    IsFileUploadedToTeleMedicine = req.IsFileUploadedToTeleMedicine,
//                    ResultAddedBy = req.ResultAddedBy,
//                    IsLISApplicable = test.IsLISApplicable,
//                }).ToList();






//            //PrescriberId = (int?)req.PrescriberId,
//            //                 ReferredById = (int?)billitm.ReferredById,
//            //                 ReferredByName = rept == null ? (billitm.ReferredById != null ? (string.IsNullOrEmpty(refDoc == null ? "" : refDoc.FullName) ? refDoc == null ? "" : refDoc.FullName : refDoc == null ? "" : refDoc.FullName) : "SELF1") : refDoc.FullName,
//            //ReferredBy = rept == null ? (req.ProviderId != null ? (string.IsNullOrEmpty(doc.LongSignature) ? doc.FullName : doc.LongSignature) : "SELF") : rept.ReferredByDr,
//            //ReceivingDate = rept == null ? ((req.RunNumberType.ToLower() == ENUM_LabRunNumType.histo || req.RunNumberType.ToLower() == ENUM_LabRunNumType.cyto) ? req.OrderDateTime : req.SampleCreatedOn) : rept.ReceivingDate,



//            //PrescriberName = rept == null ? (req.PrescriberId != null ? (string.IsNullOrEmpty(doc == null ? "" : doc.FullName) ? doc == null ? "" : doc.FullName : doc == null ? "" : doc.FullName) : "SELF") : rept.PrescriberName,
//            //                 ReceivingDate = rept == null ? ((req.RunNumberType.ToLower() == ENUM_LabRunNumType.histo || req.RunNumberType.ToLower() == ENUM_LabRunNumType.cyto) ? req.OrderDateTime : req.SampleCreatedOn) : rept.ReceivingDate,
//            //                 ReportingDate = rept == null ? DateTime.Now : rept.ReportingDate,
//            //                 SampleDate = req.SampleCreatedOn,
//            //                 SampleCode = req.SampleCode,
//            //                 SampleCodeFormatted = req.SampleCodeFormatted,
//            //                 BillingStatus = req.BillingStatus,
//            //                 Specimen = req.LabTestSpecimen,
//            //                 ColSettingsJSON = template.ColSettingsJSON,
//            //                 Comments = req.Comments,
//            //                 LabReportComments = rept == null ? "" : rept.Comments,
//            //                 ComponentName = comp == null ? "" : comp.ComponentName,
//            //                 CreatedBy = req.CreatedBy,
//            //                 CreatedOn = req.CreatedOn,
//            //                 ReportCreatedBy = rept == null ? 0 : rept.CreatedBy,
//            //                 ReportCreatedOn = rept == null ? DateTime.Now : rept.CreatedOn,
//            //                 Description = template.Description,
//            //                 DiagnosisId = req.DiagnosisId,
//            //                 TestDisplaySequence = test.DisplaySequence,
//            //                 FooterText = template.FooterText,
//            //                 HasNegativeResults = test.HasNegativeResults,
//            //                 HeaderText = template.HeaderText,
//            //                 Interpretation = test.Interpretation,
//            //                 IsAbnormal = comp == null ? false : comp.IsAbnormal,
//            //                 AbnormalType = comp == null ? "" : comp.AbnormalType,
//            //                 IsActive_Test = test.IsActive,
//            //                 IsDefault = template.IsDefault,
//            //                 IsNegativeResult = comp == null ? false : comp.IsNegativeResult,
//            //                 IsPrinted = rept == null ? false : rept.IsPrinted,
//            //                 LabReportId = rept == null ? 0 : rept.LabReportId,
//            //                 LabTestComponentsJSON = new object(),
//            //                 LabTestId = test.LabTestId,
//            //                 LabTestName = test.LabTestName,
//            //                 LabTestSpecimen = test.LabTestSpecimen,
//            //                 LabTestSpecimenSource = test.LabTestSpecimenSource,
//            //                 Method = comp == null ? "" : comp.Method,
//            //                 ModifiedBy = req.ModifiedBy,
//            //                 ModifiedOn = req.ModifiedOn,
//            //                 NegativeResultText = test.NegativeResultText,
//            //                 OrderDateTime = req.OrderDateTime,
//            //                 OrderStatus = req.OrderStatus,
//            //                 PatientVisitId = req.PatientVisitId,
//            //                 ProviderId = req.PrescriberId,
//            //                 ProviderName = req.PrescriberName,
//            //                 Range = comp == null ? "" : comp.Range,
//            //                 RangeDescription = comp == null ? "" : comp.RangeDescription,
//            //                 ReferredByDr = rept == null ? "" : rept.PrescriberName,
//            //                 Remarks = comp == null ? "" : comp.Remarks,
//            //                 ReportingName = test.ReportingName,
//            //                 ReportTemplateId = template.ReportTemplateID,
//            //                 ReportTemplateName = template.ReportTemplateName,
//            //                 ReportTemplateShortName = template.ReportTemplateShortName,
//            //                 RequisitionId = req.RequisitionId,
//            //                 RequisitionRemarks = req.RequisitionRemarks,
//            //                 ResultGroup = comp == null ? 0 : comp.ResultGroup,
//            //                 ResultingVendorId = req.ResultingVendorId,
//            //                 SampleCreatedBy = req.SampleCreatedBy,
//            //                 SampleCreatedOn = req.SampleCreatedOn,
//            //                 Signatories = rept == null ? "" : rept.Signatories,
//            //                 VerifiedBy = req.VerifiedBy,
//            //                 VerifiedOn = req.VerifiedOn,
//            //                 TemplateHTML = template.TemplateHTML,
//            //                 TemplateId = template.ReportTemplateID,
//            //                 TemplateType = template.TemplateType,
//            //                 Unit = comp == null ? "" : comp.Unit,
//            //                 Urgency = req.Urgency,
//            //                 Value = comp == null ? "" : comp.Value,
//            //                 TestComponentResultId = comp.TestComponentResultId,
//            //                 IsActive_Component = comp == null ? false : comp.IsActive,
//            //                 VisitType = req.VisitType,
//            //                 RunNumberType = req.RunNumberType,
//            //                 TemplateDisplaySequence = template.DisplaySequence,
//            //                 HasInsurance = req.HasInsurance,
//            //                 PrintCount = rept == null ? 0 : rept.PrintCount,
//            //                 PrintedBy = rept == null ? 0 : rept.PrintedBy,
//            //                 PrintedOn = rept == null ? DateTime.Now : rept.PrintedOn,
//            //                 PrintedByName = "",
//            //                 //CovidFileUrl = string.IsNullOrEmpty(CovidFileUrlCommon) ? "" : CovidFileUrlCommon.Replace("GGLFILEUPLOADID", req.GoogleFileId),
//            //                 IsFileUploadedToTeleMedicine = req.IsFileUploadedToTeleMedicine,
//            //                 PassPortNumber = pat.PassportNumber,
//            //                 WardName = req.WardName,
//            //                 IsLISApplicable = test.IsLISApplicable,
//            //             }).ToList();


//            return resultDetails;
//        }
//        public LabReportVm FormatResultsForLabReportVM(List<LabResultDenormalizedDTO> resultSets)
//        {
//            LabReportVm retData = (from r in resultSets
//                                   select new LabReportVm()
//                                   {
//                                       Columns = r.ColSettingsJSON,
//                                       FooterText = r.FooterText,
//                                       Header = r.HeaderText,
//                                       ReportId = r.LabReportId,
//                                       Signatories = r.Signatories,
//                                       TemplateType = r.TemplateType,
//                                       TemplateHTML = r.TemplateHTML,
//                                       Comments = r.LabReportComments,
//                                       IsPrinted = r.IsPrinted,
//                                       CreatedBy = r.CreatedBy,
//                                       CreatedOn = r.CreatedOn,
//                                       ReportCreatedBy = r.ReportCreatedBy,
//                                       ReportCreatedOn = r.ReportCreatedOn,
//                                       PrintCount = r.PrintCount,
//                                       PrintedBy = r.PrintedBy,
//                                       HasInsurance = r.HasInsurance,
//                                       PrintedByName = (from emp in empList
//                                                        where emp.EmployeeId == r.PrintedBy
//                                                        select emp.FirstName + " " + emp.LastName).FirstOrDefault(),
//                                       PrintedOn = r.PrintedOn,
//                                       CovidFileUrl = r.CovidFileUrl,
//                                       Email = r.Email,
//                                       IsFileUploadedToTeleMedicine = r.IsFileUploadedToTeleMedicine
//                                   }).GroupBy(tmp => tmp.TemplateType).Select(group => group.First()).FirstOrDefault();



//            retData.Lookups = GetLookup(resultSets);
//            retData.Templates = GetTemplateVM(resultSets);
//            return retData;
//        }
//        public ReportLookup GetLookup(List<LabResultDenormalizedDTO> resultSets)
//        {
//            var PatientId = resultSets.FirstOrDefault().PatientId;
//            PatientSchemeMapModel SchemeMap = _labDbContext.PatientSchemeMap.Where(a => a.PatientId == PatientId).FirstOrDefault();
//            ReportLookup lookups = (from r in resultSets
//                                    select new ReportLookup ////////////////////caught error
//                                    {
//                                        LabTypeName = r.LabTypeName,
//                                        Address = r.Address,
//                                        DOB = r.DOB,
//                                        Gender = r.Gender,
//                                        PatientCode = r.PatientCode,
//                                        PatientName = r.PatientName,
//                                        //PatientId = r.PatientId,
//                                        PhoneNumber = r.PhoneNumber,
//                                        ReceivingDate = r.ReceivingDate,
//                                        //ReportingDate = r.ReportingDate,
//                                        //PrescriberName = r.PrescriberName,
//                                        //PrescriberId = r.PrescriberId,
//                                        //ReferredById = r.ReferredById,
//                                        //ReferredByName = r.ReferredByName,
//                                        //SampleCode = r.SampleCode,
//                                        //SampleCodeFormatted = r.SampleCodeFormatted,
//                                        //SampleDate = r.SampleDate,
//                                        //VerifiedOn = r.VerifiedOn,
//                                        //VisitType = r.VisitType,
//                                        //RunNumberType = r.RunNumberType,
//                                        //Specimen = r.Specimen,
//                                        //MunicipalityName = r.MunicipalityName,
//                                        //CountrySubDivisionName = r.CountrySubDivisionName,
//                                        //CountryName = r.CountryName,
//                                        //WardNumber = r.WardNumber,
//                                        //ProfilePictureName = getProfilePicture(r.PatientId),
//                                        //PassPortNumber = r.PassPortNumber,
//                                        //WardName = r.WardName,
//                                        PolicyNumber = SchemeMap != null ? SchemeMap.PolicyNo : "",
//                                    }
//                            ).FirstOrDefault();
//            return lookups;
//        }
//        public List<LabReportTemplateVM> GetTemplateVM(List<LabResultDenormalizedDTO> resultSets)
//        {
//            List<LabReportTemplateVM> templates = (from r in resultSets
//                                                   select new LabReportTemplateVM()
//                                                   {
//                                                       FooterText = r.FooterText,
//                                                       HeaderText = r.HeaderText,
//                                                       TemplateHtml = r.TemplateHTML,
//                                                       TemplateId = r.TemplateId,
//                                                       TemplateName = r.ReportTemplateName,
//                                                       TemplateType = r.TemplateType,
//                                                       DisplaySequence = r.TemplateDisplaySequence,
//                                                       Tests = new object(),
//                                                       TemplateColumns = r.ColSettingsJSON//sud: 19Sept'18-- to show hide columns in template's scope.
//                                                   }).GroupBy(tmp => tmp.TemplateId).Select(group => group.First()).OrderBy(a => a.DisplaySequence).ToList();

//            if (templates != null && templates.Count > 0)
//            {
//                foreach (var tmp in templates)
//                {
//                    tmp.Tests = GetTestsOfTemplate(resultSets, tmp.TemplateId);
//                }
//            }

//            return templates;
//        }
//        public string getProfilePicture(int patientId)
//        {
//            var location = (from dbc in _labDbContext.AdminParameters
//                            where dbc.ParameterGroupName.ToLower() == "patient" && dbc.ParameterName == "PatientProfilePicImageUploadLocation"
//                            select dbc.ParameterValue
//            ).FirstOrDefault();

//            PatientFilesModel retFile = _labDbContext.PatientFiles
//                                       .Where(f => f.PatientId == patientId && f.IsActive == true
//                                       && f.FileType == "profile-pic")
//                                       .FirstOrDefault();

//            if (retFile != null)
//            {
//                var fileFullPath = location + retFile.FileName;
//                byte[] imageArray = System.IO.File.ReadAllBytes(@fileFullPath);
//                retFile.FileBase64String = Convert.ToBase64String(imageArray);
//                return retFile.FileBase64String;
//            }
//            else
//            {
//                return null;
//            }

//        }
//        public List<LabTestTempDTO> GetTestsOfTemplate(List<LabResultDenormalizedDTO> resultSets, int? templateId)
//        {

//            List<LabTestTempDTO> retData = (from r in resultSets
//                                            where templateId == r.TemplateId
//                                            select new LabTestTempDTO()
//                                            {
//                                                TestName = r.LabTestName,
//                                                ReportingName = r.ReportingName,
//                                                LabTestId = r.LabTestId,
//                                                Comments = r.Comments,
//                                                ComponentJSON = new object(),
//                                                DisplaySequence = r.TestDisplaySequence,
//                                                HasNegativeResults = r.HasNegativeResults,
//                                                Interpretation = r.Interpretation,
//                                                NegativeResultText = r.NegativeResultText,
//                                                RequestDate = r.OrderDateTime,
//                                                RequisitionId = r.RequisitionId,
//                                                Components = null,
//                                                Specimen = r.Specimen,
//                                                BillingStatus = r.BillingStatus,
//                                                ResultingVendorId = r.ResultingVendorId,
//                                                VendorDetail = new LabVendorsModel(),
//                                                SampleCollectedBy = (from employee in empList
//                                                                     where employee.EmployeeId == r.SampleCreatedBy
//                                                                     select employee.FirstName + " " + (string.IsNullOrEmpty(employee.MiddleName) ? "" : employee.MiddleName + " ") + employee.LastName).FirstOrDefault(),
//                                                SampleCollectedOn = r.SampleCreatedOn,
//                                                HasInsurance = r.HasInsurance,
//                                                VerifiedBy = r.VerifiedBy,
//                                                VerifiedOn = r.VerifiedOn,
//                                                IsLISApplicable = r.IsLISApplicable,
//                                            }).GroupBy(tmp => tmp.RequisitionId).Select(group => group.First()).OrderBy(test => test.DisplaySequence).ToList();

//            if (retData != null && retData.Count > 0)
//            {
//                foreach (var tst in retData)
//                {
//                    tst.VendorDetail = (from vendor in _labDbContext.LabVendors
//                                        where vendor.LabVendorId == tst.ResultingVendorId
//                                        select vendor).FirstOrDefault();
//                    tst.ComponentJSON = (from labtest in _labDbContext.LabTests
//                                         join componentMap in _labDbContext.LabTestComponentMap on labtest.LabTestId equals componentMap.LabTestId
//                                         join component in _labDbContext.LabTestComponents on componentMap.ComponentId equals component.ComponentId
//                                         where labtest.LabTestId == tst.LabTestId && componentMap.IsActive == true
//                                         select new
//                                         {
//                                             ComponentId = component.ComponentId,
//                                             ComponentName = component.ComponentName,
//                                             Unit = component.Unit,
//                                             ValueType = component.ValueType,
//                                             ControlType = component.ControlType,
//                                             Range = component.Range,
//                                             RangeDescription = component.RangeDescription,
//                                             Method = component.Method,
//                                             ValueLookup = component.ValueLookup,
//                                             MinValue = component.MinValue,
//                                             MaxValue = component.MaxValue,
//                                             DisplayName = component.DisplayName,
//                                             DisplaySequence = componentMap.DisplaySequence,
//                                             IndentationCount = componentMap.IndentationCount,
//                                             ShowInSheet = componentMap.ShowInSheet,
//                                             ComponentMapId = componentMap.ComponentMapId,
//                                             MaleRange = component.MaleRange,
//                                             FemaleRange = component.FemaleRange,
//                                             ChildRange = component.ChildRange,
//                                             GroupName = componentMap.GroupName,
//                                             IsAutoCalculate = componentMap.IsAutoCalculate,
//                                             CalculationFormula = componentMap.CalculationFormula,
//                                             FormulaDescription = componentMap.FormulaDescription,
//                                             ValuePrecision = component.ValuePrecision,
//                                             ShowRangeDescriptionInLabReport = component.ShowRangeDescriptionInLabReport,
//                                         }).ToList();
//                    tst.Components = GetResulsOfTestRequisition(resultSets, tst.RequisitionId);
//                    tst.MaxResultGroup = tst.Components.Max(v => v.ResultGroup);
//                    tst.MaxResultGroup = tst.MaxResultGroup.HasValue ? tst.MaxResultGroup.Value : 1;
//                }
//            }

//            return retData;
//        }
//        public List<LabTestComponentResult> GetResulsOfTestRequisition(List<LabResultDenormalizedDTO> resultSets, Int64 requisitionId)
//        {
//            List<LabTestComponentResult> retData = (from r in resultSets
//                                                    where r.RequisitionId == requisitionId
//                                                    && r.IsActive_Component == true
//                                                    select new LabTestComponentResult()
//                                                    {
//                                                        TestComponentResultId = r.TestComponentResultId.HasValue ? r.TestComponentResultId.Value : 0,
//                                                        ComponentName = r.ComponentName,
//                                                        Value = r.Value,
//                                                        Unit = r.Unit,
//                                                        Range = r.Range,
//                                                        RangeDescription = r.RangeDescription,
//                                                        Remarks = r.Remarks,
//                                                        //CreatedOn = r.CreatedOn,
//                                                        //IsAbnormal = r.IsAbnormal,
//                                                        //AbnormalType = r.AbnormalType,
//                                                        //IsNegativeResult = r.IsNegativeResult,
//                                                        //Method = r.Method,
//                                                        //ResultGroup = r.ResultGroup
//                                                    }).ToList();
//            if (retData != null && retData.Count > 0 && retData[0].TestComponentResultId == 0)
//            {
//                retData = new List<LabTestComponentResult>();
//            }

//            return retData;
//        }

        
//    }
//}
