export class ColumnDTO {
    Name: boolean = false;
    Result: boolean = false;
    Range: boolean = false;
    Method: boolean = false;
    Unit: boolean = false;
    Remarks: boolean = false;
    public SelectAll: boolean = true;

  public constructor(name: boolean, result: boolean, range: boolean, method: boolean, unit: boolean, remarks: boolean, selectall: boolean) {
    this.Name = name;
    this.Remarks = remarks;
    this.Range = range;
    this.Result = result;
    this.Method = method;
    this.Unit = unit;
    this.SelectAll = selectall;
}
}