import { HttpClient } from '@angular/common/http';
import { Component } from '@angular/core';
import { User } from './User.model';

@Component({
  templateUrl: './user.component.html'
})
export class UserComponent {

  constructor(public httpc:HttpClient) {
   

  }
  title = 'first-sample-project';
  myname = 'Shubhangi zagade'
  UserModel: User = new User();
  UserModels: Array<User> = new Array<User>();
  AddUser() {
    console.log(this.UserModel);
    //this.UserModels.push(this.UserModel);

    var Userdto={
      ID:this.UserModel.id,
      Password:this.UserModel.password,
      Name:this.UserModel.name,
      Gender:this.UserModel.gender,
     
    }
    console.log("continue");
    this.httpc.post("https://localhost:44386/api/User",Userdto).subscribe(res=>this.PostSuccess(res),res=>this.PostError(res));
    this.UserModel = new User();
  }

  PostSuccess(res:any){
    console.log(res);
    
  }
 // console.log("yes");

  PostError(res:any){
    console.log(res);
  }
  EditUser(input: User) {
    this.UserModel = input;
  }
  DeleteUser(input: User) {
    var index=this.UserModels.indexOf(input);
    this.UserModels.splice(index,1);
  }
  getData(){
    console.log("Hi");
    this.httpc.get("https://localhost:44386/api/User").subscribe(res=>this.GetSuccess(res),res=>this.GetError(res));
  }
  GetSuccess(input:any){
    this.UserModels=input;
  }
  GetError(input:any){
    console.log(input);
  }
}
