using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reciduo.entidades;

namespace reciduo.negocio
{
    class ClsLogica

    {
        
        public string por()
        {
            ClsResi resu = new ClsResi();
            int dato = 1;

            while (dato==1)
            {
                Console.WriteLine("ingrese el valor de dinero que quiere sacar");
                resu.Valor = int.Parse(Console.ReadLine());
                if (resu.Valor % 5 == 0)
                {   
                    Console.WriteLine("se procede a retirar la cantidad de: " + resu.Valor + " dolares");
                    
                }
                if(resu.Valor % 5 !=0)
                {
                    Console.WriteLine("error la cantidad de " + resu.Valor + " dolares, no se puede retirar intente con otra cifra");
                    Console.WriteLine("se procedio a cerrar el programa por que la cifra ingresada no puede ser retirada\n");
                    dato = 2;

                    
                }
               
            }
           


            return "";
            
                
                

        }
       
       
       

    }
}
