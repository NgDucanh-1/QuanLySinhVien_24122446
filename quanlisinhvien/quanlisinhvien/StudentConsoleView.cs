using System;
using System.Collections.Generic;

public class StudentConsoleView
{
    public Student NhapSinhVien()
    {
        Console.WriteLine("\n NHAP THONG TIN SINH VIEN");

        string maSinhVien;

        while (true)
        {
            Console.Write("Ma sinh vien: ");
            maSinhVien = Console.ReadLine() ?? "";

            if (StudentValidator.KiemTraMa(maSinhVien))
                break;

            Console.WriteLine("Ma sinh vien khong duoc rong!");
        }

        string hoTen;

        while (true)
        {
            Console.Write("Ho ten: ");
            hoTen = Console.ReadLine() ?? "";

            if (StudentValidator.KiemTraHoTen(hoTen))
                break;

            Console.WriteLine("Ho ten khong duoc rong!");
        }

        DateTime ngaySinh;

        while (true)
        {
            Console.Write("Ngay sinh (dd/MM/yyyy): ");

            if (DateTime.TryParse(
                Console.ReadLine(),
                out ngaySinh))
            {
                if (StudentValidator.KiemTraNgaySinh(ngaySinh))
                    break;
            }

            Console.WriteLine("Ngay sinh khong hop le!");
        }

        Console.Write("Gioi tinh: ");
        string gioiTinh = Console.ReadLine() ?? "";

        string email;

        while (true)
        {
            Console.Write("Email: ");
            email = Console.ReadLine() ?? "";

            if (StudentValidator.KiemTraEmail(email))
                break;

            Console.WriteLine("Email khong dung dinh dang!");
        }

        Console.Write("So dien thoai: ");
        string soDienThoai = Console.ReadLine() ?? "";

        Console.Write("Nganh hoc: ");
        string nganhHoc = Console.ReadLine() ?? "";

        double diemTrungBinh;

        while (true)
        {
            Console.Write("Diem trung binh: ");

            if (double.TryParse(
                Console.ReadLine(),
                out diemTrungBinh))
            {
                if (StudentValidator.KiemTraDiem(
                    diemTrungBinh))
                    break;
            }

            Console.WriteLine(
                "Diem phai tu 0 den 10!");
        }

        Console.Write("Trang thai hoc tap: ");
        string trangThaiHocTap =
            Console.ReadLine() ?? "";

        return new Student(
            maSinhVien,
            hoTen,
            ngaySinh,
            gioiTinh,
            email,
            soDienThoai,
            nganhHoc,
            diemTrungBinh,
            trangThaiHocTap
        );
    }

    public void HienThiDanhSach(
        List<Student> danhSach)
    {
        if (danhSach.Count == 0)
        {
            Console.WriteLine(
                "\nDanh sach sinh vien rong!");
            return;
        }

        Console.WriteLine();

        foreach (Student student in danhSach)
        {
            student.Xuat();
        }
    }

    public void HienThiSinhVien(Student student)
    {
        if (student == null)
        {
            Console.WriteLine(
                "Khong tim thay sinh vien!");
            return;
        }

        student.Xuat();
    }
}