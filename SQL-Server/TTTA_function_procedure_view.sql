
USE TTTA_DB
-- LoadData
CREATE View LoadKhoaHoc As SELECT * From KhoaHoc

CREATE View LoadMonHoc As Select *    From MonHoc;

CREATE View LoadGiangVien As Select *    From GiangVien;

Create View LoadNhanVien As Select *    From NhanVien;

Create View LoadDangNhap As Select *    From DangNhap;

Create View LoadLopHoc As Select * From LopHoc;

Create  View LoadHocVien As Select *    From HocVien;

Create View LoadBienLaiHocPhi As Select *    From BienLaiHocPhi;

Create View LoadKetQua As Select *    From KetQua;
-- Procedures
-- THEM
-- KHOAHOC------------------------------------------------------------------
Create Procedure ThemKhoaHoc(@MaKH int, @NgayBatDau date, 
							 @SoTuanHoc int, @TinhTrang varchar)
As
Begin
  Insert into KhoaHoc VALUES (@MaKH,@NgayBatDau,@SoTuanHoc,@TinhTrang)
End
-- MONHOC-------------------------------------------------------------------------------
Create Procedure ThemMonHoc (@MaMH int, @TenMH varchar, @SoGioHoc int)
As
Begin 
  Insert into MonHoc VALUES (@MaMH,@TenMH,@SoGioHoc);
End
-- LOPHOC--------------------------------------------------------------------------------
Create Procedure ThemLopHoc(@MaLH int,@KhoaHoc int,@MonHoc int,@GiangVien int,@CaHoc varchar,
							@NgayHoc varchar,@SoLuongHV varchar,@SoTien int)
As
Begin
  Insert into LopHoc VALUES (@MaLH,@KhoaHoc,@MonHoc,@GiangVien,@CaHoc,@NgayHoc,@SoLuongHV,@SoTien);
End
-- HOCVIEN-------------------------------------------------------------------------------
Create Procedure ThemHocVien(@MaHV int, @HoTen  varchar, @NgaySinh date,
				@GioiTinh varchar, @DiaChi  varchar, @SoDienThoai varchar)
As
Begin
  Insert into HocVien VALUES (@MaHV, @Hoten, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai);
End
-- DANGNHAP-------------------------------------------------------------------------------

Create Procedure ThemDangNhap(@Mail varchar, @MatKhau varchar,@QuyenDangNhap varchar)
As
Begin
  Insert into DangNhap VALUES (@Mail,@MatKhau,@QuyenDangNhap);
End
-- GIANGVIEN-------------------------------------------------------------------------------

Create Procedure ThemGiangVien(@MaGV int, @TenGV varchar, @NgaySinh date, 
		@ThamNien int, @HocVi varchar, @Luong INT, @Mail varchar)
As
Begin
  Insert into GiangVien VALUES (@MaGV, @TenGV, @NgaySinh, @ThamNien, @HocVi, @Luong, @Mail);
End

-- THEMNHANVIEN-------------------------------------------------------------------------------
Create Procedure ThemNhanVien(@MaNV  int, @TenNV  varchar, @NgaySinh  date, 
@GioiTinh  varchar, @CMND  varchar, @Luong  int, @Mail  varchar)
As
Begin
  insert into NhanVien VALUES (@MaNV, @TenNV, @NgaySinh, @GioiTinh, @CMND, @Luong, @Mail);
End


-- BIENLAI-------------------------------------------------------------------------------
Create Procedure ThemBienLai (@MaHocVien int, @MaLopHoc int, 
				@MaKhoaHoc varchar, @HoaDon varchar)
As
Begin
  Insert into BienLaiHocPhi VALUES (@MaHocVien, @MaLopHoc, @MaKhoaHoc, @HoaDon);
End

-- KETQUA-------------------------------------------------------------------------------
Create Procedure ThemKetQua (@MaHocVien int, @MaLopHoc int, @MaKhoaHoc  varchar, 
@DiemGiuaKy float, @DiemCuoiKy float, @DiemTB  float)
As
Begin
  Insert into KetQua values (@MaHocVien, @MaLopHoc, @MaKhoaHoc, @DiemGiuaKy, @DiemCuoiKy, @DiemTB);
