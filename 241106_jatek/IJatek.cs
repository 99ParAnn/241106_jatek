using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241106_jatek
{
	internal interface IJatek
	{
		bool JatszhatVele(double eletkor);

		string Nev { get; }
	}
}
