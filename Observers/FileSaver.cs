using System;
using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>, IDisposable
    {
        private readonly TextWriter _file;

        public FileSaver(string fileName)
        {
            _file = new StreamWriter(fileName);
        }

  

        public void Update(AbstractStringSubject sub)
        {
            _file.WriteLine(sub.Item);
        }


        public void Dispose()
        {
            _file?.Dispose();
        }


    }
}