import { Routes } from '@angular/router';
import { Dashboard } from './components/dashboard/dashboard';
import { PatientList } from './components/patients/patient-list/patient-list';
import { AppointmentList } from './components/appointments/appointment-list/appointment-list';

export const routes: Routes = [
  { path: '', redirectTo: '/dashboard', pathMatch: 'full' },
  { path: 'dashboard', component: Dashboard },
  { path: 'patients', component: PatientList },
  { path: 'appointments', component: AppointmentList },
  { path: '**', redirectTo: '/dashboard' }
];