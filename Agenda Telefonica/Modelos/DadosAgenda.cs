using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.IsolatedStorage;
using System.Data.Linq.Mapping;

namespace Agenda_Telefonica
{

   
    //Implementando BD, não está completo

        
    [Table(Name="tbDadosAgenda")]
  public class DadosAgenda
    {

        [Column(Name = "dttId", IsPrimaryKey = true, IsDbGenerated = true,
            CanBeNull = false, AutoSync = AutoSync.OnInsert)]
        public int Id { get; set; }

        [Column(Name= "dttNome", CanBeNull = false )]
      public String Nome { get; set; }

        [Column(Name= "dttNumero", CanBeNull= false)]
      public String Numero { get; set; }

        [Column(Name= "dttGrupo", CanBeNull= false)]
      public String Grupo { get; set; }

        [Column(Name= "dttTipo", CanBeNull= false)]
      public String Tipo { get; set; }

      public DadosAgenda()
      {
          this.Nome = string.Empty;
          this.Numero = string.Empty;
          this.Grupo = string.Empty;
          this.Tipo = string.Empty;

      }
        
       
    }
}
