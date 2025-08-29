using System.Xml.Serialization;


namespace Day13Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
                Serializing and Deserializing Data
                *************************************
                The .NET Framework provides several classes that you can use to 
                serialize and deserialize data. 
                Explain that this lesson focus on classes that enable you to serialize 
                to binary, XML, and JSON. 
                If you want to serialize data to a custom format, 
                you can create your own formatter by implementing the IFormatter interface. 

                Serialization is the process of converting an object into a format that
                can be easily stored or transmitted, such as into a byte stream, XML, or JSON. 
                Deserialization is the reverse process: converting the serialized data back into 
                an object. In C#, serialization is commonly used for storing data, transmitting 
                data between different applications, or for remoting purposes.

                Common Serialization Techniques in C#
                    Binary Serialization   byte[]   XXX
                    XML Serialization      <>       Done 
                    JSON Serialization     {}       Done 


                Client 

            1. Binary Serialization
                Binary serialization converts an object into a binary format. 
                It is efficient in terms of speed and size but is not human-readable.
                Here's an example of binary serialization:
             */
            Console.WriteLine("Day 13 Demos ");
            Person ahmed = new Person { Name = "Ahmed Ali ", Age = 30 };
            //Serialize the object to a file
            using (FileStream fs = new FileStream("person.xml", FileMode.Create, FileAccess.ReadWrite))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(Person));
                serializer.Serialize(fs, ahmed);
            }

            ////Deserialize the object from the file
            //using (FileStream fs = new FileStream("person.xml", FileMode.Open, FileAccess.ReadWrite))
            //{
            //    XmlSerializer serializer = new XmlSerializer(typeof(Person));
            //    //Person p = new Person() { Name = "", Age = 25 };  //new Object 
            //    Person deserializedPerson = (Person)serializer.Deserialize(fs);
            //    Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            //}



            // Serialize the object to a JSON string
            //string jsonString = JsonSerializer.Serialize(person);
            //File.WriteAllText("person.json", jsonString);

            //Deserialize the object from the JSON string
            //string jsonStringFromFile = File.ReadAllText("person.json");
            //Person deserializedPerson = JsonSerializer.Deserialize<Person>(jsonStringFromFile);
            //Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");

            Console.ReadLine();
        }
    }

    //[Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}
