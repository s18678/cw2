using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace cw2
{
    [Serializable]
    class Student
    {
        static int count;

        public Student(String[] data)
        {
            imie = data[0];
            nazwisko = data[1];
            stud = data[2];
            tryb = data[3];
            index = data[4];
            urodz = data[5];
            mail = data[6];
            ImMat = data[7];
            ImOj = data[8];
        }
        [XmlAttribute(attributeName:"indexnumber")]
        public String index { get; set; }
        [XmlAttribute(attributeName:"fname")]
        public String imie { get; set; }
        [XmlAttribute(attributeName:"lname")]
        public String nazwisko { get; set; }
        [XmlAttribute(attributeName:"birthdate")]
        public String urodz { get; set; }
        [XmlAttribute(attributeName:"email")]
        public String mail { get; set; }
        [XmlAttribute(attributeName:"mothersName")]
        public String ImMat { get; set; }
        [XmlAttribute(attributeName:"fathersName")]
        public String ImOj { get; set; }
        [XmlAttribute(attributeName:"name")]
        public String stud { get; set; }
        [XmlAttribute(attributeName:"mode")]
        public String tryb { get; set; }
      
    

        public static void incorrect(String data, String cause) {
            Program.log.WriteLine(cause +  data);
        }



        public static Student create(String line) {
            String[] data = line.Split(",", StringSplitOptions.RemoveEmptyEntries);
            if (data.Length < 9)
            {
                incorrect(line, "zla ilosc danych");
                return null;
            }
            else
            {
                return new Student(data);
            }
        }

        public string toString(){
            return imie + " " + nazwisko + " " + stud + " " + tryb + " " + index + " " + urodz + " " + mail + " " + ImMat + " " + ImOj; 
        }
    }
}
