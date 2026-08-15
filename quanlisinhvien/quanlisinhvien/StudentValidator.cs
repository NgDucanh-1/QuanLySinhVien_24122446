using System;
using System.Text.RegularExpressions;

public static class StudentValidator
{
    public static bool KiemTraMa(string ma)
    {
        return !string.IsNullOrWhiteSpace(ma);
    }

    public static bool KiemTraHoTen(string hoTen)
    {
        return !string.IsNullOrWhiteSpace(hoTen);
    }

    public static bool KiemTraDiem(double diem)
    {
        return diem >= 0 && diem <= 10;
    }

    public static bool KiemTraEmail(string email)
    {
        if (string.IsNullOrWhiteSpace(email))
            return false;

        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        return Regex.IsMatch(email, pattern);
    }

    public static bool KiemTraNgaySinh(DateTime ngaySinh)
    {
        return ngaySinh <= DateTime.Now;
    }
}