using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _241106_jatek
{
	internal class JatekLista
	{
		private List<IJatek> jatekLista;
		private int eletKorlat;

		public JatekLista(int eletKorlat)
		{
			this.eletKorlat = eletKorlat;
		}
		
		public void UjJatekFelvetele(IJatek ujJatek)
		{
			if (ujJatek.JatszhatVele(eletKorlat)) 
			{
				jatekLista.Add(ujJatek);
			}
		}

		public void JatekTorlese(IJatek torlendo) { 
			jatekLista.Remove(torlendo);
		}

		public IJatek JatekKereses(string jatekNeve)
		{
			int i = 0;
			while (i < jatekLista.Count && jatekNeve != jatekLista[i].Nev)
			{
				i++;
			}
			if (i < jatekLista.Count())
			{
				return jatekLista[i];
			}
			else
			{
				return null;
			}
		}
		
	

	}
}
