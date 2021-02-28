using System;

namespace LevelEvaluation.Data
{
    /// <summary>
    /// This class represents a person's entity. It contains their name, age,
    /// country and the languages they speak. The toString() method prints
    /// how they would introduce themselves.
    /// </summary>
    public class Person
    {
        private string _name;
        private int _age;
        private string _country;
        private string[] _languages;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }

        public Person() { }
        public Person(string name)
        {
            _name = name;
            _age = 25;
            _country = "Canada";
            _languages = new string[] { "English", "French" };
        }
        public Person(string name, int age, string country, string[] languages)
        {
            _name = name;
            _age = age;
            _country = country;
            _languages = languages;
        }

        // TODO: Implement a getter for the person's name
        /// <summary>
        /// This getter returns the person's name
        /// </summary>

        // TODO: Implement a getter for the person's age
        /// <summary>
        /// This getter returns the person's age
        /// </summary>

        // TODO: Implement a getter for the person's country
        /// <summary>
        /// This getter returns the person's country
        /// </summary>


        // TODO: Implement a constructor with a name as parameter
        /// <summary>
        /// This constructor takes a name and initializes
        /// the other fields with the following data:
        /// age: 25
        /// country: "Canada"
        /// languages: [ "English", "French" ]
        /// </summary>

        // TODO: Implement a constructor with parameters for each field
        /// <summary>
        /// This constructor takes data for all fields.
        /// </summary>


        /// <summary>
        /// This method returns a string with all the languages spoken.
        /// Ex.: languages = { "French", "Spanish", "Italian", "Japanese" }
        /// Output: French, Spanish, Italian, Japanese
        /// </summary>
        private string ListLanguages()
        {
            // TODO: Implement the following method to match the description above
            //throw new NotImplementedException(); // comment this line when the implementation is done
            string anotherStr = string.Empty;
            foreach (var i in _languages)
                anotherStr += i + " ";
            Console.WriteLine();
            return anotherStr;
        }


        public override string ToString()
            => $"Hey there!{Environment.NewLine}" +
               $"My name is {this._name}.{Environment.NewLine}" +
               $"I am from the {this._country} and I am {this._age} years old.{Environment.NewLine}" + 
               $"I speak the following languages: {ListLanguages()}";
    }
}
