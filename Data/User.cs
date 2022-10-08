using System;

namespace ArthurCrivilinDelCaro_d7_avaliacao.Data;

public class User
{
    public Guid Id { get; set; }

    public string Email { get; set; } = string.Empty;

    public string Password { get; set; } = string.Empty;
}
