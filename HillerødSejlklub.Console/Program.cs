using HillerødSejlklub.Library;

// Oprettelse af motor(er)
Motor motor1 = new Motor("Yamaha", 150, "Benzin", 2018);
Motor motor2 = new Motor("Suzuki", 10, "Benzin", 2020);

// Oprettelse af både
Boat Boat1 = new MotorBoat(4, "Usain Boat", 25, motor1, "5M X 3M", 2018);
Boat Boat2 = new SailBoat(5, "Kystens Knald", 33, "7M X 3M", 2023, "35 m²");
Boat Boat3 = new DinghyBoat(6, "Karen", 42, "2M X 2M", 2012, 2);
Console.WriteLine();
// Oprettelse af brugere
Console.WriteLine();
Console.WriteLine("-------- Test af UserRepository --------\n UserRepository userRepository = new UserRepository();\nnuserRepository.PrintAll();");
UserRepository userRepository = new UserRepository();

userRepository.PrintAll();
User user = new User("Gunnar Gyllevogn", "Bøgevej 13, Roskilde", "55 30 71 27", "GunnarGG@gmail.com", true);
User user2 = new User("Ronnie RøvGuitar", "Hestevænget 55, Fredensborg", "88 45 60 33", "RonnieR55@gmail.com", true);
User user3 = new User("Søren SyvSover", "FjongVej 76, Hillerød", "87 36 95 12", "SorenSS76@gmail.com", true);
User user4 = new User("Lars Lokum", "HokusPokusvej 10, Vedbæk", "67 88 20 10", "Lars10@gmail.com", true);
User user5 = new User("Jørgen Jordbærtærte", "Nørregade 27, København", "41 10 80 44", "BagerJorgen@gmail.com", true);

// Udskrivning af alle brugere
userRepository.Add(user);
userRepository.Add(user2);
userRepository.Add(user3);
userRepository.Add(user4);
userRepository.Add(user5);
Console.WriteLine("-------- Denne metode udskriver alle brugere --------");
Console.WriteLine("userRepository.PrintAll();");
userRepository.PrintAll();

Console.WriteLine("-------- Denne metode udskriver antal brugere --------\n int test = userRepository.Count();\n Console.WriteLine(test);");
int test = userRepository.Count();
Console.WriteLine($"Antal Medlemmere {test}");

Console.WriteLine("-------- Denne metode sletter en bruger baseret på navn --------\n userRepository.RemoveByName(\"Søren SyvSover\");");
userRepository.RemoveByName("Søren SyvSover");

Console.WriteLine("-------- Denne metode udskriver alle brugere, efter brugen af RemoveByName --------\n userRepository.PrintAll();");
userRepository.PrintAll();

Console.WriteLine("-------- Denne metode udskriver antal brugere, efter brugen af RemoveByName --------\n test = userRepository.Count();\n Console.WriteLine(test);");
test = userRepository.Count();
Console.WriteLine($"Antal Medlemmere {test}");

Console.WriteLine("-------- Denne metode finder en bruger baseret på navn--------\n User TestOfGetByeName = userRepository.GetByName(\"Lars Lokum\");\n Console.WriteLine($\"Her er brugerens navn: { TestOfGetByeName.Name} her er brugerens email: {TestOfGetByeName.Email}\");");
User TestOfGetByeName = userRepository.GetByName("Lars Lokum");
Console.WriteLine($"Her er brugerens navn: { TestOfGetByeName.Name} her er brugerens email: {TestOfGetByeName.Email}");

Console.WriteLine("-------- Denne metode Opdaterer informationer for brugerne --------\n userRepository.Update(1, newAddress: \"Københavnsvej 99, Roskilde\", newPhone: \"12341234\", newEmail: \"TESTUpdate@mail.dk\");");
userRepository.Update(1, newAddress: "Københavnsvej 99, Roskilde", newPhone: "12341234", newEmail: "TESTUpdate@mail.dk");

Console.WriteLine(" -------- Denne metode udsrkiver alle brugere, efter brugen af update --------");  
userRepository.PrintAll();
Console.WriteLine("Nu er vi færdige med alle metoder i UserRepository");
Console.WriteLine("-------------------------------------------------------");


// Oprettelse af bookinger
BookingRepository bookingRepo = new BookingRepository();
Booking booking = new Booking(Boat1, new DateTime(2025, 12, 23, 10, 0, 0), new DateTime(2025, 12, 23, 16, 0, 0), user, 1, "The sea");
Console.WriteLine("-------- Denne metode tilføjer en booking --------\n bookingRepo.Add(booking);");
bookingRepo.Add(booking);
Console.WriteLine("-------- Denne metode udskriver alle bookinger --------\n bookingRepo.PrintAll();");
bookingRepo.PrintAll();

Console.WriteLine("-------- Prøver at lave en booking på en båd som allerede er booket i det tidsrum --------");

