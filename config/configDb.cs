using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace Form_Projek_Akhir.config
{
    abstract class configDb
    {
        //instruksi insert,update dan delete
        public abstract int eksekusiNonQuery(string query);

        //instruksi select
        public abstract DataTable eksekusiQuery(string query);
    }
}
