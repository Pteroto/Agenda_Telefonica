using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Agenda_Telefonica.DAO;

namespace Agenda_Telefonica.Controles
{
    public class DadosControle
    {
        public void CreateDataBase()
        {
            DAOProvider.CreateDataBase();
        }

        public IEnumerable<DadosAgenda> GetDataItem()
        {
            return DAOProvider.GetDataItems();
        }

        internal void Save(DadosAgenda newItem)
        {
            DAOProvider.Save(newItem);
        }

        internal void Remove(DadosAgenda newItem)
        {
            DAOProvider.Remove(newItem);
        }

        internal void Update(DadosAgenda newItem)
        {
            DAOProvider.Update(newItem);
        }
    }
}
