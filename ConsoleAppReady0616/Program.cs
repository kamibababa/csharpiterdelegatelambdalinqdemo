//using csharp20250604;
//using System;

//namespace ConsoleAppReady0616
//{
//    internal class Program
//    {
//        //1 1 2 3 5 8...

//        static IEnumerable<long> Fib()
//        {
//            int a = 0;
//            int b = 1;

//            while(true)
//            {
//                yield return a;
//                int tmp = a;
//                a = b;
//                b = tmp + a;
//            }
//        }

//        static void Main(string[] args)
//        {

//            //foreach (int tmp in Fib())
//            //{
//            //    Console.WriteLine(tmp);
//            //    if (tmp > 30)
//            //    {
//            //        break;
//            //    }
//            //}

//            //int count = 10;
//            //int a = 0;
//            //int b = 1;

//            //for(int i = 0; i < count; i++)
//            //{
//            //    Console.WriteLine(a);
//            //    int tmp = a;
//            //    a = b;
//            //    b = tmp + a;
//            //}


//            //MyList<Person> myList = new MyList<Person>(10);
//            //myList.Add(new Person(12, "zhangsan"));
//            //myList.Add(new Person(7, "lsisi"));
//            //myList.Add(new Person(35, "wangwu"));

//            //foreach (Person person in myList)
//            //{
//            //    Console.WriteLine(person);
//            //}

//            //IEnumerator<Person> enumerator = myList.GetEnumerator();
//            //while (enumerator.MoveNext())
//            //{
//            //    Person person = enumerator.Current;
//            //    Console.WriteLine(person);
//            //}

//        }
//    }
//}
