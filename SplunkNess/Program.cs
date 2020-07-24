using Newtonsoft.Json;
using SplunkNess.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace SplunkNess
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hard coded like a baws
            var filePath = @"C:\Users\cpaton\Downloads\redirect-04-mar.json";
            var jsonTextNewLineDelimted = File.ReadAllText(filePath);

            // Newline Delimited JSON sucks :D
            char[] delimiters = new [] { '\r', '\n' };
            var jsonTextList = jsonTextNewLineDelimted.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
            var jsonText = $"[{string.Join(",", jsonTextList)}]";
            var jsonFileAsObject = JsonConvert.DeserializeObject<List<FrendRedirectLoggerModels>>(jsonText);


            //Report on what you care about
            var memberIds = jsonFileAsObject
                .Select(x => x.result.memberId)
                .ToList();
            
            var distinctMemberIds = memberIds
                .Distinct()
                .OrderBy(x => x.First())
                .ToList();

            Console.WriteLine("distinctMemberIds={0}", distinctMemberIds.Count());
            Console.Read();
        }
    }
}
