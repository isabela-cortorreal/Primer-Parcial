using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace parcial_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int b_mil = 18, b_quinientos = 19, b_docientos = 23, b_cien = 50,
                m_mil = 0, m_quinientos = 0, m_docientos = 0, m_cien = 0,
                retiro_fdp, retiro_otro, menu;

            void banco_fdp()
            {
                Console.Write("\n" + "Ingrese la suma de dinero que desea retirar: ");
                retiro_fdp = int.Parse(Console.ReadLine());

                if (retiro_fdp >= 20000)
                {
                    Console.Clear();
                    Console.WriteLine("Lo sentimos, el monto solicitado no puede ser dispensado" + "\n");
                }
                else
                {
                    while (retiro_fdp != 0) {

                        if (retiro_fdp >= 19000) {
                            retiro_fdp -= 18000;

                            if (b_quinientos != 0) {
                                m_quinientos = (retiro_fdp - retiro_fdp % 500) / 500;
                                retiro_fdp = retiro_fdp % 500;
                            }

                            if (b_docientos != 0) {
                                m_docientos = (retiro_fdp - retiro_fdp % 200) / 200;
                                retiro_fdp = retiro_fdp % 200;
                            }

                            if (b_cien != 0) {
                                m_cien = (retiro_fdp - retiro_fdp % 100) / 100;
                                retiro_fdp = retiro_fdp % 100;
                            }

                            Console.WriteLine("Billetes de mil: " + b_mil);
                            Console.WriteLine("Billetes de 500 " + m_quinientos);
                            Console.WriteLine("Billetes de 200: " + m_docientos);
                            Console.WriteLine("Billetes de 100: " + m_cien);

                        } else {

                            if (m_mil < 18) {
                                m_mil = (retiro_fdp - retiro_fdp % 1000) / 1000;
                                retiro_fdp = retiro_fdp % 1000;
                            }

                            if (m_quinientos != 0) {
                                m_quinientos = (retiro_fdp - retiro_fdp % 500) / 500;
                                retiro_fdp = retiro_fdp % 500;
                            }

                            if (m_docientos != 0) {
                                m_docientos = (retiro_fdp - retiro_fdp % 200) / 200;
                                retiro_fdp = retiro_fdp % 200;
                            }

                            if (m_cien != 0) {
                                m_cien = (retiro_fdp - retiro_fdp % 100) / 100;
                                retiro_fdp = retiro_fdp % 100;
                            }

                            Console.WriteLine("Billetes de mil: " + m_mil);
                            Console.WriteLine("Billetes de 500 " + m_quinientos);
                            Console.WriteLine("Billetes de 200: " + m_docientos);
                            Console.WriteLine("Billetes de 100: " + m_cien);
                        }
                    }


                }
            }

            void banco_x()
            {
                Console.Write("\n" + "Ingrese la suma de dinero que desea retirar: ");
                retiro_otro = int.Parse(Console.ReadLine());

                if (retiro_otro >= 10000) {
                    Console.Clear();
                    Console.WriteLine("Lo sentimos, el monto solicitado excede el limite de transaccion");

                } else {

                    if (m_mil < 18) {
                        m_mil = (retiro_otro - retiro_otro % 1000) / 1000;
                        retiro_otro = retiro_otro % 1000;
                    }

                    if (b_quinientos != 0) {
                        m_quinientos = (retiro_otro - retiro_otro % 500) / 500;
                        retiro_otro = retiro_otro % 500;
                    }

                    if (b_docientos != 0) {
                        m_docientos = (retiro_otro - retiro_otro % 200) / 200;
                        retiro_otro = retiro_otro % 200;
                    }

                    if (b_cien != 0) {
                        m_cien = (retiro_otro - retiro_otro % 100) / 100;
                        retiro_otro = retiro_otro % 100;
                    }

                    Console.WriteLine("Billetes de mil: " + m_mil);
                    Console.WriteLine("Billetes de 500 " + m_quinientos);
                    Console.WriteLine("Billetes de 200: " + m_docientos);
                    Console.WriteLine("Billetes de 100: " + m_cien);
                }
            }

            do
            {
                Console.WriteLine("Bienvenido");
                Console.WriteLine("¿A cual banco pertecene?");
                Console.WriteLine("1- FDP INVERSMENTS" +
                           "\n" + "2- Otro banco" +
                           "\n" + "3- Salir" + "\n");

                Console.Write("Escoja una opcion: ");
                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        banco_fdp();
                        break;

                    case 2:
                        banco_x();
                        break;

                    case 3:
                        Console.Clear();
                        Console.WriteLine("Programa Finalizado");
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("N/A");
                        break;

                } Console.ReadKey();

            } while (menu != 3);
        }
    }
}