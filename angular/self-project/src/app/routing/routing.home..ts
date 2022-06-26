import { MasterComponent } from "../Home/master.component";
import { UserComponent } from "../user/user.component";
import { HomeComponent } from "../Home/home.component";
import { ProductComponent } from "../product/product.component";


export const ProductRoutes= [
    {path:'add',component:MasterComponent},
    
 //{path:'home',component:HomeComponent},
//{path:'User',loadChildren:()=>import('../user/User.module').then(m=>m.UserModule)},
//{path:'Product',loadChildren:()=>import('../product/product.module').then(m=>m.ProductModule)}
{path:'Home',loadChildren:()=>import('../Home/master.module').then(m=>m.MasterModule)}
  
];