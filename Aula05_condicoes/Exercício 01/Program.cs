/* Crie um programa que solicita um valor ao usuário, de 1 a 5
e apresenta o correspondente: (UM, DOIS, TRÊS, QUATRO, CINCO) */

int n;  //sz porém usei apenas com muitos if (funcionou) mas precisa colocar o else porque o programa fica mais rápido e correto
Console.Write("Digite um valor de 1 a 5: ");
n = Convert.ToInt32(Console.ReadLine());

if(n == 1){
    Console.Write("UM");
}else{
    if(n == 2){
        Console.Write("DOIS");
    }else{
        if (n == 3){
            Console.Write("TRÊS");
        }else{
            if(n == 4){
                Console.Write("QUATRO");
            }else{
                if(n == 5){
                }else{
                    Console.Write("CINCO");
                }
            }
        }
    }
}
Console.Write("\n");