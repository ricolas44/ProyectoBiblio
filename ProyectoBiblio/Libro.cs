using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblio
{
    public class Libro
    {
        private string tipo;
        private string autor;
        private string titulo;
        private string editorial;
        private string edicion;
        private DateTime fecha;
        private Persona solicitante;

        public Libro(string tipo, string autor, string titulo, string editorial, string edicion, DateTime fecha, Persona solicitante)
        {
            this.tipo = tipo;
            this.autor = autor;
            this.titulo = titulo;
            this.editorial = editorial;
            this.edicion = edicion;
            this.fecha = fecha;
            this.solicitante = solicitante;
        }

        public string getTipo() {  return tipo; }
        public void setTipo(string tipo) { this.tipo = tipo; }
        public string getAutor() {  return autor; }
        public void setAutor(string autor) { this.autor = autor; }
        public string getTitulo() {  return titulo; }
        public void setTitulo(string titulo) { this.titulo = titulo; }
        public string getEditorial() {  return editorial; }
        public void setEditorial(string editorial) { this.editorial= editorial; }
        public string getEdicion() {  return edicion; }
        public void setEdicion(string edicion) { this.edicion = edicion; }
        public DateTime getFecha() { return fecha; }
        public void setFecha(DateTime fecha) { this.fecha = fecha;}
        public Persona getSolicitante() { return solicitante; }
        public void setSolicitante(Persona solicitante) { this.solicitante = solicitante; }

    }

}
