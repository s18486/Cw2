using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

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
                CSVPath = @"D:\Users\User\Desktop\Cw2\Cw2\dane.csv";
                DestPath = @"D:\Users\User\Desktop\Cw2\Cw2\result.xml";
                Format = "xml";                
            }

            var lines = File.ReadLines(CSVPath);

            HashSet<Student> set = new HashSet<Student>(new Comparator());
            List<Course> studiesList = new List<Course>();


            foreach(var line in lines)
            {
                var tmp = line.Split(",");

                Course course = new Course { name = tmp[2] };

                if(!studiesList.Contains(course))
                    studiesList.Add(course);

                studiesList[studiesList.IndexOf(course)].numberOfStudents++;
               
                var tmpStudent = new Student
                {
                    fname = tmp[0],
                    lname = tmp[1],
                    indexNumber = "s" + tmp[4],
                    studies = new StCourse { name = tmp[2], mode = tmp[3] },
                    birthdate = tmp[5].Length >= 9 ? tmp[5].Substring(0, 9) : "",
                    email = tmp[6],
                    mothersName = tmp[7],
                    fathersName = tmp[8]
                };
                if (!set.Add(tmpStudent))
                {
                    //nothing at the moment
                }

            }
            Uczelnia raport = new Uczelnia
            {
                author = "Artur Ostapuk",
                createdAt = DateTime.Today.ToShortDateString(),
                studenci = set,
                activeStudies = studiesList
            };

            FileStream writer = new FileStream(DestPath, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(Uczelnia));          
            serializer.Serialize(writer, raport);            
        }
    }
}
