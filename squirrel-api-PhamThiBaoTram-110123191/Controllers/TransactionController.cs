using Microsoft.AspNetCore.Mvc;
using squirrel_api_PhamThiBaoTram_110123191.Models;

namespace squirrel_api_PhamThiBaoTram_110123191.Controllers
{
    [ApiController]
    [Route("api")]
    public class TransactionController : ControllerBase
    {
        private static List<GiaoDich> danhSachGiaoDich = new List<GiaoDich>
        {
            new GiaoDich
            {
                Id = 1,
                SoTaiKhoan = "1023456789",
                SoTien = 500000,
                LoaiGiaoDich = "Nap tien"
            },
            new GiaoDich
            {
                Id = 2,
                SoTaiKhoan = "1023456789",
                SoTien = 200000,
                LoaiGiaoDich = "Rut tien"
            },
            new GiaoDich
            {
                Id = 3,
                SoTaiKhoan = "1098765432",
                SoTien = 1000000,
                LoaiGiaoDich = "Nap tien"
            },
            new GiaoDich
            {
                Id = 4,
                SoTaiKhoan = "1098765432",
                SoTien = 150000,
                LoaiGiaoDich = "Rut tien"
            },
            new GiaoDich
            {
                Id = 5,
                SoTaiKhoan = "1055566677",
                SoTien = 300000,
                LoaiGiaoDich = "Nap tien"
            }
        };

        [HttpGet("giaodich")]
        public IActionResult GetGiaoDichNapTien()
        {
            var ketQua = danhSachGiaoDich
                .Where(gd => gd.LoaiGiaoDich == "Nap tien")
                .ToList();

            return Ok(ketQua);
        }
    }
}