using System.Text.Json;
using Archivos;
//en el caso de que el archivo se encuentre en otro lugar
/*string rutaArchivo = @"C:\Users\TuUsuario\Desktop\productos1.json";
string cuerpo = File.ReadAllText(rutaArchivo);*/
string archivo="productos1.json";
string cuerpo=File.ReadAllText(archivo); //PUNTO 1:leo el archivo
Console.WriteLine(cuerpo); //muestro lo que hay dentro del archivo json
//PUNTO 2
List<Archivo>? listarchivo=JsonSerializer.Deserialize<List<Archivo>>(cuerpo); //toma el texto JSON y lo convierte en una lista de objetos Tarea, usando la clase Tarea que definimos antes.
//Console.WriteLine(listarchivo[0].Nombre);
//Nueva lista para filtrar los resultados
List<Reporte>? nuevaLista= new List<Reporte>();
foreach(var A in listarchivo)
{
    //PUNTO 3
    A.Calcular();
    Console.WriteLine($"Id:{A.Id}-Nombre:{A.Nombre}-Precio:{A.Precio}-Stock:{A.Stock}-Categoria:{A.Categoria}-Valor de un producto:{A.ValorTotalStock}-Necesita Reposicion:{A.NecesitaRepo}");
    //PUNTO 4
    //Creo una instancia de clase para guardar los items Nombre, valortotalstock y Necesitorepo
    //Luego filtramos
    Reporte item=new Reporte();
    item.Nombre=A.Nombre;
    item.ValorTotalStock=A.ValorTotalStock;
    item.NecesitaRepo=A.NecesitaRepo;
    nuevaLista.Add(item);
}
//PUNTO 5
string Serializar=JsonSerializer.Serialize(nuevaLista);//convierte la lista de objetos Reporte a un string JSON
File.WriteAllText("Reporte.json",Serializar);//crea un archivo Reporte.json y luego escribe lo guardado en serializar 
