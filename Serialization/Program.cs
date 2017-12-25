using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Serialization
{
    class Program
    {
        static void Main(string[] args)
        {
            User[] users = new User[]
            {


            new User
            {
                Id = 1,
                Person = new Person
                {
                    Id = 1,
                    FullName = "Lexa Lexavich"

                },
                Login = "Lexa228",
                Password = "123456",
                CreationDate = DateTime.Now,
                IsDeleted = false

            }
        };

            // BinaryFormatter serializer = new BinaryFormatter();
            XmlSerializer serializer= new XmlSerializer(typeof(User[]));
            using(FileStream stream=new FileStream(@"C:\my\data.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, users);
            }

           
            using (FileStream stream = new FileStream(@"C:\my\data.xml", FileMode.OpenOrCreate))
            {
                User[] newUsers=serializer.Deserialize(stream) as User[];
            }

           string json= JsonConvert.SerializeObject(users);
            User[] newUsers2 = JsonConvert.DeserializeObject<User[]>(json);
        }
    }
}
