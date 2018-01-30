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
               
            var dataState1 = new DataState1("Teodor", "Elstad");
            Console.WriteLine($"DataState1: {dataState1.Fullname}");

            var dataState2 = new DataState2("Magnus", "Karlsson");
            Console.WriteLine($"DataState2: {dataState2.Fullname()}\n");

            // Static
            Console.WriteLine("Press enter for Static:");
            Console.ReadLine();

            Console.WriteLine($"DateStamp1 GetShortDateStamp(): {DateStamp1.GetShortDateStamp(DateTime.Now)}");
            Console.WriteLine($"DateStamp1 GetLongDateStamp(): {DateStamp1.GetLongDateStamp(DateTime.Now)}");

            var dateStamp2 = new DateStamp2(DateTime.Now);
            Console.WriteLine($"DateStamp2 GetShortDateStamp(): {dateStamp2.GetShortDateStamp()}");
            Console.WriteLine($"DateStamp2 GetLongDateStamp(): {dateStamp2.GetLongDateStamp()}\n");

            // Var
            Console.WriteLine("Press enter for Var:");
            Console.ReadLine();

            var bookIdTagsMap = new Dictionary<Guid, List<string>>()
            {
                { Guid.NewGuid(), new List<string>{"triller", "teens", "werewolves", "vampires" } },
                { Guid.NewGuid(), new List<string>{"insect", "teleportation"} },
                { Guid.NewGuid(), new List<string>{"monster", "frankenstein", "lightning"} }
            };

            var var1 = new Var1(bookIdTagsMap);
            Console.WriteLine($"Var1:\n{var1.ToString()}");

            var var2 = new Var2(bookIdTagsMap);
            Console.WriteLine($"Var2:\n{var2.ToString()}\n");

            // Linq
            Console.WriteLine("Press enter for Linq:");
            Console.ReadLine();

            var listOfCx = new List<string>
            {
                "something CX! something",
                "No dice :-(",
                "something CX! again"
            };

            var linq1 = new Linq1(listOfCx);
            Console.WriteLine($"Linq1: {linq1.ToString()}");

            var linq2 = new Linq2(listOfCx);
            Console.WriteLine($"Linq2: {linq2.ToString()}\n");

            // MethodExtraction
            // TODO

            // ExceptionHandling
            // TODO
        }
    }
}
