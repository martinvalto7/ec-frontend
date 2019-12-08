import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ProductListComponent } from './product-list/product-list.component';
import { ListProductComponent } from './list-product/list-product.component';
import { HomeComponent } from './home/home.component';


const routes: Routes = [
  { path:'', component: HomeComponent,},
  { path:'products', component: ProductListComponent,},
  
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
