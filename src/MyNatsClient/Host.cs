namespace MyNatsClient
{
    public class Host
    {
        public string Address { get; }
        public int Port { get; }

        private readonly string _toString;

        public Host(string address, int port = 4222)
        {
            Address = address;
            Port = port;
            _toString = $"{address}:{port}";
        }

        public override string ToString()
        {
            return _toString;
        }
    }
}