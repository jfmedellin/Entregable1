Console.WriteLine("ingrese el nombre completo");
string Nombre = Console.ReadLine();
Console.WriteLine("ingrese su edad");
int Edad = int.Parse(Console.ReadLine());
int Valor = 15000;
double Descuento1= (Valor * 0.05);
double Descuento2= (Valor * 0.03);

if(Edad < 4){

    Console.WriteLine($"{Nombre} tu entrada es gratis");

}else{
    if(Edad >= 4 && Edad < 18){
        Console.WriteLine($"{Nombre} su descuento es del 5% que equivalen a {Descuento1} y el valor de la entrada es {Valor - Descuento1}");
    }
    else{
    Console.WriteLine($"{Nombre} su descuento es del 3% que equivalen a {Descuento2} y el valor de la entrada es {Valor - Descuento2}");

}
}

