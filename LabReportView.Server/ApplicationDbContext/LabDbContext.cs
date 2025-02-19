using LabReportView.Server.Models;
using Microsoft.EntityFrameworkCore;


namespace LabReportView.Server.ApplicationDbContext
{
    public class LabDbContext :DbContext
    {
        public LabDbContext(DbContextOptions<LabDbContext> options): base(options)
        { 
        }
        public DbSet<LabRequisitionModel> Requisitions { get; set; }
        public DbSet<EmployeeModel> Employee { get; set; }
        public DbSet<PatientModel> Patients { get; set; }
        public DbSet<LabTestModel> LabTests { get; set; }
        public DbSet<LabTestComponentResult> LabTestComponentResults { get; set; }
        public DbSet<LabReportTemplateModel> LabReportTemplates { get; set; }
        public DbSet<LabReportModel> LabReports { get; set; }
        public DbSet<BillingTransactionItemModel> BillingTransactionItems { get; set; }
        public DbSet<CountrySubDivisionModel> CountrySubdivisions { get; set; }
        public DbSet<CountryModel> Countries { get; set; }
        public DbSet<MunicipalityModel> Municipalities { get; set; }
        public DbSet<PatientSchemeMapModel> PatientSchemeMap { get; set; }
        public DbSet<LabVendorsModel> LabVendors { get; set; }
        public DbSet<LabTestComponentMapModel> LabTestComponentMap { get; set; }
        public DbSet<LabTestJSONComponentModel> LabTestComponents { get; set; }
        public DbSet<AdminParametersModel> AdminParameters { get; set; }
        public DbSet<PatientFilesModel> PatientFiles { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AdminParametersModel>().ToTable("CORE_CFG_Parameters");
            modelBuilder.Entity<LabRequisitionModel>().ToTable("LAB_TestRequisition");
            modelBuilder.Entity<EmployeeModel>().ToTable("EMP_Employee");
            modelBuilder.Entity<LabTestModel>().ToTable("LAB_LabTests");
            modelBuilder.Entity<LabReportTemplateModel>().ToTable("Lab_ReportTemplate");
            modelBuilder.Entity<LabVendorsModel>().ToTable("Lab_MST_LabVendors");
            modelBuilder.Entity<BillServiceItemModel>().ToTable("BIL_MST_ServiceItem");
            modelBuilder.Entity<BillingTransactionItemModel>().ToTable("BIL_TXN_BillingTransactionItems");
            modelBuilder.Entity<LabTestComponentResult>().ToTable("LAB_TXN_TestComponentResult");
            modelBuilder.Entity<PatientModel>().ToTable("PAT_Patient");
            modelBuilder.Entity<VisitModel>().ToTable("PAT_PatientVisits");
            modelBuilder.Entity<LabReportModel>().ToTable("LAB_TXN_LabReports");
            modelBuilder.Entity<ServiceDepartmentModel>().ToTable("BIL_MST_ServiceDepartment");
            modelBuilder.Entity<AdmissionModel>().ToTable("ADT_PatientAdmission");
            modelBuilder.Entity<DepartmentModel>().ToTable("MST_Department");
            modelBuilder.Entity<LabTestComponentMapModel>().ToTable("Lab_MAP_TestComponents");
            modelBuilder.Entity<LabTestJSONComponentModel>().ToTable("Lab_MST_Components");
            modelBuilder.Entity<CountrySubDivisionModel>().ToTable("MST_CountrySubDivision");
            modelBuilder.Entity<MunicipalityModel>().ToTable("MST_Municipality");
            modelBuilder.Entity<PatientFilesModel>().ToTable("PAT_PatientFiles");
            modelBuilder.Entity<PatientSchemeMapModel>().ToTable("PAT_MAP_PatientSchemes");
            modelBuilder.Entity<CountryModel>().ToTable("MST_Country");
        }

    }
}
