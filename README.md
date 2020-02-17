# SplunkNess
Provide stats on `.json` splunk logs when no dashboard exists.

### Caveat

My splunk instance provides `.json` as `newline-delimited JSON` which means there is no comma between each object. I hacked this by manually splitting the objects, this will be in-efficient for large amounts of data. 

### Usage

1. Do you search in splunk, export the results to `.json` 
2. Open in a text editor, copy the first row an generate a .net class online with http://json2csharp.com/
3. Copy the class files content into your application's models folder, check the namespace for clashes. Or don't, if your code doesn't compile I'll still eat subway :D
   1. I replaced `RootObject` with `FrendRedirectLoggerModels`
4.  Keep all the magic in `Program.cs` right? SOLID principals are for PHP developers right?
   1. Update `filePath` to point to your file
   2. Update `jsonFileAsObject` to be set using the type created above
5. Use LINQ to report/group on what you care about
   1. In my case I needed to know the unique member ID's

### References

* https://www.splunk.com/
* http://ndjson.org/
* http://json2csharp.com/