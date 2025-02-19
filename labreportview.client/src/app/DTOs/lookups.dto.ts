export class LookupDTO {
    PatientId: number;
    PatientName: string;
    PatientCode: string;
    Gender: string;
    DOB: string;
    PhoneNumber: string;
    Address: string | null;
    MunicipalityName: string | null;
    CountrySubDivisionName: string;
    ReferredById: number | null;
    ReferredBy: string;
    ReceivingDate: string;
    ReportingDate: string;
    SampleDate: string;
    SampleCode: number;
    VerifiedOn: string;
    SampleCodeFormatted: string;
    VisitType: string;
    RunNumberType: string;
    Specimen: string;
    LabTypeName: string;
}
