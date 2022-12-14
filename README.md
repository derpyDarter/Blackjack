# Blackjack
Blackjack Game Built On 32 Bit Windows

This blackjack game was built in C# using .Net 6.0. 

All assemblies of this game will run on Windows with .Net 6.0 CLR installed. 

To play the game, you will need to compile both the class library ("Blackjack") and the startup application ("FormsBlackjack"). 
The startup application will need to reference the class library to run. 

The class library containing the controllers and models will compile and run on Linux and Mac provided the .Net CLR is installed. 
You would just need a different user interface to call the methods from. 

As of 12.13.22 the GUI will only run on Windows, as it leverages Winforms, a Win32 API. 

The SDK required to build and run .Net applications are available here: https://dotnet.microsoft.com/en-us/download/dotnet/6.0

You can build the application on Windows, Mac, or Linux using the .Net CLI: https://learn.microsoft.com/en-us/dotnet/core/tools/

You can also build the application on Windows using Visual Studio: https://visualstudio.microsoft.com/
