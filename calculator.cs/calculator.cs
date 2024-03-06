class calculator
{
	static void main(string[] args)
	{
	int a = 10;
	int b = 6;
	
	Console.WriteLine("hasil penambahan " + a + " + " + b + "=" + penambahan(a, b));
    Console.WriteLine("hasil pengurangan  {0} - {1} = {2}", a, b, pengurangan(a, b));
	
	Console.WriteLine("\n tekan sembarang key untuk keluar");
    Console.ReadKey();
	
	}
	
	static int penambahan(int a, int b)
	{
		return a + b;
	}	
	
	static int pengurangan (int a, int b)
	
}	