/*import { Component } from '@angular/core';
import { Supplier } from './supplier.model';

@Component({
  templateUrl: './supplier.component.html'
})
export class SupplierComponent {
  title = 'first-sample-project';
  myname = 'shubhangi zagade'
  SupplierModel: Supplier = new Supplier();
  SupplierModels: Array<Supplier> = new Array<Supplier>();
  AddSupplier() {
    this.SupplierModels.push(this.SupplierModel);
    this.SupplierModel = new Supplier();
  }
  EditSupplier(input: Supplier) {
    this.SupplierModel = input;
  }
  DeleteSupplier(input: Supplier) {
    var index = this.SupplierModels.indexOf(input);
    this.SupplierModels.splice(index, 1);
  }

}*/
import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Supplier } from './supplier.model';

@Component({
  templateUrl: './supplier.component.html'
})
export class SupplierComponent {
  constructor(public httpc:HttpClient) {

  }
  
  title = 'first-sample-project';
  myname = 'shubhangi zagade'
  SupplierModel: Supplier = new Supplier();
  SupplierModels: Array<Supplier> = new Array<Supplier>();
  AddSupplier() {
    console.log(this.SupplierModel);
   

    var supplierdto={
      supplierCode:this.SupplierModel.supplierCode,
      supplierName:this.SupplierModel.supplierName,
      supplierAmount:Number(this.SupplierModel.supplierAmount),
    
  }

  this.httpc.post("https://localhost:44331/api/Supplier",supplierdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.SupplierModel = new Supplier();
  }
  PostSuccess(res:any){
    console.log(res);
    
  }
  PostError(res:any){
    console.log(res);
  }
  EditCustomer(input: Supplier) {
    this.SupplierModel = input;
  }
  DeleteCustomer(input: Supplier) {
    var index=this.SupplierModels.indexOf(input);
    this.SupplierModels.splice(index,1);
  }

  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44331/api/Supplier").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.SupplierModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}



