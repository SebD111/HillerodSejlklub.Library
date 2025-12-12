using HillerødSejlklub.Library;

// Oprettelse af motor(er)
Motor motor1 = new Motor("Yamaha", 150, "Benzin", 2018);
Motor motor2 = new Motor("Suzuki", 10, "Benzin", 2020);
// Oprettelse af både
Boat Boat1 = new MotorBoat(1, "Usain Boat", 25, motor1, "5M X 3M", 2018);
Boat Boat2 = new SailBoat(2, "Kystens Knald", 33, "7M X 3M", 2023, "35 m²");
Boat Boat3 = new DinghyBoat(3, "Karen", 42, "2M X 2M", 2012, 2);
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
userRepository.Add(user);
userRepository.Add(user2);
userRepository.Add(user3);
userRepository.Add(user4);
userRepository.Add(user5);
userRepository.PrintAll();
Console.WriteLine("----------------------------------------------------------");
int test = userRepository.Count();
Console.WriteLine(test);
Console.WriteLine("----------------------------------------------------------");
userRepository.RemoveByName("Søren SyvSover");
Console.WriteLine("userRepository.RemoveByName(\"Søren SyvSover\");");
userRepository.PrintAll();
Console.WriteLine("----------------------------------------------------------");
test = userRepository.Count();
Console.WriteLine(test);
Console.WriteLine("----------------------------------------------------------");
User TestOfGetByeName = userRepository.GetByName("Lars Lokum");
Console.WriteLine(TestOfGetByeName.Name + " " + TestOfGetByeName.Email);
Console.WriteLine("----------------------------------------------------------");
userRepository.Update(1, newAddress: "Københavnsvej 99, Roskilde", newPhone: "12341234", newEmail: "TESTUpdate@mail.dk");
userRepository.PrintAll();
Console.WriteLine("----------------------------------------------------------");


// Oprettelse af bookinger
BookingRepository bookingRepo = new BookingRepository();
Booking booking = new Booking(Boat1, new DateTime(2025, 12, 23, 10, 0, 0), new DateTime(2025, 12, 23, 16, 0, 0), user, 1, "The sea");
bookingRepo.Add(booking);
Console.WriteLine("Første booking oprettet:");
booking.PrintAll();

Console.WriteLine();
Booking booking1 = new Booking(Boat1, new DateTime(2025, 12, 23, 6, 0, 0), new DateTime(2025, 12, 23, 11, 0, 0), user, 1, "The sea");
bookingRepo.Add(booking1);
Console.WriteLine("Anden booking oprettet:");
booking.PrintAll();

Booking booking2 = new Booking(Boat3, new DateTime(2025, 12, 11, 10, 0, 0), new DateTime(2025, 12, 11, 18, 0, 0), user2, 1, "The sea");
bookingRepo.Add(booking2);
Console.WriteLine("Tredje booking oprettet:");
booking.PrintAll();
Console.WriteLine("--------------------------------");
booking.ShowAllBoatInTheWater();
Console.WriteLine("--------------------------------");
bookingRepo.SafeReturn(1);
Console.WriteLine("Efter første booking er returneret:");
booking.PrintAll();
Console.WriteLine("--------------------------------");

// Udskrivning af både med/uden motor 
Console.WriteLine("Både og motorinfo:");
BoatRepository boatRepo = new BoatRepository();
boatRepo.Add(Boat1);
boatRepo.Add(Boat2);
boatRepo.Add(Boat3);
boatRepo.PrintAll();

Console.WriteLine();
boatRepo.Remove(2);
boatRepo.PrintAll();
Boat boat = boatRepo.GetById(3);
Console.WriteLine(boat.ToString(boat));

// Oprettelse af events med repository


Event ev1 = new Event("Sommerfrokost", "Spisning med klubben", new DateTime(2025, 06, 02, 13, 00, 00), new DateTime(2025, 06, 02, 15, 00, 00), "Hillerød Sejlklub", 50);


Event ev2 = new Event("Årlige Kapløb","Hurtigste skipper vinder", new DateTime(2025, 08, 15, 13, 00, 00), new DateTime(2025, 08, 15, 15, 00, 00), "Hillerød Sejlklub", 100);

// Brug IEventRepository/EventRepository til at håndtere events
IEventRepository eventRepo = new EventRepository();
eventRepo.Add(ev1);
eventRepo.Add(ev2);

// Udskrivning af alle events
eventRepo.PrintAll();

eventRepo.RemoveByTitle("Sommerfrokost");

eventRepo.PrintAll();

Event eventTestGetByeTitle = eventRepo.GetByTitle("Årlige Kapløb");

//Console.WriteLine(eventTestGetByeTitle.Title);

eventRepo.AddUserToEvent("Årlige Kapløb", 1, userRepository);
eventRepo.AddUserToEvent("Årlige Kapløb", 2, userRepository);
eventRepo.AddUserToEvent("Årlige Kapløb", 3, userRepository);
eventRepo.AddUserToEvent("Årlige Kapløb", 4, userRepository);
eventRepo.AddUserToEvent("Årlige Kapløb", 5, userRepository);
