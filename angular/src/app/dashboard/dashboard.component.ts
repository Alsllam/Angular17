import { Component } from '@angular/core';

@Component({
  selector: 'app-dashboard',
  template: `
    <app-host-dashboard *abpPermission="'SmartApp.Dashboard.Host'"></app-host-dashboard>
    <app-tenant-dashboard *abpPermission="'SmartApp.Dashboard.Tenant'"></app-tenant-dashboard>
  `,
})
export class DashboardComponent {}
