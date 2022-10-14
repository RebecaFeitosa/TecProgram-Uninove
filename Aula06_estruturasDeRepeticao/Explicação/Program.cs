// Estruturas de repetição
// Teste ou critério de parada
// Incremento da variável de controle
// Normalmente são do tipo int

int n = 1, final = 0;
Console.Write("Qual o final da repetição: ");
final = Convert.ToInt32(Console.ReadLine());

// Enquanto - while
Console.Write("---- While ----\n");

//int n=0;
while(n <= 10){
    Console.Write("{0}\n", n);
    n = n + 1;
}


// Repita - do
Console.Write("---- Do ----\n");

n = 1;
do{
    Console.Write("{0}\n",n);
    n++;
}while(n <= 10);


// Até... para
Console.Write("---- For ----\n");

for(n = 1; n <= final; n++){
    Console.Write("{0}\n",n);
}