using System;
using System.Collections.Generic;
using System.Text;

namespace sistemaGanado
{
    class Alimentacion
    {
        private string nombreAlimento;
        private float porcionPorGanado;

        public Alimentacion(string nombreAlimento, float porcionPorGanado)
        {
            this.nombreAlimento = nombreAlimento;
            this.porcionPorGanado = porcionPorGanado;
        }

        public string NombreAlimento { get => nombreAlimento; set => nombreAlimento = value; }
        public float PorcionPorGanado { get => porcionPorGanado; set => porcionPorGanado = value; }

        public void DatosAlimento()
        {
            Console.WriteLine($"Nombre: {alimento.nombreAlimento}");
            Console.WriteLine($"Porcion por cabeza: {alimento.porcionPorGanado}");
        }
    }
}
