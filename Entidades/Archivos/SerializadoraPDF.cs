using Entidades.Bebidas;
using Entidades.Ventas;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Archivos
{
    public class SerializadoraPDF
    {
        string pathTxt = Environment.CurrentDirectory + $@"/Archivos/Tickets/NumeroTicket.txt";
        public void GenerarTicket(string path, Ticket miTicket, Bebida bebida, Bebida bebidaUnoCombo, Bebida bebidaDosCombo)
        {
            SerializadoraTXT txt = new SerializadoraTXT();
            // Crear un nuevo documento PDF
            Document documento = new Document();

            // Crear un escritor PDF y asociarlo con el documento y la ruta del archivo
            PdfWriter escritor = PdfWriter.GetInstance(documento, new FileStream(path, FileMode.Create));

            // Abrir el documento para escribir contenido
            documento.Open();

            // Crear una fuente para el título
            Font fuenteTitulo = new Font(Font.FontFamily.HELVETICA, 18, Font.BOLD);

            // Crear una fuente para el contenido
            Font fuenteContenido = new Font(Font.FontFamily.HELVETICA, 12, Font.NORMAL);

            // Agregar el título al documento
            Paragraph titulo = new Paragraph($"Ticket de Compra N° {miTicket.Id}", fuenteTitulo);
            titulo.Alignment = Element.ALIGN_CENTER;
            documento.Add(titulo);

            // Agregar la información del ticket
            Paragraph contenido = new Paragraph();
            contenido.Add(new Chunk("Fecha: ", fuenteContenido));
            contenido.Add(new Chunk(miTicket.Venta.FechaDeVenta.ToString(), fuenteContenido));
            contenido.Add(Chunk.NEWLINE);

            contenido.Add(new Chunk("---------------------------------------------------", fuenteContenido));
            contenido.Add(Chunk.NEWLINE);

            contenido.Add(new Chunk($"DNI del cliente: {miTicket.Venta.DniCliente}", fuenteContenido));
            contenido.Add(Chunk.NEWLINE);

            contenido.Add(new Chunk($"Id del empleado que realizo la venta: {miTicket.Venta.IdEmpleado}", fuenteContenido));
            contenido.Add(Chunk.NEWLINE);

            contenido.Add(new Chunk("---------------------------------------------------", fuenteContenido));
            contenido.Add(Chunk.NEWLINE);

            contenido.Add(new Chunk("Productos:", fuenteContenido));
            contenido.Add(Chunk.NEWLINE);
           
            if (miTicket.Venta.IdBebida == 0)
            {
                
                contenido.Add(new Chunk($"ID: {miTicket.Venta.IdBebidaUnoCombo} -- {bebidaUnoCombo.Marca}", fuenteContenido));
                contenido.Add(Chunk.NEWLINE);
                contenido.Add(new Chunk($"ID: {miTicket.Venta.IdBebidaDosCombo} -- {bebidaDosCombo.Marca}", fuenteContenido));
                contenido.Add(Chunk.NEWLINE);
            }
            else
            {
                contenido.Add(new Chunk($"ID: {miTicket.Venta.IdBebida} -- {bebida.Marca}", fuenteContenido));
                contenido.Add(Chunk.NEWLINE);
            }

            contenido.Add(new Chunk("---------------------------------------------------", fuenteContenido));
            contenido.Add(Chunk.NEWLINE);

            contenido.Add(new Chunk($"Total: {miTicket.Venta.Ganancias}", fuenteContenido));
            contenido.Add(Chunk.NEWLINE);
            contenido.Add(new Chunk($"Metodo de pago: {miTicket.Venta.MetodoDePago}", fuenteContenido));
            contenido.Alignment = Element.ALIGN_LEFT;
            documento.Add(contenido);

            miTicket.Id++;
            txt.Escribir(miTicket.Id.ToString(), pathTxt);
            // Cerrar el documento y el escritor
            documento.Close();
            escritor.Close();

        }

    }
}
