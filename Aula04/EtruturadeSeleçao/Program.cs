int idade=18;
if (idade > 18)
{
    Console.WriteLine("Voce e maior de idade e nao tem clt");
}

else
{
    Console.WriteLine("BEBEZAO KKKKKKKK");

}

//Encadeadas
 
 int temp = 30;

 if(temp < 0){
Console.WriteLine("Frio");
 }

else if (temp > 25){
    Console.WriteLine("Quente");
}

else{
    Console.WriteLine("Agradavel");
}

//

int dia = 1;
switch (dia);
case 1:
    Console.WriteLine("segunda");
    break;
case 2:
    Console.WriteLine("terca");                             
    break;
case 3:
    Console.WriteLine("quarta");
    break;      
case 4:
    Console.WriteLine("quinta");    
    break;
case 5:
    Console.WriteLine("sexta");
    break;
case 6:
    Console.WriteLine("sabado");
    break;
case 7: 
    Console.WriteLine("domingo");
    break;
default:
    Console.WriteLine("Dia invalido");
    break;

    //caddeada heterogenea
     int umi = 10;
     int pre = 1000;

     if(temp > 10){
         Console.WriteLine($"A temperatura e {temp}");
         else if (umi > 70) Console.WriteLine($"A umidade e {umi}");
         else if (umi < 70 || temp < 10 && pre > 500) Console.WriteLine($"A temperatura e {temp} e a umidade e {umi} e a pressao e {pre}");
     } 