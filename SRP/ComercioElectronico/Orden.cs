using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;

namespace ComercioElectronico
{
    public class Orden
    {
        public void ConfirmarCompra(Carrito carrito, DetallesDePago detallesDePago, bool notificarCliente)
        {
            if (detallesDePago.MetodoDePago == MetodoDePago.TarjetaDeCredito)
            {
                CargarTarjeta(detallesDePago, carrito);
            }

            ReservarInventario(carrito);

            if (notificarCliente)
            {
                NotificarCliente(carrito);
            }
        }

        private void NotificarCliente(Carrito carrito)
        {
            string emailCliente = carrito.EmailCliente;
            if (!String.IsNullOrEmpty(emailCliente) 
                && emailCliente.Contains("@"))
            {
                using (var mensaje = new MailMessage("noreply@misitio.com", emailCliente))
                using (var smtp = new SmtpClient("localhost"))
                {
                    mensaje.Subject = "Su orden se grabo el " + DateTime.Now.ToString();
                    mensaje.Body = "Los detalles de su orden son: " + carrito.ToString();

                    try
                    {
                        smtp.Send(mensaje);
                    }
                    catch (Exception ex)
                    {
                        Logger.Error("Ocurrio un problema enviando la notificacion", ex);
                    }
                }
            }
        }

        private void ReservarInventario(Carrito carrito)
        {
            // Reservar inventario en el 
            // Sistema de Manejo de Inventarios
        }

        private void CargarTarjeta(DetallesDePago detallesDePago, Carrito carrito)
        {
            // Consumir el servicio de pagos 
            // por tarjeta de credito
        }
    }
}
