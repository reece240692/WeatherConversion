import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { HttpClientModule } from '@angular/common/http';

import { AppComponent } from './app.component';
import { TempConverterComponent } from './temp-converter/temp-converter.component';
import { HistoryPanelComponent } from './history-panel/history-panel.component';

@NgModule({
  declarations: [
    AppComponent,
    TempConverterComponent,
    HistoryPanelComponent
  ],
  imports: [
    BrowserModule,
    HttpClientModule,
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
