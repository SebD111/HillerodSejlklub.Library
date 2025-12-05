using HillerødSejlklub.Library;
Boat boat = new Boat(1);

Booking booking = new Booking(boat,new DateTime(2025, 12, 23, 10, 0, 0),new DateTime(2025,12,23,16,0,0),"Bob",1,"The sea");
booking.GetAll();
Booking booking1 = new Booking(boat,new DateTime(2025, 12, 23, 16, 0, 0), new DateTime(2025, 12, 23, 18, 0, 0), "Bob", 1, "The sea");
booking.GetAll();

User user = new User(1, "John Doe", "123 Main St", "555-1234", "hej123@gmail.com");



var start = new DateTime(2025, 12, 02, 13, 00, 00);
var end = new DateTime(2025, 12, 02, 15, 00, 00);

var ev = Event.Create("Klubmøde", start, end, "Ny hjemmeside", 20, "Hillerød");
Event.PrintAll();

