use master
go
create database DoAnQLTV
go

use DoAnQLTV
go

set dateformat dmy;
go

-- Tạo bảng Sách
create table tblSach
(
	MaSach varchar(10) constraint pk_tblSach primary key,
	NgNhapSach date,
	TenSach nvarchar(50),
	TheLoai nvarchar(50),
	TacGia nvarchar(50),
	NXB nvarchar(50),
	NamXB int,
	SLNhap int,
	TriGia int,
	TinhTrang nvarchar(50),
	Ghichu nvarchar(50),
)
go


-- Tạo bảng Độc Giả
create table tblDocGia
(
	MaDG varchar(10) constraint pk_tblDocGia primary key,
	TenDG nvarchar(50),
	GioiTinhDG nvarchar(50),
	NgaySinhDG date,
	EmailDG nvarchar(50),
	DiaChiDG nvarchar(50),
	LoaiDG nvarchar(50),
	GhiChu nvarchar(50),
	TenTaiKhoanDG varchar(50),
	MatKhauDG varchar(50),
	NgLapThe date,
	TongNo int,
)
go


-- Tạo bảng Tài khoản thủ thư
create table tblThuThu
(
	MaTT varchar(10) constraint pk_tblThuThu primary key,
	TenTT nvarchar(50),
	GioiTinhTT nvarchar(50),
	NgaySinhTT date,
	EmailTT nvarchar(50),
	DiaChiTT nvarchar(50),
	GhiChu nvarchar(50),
	TaiKhoanTT varchar(50),
	MatKhauTT varchar(50),
)
go

-- Tạo bảng Mượn Trả
create table tblHSPhieuMuon
(
	MaPhieu varchar(10) primary key,
	MaDG varchar(10) foreign key references tblDocgia(MaDG),
	MaSach varchar(10) foreign key references tblSach(MaSach),
	NgayMuon date,
	NgayTra date,
	SLMuon int,
	TinhTrang nvarchar(50),
	GhiChu nvarchar(50)
)
go


-- Tạo bảng Phiếu mượn
create table ChiTietPM
(
	MaCTPT VARCHAR(10) PRIMARY KEY,
	MaSach VARCHAR(10) FOREIGN KEY REFERENCES tblSach(MaSach),
	NgayThang DATE,
	SoLanMuon INT
)
go


-- Tạo bảng Tham số
Create table ThamSo
(
	TenTS varchar(50),
	GiaTri int
)
go


-- Chèn dữ liệu vào bảng Thamso
insert into ThamSo values ('SoTuoiDGMin', 18)
insert into ThamSo values ('SoTuoiDGMax', 55)
insert into ThamSo values ('GiaTriThe', 6)
insert into ThamSo values ('ThoiGianXB', 8)
insert into ThamSo values ('TienPhat', 1000)
insert into ThamSo values ('SoSachMuonToiDa', 5)
insert into ThamSo values ('SoNgayMuonToiDa', 4)
go



-- Chèn dữ liệu bảng tblThuThu
insert into tblThuThu values ('TT001',N'Đỗ Xuân Trường',N'Nam','15/06/2003','doxuantruong@gmail.com',N'115 Lê Đức Thọ, Gò Vấp','...','TT001','123')
insert into tblThuThu values ('TT002',N'Lê Trung Kiên',N'Nam','16/07/2003','letrungkien@gmail.com',N'115 Lê Đức Thọ, Gò Vấp','...','TT002','123')


-- Chèn dữ liệu bảng tblSach
insert into tblSach values ('MS001','20/06/2005',N'Lập trình Windown',N'A',N'Nguyễn Xuân Nam',N'NXB Hồng Bàng','2022','100','50000',N'Mới','...')
insert into tblSach values ('MS002','25/05/2004',N'Lập trình Web',N'A',N'Lê Hồng Nhân',N'NXB Giáo Dục','2023','100','50000',N'Mới','...')
insert into tblSach values ('MS003','20/06/2005',N'Lập trình HDT',N'A',N'Nguyễn Đức Phương',N'NXB Hồng Bàng','2021','100','30000',N'Mới','...')
insert into tblSach values ('MS004','25/05/2004',N'Lập trình SQL',N'A',N'Nguyễn Xuân Nam',N'NXB Hồng Bàng','2022','100','40000',N'Mới','...')
insert into tblSach values ('MS005','20/06/2005',N'Thiết bị công nghệ hiện đại',N'B',N'Trần Xuân Bách',N'NXB Thanh Niên','2023','100','60000',N'Mới','...')
insert into tblSach values ('MS006','25/05/2004',N'Khoa học quanh ta',N'B',N'Trần Văn Chung',N'NXB Giáo Dục','2022','100','40000',N'Mới','...')
insert into tblSach values ('MS007','20/06/2005',N'Úng dụng công nghệ',N'B',N'Nguyễn Hoài Nhâm',N'NXB Hồng Bàng','2023','100','50000',N'Mới','...')
insert into tblSach values ('MS008','25/05/2004',N'Bạn và Tôi',N'C',N'Lệ Thu',N'NXB Trẻ','2021','100','50000',N'Mới','...')
insert into tblSach values ('MS009','20/06/2005',N'Ngày Ấy',N'C',N'Nguyễn Hoài Nhớ',N'NXB Thanh Niên','2021','100','40000',N'Mới','...')
insert into tblSach values ('MS010','25/05/2004',N'Tôi đi tìm tôi',N'C',N'Phạm Đức',N'NXB Thanh Niên','2024','100','20000',N'Mới','...')
go

-- Chèn dữ liệu bảng tblDocGia
insert into tblDocGia values ('DG001',N'Huỳnh Gia Bảo',N'Nam','15/06/2003',N'huynhgiabao@gmail.com',N'115 Lê Đức Thọ, Gò Vấp',N'X','...','DG001','123','02/11/2024', 0)
insert into tblDocGia values ('DG002',N'Nguyễn Đức Trung Kiên',N'Nam','14/04/2003',N'nguyenductrungkien@gmail.com',N'115 Nguyễn Oanh, Gò Vấp',N'X','...','DG002','123','04/11/2024', 0)
insert into tblDocGia values ('DG003',N'Hoàng Tất Quý',N'Nam','15/01/2003',N'hoangtatquy@gmail.com',N'115 Lê Văn Thọ, Gò Vấp',N'X','...','DG003','123','02/11/2024', 0)
insert into tblDocGia values ('DG004',N'Phùng Nam Thanh',N'Nam','11/03/2003',N'phungnamthanh@gmail.com',N'115 Hồ Thị Hương, Tân Bình',N'X','...','DG004','123','04/11/2024', 0)
insert into tblDocGia values ('DG005',N'Nguyễn Đặng Thanh Huy',N'Nam','23/10/2003',N'nguyendangthanhhuy@gmail.com',N'119 Lê Đức Thọ, Gò Vấp',N'X','...','DG005','123','02/11/2024', 0)
go



-- Chèn dữ liệu bảng tblHSPhieuMuon
insert into tblHSPhieuMuon values ('MP001','DG001','MS001','01/12/2024','21/12/2024','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP002','DG001','MS002','01/12/2024','21/12/2024','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP003','DG002','MS005','02/12/2024','22/12/2024','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP004','DG003','MS002','02/12/2024','22/12/2024','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP005','DG004','MS007','03/12/2024','21/12/2024','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP006','DG004','MS003','03/12/2024','21/12/2024','1',N'Mới','...')
insert into tblHSPhieuMuon values ('MP007','DG004','MS004','04/12/2024','22/12/2024','1',N'Mới','...')
go


