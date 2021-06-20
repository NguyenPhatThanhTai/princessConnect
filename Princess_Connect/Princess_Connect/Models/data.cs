using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Princess_Connect.Models
{
    public class data
    {
        public List<Characters> getAll()
        {
            Model model = new Model();
            return model.Characters.ToList();
        }
    }
}