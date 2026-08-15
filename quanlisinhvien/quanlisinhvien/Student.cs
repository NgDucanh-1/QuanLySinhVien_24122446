using System;

public class Student
{
    private string maSinhVien;
    private string hoTen;
    private DateTime ngaySinh;
    private string gioiTinh;
    private string email;
    private string soDienThoai;
    private string nganhHoc;
    private double diemTrungBinh;
    private string trangThaiHocTap;

    public string MaSinhVien
    {
        get { return maSinhVien; }
        set { maSinhVien = value; }
    }

    public string HoTen
    {
        get { return hoTen; }
        set { hoTen = value; }
    }

    public DateTime NgaySinh
    {
        get { return ngaySinh; }
        set { ngaySinh = value; }
    }

    public string GioiTinh
    {
        get { return gioiTinh; }
        set { gioiTinh = value; }
    }

    public string Email
    {
        get { return email; }
        set { email = value; }
    }

    public string SoDienThoai
    {
        get { return soDienThoai; }
        set { soDienThoai = value; }
    }

    public string NganhHoc
    {
        get { return nganhHoc; }
        set { nganhHoc = value; }
    }

    public double DiemTrungBinh
    {
        get { return diemTrungBinh; }
        set { diemTrungBinh = value; }
    }

    public string TrangThaiHocTap
    {
        get { return trangThaiHocTap; }
        set { trangThaiHocTap = value; }
    }

    public Student()
    {
        maSinhVien = "";
        hoTen = "";
        ngaySinh = DateTime.Now;
        gioiTinh = "";
        email = "";
        soDienThoai = "";
        nganhHoc = "";
        diemTrungBinh = 0;
        trangThaiHocTap = "";
    }

    public Student(
        string maSinhVien,
        string hoTen,
        DateTime ngaySinh,
        string gioiTinh,
        string email,
        string soDienThoai,
        string nganhHoc,
        double diemTrungBinh,
        string trangThaiHocTap)
    {
        this.maSinhVien = maSinhVien;
        this.hoTen = hoTen;
        this.ngaySinh = ngaySinh;
        this.gioiTinh = gioiTinh;
        this.email = email;
        this.soDienThoai = soDienThoai;
        this.nganhHoc = nganhHoc;
        this.diemTrungBinh = diemTrungBinh;
        this.trangThaiHocTap = trangThaiHocTap;
    }

    public void Xuat()
    {
        Console.WriteLine(
            $"{MaSinhVien,-12}" +
            $"{HoTen,-25}" +
            $"{NgaySinh:dd/MM/yyyy,-15}" +
            $"{GioiTinh,-10}" +
            $"{Email,-30}" +
            $"{SoDienThoai,-15}" +
            $"{NganhHoc,-15}" +
            $"{DiemTrungBinh,-8:F2}" +
            $"{TrangThaiHocTap,-15}"
        );
    }
}