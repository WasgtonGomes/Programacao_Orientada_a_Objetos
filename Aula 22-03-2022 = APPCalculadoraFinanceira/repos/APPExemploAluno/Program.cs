using APPExemploAluno.RegrasDeNegocio;
//

string continuar = "";
int contador = 1;

while (continuar!= "N")
{
    Aluno aluno = new Aluno();
    Console.WriteLine("#################### CADASTRO DE ALUNO " + contador +" ##################");
    Console.WriteLine();
    Console.Write("Nome..........:");
    aluno.Nome = Console.ReadLine();

    Console.Write("Nota 1 .......:");
    aluno.Nota1 = Convert.ToInt32(Console.ReadLine());

    Console.Write("Nota2.........:");
    aluno.Nota2 = Convert.ToInt32(Console.ReadLine());

    aluno.CalcularMedia(); //processamento

    Console.Clear();
    Console.WriteLine("#################### DADOS DO ALUNO ####################");
    Console.WriteLine();
    Console.WriteLine("Nome.......:" + aluno.Nome);
    Console.WriteLine("Média......:" + aluno.Media);
    if (aluno.Media<70) Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Situação...:" + aluno.SituacaoAluno());
    Console.ForegroundColor = ConsoleColor.White;                          //ALTERA AS CORES DO TEXTO
    Console.WriteLine();
    Console.WriteLine("################### FIM DOS DADOS DO ALUNO #############");
    Console.WriteLine();
    Console.WriteLine("Deseja continuar cadasdastrando? (S/N)");
    continuar = Console.ReadLine().ToUpper();  // O .ToUpper() faz com que tudo fique em letra maiuscula
    contador++;
}