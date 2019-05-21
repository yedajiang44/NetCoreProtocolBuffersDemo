using System;

namespace ProtocolBuffersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var yedajing44 = new Person
            {
                Id = 1234,
                Name = "yedajiang44",
                Email = "yedajiang44@163.com",
                Phones = {
                    new Person.Types.PhoneNumber { Number = "123456789", Type = Person.Types.PhoneType.Home },
                    new Person.Types.PhoneNumber { Number = "987654321", Type = Person.Types.PhoneType.Work }
                }
            };
            var json = yedajing44.ToString();
            Console.WriteLine($"序列化：{json}");
            yedajing44 = Person.Parser.ParseJson(json);
            Console.WriteLine($"反序列化{yedajing44}");
            Console.ReadKey();
        }
    }
}