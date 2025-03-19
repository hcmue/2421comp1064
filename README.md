# 2421comp1064

### 1. Demo Upload file

### 2. Demo EF Core Code First
- Tạo Entity Model (các class map với table trong DB)
- Tạo lớp DbContext: chỉ ra gồm những Entity nào
- Thực hiện Migration

### 3. Cài packages (cả code first và database first)
- Chuột phải project ==> Manage Nuget Packages... ==> Browse ==> gõ và chọn tên packages
	+ Microsoft.EntityFrameworkCore
	+ Microsoft.EntityFrameworkCore.SqlServer
	+ Microsoft.EntityFrameworkCore.Tools
	(chú ý version EF core phải bằng version của ASP.NET Core)