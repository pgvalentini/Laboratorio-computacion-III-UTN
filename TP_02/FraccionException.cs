using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_02
{
	public class FraccionException : Exception
	{
		public FraccionException () {
			
		Console.WriteLine("El numerador no puede ser cero");
		
		}
	} 
}
