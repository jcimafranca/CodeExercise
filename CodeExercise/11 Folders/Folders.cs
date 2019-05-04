using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

/*
Implement a function FolderNames, which accepts a string containing an XML file that specifies folder structure and returns all folder names that start with startingLetter. The XML format is given in the example below.

For example, for the letter 'u' and XML file:

<?xml version="1.0" encoding="UTF-8"?>
<folder name="c">
    <folder name="program files">
        <folder name="uninstall information" />
    </folder>
    <folder name="users" />
</folder>

the function should return "uninstall information" and "users" (in any order).
 */

public class Folders
{
    public static IEnumerable<string> FolderNames(string xml, char startingLetter)
    {        
        List<string> distinctPairs = new List<string>();

        XDocument xdoc = XDocument.Parse(xml);
        var result =
            from el in xdoc.Descendants("folder")                         
            select el.FirstAttribute.Value;            

        foreach (var a in result)
        {
            if(char.Parse(a.Substring(0,1)) == startingLetter)
            {
                distinctPairs.Add(a);
            }           
        }

        return distinctPairs;
        //throw new NotImplementedException("Waiting to be implemented.");
    }

    //public static void Main(string[] args)
    //{
    //    string xml =
    //        "<?xml version=\"1.0\" encoding=\"UTF-8\"?>" +
    //        "<folder name=\"c\">" +
    //            "<folder name=\"program files\">" +
    //                "<folder name=\"uninstall information\" />" +
    //            "</folder>" +
    //            "<folder name=\"users\" />" +
    //        "</folder>";

    //    foreach (string name in Folders.FolderNames(xml, 'u'))
    //        Console.WriteLine(name);
    //}
}