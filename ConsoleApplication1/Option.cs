using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum {
    public interface IOption<T> {
        U Visit<U>( Func<U> onNone, Func<T, U> onSome );
    }
    class Some<T> : IOption<T> {
        public T value;
        public Some( T value ) { this.value = value; }

        public U Visit<U>( Func<U> onNone, Func<T, U> onSome ) {
            return onSome(value);
        }
    }
    class None<T> : IOption<T> {
        public U Visit<U>( Func<U> onNone, Func<T, U> onSome ) {
            return onNone();
        }
    }
}
