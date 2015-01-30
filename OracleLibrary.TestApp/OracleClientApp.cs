using OracleLibrary.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OracleLibrary.TestApp
{
    class OracleClientApp
    {
        static void Main(string[] args)
        {
            PartBLL businessLayerObj = new PartBLL();

            var parts = businessLayerObj.GetParts();
            var partsByPage = businessLayerObj.GetPartsByPage("partnumber", true, 2, 2);
            var partsByNumber = businessLayerObj.GetPartsByNumber("1", 2);
            var partsByName = businessLayerObj.GetPartsByName("a", 1);
            var partsByDesc = businessLayerObj.GetPartsByDescription("b", 0);

<<<<<<< HEAD

            // Comment 1
=======
            // Comments for someTesting
>>>>>>> 4480c1dc9f7b95145da6f501f79f4c1350f75244
        }
    }
}
