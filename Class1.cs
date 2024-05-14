using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ClassLibrary1
{
    internal  class Class1
    {
        static void Main(string[] args) {

            var mensagem = "Olá Mundo Novo ... ";
            ExibirMensagem(mensagem);   
        }

        static void ExibirMensagem(string texto)
        {
            

          //  Console.WriteLine(texto.Substring(2, 8));


            for (int i = texto.Length; i > 0; i--)
            {
              //  var textoDireita = texto.PadRight(i);
				var textoInicial = texto.Substring(0, i);

				Console.WriteLine(textoInicial);

            } 
        }

		

		}

	}
