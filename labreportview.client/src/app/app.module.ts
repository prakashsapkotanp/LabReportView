import { HttpClientModule } from '@angular/common/http';
import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppComponent } from './app.component';
import { FormsModule } from '@angular/forms';
import { DanpheBarCodeComponent } from './bar-code/danphe-bar-code.component';
import { ReportSearchComponent } from './report-search-page';

@NgModule({
  declarations: [
    AppComponent,
    DanpheBarCodeComponent,
    ReportSearchComponent
  ],
  imports: [
    BrowserModule, HttpClientModule,FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
