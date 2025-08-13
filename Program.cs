using System.ComponentModel;
using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia");
Smartphone Nokia = new Nokia(numero: "25636243", modelo: "Modelo Nokia", imei: "12345678", memoria: 16);
Nokia.Ligar();
Nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n\n");

Console.WriteLine("Smartphone Iphone");
Smartphone Iphone = new Iphone(numero: "67389564", modelo: "Modelo Iphone", imei: "87654321", memoria: 64);
Nokia.Ligar();
Nokia.InstalarAplicativo("Telegram");