using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Indexadores;

public class Time
{
    //definir os limites do array
    string[] valor = new string[10];

    //criar indexador
    public string this[int i]
    {
        get
        {
            if(i >= 0 && i < valor.Length)
            {
                //retornar o valor
                return valor[i];
            }
            return "Erro";
        }

        set
        {
            if (i >= 0 && i < valor.Length)
                //atribuir valor
                valor[i] = value;
        }
    }
}
