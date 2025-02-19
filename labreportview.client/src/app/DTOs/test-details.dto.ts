import { VendorDetail } from "./vendor-details.dto";

export class TestDetails {
    TestName: string;
    ReportingName: string;
    RequisitionId: number;
    LabTestId: number;
    Specimen: string;
    SampleCollectedBy: string;
    SampleCollectedOn: string;
    VendorDetail: Array<VendorDetail> = new Array<VendorDetail>;
    HasInsurance: boolean;
    BillingStatus: string;
    VerifiedBy: number;
    VerifiedOn: string;
    ResultingVendorId: number;
    MaxResultGroup: number;
    IsLISApplicable: boolean;
}
