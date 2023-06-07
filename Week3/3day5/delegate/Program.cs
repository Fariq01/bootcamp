using delegateC;
static class Program
{
	public delegate void ButtonClick();
	public delegate void DeleMath(int a, int b);
	
	static void Main()
	
	{
		delegateClass dgc = new();

		ButtonClick bt1 = new ButtonClick(dgc.DisplayButton);
		bt1();
		
		DeleMath math1 = new DeleMath();
	}
}