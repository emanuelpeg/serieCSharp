using System;

namespace SecuenciaCSharep
{
	public class SecuenciaInPar : Secuencia
	{
	
		protected override void generate () {
			int semilla = new Random ().Next (99);
			for (int i = 0; i<4; i++) {
				this.values.Add ((semilla * i * 2) + 1);			
			}
			 

		}

		public SecuenciaInPar ()
		{
		}
	}
}

