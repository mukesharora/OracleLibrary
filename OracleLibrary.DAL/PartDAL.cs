using OracleLibrary.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OracleLibrary.DAL
{
    public class PartDAL
    {
        public string ConnectionStr
        {
            get;
            set;
        }

        public eKanbanModel DbContext
        {
            get;
            set;
        }

        public PartDAL(string connStr)
        {
            this.ConnectionStr = connStr;
            this.DbContext = new eKanbanModel();
        }

        public PartDAL()
        {
            this.DbContext = new eKanbanModel();
        }

        // fetch all the parts information from the database 
        public List<PART> GetParts()
        {
            return this.DbContext.PARTs.ToList();
        }

        // fetch parts information of specific page from the database 
        public List<PART> GetPartsByPage(string orderBy, bool ascending, int pageNumber, int pageSize)
        {
            List<PART> partList = null;

            if (pageSize <= 0)
            {
                pageSize = 10;
            }

            int rowsCount = this.DbContext.PARTs.Count();

            if (rowsCount <= pageSize || pageNumber <= 0)
            {
                pageNumber = 1;
            }

            int excludedRows = (pageNumber - 1) * pageSize;

            switch (orderBy.ToUpper())
            {
                case "PARTNUMBER":
                    if (ascending)
                    {
                        partList = this.DbContext.PARTs.OrderBy(p => p.PARTNUMBER)
                                        .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    else
                    {
                        partList = this.DbContext.PARTs.OrderByDescending(p => p.PARTNUMBER)
                                        .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    break;
                case "PARTNAME":
                    if (ascending)
                    {
                        partList = this.DbContext.PARTs.OrderBy(p => p.PARTNAME)
                                        .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    else
                    {
                        partList = this.DbContext.PARTs.OrderByDescending(p => p.PARTNAME)
                                        .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    break;
                case "PARTDESCRIPTION":
                    if (ascending)
                    {
                        partList = this.DbContext.PARTs.OrderBy(p => p.PARTDESCRIPTION)
                                        .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    else
                    {
                        partList = this.DbContext.PARTs.OrderByDescending(p => p.PARTDESCRIPTION)
                                       .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    break;
                case "QUANTITY":
                    if (ascending)
                    {
                        partList = this.DbContext.PARTs.OrderBy(p => p.QUANTITY)
                                        .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    else
                    {
                        partList = this.DbContext.PARTs.OrderByDescending(p => p.QUANTITY)
                                       .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    break;
                case "ID":
                    if (ascending)
                    {
                        partList = this.DbContext.PARTs.OrderBy(p => p.ID)
                                       .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    else
                    {
                        partList = this.DbContext.PARTs.OrderByDescending(p => p.ID)
                                       .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    break;
                default:
                    if (ascending)
                    {
                        partList = this.DbContext.PARTs.OrderBy(p => p.ID)
                                       .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    else
                    {
                        partList = this.DbContext.PARTs.OrderByDescending(p => p.ID)
                                       .Skip(excludedRows).Take(pageSize).ToList();
                    }
                    break;
            }

            return partList;
        }

        // fetch parts information based on specified partNumber from the database
        public List<PART> GetPartsByNumber(string partNumber, int maximumRecords)
        {
            List<PART> partList = null;

            if (maximumRecords == 0)
            {
                partList = this.DbContext.PARTs.Where(o => o.PARTNUMBER.ToLower().StartsWith(partNumber.ToLower())).OrderBy(o => o.PARTNUMBER).ToList();
            }
            else
            {
                partList = this.DbContext.PARTs.Where(o => o.PARTNUMBER.ToLower().StartsWith(partNumber.ToLower())).OrderBy(o => o.PARTNUMBER).Take(maximumRecords).ToList();
            }

            return partList;
        }

        // fetch parts information based on specified partName from the database  
        public List<PART> GetPartsByName(string partName, int maximumRecords)
        {
            List<PART> partList = null;

            if (maximumRecords == 0)
            {
                partList = this.DbContext.PARTs.Where(o => o.PARTNAME.ToLower().StartsWith(partName.ToLower())).OrderBy(o => o.PARTNAME).ToList();
            }
            else
            {
                partList = this.DbContext.PARTs.Where(o => o.PARTNAME.ToLower().StartsWith(partName.ToLower())).OrderBy(o => o.PARTNAME).Take(maximumRecords).ToList();
            }

            return partList;
        }

        // fetch parts information based on specified part Description from the database.
        public List<PART> GetPartsByDescription(string partDescription, int maximumRecords)
        {
            List<PART> partList = null;

            if (maximumRecords == 0)
            {
                partList = this.DbContext.PARTs.Where(o => o.PARTDESCRIPTION.ToLower().StartsWith(partDescription.ToLower())).OrderBy(o => o.PARTDESCRIPTION).ToList();
            }
            else
            {
                partList = this.DbContext.PARTs.Where(o => o.PARTDESCRIPTION.ToLower().StartsWith(partDescription.ToLower())).OrderBy(o => o.PARTDESCRIPTION).Take(maximumRecords).ToList();
            }

            return partList;
        }
    }
}
