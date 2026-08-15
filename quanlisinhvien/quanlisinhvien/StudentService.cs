using System;
using System.Collections.Generic;
using System.Linq;

public class StudentService
{
    private List<Student> danhSachSinhVien;

    public StudentService()
    {
        danhSachSinhVien = new List<Student>();
    }

    public bool ThemSinhVien(Student student)
    {
        if (student == null)
            return false;

        if (TimTheoMa(student.MaSinhVien) != null)
            return false;

        danhSachSinhVien.Add(student);
        return true;
    }

    public List<Student> LayDanhSach()
    {
        return danhSachSinhVien;
    }

    public Student TimTheoMa(string ma)
    {
        return danhSachSinhVien.FirstOrDefault(
            sv => sv.MaSinhVien.Equals(
                ma,
                StringComparison.OrdinalIgnoreCase)
        );
    }

    public List<Student> TimGanDungTheoHoTen(string ten)
    {
        return danhSachSinhVien
            .Where(sv => sv.HoTen.ToLower().Contains(ten.ToLower()))
            .ToList();
    }

    public bool CapNhatSinhVien(string ma, Student studentMoi)
    {
        Student student = TimTheoMa(ma);

        if (student == null)
            return false;

        student.HoTen = studentMoi.HoTen;
        student.NgaySinh = studentMoi.NgaySinh;
        student.GioiTinh = studentMoi.GioiTinh;
        student.Email = studentMoi.Email;
        student.SoDienThoai = studentMoi.SoDienThoai;
        student.NganhHoc = studentMoi.NganhHoc;
        student.DiemTrungBinh = studentMoi.DiemTrungBinh;
        student.TrangThaiHocTap = studentMoi.TrangThaiHocTap;

        return true;
    }

    public bool XoaSinhVien(string ma)
    {
        Student student = TimTheoMa(ma);

        if (student == null)
            return false;

        danhSachSinhVien.Remove(student);
        return true;
    }

    public List<Student> SapXepTheoHoTen()
    {
        return danhSachSinhVien
            .OrderBy(sv => sv.HoTen)
            .ToList();
    }

    public List<Student> SapXepTheoDiem()
    {
        return danhSachSinhVien
            .OrderByDescending(sv => sv.DiemTrungBinh)
            .ToList();
    }

    public List<Student> SinhVienDiemTu8()
    {
        return danhSachSinhVien
            .Where(sv => sv.DiemTrungBinh >= 8)
            .ToList();
    }

    public List<Student> SinhVienDiemCaoNhat()
    {
        if (danhSachSinhVien.Count == 0)
            return new List<Student>();

        double diemMax = danhSachSinhVien.Max(
            sv => sv.DiemTrungBinh);

        return danhSachSinhVien
            .Where(sv => sv.DiemTrungBinh == diemMax)
            .ToList();
    }

    public double TinhDiemTrungBinh()
    {
        if (danhSachSinhVien.Count == 0)
            return 0;

        return danhSachSinhVien.Average(
            sv => sv.DiemTrungBinh);
    }

    public Dictionary<string, int> ThongKeTheoNganh()
    {
        return danhSachSinhVien
            .GroupBy(sv => sv.NganhHoc)
            .ToDictionary(
                group => group.Key,
                group => group.Count());
    }

    public Dictionary<string, int> ThongKeTheoTrangThai()
    {
        return danhSachSinhVien
            .GroupBy(sv => sv.TrangThaiHocTap)
            .ToDictionary(
                group => group.Key,
                group => group.Count());
    }
}