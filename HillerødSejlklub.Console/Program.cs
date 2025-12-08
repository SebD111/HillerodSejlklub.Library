using HillerødSejlklub.Library;
Boat boat = new Boat(1,"test","test",2,"test","test",0);
Boat boat2 = new Boat(2, "test", "2test", 2, "test", "test", 0);
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

Booking booking1 = new Booking(boat, new DateTime(2025, 12, 23, 16, 0, 0), new DateTime(2025, 12, 23, 18, 0, 0), user2, 1, "The sea");
booking.GetAll();




    



