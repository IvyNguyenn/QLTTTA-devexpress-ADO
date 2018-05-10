using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using QLTTTA.DTO;
namespace QLTTTA.DAO
{
    public class NhanVienDAO
    {
        private static NhanVienDAO instance;

        public static NhanVienDAO Instance
        {
            get { if (instance == null) instance = new NhanVienDAO(); return instance; }
            private set { instance = value; }
        }
        public NhanVienDAO() { }
        public bool them(int maNV, string tenNV, DateTime? ngaySinh, string gioiTinh, string cmnd, int luong, string mail)
        {
            try
            {
                SqlParameter[] sqlParams = { new SqlParameter("@MaNV", SqlDbType.Int),
                new SqlParameter("@TenNV", SqlDbType.VarChar),
                new SqlParameter("@NgaySinh", SqlDbType. Date),
                new SqlParameter("@GioiTinh", SqlDbType.VarChar),
                new SqlParameter("@CMND", SqlDbType.VarChar),
                new SqlParameter("@Luong", SqlDbType.Int),
                new SqlParameter("@Mail", SqlDbType.VarChar)};
                Object[] parameters = { maNV, tenNV, ngaySinh, gioiTinh, cmnd, luong, mail };
                DataProvider.Instance.ExecuteNonQuery("ThemNhanVien", sqlParams, parameters);
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool capNhat(int maNV, string tenNV, DateTime? ngaySinh, string gioiTinh, string cmnd, int luong, string mail)
        {
            try
            {
                SqlParameter[] sqlParams = { new SqlParameter("@MaNV", SqlDbType.Int),
                new SqlParameter("@TenNV", SqlDbType.VarChar),
                new SqlParameter("@NgaySinh", SqlDbType. Date),
                new SqlParameter("@GioiTinh", SqlDbType.VarChar),
                new SqlParameter("@CMND", SqlDbType.VarChar),
                new SqlParameter("@Luong", SqlDbType.Int),
                new SqlParameter("@Mail", SqlDbType.VarChar)};
                Object[] parameters = { maNV, tenNV, ngaySinh, gioiTinh, cmnd, luong, mail };
                DataProvider.Instance.ExecuteNonQuery("CapNhatNhanVien", sqlParams, parameters);
                return true;

            }
            catch
            {
                return false;
            }
        }
        public bool xoa(int maNV)
        {
            try
            {
                SqlParameter[] sqlParams = { new SqlParameter("@MaNV", SqlDbType.Int) };
                Object[] parameters = { maNV };
                DataProvider.Instance.ExecuteNonQuery("XoaNhanVien", sqlParams, parameters);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public DataTable getListNhanVien()
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from loadnhanvien"));
        }
        public DataTable getNhanVien(string mail)
        {
            return DataProvider.Instance.ExecuteQuery(string.Format("select * from nhanvien where mail = '{0}'", mail));

        }

    }
}
