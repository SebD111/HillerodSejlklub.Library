using HillerødSejlklub.Library;

// Oprettelse af både
var Boat1 = new MotorBoat(1,"Usain Boat, 5M X 3M", 2018);
var Boat2 = new SailBoat(2, "Kystens Knald, 7M X 3M", 2023);
var Boat3 = new DinghyBoat(3, "Karen, 2M X 2M", 2012);


Console.WriteLine();


// Oprettelse af brugere

Console.WriteLine();

User user = new User("Gunnar Gyllevogn", "Bøgevej 13, Roskilde", "55 30 71 27", "GunnarGG@gmail.com",true);
User user2 = new User("Ronnie RøvGuitar", "Hestevænget 55, Fredensborg", "88 45 60 33", "RonnieR55@gmail.com", true);
User user3 = new User("Søren SyvSover", "FjongVej 76, Hillerød", "87 36 95 12", "SorenSS76@gmail.com", true);
User user4 = new User("Lars Lokum", "HokusPokusvej 10, Vedbæk", "67 88 20 10", "Lars10@gmail.com", true);
User user5 = new User("Jørgen Jordbærtærte", "Nørregade 27, København", "41 10 80 44", "BagerJorgen@gmail.com", true);

// Udskrivning af alle brugere

UserRepository userRepository = new UserRepository();
userRepository.GetAll();

Console.WriteLine();

// Oprettelse af bookinger
Booking booking = new Booking(boat, new DateTime(2025, 12, 23, 10, 0, 0), new DateTime(2025, 12, 23, 16, 0, 0), user, 1, "The sea");
booking.GetAll();

Console.WriteLine();
Booking booking1 = new Booking(boat, new DateTime(2025, 12, 23, 6, 0, 0), new DateTime(2025, 12, 23, 10, 0, 0), user, 1, "The sea");
booking.GetAll();

Booking booking2 = new Booking(boat2, new DateTime(2025, 12, 23, 16, 0, 0), new DateTime(2025, 12, 23, 18, 0, 0), user2, 1, "The sea");
booking.GetAll();


booking.BoatInTheWater(new DateTime(2025, 12, 23,0,0,0), new DateTime(2025,12,23,23,0,0));
booking.SafeReturn(1);
booking.GetAll();
Console.WriteLine();


// Oprettelse af events
var start1 = new DateTime(2025, 06, 02, 13, 00, 00);
var end1 = new DateTime(2025, 06, 02, 15, 00, 00);

var ev1 = Event.Create("Klubmøde", start1, end1, "Ny hjemmeside", 20, "Hillerød Sejlklub");


var start2 = new DateTime(2025, 08, 15, 13, 00, 00);
var end2 = new DateTime(2025, 08, 15, 15, 00, 00);

var ev2 = Event.Create("Årlige Kapløb", start2, end2, "Hurtigeste båd vinder", 50, "Hillerød Sejlklub");

// Udskrivning af alle events
Event.PrintAll();

