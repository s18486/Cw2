using System;
using System.Collections.Generic;
using System.IO;

namespace Cw2
{
    class Program
    {
        static void Main(string[] args)
        {
            string CSVPath;
            string DestPath;
            string Format;
            try
            {
                CSVPath = args[0];
                DestPath = args[1];
                Format = args[2];
            }catch (Exception)
            {
                CSVPath = @"C:\Users\s18486\Desktop\Cw2\Cw2\dane.csv";
                DestPath = @"C:\Users\s18486\Desktop\Cw2\Cw2\result.xml";
                Format = "xml";
            }

            var lines = File.ReadLines(CSVPath);

            HashSet<Student> set = new HashSet<Student>(new Comparator());


            foreach(var line in lines)
            {
                var tmp = line.Split(",");
                var tmpStudent = new Student {
                    fname = tmp[0],
                    lname = tmp[1],
                    indexNumber = "s" + tmp[5],
                    studies = new Course { name = tmp[3], mode = tmp[4] },
                    birthdate = tmp[6].Length >=9?tmp[6].Substring(0, 10):"",
                    email = tmp[7],
                    mothersName=tmp[8],
                    fathersName=tmp[9]
                };
                if (!set.Add(tmpStudent))
                {

                }
            }
            Console.WriteLine(set.Count);
        }
    }
}
