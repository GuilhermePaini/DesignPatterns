namespace Command
{
    internal class ReadWrite
    {
        private string _value { get; set; } = "";

        public void Read() => Console.Write(_value);

        public void Write() => _value += Console.ReadLine();
    }
}
