using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumentWorker
{
    internal class Key : IKey
    {
        public T CheckKey<T>(out string key)
            where T : DocumentWorker, new()
        {
            Console.WriteLine("Введите ключ");

            key = Console.ReadLine();

            if (key.Equals("pro"))
            {
                T proDocumentWorker = new ProDocumentWorker() as T;

                return proDocumentWorker;
            }
            else if (key.Equals("exp"))
            {
                T expertDocumentWorker = new ExpertDocumentWorker() as T;

                return expertDocumentWorker;
            }
            else
            {
                T unRecognized = new DocumentWorker() as T;

                return unRecognized;
            }
        }
    }
}
