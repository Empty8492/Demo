import { Component, OnInit } from '@angular/core';
import * as $ from 'jquery';
@Component({
  selector: 'app-insert',
  templateUrl: './insert.component.html',
  styleUrls: ['./insert.component.css']
})
export class InsertComponent implements OnInit {

  constructor() { }
  public all1: boolean = true;
  public Name: any;
  public January: any;
  public February: any;
  public March: any;
  ngOnInit(): void {
  }
  insertdata() {
    if (this.Name == undefined || this.January == undefined || this.February == undefined || this.March == undefined) {
      this.all1 = true;
    }
    else {
      this.all1 = false;
    }
  }
  Insert() {
    var param = { "Name": this.Name, "January": parseInt(this.January, 10), "February": parseInt(this.February, 10), "March": parseInt(this.March, 10) };
      $.ajax({
        url: "https://localhost:44371/api/Users",
        type: "post",
        data: param,
        success: function (data) {
          alert("成功添加数据");
          window.location.reload();
        }
      })

    
  }
}
