using System;
using System.Collections.Generic;
using System.Text;

namespace Shared
{
    public class Choice
    {
        public int Order { get; set; }
        public string Description { get; set; }
        public override bool Equals(object? obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            if (this.GetType() != obj.GetType()) return false;
            var other = (Choice)obj;
            return this.Order == other.Order
                && this.Description == other.Description;      
        }
    }
}
