namespace FinControl.Domain.Entities;

public abstract class BaseEntity
{
    public Guid Id { get; set; } = Guid.CreateVersion7();
    public DateTime CreatedAtUtc { get; set; }
    public DateTime? UpdatedAtUtc { get; set; }
    public bool IsDeleted { get; set; }
}
