using System;

namespace Server
{
    internal class adventureworkEntities : IDisposable
    {
        public string Connect { get; set; }
        public bool IsConect { get; set; }
        public adventureworkEntities(string connect)
        {
            Connect = connect;
        }

        public void Dispose()
        {
        }
    }
}