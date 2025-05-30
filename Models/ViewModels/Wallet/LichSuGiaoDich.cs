using System.Transactions;

public enum LoaiGiaoDich
{
    Nạp,
    Rút
}
public class LichSuGiaoDich
{
    public LoaiGiaoDich Loai { get; set; }
    public decimal SoTien { get; set; }
    public DateTime Time { get; set; }
}