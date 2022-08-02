﻿using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;

namespace ControleDeContatos.Data
{
    public class BancoContext : DbContext
    {

        public BancoContext(DbContextOptions<BancoContext> option) : base(option)
        { }

        public DbSet<ContatoModel> Contatos
        {
            get; set;
        }
    }
}
