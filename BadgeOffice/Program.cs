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

//Part 2: The Numbers


