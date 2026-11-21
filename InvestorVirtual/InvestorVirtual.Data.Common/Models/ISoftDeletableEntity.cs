namespace InvestorVirtual.Data.Common.Models;

public interface ISoftDeletableEntity
{
    public bool IsDeleted { get; set; }
}