End


-- UPDATE-------------------------------------------------------------------------------
-- KHOAHOC-------------------------------------------------------------------------------
CREATE Procedure CapNhatKhoaHoc(@MaKH  int, @NgayBatDau date, 
									@SoTuanHoc int, @TinhTrang varchar)
As
Begin
  Update KhoaHoc
  Set MaKH=@MaKH, NgayBatDau=@NgayBatDau,
  SoTuanHoc=@SoTuanHoc, TinhTrang=@TinhTrang
  Where MaKH=@MaKH;
End

-- MONHOC-------------------------------------------------------------------------------
Create Procedure CapNhatMonHoc(@MaMH  int, @TenMH varchar, 
											@SoGioHoc  int)
As
Begin 
  Update MonHoc SET MaMH=@MaMH, TenMH=@TenMH, SoGioHoc=@SoGioHoc
  Where MaMH=@MaMH;
End

-- LOPHOC-------------------------------------------------------------------------------

CREATE Procedure CapNhatLopHoc(@MaLH int,@KhoaHoc int,@MonHoc int,@GiangVien int,
					@CaHoc varchar,@NgayHoc varchar,@SoLuongHV varchar,@SoTien int)
As
Begin
  UpDate LopHoc SET MaLH=@MaLH, KhoaHoc=@KhoaHoc, MonHoc=@MonHoc, GiangVien=@GiangVien,
			CaHoc=@CaHoc, NgayHoc=@NgayHoc, SoLuongHV=@SoLuongHV, SoTien=@SoTien
  Where MaLH=@MaLH and KhoaHoc=@KhoaHoc;
End


-- HOCVIEN-------------------------------------------------------------------------------
CREATE Procedure CapNhatHocVien
(@MaHV int, @HoTen  varchar, @NgaySinh  date,
 @GioiTinh  varchar, @DiaChi  varchar, @SoDienThoai  varchar)
As
Begin
  Update HocVien
  Set MaHV=@MaHV, HoTen=@HoTen, NgaySinh=@NgaySinh, 
  GioiTinh=@GioiTinh, DiaChi=@DiaChi, SoDienThoai=@SoDienThoai
  Where MaHV=@MaHV;
End



-- DANGNHAP-------------------------------------------------------------------------------
Create Procedure CapNhatDangNhap
(@Mail varchar, @MatKhau varchar,@QuyenDangNhap  varchar)
As
Begin
  Update DangNhap
  Set Mail=@Mail, MatKhau=@MatKhau, QuyenDangNhap=@QuyenDangNhap
  Where Mail=@Mail;
End 

-- GIANGVIEN-------------------------------------------------------------------------------
Create Procedure CapNhatGiangVien
(@MaGV int, @TenGV  varchar, @NgaySinh date, 
@ThamNien int, @HocVi varchar, @Luong int, @Mail varchar)
As
Begin
  Update GiangVien
  Set MaGV=@MaGV, TenGV=@TenGV, NgaySinh=@NgaySinh, 
  ThamNien=@ThamNien, HocVi=@HocVi, Luong=@Luong, Mail=@Mail
  Where MaGV=@MaGV;
End

-- NHANVIEN-------------------------------------------------------------------------------
Create Procedure CapNhatNhanVien
(@MaNV  int, @TenNV varchar, @NgaySinh date, 
@GioiTinh varchar, @CMND varchar, @Luong int, @Mail varchar)
As
Begin
  Update NhanVien
  Set MaNV=@MaNV, TenNV=@TenNV, NgaySinh=@NgaySinh, 
  GioiTinh=@GioiTinh, CMND=@CMND, Luong=@Luong, Mail=@Mail
  Where MaNV=@MaNV;
End

