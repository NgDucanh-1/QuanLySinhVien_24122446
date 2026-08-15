using System;
using System.Collections.Generic;

public class MenuManager
{
    private StudentService studentService;
    private StudentConsoleView view;

    public MenuManager()
    {
        studentService = new StudentService();
        view = new StudentConsoleView();
    }

    public void Chay()
    {
        int luaChon;

        do
        {
            HienThiMenu();

            Console.Write("Nhap lua chon: ");

            if (!int.TryParse(
                Console.ReadLine(),
                out luaChon))
            {
                Console.WriteLine(
                    "Lua chon khong hop le!");
                TiepTuc();
                continue;
            }

            switch (luaChon)
            {
                case 1:
                    ThemSinhVien();
                    break;

                case 2:
                    HienThiDanhSach();
                    break;

                case 3:
                    TimTheoMa();
                    break;

                case 4:
                    TimGanDungTheoTen();
                    break;

                case 5:
                    CapNhatSinhVien();
                    break;

                case 6:
                    XoaSinhVien();
                    break;

                case 7:
                    SapXepTheoHoTen();
                    break;

                case 8:
                    SapXepTheoDiem();
                    break;

                case 9:
                    SinhVienDiemTu8();
                    break;

                case 10:
                    SinhVienDiemCaoNhat();
                    break;

                case 11:
                    TinhDiemTrungBinh();
                    break;

                case 12:
                    ThongKeTheoNganh();
                    break;

                case 13:
                    ThongKeTheoTrangThai();
                    break;

                case 0:
                    Console.WriteLine(
                        "Ket thuc chuong trinh!");
                    break;

                default:
                    Console.WriteLine(
                        "Lua chon khong ton tai!");
                    break;
            }

            if (luaChon != 0)
                TiepTuc();

        } while (luaChon != 0);
    }

    private void HienThiMenu()
    {
        Console.Clear();

        Console.WriteLine(
            "==============================================");
        Console.WriteLine(
            "       QUAN LY SINH VIEN BANG OOP");
        Console.WriteLine(
            "==============================================");

        Console.WriteLine("1. Them sinh vien");
        Console.WriteLine("2. Hien thi danh sach");
        Console.WriteLine("3. Tim sinh vien theo ma");
        Console.WriteLine("4. Tim gan dung theo ho ten");
        Console.WriteLine("5. Cap nhat sinh vien");
        Console.WriteLine("6. Xoa sinh vien");
        Console.WriteLine("7. Sap xep theo ho ten");
        Console.WriteLine("8. Sap xep theo diem trung binh");
        Console.WriteLine("9. Sinh vien diem tu 8 tro len");
        Console.WriteLine("10. Sinh vien co diem cao nhat");
        Console.WriteLine("11. Tinh diem trung binh");
        Console.WriteLine("12. Thong ke theo nganh");
        Console.WriteLine("13. Thong ke theo trang thai");
        Console.WriteLine("0. Thoat");

        Console.WriteLine(
            "==============================================");
    }

    private void ThemSinhVien()
    {
        Student student = view.NhapSinhVien();

        if (studentService.ThemSinhVien(student))
            Console.WriteLine(
                "\nThem sinh vien thanh cong!");
        else
            Console.WriteLine(
                "\nMa sinh vien da ton tai!");
    }

    private void HienThiDanhSach()
    {
        Console.WriteLine(
            "\n===== DANH SACH SINH VIEN =====");

        view.HienThiDanhSach(
            studentService.LayDanhSach());
    }

    private void TimTheoMa()
    {
        Console.Write(
            "\nNhap ma sinh vien can tim: ");

        string ma = Console.ReadLine() ?? "";

        Student student =
            studentService.TimTheoMa(ma);

        view.HienThiSinhVien(student);
    }

    private void TimGanDungTheoTen()
    {
        Console.Write(
            "\nNhap ten can tim: ");

        string ten = Console.ReadLine() ?? "";

        List<Student> ketQua =
            studentService.TimGanDungTheoHoTen(ten);

        view.HienThiDanhSach(ketQua);
    }

    private void CapNhatSinhVien()
    {
        Console.Write(
            "\nNhap ma sinh vien can cap nhat: ");

        string ma = Console.ReadLine() ?? "";

        Student student =
            studentService.TimTheoMa(ma);

        if (student == null)
        {
            Console.WriteLine(
                "Khong tim thay sinh vien!");
            return;
        }

        Console.WriteLine(
            "\nNhap thong tin moi:");

        Student studentMoi =
            view.NhapSinhVien();

        if (studentService.CapNhatSinhVien(
            ma,
            studentMoi))
        {
            Console.WriteLine(
                "Cap nhat thanh cong!");
        }
    }

    private void XoaSinhVien()
    {
        Console.Write(
            "\nNhap ma sinh vien can xoa: ");

        string ma = Console.ReadLine() ?? "";

        Student student =
            studentService.TimTheoMa(ma);

        if (student == null)
        {
            Console.WriteLine(
                "Khong tim thay sinh vien!");
            return;
        }

        Console.Write(
            "Ban co chac chan muon xoa? (Y/N): ");

        string xacNhan =
            Console.ReadLine() ?? "";

        if (xacNhan.Equals(
            "Y",
            StringComparison.OrdinalIgnoreCase))
        {
            studentService.XoaSinhVien(ma);

            Console.WriteLine(
                "Xoa thanh cong!");
        }
    }

    private void SapXepTheoHoTen()
    {
        List<Student> ketQua =
            studentService.SapXepTheoHoTen();

        view.HienThiDanhSach(ketQua);
    }

    private void SapXepTheoDiem()
    {
        List<Student> ketQua =
            studentService.SapXepTheoDiem();

        view.HienThiDanhSach(ketQua);
    }

    private void SinhVienDiemTu8()
    {
        List<Student> ketQua =
            studentService.SinhVienDiemTu8();

        view.HienThiDanhSach(ketQua);
    }

    private void SinhVienDiemCaoNhat()
    {
        List<Student> ketQua =
            studentService.SinhVienDiemCaoNhat();

        view.HienThiDanhSach(ketQua);
    }

    private void TinhDiemTrungBinh()
    {
        double diem =
            studentService.TinhDiemTrungBinh();

        Console.WriteLine(
            $"\nDiem trung binh: {diem:F2}");
    }

    private void ThongKeTheoNganh()
    {
        Dictionary<string, int> ketQua =
            studentService.ThongKeTheoNganh();

        foreach (var item in ketQua)
        {
            Console.WriteLine(
                $"{item.Key}: {item.Value} sinh vien");
        }
    }

    private void ThongKeTheoTrangThai()
    {
        Dictionary<string, int> ketQua =
            studentService.ThongKeTheoTrangThai();

        foreach (var item in ketQua)
        {
            Console.WriteLine(
                $"{item.Key}: {item.Value} sinh vien");
        }
    }

    private void TiepTuc()
    {
        Console.WriteLine(
            "\nNhan Enter de tiep tuc...");

        Console.ReadLine();
    }
}