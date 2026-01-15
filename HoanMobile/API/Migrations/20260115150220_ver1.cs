using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Migrations
{
    /// <inheritdoc />
    public partial class ver1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "chatLieus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chatLieus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "chucVus",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chucVus", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "giamGias",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: true),
                    SoTienKhuyenMai = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: true),
                    PhanTramKhuyenMai = table.Column<int>(type: "int", nullable: true),
                    SoTienToiThieu = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: true),
                    GiaTriToiDa = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: true),
                    NgayBatDau = table.Column<DateTime>(type: "datetime2", nullable: true),
                    NgayKetThuc = table.Column<DateTime>(type: "datetime2", nullable: true),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Kieu = table.Column<bool>(type: "bit", nullable: true),
                    ApDungSanPham = table.Column<bool>(type: "bit", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    DotGiamGia = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giamGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "hinhThucThanhToans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hinhThucThanhToans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "KichCos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KichCos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "loais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_loais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nguoiDungs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ho = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Sdt = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nguoiDungs", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhaCungCaps",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaCungCaps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "nhaXuatBans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhaXuatBans", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tacGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tacGias", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "theLoais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_theLoais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "combos",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LoaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_combos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_combos_loais_LoaiId",
                        column: x => x.LoaiId,
                        principalTable: "loais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "khachHangs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_khachHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_khachHangs_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "nhanViens",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NgayVaoLam = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ChucVuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_nhanViens", x => x.Id);
                    table.ForeignKey(
                        name: "FK_nhanViens_chucVus_ChucVuId",
                        column: x => x.ChucVuId,
                        principalTable: "chucVus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_nhanViens_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "taiKhoans",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTaoTk = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_taiKhoans", x => x.Id);
                    table.ForeignKey(
                        name: "FK_taiKhoans_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "diaChis",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DiaChiCuThe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    QuanHuyen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    XaPhuong = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_diaChis", x => x.Id);
                    table.ForeignKey(
                        name: "FK_diaChis_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_diaChis_nhaCungCaps_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "nhaCungCaps",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "products",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TheLoaiId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThuongHieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_products_nhaXuatBans_ThuongHieuId",
                        column: x => x.ThuongHieuId,
                        principalTable: "nhaXuatBans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_products_tacGias_TheLoaiId",
                        column: x => x.TheLoaiId,
                        principalTable: "tacGias",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "hoaDons",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoaiHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TongTien = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    TongTienSauKhiGiam = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiamGiaId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    NhanVienId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KhachHangId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HinhThucThanhToanId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDons_giamGias_GiamGiaId",
                        column: x => x.GiamGiaId,
                        principalTable: "giamGias",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_hinhThucThanhToans_HinhThucThanhToanId",
                        column: x => x.HinhThucThanhToanId,
                        principalTable: "hinhThucThanhToans",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_khachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "khachHangs",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDons_nhanViens_NhanVienId",
                        column: x => x.NhanVienId,
                        principalTable: "nhanViens",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "chiTietProducts",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MauSacId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChatLieuId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    NhaCungCapId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BoNhoTrongId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Gia = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    SoTrang = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    ProductId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietProducts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chiTietProducts_KichCos_BoNhoTrongId",
                        column: x => x.BoNhoTrongId,
                        principalTable: "KichCos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietProducts_chatLieus_ChatLieuId",
                        column: x => x.ChatLieuId,
                        principalTable: "chatLieus",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietProducts_nhaCungCaps_NhaCungCapId",
                        column: x => x.NhaCungCapId,
                        principalTable: "nhaCungCaps",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietProducts_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietProducts_theLoais_MauSacId",
                        column: x => x.MauSacId,
                        principalTable: "theLoais",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "anhs",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DuongDan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    NguoiDungId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ChiTietProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_anhs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_anhs_chiTietProducts_ChiTietProductId",
                        column: x => x.ChiTietProductId,
                        principalTable: "chiTietProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_anhs_nguoiDungs_NguoiDungId",
                        column: x => x.NguoiDungId,
                        principalTable: "nguoiDungs",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "chiTietCombos",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    ComboId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChiTietProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietCombos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chiTietCombos_chiTietProducts_ChiTietProductId",
                        column: x => x.ChiTietProductId,
                        principalTable: "chiTietProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_chiTietCombos_combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "combos",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "chiTietGiamGias",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ChiTietProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    GiamGiaId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_chiTietGiamGias", x => x.Id);
                    table.ForeignKey(
                        name: "FK_chiTietGiamGias_chiTietProducts_ChiTietProductId",
                        column: x => x.ChiTietProductId,
                        principalTable: "chiTietProducts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_chiTietGiamGias_giamGias_GiamGiaId",
                        column: x => x.GiamGiaId,
                        principalTable: "giamGias",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "gioHangs",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    TongGia = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    ComboId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    ChiTietProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    KhachHangId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_gioHangs", x => x.Id);
                    table.ForeignKey(
                        name: "FK_gioHangs_chiTietProducts_ChiTietProductId",
                        column: x => x.ChiTietProductId,
                        principalTable: "chiTietProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_gioHangs_combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "combos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_gioHangs_khachHangs_KhachHangId",
                        column: x => x.KhachHangId,
                        principalTable: "khachHangs",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "hoaDonChiTiets",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Soluong = table.Column<int>(type: "int", nullable: false),
                    TrangThai = table.Column<bool>(type: "bit", nullable: false),
                    ThanhTien = table.Column<decimal>(type: "decimal(20,2)", precision: 20, scale: 2, nullable: false),
                    HoaDonId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ChiTietProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ComboId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hoaDonChiTiets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_chiTietProducts_ChiTietProductId",
                        column: x => x.ChiTietProductId,
                        principalTable: "chiTietProducts",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_combos_ComboId",
                        column: x => x.ComboId,
                        principalTable: "combos",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_hoaDonChiTiets_hoaDons_HoaDonId",
                        column: x => x.HoaDonId,
                        principalTable: "hoaDons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "trangThais",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    HoaDonChiTietId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThoiGian = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LyDo = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trangThais", x => x.Id);
                    table.ForeignKey(
                        name: "FK_trangThais_hoaDonChiTiets_HoaDonChiTietId",
                        column: x => x.HoaDonChiTietId,
                        principalTable: "hoaDonChiTiets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_anhs_ChiTietProductId",
                table: "anhs",
                column: "ChiTietProductId");

            migrationBuilder.CreateIndex(
                name: "IX_anhs_NguoiDungId",
                table: "anhs",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietCombos_ChiTietProductId",
                table: "chiTietCombos",
                column: "ChiTietProductId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietCombos_ComboId",
                table: "chiTietCombos",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietGiamGias_ChiTietProductId",
                table: "chiTietGiamGias",
                column: "ChiTietProductId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietGiamGias_GiamGiaId",
                table: "chiTietGiamGias",
                column: "GiamGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietProducts_BoNhoTrongId",
                table: "chiTietProducts",
                column: "BoNhoTrongId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietProducts_ChatLieuId",
                table: "chiTietProducts",
                column: "ChatLieuId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietProducts_MauSacId",
                table: "chiTietProducts",
                column: "MauSacId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietProducts_NhaCungCapId",
                table: "chiTietProducts",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_chiTietProducts_ProductId",
                table: "chiTietProducts",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_combos_LoaiId",
                table: "combos",
                column: "LoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_diaChis_NguoiDungId",
                table: "diaChis",
                column: "NguoiDungId");

            migrationBuilder.CreateIndex(
                name: "IX_diaChis_NhaCungCapId",
                table: "diaChis",
                column: "NhaCungCapId");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_ChiTietProductId",
                table: "gioHangs",
                column: "ChiTietProductId");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_ComboId",
                table: "gioHangs",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_gioHangs_KhachHangId",
                table: "gioHangs",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_ChiTietProductId",
                table: "hoaDonChiTiets",
                column: "ChiTietProductId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_ComboId",
                table: "hoaDonChiTiets",
                column: "ComboId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDonChiTiets_HoaDonId",
                table: "hoaDonChiTiets",
                column: "HoaDonId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_GiamGiaId",
                table: "hoaDons",
                column: "GiamGiaId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_HinhThucThanhToanId",
                table: "hoaDons",
                column: "HinhThucThanhToanId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_KhachHangId",
                table: "hoaDons",
                column: "KhachHangId");

            migrationBuilder.CreateIndex(
                name: "IX_hoaDons_NhanVienId",
                table: "hoaDons",
                column: "NhanVienId");

            migrationBuilder.CreateIndex(
                name: "IX_khachHangs_NguoiDungId",
                table: "khachHangs",
                column: "NguoiDungId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_ChucVuId",
                table: "nhanViens",
                column: "ChucVuId");

            migrationBuilder.CreateIndex(
                name: "IX_nhanViens_NguoiDungId",
                table: "nhanViens",
                column: "NguoiDungId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_products_TheLoaiId",
                table: "products",
                column: "TheLoaiId");

            migrationBuilder.CreateIndex(
                name: "IX_products_ThuongHieuId",
                table: "products",
                column: "ThuongHieuId");

            migrationBuilder.CreateIndex(
                name: "IX_taiKhoans_NguoiDungId",
                table: "taiKhoans",
                column: "NguoiDungId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_trangThais_HoaDonChiTietId",
                table: "trangThais",
                column: "HoaDonChiTietId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "anhs");

            migrationBuilder.DropTable(
                name: "chiTietCombos");

            migrationBuilder.DropTable(
                name: "chiTietGiamGias");

            migrationBuilder.DropTable(
                name: "diaChis");

            migrationBuilder.DropTable(
                name: "gioHangs");

            migrationBuilder.DropTable(
                name: "taiKhoans");

            migrationBuilder.DropTable(
                name: "trangThais");

            migrationBuilder.DropTable(
                name: "hoaDonChiTiets");

            migrationBuilder.DropTable(
                name: "chiTietProducts");

            migrationBuilder.DropTable(
                name: "combos");

            migrationBuilder.DropTable(
                name: "hoaDons");

            migrationBuilder.DropTable(
                name: "KichCos");

            migrationBuilder.DropTable(
                name: "chatLieus");

            migrationBuilder.DropTable(
                name: "nhaCungCaps");

            migrationBuilder.DropTable(
                name: "products");

            migrationBuilder.DropTable(
                name: "theLoais");

            migrationBuilder.DropTable(
                name: "loais");

            migrationBuilder.DropTable(
                name: "giamGias");

            migrationBuilder.DropTable(
                name: "hinhThucThanhToans");

            migrationBuilder.DropTable(
                name: "khachHangs");

            migrationBuilder.DropTable(
                name: "nhanViens");

            migrationBuilder.DropTable(
                name: "nhaXuatBans");

            migrationBuilder.DropTable(
                name: "tacGias");

            migrationBuilder.DropTable(
                name: "chucVus");

            migrationBuilder.DropTable(
                name: "nguoiDungs");
        }
    }
}
