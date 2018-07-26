using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CeKettoskeresztTeszt
{
    class ListExtension
    {

        public static T findSecond<T>(List<T> inputList, Func<T, bool> predicate)
        {
            int i = 0;
            foreach (var item in inputList)
            {
                if (predicate(item))
                {
                    i++;
                    if (i==2)
                    {
                        return item;
                    }
                }
            }
            throw new Exception();

        }

    }
}
