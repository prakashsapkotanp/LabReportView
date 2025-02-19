import { LookupDTO } from "./lookups.dto";
import { SignatoryDTO } from "./signatory.dto";
import { TemplateDTO } from "./template.dto";

export class ResultDTO {
    Header: string; 
    Lookups: LookupDTO;
    Columns: string;
    ReportId: number;
    Signatories: Array<SignatoryDTO> = new Array<SignatoryDTO>();
    TemplateId: number;
    TemplateType: string;
    TemplateHTML: string | null;
    TemplateName: string | null;
    FooterText: string;
    Comments: string | null;
    IsPrinted: boolean;
    ValidToPrint: boolean;
    CreatedOn: string; 
    CreatedBy: number;
    ReportCreatedOn: string;
    ReportCreatedBy: number;
    BarCodeNumber: number;
    PrintedOn: string;
    PrintedBy: number;
    PrintCount: number;
    PrintedByName: string;
    HasInsurance: boolean;
    Templates: Array<TemplateDTO> = new Array <TemplateDTO>();
}

