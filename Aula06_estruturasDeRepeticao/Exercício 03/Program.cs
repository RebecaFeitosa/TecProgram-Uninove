/*int n=1;
while(n<=5){
    Console.Write("{0} (while)\n",n);
    n++;
}


n=1;
do{
    Console.Write("{0} (do.while)\n",n);
    n++;
}while(n<=5);
*/
int n, tab;
Console.Write("Escolha a tabuada: ");
tab = Convert.ToInt32(Console.ReadLine());
for(n=1; n<=10; n++){
    Console.Write("{0} x {1} = {2}\n",tab, n, tab*n);
}