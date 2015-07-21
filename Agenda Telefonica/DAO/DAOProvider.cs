using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


// Classe onde criamos os comandos do DB, como selects, updates, deletes e etc...


namespace Agenda_Telefonica.DAO
{
    public class DAOProvider
    {
        public static void CreateDataBase()
        {
            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                if (!db.DatabaseExists())
                {
                    db.CreateDatabase();
                }
            }
        }

        public static IEnumerable<DadosAgenda> GetDataItems()
        {
            List<DadosAgenda> returnValue = null;

            returnValue = new List<DadosAgenda>();

            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                var query = db.dadosAgenda.OrderBy(d => d.Nome);

                foreach (DadosAgenda item in query)
                {
                    returnValue.Add(item);
                }
            }
            return returnValue;
        }

        internal static void Save(DadosAgenda newItem)
        {
            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                db.dadosAgenda.InsertOnSubmit(newItem);
                db.SubmitChanges();
            }
        }

        internal static void Remove(DadosAgenda item)
        {
            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                var query = db.dadosAgenda.Where(d => d.Id == item.Id);

                if (query.Count() > 0)
                {
                    db.dadosAgenda.DeleteOnSubmit(query.First());

                    db.SubmitChanges();
                }
            }
        }

        internal static void Update(DadosAgenda item)
        {
            using (DataBaseContext db = new DataBaseContext(DataBaseContext.ConnectionString))
            {
                var query = db.dadosAgenda.Where(d => d.Id == item.Id);
                DadosAgenda dados = (DadosAgenda)query.First<DadosAgenda>();
                dados.Nome = item.Nome;
                dados.Numero = item.Numero;
                dados.Tipo = item.Tipo;
                dados.Grupo = item.Grupo;
                db.SubmitChanges();
            }
        }

    }

}
