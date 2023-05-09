namespace MappersBenchmark.Models.DTO;

public class BoxOfficeDto
{
    public Guid Id { get; set; }
    public long BudgetValue { get; set; }
    public long IncomesTotal { get; set; }
    public long CastSalaryTotal { get; set; }
    public long PostProductionTotal { get; set; }
    public long CinemaIncomes { get; set; }
    public long VODIncomes { get; set; }
    public long BlueRayIncomes { get; set; }
}
