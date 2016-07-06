using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum {
    interface OptionIterator<I> {
          IOption<I> GetNext();
    }

    public class TestArray : OptionIterator<int> {

        int[] testArray = {1,2,3,4,5,6,7,8,9,0};
        int current = -1;

        public IOption<int> GetNext() {
            current++;
            if( current < testArray.Length ) {
                return new Some<int>(testArray[current]);
            }else {
                return new None<int>();
            }
        }
    }
}
