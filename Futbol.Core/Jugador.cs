namespace Futbol.Core
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Equipo { get; set; }
        public double Peso { get; set; }
        public double Altura { get; set; }
        
        /// <summary>
        /// Esta Propiedad devuelve el calculo del IMC
        /// </summary>
        public double IMC => Peso / (Altura * Altura);
        
        /// <summary>
        /// Esta propiedad devuelva una cadena descriptiva del IMC del Jugador
        /// </summary>
        public string DescripcionIMC
        {
            get
            {
                switch (IMC)
                {
                    case double v when v < 18.5: return "Bajo";
                    case double v when v >= 18.5 && v < 25: return "Normal";
                    case double v when v >= 25 && v < 30: return "Warning";
                    default: return "Warning";
                }
            }
        }
        public bool SosDe(string unEquipo) => Equipo == unEquipo;
    }
}