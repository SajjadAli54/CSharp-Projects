using System;

namespace Chain{

 delegate void Custom(String str);
 delegate int Function(int num);

 class Program{

	public static void Hi(String str){
		Console.WriteLine("Hi : {0} " , str);
	}

	public static void Bye(String str){
		Console.WriteLine("Good bye {0}", str);
	}

	public static void Main(String[] args){
		int a = 12;
		Lambdas(ref a);		
	}

	public static void Lambdas(ref int a){
		Custom custom = (String str) => {
			for(int i=0;i<str.Length;i++)
				Console.WriteLine(str[i]);
		};
		//custom("Hello World");

		Custom c = str => Console.WriteLine(str);
		//c("I am the king of the world");

		Function square = number => number * number;
		Console.WriteLine(square(34));
	}

	public static void ChaingOfDelegates(){
		Custom hi, bye, chainOfHiAndBye, multiMinusHi;
		hi = Hi;
		bye = Bye;
		chainOfHiAndBye = hi + bye;
		multiMinusHi = chainOfHiAndBye - hi;

		hi("A\n");
		bye("B\n");
		chainOfHiAndBye("C\n");
		multiMinusHi("D");
	}

 }

}