using System;

namespace proyecto_DirectorioEmp
{
    public class Grado
    {
        // Variables privadas
        private int numeroGrado;
        private string nivelEducativo;
        private string institucion;
        private string nombreTitulo;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private string tipoGrado;
        private DateTime fechaExpiracion;
        private string pais;

        // Constructor vacío
        public Grado()
        {
            numeroGrado = 0;
            nivelEducativo = "";
            institucion = "";
            nombreTitulo = "";
            fechaInicio = DateTime.Now;
            fechaFinal = DateTime.Now;
            tipoGrado = "";
            fechaExpiracion = DateTime.Now;
            pais = "";
        }

        // Constructor con parámetros
        public Grado(int numeroGrado, string nivelEducativo, string institucion,
                     string nombreTitulo, DateTime fechaInicio, DateTime fechaFinal,
                     string tipoGrado, DateTime fechaExpiracion, string pais)
        {
            this.numeroGrado = numeroGrado;
            this.nivelEducativo = nivelEducativo;
            this.institucion = institucion;
            this.nombreTitulo = nombreTitulo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.tipoGrado = tipoGrado;
            this.fechaExpiracion = fechaExpiracion;
            this.pais = pais;
        }

        // Métodos Get y Set
        public int GetNumeroGrado()
        {
            return numeroGrado;
        }

        public void SetNumeroGrado(int numeroGrado)
        {
            this.numeroGrado = numeroGrado;
        }

        public string GetNivelEducativo()
        {
            return nivelEducativo;
        }

        public void SetNivelEducativo(string nivelEducativo)
        {
            this.nivelEducativo = nivelEducativo;
        }

        public string GetInstitucion()
        {
            return institucion;
        }

        public void SetInstitucion(string institucion)
        {
            this.institucion = institucion;
        }

        public string GetNombreTitulo()
        {
            return nombreTitulo;
        }

        public void SetNombreTitulo(string nombreTitulo)
        {
            this.nombreTitulo = nombreTitulo;
        }

        public DateTime GetFechaInicio()
        {
            return fechaInicio;
        }

        public void SetFechaInicio(DateTime fechaInicio)
        {
            this.fechaInicio = fechaInicio;
        }

        public DateTime GetFechaFinal()
        {
            return fechaFinal;
        }

        public void SetFechaFinal(DateTime fechaFinal)
        {
            this.fechaFinal = fechaFinal;
        }

        public string GetTipoGrado()
        {
            return tipoGrado;
        }

        public void SetTipoGrado(string tipoGrado)
        {
            this.tipoGrado = tipoGrado;
        }

        public DateTime GetFechaExpiracion()
        {
            return fechaExpiracion;
        }

        public void SetFechaExpiracion(DateTime fechaExpiracion)
        {
            this.fechaExpiracion = fechaExpiracion;
        }

        public string GetPais()
        {
            return pais;
        }

        public void SetPais(string pais)
        {
            this.pais = pais;
        }

        // Método para mostrar información
        public override string ToString()
        {
            return $"Grado #{numeroGrado}: {nombreTitulo} - {nivelEducativo} en {institucion}";
        }
    }
}