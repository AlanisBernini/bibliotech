﻿namespace Bibliotech.Api.Domain.Entities;

public class Livro: Entity
{
    public string Titulo { get; set; }
    public string ISBN { get; set; }
    public string Editora{ get; set; }
    public int AnoPublicação { get; set; }
    public int AssuntoId { get; set; }
    public int AutorId { get; set; }
}



