using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    public struct StructWithValue : IEquatable<StructWithValue>
    {
        private ushort value;
        public StructWithValue(ushort v)
        {
            value = v;
        }
        public override int GetHashCode()
        {
            return value.GetHashCode();
        }
        public override bool Equals(object obj)
        {
            return obj != null && !(base.GetType() != obj.GetType()) && this.Equals((StructWithValue)obj);
        }

        public bool Equals(StructWithValue other)
        {
            return value.Equals(other.value);
        }

        public static bool operator ==(StructWithValue a1, StructWithValue a2)
        {
            return a1.Equals(a2);
        }

        public static bool operator !=(StructWithValue a1, StructWithValue a2)
        {
            return !(a1 == a2);
        }
    }
}
