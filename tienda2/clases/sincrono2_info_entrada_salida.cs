using System;
using System.Text;

using System.Net;
using System.Net.Sockets;

using System.Threading;

using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Reflection;



namespace tienda2.clases
{
    //si quieres usar esta clase tienes que eliminar o poner en comentarios si_como_se_usaba_info_entrada_salida
    //por que sino marcara error

    /*
    //usar el modelo para que no aya errores
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
            user usua;

            cliente.iniciar();

            while (true)
            {
                Console.WriteLine("ingrese el usuario: ");
                usuario = Console.ReadLine();


                Console.WriteLine("ingrese la contraseña: ");
                contraseña = Console.ReadLine();

                usua = new user(usuario, contraseña);
                cliente.enviar_objeto(usua);

                Console.WriteLine("el estado del loguin es: {0}", cliente.recibir());

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

            user usuario;
            try
            {

                while (true)
                {
                    
                    buffer = new byte[1024];
                    s_cliente.Receive(buffer);
                    usuario = (user)serialisasion_info_entrada_salida.deserialisacion(buffer);


                    if (usuario.usuario == "admin" && usuario.contraseña == "admin")
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

        public void enviar_objeto(object a_enviar)
        {

            s_cliente.Send(serialisasion_info_entrada_salida.serialisacion(a_enviar));
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

    class serialisasion_info_entrada_salida
    {
        public static byte[] serialisacion(object a_serialisar)
        {
            MemoryStream memory = new MemoryStream();
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Serialize(memory, a_serialisar);

            return memory.ToArray();
        }

        public static object deserialisacion(byte[] a_deserialisar)
        {
            MemoryStream memory = new MemoryStream(a_deserialisar);
            BinaryFormatter formatter = new BinaryFormatter();

            formatter.Binder = new CurrentAssemblyDeserializationBinder();

            return formatter.Deserialize(memory);
        }
    }

    public class CurrentAssemblyDeserializationBinder : SerializationBinder
    {
        public override Type BindToType(string assemblyName, string typeName)
        {
            return Type.GetType(String.Format("{0}, {1}", typeName, Assembly.GetExecutingAssembly().FullName));
        }
    }

    [Serializable]
    class user
    {
        public string usuario, contraseña;

        public user(string _usuario, string _contraseña)
        {
            this.usuario = _usuario;
            this.contraseña = _contraseña;
        }
    }
*/
}


