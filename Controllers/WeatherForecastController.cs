using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices;
using System;

namespace testAsp.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    //arrancador 
    IntPtr h = IntPtr.Zero;
    //instanciando como  libreria externa
    [DllImport("SDK/plcommpro.dll", EntryPoint = "Connect")]
    public static extern IntPtr Connect(string Parameters);

    //get user 
    [DllImport("SDK/plcommpro.dll", EntryPoint = "GetDeviceData")]
    public static extern int GetDeviceData(IntPtr h, ref byte buffer, int buffersize, string tablename, string filename, string filter, string options);
    [DllImport("SDK/plcommpro.dll", EntryPoint = "PullLastError")]
    public static extern int PullLastError();
    // variables
    public string protocolo = "TCP";
    public string ipaddress = "192.168.88.10";
    public string port = "4370";
    public string timeout = "2000";
    public string passwd = "";
    private bool conexion_controller()
    {
        string cadena = "protocol=" + protocolo + ",ipaddress=" + ipaddress + ",port=" + port + ",timeout=" + timeout + ",passwd=" + passwd;

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
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public string Get()
    {
        if (this.conexion_controller())
        {
            return "conectado";
        }
        else
        {
            return "erro";
        }
    }
}
