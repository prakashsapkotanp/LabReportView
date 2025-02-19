import { ComponentDTO } from "./component.dto";
import { TestComponent } from "./test-component.dto";

export class Test {
    TestName: string;
    ReportingName: string;
    RequisitionId: number;
    LabTestId: number;
    ComponentJSON: Array<ComponentDTO> = new Array <ComponentDTO>();
    HasNegativeResults: boolean;
    NegativeResultText: string | null;
    RequestDate: string;
    Comments: string | null;
    DisplaySequence: number;
    Interpretation: string | null;
    Components: Array<TestComponent> = new Array<TestComponent>;
}

