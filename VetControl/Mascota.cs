namespace VetControl
{
    // Clase que representa una mascota.
    public class Mascota
    {
        // Propiedades automáticas.
        public string Nombre { get; set; } = "";
        public string Especie { get; set; } = "";
        public char Sexo { get; set; }
        public string Servicio { get; set; } = "";

        // Campos privados.
        private int edad;
        private double peso;

        // La edad solo acepta valores entre 0 y 30.
        public int Edad
        {
            get { return edad; }
            set
            {
                if (value >= 0 && value <= 30)
                {
                    edad = value;
                }
            }
        }

        // El peso debe ser mayor que cero.
        public double Peso
        {
            get { return peso; }
            set
            {
                if (value > 0)
                {
                    peso = value;
                }
            }
        }

        // Calcula la edad en meses.
        public int CalcularEdadEnMeses()
        {
            return Edad * 12;
        }

        // Determina la etapa de vida de la mascota.
        public string ObtenerEtapa()
        {
            if (Edad < 1)
            {
                return "Cachorro";
            }
            else if (Edad <= 7)
            {
                return "Adulto";
            }
            else
            {
                return "Senior";
            }
        }

        // Devuelve el sexo completo de la mascota.
        public string ObtenerSexoCompleto()
        {
            switch (Sexo)
            {
                case 'M':
                    return "Macho";

                case 'H':
                    return "Hembra";

                default:
                    return "";
            }
        }
        // Obtiene el precio del servicio seleccionado.
        public decimal ObtenerCostoBase()
        {
            switch (Servicio)
            {
                case "Consulta general":
                    return 15000m;

                case "Vacunación":
                    return 20000m;

                case "Desparasitación":
                    return 10000m;

                case "Baño":
                    return 12000m;

                default:
                    return 0m;
            }
        }
        // Calcula el descuento según la etapa de vida.
        public decimal CalcularDescuento()
        {
            string etapa = ObtenerEtapa();

            if (etapa == "Cachorro" || etapa == "Senior")
            {
                return ObtenerCostoBase() * 0.10m;
            }
            else
            {
                return 0m;
            }
        }
        // Calcula el impuesto del 13 % sobre el subtotal.
        public decimal CalcularImpuesto()
        {
            decimal subtotal = ObtenerCostoBase() - CalcularDescuento();

            return subtotal * 0.13m;
        }
    
            // Calcula el total final de la mascota.
        public decimal CalcularTotal()
        {
            decimal subtotal = ObtenerCostoBase() - CalcularDescuento();

            return subtotal + CalcularImpuesto();
        }
        // Crea el resumen de la mascota para mostrarlo en la lista.
        public string ObtenerResumen()
        {
            return Nombre + " (" + ObtenerSexoCompleto() + ") - " +
                   Especie + " - " + ObtenerEtapa() + " - " +
                   Servicio + " - ₡" + CalcularTotal().ToString("0.##");
        }

    }
  }



