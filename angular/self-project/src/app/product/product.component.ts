import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { Product } from './product.model';

@Component({
  templateUrl: './product.component.html'
})
export class ProductComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'first-sample-project';
  myname = 'Shubhangi zagade'
  ProductModel: Product= new Product();
  ProductModels: Array<Product> = new Array<Product>();
  AddProduct() {
    console.log(this.ProductModel);
    //this.UserModels.push(this.UserModel);

    var Productdto={
      ID:this.ProductModel.id,
      Name:this.ProductModel.name,
     
    }
    //console.log("continue");
    this.httpc.post("https://localhost:44386/api/Product",Productdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.ProductModel = new Product();
  }

  PostSuccess(res:any){
    console.log(res);
    
  }
 // console.log("yes");

  PostError(res:any){
    console.log(res);
  }
  EditProduct(input: Product) {
    this.ProductModel = input;
  }
  DeleteProduct(input: Product) {
    var index=this.ProductModels.indexOf(input);
    this.ProductModels.splice(index,1);
  }
  getData(){
    
    this.httpc.get("https://localhost:44386/api/Product").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
    
  }

  GetSuccess(input:any){
    this.ProductModel=input;
    console.log("Hi");
  }
  GetError(input:any){
    console.log(input);
  }
}
