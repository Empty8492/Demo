import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { TableComponent } from './component/table/table.component';
import { CharComponent } from './component/char/char.component';
import { LineComponent } from './component/char/line/line.component';
import { PieComponent } from './component/char/pie/pie.component';
import { InsertComponent } from './component/table/insert/insert.component';
import { SelectComponent } from './component/table/select/select.component';

import {HighchartsChartModule} from 'highcharts-angular';
import {FormsModule} from '@angular/forms';
import { HomeComponent } from './component/home/home.component';
import { ColumnComponent } from './component/char/column/column.component';
@NgModule({
  declarations: [
    AppComponent,
    TableComponent,
    CharComponent,
    LineComponent,
    PieComponent,
    InsertComponent,
    SelectComponent,
    HomeComponent,
    ColumnComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HighchartsChartModule,
    FormsModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
