
//Part 1: The Name
using System.Security;

System.Console.Write("What is your full Name?");

string fullName = Console.ReadLine();
fullName = fullName.Trim();

int spacePosition = fullName.IndexOf(" ");
string firstName =fullName.Substring(0, 1);
string lastName = fullName.Substring(spacePosition + 1);

string firstLetter = firstName.ToLower();
string lastLetter = lastName.ToLower();
string badgeName = fullName.ToUpper();

string fI=firstName.Substring(0, 1);
string lI = lastName.Substring(0, 1);
string firstInitial = fI.ToUpper();
string lastInitial = lI.ToUpper();
int lastNameLetters = lastName.Length;

System.Console.WriteLine("Full Name: " + fullName);
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

//Part 3: The Walk

System.Console.WriteLine("What is the dorm's x?");
int dormX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("What is the dorm's y?");
int dormY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("What is the classroom's x");
int classroomX = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("What is the classroom's y");
int classroomY = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Walking speed in feet per second: "); 
double walkingSpeed = Convert.ToDouble(Console.ReadLine());

double distance = Math.Sqrt(Math.Pow((classroomX - dormX), 2) + Math.Pow((classroomY - dormY), 2));
double tripSeconds = distance / walkingSpeed;
double minutes = Convert.ToInt32(tripSeconds) / 60;
double seconds = (int)tripSeconds % 60;


System.Console.WriteLine("Distance: " + distance.ToString("F1") + " feet");
System.Console.WriteLine("Walk time: " + minutes + " minutes and " + seconds + " seconds" );

