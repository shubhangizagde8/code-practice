import { UserComponent } from "../user/user.component";
//import { HomeComponent } from "../home/home.component";
//import { productComponent } from "../product/product.component";

export const MainRoutes= [
   // {path:'',component:HomeComponent},
  //  {path:'home',component:HomeComponent},
    {path:'User',loadChildren:()=>import('../user/User.module').then(m=>m.UserModule)},
    //{path:'product',loadChildren:()=>import('../product/product.module').then(m=>m.ProductModule)}
];