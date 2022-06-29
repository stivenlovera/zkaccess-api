using System.Runtime.InteropServices;
namespace zktco_access.sdkZkteco
{
    public class zkControlador
    {
        //arrancador 
        IntPtr h = IntPtr.Zero;
        //instanciando como  libreria externa
        [DllImport("./SDK/plcommpro.dll", EntryPoint = "Connect")]
        public static extern IntPtr Connect(string Parameters);

        //get user 
        [DllImport("./SDK/plcommpro.dll", EntryPoint = "GetDeviceData")]
        public static extern int GetDeviceData(IntPtr h, ref byte buffer, int buffersize, string tablename, string filename, string filter, string options);
        [DllImport("./SDK/plcommpro.dll", EntryPoint = "PullLastError")]
        public static extern int PullLastError();
        public bool conexion_controller(string protocolo, string ipaddress, string port, string timeout, string passwd)
        {
            string cadena = "protocol=" + protocolo + ",ipaddress=" + ipaddress + ",port=" + port + ",timeout=" + timeout + ",passwd=" + passwd;
            Console.WriteLine("test de conexion"+cadena);
            h = Connect(cadena);
            if (h != IntPtr.Zero)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
