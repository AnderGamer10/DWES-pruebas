using System;



// 1------------------------------------------------------------------------
// var a = 0;
// var notas = new[] { 7.1M, 4, 6, 5, 4, 6.5M, 7 };
// var cantidadApro = 0M;
// var media = 0M;


// aqui:
// if (notas[a] >= 5) cantidadApro++;
// a++;
// if (a < notas.Length) goto aqui;
// media = (cantidadApro / notas.Length) * 100;
// Console.WriteLine($"{media:0.00} %");


// 2------------------------------------------------------------------------
// var a = 0;
// var notas = new[] { 7.1M, 4, 6, 5, 4, 6.5M, 7 };
// var cantidadApro = 0M;
// var media = 0M;


// do
// {
//     if (notas[a] >= 5) cantidadApro++;
//     a++;
// } while (a < notas.Length);

// media = (cantidadApro / notas.Length) * 100;
// Console.WriteLine($"{media:0.00} %");

// 3------------------------------------------------------------------------
// int a;
// var notas = new[] { 7.1M, 4, 6, 5, 4, 6.5M, 7 };
// decimal cantidadApro;
// decimal media;
// Inicializacion();
// while(a < notas.Length) Proceso();
// Finalizacion();


// void Inicializacion(){
// a = 0;
// cantidadApro = 0;
// }

// void Proceso(){
// if (notas[a] >= 5) cantidadApro++;
// a++;
// }

// void Finalizacion(){
//     media = (cantidadApro / notas.Length) * 100;
//     Console.WriteLine($"{media:0.00} %");
// }

// 4------------------------------------------------------------------------
// var a = 0;
// var notas = new[] { 7.1M, 4, 6, 5, 4, 6.5M, 7 };
// var cantidadApro = 0M;
// var media = 0M;

// decimal Calcular(decimal[] datos)
// {
//     do
//     {
//         if (notas[a] >= 5) cantidadApro++;
//         a++;
//     } while (a < notas.Length);
//     media = (cantidadApro / datos.Length) * 100;
//     return media;
// }

// Console.WriteLine($"{Calcular(notas):0.00} %");


//5.1------------------------------------------------------------------------



// (String,Char,Decimal) A1 =("Luis", 'H',7.1M);
// (String,Char,Decimal) A2 =("Marta", 'M',4);
// (String,Char,Decimal) A3 =("Marcos", 'H',6);
// (String,Char,Decimal) A4 =("Aroa", 'M',5);
// (String,Char,Decimal) A5 =("Nerea", 'M',4);
// (String,Char,Decimal) A6 =("Kike", 'H',6.5M);
// (String,Char,Decimal) A7 =("Juan", 'H',7.5M);

// var notas = new[] { A1, A2, A3, A4, A5, A6, A7};
// decimal media = 0M;
// for (int i = 0; i < notas.Length; i++)
// {
//     media += notas[i].Item3;
// }
// Console.WriteLine(media/notas.Length);



//5.2------------------------------------------------------------------------

// class Program
// {
//     public struct Alumno
//     {
//         public String nombre;
//         public Char sexo;
//         public decimal nota;
//     }
//     public static void Main()
//     {
//         Console.WriteLine("Usando estructuras");

//         Alumno Al1; Al1.nombre = "Luis"; Al1.sexo = 'H'; Al1.nota = 7.5M;
//         Alumno Al2; Al2.nombre = "Marta"; Al2.sexo = 'M'; Al2.nota = 4;
//         Alumno Al3; Al3.nombre = "Marcos"; Al3.sexo = 'H'; Al3.nota = 6;
//         Alumno Al4; Al4.nombre = "Aroa"; Al4.sexo = 'M'; Al4.nota = 5;
//         Alumno Al5; Al5.nombre = "Nerea"; Al5.sexo = 'M'; Al5.nota = 4;
//         Alumno Al6; Al6.nombre = "Kike"; Al6.sexo = 'H'; Al6.nota = 6.5M;
//         Alumno Al7; Al7.nombre = "Juan"; Al7.sexo = 'H'; Al7.nota = 7.5M;
//         var notas = new[] { Al1, Al2, Al3, Al4, Al5, Al6, Al7 };

//         decimal media = 0M;
//         for (int i = 0; i < notas.Length; i++)
//         {
//             media += notas[i].nota;
//         }
//         Console.WriteLine(media / notas.Length);
//     }
// }

//5.3------------------------------------------------------------------------
// class Program
// {
//     public record Person(string nombre, char sexo, decimal nota);

//     public static void Main()
//     {
//         Person person1 = new("Luis", 'H', 7.5M);
//         Person person2 = new("Marta", 'M', 4);
//         Person person3 = new("Marcos", 'H', 6);
//         Person person4 = new("Aroa", 'M', 5);
//         Person person5 = new("Nerea", 'M', 4);
//         Person person6 = new("Kike", 'H', 6.5M);
//         Person person7 = new("Juan", 'H', 7.5M);
//         var notas = new[] { person1, person2, person3, person4, person5, person6, person7 };
//         decimal media = 0M;
//         for (int i = 0; i < notas.Length; i++)
//         {
//             media += notas[i].nota;
//         }
//         Console.WriteLine(media / notas.Length);
//     }
// }
//5.4------------------------------------------------------------------------

