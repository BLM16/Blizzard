﻿using Blizzard;

[assembly: System.Runtime.CompilerServices.InternalsVisibleTo("Blizzard.Tests")]

#if DEBUG
// Use the default Examples/john.bzz file in DEBUG mode if no options are specified
// Allows debugging in an IDE without building and running from the command line
if (args.Length == 0)
{
    args = "run Examples/john.bzz".Split();
}
#endif

// Register the command line argument parser and invoke the handler method for the given command
new ArgumentParser().Register().Invoke(args);
