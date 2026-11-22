using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace BiblioStock.Persistencia
{
    public class ArchivoTexto
    {
        private string ruta;

        public ArchivoTexto(string nombreArchivo)
        {
            string carpeta = Path.Combine(
                AppDomain.CurrentDomain.BaseDirectory,
                "Datos"
            );

            Directory.CreateDirectory(carpeta);

            ruta = Path.Combine(carpeta, nombreArchivo);

            if (!File.Exists(ruta))
            {
                File.Create(ruta).Close();
            }
        }

        public List<string> LeerArchivo()
        {
            List<string> registros = new List<string>();

            try
            {
                registros.AddRange(File.ReadAllLines(ruta));
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo leer el archivo: " + ex.Message
                );
            }

            return registros;
        }

        public void GuardarArchivo(List<string> registros)
        {
            try
            {
                File.WriteAllLines(ruta, registros);
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo guardar el archivo: " + ex.Message
                );
            }
        }

        public void AgregarRegistro(string registro)
        {
            try
            {
                File.AppendAllText(
                    ruta,
                    registro + Environment.NewLine
                );
            }
            catch (Exception ex)
            {
                throw new Exception(
                    "No se pudo agregar el registro: " + ex.Message
                );
            }
        }
    }
}

