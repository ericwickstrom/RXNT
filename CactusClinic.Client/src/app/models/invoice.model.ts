export interface Invoice {
  id: string;
  appointmentId: string;
  amount: number;
  isPaid: boolean;
  paymentDate?: Date;
  createdDate: Date;
}