Console.WriteLine();
Booking booking1 = new Booking(Boat1, new DateTime(2025, 12, 23, 6, 0, 0), new DateTime(2025, 12, 23, 11, 0, 0), user, 1, "The sea");
Console.WriteLine("-------- Denne metode tilføjer en booking --------\n bookingRepo.Add(booking1);");
bookingRepo.Add(booking1);

Console.WriteLine("-------- Denne metode udskriver alle bookinger --------\n bookingRepo.PrintAll();");
bookingRepo.PrintAll();


Booking booking2 = new Booking(Boat3, new DateTime(2025, 12, 11, 10, 0, 0), new DateTime(2025, 12, 11, 18, 0, 0), user2, 1, "The sea");
Console.WriteLine("-------- Denne metode tilføjer en booking --------\n bookingRepo.Add(booking2);");
bookingRepo.Add(booking2);
Console.WriteLine("-------- Denne metode udskriver alle bookinger --------\n bookingRepo.PrintAll();");
bookingRepo.PrintAll();

Console.WriteLine("-------- Denne metode udskriver alle både som er i brug --------\n bookingRepo.ShowAllBoatInTheWater();");
bookingRepo.ShowAllBoatInTheWater();

Console.WriteLine("-------- Denne metode sletter en booking ud fra booking id --------\n bookingRepo.SafeReturn(1); ");
bookingRepo.SafeReturn(1);

Console.WriteLine("-------- Denne metode udskriver alle bookinger, efter brugen af SafeReturn --------\n bookingRepo.PrintAll();");
bookingRepo.PrintAll();
Console.WriteLine("-------------------------------------------------------");
Console.WriteLine("Nu er vi færdige med alle metoder i BookingRepository");
Console.WriteLine("-------------------------------------------------------");

// Udskrivning af både med/uden motor 
Console.WriteLine("Både og motorinfo:");
BoatRepository boatRepo = new BoatRepository();
boatRepo.Add(Boat1);
boatRepo.Add(Boat2);
boatRepo.Add(Boat3);
Console.WriteLine("-------- Denne metode udskriver alle både --------\n boatRepo.PrintAll();");
boatRepo.PrintAll();

Console.WriteLine();
Console.WriteLine("-------- Denne metode sletter en båd uf fra id --------\n boatRepo.Remove(2);");
boatRepo.Remove(2);

Console.WriteLine("-------- Denne metode udskriver alle både, efter brugen af remove --------\n boatRepo.PrintAll();");
boatRepo.PrintAll();

Console.WriteLine("-------- Denne metode finder en båd uf fra dens id --------\n Boat boat = boatRepo.GetById(3);\n Console.WriteLine(boat.ToString(boat));");
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
Console.WriteLine("-------- Denne metode printer alle events --------\n eventRepo.PrintAll();");
eventRepo.PrintAll();

Console.WriteLine("-------- Denne metode fjerner et event ud fra dens titel --------\n eventRepo.RemoveByTitle(\"Sommerfrokost\");");
eventRepo.RemoveByTitle("Sommerfrokost");

Console.WriteLine("-------- Denne metode printer alle events, efter brugen af RemoveByTitle --------\n eventRepo.PrintAll();");
eventRepo.PrintAll();

Console.WriteLine("-------- Denne metode finder et event ud fra dens titel --------\n Event eventTestGetByeTitle = eventRepo.GetByTitle(\"Årlige Kapløb\");");
Event eventTestGetByeTitle = eventRepo.GetByTitle("Årlige Kapløb");
Console.WriteLine($" Her får vi event titelen: {eventTestGetByeTitle.Title}");

//Console.WriteLine(eventTestGetByeTitle.Title);

Console.WriteLine("\n-------- Denne metode tilføjer brugere til et event --------\n eventRepo.AddUserToEvent(Årlige Kapløb, 1, userRepository);\n");
eventRepo.AddUserToEvent("Årlige Kapløb", 1, userRepository);
eventRepo.AddUserToEvent("Årlige Kapløb", 2, userRepository);
Console.WriteLine("\n-------- Denne metode prøver at tilføje en bruger som ikke eksisterer til et event --------\n eventRepo.AddUserToEvent(Årlige Kapløb, 99, userRepository);\n");
eventRepo.AddUserToEvent("Årlige Kapløb", 99, userRepository);
Console.WriteLine("\n-------- Denne metode prøver at tilføje en bruger til et event som ikke eksisterer --------\n eventRepo.AddUserToEvent(Årlige Sejltur, 4, userRepository);\n");
eventRepo.AddUserToEvent("Sommerfrokost", 4, userRepository);
Console.WriteLine("\n-------- Denne metode prøver at tilføje en bruger til et fuldt booket event --------\n eventRepo.AddUserToEvent(Sommerfrokost, 5, userRepository);\n");
eventRepo.AddUserToEvent("Rave party", 5, userRepository);
