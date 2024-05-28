namespace Empleados;

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fecNac;
    private char estadoCivil;
    private DateTime fechaIngreso;
    private double sueldo;

    private Cargos cargo;
   
    public string Nombre
    {
        get
        {
            return nombre;
        }

        set
        {
            nombre = value;
        }
    }

    public string Apellido
    {
        get
        {
            return apellido;
        }
        set
        {
            apellido = value;
        }
    }

    public DateTime Fecnac
    {
        get
        {
            return fecNac;
        }
        set
        {
            fecNac = value;
        }
    }

    public char Estadocivil
    {
        get
        {
            return estadoCivil;    
        }
        set
        {
            estadoCivil = value;
        }
    }

    public DateTime Fechaingreso
    {
        get
        {
            return fechaIngreso;
        }
        set
        {
            fechaIngreso = value;
        }
    }
    public double Sueldo
    {
        get
        {
            return sueldo;
        }
        set
        {
            sueldo = value;
        }
    }
    public Cargos Cargo
    {
        get
        {
            return cargo;
        }
        set
        {
            cargo = value;
        }
    }

    public int calcularAntiguedad(DateTime Fechaingreso)
    {   
        int anioActual = DateTime.Now.Year;
        int fechaQueIngresa = Fechaingreso.Year;
        int antiguedad;
        if(anioActual > fechaQueIngresa)
        {
            antiguedad = anioActual - fechaQueIngresa;
        }
        else{
            Console.WriteLine("Ingrese una fecha valida");
            antiguedad = 0;
        }
        
        return antiguedad;
    }

    public int calcularEdad(DateTime Fecnac)
    {
        int anioActual = DateTime.Now.Year;
        int anioNacimiento = Fecnac.Year;
        int edadActual = anioActual - anioNacimiento;
        return edadActual;
    }

    
    public double calcularSalario(double Sueldo, int antiguedad, Cargos Cargo, string estadoCivil)
    {
        double adicional = 0;
        if(antiguedad > 1 && antiguedad < 20)
        {
            for (int i = 0; i < antiguedad; i++)
            {
                adicional = adicional + (Sueldo * 0.01) ;
            } 
            
        }else
        {
            adicional = Sueldo * 0.25;
        }

        if(Cargo == Cargos.Ingeniero || Cargo == Cargos.Especialista)
        {
            adicional = adicional + adicional * 0.5;
        }

        if(estadoCivil == "c" || estadoCivil == "C")
        {
            adicional = adicional + 150000;
        }


        double salario = Sueldo + adicional;
        return salario;
    }

   

}

 public enum Cargos
    {
        Auxiliar = 0,
        Administrativo = 1,
        Ingeniero = 2,
        Especialista = 3,
        Investigador = 4
    }


