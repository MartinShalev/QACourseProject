using AutoFixture;
using System;

namespace ProjectInProgres.UsersTools
{
    public static class FactoryExtensions
    {
        public static string CreateRandomString(this IFixture fixture, int length)
        {
            var rnd = new Random();
            var randomChars = new char[length];

            for (var i = 0; i < length; i++)
            {
                randomChars[i] = (char)rnd.Next('a', 'z');
            }
            return new string(randomChars);
        }
    }
}
