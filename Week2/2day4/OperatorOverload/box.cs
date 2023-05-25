using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace boxClass;

	public class box
	{
		public float weight;
		public float height;
		
		public float total;
		
		public box(float weight, float height)
		
		{
			this.weight = weight;
			this.height = height;
		}
	

		public static box operator +(box a, box b)
		
		{
			box box1 = new box(a.height + b.height, a.weight + b.weight);
			
			return box1;
		}
		
	}
