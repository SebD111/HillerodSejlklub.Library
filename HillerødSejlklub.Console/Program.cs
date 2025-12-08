using HillerødSejlklub.Library;
Boat boat = new Boat(1,"9/11 tower dive","test",2,"test","test",0);
Boat boat2 = new Boat(2, "Den flyvende hollænder", "2test", 2, "test", "test", 0);
Boat boat3 = new Boat(3, "test", "3test", 2, "test", "test", 0);
Boat boat4 = new Boat(4, "test", "4test", 2, "test", "test", 0);

BoatRepository repository = new BoatRepository();
repository.PrintAllBoats();

User user = new User(1, "John Doe", "123 Main St", "555-1234", "hej123@gmail.com",true);
User user2 = new User(1, "John Doe2", "123 Main St", "555-1234", "hej123@gmail.com", true);
User user3 = new User(1, "John Doe3", "123 Main St", "555-1234", "hej123@gmail.com", true);
User user4 = new User(1, "John Doe4", "123 Main St", "555-1234", "hej123@gmail.com", true);
User user5 = new User(1, "John Doe5", "123 Main St", "555-1234", "hej123@gmail.com", true);

UserRepository userRepository = new UserRepository();
userRepository.GetAllMembers();

Booking booking = new Booking(boat, new DateTime(2025, 12, 23, 10, 0, 0), new DateTime(2025, 12, 23, 16, 0, 0), user, 1, "The sea");
booking.GetAll();

Booking booking1 = new Booking(boat2, new DateTime(2025, 12, 23, 16, 0, 0), new DateTime(2025, 12, 23, 18, 0, 0), user2, 1, "The sea");
booking.GetAll();

booking.BoatInTheWater(new DateTime(2025, 12, 23,0,0,0), new DateTime(2025,12,23,23,0,0));
booking.SafeReturn(1);
booking.GetAll();
Console.WriteLine();

var start1 = new DateTime(2025, 06, 02, 13, 00, 00);
var end1 = new DateTime(2025, 06, 02, 15, 00, 00);

var ev1 = Event.Create("Klubmøde", start1, end1, "Ny hjemmeside", 20, "Hillerød Sejlklub");


var start2 = new DateTime(2025, 08, 15, 13, 00, 00);
var end2 = new DateTime(2025, 08, 15, 15, 00, 00);

var ev2 = Event.Create("Årlige Kapløb", start2, end2, "Hurtigeste båd vinder", 50, "Hillerød Sejlklub");

Event.PrintAll();

