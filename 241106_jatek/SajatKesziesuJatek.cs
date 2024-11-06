using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241106_jatek
{
	internal class SajatKesziesuJatek : IJatek
	{

		string nev;

		public SajatKesziesuJatek(string nev)
		{
			this.nev = nev;
		}

		public string Nev { get => nev; }

		public bool JatszhatVele(double eletkor)
		{
			return true;
		}
	}
}
