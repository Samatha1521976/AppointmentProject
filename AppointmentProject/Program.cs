// See https://aka.ms/new-console-template for more information
// Sample Input
using AppointmentProject;

Appointment obj = new Appointment("Tuesday", 15);
var res = obj.CheckSlot();

// Sample Output
Console.WriteLine(res); // Output: Available
