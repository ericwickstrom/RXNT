export interface Appointment {
  id: string;
  patientId: string;
  doctorId: string;
  scheduledDateTime: Date;
  status: AppointmentStatus;
  notes?: string;
}

export enum AppointmentStatus {
  Scheduled = 'Scheduled',
  Completed = 'Completed', 
  Cancelled = 'Cancelled'
}
