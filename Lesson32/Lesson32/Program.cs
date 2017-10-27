using System;

namespace Lesson32
{

	/* Generic type
	 * 1. Need to add generic type after class name
	 * 2. When define, need to use generic type T to represent any type of data 
	 * 3. When using generic type, for the type is not concertly, we can't 
	 * using arithmetic operator
	*/


	// Error
//	public class Math<T> {
//
//		public T Max(T num1, T num2) {
//			return num1 > num2 ? num1 : num2;
//		}
//
//	}



	/* T - type
	 * S/U/V - 2nd, 3rd, 4th type
	 * K/V - key/value
	 * N - number
	*/

	// Array class 
	public class Array <T/*, S, U, V*/> {
		private T[] _arr;
		private int _count = 0;


		/* Indexer 
		 * 
		*/
		public T this [int index] {
			set { 
				_arr [index] = value;
			}
			get { 
				return _arr [index];
			}
		}

		// Attribute
		public int Count {
			get { 
				return _count;
			}
		}


		public void Add (T value) {
			_arr [_count] = value;
			_count++;
		}

		public void Log() {
			string str = "Current array include " + Count + " elements: (";
			for (int i = 0; i < Count; i++) {
				str += _arr [i];
				if (i < Count - 1) {
					str += ", ";
				}
			}
			str += ")";
			Console.WriteLine (str);
		}

		public Array() {
			_arr = new T[100];
		}
	}


	class MainClass
	{
		public static void Main (string[] args)
		{
			// Only when int instantiating use, need to specify the data type
			Array<float> arr = new Array<float> ();
			arr.Log ();
			arr.Add (23.5f);

			arr.Log ();
			arr.Add (74.1f);

			arr.Log ();
			arr [1] = 12.3f;
			arr.Log();

		}
	}
}
