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
            var partsByDesc1 = businessLayerObj.GetPartsByDescription("b", 0);
            var partsByDesc2 = businessLayerObj.GetPartsByDescription("b", 0);

             var partsByDesc = businessLayerObj.GetPartsByDescription("b", 0);
             var partsByDesc4 = businessLayerObj.GetPartsByDescription("b", 0);

           
        }
    }
}
