double salario, dia;
dia = 05;

Console.Write("Digite o salário: ");
salario = Convert.ToDouble(Console.ReadLine());
//                                                                          0      1        
Console.Write("O salário digitado é R$ {1}, você irá receber no dia {0}.", dia, salario.ToString("0.00"));
/*    .ToString(0.00) significa que só pode exibir apenas 2 números após a vírgula.

como se fosse array                                                            0      1
Console.Write("O salário digitado é R$ {0} e você irá receber no dia {1}.", salario, dia);

*/