using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum {
    class Program {
        static void Main( string[] args ) {

            //Factory
            System.Console.WriteLine("FACTORY");
            var factory = new F();
            System.Console.WriteLine(factory.createObject(F.options.ObjectA).describe());
            System.Console.WriteLine(factory.createObject(F.options.ObjectB).describe());
            System.Console.WriteLine(factory.createObject(F.options.ObjectC).describe());
            System.Console.ReadKey();

            System.Console.WriteLine("OPTION");
            IOption<int> option = new Some<int>(5);
            string optionRet = option.Visit<string>(() => { return "onNone"; }, ( int i ) => { return "onSome: " + i; }  );
            Console.WriteLine(optionRet);
            IOption<int> optionNone = new None<int>();
            string optionNoneRet = optionNone.Visit<string>(() => { return "onNone"; }, ( int i ) => { return "onSome: " + i; });
            Console.WriteLine(optionNoneRet);
            System.Console.ReadKey();

            System.Console.WriteLine("OPTIONITERATOR");
            OptionIterator<int> testIterator = new TestArray();
            for( int i = 0 ; i < 12 ; i++ ) {
                IOption<int> tstIter = testIterator.GetNext();
                string tstIterRet = tstIter.Visit<string>(() => { return "onNone"; }, ( int j ) => { return "onSome: " + j; });
                System.Console.WriteLine(tstIterRet);
            }
            System.Console.ReadKey();

            System.Console.WriteLine("TRADITIONALITERATOR");
            TraditionalIterator<int> testIteratorTrad = new TestArrayTrad();
            while( testIteratorTrad.hasNext() ) {
                int tstTradIter = testIteratorTrad.next();
                System.Console.WriteLine("got: " + tstTradIter);
            }
            System.Console.ReadKey();


        }
    }
}
