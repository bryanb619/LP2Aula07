using System.IO;

namespace Observers
{
    public class FileSaver : IObserver<AbstractStringSubject>
    {


        private readonly string _fileName;

        public FileSaver(string fileName)
        {
            _fileName = fileName;
        }

        public void Update(AbstractStringSubject sub)
        {
            File.AppendAllText(_fileName, sub.Item + "\n");
        }
    }
}