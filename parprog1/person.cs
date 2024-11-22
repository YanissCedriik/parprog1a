

namespace parprog1
{


    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string HairColor { get; set; }
        public string Hobbies { get; set; }

        public Person(string name, int age, string hairColor, string hobbies)
        {
            Name = name;
            Age = age;
            HairColor = hairColor;
            Hobbies = hobbies;
        }

    }

}