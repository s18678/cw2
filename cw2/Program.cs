using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;


namespace cw2
{
    class Program
    {
        public static String logn = @"log.txt";
        public static StreamWriter log;
        static void Main(string[] args)
        {
            var path = @"dane.csv";
            var outpath = @"result.xml";
            if(args.length == 2){
                path = args[0];
                outpath = args[1];
            }
            if (!File.Exists(outpath))
                File.Create(outpath);


            HashSet<Student> std = new HashSet<Student>();
            var parsedDate = DateTime.Parse("2020-03-10");
            var today = DateTime.Today;
            
            if (!File.Exists(logn))
                File.Create(logn);
            log = new StreamWriter(logn);

            
            var lines = File.ReadLines(path);
            Student temp;
            foreach (string s in lines) {
                temp = Student.create(s);
                if (temp != null)
                    if (!std.Add(temp)) {
                        Student.incorrect(s, "duplikat");
                    }
            }
            foreach(Student s in std){
                Console.WriteLine(s.toString);
            }

            FileStream writer = new FileStream(outpath, FileMode.Create);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Student>),
                                       new XmlRootAttribute("uczelnia"));
            serializer.Serialize(writer, list);
            serializer.Serialize(writer, list);
            
            
             
        }
    }
}
