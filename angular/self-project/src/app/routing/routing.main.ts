import { UserComponent } from "../user/user.component";
import { HomeComponent } from "../Home/home.component";
import { ProductComponent } from "../product/product.component";
import { LoginComponent } from "../login/login.component";


export const MainRoutes= [
   {path:'',component:HomeComponent},
{path:'home',component:HomeComponent},
{path:'User',loadChildren:()=>import('../user/User.module').then(m=>m.UserModule)},
{path:'Product',loadChildren:()=>import('../product/product.module').then(m=>m.ProductModule)},
//{path:'Home',loadChildren:()=>import('../Home/master.module').then(m=>m.MasterModule)}
];