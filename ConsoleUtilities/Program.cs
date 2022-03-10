using System;
using ClassLibrary;


SecureConsole Input = new SecureConsole();

CustomStrings One = new CustomStrings();

Console.WriteLine(One.GetStringOfNumbers(Input.SecureInputInteger()));

Console.WriteLine(One.GetRectangleAsterix(Input.SecureInputInteger()));