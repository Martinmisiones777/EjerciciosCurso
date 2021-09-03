using System.Security.Cryptography;
using System;

namespace eje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int codCliente;
            string nomCliente;
            string salir="N";
            int tipoIva;
            string sitFiscal_IVA;
            double montoCompra, montoAlicuota, montoCompraConAlicuota;
        while (salir == "N")
        {
            Console.WriteLine("Ingrese el codigo del cliente: ");
            codCliente = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese nombre del cliente: ");
            nomCliente = Console.ReadLine();
            Console.WriteLine("Indique situacion de IVA: \n "+
                              "1- Responsable Inscripto\n"+
                              "2- Responsable No Inscripto\n"+
                              "3- Exento\n"+
                              "4- Consumidor Final"  );
            Console.WriteLine("Indique una opcion");
            tipoIva = int.Parse(Console.ReadLine());
            Console.WriteLine("Indique el monto de la compra sin impuestos: ");
            montoCompra = double.Parse(Console.ReadLine());
            switch (tipoIva)
            {
                case 1:
                {
                    montoAlicuota = montoCompra*0.14;
                    montoCompraConAlicuota = montoCompra + montoAlicuota;
                    sitFiscal_IVA = "Responsable Inscripto";
                }break;

                case 2:
                {
                    montoAlicuota = montoCompra*0.18;
                    montoCompraConAlicuota = montoCompra + montoAlicuota;
                    sitFiscal_IVA = "Responsable No Inscripto";
                }break;

                case 3:
                {
                    montoAlicuota = montoCompra*0.00;
                    montoCompraConAlicuota = montoCompra + montoAlicuota;
                    sitFiscal_IVA = "Exento";
                }break;

                case 4:
                {
                    montoAlicuota = montoCompra*0.21;
                    montoCompraConAlicuota = montoCompra + montoAlicuota;
                    sitFiscal_IVA = "Consumidor Final";
                }break;


                default:
                {
                    montoAlicuota = montoCompra*0.21;
                    montoCompraConAlicuota = montoCompra + montoAlicuota;
                    sitFiscal_IVA = "Otra Situacion IVA";
                }break;
            }


            Console.WriteLine();
            Console.WriteLine("Codigo Cliente.........................."+codCliente);
            Console.WriteLine("Nombre del Cliente......................"+nomCliente);
            Console.WriteLine("Tipo de Situacin de IVA................."+sitFiscal_IVA);
            Console.WriteLine("Monto de Alicuota Aplicada..............$"+montoAlicuota);
            Console.WriteLine("Monto total de compra con alicuota......$"+montoCompraConAlicuota);
            Console.WriteLine("..........................................................");
            Console.WriteLine("Presione N para continuar S para salir");
            //char salir = Convert.ToChar(Console.ReadLine());

        }
            
                              


        }
    }
}
