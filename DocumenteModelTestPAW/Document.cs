using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocumenteModelTestPAW
{
    public class Document : IComparable
    {
        public readonly int cod;
        public string titlu { get; set; }
        public DateTime data { get; set; }

        public Document(int cod, string titlu, DateTime data)
        {
            this.cod = cod;
            this.titlu = titlu;
            this.data = data;
        }

        public override string ToString()
        {
            return $"Document cu codul: {cod}, titlul: {titlu}, din data de {data}.";
        }

        public int CompareTo(object obj)
        {
            Document other = obj as Document;
            return other.titlu.CompareTo(titlu);
        }
    }
}
