using System;
using System.Collections.Generic;

namespace SecuenciaCSharep
{
	public abstract class Secuencia
	{
		protected IList<int> values = new List<int>();

		protected abstract void generate();

		public Secuencia ()
		{
			this.generate();
		}

		public IList<int> getValues(){
			return values;
		}
	
	}
}

