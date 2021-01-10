using System;
using System.Text;

using System.Net;
using System.Net.Sockets;
using System.Threading;



namespace tienda2.clases
{
    /*
    class si_como_se_usaba_info_entrada_salida
    {
    }

    class modelo_sockets_r
    {
        public void sevidor_modelo()
        {
            servidor_r serv = new servidor_r();
            serv.servidor("localhost", 4404);
            serv.iniciar();
        }

        public void cliente_modelo()
        {
            cliente_r cliente = new cliente_r();
            cliente.cliente("localhost", 4404); 
            string usuario, contraseña;
            

            cliente.iniciar();

            string mensaje;

            while (true)
            {
                
                
                Console.WriteLine("ingrese el mensaje a enviar: ");
                mensaje=Console.ReadLine();
                cliente.enviar(mensaje);
                

                Console.WriteLine("ingrese el usuario: ");
                usuario = Console.ReadLine();
                cliente.enviar(usuario);

                Console.WriteLine("ingrese la contraseña: ");
                contraseña = Console.ReadLine();
                cliente.enviar(contraseña);

                Console.WriteLine("el estado del loguin es: {0}", cliente.recibir() );
                
                

                
                

            }

        }
    }

    class servidor_r
    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        Socket s_servidor;
        Socket s_cliente;

        public void servidor(string ip, int port)
        {
            //host = Dns.GetHostByName(ip);
            host = Dns.GetHostEntry(ip);
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr, port);
            s_servidor = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_servidor.Bind(endPoint);
            s_servidor.Listen(10);
        }


        public void iniciar()
        {
            Thread hilo;
            while (true)
            {
                Console.WriteLine("conecciones... \n");
                s_cliente = s_servidor.Accept();
                hilo = new Thread(coneccion_cliente);
                hilo.Start(s_cliente);
                Console.WriteLine("se a conectado un cliente ");
            }
        }


        public void coneccion_cliente(object s)
        {
            Socket s_client = (Socket)s;

            byte[] buffer;
            string usuario, contraseña;
            string mensaje;

            try
            {

                while (true)
                {
                    
                    
                    buffer = new byte[1024];
                    s_cliente.Receive(buffer);
                    mensaje = convierte_de_byte_a_string(buffer);
                    Console.WriteLine("se recivio el mensaje: " + mensaje);
                    Console.Out.Flush();
                   

                    buffer = new byte[1024];
                    s_cliente.Receive(buffer);
                    usuario = convierte_de_byte_a_string(buffer);

                    buffer = new byte[1024];
                    s_cliente.Receive(buffer);
                    contraseña = convierte_de_byte_a_string(buffer);

                    if (usuario == "admin" && contraseña == "admin")
                    {
                        byte[] responder = Encoding.ASCII.GetBytes("logueado");
                        s_client.Send(responder);
                    }
                    else
                    {
                        byte[] responder = Encoding.ASCII.GetBytes("error");
                        s_client.Send(responder);
                    }
                }
            }
            catch (SocketException se)
            {
                Console.WriteLine("se a desconectado un cliente: {0}", se.Message);
            }



        }

        public string convierte_de_byte_a_string(byte[] buffer)
        {
            string mensaje;
            int end_index;
            mensaje = Encoding.ASCII.GetString(buffer);
            end_index = mensaje.IndexOf('\0');
            if (end_index > 0)
            {
                mensaje = mensaje.Substring(0, end_index);
            }
            return mensaje;
        }

    }

    class cliente_r
    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;


        Socket s_cliente;

        public void cliente(string ip, int port)
        {
            //host = Dns.GetHostByName(ip);
            host = Dns.GetHostEntry(ip);
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr, port);
            s_cliente = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);

        }

        public void iniciar()
        {
            s_cliente.Connect(endPoint);
        }

        public void enviar(string mensaje)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(mensaje);
            s_cliente.Send(bytes);
            Console.WriteLine("se envio: " + mensaje);
        }


        public string recibir()
        {
            byte[] buffer = new byte[1024];
            s_cliente.Receive(buffer);
            return combierte_de_byte_a_string(buffer);

        }

        public string combierte_de_byte_a_string(byte[] buffer)
        {
            string mensaje;
            int end_index;
            mensaje = Encoding.ASCII.GetString(buffer);
            end_index = mensaje.IndexOf('\0');
            if (end_index > 0)
            {
                mensaje = mensaje.Substring(0, end_index);
            }
            return mensaje;
        }

    }

*/

}
