public class ApiClass
{
    public string name { get; set; } = "";
    public string contact { get; set; } = "";
}

public class ResponseData
{
    public string Message { get; set; } = "";
    public int ResponseCode { get; set; }
}

public class Comercios
{
    public string Nombre { get; set; } = "";
    public int Giro { get; set; } =1;
    public string UrlWeb { get; set; } = "";
    public string UrlFacebook { get; set; } = "";
}

public class Promociones
{
    public long? Id { get; set; }
    public string Descripcion { get; set; } = "";
    public string Restricciones { get; set; } = "";
    public string FechaInicioVigencia { get; set; } = "";
    public string FechaFinVigencia { get; set; } = "";
    public string Message { get; set; } = "";
    public int ResponseCode { get; set; }
}
public class IdPromocion
{
    public long Id { get; set; }

}

public class Sucursales
{
    public string Calle { get; set; } = "";
    public int Numero { get; set; }
    public string Colonia { get; set; } = "";
    public string Municipio { get; set; } = "";
    public string CP { get; set; } = "";
    public double Latitud { get; set; }
    public double Longitud { get; set; }
    public string Telefono { get; set;}

}
