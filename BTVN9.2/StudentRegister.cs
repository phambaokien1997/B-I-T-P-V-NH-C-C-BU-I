using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTVN9._2
{
    class StudentRegister : IStudentRegister
    {
        private List<(Student hocVien, Course khoaHoc, DateTime ngayDangKy)> danhSachDangKy = new List<(Student, Course, DateTime)> ();
        public void Dangky(Student hocVien, Course khoaHoc, DateTime ngayDangKy)
        {
            danhSachDangKy.Add((hocVien,khoaHoc,ngayDangKy));
        }
        public void DSHienThiDKVoiChietKhau()
        {
            Console.WriteLine("Danh sách học viên đăng ký có mức giảm giá từ cao đến thấp:");
            foreach (var d in danhSachDangKy)
            {
                double chietKhauPhanTram = 0;
                if ((d.ngayDangKy - d.khoaHoc.NgayKhaiGiang).TotalDays >= 30)
                {
                    chietKhauPhanTram = 0.15;
                }
                else if ((d.ngayDangKy - d.khoaHoc.NgayKhaiGiang).TotalDays >= 10)
                {
                    chietKhauPhanTram = 0.10;
                }
                double hocPhiSauKhiChietKhau = d.khoaHoc.HocPhi * (1 - chietKhauPhanTram);
                Console.WriteLine("Họ tên: {0}, Ngày Sinh: {1}, Ngày Đăng Ký: {2}, Học Phí: {3}, Học Phí Sau Chiết Khấu : {4}", d.hocVien.HoTen, d.hocVien.NgaySinh , d.ngayDangKy, d.khoaHoc.HocPhi, hocPhiSauKhiChietKhau);
            }    
        }
    }
}
