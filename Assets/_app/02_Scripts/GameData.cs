using SQLite;

public class GameData
{
    [PrimaryKey, AutoIncrement]
    public int SaveSlotId { get; set; }

    public float Hambre { get; set; }
    public float Sueno { get; set; }
    public float Higiene { get; set; }
    public float Diversion { get; set; }

    public int Monedas { get; set; }

    public string UltimaFechaGuardado { get; set; }
}
