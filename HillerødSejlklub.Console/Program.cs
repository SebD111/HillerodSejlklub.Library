using HillerødSejlklub.Library;

// Oprettelse af motor(er)
var motor1 = new Motor("Yamaha", 150, "Benzin", 2018);
var motor2 = new Motor("Suzuki", 10, "Benzin", 2020);

// Oprettelse af både
var Boat1 = new MotorBoat(1, "Usain Boat, 5M X 3M", 25, motor1, "5M X 3M", 2018);
var Boat2 = new SailBoat(2, "Kystens Knald, 7M X 3M", 33, "7M X 3M", 2023, "35 m²");
var Boat3 = new DinghyBoat(3, "Karen, 2M X 2M", 42, motor2, "2M X 2M", 2012, 2);

Console.WriteLine();

// Oprettelse af brugere

Console.WriteLine();

User user = new User("Gunnar Gyllevogn", "Bøgevej 13, Roskilde", "55 30 71 27", "GunnarGG@gmail.com", true);
User user2 = new User("Ronnie RøvGuitar", "Hestevænget 55, Fredensborg", "88 45 60 33", "RonnieR55@gmail.com", true);
User user3 = new User("Søren SyvSover", "FjongVej 76, Hillerød", "87 36 95 12", "SorenSS76@gmail.com", true);
User user4 = new User("Lars Lokum", "HokusPokusvej 10, Vedbæk", "67 88 20 10", "Lars10@gmail.com", true);
User user5 = new User("Jørgen Jordbærtærte", "Nørregade 27, København", "41 10 80 44", "BagerJorgen@gmail.com", true);

// Udskrivning af alle brugere
UserRepository userRepository = new UserRepository();
userRepository.GetAll();

Console.WriteLine();

// Oprettelse af bookinger
Booking booking = new Booking(Boat1, new DateTime(2025, 12, 23, 10, 0, 0), new DateTime(2025, 12, 23, 16, 0, 0), user, 1, "The sea");
booking.GetAll();

Console.WriteLine();
Booking booking1 = new Booking(Boat2, new DateTime(2025, 12, 23, 6, 0, 0), new DateTime(2025, 12, 23, 10, 0, 0), user, 1, "The sea");
booking.GetAll();

Booking booking2 = new Booking(Boat3, new DateTime(2025, 12, 23, 16, 0, 0), new DateTime(2025, 12, 23, 18, 0, 0), user2, 1, "The sea");
booking.GetAll();

booking.BoatInTheWater(new DateTime(2025, 12, 23, 0, 0, 0), new DateTime(2025, 12, 23, 23, 0, 0));
booking.SafeReturn(1);
booking.GetAll();
Console.WriteLine();

// Udskrivning af både med/uden motor 
Console.WriteLine("Både og motorinfo:");
var boatRepo = new BoatRepository();
foreach (Boat boat in boatRepo.GetAll())
{
    if (boat is MotorBoat motorBoat && motorBoat.Motor != null)
    {
        Console.WriteLine($"{boat.BoatName} - Motor:");
        Console.WriteLine(motorBoat.Motor.ToString());
    }
    else
    {
        Console.WriteLine($"{boat.BoatName} - Ingen motor");
    }
}
Console.WriteLine();


// Oprettelse af events med repository
var start1 = new DateTime(2025, 06, 02, 13, 00, 00);
var end1 = new DateTime(2025, 06, 02, 15, 00, 00);

var ev1 = new Event
{
    Title = "Sommerfrokost",
    StartDate = start1,
    EndDate = end1,
    Description = "Spisning med klubben",
    MaxParticipants = 50,
    Location = "Hillerød Sejlklub"
};

var start2 = new DateTime(2025, 08, 15, 13, 00, 00);
var end2 = new DateTime(2025, 08, 15, 15, 00, 00);

var ev2 = new Event
{
    Title = "Årlige Kapløb",
    StartDate = start2,
    EndDate = end2,
    Description = "Hurtigeste skipper vinder",
    MaxParticipants = 100,
    Location = "Hillerød Sejlklub"
};

// Brug IEventRepository/EventRepository til at håndtere events
IEventRepository eventRepo = new EventRepository();
eventRepo.Add(ev1);
eventRepo.Add(ev2);

// Udskrivning af alle events
eventRepo.GetAll();
