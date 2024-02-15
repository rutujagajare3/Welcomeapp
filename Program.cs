// See https://aka.ms/new-console-template for more information
using WelcomeApp;
Console.WriteLine("Welcome to Authentication App");
Signin obj = new Signin();
Console.WriteLine(obj.Authenticate("admin","admin@1256"));
