using HillerødSejlklub.Library;

// Oprettelse af både
// int id, string boatType, string boatName, int sailNumber, string motorInfo, string boatDimensions, int yearOfConstruction)
Console.WriteLine();

Boat boat = new Boat(1,"Motorbåd","HavGris",7,"Yamaha 35HK","5M X 2M",2018);
Boat boat2 = new Boat(2, "Sejlbåd", "Kystens Knald", 88, "Ingen Motor", "7M x 3M", 2015);
Boat boat3 = new Boat(3, "Jolle", "Karen", 23, "Yamaha 10HK", "4M x 2M", 2012);
Boat boat4 = new Boat(4, "Racer", "Usain Båd", 33, "Yamaha 250HK", "6M x 3M", 2025);

// Udskrivning af alle både
BoatRepository repository = new BoatRepository();
repository.PrintAllBoats();

// Oprettelse af brugere

Console.WriteLine();

User user = new User("Gunnar Gyllevogn", "Bøgevej 13, Roskilde", "55 30 71 27", "GunnarGG@gmail.com",true);
User user2 = new User("Ronnie RøvGuitar", "Hestevænget 55, Fredensborg", "88 45 60 33", "RonnieR55@gmail.com", true);
User user3 = new User("Søren SyvSover", "FjongVej 76, Hillerød", "87 36 95 12", "SorenSS76@gmail.com", true);
User user4 = new User("Lars Lokum", "HokusPokusvej 10, Vedbæk", "67 88 20 10", "Lars10@gmail.com", true);
User user5 = new User("Jørgen Jordbærtærte", "Nørregade 27, København", "41 10 80 44", "BagerJorgen@gmail.com", true);

// Udskrivning af alle brugere

UserRepository userRepository = new UserRepository();
userRepository.GetAllMembers();

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

