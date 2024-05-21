using CalculadoraEspacio;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Calculadora miCalculadora = new Calculadora();

int bandera = 1,opcion; 
double numero1;

do{
    Console.Write("1:Sumar\n");
    Console.Write("2:Restar\n");
    Console.Write("3:Multiplicar\n");
    Console.Write("4:Dividir\n");
    Console.Write("5:Limpiar\n");
    string opcionS = Console.ReadLine();
    if(int.TryParse(opcionS, out opcion))
    {
        Console.Write("Ingrese un numero");
        string num1 = Console.ReadLine();        

        if(double.TryParse(num1, out numero1))
        {
            switch(opcion)
            {
                case 1:
                     miCalculadora.sumar(numero1);
                     Console.WriteLine(miCalculadora.RESULTADO);                
                break;
                case 2:
                    miCalculadora.restar(numero1);
                    Console.WriteLine(miCalculadora.RESULTADO);   
                break;
                case 3:
                    miCalculadora.multiplicar(numero1);
                    Console.WriteLine(miCalculadora.RESULTADO);   
                break;
                case 4:
                    miCalculadora.dividir(numero1);
                    Console.WriteLine(miCalculadora.RESULTADO);   
                break;
                case 5:
                    miCalculadora.limpiar();
                    Console.WriteLine(miCalculadora.RESULTADO);   
                break;
            }
        }
    }
    Console.Write("Desea realizar otra operacion? (0=no, 1=si)");
    string banderaO = Console.ReadLine();
    if(int.TryParse(banderaO, out bandera))
    {
        if(bandera != 0 && bandera != 1)
        {
            Console.Write("Porfavor ingrese una opcion valida");
            bandera = 1;
        }
    }
}
while(bandera != 0);