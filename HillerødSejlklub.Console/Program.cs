using HillerødSejlklub.Library;
Boat boat = new Boat(1);

Booking booking = new Booking(boat,new DateTime(2025, 12, 23, 10, 0, 0),new DateTime(2025,12,23,16,0,0),"Bob",1,"The sea");
booking.GetAll();
Booking booking1 = new Booking(boat,new DateTime(2025, 12, 23, 16, 0, 0), new DateTime(2025, 12, 23, 18, 0, 0), "Bob", 1, "The sea");
booking.GetAll();

User user = new User(1, "John Doe", "123 Main St", "555-1234", "hej123@gmail.com");

Console.WriteLine();

var start1 = new DateTime(2025, 06, 02, 13, 00, 00);
var end1 = new DateTime(2025, 06, 02, 15, 00, 00);

var ev1 = Event.Create("Klubmøde", start1, end1, "Ny hjemmeside", 20, "Hillerød Sejlklub");


var start2 = new DateTime(2025, 08, 15, 13, 00, 00);
var end2 = new DateTime(2025, 08, 15, 15, 00, 00);

var ev2 = Event.Create("Årlige Kapløb", start2, end2, "Hurtigeste båd vinder", 50, "Hillerød Sejlklub");

Event.PrintAll();

