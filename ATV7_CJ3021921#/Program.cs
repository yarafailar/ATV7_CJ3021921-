namespace ATV7_CJ3021921
{
	internal class Program
	{
	static void Main(string[] args)
	{
		Console.WriteLine("===========MENU DO MARQUESITO========");

		Console.WriteLine("Digite 1 para o exercício 1");

		Console.WriteLine("Digite 2 para o exercício 2");

		Console.WriteLine("Digite 3 para o exercício 3");

		Console.WriteLine("Digite 4 para o exercício 4");

		Console.WriteLine("Digite 5 para o exercício 5");

		Console.WriteLine("Digite 6 para o exercício 6");

		Console.WriteLine("Digite 7 para o exercício 7");

		Console.WriteLine("Digite 0 para sair");

		Console.WriteLine("=====================================");

			int opcao = int.Parse(Console.ReadLine());

			switch (opcao)
			{
				case 0:

					Console.WriteLine("obrigado por utilizar o programa");
					break;

				case 1:

					Console.WriteLine("Exercício 1");
					int n = 1, l;

					Console.WriteLine("Digite um número:");
					l = int.Parse(Console.ReadLine());

					do
					{
						Console.WriteLine(n);
						n++;
					} while (n <= l);

					break;

				case 2:

					Console.WriteLine("Exercício 2");
					int num = 1, p;

					Console.WriteLine("Digite um número:");
					p = int.Parse(Console.ReadLine());

					do
					{
						if (num % 2 == 0)
						{
							Console.WriteLine(p);
						}
						num++;
					} while (num <= p);

					break;

				case 3:

					Console.WriteLine("Exercício 3");
					int d, c;

					Console.WriteLine("Digite um número até 1000:");
					c = int.Parse(Console.ReadLine());

					d = c;
					do
					{
						if (d % 2 == 0)
						{
							Console.WriteLine(d);
						}
						d++;
					} while (d < 1000);

					break;


				case 4:

					Console.WriteLine("Exercício 4");

					int j, b = 1;
					int s4 = 200;

					Console.WriteLine("Digite um número:");
					j = int.Parse(Console.ReadLine());

					if (j < 0)
					{
						Console.WriteLine("Número inválido");
					}
					else
					{
						do
						{
							Console.WriteLine(b);
							b++;
						} while (b < s4);
					}

					break;

				case 5:
			
					Console.WriteLine("Exercício 5");

					int t, r;
					do
					{
						Console.WriteLine("Digite um número:");
						t = int.Parse(Console.ReadLine());

						r = 1;

						do
						{
							if (t % r == 0)
							{
								Console.WriteLine(r);
							}
							r++;
						} while (r <= t);

					} while (t > 0);

					break;

				case 6:

					Console.WriteLine("Exercício 6");

					int l3 = 0, m5;
					do
					{
						Console.WriteLine("Digite um valor:");
						m5 = int.Parse(Console.ReadLine());

						if (l3 == 0)
						{
						}

						if (m5 < m5)
						{
							Console.WriteLine("O número maior é = {0}", m5);
						}

						if (m5 > m5)
						{
							Console.WriteLine("O número menor é = {0}", m5);
						}

						l3++;
					} while (l3 < 11);

					break;

				case 7:
					
					Console.WriteLine("Exercício 7");

					int s = 0, r8;
					int p2 = 0, m1 = 0;

					do
					{
						Console.WriteLine("Digite um valor:");
						r8 = int.Parse(Console.ReadLine());

						if (r8 <= 0)
							break;

						if (s % 2 != 0)
						{
							p2 = p2 + r8;
						}

						if (s % 2 == 0)
						{
							m1 = m1 + r8;
						}

						Console.WriteLine("Soma dos números ímpares = {0}", p2);
						Console.WriteLine("Soma dos números pares = {0}", m1);

						s++;
					} while (s < 10);

					break;
			} while (opcao != 0);
			while (opcao != 0);

		}
	}
}


