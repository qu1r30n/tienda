using System;
using System.Text;
using System.Net;
using System.Net.Sockets;


namespace tienda2
{
    class servidor_r
    {
        IPHostEntry host;
        IPAddress ipAddr;
        IPEndPoint endPoint;

        Socket s_servidor;
        Socket s_cliente;

        public void server(string ip,int port)
        {
            //host = Dns.GetHostByName(ip);
            host = Dns.GetHostEntry(ip);
            ipAddr = host.AddressList[0];
            endPoint = new IPEndPoint(ipAddr,port);
            s_servidor = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            s_servidor.Bind(endPoint);
            s_servidor.Listen(10);
        }


        public void iniciar()
        {
            byte[] bufer = new byte[1024];
            string mensaje;
            s_cliente = s_servidor.Accept();
            s_cliente.Receive(bufer);

            mensaje = Encoding.ASCII.GetString(bufer);
            Console.WriteLine("se recivio el mensaje: " + mensaje);
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

        public void start()
        {
            s_cliente.Connect(endPoint);
        }

        public void send(string mensaje)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(mensaje);
            s_cliente.Send(bytes);
            Console.WriteLine("se envio: " + mensaje);
        }
    }


    class modelo_sockets_r
    {
        public void cliente_modelo()
        {
            cliente_r cliente = new cliente_r();
            cliente.cliente("localhost", 4404);
            cliente.start();
            cliente.send("hola mundo soy el cliente");

        }

        public void sevidor_modelo()
        {
            servidor_r serv = new servidor_r();
            serv.server("localhost", 4404);
            serv.iniciar();
        }
    }

}