# 2421comp1064

##1. Dựng lại database
(2.Labs ==> EStoreResources ==> MyEStoreDB.sql)

## 2. Tạo mới project

##3. Cài thư viện (chú ý version = .NET Core)
(Right click prject => Manage Nuget Packages...=> Browse)
`Microsoft.EntityFrameworkCore
Microsoft.EntityFrameworkCore.SqlServer
Microsoft.EntityFrameworkCore.Tools`

## 4. Chuẩn bị chuỗi kết nối
`Server=.; Database=MyeStore; Integrated Security=True;`


## 5. Tạo entity từ database (Database first)
- Vào menu Tools ==> Nuget Package Manager ==> Package Manager Console (PM)
- Gõ lệnh để generate entities bỏ trong thư mục Entities
PM> Scaffold-DbContext "Server=.; Database=MyeStore; Integrated Security=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Entities -f

## 6. Lưu trữ chuỗi kết nối
Mở appsettings.json và thêm:
`  "ConnectionStrings": {
    "MyEstore": "Server=.; Database=MyeStore; Integrated Security=True;"
  }
`

## 7. Đăng ký dùng DbContext
Mở file Program.cs thêm trước mục `var app = builder.Build();` phần đăng ký:
`builder.Services.AddDbContext<MyeStoreContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("MyEstore")));
`

===============

# Thao tác trên Entity
- Giả sử đã có biến _context đang giữ DbContext
- Thao tác: _context.Add(obj) / _context.Update(obj) / _context.Remove(obj)
- Lưu: _context.SaveChanges();