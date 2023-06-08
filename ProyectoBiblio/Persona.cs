using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoBiblio
{
    public class Persona
    {
        private string nombre;
        private string apellidoP;
        private string apellidoM;
        private string DNI;
        private string telefono;
        private string correo;

        public Persona(string nombre, string apellidoM, string apellidoP, string dNI, string telefono, string correo)
        {
            this.nombre = nombre;
            this.apellidoP = apellidoP;
            this.apellidoM = apellidoM;
            this.DNI = dNI;
            this.telefono = telefono;
            this.correo = correo;
        }

        public void setNombre(string nombre) { this.nombre = nombre; }
        public string getNombre() { return this.nombre; }
        public void setApellidoP(string apellidoP) { this.apellidoP = apellidoP; }
        public string getApellidoP() {  return this.apellidoP; }
        public void setApellidoM(string apellidoM) { this.apellidoM = apellidoM; }
        public string getApellidoM() {  return this.apellidoM; }
        public void setDni(string dni) { this.DNI = dni; }
        public string getDni() { return this.DNI; }
        public void setTelenofo(string telefono) { this.telefono = telefono; }
        public string getTelefono() {  return this.telefono; }
    }
        
}
