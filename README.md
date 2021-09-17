<h1 align="center"> Cơ Sở Dữ Liệu Phân Tán <br/>
 Đề tài: Quản Lý Vật Tư
<h1>

   <p align="center"> 
      <img src="https://hips.hearstapps.com/hmg-prod.s3.amazonaws.com/images/amazon-rivet-furniture-1533048038.jpg?crop=1.00xw:0.502xh;0,0.423xh&resize=1200:*">
   </p>
   


# [**Table Of Content**](#table-of-content)
- [**Table Of Content**](#table-of-content)
- [**Introduce**](#introduce)
- [**Publication and Subcription**](#publication-and-subcription)
- [**Link Server**](#link-server)
- [**Authorization**](#authorization)
- [**Stored Procedure**](#stored-procedure)
- [**Data Set**](#data-set)
- [**How To Build and How To Read**](#how-to-build-and-how-to-read)
- [**FAQ**](#faq)
- [**Timeline**](#timeline)
- [**Tools**](#tools)
- [**Post Script**](#post-script)
# [**Introduce**](#introduce)
   Chào các bạn, mình tên là Nguyễn Thành Phong, lớp D18CQCN03-N, khóa 2018-2023. Đây là phần đồ án của mình với môn Cơ Sở Dữ Liệu Phân do thầy Lưu Nguyễn Kì Thư giảng dạy. Đồ án này là bài thi cá nhân của riêng mình, không làm nhóm với bất kì ai. Có thể không phải là đồ án xuất sắc nhất nhưng mình mong sẽ giúp ích cho các bạn sinh viên đang đọc phần giới thiệu này của mình. Dù bạn là sinh viên mới vào năm 4 hay là những bạn không may mắn phải học lại môn này thì mình hi vọng phần diễn giải của mình sẽ giúp các bạn nhiều nhất có thể. Có một khuyết danh mà mình rất yêu thích là:
  > *Không ai trở nên nghèo túng vì cho đi*
  
 Thôi, không vòng vo Tam Quốc nữa. Mình sẽ giới thiệu cho các bạn cách xem và tham khảo đồ án của mình sao cho hiệu quả nhất nhé. Nào chúng ta bắt đầu thôi !!
 
# [**Publication and Subcription**](#publication-and-subcription)
  Với đề tài này chúng ta cần 3 server phân mảnh đề làm việc. Các bạn coi hình ảnh bên dưới để dễ hình dung
 
  Đối với phân mảnh 1 và 2: các bạn chọn hết tất cả các bảng trừ bảng sysdiagram(dbo)
 
 ![image](https://user-images.githubusercontent.com/58034430/133271162-3521acd5-7851-405d-a404-f29569b3d2bb.png)

  Đối với phân mảnh 3: các bạn chọn các cột như hình rồi nhấn next liên tục cho tới khi kết thúc tác vụ thì thôi. Do là phân mảnh dùng cho tra cứu nên cần nhân bản để đảm bảo toàn vẹn dữ liệu
 
 ![Ssms_r9bSDYDM3D](https://user-images.githubusercontent.com/58034430/133271440-2aa8c8ce-9098-4c4b-88e3-04519e7f6d9c.png)

 
# [**Link Server**](#link-server)
  Theo đề tài này chúng ta có 3 server phân mảnh. Server 1 và server 2 chứa thông tin của chi nhánh 1 và chi nhánh 2. Server chứa toàn bộ thông tin của kho & nhân viên. Do trong đề tài này chúng ta có hẳn một server phục vụ cho việc tra cứu. Do đó trong quá trình viết [**Stored Procedure**](#stored-procedure), chúng ta bắt buộc phải viết sao cho có sự tham gia của phân mảnh 3 trong một số Stored Procedure. Ví dụ như tìm kiếm xem mã nhân viên đã tồn tại hay chưa thì dùng server 3 thay vì quay về server chủ.
 
 Chúng ta sẽ có 2 LINK cho mỗi server phân mảnh 1 và 2 như sau
 
    LINK0 đi từ phân mảnh này tới phân mảnh 3
    LINK1 đi từ phân mảnh này tới phân mảnh còn lại
  
 >Note: nếu bài không có phân mảnh 3 thì chúng ta quay trở về server gốc để tìm.
# [**Authorization**](#authorization)
   Đối với phân quyền, chúng ta sẽ cùng nhau phân tích đề bài:
   > Phân quyền: Chương trình có 3 nhóm : Công ty , ChiNhanh, User
   > -  Nếu login thuộc nhóm CongTy thì login đó có thể đăng nhập vào bất kỳ chi nhánh nào để xem số liệu bằng cách chọn tên chi nhánh, và chỉ có các chức năng sau:

   >1.Chỉ có thể xem dữ liệu của phân mảnh tương ứng.
 
   >2.Xem được các báo cáo.
 
   >3.Tạo login thuộc nhóm Congty
 
 
   >-  Nếu login thuộc nhóm ChiNhanh thì chỉ cho phép toàn quyền làm việc trên chi nhánh đó , không được log vào chi nhánh khác ; Tạo login thuộc nhóm ChiNhanh, User .
   >- Nếu login thuộc nhóm User thì chỉ được quyền cập nhật dữ liệu, không được tạo tài khoản mới cho hệ thống.
Chương trình cho phép ta tạo các login, password và cho login này làm việc với quyền hạn gì. Căn cứ vào quyền này khi user login vào hệ thống, ta sẽ biết người đó được quyền làm việc với mảnh phân tán nào hay trên tất cả các phân mảnh. 

  Công Ty có thể chuyển qua lại giữa các chi nhánh để xem dữ liệu nhưng không thể thêm - xóa - sửa, có thể tạo tài khoản với cùng vai trò Công ty.
 
  Chi nhánh không thể chuyển qua lại giữa các chi nhánh để xem dữ liệu nhưng có thể thêm - xóa - sửa thoải mái với phân mảnh đang đăng nhập, có thể tạo tài khoản với vai trò Chi nhánh hoặc User.
 
  User cũng không thể chuyển qua lại giữa các chi nhánh để xem dữ liệu nhưng có thể thêm - xóa - sửa thoải mái với phân mảnh đang đăng nhập, không thể tạo tài khoản.
 
# [**Stored Procedure**](#stored-procedure)
   Ở đây, mình sẽ nói sơ lược về một số điều cần lưu ý khi viết Stored Procedure.
 
   Đầu tiên, theo kinh nghiệm của chính mình & do thầy Thư truyền đạt, chúng ta nên viết Stored Procedure ngay trên một phân mảnh để xem nó có hoạt động đúng không ? Nếu Stored Procedure hoạt động đúng thì mới quay về server gốc rồi lưu nó lại. Cuối cùng mới đẩy về các server phân mảnh.
   
   Các bước để đẩy một Stored Procedure về phân mảnh
 
    Bước 1 : Vào replication chọn phân mảnh muốn đẩy xuống
 
    Bước 2 : Nhấn chuột phải chọn Properties
 
    Bước 3 : Chọn Articles -> bỏ dấu tích "show only checked articles of the list"
 
    Bước 4 : Đánh dấu các stored procedure muốn sử dụng tại phân mảnh đó
 
    Bước 5 : Nhấn OK để kết thúc.
 
    Bước 6 : Chuột phải lại vào phân mảnh chọn "view snapshot agent status" -> start để nó đẩy xuống phân mảnh
 
   Khi các bạn tải đồ án này về máy, hãy tìm tới thư mục Stored Procedure, thư mục này chứa tất cả các Stored Procedue kèm chú thích cụ thể nhé.
 
   Một đơn vị phân tán có thể truyền xuống các server phân mảnh chỉ có thể là table - stored procedure - view - user defined function
 
   > Note: Đảm bảo dịch vụ SQL Server Agent phải đang hoạt động thì quá trình mới thành công
# [**Data Set**](#data-set)
  Phần này mình sẽ nói cho các bạn biết về chức năng của các Data Set mình sử dụng và chúng tham gia vào form nào
  1. dataSet là cái data set chứa nội dung của toàn bộ cơ sở dữ liệu. Data Set này tham gia vào mọi form chính của chương trình gồm: nhân viên, kho, vật tư, đặt hàng.
# [**How To Build and How To Read**](#how-to-build-and-how-to-read)
  Ui đọc đến đây là quá trời thứ phải học rồi. Vậy học thế nào cho hiệu quả đây nhỉ ??? Dễ lắm mình những thứ mình liệt kê bên dưới là theo thứ tự mình đã học và làm để tự xây dựng được đồ án này. Nói cách khác phần này hướng dẫn các bạn làm sao để tự mình solo môn này luôn ý, hehe 😎😎😎
 
  1. Hiểu khái niệm phân mảnh ngang là gì ? phân mảnh dọc là gì ? phân mảnh hỗn hợp là gì ?🔀
 
  2. Phân mảnh là cái chi chi ? Làm sao để phân tán cho một cơ sở dữ liệu ? 📅
 
  3. Phân quyền là cái quần què gì vậy ? ( Sao lắm phân quá zợ 💩💩💩) ? Quyền công ty làm được gì, rùi còn chi nhánh và user thì làm được những gì nhỉ ? Cái này thì phần [**Authorization**](#authorization) mình trả lời rất rõ rồi nè.
 
 4. Tạo stored procedure như nào ? Làm sao lấy được thông tin từ đăng nhập ? 😫 Phần này thì trong thư mục Stored Procedure mình có đủ rùi nè
 
 5. Làm sao để tạo form đăng nhập với DevExpress nhỉ ? 🔐
 
 6. Form chính và Form Nhân viên được tạo và kết nối với nhau ra sao ? 🤝
 
 7. Tạo mấy cái biểu mẫu báo cáo như nào ý nhỉ ?📈
 
 Mình liệt kê ra các câu hỏi này để các bạn dễ hình dung từng bước để xây dựng đồ án này. Khi bạn tự trả lời được từng câu hỏi này thì các bạn sẽ dần dần có cái nhìn bao quát cái "của nợ" này. NHƯNG, một chữ nhưng TO ĐÙNG, vẫn còn một vấn đề nữa.....
 
 UI CHA !! SAO NHIỀU CÂU HỎI QUÁ ZỢ 😵😵😵. VẬY HỌC CÁI NÀY Ở ĐÂU ĐỂ MÀ LÀM ?? Đừng lo, đừng lo. Bạn tới đúng nơi rồi đó. Mình rất hiểu tâm lý của các bạn khi gặp lại thầy Thư ( "lại" nếu như bạn đã học cấu trúc dữ liệu & giải thuật ở năm 2 của thầy ). Chắc nhiều bạn ám ảnh thầy lắm - y như mình vậy 😋😋.
 
 Và mình đã chuẩn bị cho các bạn một danh sách đầy đủ cái video cho môn cơ sở phân tán của thầy Lưu Nguyễn Kì Thư tại [**đây**](https://www.youtube.com/playlist?list=PLkPVg51dQOyYQc-jkT9BOEooS2IsaNWyH). 
 
 Điều quan trọng là những video này đều do thầy Thư trực tiếp giảng dạy và có làm hướng dẫn chi tiết nên chỉ cần các bạn chăm chỉ học theo đầy đủ thì **100%** một mình cân hết đồ án luôn 😎😎😎
 
 >Note: xem xong thì để cho mình một like 👍 video nha ! 
 
# [**FAQ**](#faq)
  FAQ hay viết tắt của cụm từ Frequently Asked Questions, là những câu hỏi thường gặp trong quá trình chúng ta làm đồ án này. Những câu hỏi được liệt kê bên dưới bao gồm những câu hỏi mình tổng hợp lại trong suốt quá trình học môn này. Bao gồm câu hỏi của sinh viên với thầy & những kiến thứ dễ gây lú do mình tự đúc kết ra trong quá trình làm nhé
  ***
  >Hỏi: Sau khi phân tán xong thì có 1 trường dữ liệu là rowguild. Vậy rowguid được sinh ra để làm gì?
 
  >Đáp: Hỗ trợ quá trình đồng bộ dữ liệu từ site phân mảnh về site chủ và ngược lại.
  ***
  >Hỏi: Thầy ơi cho em hỏi đề tài 3 phiếu nhập và phiếu xuất sao mã kho không phải là khóa ngoại vậy ạ? Script chạy lên cũng ko có luôn ạ (Tức là thiếu mã kho trong các bảng này ấy)
  
  >Đáp: Makho là khóa ngoại, các em thêm vào database nhé.
  
  >Note: Phần [**Tools**](#tools) ở cuối bài viết có chứa script chuẩn nha. 
  ***
  >Hỏi: Thầy ơi cho em hỏi phân mảnh 3 tra cứu chỉ có bảng Nhân viên , kho và chi nhánh thôi hả thầy ?
  
  >Đáp: Không có chi nhánh
  ***
  >Hỏi: Dạ thưa thầy, phần truy vấn dữ liệu, nếu trên site đang đứng mà tìm không thấy thì sẽ về site chủ để tìm hay là nhảy sang các phân mảnh khác để tìm ạ
  
  >Đáp: Về site chủ em nhé
  ***
  >Hỏi: Thầy ơi cho em hỏi, trong tập tin word đề bài, Bảng Vật Tư không có cột Số lượng tồn, bảng Nhân viên không có Trạng thái Xóa, khác so với database
Thầy cho em hỏi là có cần 2 cột đó không ạ ?
 
  >Đáp: Nên có 2 cột đó !
  ***
  >Hỏi: Chúng ta phân tán ra server 3 - Tra Cứu nhưng trong chương trình thì người đăng nhập ở vai trò nào sẽ dùng server 3 ? Nhiều đồ án khi demo chỉ đăng nhập vào chi nhánh 1 và 2 mà không thấy ai dùng server 3 để xem cả.
 
  >Đáp: Server 3 mục đích là để tra cứu, có nghĩa là đứng ở server 1 hoặc server 2 LINK tới server 3 chứ không được đứng ở ngay server 3 rồi thao tác với dữ liệu.
 
  >Chẳng hạn, ta sẽ dùng server 3 ở trong Stored Procedure, muốn kiểm tra mã của trường dữ liệu - ví dụ như mã nhân viên, mã đơn hàng -  có tồn tại ở server khác không thì dùng LINK tới server 3 rồi kiểm tra, chứ không phải đứng tại server 3 để thao tác.

  >Note: Form đăng nhập thì ở ô chọn chi nhánh chỉ được hiện chi nhánh 1 và 2 thôi. Nếu có chi nhánh 3 thì bị trừ điểm.
  ***
  >Hỏi: Em thấy trong đề không có yêu cầu server 3 là phân mảnh dọc ?
 
  >Đáp: Theo đề bài: "QLVT được đặt trên server 3: chứa thông tin các nhân viên, kho của cả 2 chi nhánh 1 và 2. Server này dùng để tra cứu thông tin của nhân viên, kho của cả 2 chi nhánh".
 
  >Đề nói như này thì phải dùng phân mảnh dọc. Vì phân mảnh dọc sẽ lấy theo cột, nên row vẫn vậy, vẫn đầy đủ, không bị tách. thỏa mãn yêu cầu là có dữ liệu của cả 2 chi nhánh. Còn nếu dùng phân mảnh ngang thì em sẽ chỉ phân mảnh một quan hệ dựa trên một vị từ được định nghĩa. VD: CHINHANH = 'CN1' -> thiếu dữ liệu của CN2.
  ***
  >Hỏi: Login Name là gì ? Username là gì ? Mà chúng gây lú thế nhỉ ?!
  
  >Đáp: 
  
  >Login Name là tài khoản chúng ta dùng để đăng nhập vào một server. Ví dụ như tài khoản SA - tài khoản phổ biến khi đăng nhập SQL Server để tăng độ bảo mật. Sau khi kết nối thành công tới một server, chọn Security -> Logins sẽ thấy tài khoản SA
  
  > Username là tài khoản mà chúng ta dùng để làm việc trên một cơ sở dữ liệu. Ví dụ trên cơ sở dữ liệu QLVT, chọn vào QLVT -> Security -> Users sẽ thấy các tài khoản có thể làm việc trên cơ sở dữ liệu này
  ***
  >Hỏi: Em chép các Stored Procedure như view_getSubcribers hoặc sp_Lay_Thong_Tin_Nhan_Vien_Tu_Login của thầy vào không trượt phát nào (!?) nhưng chạy thì nhận về lỗi "*invalid object dbo.NHANVIEN*"  hoặc "*invalid object dbo.sysmergepublications*" , không hiểu lý do vì sao?
  
  >Đáp: Đó là vì SQL Server không biết câu lệnh trên đang sử dụng cơ sở dữ liệu nào. Các bạn phải chỉ đích danh cơ sở dữ liệu đang muốn truy vấn thì SQL Server mới hiểu và thực hiện được. Chạy lệnh sau để chỉ ra cơ sở dữ liệu bạn muốn dùng:
  
    USE <database name>
  
  > Ví dụ: USE QLVT
  ***
  >Hỏi: db_dataReader, db_dataWriter, db_securityAdmin,.... rồi db_accessAdmin là gì ? Chúng dùng để làm gì ?
  
  >Đáp: chúng là những quyền mà một tài khoản kiểu login name có thể được chỉ định & quyết định xem chúng có thể làm những gì trên cơ sở dữ liệu đó.
  
  > 1.db_dataReader là quyền chỉ xem dữ liệu, không thể thêm mới hoặc sửa đổi dữ liệu
  
  > 2.db_dataWriter là quyền chỉ ghi dữ liệu, dĩ nhiên nếu ghi được thì coi như cũng đọc được dữ liệu
  
  > 3.db_securityAdmin là quyền tạo các tài khoản login name, tài khoản này dùng để đăng nhập vào server
  
  > 4.db_accessAdmin là quyền tạo các tài khoản username, tài khoản dùng để thao tác trên một cơ sơ dữ liệu nhất định
  
  > 5.db_owner là quyền cao nhất với một cơ sở dữ liệu, quyền này cho phép xem, thêm, xóa, sửa tất cả dữ liệu & có thể tạo tài khoản login name và username mà không có giới hạn nào( kiểu bạn là chủ nhà thì làm gì cũng được ấy )
  ***
  >Hỏi: Viết Stored Procedure ở đâu là hợp lý ?
  
  >Đáp: Nên viết ở Server gốc. Sau đó sẽ tùy vào từng chức năng mà đẩy xuống các server phân mảnh là hợp lý nhất.
  ***
  >Hỏi: Tạo LINK để liên kết các server với nhau có lưu ý gì không ?
  
  >Đáp: Có. Bắt buộc ở các server phân mảnh thì tên LINK phải hoàn toàn giống nhau. Ví dụ, nếu ở server thứ nhất bạn tạo ra 2 LINK
  
  > LINK0 dùng để kết nối từ server phân mảnh về server gốc
  
  > LINK1 dùng để kết nối từ server phân mảnh này đến server phân mảnh còn
  
  > Thì ở phân mảnh còn lại bạn cũng phải tạo 2 LINK với tên giống nhau. Điều này là vô cùng quan trọng bởi khi viết các Stored Procedure từ server gốc rồi đẩy về các phân mảnh thì các chữ LINK dùng trong Server phân mảnh nếu khác Server khác thì Stored Procedure đó sẽ bị lỗi & không thể hoạt động được
  ***
  >Hỏi: Mình không thích dùng C#, có được dùng ngôn ngữ khác có được không ?
 
  >Đáp: Được chứ. Thầy Thư cho phép chúng ta chọn ngôn ngữ tùy thích để xây dựng đồ án.
  ***
  >Hỏi: Mình không thích chơi DevExpress & mình muốn dùng cái khác có được không ?
  
  >Đáp: Dĩ nhiên là được rồi. Về cơ bản DevExpress là một thư viện hỗ trợ Winform. Các bạn hoàn toàn có thể dùng thư việc đều được ( làm bằng Winform truyền thống luôn cho máu )
  ***
  >Hỏi: Có 2 cách để viết Stored Procedure. Cách 1 đã được trình bình ở mục [**Stored Procedure**](#stored-procedure). Cách số 2 là viết Stored Procedure thủ công tại từng phân mảnh. Cách làm nào hiệu quả hơn ?
 
 >Đáp: Cách làm thứ nhất hay hơn. Nếu ta chỉnh sửa stored procedure trên server gốc thì sự thay đổi sẽ tự động được cập nhật xuống các server phân mảnh. Còn cách thứ 2 thì phải sửa thủ công trên từng phân mảnh.
 ***
 >Hỏi: Nếu sửa Stored Procedure trên phân mảnh thì nó có đồng bộ về các phân mảnh khác và server gốc, điều này là đúng hay sai ?
 
 >Đáp: Sai. Code chỉ đồng bộ theo một chiều từ server gốc tới các phân mảnh. Không có chiều ngược lại.
 ***
 >Hỏi: Khi không tìm được trên server hiện tại, em muốn sang phân mảnh khác để tìm thay về server gốc có được không ?
 
 >Đáp: Có 2 lý do để không nên sử dụng cách này
 
 >Lý do 1: Về lý thuyết thì được nhưng nếu chẳng may server phân mảnh đó offline thì sẽ không hoạt động được. Ngược lại, server gốc thì luôn online.
 
 >Lý do 2: Giả sử có 3 phân mảnh và thông tin cần tìm ở server 3. Tuy nhiên, khi viết stored procedure thì chúng ta lại tìm kiếm theo trình tự 1 -> 2 -> 3. Nếu chẳng may server 2 không hoạt động thì câu lệnh sẽ trả về lỗi và chấm dứt thực thi luôn. Trong khi server 3 thì lại hoạt động bình trường. Do đó về server gốc là hợp lý hơn.
 ***
 >Hỏi: Sửa dữ liệu tại server gốc thì phân mảnh có nhận được không ? Nếu ngược lại, từ server phân mảnh về server gốc thì có nhận được không ?
 
 >Đáp: Có, dữ liệu đồng bộ theo 2 chiều.
 ***
 >Hỏi: Nêu ưu và nhược điểm khi ưu tiên tìm kiếm trên site phân mảnh trước khi về site chủ.
 
 >Đáp: 
 
 >Ưu điểm: server gốc lúc nào cũng hoạt động nên luôn truy vấn được dữ liệu mong muốn
 
 >Nhược điểm: Không thể che dấu được hoàn toàn các thông tin nhạy cảm giữa các site phân mảnh. Việc cấp 1 tài khoản để vào site chủ có thể giúp người dùng đó xem được dữ liệu của site khác
 ***
 >Hỏi: Thầy cho em hỏi là Chức Năng đặt hàng thì nhân viên thuộc chi nhánh và user có được phép chỉnh sửa Mã Nhân Viên không ạ
 
 >Đáp: Lấy MANV đăng nhập áp cho các phiếu, không cho sửa MANV ( nghĩa là người đăng đăng nhập thì lấy mã nhân viên của họ áp dụng vào các phiếu luôn)
 ***
 >Hỏi: Thầy cho em hỏi là Chi nhánh với user đăng nhập vào thì thấy hết tất cả đơn đặt hàng , phiếu nhập, phiếu xuất luôn hả thầy, hay chỉ mỗi phiếu của chính họ thôi ạ 
 
 >Đáp: Thấy hết, nhưng chỉ cho chỉnh sửa các phiếu do mình lập
 ***
 >Hỏi: Thầy ơi cho em hỏi đề tài Vật Tư, NV01 có thể lập phiếu nhập trên đơn đặt hàng của NV02 không ạ?
 
 >Đáp: Không
 ***
 >Hỏi: Đề 3 QLVT trong table chi tiết đơn đặt hàng có phần đơn giá, thầy cho e hỏi lúc lập đơn đặt hàng thì đơn giá của vật tư lấy ở đâu ạ 
 
 >Đáp: Nhập tay em
# [**Timeline**](#timeline)
## **Phase 1** : **01-09-2021 to 05-09-2021**
 
  1. Phân tán cơ sở dữ liệu
 
  2. Tạo LINK server
 
  3. Phân quyền
 
 ## **Phase 2** : **06-09-2021 to 16-09-2021**
 
  1. Thiết kế form Chính
 
  2. Khởi tạo các biến toàn cục
 
  3. Thiết kế form đăng nhập
 
  4. Hoàn thiện các nút chức năng Đăng nhập và Thoát
 
  5. Thiết kết form nhân viên

  6. Hoàn thiện chức năng Thêm, Xóa & Hoàn tác
 
  7. Hoàn thiện chức năng Ghi
 
  8. Hoàn thiện chức năng Hoàn tác ngay cả khi đã nhấn Ghi để lưu vào cơ sở dữ liệu với nút Thêm và Ghi
 
  9. Thiết kế form chuyển chi nhánh
 
 10. Hoàn thiện tính năng chuyển chi nhánh
 
 11. Hoàn thiện chức năng Hoàn tác ngay cả khi đã nhấn chuyển chi nhánh.
 
  ## **Phase 3** : **16-09-2021 to 17-09-2021**
  1. Hoàn thiện toàn bộ tính năng của form vật tư
 
# [**Tools**](#tools)
  
  **Visual Studio 2019** - cái này thì quen thuộc quá rồi, ai học đến năm 4 rồi mà chưa cài thì toang CMNR
  
  **DevExpress** - thư viện hỗ trợ làm Winform siêu đẹp, siên tiện. Các bạn nhấn vào [**đây**](https://drive.google.com/file/d/1Rik18mGgDjt2xVSKkcWv3HTw5raQ2lRn/view) để tải nha. Cái này đã crack tận 16 năm rồi, dùng tẹt cmn bô luôn.
  
  **SQL Server 2014** - cái này do thầy Thư chia sẻ cho sinh viên tụi mình. Bao uy tín. Tải tại [**đây**](https://drive.google.com/file/d/12r_yzyKRxnyIA1Q2ZajFsUAMAJ_6DoA8/view) nhé.
  
  **Database Script** - cái này là phần script tiêu chuẩn do chính thầy Thư gửi cho tụi mình nha. Tải tại [**đây**](https://drive.google.com/file/d/1ahRASX5mvGY8v4JLNmdPdiXirotPikhQ/view?usp=sharing)
  
  > Note: Mình rất khuyến khích các bạn cài đặt toàn bộ những phần mềm bên trên bởi trong quá trình học thì thầy hướng dẫn trên những phần mềm này. Ngoài ra, nếu chẳng may gặp lỗi gì đó, các bạn có thể hỏi thầy hoặc bạn bè của mình dễ hơn so với việc chọn làm bằng một phần mềm khác.

# [**Post Script**](#post-script)
 Ngày bắt đầu: 01-09-2021
 
 Ngày kết thúc: xx-xx-2021
 
 # [**Made with 💘 and C# <img src="https://www.vectorlogo.zone/logos/dotnet/dotnet-ar21.svg" width="60">**](#made-with-love-and-c)
