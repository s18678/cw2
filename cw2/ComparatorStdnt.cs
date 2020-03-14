using System;
using System.Collections.Generic;
using System.Text;

namespace cw2
{
    class ComparatorStdnt : IEqualityComparer<Student>
    {
        public bool IEqualityComparer<Student>.Equals(Student x, Student y)
        {
            return StringComparer.InvariantCultureIgnoreCase.Equals($"{x.imie} {x.nazwisko} {x.index}", $"{y.imie} {y.nazwisko} {y.index}");
        }

        public int IEqualityComparer<Student>.GetHashCode(Student obj)
        {
            return StringComparer.InvariantCultureIgnoreCase.GetHashCode($"{obj.imie} {obj.nazwisko} {obj.index}");
        }
    }

}
