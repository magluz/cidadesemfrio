using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public static class Pessoas
{
    public string Usuario;
    public string Senha;
    public string Email;
    public List<string> Cidade; 

    public Pessoas(string _usuario, string _senha, string _Email, List<string> _cidade )
    {
        Usuario = _usuario;
        Senha = _senha;
        Email = _email;
        Cidade = _cidade; 
    }
}

