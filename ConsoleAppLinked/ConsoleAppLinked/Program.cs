using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppLinked
{
    public class Person
    {
        int age;
        string fname;
        string lname;
        string city;
        public Person()
        {

        }
        public Person(int _age, string _fname, string _lname, string _city)
        {
            this.age = _age;
            this.fname = _fname;
            this.lname = _lname;
            this.city = _city;
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Fname
        {
            get { return fname; }
            set { fname = value; }
        }
        public string Lname
        {
            get { return lname; }
            set { lname = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public void DisplayPerson()
        {
            Console.WriteLine("age:{0} firstname:{1} lastname:{2} city:{3}", age, fname, lname, city);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> PersonList = new List<Person>();
            PersonList.Add(new Person(25, "Bhushan", "Pungliya", "Indore"));
            PersonList.Add(new Person(21, "Piyush", "Mandloi", "Indore"));
            PersonList.Add(new Person(25, "Vranda", "Daga", "Pune"));
            PersonList.Add(new Person(25, "Shahrukh", "Khan", "Mumbai"));
            PersonList.Add(new Person(25, "Salman ", "Khan", "Mumbai"));
            foreach (var p in PersonList)
            {
                Console.WriteLine("Person: {0},{1},{2},{3}", p.Age, p.Fname, p.Lname, p.City);
            }
            Console.Read();
        }
    }
}