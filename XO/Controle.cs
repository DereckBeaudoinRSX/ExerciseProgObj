using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApplication1
{
	class Controle
	{
		public static bool _Tour = true; 
		public static int _CompteurDeTour;

		public Controle()
		{
			
		}
		public void Plus1Tour()
		{
			_CompteurDeTour += 1; 
			_Tour = !_Tour; 
		}
		public bool ValeurTour()
		{
			return _Tour;
		}
		public int ValeurCompteur()
		{
			return _CompteurDeTour;
		}
		public void ClearTour()
		{
			_CompteurDeTour = 0;
			_Tour = true; 
			
		}

	}
}
