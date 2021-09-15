using System;

Console.WriteLine("Hello World!");

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


//5------------------------------------------------------------------------

var a = 0;
var notas = new[] { 7.1M, 4, 6, 5, 4, 6.5M, 7};
var cantidadApro = 0M;
var media = 0M;




























