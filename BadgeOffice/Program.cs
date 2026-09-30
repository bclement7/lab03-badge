//Part 1: The Name

System.Console.Write("What is your full Name?");


string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName =fullName.Substring(0, 1);
string lastName = fullName.Substring(spacePosition + 1);

string firstLetter = firstName.ToLower();
string lastLetter = lastName.ToLower();
string badgeName = fullName.ToUpper();

string firstInitial =firstName.Substring(0, 1);
string lastInitial = lastName.Substring(0, 1);

int lastNameLetters = lastName.Length;

System.Console.WriteLine("Name on Badge: " + badgeName);
System.Console.WriteLine("Username: " + firstLetter + lastLetter);
System.Console.WriteLine("Initials: " + firstInitial +"." + lastInitial + ".");
System.Console.WriteLine("Letters in last Name: " + lastNameLetters);
System.Console.WriteLine();
//Part 2: The Numbers

Random rng = new Random();

int studentId = rng.Next(100000, 1000000);
int lockerNumber = rng.Next(1, 501);

System.Console.WriteLine("Student ID: " + studentId);
System.Console.WriteLine("Locker: " + lockerNumber);
System.Console.WriteLine();



