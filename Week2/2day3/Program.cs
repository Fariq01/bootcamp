using delegateSpace;
	
	class Program {

		static void Main()
		{
			
			// delegateClass
			delegateClass delClass1 = new delegateClass();
			
			delMethod del1 = delClass1.run;
			
			del1(); 
			
			
			//delegateGeneric
			
			delegateGenericClass<int, string> delGenClass1 = new delegateGenericClass<int, string>();
			
			delGenMethod<int, string> delGen1  =  delGenClass1.run;
			delGen1(1, "hello");
			
			
			
		
		}
	}
	