-- KETQUA-------------------------------------------------------------------------------
CREATE Procedure CapNhatKetQua
(@MaHocVien int, @MaLopHoc  int, @MaKhoaHoc varchar, 
@DiemGiuaKy float, @DiemCuoiKy float, @DiemTB float)
As
Begin
  Update KetQua
  Set MaHocVien=@MaHocVien, MaLopHoc=@MaLopHoc, MaKhoaHoc=@MaKhoaHoc, 
  DiemGiuaKy=@DiemGiuaKy, DiemCuoiKy=@DiemCuoiKy, DiemTB=@DiemTB
  Where MaHocVien=@MaHocVien and MaLopHoc=@MaLopHoc
  and MaKhoaHoc=@MaKhoaHoc;
End

-- DELETE-------------------------------------------------------------------------------
-- KHOAHOC-------------------------------------------------------------------------------
Create Procedure XoaKhoaHoc(@MaKH int)
As
Begin
  Delete
  From KhoaHoc
  Where MaKH=@MaKH;
End
-- MONHOC-------------------------------------------------------------------------------
Create Procedure XoaMonHoc(@MaMH int)
As
Begin
  Delete
  From MonHoc
  Where MaMH=@MaMH;
End
-- LOPHOC-------------------------------------------------------------------------------
Create  Procedure XoaLopHoc
(@MaLH  int,@KhoaHoc int)
As
Begin
  Delete
  From LopHoc
  Where MaLH=@MaLH and KhoaHoc=@KhoaHoc;
End

-- HOCVIEN-------------------------------------------------------------------------------
Create Procedure XoaHocVien(@MaHV  int)
As
Begin
  Delete
  From HocVien
  Where MaHV=@MaHV;
End 
-- DANGNHAP-------------------------------------------------------------------------------
CREATE Procedure XoaDangNhap
(@Mail varchar, @MatKhau  varchar,@QuyenDangNhap  varchar)
As
Begin
  Delete
  From DangNhap
  Where Mail=@Mail;
End

-- GIANGVIEN-------------------------------------------------------------------------------
CREATE Procedure XoaGiangVien
(@MaGV int)
As
Begin
  Delete
  From GiangVien
  Where MaGV=@MaGV;
End

-- NHANVIEN-------------------------------------------------------------------------------
Create Procedure XoaNhanVien
(@MaNV int)
As
Begin
  Delete 
  From NhanVien 
  Where MaNV=@MaNV;
End


-- BIENLAI-------------------------------------------------------------------------------
Create Procedure XoaBienLai
(@MaHocVien int, @MaLopHoc int, @MaKhoaHoc varchar)
As
Begin
  Delete
  From BienLaiHocPhi
  Where MaHocVien=@MaHocVien and MaLopHoc=@MaLopHoc
  and MaKhoaHoc=@MaKhoaHoc;
End
-- KETQUA-------------------------------------------------------------------------------
CREATE Procedure XoaKetQua
(@MaHocVien int, @MaLopHoc int, @MaKhoaHoc varchar)
As
Begin
  Delete
  From KetQua
  Where MaHocVien=@MaHocVien and MaLopHoc=@MaLopHoc
  and MaKhoaHoc=@MaKhoaHoc;
End

--KIEMTRADANGNHAP-------------------------------------------------------------------------------
Create Procedure KiemTraDangNhap
(@i_Mail varchar, @i_MatKhau varchar, @i_Quyen varchar,
@o_Mail varchar, @o_MatKhau varchar, @o_Quyen varchar)
As
Begin
  Select DangNhap.Mail o_Mail, DangNhap.MatKhau o_MatKhau, DangNhap.QuyenDangNhap o_Quyen
  From DangNhap
  Where Mail=@i_Mail and MatKhau=@i_MatKhau and QuyenDangNhap=@i_Quyen;
END


---- TRIGGER --------------------------------------------------------------------------------------------------------------------------------
USE TTTA_DB
--TRIGGER
DROP TRIGGER TG_ThemKetQua

CREATE TRIGGER TG_ThemKetQua
ON BienLaiHocPhi AFTER INSERT 
AS
DECLARE
  @MaHocVien INT,
  @MaLopHoc INT,
  @MaKhoaHoc INT
SELECT @MaHocVien= ins.MaHocVien,
	   @MaLopHoc= ins.MaLopHoc,
	   @MaKhoaHoc= ins.MaKhoaHoc
