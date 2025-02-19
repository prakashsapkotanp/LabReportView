import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component } from '@angular/core';
import { ResultDTO } from './DTOs/results.dto';
@Component({
    selector: 'report-search-page',
    templateUrl: './report-search-page.html',
  })
  export class ReportSearchComponent {
    public barcodeNumber: number;
    public report: ResultDTO;
    public options = {
      headers: new HttpHeaders({ 'Content-Type': 'application/x-www-form-urlencoded' })
    };
  
  constructor(public http: HttpClient) {
}

  onButtonClick(): void {
    if (!this.barcodeNumber) {
        alert("please enter a valid var code number");
        return;   
    }
    if (this.barcodeNumber) {
      this.http.get<any>(`https://localhost:7053/api/labReport/LabReportByRequisitionIds?barCodeNumber=${this.barcodeNumber}`, this.options)
        .subscribe(
          (res) => {
            this.report = res.Result; 
          },
          (error) => {
            alert('Test with this barcode number is not completed');
          }
        );
    } 
  }
  
}