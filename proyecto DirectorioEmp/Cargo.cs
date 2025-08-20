using System;

namespace proyecto_DirectorioEmp
{
    public class Cargo
    {
        // Variables privadas
        private int numeroCargo;
        private string titulo;
        private DateTime fechaInicio;
        private DateTime fechaFinal;
        private bool empleoActual;
        private string empresa;
        private decimal salario;
        private string detalles;

        // Constructor vacío
        public Cargo()
        {
            numeroCargo = 0;
            titulo = "";
            fechaInicio = DateTime.Now;
            fechaFinal = DateTime.Now;
            empleoActual = false;
            empresa = "";
            salario = 0.0m;
            detalles = "";
        }

        // Constructor con parámetros
        public Cargo(int numeroCargo, string titulo, DateTime fechaInicio,
                     DateTime fechaFinal, bool empleoActual, string empresa,
                     decimal salario, string detalles)
        {
            this.numeroCargo = numeroCargo;
            this.titulo = titulo;
            this.fechaInicio = fechaInicio;
            this.fechaFinal = fechaFinal;
            this.empleoActual = empleoActual;
            this.empresa = empresa;
            this.salario = salario;
            this.detalles = detalles;
        }

        // Métodos Get y Set
        public int GetNumeroCargo()
        {
            return numeroCargo;
        }

        public void SetNumeroCargo(int numeroCargo)
        {
            this.numeroCargo = numeroCargo;
        }

        public string GetTitulo()
        {
            return titulo;
        }

        public void SetTitulo(string titulo)
        {
            this.titulo = titulo;
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

        public bool GetEmpleoActual()
        {
            return empleoActual;
        }

        public void SetEmpleoActual(bool empleoActual)
        {
            this.empleoActual = empleoActual;
        }

        public string GetEmpresa()
        {
            return empresa;
        }

        public void SetEmpresa(string empresa)
        {
            this.empresa = empresa;
        }

        public decimal GetSalario()
        {
            return salario;
        }

        public void SetSalario(decimal salario)
        {
            this.salario = salario;
        }

        public string GetDetalles()
        {
            return detalles;
        }

        public void SetDetalles(string detalles)
        {
            this.detalles = detalles;
        }

        // Método para mostrar información
        public override string ToString()
        {
            string estado = empleoActual ? "Actual" : "Anterior";
            return $"Cargo #{numeroCargo}: {titulo} en {empresa} ({estado})";
        }
    }
}