using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wfAssociationTests
{

    //-----------------------------------  HAS ONE --------------------------------------------------------------
    public class efHasOne
    {
        public int Id { get; set; }
        virtual public efHadOne efHad { get; set; }
    }

    public class efHadOne
    {
        public int Id { get; set; }
        public String Label { get; set; }
    }


    //-----------------------------------  HAS MANY ---------------------------------------------------------------


    //-----------------------------------  MANY MANY --------------------------------------------------------------
}
