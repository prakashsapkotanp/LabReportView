import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Component, ElementRef, NgModule, ViewChild } from '@angular/core';
import { ResultDTO } from './DTOs/results.dto';
import { ColumnDTO } from './DTOs/column.dto';
import * as JsBarcode from 'jsbarcode';
import * as moment from 'moment';
@Component({
    selector: 'report-search-page',
    templateUrl: './report-search-page.html',
    // templateUrl:'./view.html'
    styleUrls: ['./report-search-page.css'],
})

export class ReportSearchComponent {
    public barcodeNumber: number;
    public stringBarCodeNumber: string = "";
    public selectedFormat: string = 'CODE128';
    public report: ResultDTO;
    public hospitalCode: string = "";
    public showHeader: boolean = false;
    public ResultFormattedForCulture: Array<any> = new Array<any>(); //sud:18Sept (needed to format culture report while mixing culture and normal)
    public showIntermediateInCultureRpt: boolean = false; //bring it from parameters later on.

    public hasInsurance: boolean = false;
    public showBarCode: boolean = false;
    public showHideHighLowNormalFlag: boolean = false;
    public showFooterText: boolean = true;
    public showInterpretation: boolean = false;
    public showGap: boolean = true;
    public showChangeSample: boolean = false;
    public showConfirmationBox: boolean = false;
    public barCodeFormat = "CODE128";
    public sampleCode = { RunNumber: 0, SampleCreatedOn: null, SampleCode: 0 };
    public sampleCodeExistingDetail = {
        Exisit: false,
        PatientName: null,
        PatientId: null,
        SampleCreatedON: null,
    };
    public visitType = null;
    public RunNumberType = null;
    public CurrentDateTime: string;
    public showLoggedInUserSignatory: boolean = false;
    public showReportDispatcherSignatory: boolean = false;
    public referredByLabelInLabReport: string = 'Referred By';
    public routeAfterVerification: string;
    public qrCode: string;
    public collectionSite: string = "LPH Hospital";
    public allValues: any;
    public showSignatories: boolean = true;
    public showDigitalSignature: boolean = true;
    public allColumnsCount: number = 0;
    public showPopUp: boolean = false;
    public loading: boolean = false;
    public showPrintInfo: boolean = true;
    public DOB: string;
    public receivingDate: string;
    public testingDate: string;
    public reportingDate: string;

    //   public allColumnsCombined: string;
    public allColumns: ColumnDTO = new ColumnDTO(
        false,
        false,
        false,
        false,
        false,
        false,
        false
    );
    public verificationEnabled: boolean = false;
    public options = {
        headers: new HttpHeaders({ 'Content-Type': 'application/x-www-form-urlencoded' })
    };
    CreatedByUser: any;
    ShowHideDigitalImage: any;

    constructor(public http: HttpClient) { }

