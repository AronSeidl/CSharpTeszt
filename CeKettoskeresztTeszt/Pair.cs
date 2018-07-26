using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeKettoskeresztTeszt
{

    public delegate void ItemQueryHandler(int item);

    class Pair<T>
    {
        public event ItemQueryHandler HasQueried;

        private T _item1;
        private T _item2;

        public T Item1
        {
            get
            {
                RaiseHasQueried(1);
                return _item1;
            }
            private set { _item1 = value; }
        }

        public T Item2
        {
            get
            {
                RaiseHasQueried(2);
                return _item2;
            }
            private set { _item1 = value; }
        }


        //public T Item1 { get; private set; }
        //public T Item2 { get; private set; }

        public Pair(T item1, T item2)
        {
            Item1 = item1;
            Item2 = item2;
        }
        protected void RaiseHasQueried(int num)
        {
            if (HasQueried != null)
            {

                HasQueried(num);
            }

        }
    }
}
