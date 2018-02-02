using System;
using System.Collections.Generic;

namespace Werewolves.Dilemmas
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Beware of Werewolves... Press enter to continue.");
            Console.WriteLine("Press enter to continue.");
            Console.ReadLine();

            var s = @"
      /^\      /^\
      |  \    /  |
      ||\ \../ /||
      )'        `(
     ,;`w,    ,w';,
     ;,  ) __ (  ,;
      ;  \(\/)/  ;;
     ;|  |vwwv|    ``-...
      ;  `lwwl'   ;      ```''-.
     ;| ; `""' ; ;              `.
      ;         ,   ,          , |
      '  ;      ;   l    .     | |
      ;    ,  ,    |,-,._|      \;
       ;  ; `' ;   '    \ `\     \;
       |  |    |  |     |   |    |;
       |  ;    ;  |      \   \   (;
       | |      | l       | | \  |
       | |      | |       | |  ) |
       | |      | ;       | |  | |
       ; ,      : ,      ,_.'  | |
      :__'      | |           ,_.'
               `--'";
               
            Console.WriteLine(s);

            // DataState
            Console.WriteLine("Press enter for DataState:");
            Console.ReadLine();
               
            var dataState = new DataState("Teodor", "Elstad");
            Console.WriteLine($"DataState: {dataState.Fullname}");

            // Static
            Console.WriteLine("Press enter for Static:");
            Console.ReadLine();

            Console.WriteLine($"DateStamp GetShortDateStamp(): {DateStamp.GetShortDateStamp(DateTime.Now)}");
            Console.WriteLine($"DateStamp GetLongDateStamp(): {DateStamp.GetLongDateStamp(DateTime.Now)}");

            // Var
            Console.WriteLine("Press enter for Var:");
            Console.ReadLine();

            var bookIdTagsMap = new Dictionary<Guid, List<string>>()
            {
                { Guid.NewGuid(), new List<string>{"triller", "teens", "werewolves", "vampires" } },
                { Guid.NewGuid(), new List<string>{"insect", "teleportation"} },
                { Guid.NewGuid(), new List<string>{"monster", "frankenstein", "lightning"} }
            };

            var var = new Var(bookIdTagsMap);
            Console.WriteLine($"Var:\n{var.ToString()}");

            // MethodExtraction
            Console.WriteLine("Press enter for MethodExtraction:");
            Console.ReadLine();

            var dirs = new List<string> { "/" };
            Console.WriteLine($"MethodExtraction: {MethodExtraction.TotalFileSizeInDirectories(dirs)}");

            // Linq
            Console.WriteLine("Press enter for Linq:");
            Console.ReadLine();

            var listOfCx = new List<string>
            {
                "something CX! something",
                "No dice :-(",
                "something CX! again"
            };

            var linq = new Linq(listOfCx);
            Console.WriteLine($"Linq: {linq.ToString()}");

            // ExceptionHandling
            // A running example including ExceptionHandling is left as an exercise for the reader.
        }
    }
}
