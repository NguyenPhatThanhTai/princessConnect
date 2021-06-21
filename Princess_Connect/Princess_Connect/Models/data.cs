using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Princess_Connect.Models
{
    public class data
    {
        public List<Saved> getAll()
        {
            DAO model = new DAO();
            return model.Saved.ToList();
        }
    }
}