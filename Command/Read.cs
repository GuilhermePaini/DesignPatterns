namespace Command
{
    internal class Read : ICommand
    {
        private ReadWrite _readWrite;

        public Read(ReadWrite readWrite) 
        {
            _readWrite = readWrite;
        }

        public void Execute()
        {
            _readWrite.Read();
        }
    }
}
