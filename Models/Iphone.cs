using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.Models
{
    public class Iphone(string nome, string modelo, string imei, int memoria) : Smartphone(nome, modelo, imei, memoria)
    {
        public override string InstalarAplicativo(string nome)
        {
            return $"O aplicagivo {nome} foi instalado para Iphone";
        }
    }
}