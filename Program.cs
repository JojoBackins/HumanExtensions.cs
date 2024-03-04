using System;
using System.Security.Cryptography.X509Certificates;

namespace AmazingExtensions
{
    public static class ExtendAHuman
    {
        public static bool IsDistressCall(this string s)
        {
            if (s.Contains("Help!"))
                return true;
            else
                return false;
        }
    }
}
namespace Human
{
    using AmazingExtensions;

    class Program
    {
        static void Main(string[] args)
        {
            string message = "Evil clones are wreaking havoc. Help!";
            message.IsDistressCall();

        }
    }
}