FROM INSERTED INS
BEGIN
  INSERT INTO KetQua (mahocvien, malophoc,makhoahoc) VALUES (@MaHocVien, @MaLopHoc,@MaKhoaHoc)
END 
----------------------------------------------
CREATE TRIGGER TG_ XoaKetQua
After Delete on BienLaiHocPhi 
Referencing Old as oldest
For Each Row
Declare
  v_MaHocVien int;
  v_MaLopHoc int;
  v_MaKhoaHoc int;
Begin
  v_MaHocVien:= :oldest.MaHocVien;
  v_MaLopHoc:= :oldest.MaLopHoc;
  v_MaKhoaHoc:= :oldest.MaKhoaHoc;
  Delete 
  From KetQua 
  Where MaHocVien=v_MaHocVien and MaLopHoc=v_MaLopHoc
  and MaKhoaHoc=v_MaKhoaHoc;
End;

Create or Replace 
Trigger XoaBienLaiLopHoc
Before Delete on LopHoc
Referencing Old as oldest
For Each Row
Declare
  v_MaLopHoc int;
  v_MaKhoaHoc int;
Begin
  v_MaLopHoc:= :oldest.MaLH;
  v_MaKhoaHoc:= :oldest.KhoaHoc;
  Delete 
  From BienLaiHocPhi 
  Where MaLopHoc=v_MaLopHoc and MaKhoaHoc=v_MaKhoaHoc;
End;
--FUNCTION
Create Or Replace Function NhanVienNu(p_MaNV int)
  Return varchar2 As
  v_NhanVienNu NhanVien.TenNV%Type;
Begin
  Begin
     Select NhanVien.TenNV
     Into   v_NhanVienNu
     From   NhanVien
     Where  NhanVien.MaNV=p_MaNV and NhanVien.GioiTinh = 'Nu';
  Exception
     When No_Data_Found Then
        v_NhanVienNu := Null;
  End;
  Return v_NhanVienNu;
End;

Create Or Replace Function TimNhanVien(p_MaNV int)
  Return varchar2 As
  v_NhanVien NhanVien.TenNV%Type;
Begin
  Begin
     Select NhanVien.TenNV
     Into   v_NhanVien
     From   NhanVien
     Where  NhanVien.MaNV=p_MaNV;
  Exception
     When No_Data_Found Then
        v_NhanVien := Null;
  End;
  Return v_NhanVien;
End;

Create Or Replace Function TimGiangVien(p_MaGV int)
  Return varchar2 As
  v_GiangVien GiangVien.TenGV%Type;
Begin
  Begin
     Select GiangVien.TenGV
     Into   v_GiangVien
     From   GiangVien
     Where  GiangVien.MaGV=p_MaGV;
  Exception
     When No_Data_Found Then
        v_GiangVien := Null;
  End;
  Return v_GiangVien;
End;

Create or Replace Function ThongKeHocVien(p_MaKH int)
  Return number As
  v_SoLuong number;
Begin
  Begin
     Select Count(Distinct MaHocVien)
     Into   v_SoLuong
     From   BienLaiHocPhi
     Where  BienLaiHocPhi.MaKhoaHoc=p_MaKH;
  Exception
     When No_Data_Found Then
        v_SoLuong := Null;
  End;
  Return v_SoLuong;
End;

Create or Replace 
Function TinhDiemTB(DiemGiuaKy float, DiemCuoiKy float)
  Return number As
  v_DiemTB number;
Begin
  Begin
    v_DiemTB := (DiemGiuaKy+DiemCuoiKy)/2;
  Exception
     When No_Data_Found Then
        v_DiemTB := Null;
  End;
  Return v_DiemTB;
End;

Create or Replace Function TinhTongDoanhThu(p_MaKH int)
  Return number As
  v_DoanhThu number;
Begin
  Begin
     Select SUM(lh.SoTien) AS "Tong Tien"
     Into   v_DoanhThu
     From   LopHoc lh, BienLaiHocPhi bl
     Where  bl.MaKhoaHoc=p_MaKH and bl.MaLopHoc=lh.MaLH;
  Exception
     When No_Data_Found Then
        v_DoanhThu := Null;
  End;
  Return v_DoanhThu;
End;
