using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241106_jatek
{
	internal class VeszelyesJatek : SajatKesziesuJatek
	{
		public VeszelyesJatek(string nev) : base(nev)
		{
		}

		public override bool JatszhatVele(int eletkor)
		{
			return eletkor > 18;
		}
	}
}
