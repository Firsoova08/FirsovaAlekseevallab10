using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace FirsovaAlekseevalab10
{
    internal class Program
    {
        delegate int MathOperation(int a, int b);
        static void Main(string[] args)
        {
            //var monster = new
            //{
            //    Name = "Дракон",
            //    Damage = 50,
            //    IsBoss = true,
            //    Description = "Древний огнедышащий змей"
            //};
            //Console.WriteLine(monster.Description);

            //var products = new[]
            //{
            //    new {Name="Молоко", Price=59.99, Category="Продукты"},
            //    new {Name="Ноутбук", Price= 49990.00, Category = "Электроника"},
            //    new {Name="Щётка для зубов", Price=120.50, Category = "Гигиена"}
            //};
            //Console.WriteLine("Список товаров:");
            //foreach (var product in products)
            //{
            //    Console.WriteLine($"{product.Name} ({product.Category}) {product.Price}P");
            //}

            //Student student = new Student();
            //student.Name = "Денис";
            //student.University = "BO ВолГУ";
            //student.SayHello();
            //Console.WriteLine($"Учится в: {student.University}");

            //Student student1 = new Student();
            //student1.Name = "Денис";
            //student1.University = "ВФ ВолГУ";
            //student1.SayHello();
            //Person student2 = new Person();
            //student2.Name = "Денис";
            //student2.SayHello();

            //Dog dog = new Dog { Name = "Бобик" };
            //Cat cat = new Cat { Name = "Мурка" };
            //dog.Info();
            //dog.MakeSound();
            //cat.Info();
            //cat.MakeSound();

            //// 1. Через метод
            //int Square(int x)
            //{
            //    return x * x;
            //}
            //Console.WriteLine(Square(5));
            //// 2. То же самое через лямбду
            //Func<int, int> square = x => x * x;
            //Console.WriteLine(square(5));
            //Button button = new Button();
            //button.OnClick += () => Console.WriteLine("Кнопка нажата!");
            //button.Click();
            //List<ISound> sounds = new List<ISound> {
            // new Bird(),
            // new Phone()};
            //foreach (var sound in sounds)
            //{
            //    sound.MakeSound();
            //}
            //Book book = new Book { Name = "Война и мир" };
            //Console.WriteLine(book.Name);
            //Duck duck = new Duck();
            //((IFlier)duck).Fly();
            //((ISwimmer)duck).Swim();
            //Animal[] animals = {
            //new Dog { Name = "Бобик" },
            //new Cat { Name = "Мурка" }
            // };
            //foreach (var animal in animals)
            //{
            //    animal.Info();
            //    animal.MakeSound();

            //}
            //foreach (int number in GenerateNumbers())
            //{
            //    Console.WriteLine($"Получено число: {number}");
            //}
            //List<int> numbers = new List<int> { 5, 2, 9, 4, 7, 3, 8, 23, 45, 12, 34, 13, 98, 67, 56, 99 };
            //List<int> evenNumbers = new List<int>();
            //foreach (var num in numbers)
            //{
            //    if (num % 2 == 0)
            //        evenNumbers.Add(num);
            //}
            //List<int> multiplied = new List<int>();
            //foreach (var num in evenNumbers)
            //{
            //    multiplied.Add(num * 10);
            //}
            //multiplied.Sort((a, b) => b.CompareTo(a));
            //Console.WriteLine("Результат (без LINQ):");
            //foreach (var num in multiplied)
            //{
            //    Console.WriteLine(num);
            //}
            //  var result = numbers
            //.Where(n => n % 2 == 0) 
            //.Select(n => n * 10) 
            //.OrderByDescending(n => n); 

            //  Console.WriteLine("Результат (с LINQ):");
            //  foreach (var num in result)
            //  {
            //      Console.WriteLine(num);
            //  }
            //List<string> names = new List<string> { "Анна", "Иван", "Мария", "Пётр" };
            // Без LINQ
            //List<string> longNames = new List<string>();
            //foreach (var name in names)
            //{
            //    if (name.Length > 4)
            //        longNames.Add(name);
            //}
            //foreach (var name in longNames)
            //{
            //    Console.WriteLine(name);
            //}
            // C LINQ
            //var linqLongNames = names.Where(name=> name.Length > 4);
            //foreach (var name in linqLongNames)
            //{
            //    Console.WriteLine(name);

            //}
            //List<int> nums = new List<int> { 10, 5, 20, 3 };
            // Без LINQ
            //int min = nums[0];
            //foreach (var num in nums)
            //{
            //    if (num < min)
            //        min = num;
            //}
            //Console.WriteLine($"\nМинимальное число (без LINQ): {min}");
            //List<int> nums =new List<int> { 10, 5, 20, 3 };
            //// C LINQ
            //int linqMin = nums.Min();
            //Console.WriteLine($"Минимальное число (с LINQ): {linqMin}");
            //List<int> numbers = new List<int> { 1, 2, 3, 4 };
            // Без LINQ
            //List<int> squares = new List<int>(); 
            //foreach (var num in numbers)
            //{
            //    squares.Add(num * num);
            //}
            //Console.WriteLine("\nКвадраты чисел (без LINQ): ");
            //Console.WriteLine(string.Join(", ", squares));
            // C LINQ
            //var linqSquares = numbers.Select(n => n * n);
            //Console.WriteLine("Квадраты чисел (c LINQ):");
            //Console.WriteLine(string.Join(", ", linqSquares));
            //List<Student> students = new()
            //{
            //    new Student { Name = "Андрей", Score = 90 },
            //    new Student { Name = "Вика", Score = 78 },
            //   new Student {Name= "Денис", Score = 84 },
            //   new Student{Name ="Лена",Score = 95 },
            // new Student {  Name ="Олег",Score = 65}
            //};
            //List < Student > goodStudents = new List<Student>();
            //int total = 0;
            //foreach (var s in students)
            //{
            //    total += s.Score;
            //    if (s.Score > 80)
            //        goodStudents.Add(s);
            //}
            //goodStudents.Sort((a, b) => a.Name.CompareTo(b.Name));
            //Console.WriteLine("Студенты с баллом выше 80:");
            //foreach (var s in goodStudents)
            //{
            //    Console.WriteLine($"{s.Name} {s.Score}");
            //}
            //Console.WriteLine($"Средний балл: {(double)total / students.Count: F1}");
            //List<Student> students = new()
            //{
            //new Student { Name = "Андрей", Score = 90 },
            //new Student { Name = "Вика", Score = 78 },
            //new Student { Name = "Денис", Score = 84},
            //new Student { Name = "Лена", Score = 95 },
            //new Student { Name = "Олег", Score = 65 }
            //};

            //var goodStudents = students
            //.Where(s => s.Score > 80)
            //.OrderBy(s => s.Name);
            //var averageScore = students.Average(s => s.Score);
            //Console.WriteLine("Студенты с баллом > 80:");
            //foreach (var s in goodStudents)
            //    Console.WriteLine($"{s.Name} {s.Score}");
            //Console.WriteLine($"Средний балл: {averageScore:F1}");
            //Func<int, int, int> sum = (a, b) => a + b;
            //Console.WriteLine(sum(3, 7));
            //Func<int, string> numberToWord= num=>
            //{
            //    switch (num)
            //    {
            //        case 1: return "один";
            //        case 2: return "два";
            //        default: return "много";
            //    }
            //};
            //Console.WriteLine(numberToWord(2)); 
            //MathOperation add = (a, b) => a + b;
            //Console.WriteLine(add(2, 3)); 
            //foreach (var step in WaitCoroutine())
            //{
            //    Console.WriteLine(step);
            //    Thread.Sleep(1000); //имитируем ожидание
            //    Console.WriteLine("Готово!");
            //Arena arena = new();
            //arena.AddUnit(new Warrior("Рагнар"));
            //arena.AddUnit(new Mage("Гендальф"));
            //arena.AddUnit(new Archer("Леголас"));
            //arena.StartBattle();
        }



            //}
            //static IEnumerable<string> WaitCoroutine()
            //{
            //    yield return "Ждём... 1 секунда";
            //    yield return "Ждём... 2 секунды";
            //}

            //public static async Task<string> MakeSoupAsync()
            //{
            //    Console.WriteLine("Начали варить суп...");
            //    await Task.Delay(3000);
            //    return "Суп";
            //    Console.WriteLine("Начинаем готовить ужин...");
            //    // Вызываем асинхронный метод и ждём его завершения
            //    await CookDinnerAsync();
            //    Console.WriteLine("Ужин готов!");
            //}

            //public static async Task<string> MakeSaladAsync()
            //{
            //    Console.WriteLine("Начали резать салат...");
            //    await Task.Delay(1000);
            //    return "Салат";
            //}

            //public static async Task CookDinnerAsync()
            //{
            //    // Запускаем задачи параллельно
            //    Task<string> soupTask = MakeSoupAsync();
            //    Task<string> saladTask = MakeSaladAsync(); 
            //    // Ожидаем завершения всех задач
            //    string soup = await soupTask;
            //    string salad = await saladTask;
            //    Console.WriteLine($"Готово: {soup} и {salad}");
            //}
            //class Student
            //{
            //    public string Name;
            //    public int Score;
            //}
            //static async Task Main()
            //{
            //    Console.WriteLine("1. Включили чайник...");
            //    Task boilTask = BoilWaterAsync();
            //    Task sliceTask = SliceLemonAsync();
            //    Console.WriteLine("4. Завариваем чай с лимоном!");

            //}
            //static async Task BoilWaterAsync()
            //{
            //    Console.WriteLine("2. Кипятим воду (ждём 3 секунды)...");
            //    await Task.Delay(3000); // Асинхронная пауза
            //    Console.WriteLine("... вода закипела!");
            //}
            //static async Task SliceLemonAsync()
            //{
            //    Console.WriteLine("3. Режем лимон (ждём 2 секунды)...");
            //    await Task.Delay(2000);
            //    Console.WriteLine("...лимон порезан!");
            //}
            //public class Button
            //{
            //   public event Action OnClick;

            //   public void Click()
            //   {
            //    OnClick?.Invoke();
            //   }
            //}
            //static IEnumerable<int> GenerateNumbers()
            //{
            //    Console.WriteLine("Начинаем генерацию..."); yield return 1;
            //    Console.WriteLine("Пауза..."); yield return 2;
            //    Console.WriteLine("И ещё раз..."); yield return 3;
            //    Console.WriteLine("Готово!");
            //}


    }
    
    
}
  