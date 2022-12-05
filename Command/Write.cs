using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
    internal class Write : ICommand
    {
        private ReadWrite _readWrite;

        public Write(ReadWrite readWrite)
        {
            _readWrite = readWrite;
        }

        public void Execute()
        {
            _readWrite.Write();
        }
    }
}
