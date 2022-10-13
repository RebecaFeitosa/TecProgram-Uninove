//   Sendo o dia 1 igual a domingo, Crie um programa que solicite um dia da semana, 
//   escrever se é DOM, SEG, TER, QUA, QUI, SEX, SAB. O usuário pode digitar um dia entre 1 a 30.

int dia, semanas, resto_semana;

Console.Write("Digite o dia do Mes");
dia = Convert.ToInt32(Console.ReadLine());

semanas = dia / 7;
Console.WriteLine("Semanas completas", semanas );
resto_semana = dia - (semanas) * 7;
Console.WriteLine("dia da semana = {0}", resto_semana );

switch(resto_semana){
    case 1:    Console.Write("Domingo");  break;
    case 2:    Console.Write("Segunda");  break;
    case 3:    Console.Write("Terça");    break;
    case 4:    Console.Write("Quarta");   break;
    case 5:    Console.Write("Quinta");   break;
    case 6:    Console.Write("Sexta");    break;
    case 0:    Console.Write("Sabado");   break;

    default:   Console.Write("Valor incorreto"); break;
}
    
Console.Write("\n");