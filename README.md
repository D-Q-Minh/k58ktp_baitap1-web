##### Sinh viên: Dương Quang Minh
MSSS: K225480106047
### Môn: Phát triển ứng dụng trên nền web
### Bài 1:
#### TẠO SOLUTION GỒM CÁC PROJECT SAU:
##### 
 1. DLL đa năng, keyword: c# window library -> Class Library (.NET Framework) bắt buộc sử dụng .NET Framework 2.0: giải bài toán bất kỳ, độc lạ càng tốt, phải có dấu ấn cá nhân trong kết quả, biên dịch ra DLL. DLL độc lập vì nó ko nhập, ko xuất, nó nhận input truyền vào thuộc tính của nó, và trả về dữ liệu thông qua thuộc tính khác, hoặc thông qua giá trị trả về của hàm. Nó độc lập thì sẽ sử dụng được trên app dạng console (giao diện dòng lệnh - đen sì), cũng sử dụng được trên app desktop (dạng cửa sổ), và cũng sử dụng được trên web form (web chạy qua iis).
 2. Console app, bắt buộc sử dụng .NET Framework 2.0, sử dụng được DLL trên: nhập được input, gọi DLL, hiển thị kết quả, phải có dấu án cá nhân. keyword: c# window Console => Console App (.NET Framework), biên dịch ra EXE
 3. Windows Form Application, bắt buộc sử dụng .NET Framework 2.0**, sử dụng được DLL đa năng trên, kéo các control vào để có thể lấy đc input, gọi DLL truyền input để lấy đc kq, hiển thị kq ra window form, phải có dấu án cá nhân; keyword: c# window Desktop => Windows Form Application (.NET Framework), biên dịch ra EXE
 4. Web đơn giản, bắt buộc sử dụng .NET Framework 2.0, sử dụng web server là IIS, dùng file hosts để tự tạo domain, gắn domain này vào iis, file index.html có sử dụng html css js để xây dựng giao diện nhập được các input cho bài toán, dùng mã js để tiền xử lý dữ liệu, js để gửi lên backend. backend là api.aspx, trong code của api.aspx.cs thì lấy được các input mà js gửi lên, rồi sử dụng được DLL đa năng trên. kết quả gửi lại json cho client, js phía client sẽ nhận được json này hậu xử lý để thay đổi giao diện theo dữ liệu nhận dược, phải có dấu án cá nhân. keyword: c# window web => ASP.NET Web Application (.NET Framework) + tham khảo link chatgpt thầy gửi. project web này biên dịch ra DLL, phải kết hợp với IIS mới chạy được.

#### Bài làm:
##### Bài: kiểm tra số nguyên tố
1. DDL
 - create a new project -> chọn class library (.NET Framework 2.0)
<img width="1187" height="182" alt="1" src="https://github.com/user-attachments/assets/c958ba4f-1a51-4e48-8dfb-52d9d6704cd1" />
<img width="573" height="278" alt="2" src="https://github.com/user-attachments/assets/aa4cddbc-68af-46cc-bd2c-d173b2fe16b1" />
 - build solution, được file .dll
<img width="1003" height="613" alt="3" src="https://github.com/user-attachments/assets/b05588c3-288b-4d04-9bc1-ebaa2b2a346d" />
<img width="625" height="153" alt="4" src="https://github.com/user-attachments/assets/1b81c445-22a0-40f3-9546-33d9e50fcd13" />
2. 