    onButtonClick(): void {
        this.loading = true;
        // Fetch the report based on the barcode number
        this.http.get<any>(`https://localhost:7053/api/labReport/LabReportByRequisitionIds?barCodeNumber=${this.barcodeNumber}`, this.options)
            .subscribe(
                (res) => {
                    this.report = res;
                    this.report.Signatures = JSON.parse(this.report.Signatories);
                    this.allColumns = JSON.parse(this.report.Columns);
                    this.report.Templates.forEach((temp) => {
                        temp.TemplateColumn = JSON.parse(temp.TemplateColumns);
                        temp.ColumnCounts = Object.entries(temp.TemplateColumn).length
                    });
                    this.stringBarCodeNumber = String(this.barcodeNumber);
                    console.log(this.allColumns);
                    console.log(this.report);
                    this.loading = false;
                    this.showPopUp = true;
                    this.showHeader = true;
                    this.showBarCode = true;
                    // this.DOB = this.report.Lookups.DOB;
                    let age = this.AgeCalculator(this.report.Lookups.DOB);
                    this.DOB = this.FormateAgeSex(age, this.report.Lookups.Gender);
                    this.reportingDate= moment(this.report.Lookups.VerifiedOn).format("YYYY-MM-DD HH:MM A ");
                    this.testingDate= moment(this.report.Lookups.ReportingDate).format("YYYY-MM-DD HH:MM A ");
                    this.receivingDate= moment(this.report.Lookups.ReceivingDate).format("YYYY-MM-DD HH:MM A ");
                    this.showSignatories = true;
                    this.showDigitalSignature = true;
                    this.generateBarcode(this.stringBarCodeNumber);
                },
                (error) => {
                    alert('Test with this barcode number is not completed');
                    this.loading = false;
                }
            );
    }
    printLabReport() {
        this.loading = true;


        const contentToPrint = document.getElementById("id_report_search_print-page");

        if (contentToPrint) {
            const printContent = contentToPrint.innerHTML;

            // Rest of your print logic
            const documentContent = `
              <html>
                <head>              
                  <link rel="stylesheet" type="text/css" href="../assets/themes/PrintReportPage.css">
                  <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.2/dist/css/bootstrap.min.css" rel="stylesheet">
                </head>
                <body onload="window.print()">${printContent}</body>
              </html>
            `;

            const iframe = document.createElement('iframe');
            document.body.appendChild(iframe);
            iframe.contentWindow?.document.open();
            iframe.contentWindow?.document.write(documentContent);
            iframe.contentWindow?.document.close();

            setTimeout(() => {
                document.body.removeChild(iframe);
                this.loading = false;
            }, 500);
        } else {
            this.loading = false;
            alert("No content to print.");
        }

    }
    @ViewChild('barcode', { static: false }) barcodeElement!: ElementRef;

    //   ngAfterViewInit() {
    //    ;
    //   }
    updateBarcode(newBarcode: string) {
        this.stringBarCodeNumber = newBarcode;
        this.generateBarcode(this.stringBarCodeNumber);
    }
    generateBarcode(barcodeValue: string) {
        setTimeout(() => {
            if (this.barcodeElement && this.barcodeElement.nativeElement) {
                JsBarcode(this.barcodeElement.nativeElement, barcodeValue, {
                    format: "CODE128",
                    displayValue: true,
                    // lineColor: "#000",
                    // width: 2,
                    // height: 15  // Adjust height here
                    // margin: 1  // Optional: set margin if you need spacing around the barcode
                    width: 1.5,
                    height: 30,
                    fontSize: 14,
                    textMargin: 1,
                    margin: 10
                });
            } else {
                console.error("Barcode element not found");
            }
        }, 200);
    }
   

    AgeCalculator(dateOfBirth: string): string {
        const today = new Date();
    
        // Convert the dateOfBirth string to a Date object
        const dob = new Date(dateOfBirth);
    
        // Calculate the differences
        const years = today.getFullYear() - dob.getFullYear();
        const months = today.getMonth() - dob.getMonth();
        const days = today.getDate() - dob.getDate();
    
        let yearsDiff = years;
        let monthsDiff = months;
        let daysDiff = days;
    
        // Adjust for cases where the current month/day is earlier than the birth month/day
        if (monthsDiff < 0 || (monthsDiff === 0 && daysDiff < 0)) {
          yearsDiff--;
          monthsDiff += 12;
        }
    
        if (daysDiff < 0) {
          const lastMonth = new Date(today.getFullYear(), today.getMonth(), 0); // Last day of the previous month
          daysDiff += lastMonth.getDate();
          monthsDiff--;
        }
    
        // Construct age string based on conditions
        if (yearsDiff > 1) {
          return `${yearsDiff}Y`; // Show years in the format "XY"
        } else if (yearsDiff === 1) {
          return `1Y`; // Show "1Y" for exactly one year
        } else {
          // Less than one year; return the month and day format
          return monthsDiff > 0 || daysDiff > 0 ? `${monthsDiff}M-${daysDiff}D` : '0D'; // Show in format "XM-XD" or "0D"
        }
      }
      FormateAgeSex(age: string, gender: string): string {
        if (age && gender) {
          let agesex = age + '/' + gender.charAt(0).toUpperCase();
          return agesex;
        }
        else
          return '';
      }
    closePopUpBox() {
        this.showPopUp = false;
    }
}
