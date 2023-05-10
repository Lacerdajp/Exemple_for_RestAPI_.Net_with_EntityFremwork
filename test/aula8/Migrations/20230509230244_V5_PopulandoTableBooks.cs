﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace aula8.Migrations
{
    /// <inheritdoc />
    public partial class V5_PopulandoTableBooks : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("" +
               "Insert into books(autor,titulo,valor,data) values('Joao','Jovens Sarados',50.0,'2020-11-04 00:00:00' );" +
               "Insert into books(autor,titulo,valor,data)values('Henrique','Rome sweet Home',90.0,'2015-05-07 00:00:00' );" +
               "Insert into books(autor,titulo,valor,data)values('Isabela','Love so love',120.0,'2004-09-15 00:00:00');" +
               "Insert into books(autor,titulo,valor,data)values('Dayane','Fisioterapia por amor',40.0,'2015-09-07 00:00:00' );");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
