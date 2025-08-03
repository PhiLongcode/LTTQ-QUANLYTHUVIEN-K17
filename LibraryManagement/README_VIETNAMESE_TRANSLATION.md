# Dịch Nội Dung Hệ Thống Quản Lý Thư Viện

## Tổng quan
Dự án này đã được dịch từ tiếng Ả Rập sang tiếng Việt để phù hợp với người dùng Việt Nam.

## Những gì đã được dịch

### 1. Form Đăng nhập (FRM_LOGİN)
- **اسم المستخدم** → **Tên đăng nhập**
- **كلمة المرور** → **Mật khẩu**
- **تسجيل الدخول** → **Đăng nhập**
- **نظام المكتبة الإلكترونية** → **Hệ thống Quản lý Thư viện**
- **أهلاً و سهلاً** → **Chào mừng bạn**

### 2. Form Chính (FRM_MAIN)
- **الرئيسية** → **Trang chủ**
- **الكتب** → **Sách**
- **الطلاب** → **Sinh viên**
- **الاستعارة** → **Mượn sách**
- **البيع** → **Bán sách**
- **المستخدمين** → **Người dùng**
- **الاصناف** → **Danh mục**
- **مدير** → **Quản trị viên**

### 3. Các nút chức năng
- **اضافه** → **Thêm**
- **تعديل** → **Sửa**
- **حذف** → **Xóa**
- **تفاصيل** → **Chi tiết**
- **استعاره** → **Mượn sách**
- **اضافه كتاب** → **Thêm sách**
- **اضافه طالب** → **Thêm sinh viên**
- **اضافه صنف** → **Thêm danh mục**
- **بيع كتاب** → **Bán sách**

### 4. Thống kê
- **عدد الكتب** → **Số lượng sách**
- **عدد الطلاب** → **Số lượng sinh viên**
- **الاستعارة** → **Sách mượn**
- **عدد المبيعات** → **Số lượng bán**

### 5. Form Báo cáo (FRM_RAPORT)
- **معلومات عامه** → **Thông tin chung**
- **التاريخ** → **Ngày tháng**
- **الصلاحيه** → **Quyền hạn**
- **اسم مقدم التقرير** → **Tên người báo cáo**
- **ملخص التقرير** → **Tóm tắt báo cáo**
- **طباعه التقرير** → **In báo cáo**
- **مشاهده الطباعه** → **Xem trước in**
- **اعدادات الطباعه** → **Cài đặt in**

### 6. Form Bán sách (FRM_MAKESELL)
- **اختر الكتاب** → **Chọn sách**
- **المعلومات الاساسيه** → **Thông tin cơ bản**
- **السعر** → **Giá**
- **اختر المشتري** → **Chọn người mua**

### 7. Chi tiết Sinh viên (FRM_DETAİLSST)
- **رقم الهويه** → **Số CMND**
- **البريد الالكتروني** → **Email**
- **رقم الهاتف** → **Số điện thoại**
- **عنوان السكن** → **Địa chỉ**
- **القسم الدراسي** → **Khoa**
- **اسم المدرسه او الكلية** → **Tên trường/đại học**
- **اسم الطالب** → **Tên sinh viên**

### 8. Chi tiết Sách (FRM_DETAİLSBOOKS)
- **تاريخ النشر** → **Ngày xuất bản**
- **صنف الكتاب** → **Danh mục sách**
- **السعر** → **Giá**

### 9. Thông báo
- **تم التعديل بنجاح** → **Sửa đổi thành công**
- **يجب ان تكون كلمه المرور اكبر من 8 احرف** → **Mật khẩu phải có ít nhất 8 ký tự**

## Cách sử dụng

### Chạy script dịch
```bash
python translate_to_vietnamese.py
```

### Khôi phục từ backup
Nếu cần khôi phục về phiên bản tiếng Ả Rập, các file backup đã được tạo với đuôi `.backup`:
```bash
# Ví dụ khôi phục file FRM_LOGİN.Designer.cs
cp PresentationLayer/FRM_LOGİN.Designer.cs.backup PresentationLayer/FRM_LOGİN.Designer.cs
```

## Cấu trúc file

### File đã được dịch
- `PresentationLayer/FRM_LOGİN.Designer.cs` - Form đăng nhập
- `PresentationLayer/FRM_MAIN.Designer.cs` - Form chính
- `PresentationLayer/FRM_RAPORT.Designer.cs` - Form báo cáo
- `PresentationLayer/FRM_MAKESELL.Designer.cs` - Form bán sách
- `PresentationLayer/FRM_DETAİLSST.Designer.cs` - Chi tiết sinh viên
- `PresentationLayer/FRM_DETAİLSBOOKS.Designer.cs` - Chi tiết sách
- `PresentationLayer/FRM_DİALOG.Designer.cs` - Dialog thông báo
- `PresentationLayer/FRM_EDİTED.Designer.cs` - Thông báo sửa đổi
- `PresentationLayer/FRM_DELETED.Designer.cs` - Thông báo xóa
- Và các file khác...

### File backup
Tất cả file đã được tạo backup với đuôi `.backup` để có thể khôi phục nếu cần.

## Lưu ý

1. **Font chữ**: Dự án sử dụng font "LBC" cho tiếng Ả Rập. Để hiển thị tiếng Việt tốt, có thể cần thay đổi font sang font hỗ trợ tiếng Việt như "Arial", "Times New Roman", hoặc "Segoe UI".

2. **Encoding**: Tất cả file đã được lưu với encoding UTF-8 để hỗ trợ tiếng Việt.

3. **Kiểm tra**: Sau khi dịch, nên build và test lại ứng dụng để đảm bảo tất cả text hiển thị đúng.

## Tác giả
Script dịch được tạo bởi AI Assistant để hỗ trợ việc chuyển đổi ngôn ngữ cho dự án Library Management System. 