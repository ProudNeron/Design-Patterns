using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.DesignPatterns.Behavioural.Memento
{
    public class Originator<ContentType> : IOriginator<ContentType>
    {
        public ContentType? Content { get; set; }

        public void Restore(Memento<ContentType> memento)
        {
            Content = memento.GetContent();
        }

        public Memento<ContentType> SaveState()
        {
            return new Memento<ContentType>(Content);
        }
    }
}