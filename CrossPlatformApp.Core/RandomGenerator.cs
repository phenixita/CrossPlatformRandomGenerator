using System;

namespace CrossPlatformApp.Core
{
    public class RandomGenerator : IIntegerGenerator
    {
        public int GenerateInt()
        {
            Random r = new Random(DateTime.Now.Second);

            return r.Next();
        }
    }
}