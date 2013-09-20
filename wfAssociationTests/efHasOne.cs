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
    public class efHasMany
    {
        public int Id { get; set; }
        public List<efHasManyAssociation> members { get; set; } 
    }

    public class efHasManyAssociation
    {
        public int Id { get; set; }
        public String Label { get; set; }
    }

    //-----------------------------------  MANY MANY --------------------------------------------------------------
    public class efManyMany
    {
        public int Id { get; set; }
        public List<efManyManyAssociation> members { get; set; } 
    }

    public class efManyManyAssociation
    {
        public int Id { get; set; }
        public List<efManyMany> members { get; set; }
    }

    // //////////////////////////////////////////////////////////////////////////////////////////////////////////////
    // /   Helper Methods //////
    // //////////////////////////////////////////////////////////////////////////////////////////////////////////////

}
