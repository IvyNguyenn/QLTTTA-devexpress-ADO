using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Oracle.DataAccess.Client;
using System.Data.SqlClient;

namespace QLTTTA.DAO
{
    public class KhoaHocDAO
    {
        private static KhoaHocDAO instance;

        public static KhoaHocDAO Instance
        {
            get { if (instance == null) instance = new KhoaHocDAO(); return instance; }
            private set { instance = value; }
        }
        public KhoaHocDAO() { }
        public bool them(int maKH, DateTime ngayBatDau, int soTuanHoc, string tinhTrang)
        {
            try
            {
                string[] sqlParams = { "@MaKH","@NgayBatDau","@SoTuanHoc","@TinhTrang" };
                Object[] parameters = { maKH, ngayBatDau, soTuanHoc, tinhTrang };
                DataProvider.Instance.ExecuteNonQuery("ThemKhoaHoc", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool capNhat(int maKH, DateTime? ngayBatDau, int soTuanHoc, string tinhTrang)
        {
            try
            {
                SqlParameter[] sqlParams = { new SqlParameter("@MaKH", SqlDbType.Int),
                new SqlParameter("@NgayBatDau", SqlDbType.Date),
                new SqlParameter("@SoTuanHoc", SqlDbType. Int),
                new SqlParameter("@TinhTrang", SqlDbType.VarChar) };
                Object[] parameters = { maKH, ngayBatDau, soTuanHoc, tinhTrang };
                DataProvider.Instance.ExecuteNonQuery("CapNhatKhoaHoc", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public bool xoa(int maKH)
        {
            try
            {
                SqlParameter[] sqlParams = { new SqlParameter("@MaKH", OracleDbType.Int32) };
                Object[] parameters = { maKH };
                DataProvider.Instance.ExecuteNonQuery("XoaKhoaHoc", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public DataTable getKhoaHoc(int maKH)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from khoahoc where maKH = {0}", maKH));

        }

        public DataTable getListKhoaHoc()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadkhoahoc"));
        }

        public DataTable getListKhoaHocByMaGV(int maGV)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("Select * From Khoahoc Where Makh in (select khoahoc from lophoc where giangvien = {0})", maGV.ToString()));
        }
    }
}
