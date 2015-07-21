using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Linq;

// Classe q faz a conexao com o BD


namespace Agenda_Telefonica.DAO
{
    public class DataBaseContext : DataContext
    {
        public static string ConnectionString = "Data Source=isostore:/BD.sdf";

        private Table<DadosAgenda> _dadosAgenda;

        public Table<DadosAgenda> dadosAgenda
        {
            get
            {
                if (this._dadosAgenda == null)
                    this._dadosAgenda = this.GetTable<DadosAgenda>();

                return this._dadosAgenda;
            }
        }

        public DataBaseContext(string connectionString)
            : base(connectionString)
        { }

    }
}
