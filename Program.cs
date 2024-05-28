using CalculadoraEspacio;
using Empleados;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

/*
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
        if(bandera == 0 )
        {
            break;
        }
    }
}
while(bandera != 0);
*/
Empleado miEmpleado = new Empleado();

double calculandoSalario = miEmpleado.calcularSalario(650000,15,Cargos.Ingeniero,"casado");

Console.WriteLine(calculandoSalario);

Empleado []arregloEmpleado = new Empleado[3];

double conceptoSalario = 0;
int mayorEdad = 0, mayorAntiguedad = 0;
int edades, antiguedades;
string nombreAjubilarse = "", apellidoAjubilarse="";

arregloEmpleado[0] = new Empleado
{
    Nombre = "Mariano",
    Apellido = "Gotardo",
    Fecnac = new DateTime(2003,10,18),
    Estadocivil = 'S',
    Fechaingreso = new DateTime(2020,9,15),
    Sueldo = 5000,
    Cargo = Cargos.Ingeniero,
};

arregloEmpleado[1] = new Empleado
{
    Nombre = "Lucas",
    Apellido = "Pratto",
    Fecnac = new DateTime(2018,12,9),
    Estadocivil = 'S',
    Fechaingreso = new DateTime(2015,9,15),
    Sueldo = 4000,
    Cargo = Cargos.Especialista,
};

arregloEmpleado[2] = new Empleado
{
    Nombre = "Lucas",
    Apellido = "Alario",
    Fecnac = new DateTime(2000,10,7),
    Estadocivil = 'S',
    Fechaingreso = new DateTime(2023,9,15),
    Sueldo = 3000,
    Cargo = Cargos.Auxiliar,
};

foreach (Empleado elemento in arregloEmpleado)
{
    conceptoSalario = conceptoSalario + elemento.Sueldo;

    

}






Console.WriteLine($"El total gastado en salario fue de: {conceptoSalario}");




