using HillerødSejlklub.Library;
Boat boat = new Boat(1);

Booking booking = new Booking(boat,new DateTime(2025, 12, 23, 10, 0, 0),new DateTime(2025,12,23,16,0,0),"Bob",1,"The sea");
booking.GetAll();
Booking booking1 = new Booking(boat,new DateTime(2025, 12, 23, 16, 0, 0), new DateTime(2025, 12, 23, 18, 0, 0), "Bob", 1, "The sea");
booking.GetAll();

