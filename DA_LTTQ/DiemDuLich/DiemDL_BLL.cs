﻿using System.Data;

namespace QLTour
{
    class DiemDL_BLL
    {
        DiemDL_DAL dalDiemDL;
        public DiemDL_BLL()
        {
            dalDiemDL = new DiemDL_DAL();
        }

        public DataTable GetAllDDLTrongNc()
        {
            return dalDiemDL.GetAllDDLTrongNc();
        }

        public DataTable GetAllDDLNgoaiNc()
        {
            return dalDiemDL.GetAllDDLNgoaiNc();
        }

        public DataTable GetAllDDL(tbl_DiemDL ddl)
        {
            return dalDiemDL.GetAllDDL(ddl);
        }

        public bool InsertDDL(tbl_DiemDL ddl)
        {
            return dalDiemDL.InsertDDL(ddl);
        }

        public bool UpdateDDL(tbl_DiemDL ddl)
        {
            return dalDiemDL.UpdateDDL(ddl);
        }

        public bool DeleteDDL(tbl_DiemDL ddl)
        {
            return dalDiemDL.DeleteDDL(ddl);
        }

       /* public int GetSLDDL()
        {
            return dalDiemDL.GetSLDDL();
        }*/
    }
}
