namespace BookStore.Core.Common
{
    public interface IDeletable
    {
        bool IsDeleted { get; set; }
        DateTime? DeletedAt { get; set; }

    }
}
