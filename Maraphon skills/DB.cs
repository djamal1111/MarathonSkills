using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Maraphon_skills
{
    public static class Util
    {
        private static marafonEntities database;
        public static marafonEntities db 
        {
            get 
                {
                   if (database == null)
                    database = new marafonEntities();
                
                   return database;
                }
        }
    }
}
