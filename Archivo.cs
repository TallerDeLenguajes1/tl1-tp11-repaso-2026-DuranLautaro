using System.Text.Json.Serialization;

namespace Archivos;
public class Reporte
{
    private string? nombre;
    private double valortotalstock;
    private bool necesitarepo;

    public string? Nombre { get => nombre; set => nombre = value; }
    public double ValorTotalStock { get => valortotalstock; set => valortotalstock = value; }
    public bool NecesitaRepo { get => necesitarepo; set => necesitarepo = value; }
}
public class Archivo
{
    private int id;
    private string? nombre;
    private double precio;
    private int stock;
    private string? categoria;
    private double valortotalstock;
    private bool necesitarepo;

    [JsonPropertyName("Id")]
    public int Id { get => id; set => id = value; }
    [JsonPropertyName("Nombre")]
    public string? Nombre { get => nombre; set => nombre = value; }
     [JsonPropertyName("Precio")]
    public double Precio { get => precio; set => precio = value; }
     [JsonPropertyName("Stock")]
    public int Stock { get => stock; set => stock = value; }
     [JsonPropertyName("Categoria")]
    public string? Categoria { get => categoria; set => categoria = value; }
    public double ValorTotalStock { get => valortotalstock; set => valortotalstock = value; }
    public bool NecesitaRepo { get => necesitarepo; set => necesitarepo = value; }
    //metodo para calcular los datos
    public void Calcular()
    {
        valortotalstock=precio*stock;
        if(stock<3)
        {
            necesitarepo=true;
        }
        else
        {
            necesitarepo=false;
        }
    }
    
}
