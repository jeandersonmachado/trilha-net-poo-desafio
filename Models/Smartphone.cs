using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace teste.Models
{
    public abstract class Smartphone
    {
        public Smartphone(string nome, string modelo, string imei, int memoria)
        {
            Nome = nome;
            Modelo = modelo;
            Imei = imei;
            Memoria = memoria;
        }
        public string Nome { get; set; }
        private string Modelo { get; set; }
        private string Imei { get; set; }
        private int Memoria { get; set; }

        public void Ligar()
        {
            Console.WriteLine("Ligando");
        }

        public void RebecerLigacao()
        {
            Console.WriteLine("Recebendo ligacao");
        }

        public abstract string InstalarAplicativo(string nome);
    }
}