﻿string permission = "Admin|Manager";
int level = 55;

/**
    My Solution
*/
// if (!permission.Contains("Admin") && !permission.Contains("Manager") && level < 20)
// {
//     Console.WriteLine("You do not have sufficient privileges.");
// }
// else if (permission.Contains("Admin") && level > 55)
// {
//     Console.WriteLine("Welcome, Super Admin user.");
// }
// else if (permission.Contains("Admin") && level <= 55)
// {
//     Console.WriteLine("Welcome, Admin user.");
// }
// else if (!permission.Contains("Admin") && level >= 20)
// {
//     Console.WriteLine("Contact an Admin for access.");
// }

/**
    Other solution
*/
if (permission.Contains("Admin"))
{
    level > 55 ? Console.WriteLine("Welcome, Super Admin user.") : Console.WriteLine("Welcome, Admin user.")
}
else if (permission.Contains("Manager"))
{
    level >= 20 ? Console.WriteLine("Contact an Admin for access.") : Console.WriteLine("You do not have sufficient privileges.")
}
else
{
    Console.WriteLine("You do not have sufficient privileges.");
}