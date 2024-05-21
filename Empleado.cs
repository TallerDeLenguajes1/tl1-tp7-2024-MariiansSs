namespace Empleado;

public class Empleado
{
    private string nombre;
    private string apellido;
    private DateTime fecNac = DateTime.Now;
    private char estadoCivil;
    private double sueldo;

    private cargos cargo;
   
    public string Nombre
    {
        get
        {
            return nombre;
        }
    }

    public string Apellido
    {
        get
        {
            return apellido;
        }
    }

    public DateTime Fecnac
    {
        get
        {
            return fecNac;
        }
    }

    public char Estadocivil
    {
        get
        {
            return estadoCivil;    
        }
    }

}

 public enum cargos
    {
        Auxiliar,
        Administrativo,
        Ingeniero,
        Especialista,
        Investigador
    }

