// Pergunte ao usuário o número que ele quer da tabuada e mostre o resultado da tabuada inteira

int n, final = 0;
Console.Write("Qual a tabuada: ");
final = Convert.ToInt32(Console.ReadLine());

Console.Write("\n---- For ----\n");

for(n = 1; n <=10; n++){
    Console.Write("{0} x {1} = {2}\n",final, n, final * n);
}