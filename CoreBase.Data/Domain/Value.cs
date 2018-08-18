using System;

namespace CoreBase.Core.Domain
{
    public class Value
    {
        public Guid Id {
            get { return Id; }
            private set { value = new Guid(); }
        }

        public int ThisValue { get; set; }

        public DateTime CreatedAt {
            get { return CreatedAt; }
            private set { value = DateTime.Now; }
        }
    }
}
