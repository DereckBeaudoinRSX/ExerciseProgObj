using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExeriseProg
{
	public class Fraction
	{
		private int _numerateur;
		private int _denominateur;

		public Fraction(int numerateur, int denominateur)
		{
			_numerateur = numerateur;
			_denominateur = denominateur; 
		}
		public int GetNumerateur()
		{
			return this._numerateur;
		}
		public int GetDenominateur()
		{
			return this._denominateur;
		}

		public static Fraction operator +(Fraction premiereFraction, Fraction deuxiemeFraction)
		{
			return new Fraction(premiereFraction._numerateur * deuxiemeFraction._denominateur + deuxiemeFraction._numerateur * premiereFraction._denominateur, premiereFraction._denominateur * deuxiemeFraction._denominateur);
		}
		public static Fraction operator -(Fraction premiereFraction, Fraction deuxiemeFraction)
		{
			var denominateur = premiereFraction._denominateur + deuxiemeFraction._denominateur;
			var numerateur = (premiereFraction._numerateur * deuxiemeFraction._denominateur) - (deuxiemeFraction._numerateur + deuxiemeFraction._denominateur);
			return new Fraction(numerateur, denominateur);
		}
		public static Fraction operator /(Fraction premiereFraction, Fraction deuxiemeFraction)
		{
			if (deuxiemeFraction._denominateur == 0)
			{
				throw new DivideByZeroException();
			}
			else
			{
				return new Fraction((premiereFraction._numerateur * deuxiemeFraction._denominateur) + (premiereFraction._denominateur * deuxiemeFraction._numerateur) ,premiereFraction._denominateur * deuxiemeFraction._denominateur);
			}
		}
		public static Fraction operator *(Fraction premiereFraction, Fraction deuxiemeFraction)
		{
			return new Fraction((premiereFraction._numerateur * deuxiemeFraction._numerateur), (premiereFraction._denominateur * deuxiemeFraction._denominateur));
		}

	}
}
