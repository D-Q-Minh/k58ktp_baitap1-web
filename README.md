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

2. Tạo Console app
Tạo project console app ( .NET Framework) thêm Reference tới b1.dll và sửa lại code trong Program.cs
<img width="736" height="103" alt="5" src="https://github.com/user-attachments/assets/1824fe2f-4d3b-4dca-ab8c-4f2ad9f9b8cb" />
<img width="968" height="629" alt="10" src="https://github.com/user-attachments/assets/858da558-499f-4737-9d0d-3b318ae6b6d4" />

references đến file .dll
<img width="445" height="124" alt="6" src="https://github.com/user-attachments/assets/82a1e9bc-7a3c-4d60-8e84-2731773ed0be" />
<img width="740" height="264" alt="7" src="https://github.com/user-attachments/assets/968b9d3d-da1e-46ba-99d8-f8d8bc0d1370" />

Chuột phải vào project console ---> Set as startup project
<img width="178" height="27" alt="8" src="https://github.com/user-attachments/assets/00d01c57-ec6d-45e1-971c-d937511ec982" />
<img width="304" height="43" alt="9" src="https://github.com/user-attachments/assets/6bace90b-9b27-43c6-8efa-9e5c74dd973c" />

Chạy console app
<img width="456" height="101" alt="11" src="https://github.com/user-attachments/assets/fe1d7636-8dfe-4e65-af03-b4abfb3bdee2" />

3. Windows Form Application
Tạo project Windows Form Application (.NET Framework)
<img width="591" height="98" alt="image" src="https://github.com/user-attachments/assets/d37685dd-3243-4f3f-acd4-ea4a39cbafdd" />

thêm Reference tới b1.dll
<img width="234" height="28" alt="13" src="https://github.com/user-attachments/assets/b207894b-5a22-43bb-9685-756e22773f81" />
<img width="181" height="28" alt="14" src="https://github.com/user-attachments/assets/da47f536-7098-43c3-856b-c1a5d0e15905" />
<img width="742" height="536" alt="15" src="https://github.com/user-attachments/assets/f17a3b1a-88a2-4129-a9d4-5f8ccf9353e0" />
