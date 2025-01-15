using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesignPatterns.src.DesignPatterns.Behavioural.Memento
{
    public interface IOriginator<ContentType>
    {
        void Restore(Memento<ContentType> memento);
        Memento<ContentType> SaveState();
    }
}