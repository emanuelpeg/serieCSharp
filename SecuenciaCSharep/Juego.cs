using System;

namespace SecuenciaCSharep
{
	public class Juego
	{
		private Secuencia secuencia;

		private int puntaje = 0;

		public void generar() {
			int i = new Random ().Next (2);

			switch (i) {
			case 0:
				secuencia = new SecuenciaPar ();
				break;
			default: 
				secuencia = new SecuenciaInPar ();
				break;
			}
		}

		public Juego ()
		{
			this.puntaje = 0;
			generar ();
		}

		public int getValue0() {
			return secuencia.getValues()[0];
		}

		public int getValue1() {
			return secuencia.getValues()[1];
		}

		private int getValue2() {
			return secuencia.getValues()[2];
		}

		public int getValue3() {
			return secuencia.getValues()[3];
		}

		public int getPuntaje() {
			return this.puntaje;
		}

		public bool isOK(int n) {
		
			if (this.getValue2 () == n) {
			
				this.puntaje++;
				this.generar ();
				return true;
			}
			this.puntaje --;
			this.generar ();
			return false;
		}

	}
}


