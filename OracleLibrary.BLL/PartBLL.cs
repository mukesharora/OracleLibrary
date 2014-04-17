using OracleLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OracleLibrary.BLL
{
    public class PartBLL
    {
        PartDAL partDAlObj = null;

        public PartBLL()
        {
            this.partDAlObj = new PartDAL();
        }
        // fetch all the parts information from the database 
        public List<PART> GetParts()
        {
            return this.partDAlObj.GetParts();
        }

        // fetch parts information of specific page from the database 
        public List<PART> GetPartsByPage(string orderBy, bool ascending, int pageNumber, int pageSize)
        {
            return this.partDAlObj.GetPartsByPage(orderBy, ascending, pageNumber, pageSize);
        }

        // fetch parts information based on specified partNumber from the database
        public List<PART> GetPartsByNumber(string partNumber, int maximumRecords)
        {
            return this.partDAlObj.GetPartsByNumber(partNumber, maximumRecords);
        }

        // fetch parts information based on specified partName from the database  
        public List<PART> GetPartsByName(string partName, int maximumRecords)
        {
            return this.partDAlObj.GetPartsByName(partName, maximumRecords);
        }

        // fetch parts information based on specified part Description from the database.
        public List<PART> GetPartsByDescription(string partDescription, int maximumRecords)
        {
            return this.partDAlObj.GetPartsByDescription(partDescription, maximumRecords);
        }

    }
}
