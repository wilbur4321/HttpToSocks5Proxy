using System;
using MihaZupan;

namespace MihaZupan.ProxyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var Socks5ServerAddress = "localhost";
            var Socks5ServerPort = 3448;
            var proxy = new HttpToSocks5Proxy(Socks5ServerAddress, Socks5ServerPort);

            // Or if you need credentials for your proxy server:
            //var proxy = new HttpToSocks5Proxy(Socks5ServerAddress, Socks5ServerPort, "username", "password");

            // Allows you to use proxies that are only allowing connections to Telegram
            // Needed for some proxies
            proxy.ResolveHostnamesLocally = false;

            Console.WriteLine("Proxy address: " + proxy.GetProxy(new Uri("http://www.google.com")));

            Console.WriteLine("Press enter to exit...");
            Console.ReadLine();
            Console.WriteLine("Goodbyte!");
        }
    }
}
