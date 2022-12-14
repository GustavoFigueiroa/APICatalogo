﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APICatalogo.Migrations
{
    public partial class PopulaProdutos : Migration
    {
        protected override void Up(MigrationBuilder mb)
        {
            mb.Sql("Insert into produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " + "Values('Coca-Cola Diet','Refrigerante de Cola 350ml','5.45','cocacola.jpg',50,now(),2)");

            mb.Sql("Insert into produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " + "Values('Lanche de Atum','Lanche de Atum com maionese','8.50','atum.jpg',10,now(),3)");

            mb.Sql("Insert into produtos(Nome,Descricao,Preco,ImagemUrl,Estoque,DataCadastro,CategoriaId) " + "Values('Pudim 100 g','Pudim de leite condensado 100g','6.75','pudim.jpg',20,now(),4)");
        }

        protected override void Down(MigrationBuilder mb)
        {
            mb.Sql("Delete from produtos");
        }
    }
}
