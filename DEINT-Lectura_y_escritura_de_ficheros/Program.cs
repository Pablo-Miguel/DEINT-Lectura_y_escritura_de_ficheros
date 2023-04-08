// See https://aka.ms/new-console-template for more information

String ruta = "C:\\Users\\Dam\\Downloads\\pruebaLectura.txt";
String resultado = File.ReadAllText(ruta);

var lineas = File.ReadAllLines(ruta);

File.Copy(ruta, ruta, true);
File.Delete(ruta);

Directory.Delete(ruta);
Directory.CreateDirectory(ruta);
var rutas = Directory.EnumerateDirectories(ruta);
foreach (var rutaEnum in rutas)
{

}

var rutas2 = Directory.EnumerateDirectories(ruta, "*", SearchOption.AllDirectories);
var ficheros = Directory.EnumerateFiles(ruta, "*.jpg", SearchOption.AllDirectories);

DirectoryInfo directorio = new DirectoryInfo(ruta);

var extension = Path.GetExtension(ruta);
var nombre = Path.GetFileName(ruta);
var rutaCombinada = Path.Combine(ruta, ruta);

FileInfo fichero = new FileInfo(ruta);
fichero.FullName();
fichero.Name();

using (StreamReader sr = new StreamReader(ruta)) { 

}
using (StreamWriter sw = new StreamWriter(ruta)) { 

}

StreamReader sr2 = new StreamReader(ruta);
StreamWriter sw2 = new StreamWriter(ruta);

sw2.WriteLine("Hola");
sr2.ReadLine();

sw2.Dispose();
sr2.Dispose();
