using iTextSharp.text;
using iTextSharp.text.pdf;
using SistemaRecepcionPesos.Modelo;
using SistemaRecepcionPesos.Properties;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaRecepcionPesos.Controlador
{
    class TicketController
    {
        DBEcuamareEntities bd = new DBEcuamareEntities();

        
        public V_TicketImprimir ObtenerTicketPorID(int idTicket)
        {
            V_TicketImprimir ticket = (from tick in bd.V_TicketImprimir
                                       where tick.ID == idTicket
                                       select tick).Single();
            return ticket;
        }
        public V_TicketImprimir ObtenerTicketSalidayFinalizadoPorNumero(string numeroTicket)
        {
            V_TicketImprimir ticket = (from tick in bd.V_TicketImprimir
                                       where tick.TICKET == numeroTicket
                                       & ((tick.ESTADO.Equals("FINALIZADO"))
                                       || (tick.ESTADO.Equals("SALIDA")))
                                       select tick).Single();
            return ticket;
        }
        public int ObtenerIDPorNumeroTicket(string numeroTicket)
        {
            int ticket = (from tick in bd.V_TicketImprimir
                                       where tick.TICKET == numeroTicket
                                       select tick.ID).Single();
            return ticket;
        }
        public String ObtenerNumeroTicketPorID(int id)
        {
            string ticket = (from tick in bd.V_TicketImprimir
                          where tick.ID == id
                          select tick.TICKET).Single();
            return ticket;
        }
        public List<V_TicketImprimir> ObtenerTicketEnProceso()
        {
            try
            {
                 List<V_TicketImprimir> tickets = bd.V_TicketImprimir.Where(d => d.ESTADO.Equals("ENTRADA") || d.ESTADO.Equals("SALIDA")).OrderByDescending(d => d.ID).Take(100).ToList();
                 return tickets;
            }
            catch(Exception ex)
            {
                return null;
            }
            
            
        }
        public List<V_TicketImprimir> ObtenerTicketFinalizados()
        {
            try
            {
                List<V_TicketImprimir> tickets = bd.V_TicketImprimir.Where(d => d.ESTADO.Equals("FINALIZADO")).OrderByDescending(d => d.ID).Take(100).ToList();
                return tickets;
            }
            catch(Exception ex)
            {
                return null;
            }
        }
        
        public void GenerarPDF(string dest, int idIicket)
        {
            Document document = new Document();
            //PdfWriter.getInstance(document, new FileOutputStream(dest));
            PdfWriter writer = PdfWriter.GetInstance(document,
                                        new FileStream(dest, FileMode.Create));
            iTextSharp.text.Rectangle one = new iTextSharp.text.Rectangle(50, 180);
            iTextSharp.text.Rectangle two = new iTextSharp.text.Rectangle(700, 400);

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font font = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //document.SetPageSize(one);
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            document.SetMargins(20, 20, 20, 20);
            document.Open();

            V_TicketImprimir ticket = ObtenerTicketPorID(idIicket);
            Paragraph p = new Paragraph("TICKET#: " + ticket.TICKET, font);
            Paragraph p1 = new Paragraph("CODIGO PROVEEDOR: " + ticket.C_CODIGO_PROVEEDOR, font);
            Paragraph p2 = new Paragraph("RUC PROVEEDOR: " + ticket.RUC_PROVEEDOR, font);
            Paragraph p3 = new Paragraph("NOMBRE PROVEEDOR: " + ticket.NOMBRE_PROVEEDOR, font);
            Paragraph p4 = new Paragraph("CONDUCTOR: " + ticket.CONDUCTOR, font);
            Paragraph p5 = new Paragraph("VEHICULO: " + ticket.VEHICULO, font);
            Paragraph p6 = new Paragraph("N#GUÍA: " + ticket.N__GUIA, font);
            Paragraph p7 = new Paragraph("FECHA ENTRADA: " + ticket.FECHA_ENTRADA, font);
            Paragraph p8 = new Paragraph("FECHA SALIDA: " + ticket.FECHA_SALIDA, font);
            Paragraph p9 = new Paragraph("FORMA DE ENTREGA: " + ticket.FORMA_DE_ENTREGA, font);
            Paragraph p10 = new Paragraph("MATERIAL: " + ticket.MATERIAL, font);
            Paragraph p11 = new Paragraph("PESO ENTRADA: " + ticket.PESO_ENTRADA + "KG", font);
            Paragraph p12 = new Paragraph("PESO SALIDA: " + ticket.PESO_SALIDA + "KG", font);
            Paragraph p13 = new Paragraph("PESO BRUTO: " + ticket.PESO_BRUTO + "KG", font);
            Paragraph p14 = new Paragraph("%MUESTRA: " + ticket.C_MUESTRA, font);
            Paragraph p15 = new Paragraph("PESO IMPUREZAS: " + ticket.PESO_IMPUREZAS + "KG", font);
            Paragraph p16 = new Paragraph("PESO NO CONFORME: " + ticket.PESO_NO_CONFORME + "KG", font);
            Paragraph p17 = new Paragraph("PESO NETO: " + ticket.PESO_NETO + "KG", font);
            document.Add(p);
            document.Add(p1);
            document.Add(p2);
            document.Add(p3);
            document.Add(p4);
            document.Add(p5);
            document.Add(p6);
            document.Add(p7);
            document.Add(p8);
            document.Add(p9);
            document.Add(p10);
            document.Add(p11);
            document.Add(p12);
            document.Add(p13);
            document.Add(p14);
            document.Add(p15);
            document.Add(p16);
            document.Add(p17);
            //document.SetPageSize(two);
            //document.SetMargins(20, 20, 20, 20);
            //document.NewPage();
            //document.Add(p);
            document.Close();
        }

        public void GenerarPDF2(string dest, int idIicket)
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.A4);
            // Indicamos donde vamos a guardar el documento
            PdfWriter writer = PdfWriter.GetInstance(doc,
                            new FileStream(dest, FileMode.Create));



            // Abrimos el archivo
            doc.Open();


            // Creamos el tipo de Font que vamos utilizar
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);
            iTextSharp.text.Font negrita = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            iTextSharp.text.Font negritaGrande = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 10, iTextSharp.text.Font.BOLD, BaseColor.BLACK);
            var logo = Resources.logo_ecuamare;
            iTextSharp.text.Image jpg = iTextSharp.text.Image.GetInstance(logo, System.Drawing.Imaging.ImageFormat.Png);

            //Resize image depend upon your need

            jpg.ScaleToFit(140f, 120f);

            //Give space before image

            jpg.SpacingBefore = 10f;

            //Give some space after the image

            jpg.SpacingAfter = 1f;

            jpg.Alignment = Element.ALIGN_CENTER;

            //Escribimos el encabezamiento en el documento
            doc.Add(jpg);

            V_TicketImprimir ticket = ObtenerTicketPorID(idIicket);

            Paragraph Ruc = new Paragraph("RUC: 0993371900001", _standardFont);
            Ruc.Alignment = Element.ALIGN_CENTER;
            doc.Add(Ruc);
            Paragraph Direccion = new Paragraph("ELIAS GODOY 48 Y ELIAS OBANDO", _standardFont);
            Direccion.Alignment = Element.ALIGN_CENTER;
            doc.Add(Direccion);
            Paragraph Pais = new Paragraph("GUAYAQUIL-ECUADOR", _standardFont);
            Pais.Alignment = Element.ALIGN_CENTER;
            doc.Add(Pais);
            doc.Add(Chunk.NEWLINE);
            Paragraph NumeroTicket = new Paragraph("Ticket N#: "+ticket.TICKET, negritaGrande);
            NumeroTicket.Alignment = Element.ALIGN_CENTER;
            doc.Add(NumeroTicket);
            Paragraph FechaHora = new Paragraph("Fecha emisión: " + DateTime.Now.ToString(), negritaGrande);
            FechaHora.Alignment = Element.ALIGN_CENTER;
            doc.Add(FechaHora);


            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblProveedor = new PdfPTable(3);
            tblProveedor.WidthPercentage = 100;
            doc.Add(new Paragraph("Proveedor", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clProvCodigo = new PdfPCell(new Phrase("Codigo", _standardFont));
            clProvCodigo.BorderWidth = 0;
            clProvCodigo.BorderWidthBottom = 0.75f;

            PdfPCell clProvRUC = new PdfPCell(new Phrase("RUC", _standardFont));
            clProvRUC.BorderWidth = 0;
            clProvRUC.BorderWidthBottom = 0.75f;

            PdfPCell clProvNombre = new PdfPCell(new Phrase("Nombre", _standardFont));
            clProvNombre.BorderWidth = 0;
            clProvNombre.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblProveedor.AddCell(clProvCodigo);
            tblProveedor.AddCell(clProvRUC);
            tblProveedor.AddCell(clProvNombre);

            // Llenamos la tabla con información
            clProvCodigo = new PdfPCell(new Phrase(ticket.C_CODIGO_PROVEEDOR, _standardFont));
            clProvCodigo.BorderWidth = 0;

            clProvRUC = new PdfPCell(new Phrase(ticket.RUC_PROVEEDOR, _standardFont));
            clProvRUC.BorderWidth = 0;

            clProvNombre = new PdfPCell(new Phrase(ticket.NOMBRE_PROVEEDOR, _standardFont));
            clProvNombre.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblProveedor.AddCell(clProvCodigo);
            tblProveedor.AddCell(clProvRUC);
            tblProveedor.AddCell(clProvNombre);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblProveedor);



            PdfPTable tblTransportista = new PdfPTable(3);
            tblTransportista.WidthPercentage = 100;
            doc.Add(new Paragraph("Transportista", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clConductor = new PdfPCell(new Phrase("Conductor", _standardFont));
            clConductor.BorderWidth = 0;
            clConductor.BorderWidthBottom = 0.75f;

            PdfPCell clVehiculo = new PdfPCell(new Phrase("Vehículo", _standardFont));
            clVehiculo.BorderWidth = 0;
            clVehiculo.BorderWidthBottom = 0.75f;

            PdfPCell clGuia = new PdfPCell(new Phrase("N# Guía", _standardFont));
            clGuia.BorderWidth = 0;
            clGuia.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblTransportista.AddCell(clConductor);
            tblTransportista.AddCell(clVehiculo);
            tblTransportista.AddCell(clGuia);

            // Llenamos la tabla con información
            clConductor = new PdfPCell(new Phrase(ticket.CONDUCTOR, _standardFont));
            clConductor.BorderWidth = 0;

            clVehiculo = new PdfPCell(new Phrase(ticket.VEHICULO, _standardFont));
            clVehiculo.BorderWidth = 0;

            clGuia = new PdfPCell(new Phrase(ticket.N__GUIA, _standardFont));
            clGuia.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblTransportista.AddCell(clConductor);
            tblTransportista.AddCell(clVehiculo);
            tblTransportista.AddCell(clGuia);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblTransportista);


            PdfPTable tblEntrega = new PdfPTable(2);
            tblEntrega.WidthPercentage = 50;
            tblEntrega.HorizontalAlignment = Element.ALIGN_LEFT;
            //doc.Add(new Paragraph("Entrega", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clMaterial = new PdfPCell(new Phrase("Material", _standardFont));
            clMaterial.BorderWidth = 0;
            clMaterial.BorderWidthBottom = 0.75f;

            PdfPCell clForma = new PdfPCell(new Phrase("Forma de entrega", _standardFont));
            clForma.BorderWidth = 0;
            clForma.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            tblEntrega.AddCell(clMaterial);
            tblEntrega.AddCell(clForma);

            // Llenamos la tabla con información
            clMaterial = new PdfPCell(new Phrase(ticket.MATERIAL, _standardFont));
            clMaterial.BorderWidth = 0;

            clForma = new PdfPCell(new Phrase(ticket.FORMA_DE_ENTREGA, _standardFont));
            clForma.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEntrega.AddCell(clMaterial);
            tblEntrega.AddCell(clForma);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblEntrega);



            PdfPTable tblEntrada = new PdfPTable(2);
            tblEntrada.WidthPercentage = 50;
            tblEntrada.HorizontalAlignment = Element.ALIGN_LEFT;
            //doc.Add(new Paragraph("Entrada", negrita));
            // Configuramos el título de las columnas de la tabla

            PdfPCell clFechaEntrada = new PdfPCell(new Phrase("Fecha entrada", _standardFont));
            clFechaEntrada.BorderWidth = 0;
            clFechaEntrada.BorderWidthBottom = 0.75f;

            PdfPCell clPesoEntrada = new PdfPCell(new Phrase("Peso entrada", _standardFont));
            clPesoEntrada.BorderWidth = 0;
            clPesoEntrada.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblEntrada.AddCell(clFechaEntrada);
            tblEntrada.AddCell(clPesoEntrada);

            // Llenamos la tabla con información

            clFechaEntrada = new PdfPCell(new Phrase(ticket.FECHA_ENTRADA.ToString(), _standardFont));
            clFechaEntrada.BorderWidth = 0;

            clPesoEntrada = new PdfPCell(new Phrase(ticket.PESO_ENTRADA.ToString()+" KG", _standardFont));
            clPesoEntrada.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEntrada.AddCell(clFechaEntrada);
            tblEntrada.AddCell(clPesoEntrada);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblEntrada);


            PdfPTable tblSalida = new PdfPTable(2);
            tblSalida.WidthPercentage = 50;
            tblSalida.HorizontalAlignment = Element.ALIGN_LEFT;
            // doc.Add(new Paragraph("Salida", negrita));
            // Configuramos el título de las columnas de la tabla

            PdfPCell clFechaSalida = new PdfPCell(new Phrase("Fecha salida", _standardFont));
            clFechaSalida.BorderWidth = 0;
            clFechaSalida.BorderWidthBottom = 0.75f;

            PdfPCell clPesoSalida = new PdfPCell(new Phrase("Peso salida", _standardFont));
            clPesoSalida.BorderWidth = 0;
            clPesoSalida.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblSalida.AddCell(clFechaSalida);
            tblSalida.AddCell(clPesoSalida);

            // Llenamos la tabla con información

            clFechaSalida = new PdfPCell(new Phrase(ticket.FECHA_SALIDA.ToString(), _standardFont));
            clFechaSalida.BorderWidth = 0;

            clPesoSalida = new PdfPCell(new Phrase(ticket.PESO_SALIDA.ToString() + " KG", _standardFont));
            clPesoSalida.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblSalida.AddCell(clFechaSalida);
            tblSalida.AddCell(clPesoSalida);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblSalida);









            PdfPTable tblPesaje2 = new PdfPTable(3);
            tblPesaje2.WidthPercentage = 50;
            tblPesaje2.HorizontalAlignment = Element.ALIGN_LEFT;
            // Configuramos el título de las columnas de la tabla
            PdfPCell clPesoImpurezas = new PdfPCell(new Phrase("Peso Impurezas", _standardFont));
            clPesoImpurezas.BorderWidth = 0;
            clPesoImpurezas.BorderWidthBottom = 0.75f;

            PdfPCell clMuestra = new PdfPCell(new Phrase("%Muestra", _standardFont));
            clMuestra.BorderWidth = 0;
            clMuestra.BorderWidthBottom = 0.75f;

            PdfPCell clPesoNoConforme = new PdfPCell(new Phrase("Peso No Conforme", _standardFont));
            clPesoNoConforme.BorderWidth = 0;
            clPesoNoConforme.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPesaje2.AddCell(clPesoImpurezas);
            tblPesaje2.AddCell(clMuestra);
            tblPesaje2.AddCell(clPesoNoConforme);


            // Llenamos la tabla con información
            clPesoImpurezas = new PdfPCell(new Phrase(ticket.PESO_IMPUREZAS.ToString() + " KG", _standardFont));
            clPesoImpurezas.BorderWidth = 0;

            clMuestra = new PdfPCell(new Phrase(ticket.C_MUESTRA.ToString(), _standardFont));
            clMuestra.BorderWidth = 0;

            clPesoNoConforme = new PdfPCell(new Phrase(ticket.PESO_NO_CONFORME.ToString() + " KG", _standardFont));
            clPesoNoConforme.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPesaje2.AddCell(clPesoImpurezas);
            tblPesaje2.AddCell(clMuestra);
            tblPesaje2.AddCell(clPesoNoConforme);





            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPesaje2);


            PdfPTable tblPesajeFinal = new PdfPTable(2);
            tblPesajeFinal.WidthPercentage = 50;
            tblPesajeFinal.HorizontalAlignment = Element.ALIGN_LEFT;
            //doc.Add(new Paragraph("Pesaje", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clPesoBruto = new PdfPCell(new Phrase("Peso Bruto", _standardFont));
            clPesoBruto.BorderWidth = 0;
            clPesoBruto.BorderWidthBottom = 0.75f;

            PdfPCell clPesoNeto = new PdfPCell(new Phrase("Peso Neto", _standardFont));
            clPesoNeto.BorderWidth = 0;
            clPesoNeto.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            tblPesajeFinal.AddCell(clPesoBruto);
            tblPesajeFinal.AddCell(clPesoNeto);


            // Llenamos la tabla con información
            clPesoBruto = new PdfPCell(new Phrase(ticket.PESO_BRUTO.ToString() + " KG", _standardFont));
            clPesoBruto.BorderWidth = 0;

            clPesoNeto = new PdfPCell(new Phrase(ticket.PESO_NETO.ToString() + " KG", _standardFont));
            clPesoNeto.BorderWidth = 0;


            // Añadimos las celdas a la tabla
            tblPesajeFinal.AddCell(clPesoBruto);
            tblPesajeFinal.AddCell(clPesoNeto);






            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPesajeFinal);

            Paragraph linea = new Paragraph("_______________________________", _standardFont);
            linea.Alignment = Element.ALIGN_RIGHT;
            doc.Add(linea);
            Paragraph Recibido = new Paragraph("FIRMA RECIBIDO               ", _standardFont);
            Recibido.Alignment = Element.ALIGN_RIGHT;
            doc.Add(Recibido);






            Paragraph saltoDeLinea = new Paragraph("                                                                                                                                                                                                                                                                                                                                                                                   ");
            doc.Add(saltoDeLinea);




            iTextSharp.text.Image jpgC = iTextSharp.text.Image.GetInstance(logo, System.Drawing.Imaging.ImageFormat.Png);

            ////Resize image depend upon your need

            jpgC.ScaleToFit(140f, 120f);

            ////Give space before image

            jpgC.SpacingBefore = 10f;

            ////Give some space after the image

            //jpgC.SpacingAfter = 1f;

            jpgC.Alignment = Element.ALIGN_CENTER;

            // Escribimos el encabezamiento en el documento
            doc.Add(jpg);

            //Paragraph Ruc = new Paragraph("RUC: 0993371900001", _standardFont);
            //Ruc.Alignment = Element.ALIGN_CENTER;
            doc.Add(Ruc);
            //Paragraph Direccion = new Paragraph("ELIAS GODOY 48 Y ELIAS OBANDO", _standardFont);
            //Direccion.Alignment = Element.ALIGN_CENTER;
            doc.Add(Direccion);
            //Paragraph Pais = new Paragraph("QUITO-ECUADOR", _standardFont);
            //Pais.Alignment = Element.ALIGN_CENTER;
            doc.Add(Pais);
            doc.Add(Chunk.NEWLINE);
            //Paragraph NumeroTicket = new Paragraph("Ticket N#: " + ticket.TICKET, negritaGrande);
            //NumeroTicket.Alignment = Element.ALIGN_CENTER;
            doc.Add(NumeroTicket);
            //Paragraph FechaHora = new Paragraph("Fecha emisión: " + DateTime.Now.ToString(), negritaGrande);
            //FechaHora.Alignment = Element.ALIGN_CENTER;
            doc.Add(FechaHora);

            doc.Add(Chunk.NEWLINE);

            // Creamos una tabla que contendrá el nombre, apellido y país
            // de nuestros visitante.
            PdfPTable tblProveedorC = new PdfPTable(3);
            tblProveedorC.WidthPercentage = 100;
            doc.Add(new Paragraph("Proveedor", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clProvCodigoC = new PdfPCell(new Phrase("Codigo", _standardFont));
            clProvCodigoC.BorderWidth = 0;
            clProvCodigoC.BorderWidthBottom = 0.75f;

            PdfPCell clProvRUCC = new PdfPCell(new Phrase("RUC", _standardFont));
            clProvRUCC.BorderWidth = 0;
            clProvRUCC.BorderWidthBottom = 0.75f;

            PdfPCell clProvNombreC = new PdfPCell(new Phrase("Nombre", _standardFont));
            clProvNombreC.BorderWidth = 0;
            clProvNombreC.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblProveedorC.AddCell(clProvCodigoC);
            tblProveedorC.AddCell(clProvRUCC);
            tblProveedorC.AddCell(clProvNombreC);

            // Llenamos la tabla con información
            clProvCodigoC = new PdfPCell(new Phrase(ticket.C_CODIGO_PROVEEDOR, _standardFont));
            clProvCodigoC.BorderWidth = 0;

            clProvRUCC = new PdfPCell(new Phrase(ticket.RUC_PROVEEDOR, _standardFont));
            clProvRUCC.BorderWidth = 0;

            clProvNombreC = new PdfPCell(new Phrase(ticket.NOMBRE_PROVEEDOR, _standardFont));
            clProvNombreC.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblProveedorC.AddCell(clProvCodigoC);
            tblProveedorC.AddCell(clProvRUCC);
            tblProveedorC.AddCell(clProvNombreC);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblProveedorC);



            PdfPTable tblTransportistaC = new PdfPTable(3);
            tblTransportistaC.WidthPercentage = 100;
            doc.Add(new Paragraph("Transportista", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clConductorC = new PdfPCell(new Phrase("Conductor", _standardFont));
            clConductorC.BorderWidth = 0;
            clConductorC.BorderWidthBottom = 0.75f;

            PdfPCell clVehiculoC = new PdfPCell(new Phrase("Vehículo", _standardFont));
            clVehiculoC.BorderWidth = 0;
            clVehiculoC.BorderWidthBottom = 0.75f;

            PdfPCell clGuiaC = new PdfPCell(new Phrase("N# Guía", _standardFont));
            clGuiaC.BorderWidth = 0;
            clGuiaC.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblTransportistaC.AddCell(clConductorC);
            tblTransportistaC.AddCell(clVehiculoC);
            tblTransportistaC.AddCell(clGuiaC);

            // Llenamos la tabla con información
            clConductorC = new PdfPCell(new Phrase(ticket.CONDUCTOR, _standardFont));
            clConductorC.BorderWidth = 0;

            clVehiculoC = new PdfPCell(new Phrase(ticket.VEHICULO, _standardFont));
            clVehiculoC.BorderWidth = 0;

            clGuiaC = new PdfPCell(new Phrase(ticket.N__GUIA, _standardFont));
            clGuiaC.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblTransportistaC.AddCell(clConductorC);
            tblTransportistaC.AddCell(clVehiculoC);
            tblTransportistaC.AddCell(clGuiaC);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblTransportistaC);


            PdfPTable tblEntregaC = new PdfPTable(2);
            tblEntregaC.WidthPercentage = 50;
            tblEntregaC.HorizontalAlignment = Element.ALIGN_LEFT;
            //doc.Add(new Paragraph("Entrega", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clMaterialC = new PdfPCell(new Phrase("Material", _standardFont));
            clMaterialC.BorderWidth = 0;
            clMaterialC.BorderWidthBottom = 0.75f;

            PdfPCell clFormaC = new PdfPCell(new Phrase("Forma de entrega", _standardFont));
            clFormaC.BorderWidth = 0;
            clFormaC.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            tblEntregaC.AddCell(clMaterialC);
            tblEntregaC.AddCell(clFormaC);

            // Llenamos la tabla con información
            clMaterialC = new PdfPCell(new Phrase(ticket.MATERIAL, _standardFont));
            clMaterialC.BorderWidth = 0;

            clFormaC = new PdfPCell(new Phrase(ticket.FORMA_DE_ENTREGA, _standardFont));
            clFormaC.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEntregaC.AddCell(clMaterialC);
            tblEntregaC.AddCell(clFormaC);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblEntregaC);



            PdfPTable tblEntradaC = new PdfPTable(2);
            tblEntradaC.WidthPercentage = 50;
            tblEntradaC.HorizontalAlignment = Element.ALIGN_LEFT;
            //doc.Add(new Paragraph("Entrada", negrita));
            // Configuramos el título de las columnas de la tabla

            PdfPCell clFechaEntradaC = new PdfPCell(new Phrase("Fecha entrada", _standardFont));
            clFechaEntradaC.BorderWidth = 0;
            clFechaEntradaC.BorderWidthBottom = 0.75f;

            PdfPCell clPesoEntradaC = new PdfPCell(new Phrase("Peso entrada", _standardFont));
            clPesoEntradaC.BorderWidth = 0;
            clPesoEntradaC.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblEntradaC.AddCell(clFechaEntradaC);
            tblEntradaC.AddCell(clPesoEntradaC);

            // Llenamos la tabla con información

            clFechaEntradaC = new PdfPCell(new Phrase(ticket.FECHA_ENTRADA.ToString(), _standardFont));
            clFechaEntradaC.BorderWidth = 0;

            clPesoEntradaC = new PdfPCell(new Phrase(ticket.PESO_ENTRADA.ToString() + " KG", _standardFont));
            clPesoEntradaC.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblEntradaC.AddCell(clFechaEntradaC);
            tblEntradaC.AddCell(clPesoEntradaC);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblEntradaC);


            PdfPTable tblSalidaC = new PdfPTable(2);
            tblSalidaC.WidthPercentage = 50;
            tblSalidaC.HorizontalAlignment = Element.ALIGN_LEFT;
            // doc.Add(new Paragraph("Salida", negrita));
            // Configuramos el título de las columnas de la tabla

            PdfPCell clFechaSalidaC = new PdfPCell(new Phrase("Fecha salida", _standardFont));
            clFechaSalidaC.BorderWidth = 0;
            clFechaSalidaC.BorderWidthBottom = 0.75f;

            PdfPCell clPesoSalidaC = new PdfPCell(new Phrase("Peso salida", _standardFont));
            clPesoSalidaC.BorderWidth = 0;
            clPesoSalidaC.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblSalidaC.AddCell(clFechaSalidaC);
            tblSalidaC.AddCell(clPesoSalidaC);

            // Llenamos la tabla con información

            clFechaSalidaC = new PdfPCell(new Phrase(ticket.FECHA_SALIDA.ToString(), _standardFont));
            clFechaSalidaC.BorderWidth = 0;

            clPesoSalidaC = new PdfPCell(new Phrase(ticket.PESO_SALIDA.ToString() + " KG", _standardFont));
            clPesoSalidaC.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblSalidaC.AddCell(clFechaSalidaC);
            tblSalidaC.AddCell(clPesoSalidaC);




            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblSalidaC);









            PdfPTable tblPesaje2C = new PdfPTable(3);
            tblPesaje2C.WidthPercentage = 50;
            tblPesaje2C.HorizontalAlignment = Element.ALIGN_LEFT;
            // Configuramos el título de las columnas de la tabla
            PdfPCell clPesoImpurezasC = new PdfPCell(new Phrase("Peso Impurezas", _standardFont));
            clPesoImpurezasC.BorderWidth = 0;
            clPesoImpurezasC.BorderWidthBottom = 0.75f;

            PdfPCell clMuestraC = new PdfPCell(new Phrase("%Muestra", _standardFont));
            clMuestraC.BorderWidth = 0;
            clMuestraC.BorderWidthBottom = 0.75f;

            PdfPCell clPesoNoConformeC = new PdfPCell(new Phrase("Peso No Conforme", _standardFont));
            clPesoNoConformeC.BorderWidth = 0;
            clPesoNoConformeC.BorderWidthBottom = 0.75f;

            // Añadimos las celdas a la tabla
            tblPesaje2C.AddCell(clPesoImpurezasC);
            tblPesaje2C.AddCell(clMuestraC);
            tblPesaje2C.AddCell(clPesoNoConformeC);


            // Llenamos la tabla con información
            clPesoImpurezasC = new PdfPCell(new Phrase(ticket.PESO_IMPUREZAS.ToString() + " KG", _standardFont));
            clPesoImpurezasC.BorderWidth = 0;

            clMuestraC = new PdfPCell(new Phrase(ticket.C_MUESTRA.ToString(), _standardFont));
            clMuestraC.BorderWidth = 0;

            clPesoNoConformeC = new PdfPCell(new Phrase(ticket.PESO_NO_CONFORME.ToString() + " KG", _standardFont));
            clPesoNoConformeC.BorderWidth = 0;

            // Añadimos las celdas a la tabla
            tblPesaje2C.AddCell(clPesoImpurezasC);
            tblPesaje2C.AddCell(clMuestraC);
            tblPesaje2C.AddCell(clPesoNoConformeC);





            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPesaje2C);


            PdfPTable tblPesajeFinalC = new PdfPTable(2);
            tblPesajeFinalC.WidthPercentage = 50;
            tblPesajeFinalC.HorizontalAlignment = Element.ALIGN_LEFT;
            //doc.Add(new Paragraph("Pesaje", negrita));
            // Configuramos el título de las columnas de la tabla
            PdfPCell clPesoBrutoC = new PdfPCell(new Phrase("Peso Bruto", _standardFont));
            clPesoBrutoC.BorderWidth = 0;
            clPesoBrutoC.BorderWidthBottom = 0.75f;

            PdfPCell clPesoNetoC = new PdfPCell(new Phrase("Peso Neto", _standardFont));
            clPesoNetoC.BorderWidth = 0;
            clPesoNetoC.BorderWidthBottom = 0.75f;


            // Añadimos las celdas a la tabla
            tblPesajeFinalC.AddCell(clPesoBrutoC);
            tblPesajeFinalC.AddCell(clPesoNetoC);


            // Llenamos la tabla con información
            clPesoBrutoC = new PdfPCell(new Phrase(ticket.PESO_BRUTO.ToString() + " KG", _standardFont));
            clPesoBrutoC.BorderWidth = 0;

            clPesoNetoC = new PdfPCell(new Phrase(ticket.PESO_NETO.ToString() + " KG", _standardFont));
            clPesoNetoC.BorderWidth = 0;


            // Añadimos las celdas a la tabla
            tblPesajeFinalC.AddCell(clPesoBrutoC);
            tblPesajeFinalC.AddCell(clPesoNetoC);





            // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
            doc.Add(tblPesajeFinalC);
            doc.Add(linea);
            doc.Add(Recibido);











            doc.Close();
            writer.Close();
        }

    }
}
