namespace FornecedorAPI.Models
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public bool Ativo { get; set; } = true;

        public BaseEntity()
        {
            Id = new Guid();
        }
    }
}
