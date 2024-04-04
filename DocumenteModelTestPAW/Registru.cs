using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumenteModelTestPAW
{
    public class Registru 
    {
        public List<Document> documents = new List<Document>();
        Random random = new Random();
        public void AdaugaDocument(string titlu)
        {
            Document inputDoc = new Document(random.Next(0, 10000), titlu, DateTime.Now);
            documents.Add(inputDoc);
        }

        public int NrDocumente()
        {
            return documents.Count;
        }

        public void RemoveDocumentWithId(int  id)
        {
            for (int i = 0; i < documents.Count; i++)
            {
                if (documents[i].cod == id)
                {
                    documents.RemoveAt(i);
                }
            }
        }

        public Document this[int index]
        {
            get
            {
                if (documents != null && index >= 0 && index < documents.Count)
                {
                    return documents[index];
                } else
                {
                    throw new IndexOutOfRangeException("Index is out of range.");
                }
            }
        }

        public Document this[string name]
        {
            get
            {
                for (int i = 0; i < documents.Count; i++)
                {
                    if (documents[i].titlu.Equals(name, StringComparison.OrdinalIgnoreCase))
                    {
                        return documents[i];
                    }
                }
                throw new IndexOutOfRangeException("Index is out of range");
            }
        }
    }
}