// class Program
// {
//     public class personas
//     {
//         string _nombre;
//         decimal _nota;
//         char _sexo;
//         public string nombre
//         {
//             get => _nombre;
//             set => _nombre = value;
//         }
//         public decimal nota
//         {
//             get => _nota;
//             set => _nota = value;
//         }
//         public char sexo
//         {
//             get => _sexo;
//             set => _sexo = value;
//         }
//     }
//     class mediaNota
//     {
//         static void Main()
//         {
//             personas A1 = new personas();
//             personas A2 = new personas();
//             personas A3 = new personas();
//             personas A4 = new personas();
//             personas A5 = new personas();
//             personas A6 = new personas();
//             personas A7 = new personas();
//             A1.nombre = "Luis";
//             A1.sexo = 'H';
//             A1.nota = 7.5M;

//             A2.nombre = "Marta";
//             A2.sexo = 'M';
//             A2.nota = 4;

//             A3.nombre = "Marcos";
//             A3.sexo = 'H';
//             A3.nota = 6;

//             A4.nombre = "Aroa";
//             A4.sexo = 'M';
//             A4.nota = 5;

//             A5.nombre = "Nerea";
//             A5.sexo = 'M';
//             A5.nota = 4;

//             A6.nombre = "Kike";
//             A6.sexo = 'H';
//             A6.nota = 6.5M;

//             A7.nombre = "Juan";
//             A7.sexo = 'H';
//             A7.nota = 7.5M;

//             var notas = new[] { A1.nota, A2.nota, A3.nota, A4.nota, A5.nota, A6.nota, A7.nota };

//             decimal media = 0M;
//             for (int i = 0; i < notas.Length; i++)
//             {
//                 media += notas[i];
//             }
//             Console.WriteLine(media / notas.Length);
//         }
//     }
// }

//5.5------------------------------------------------------------------------
// using System.Collections.Generic;

// var dLuis = new Dictionary<string, object>();
// dLuis["nombre"] = "Luis";
// dLuis["sexo"] = 'H';
// dLuis["nota"] = 7.5M;

// var dMarta = new Dictionary<string, object>();
// dMarta["nombre"] = "Marta";
// dMarta["sexo"] = 'M';
// dMarta["nota"] = 4;

// var dMarcos = new Dictionary<string, object>();
// dMarcos["nombre"] = "Marcos";
// dMarcos["sexo"] = 'H';
// dMarcos["nota"] = 5;

// var dAroa = new Dictionary<string, object>();
// dAroa["nombre"] = "Aroa";
// dAroa["sexo"] = 'M';
// dAroa["nota"] = 6;

// var dNerea = new Dictionary<string, object>();
// dNerea["nombre"] = "Nerea";
// dNerea["sexo"] = 'M';
// dNerea["nota"] = 4;

// var dKike = new Dictionary<string, object>();
// dKike["nombre"] = "Kike";
// dKike["sexo"] = 'H';
// dKike["nota"] = 6.5M;

// var dJuan = new Dictionary<string, object>();
// dJuan["nombre"] = "Juan";
// dJuan["sexo"] = 'H';
// dJuan["nota"] = 7.5M;

// var notas = new[] { dLuis,dMarta, dMarcos, dAroa, dNerea, dKike, dJuan};
// decimal media = 0M;
// for (int i = 0; i < notas.Length; i++)
// {
//     media += decimal.Parse(notas[i]["nota"].ToString());
// }
// Console.WriteLine(media / notas.Length);


//-------------------------------------------------------------



namespace Actividad6
{
    class Program
    {
        static void Main(string[] args)
        {
            Sistema system = new Sistema();

            Alumno A1 = new Alumno("Luis", 'H', 7.5M);
            Alumno A2 = new Alumno("Marta", 'M', 4M);
            Alumno A3 = new Alumno("Marcos", 'H', 6M);
            Alumno A4 = new Alumno("Aroa", 'M', 5M);
            Alumno A5 = new Alumno("Nerea", 'M', 4M);
            Alumno A6 = new Alumno("Kike", 'H', 6.5M);
            Alumno A7 = new Alumno("Juan", 'H', 7.5M);

            Alumno[] notas = { A1, A2, A3, A4, A5, A6, A7 };


            Console.WriteLine($"{(system.calcularMedia(notas)):0.00} ");
            Console.WriteLine($"{(system.calcularAprobados(notas)):0.00} " + "%");
        }
    }
}

class Sistema
{

    public decimal calcularMedia(Alumno[] lista)
    {

        decimal resultado = 0M;

        for (int i = 0; i < lista.Length; i++)
            resultado += lista[i].nota;

        return resultado / lista.Length;
    }

    public decimal calcularAprobados(Alumno[] lista)
    {

        decimal resultado = 0M;
        int cantidadAprobados = 0;

        for (int i = 0; i < lista.Length; i++)
            if (lista[i].nota >= 5)
                cantidadAprobados++;
                
        resultado = (cantidadAprobados * 100) / lista.Length;
        return resultado;
    }


}

class Alumno
{
    String nombre;
    char sexo;
    public decimal nota;
    public Alumno(String _nombre, char _sexo, decimal _nota)
    {

        nombre = _nombre;
        sexo = _sexo;
        nota = _nota;

    }




}

