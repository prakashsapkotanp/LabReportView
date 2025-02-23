import { ColumnDTO } from "./column.dto";
import { Test } from "./test.dto";

export class TemplateDTO {
    TemplateId: number;
    TemplateName: string;
    TemplateType: string;
    TemplateHtml: string | null;
    HeaderText: string;
    FooterText: string;
    TemplateColumns: string;
    Tests: Array<Test> = new Array<Test>();
    TemplateColumn: ColumnDTO;
    ColumnCounts: number;
}
           