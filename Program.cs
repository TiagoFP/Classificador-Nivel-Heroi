using System;
using System.Reflection;
using System.Xml.XPath;

internal class Program
{
	private static void Main(string[] args)
	{
		string NomeHeroi;
		int Xp;

		NomeHeroi = Console.ReadLine();
		Xp = int.Parse(Console.ReadLine());

		if (Xp < 1000)
		{
			string nivel = "Ferro";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
		else if (Xp > 1001 && Xp <= 2000)
		{
			string nivel = "Bronze";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
		else if (Xp > 2001 && Xp <= 5000)
		{
			string nivel = "Prata";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
		else if (Xp > 5001 && Xp <= 7000)
		{
			string nivel = "Ouro";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
		else if (Xp > 7001 && Xp <= 8000)
		{
			string nivel = "Platina";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
		else if (Xp > 8001 && Xp <= 9000)
		{
			string nivel = "Ascendente";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
		else if (Xp > 9001 && Xp <= 10000)
		{
			string nivel = "Imortal";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
		else
		{
			string nivel = "Radiante";
			Console.WriteLine("O Héroi " + NomeHeroi + " está no nível " + nivel);
		}
	}
}


