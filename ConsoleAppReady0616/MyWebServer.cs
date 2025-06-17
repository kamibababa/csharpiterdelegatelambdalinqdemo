using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppReady0616
{
    internal class MyWebServer
    {
        static void setAge(int age)
        {
            if(age < 120)
            {
                Console.WriteLine("setage ok");
            }
            else
            {
                throw new AgeArgumentErrorException("age is too old");
            }
        }
        static void openfile(string path)
        {
            FileStream fs = null;
            try
            {
                fs = File.Open(path, FileMode.Open);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                fs?.Close();
            }
        }
        static void Main(string[] args)
        {
            HttpListener httpListener = new HttpListener();
            httpListener.Prefixes.Add("http://localhost:5555/");
            httpListener.Start();
            Console.WriteLine("server start");
            Random random = new Random();
            while (true)
            {
                HttpListenerContext httpListenerContext = httpListener.GetContext();
                HttpListenerRequest httpListenerRequest = httpListenerContext.Request;

                Console.WriteLine($"{httpListenerRequest.Url}");
                HttpListenerResponse httpListenerResponse = httpListenerContext.Response;

                Stream outputStream = httpListenerResponse.OutputStream;

                try
                {
                    //int x = 0;
                    //int y = 9 / x;
                    //openfile("xxx.txt");
                    setAge(222);
                }
                catch (AgeArgumentErrorException ex)
                {
                    Console.WriteLine(ex.Message+ex.GetType());
                }
                //openfile("xxx.txt");


                string msg = "<h1>" + random.NextDouble() + "</h1>";
                byte[] bytes = UTF8Encoding.UTF8.GetBytes(msg);

                outputStream.Write(bytes, 0, bytes.Length);

                outputStream.Close();
            }
        }
    }
}
