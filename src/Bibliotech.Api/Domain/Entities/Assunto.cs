namespace Bibliotech.Api.Domain.Entities;

public class Assunto : Entity
{
   public string Descricao{ get; set; }
   public string Status { get; private set; }

}