using csharp20250604;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    delegate bool judge(int tmp);
    delegate int operate(int a, int b);
    delegate string Str_operate(string a, string b);

    delegate T t_operate<T>(T t1, T t2);

   

    internal class DelegeteDemo
    {

        static T execute<T>(T t1, T t2, t_operate<T> op)
        {
            return op(t1, t2);
        }
        static string Concat(string s1, string s2)
        {
            return s1 + s2;
        }

        static void print(string msg)
        {
            Console.WriteLine(msg);
        }
        static int AddOne(int a)
        {
            return ++a;
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Multiply(int a, int b)
        {
            return a * b;
        }
        static bool isEven(int value)
        {
            return value % 2 == 0 ;
        }

        static bool isPositive(int value)
        {
            return value > 0;
        }

        static void output(judge func, int[] arr)
        {
            foreach(int tmp in arr)
            {
                if (func(tmp))
                {
                    Console.WriteLine(tmp);
                }
            }
        }

        static void Main(string[] args)
        {
            MyList<Person> myList = new MyList<Person>(10);
            myList.Add(new Person(12, "zhangsan"));
            myList.Add(new Person(7, "lsisi"));
            myList.Add(new Person(35, "wangwu"));

            List<Person> people = myList.Where(x => x.Age > 10).ToList() ;
            foreach (var item in people)
            {
                Console.WriteLine(item);
            } 
            
            //int defaultValue = default;
            //Console.WriteLine(defaultValue);
            //Console.WriteLine("-".Multiply(50));
            //string sentence = "this is a book that is a desk he is a boy";
            //string[] arr = sentence.Split(" ");

            //var dic = arr.GroupBy(x => x).ToDictionary(g => g.Key, g => g.Count()).OrderByDescending(e=>e.Value);
            //foreach (var item in dic)
            //{
            //    Console.WriteLine($"{item.Key}---{item.Value}");
            //}            //Random random = new Random();
            //List<Person> lst = Enumerable.Range(1, 10).Select(x => new Person { Age = random.Next(10), Name = "wangwu" + x, Class=x%3 }).ToList();
            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("------------");

            //var dic = lst.ToDictionary(x => x.Age);
            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item.Key);
            //    Console.WriteLine(item.Value);
            //}


            //IEnumerable<IGrouping<int, Person>> enumerable = lst.GroupBy(x => x.Class);
            //foreach (var group in enumerable)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (Person person in group)
            //    {
            //        Console.WriteLine(person);
            //    }
            //}

            //var dic = enumerable.ToDictionary(e => e.Key, e => e.Count());
            //foreach (var item in dic)
            //{
            //    Console.WriteLine(item.Key+"---"+ item.Value);
            //}
            //var newLst = lst.Where(x => x.Age > 5);
            //foreach (var item in newLst)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("------------");

            //var newLst2 = lst.Where(x => x.Age > 5).Select(x=>new { x.Name, x.Class});
            //foreach (var item in newLst2)
            //{
            //    Console.WriteLine(item.Name);
            //    Console.WriteLine(item.Class);
            //}


            //int[] arr = { 1, -1, 5, 6, 8, -12 };
            //output(isEven, arr);
            ////output(isEven, arr);

            //operate op = Multiply;
            //Console.WriteLine(op(3,5));

            //Str_operate op2 = Concat;
            //Console.WriteLine(op2("hello","world"));

            //t_operate<int> oopp = Multiply;
            //Console.WriteLine(execute(22, 3, oopp));

            //t_operate<string> ooppp = Concat;
            //Console.WriteLine(execute("xx","oo", ooppp));

            //Func<int, int, int> func = (x,y)=>x+y;
            //Console.WriteLine(func(12,12));


            //Func<string, string, string> func3 = (string s1, string s2)=>s1+s2;
            //Console.WriteLine(func3("saf", "322"));

            //var func2 = (int x) => x + 1;
            ////Func<int, int> func2 = x => x+1;
            //Console.WriteLine(func2(12));

            //Action<string> output = msg => Console.WriteLine(msg);
            //output("ok");

            //Func<int, bool> pred = x => x > 0;
            ////Predicate<int> pred = isPositive;
            //Console.WriteLine(pred(-21));

            //Func<int> GetRandom = () =>
            //{
            //    Random random = new Random();
            //    return random.Next(10);
            //};

            //Console.WriteLine(GetRandom());

            //Action funcxx = () =>
            //{
            //    Random random = new Random();
            //    Console.WriteLine(random.NextDouble());
            //};

            //funcxx();

            //var funcxy = (Person p) => new { p.Name};
            //Person p = new Person { Name = "zhangsan", Age = 12 };
            //Console.WriteLine(funcxy(p).Name);

            //int[] arr = { 1, -1, 5, 6, 8, -12 };
            //List<int> arr = [5,99];
            //int value = arr.FirstOrDefault();
            //Console.WriteLine(value);
            //List<int> lst = arr.Where(x => x % 2 == 0).ToList();
            //List<int> lst = new List<int>();
            //foreach(int tmp in arr)
            //{
            //    if(tmp % 2 == 0)
            //    {
            //        lst.Add(tmp);
            //    }
            //}

            //foreach (var item in lst)
            //{
            //    Console.WriteLine(item) ;

            //}
        }
    }
}
