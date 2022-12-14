public class Program{

	double secs;

	public int Number{ set; get; }

	public double Hour{
	
		set 
		{
			secs = value * 3600;
		}

		protected get 
		{
			return secs / 3600;
		}
	}

	public double Minutes{ get {return secs * 60; }}

}

public class C : Program{

	public C(){
		
	}

	static void Main(){

	}
}