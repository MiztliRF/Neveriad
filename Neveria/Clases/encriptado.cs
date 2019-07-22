using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantCasaDeLia.Clases
{
    class encriptado
    {
        public static string cryption(string str)
        {

            string encriptacion,contra ="";
            

            for (int counter = 0; counter < str.Length; counter++)
            {

                encriptacion = str.Substring(counter, 1);


                if (encriptacion.Equals("a") || encriptacion.Equals("A"))
                {
                    contra += "@";
                    //Console.Write("3H$D");
                }
                if (encriptacion.Equals("b") || encriptacion.Equals("B"))
                {
                    contra += "W";
                    //Console.Write("R3C$");
                }
                if (encriptacion.Equals("c") || encriptacion.Equals("C"))
                {
                    contra += "Q";
              
                }
                if (encriptacion.Equals("d") ||  encriptacion.Equals("D"))
                {
                    contra += "E";
                   
                }
         
                if (encriptacion.Equals("e") || encriptacion.Equals("E"))
                {
                    contra += "A";
                   
                }
                if (encriptacion.Equals("f") || encriptacion.Equals("F"))
                {
                    contra += "P";
                  
                }
                if (encriptacion.Equals("g") || encriptacion.Equals("G"))
                {
                    contra += "B";
                  
                }
                if (encriptacion.Equals("h") || encriptacion.Equals("H"))
                {
                    contra += "H";
                
                }
                if (encriptacion.Equals("i") || encriptacion.Equals("I"))
                {
                    contra += "S";
                    
                }
                if (encriptacion.Equals("j") || encriptacion.Equals("J"))
                {
                    contra += "D";
            
                }
                if (encriptacion.Equals("k") || encriptacion.Equals("K"))
                {
                    contra += "1";
                 
                }
                if (encriptacion.Equals("l") || encriptacion.Equals("L"))
                {
                    contra += "7";
                   
                }

                if (encriptacion.Equals("m") || encriptacion.Equals("M"))
                {
                    contra += "2";
                
                }
                if (encriptacion.Equals("n") || encriptacion.Equals("N"))
                {
                    contra += "0";

                    
                }
                if (encriptacion.Equals("ñ") || encriptacion.Equals("Ñ"))
                {
                    contra += "?";
                 
                }
                if (encriptacion.Equals("o") || encriptacion.Equals("O"))
                {
                    contra += "¿";
               
                }
                if (encriptacion.Equals("p") || encriptacion.Equals("P"))
                {
                    contra += "6";
                 
                }
                if (encriptacion.Equals("q") || encriptacion.Equals("Q"))
                {
                    contra += "7";

                }
                if (encriptacion.Equals("r") || encriptacion.Equals("R"))
                {
                    contra += "Z";
                   
                }
                if (encriptacion.Equals("s") || encriptacion.Equals("S"))
                {
                    contra += "O";
                 
                }
                if (encriptacion.Equals("t") || encriptacion.Equals("T"))
                {
                    contra += "X";
                 
                }
                if (encriptacion.Equals("u") || encriptacion.Equals("U"))
                {
                    contra += "Ñ";
                  
                }
                if (encriptacion.Equals("v") || encriptacion.Equals("V"))
                {
                    contra += "M";
               
                }
                if (encriptacion.Equals("w") || encriptacion.Equals("W"))
                {
                    contra += "4";
                  
                }
                if (encriptacion.Equals("x") || encriptacion.Equals("X"))
                {
                    contra += "T";
                    
                }


                if (encriptacion.Equals("y") || encriptacion.Equals("Y"))
                {
                    contra += "04%$";
                    
                }


                if (encriptacion.Equals("z") || encriptacion.Equals("Z"))
                {
                    contra += "B";
                 
                }
                if (encriptacion.Equals("1"))
                {
                    contra += "9";

                }
                if (encriptacion.Equals("2"))
                {
                    contra += "<";

                }
                if (encriptacion.Equals("3"))
                {
                    contra += "=";

                }
                if (encriptacion.Equals("4"))
                {
                    contra += "$";

                }
                if (encriptacion.Equals("5"))
                {
                    contra += "&";

                }
                if (encriptacion.Equals("7"))
                {
                    contra += "|";

                }
                if (encriptacion.Equals("8"))
                {
                    contra += "°";

                }
                if (encriptacion.Equals("9"))
                {
                    contra += "¬";

                }
                if (encriptacion.Equals("10"))
                {
                    contra += "9283";

                }
                if (encriptacion.Equals("0"))
                {
                    contra += "*";

                }




            }

            return contra;
        }

    }
}
