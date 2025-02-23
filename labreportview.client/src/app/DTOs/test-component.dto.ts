export class TestComponent {
    TestComponentResultId: number;
    RequisitionId: number;
    LabTestId: number;
    Value: string;
    Unit: string;
    Range: string;
    ComponentName: string;
    ComponentId: number | null;
    Method: string;
    CreatedBy: number | null;
    CreatedOn: string;
    ModifiedBy: number | null;
    ModifiedOn: string | null;
    Remarks: string | null;
    TemplateId: number | null;
    RangeDescription: string;
    LabRequisition: string | null;
    IsNegativeResult: boolean | null;
    NegativeResultText: string | null;
    IsAbnormal: boolean;
    LabReportId: number | null;
    IsActive: boolean | null;
    AbnormalType: string | null;
    ResultGroup: number;
    ControlType: string;
}
