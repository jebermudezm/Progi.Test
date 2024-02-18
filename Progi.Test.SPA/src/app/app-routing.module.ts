import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { SidebarComponent } from './pages/sidebar/sidebar.component';
import { DashboardComponent } from './pages/dashboard/dashboard.component';
import { CalculatePriceComponent } from './pages/calculateprice/calculateprice.component';



const routes: Routes = [
  {path:'',
  component: SidebarComponent,  children: [
    {path: 'dashboard', component: DashboardComponent},
    {path: 'calculateprice', component: CalculatePriceComponent},
    {path:'**', component: DashboardComponent},
  ]
}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
  
})
export class AppRoutingModule { }
