using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Model
{
    public abstract class Key
    { 
        protected Key(int id)
        {
            Id = id;
        }

        public abstract string IndexName
        {
            get;
        }

        public virtual int Id
        {
            get;
            set;
        }
    }
}
