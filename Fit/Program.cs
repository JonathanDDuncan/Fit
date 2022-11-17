// See https://aka.ms/new-console-template for more information

using Fit;

Console.WriteLine("Enter width1");
string str1 = Console.ReadLine();
Console.WriteLine("Enter height1");
string str2 = Console.ReadLine();
Console.WriteLine("Enter width2");
string str3 = Console.ReadLine();
Console.WriteLine("Enter height2");
string str4 = Console.ReadLine();

var rw1 = double.Parse(str1);
var rw2 = double.Parse(str3);
var rh1 = double.Parse(str2);
var rh2 = double.Parse(str4);

var result = Calculate.GetSize(rw1, rh1, rw2, rh2);
Console.WriteLine("New width is " + result.width3 + " new height is " + result.height3);