using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bolillero;

public class Bolilleros
{
        public int Cantidad { get; set; }
        public List<int> BolillaSacada { get; set; }
        public List<int> BolillaAdentro { get; set; }
        public List<int> Jugada { get; set; }
        public IAzar Azar { get; protected set; }
    

    public Bolilleros()
    {
        this.Cantidad = Cantidad;
        this.BolillaAdentro = BolillaAdentro;
        this.BolillaSacada = BolillaSacada;
        this.Jugada = Jugada;
    }

    public void SacarBolilla()
    {
        Azar.SacarBolilla();
    }
}