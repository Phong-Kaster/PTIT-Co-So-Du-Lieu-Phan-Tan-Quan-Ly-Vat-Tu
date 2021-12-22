<h1 align="center"> Cơ Sở Dữ Liệu Phân Tán <br/>
 Đề tài: Quản Lý Vật Tư
<h1>

   <p align="center"> 
      <img src="./avatar/cropped-1280-640-927078.jpg">
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
  - [**1.Confusing Questions**](#1confusing-questions)
  - [**2.Interview Questions**](#2interview-questions)
- [**Video**](#video)
- [**Timeline**](#timeline)
  - [**Phase 1** : **01-09-2021 to 05-09-2021**](#phase-1--01-09-2021-to-05-09-2021)
  - [**Phase 2** : **06-09-2021 to 16-09-2021**](#phase-2--06-09-2021-to-16-09-2021)
  - [**Phase 3** : **16-09-2021 to 25-09-2021**](#phase-3--16-09-2021-to-25-09-2021)
  - [**Phase 4** : **26-09-2021 to 30-09-2021**](#phase-4--26-09-2021-to-30-09-2021)
- [**Special Thank**](#special-thank)
- [**Post Script**](#post-script)
- [**Tools**](#tools)
- [**Made with 💘 and C# <img src="https://www.vectorlogo.zone/logos/dotnet/dotnet-ar21.svg" width="60">**](#made-with--and-c-)

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
 
 Chúng ta sẽ có 3 LINK cho mỗi server phân mảnh 1 & 2 như sau
 
    LINK0 đi từ phân mảnh này tới phân mảnh 3
    LINK1 đi từ phân mảnh này tới phân mảnh còn lại
	LINK2 đi từ phân mảnh này tới phân mảnh gốc
  
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
  dataSet là cái data set chứa nội dung của toàn bộ cơ sở dữ liệu. Data Set này tham gia vào mọi form chính của chương trình gồm: nhân viên, kho, vật tư, đặt hàng. Nói chung thì ban đầu mình tính là có nhiều data set cơ mà cuối cùng thì dùng đúng 1 cái này thôi. Không dùng tạo thêm cái nào. Tạo cái này thì các bạn làm theo video thầy Thư nhưng bước chọn bảng thì chọn hết các bảng luôn nhé.
 
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
 
 Và mình đã chuẩn bị cho các bạn một danh sách đầy đủ các video cho môn cơ sở phân tán của thầy Lưu Nguyễn Kì Thư tại [**đây**](https://www.youtube.com/playlist?list=PLkPVg51dQOyYQc-jkT9BOEooS2IsaNWyH). 
 
 Điều quan trọng là những video này đều do thầy Thư trực tiếp giảng dạy và có làm hướng dẫn chi tiết nên chỉ cần các bạn chăm chỉ học theo đầy đủ thì **100%** một mình cân hết đồ án luôn 😎😎😎
 
 Ngoài ra, trình tự các video là theo đúng quá trình thầy Thư dạy nên các bạn hãy học theo đúng trình tự này. Đừng nhảy cóc vội vàng nhé vì `dục tốc bất đạt` mà.
 
 >Note: xem xong thì để cho mình một like 👍 video nha ! 
 
# [**FAQ**](#faq)
  FAQ hay viết tắt của cụm từ Frequently Asked Questions, là những câu hỏi thường gặp trong quá trình chúng ta làm đồ án này. Những câu hỏi được liệt kê bên dưới bao gồm những câu hỏi mình tổng hợp lại trong suốt quá trình học môn này. Bao gồm câu hỏi của sinh viên với thầy & những kiến thứ dễ gây lú do mình tự đúc kết ra trong quá trình làm nhé.
 

 
  ## [**1.Confusing Questions**](#1confusing-questions)
 
  Đây là nơi tập hợp các câu hỏi mà trong quá trình làm sinh viên tụi mình hay vướng phải và hướng giải quyết. 
  ***
  >Câu Hỏi 1: Thầy ơi cho em hỏi đề tài 3 phiếu nhập và phiếu xuất sao mã kho không phải là khóa ngoại vậy ạ? Script chạy lên cũng ko có luôn ạ (Tức là thiếu mã kho trong các bảng này ấy)
  
  >Đáp: Makho là khóa ngoại, các em thêm vào database nhé.
  
  >Note: Phần [**Tools**](#tools) ở cuối bài viết có chứa script chuẩn nha. 
  ***
  >Câu Hỏi 2: Thầy ơi cho em hỏi phân mảnh 3 tra cứu chỉ có bảng Nhân viên , kho và chi nhánh thôi hả thầy ?
  
  >Đáp: Không có chi nhánh
  ***
  >Câu Hỏi 3: Dạ thưa thầy, phần truy vấn dữ liệu, nếu trên site đang đứng mà tìm không thấy thì sẽ về site chủ để tìm hay là nhảy sang các phân mảnh khác để tìm ạ
  
  >Đáp: Về site chủ em nhé
  ***
  >Câu Hỏi 4: Thầy ơi cho em hỏi, trong tập tin word đề bài, Bảng Vật Tư không có cột Số lượng tồn, bảng Nhân viên không có Trạng thái Xóa, khác so với database
Thầy cho em hỏi là có cần 2 cột đó không ạ ?
 
  >Đáp: Nên có 2 cột đó !
  ***
  >Câu Hỏi 5: Chúng ta phân tán ra server 3 - Tra Cứu nhưng trong chương trình thì người đăng nhập ở vai trò nào sẽ dùng server 3 ? Nhiều đồ án khi demo chỉ đăng nhập vào chi nhánh 1 và 2 mà không thấy ai dùng server 3 để xem cả.
 
  >Đáp: Server 3 mục đích là để tra cứu, có nghĩa là đứng ở server 1 hoặc server 2 LINK tới server 3 chứ không được đứng ở ngay server 3 rồi thao tác với dữ liệu.
 
  >Chẳng hạn, ta sẽ dùng server 3 ở trong Stored Procedure, muốn kiểm tra mã của trường dữ liệu - ví dụ như mã nhân viên, mã đơn hàng -  có tồn tại ở server khác không thì dùng LINK tới server 3 rồi kiểm tra, chứ không phải đứng tại server 3 để thao tác.

  >Note: Form đăng nhập thì ở ô chọn chi nhánh chỉ được hiện chi nhánh 1 và 2 thôi. Nếu có chi nhánh 3 thì bị trừ điểm.
  ***
  >Câu Hỏi 6: Em thấy trong đề không có yêu cầu server 3 là phân mảnh dọc ?
 
  >Đáp: Theo đề bài: "QLVT được đặt trên server 3: chứa thông tin các nhân viên, kho của cả 2 chi nhánh 1 và 2. Server này dùng để tra cứu thông tin của nhân viên, kho của cả 2 chi nhánh".
 
  >Đề nói như này thì phải dùng phân mảnh dọc. Vì phân mảnh dọc sẽ lấy theo cột, nên row vẫn vậy, vẫn đầy đủ, không bị tách. thỏa mãn yêu cầu là có dữ liệu của cả 2 chi nhánh. Còn nếu dùng phân mảnh ngang thì em sẽ chỉ phân mảnh một quan hệ dựa trên một vị từ được định nghĩa. VD: CHINHANH = 'CN1' -> thiếu dữ liệu của CN2.
  
  ***
  >Câu Hỏi 7: Em chép các Stored Procedure như view_getSubcribers hoặc sp_Lay_Thong_Tin_Nhan_Vien_Tu_Login của thầy vào không trượt phát nào (!?) nhưng chạy thì nhận về lỗi "*invalid object dbo.NHANVIEN*"  hoặc "*invalid object dbo.sysmergepublications*" , không hiểu lý do vì sao?
  
  >Đáp: Đó là vì SQL Server không biết câu lệnh trên đang sử dụng cơ sở dữ liệu nào. Các bạn phải chỉ đích danh cơ sở dữ liệu đang muốn truy vấn thì SQL Server mới hiểu và thực hiện được. Chạy lệnh sau để chỉ ra cơ sở dữ liệu bạn muốn dùng:
  
    USE <database name>
  
  > Ví dụ: USE QLVT
 
  ***
  >Câu Hỏi 8: Viết Stored Procedure ở đâu là hợp lý ?
  
  >Đáp: Nên viết ở Server gốc. Sau đó sẽ tùy vào từng chức năng mà đẩy xuống các server phân mảnh là hợp lý nhất.
  ***
  >Câu Hỏi 9: Tạo LINK để liên kết các server với nhau có lưu ý gì không ?
  
  >Đáp: Có. Bắt buộc ở các server phân mảnh thì tên LINK phải hoàn toàn giống nhau. Ví dụ, nếu ở server thứ nhất bạn tạo ra 2 LINK
  
  > LINK0 dùng để kết nối từ server phân mảnh về server gốc
  
  > LINK1 dùng để kết nối từ server phân mảnh này đến server phân mảnh còn
  
  > Thì ở phân mảnh còn lại bạn cũng phải tạo 2 LINK với tên giống nhau. Điều này là vô cùng quan trọng bởi khi viết các Stored Procedure từ server gốc rồi đẩy về các phân mảnh thì các chữ LINK dùng trong Server phân mảnh nếu khác Server khác thì Stored Procedure đó sẽ bị lỗi & không thể hoạt động được
  ***
  >Câu Hỏi 10: Mình không thích dùng C#, có được dùng ngôn ngữ khác có được không ?
 
  >Đáp: Được chứ. Thầy Thư cho phép chúng ta chọn ngôn ngữ tùy thích để xây dựng đồ án.
  ***
  >Câu Hỏi 11: Mình không thích chơi DevExpress & mình muốn dùng cái khác có được không ?
  
  >Đáp: Dĩ nhiên là được rồi. Về cơ bản DevExpress là một thư viện hỗ trợ Winform. Các bạn hoàn toàn có thể dùng thư việc đều được ( làm bằng Winform truyền thống luôn cho máu )
  
 ***
 >Câu Hỏi 12: Khi không tìm được trên server hiện tại, em muốn sang phân mảnh khác để tìm thay về server gốc có được không ?
 
 >Đáp: Có 2 lý do để không nên sử dụng cách này
 
 >Lý do 1: Về lý thuyết thì được nhưng nếu chẳng may server phân mảnh đó offline thì sẽ không hoạt động được. Ngược lại, server gốc thì luôn online.
 
 >Lý do 2: Giả sử có 3 phân mảnh và thông tin cần tìm ở server 3. Tuy nhiên, khi viết stored procedure thì chúng ta lại tìm kiếm theo trình tự 1 -> 2 -> 3. Nếu chẳng may server 2 không hoạt động thì câu lệnh sẽ trả về lỗi và chấm dứt thực thi luôn. Trong khi server 3 thì lại hoạt động bình trường. Do đó về server gốc là hợp lý hơn.
 
 ***
 >Câu Hỏi 13: Thầy cho em hỏi là Chức Năng đặt hàng thì nhân viên thuộc chi nhánh và user có được phép chỉnh sửa Mã Nhân Viên không ạ
 
 >Đáp: Lấy MANV đăng nhập áp cho các phiếu, không cho sửa MANV ( nghĩa là người đăng đăng nhập thì lấy mã nhân viên của họ áp dụng vào các phiếu luôn)
 ***
 >Câu Hỏi 14: Thầy cho em hỏi là Chi nhánh với user đăng nhập vào thì thấy hết tất cả đơn đặt hàng , phiếu nhập, phiếu xuất luôn hả thầy, hay chỉ mỗi phiếu của chính họ thôi ạ 
 
 >Đáp: Thấy hết, nhưng chỉ cho chỉnh sửa các phiếu do mình lập
 ***
 >Câu Hỏi 15: Thầy ơi cho em hỏi đề tài Vật Tư, NV01 có thể lập phiếu nhập trên đơn đặt hàng của NV02 không ạ?
 
 >Đáp: Không
 ***
 >Câu Hỏi 16: Đề 3 QLVT trong table chi tiết đơn đặt hàng có phần đơn giá, thầy cho e hỏi lúc lập đơn đặt hàng thì đơn giá của vật tư lấy ở đâu ạ 
 
 >Đáp: Nhập tay em
 ***
 >Câu Hỏi 17: Nếu mình vào sửa đơn hàng thì mình có được sửa ngày lập đơn hàng và mã kho hàng không ạ ?
 
 >Đáp: Sửa mã kho hàng thì được nhưng không sửa ngày lập đơn hàng và nhân viên.
 ***
 >Câu Hỏi 18: Thưa thầy, giả sử ta chọn một cái đơn hàng do người khác lập thì chúng ta cũng ko được phép sửa phần chi tiết đơn hàng của họ đúng không ạ?
 
 >Đáp: chắc chắn rồi ! người nào đăng nhập thì chỉ sửa cái đó. Nếu đã có phiếu nhập thì không cho xóa đơn hàng
 ***
 >Câu Hỏi 19: Dính phải lỗi "Cannot open database <db_name> requested by the login.The login failed", phải chữ như nào bây giờ ?
 
 >Đáp: Kiểm tra lại connstr xem có sai không ? Tên database, tên servername, tên login đã ghi đúng hết chưa. Ví dụ, lúc mình làm thì mình ghi tên cơ sở dữ liệu trong phần Program.cs là QLTVT_DATHANG thay vì đúng ra phải là QLVT_DATHANG. May là mình dò kĩ nên tiết kiệm được nhiều thời gian.
 ***
 >Câu Hỏi 20: Gặp lỗi "unable to add a connection string" gây bối rồi quớ 🥱
 
 >Đáp: Truy cập đường dẫn sau https://exerror.com/unable-to-add-data-connection-could-not-find-any-resources-appropriate-for-the-specified-culture-or-the-neutral-culture/
 > Bước 1: Tải thư mục trong solution
 
 > Bước 2: Tìm C:\Program Files (x86)\Microsoft Visual Studio\2019\Community\Common7\IDE
 
 > Bước 3: Giải nén thư mục cài đặt & paste vào trong thư mục này
 ***
 >Câu Hỏi 21: Nếu mình vào sửa đơn hàng thì mình có được sửa ngày lập đơn hàng và mã kho hàng không ạ
 
 >Đáp: sửa mã kho hàng được và không sửa ngày lập đơn hàng
 ***
 >Câu Hỏi 22: Chỉ người lập mới đơn hàng mới được sửa đơn hàng đó đúng không ạ ?
 
 >Đáp: Đúng
 
 ## [**2.Interview Questions**](#2interview-questions)
 
 Đây là phần tổng hợp các câu hỏi lý thuyết mà thầy Thư có thể hỏi trong buổi thi vấn đáp cuối kì
 
  ***
  >Câu Hỏi 1: Sau khi phân tán xong thì có 1 trường dữ liệu là rowguild. Vậy rowguid được sinh ra để làm gì?
 
  >Đáp: Hỗ trợ quá trình đồng bộ dữ liệu từ site phân mảnh về site chủ và ngược lại.
 
  ***
  >Câu Hỏi 2: Login Name là gì ? Username là gì ? Mà chúng gây lú thế nhỉ ?!
  
  >Đáp: 
  
  >Login Name là tài khoản chúng ta dùng để đăng nhập vào một server. Ví dụ như tài khoản SA - tài khoản phổ biến khi đăng nhập SQL Server để tăng độ bảo mật. Sau khi kết nối thành công tới một server, chọn Security -> Logins sẽ thấy tài khoản SA
  
  > Username là tài khoản mà chúng ta dùng để làm việc trên một cơ sở dữ liệu. Ví dụ trên cơ sở dữ liệu QLVT, chọn vào QLVT -> Security -> Users sẽ thấy các tài khoản có thể làm việc trên cơ sở dữ liệu này

 ***
  >Câu Hỏi 3: db_dataReader, db_dataWriter, db_securityAdmin,.... rồi db_accessAdmin là gì ? Chúng dùng để làm gì ?
  
  >Đáp: chúng là những quyền mà một tài khoản kiểu login name có thể được chỉ định & quyết định xem chúng có thể làm những gì trên cơ sở dữ liệu đó.
  
  > 1.db_dataReader là quyền chỉ xem dữ liệu, không thể thêm mới hoặc sửa đổi dữ liệu
  
  > 2.db_dataWriter là quyền chỉ ghi dữ liệu, dĩ nhiên nếu ghi được thì coi như cũng đọc được dữ liệu
  
  > 3.db_securityAdmin là quyền tạo các tài khoản login name, tài khoản này dùng để đăng nhập vào server
  
  > 4.db_accessAdmin là quyền tạo các tài khoản username, tài khoản dùng để thao tác trên một cơ sơ dữ liệu nhất định
  
  > 5.db_owner là quyền cao nhất với một cơ sở dữ liệu, quyền này cho phép xem, thêm, xóa, sửa tất cả dữ liệu & có thể tạo tài khoản login name và username mà không có giới hạn nào( kiểu bạn là chủ nhà thì làm gì cũng được ấy )

***
  >Câu Hỏi 4: Có 2 cách để viết Stored Procedure. Cách 1 đã được trình bình ở mục [**Stored Procedure**](#stored-procedure). Cách số 2 là viết Stored Procedure thủ công tại từng phân mảnh. Cách làm nào hiệu quả hơn ?
 
 >Đáp: Cách làm thứ nhất hay hơn. Nếu ta chỉnh sửa stored procedure trên server gốc thì sự thay đổi sẽ tự động được cập nhật xuống các server phân mảnh. Còn cách thứ 2 thì phải sửa thủ công trên từng phân mảnh.

***
 >Câu Hỏi 5: Nếu sửa Stored Procedure trên phân mảnh thì nó có đồng bộ về các phân mảnh khác và server gốc, điều này là đúng hay sai ?
 
 >Đáp: Sai. Code chỉ đồng bộ theo một chiều từ server gốc tới các phân mảnh. Không có chiều ngược lại.

***
 >Câu Hỏi 6: Sửa dữ liệu tại server gốc thì phân mảnh có nhận được không ? Nếu ngược lại, từ server phân mảnh về server gốc thì có nhận được không ?
 
 >Đáp: Có, dữ liệu đồng bộ theo 2 chiều.

 ***
 >Câu Hỏi 7: Nêu ưu và nhược điểm khi ưu tiên tìm kiếm trên site phân mảnh trước khi về site chủ.
 
 >Đáp: 
 
 >Ưu điểm: server gốc lúc nào cũng hoạt động nên luôn truy vấn được dữ liệu mong muốn
 
 >Nhược điểm: Không thể che dấu được hoàn toàn các thông tin nhạy cảm giữa các site phân mảnh. Việc cấp 1 tài khoản để vào site chủ có thể giúp người dùng đó xem được dữ liệu của site khác

 ***
 >Câu Hỏi 8: Muốn thực thi một câu lệnh store procedure, view, function thì ta làm như nào ?
 
 >Đáp: Ta sẽ tạo một đối tượng là SqlCommand rồi nhúng vào các đối số cần thiết vào
 
  
  ***
 >Câu Hỏi 9: Giao tác là gì ? Để viết giao tác cần bật dịch vụ gì ?
 
 >Đáp: Giao tác là một dãy các thao tác đọc và ghi dữ liệu cùng với các bước tính toán nhất quán ( Begin Trans, Commit , Rollback,Begin distributed trans) để giải quyết các tình huống khi dữ liệu bị mất tính nhất quán khi có nhiều truy xuất đồng thời
 
 > Để viết giao tác cần phải bật dịch vụ MSDTC - Miscrosoft Distribute Transaction Coordinator
 ***
 >Câu Hỏi 10: ý nghĩa của Begin trans, commit, rollback & Begin distributed trans là gì ?
 
 >Đáp: 
 
 > Begin Trans: bắt đầu giao tác
 
 > Commit : xác nhận thành công 
 
 > Rollback( hoặc abort) : hủy bỏ giao tác và trả lại dữ liệu cũ
 
 > Begin distributed trans : câu lệnh mở đầu giao tác phân tán
 
 ***
 >Câu Hỏi 11: Nêu những tính chất giao tác ?
 
 >Đáp: Có tất cả 4 tính chất với giao tác gồm:
 
 >(1) tính nguyên tử: 1 giao tác có nhiều tập lệnh thì mọi câu lệnh hoặc thành công 
hoặc nếu 1 lệnh thất bại thì tất cả thất bại

 >(2) tính nhất quán: đảm bảo tất cả rằng buộc. Mọi lệnh đều được chạy
 
 >(3) tính biệt lập: một giao tác đang thực thi thì ko làm lộ các kết quả của nó cho những giao thức khác
đang cùng hoạt động trước khi nó hoàn thành.

 >(4) tính bền vững: một giao tác đã được commit thì dữ liệu đó được giữ nguyên và không thể rollback
 
 ***
 >Câu Hỏi 12: Dữ liệu rác là gì ? 
 
 >Đáp: là dữ liệu sinh ra có thể chưa phải là dữ liệu đã được commit nếu một giao tác khác đồng thời vào và lấy giao tác này ra thì dữ liệu này là ko chính xác.
 
 ***
 >Câu Hỏi 13: Có mấy loại giao tác ? 
 
 >Đáp: Có 2 loại giao tác là tập trung và phân tán
 
 > Giao tác tập trung có 2 loại: giao tác phẳng và giao tác lồng
 
 >(1) Giao tác phẳng có điểm khởi đầu duy nhất ( begin transaction ) và một điểm kết thúc duy nhất ( end transaction )
 
 >(2) Giao tác lồng chứa nhiều giao tác với điểm khởi đầu và duy nhất riêng biệt.

 > Giao tác phân tán chỉ có 1 loại duy nhất: giao tác phẳng
 
 ***
 >Câu Hỏi 14: XACT_ABORT là gì ? Nó nhận được mấy giá trị ?
 
 >Đáp: XACT_ABORT: đây là tùy chọn kết nối. Nó chỉ nhận 2 giá trị là ON & OFF.
 
 >Nếu là OFF, SQL Server sẽ bỏ qua lệnh gây lỗi trong transaction và tiếp tục thực thi các lệnh còn lại.
 
 >Nếu là ON, SQL Server sẽ hủy bỏ toàn bộ transaction nếu nó gặp lệnh bị lỗi và trả lại dữ liệu về ban đầu.
 
 ***
 >Câu Hỏi 15: Khi viết 1 stored procedure khi nào ta không dùng begin transaction , không dùng commit ... nhưng vẫn được coi là 1 giao tác ?
 
 >Đáp: khi ta sử dụng chỉ một lệnh UPDATE - DELETE - INSERT duy nhất. Còn nếu có 2 lệnh UPDATE - DELETE - INSERT thì phải dùng cú pháp begin transaction và commit
 
 ***
 >Câu Hỏi 16: Dịch vụ MS TDC là gì ?
 
 >Đáp: Dịch vụ MS TDC là Microsoft Distributed Transaction Coordinator. Nó đảm bảo tất cả cập nhật được thực thi ở tất cả 
các phân mảnh hoặc trong trường hợp lỗi thì xem như chưa thực hiện thao tác nào hết.

 ***
 >Câu Hỏi 17: Vị từ thích hợp là gì ?
 
 >Đáp: Thỏa tính đầy đủ và tính cực tiểu
 
 ***
 >Câu Hỏi 18: Tiêu chí đầy đủ và tiêu chí cực tiểu là gì ?
 
 >Đáp: 
 
 >Tiêu chí đầy đủ là ta có nhiều stored procedure thì xác suất nó truy xuất tới các phân mảnh là như nhau.
 
 >Tiêu chí cực tiểu là mỗi site được sinh ra phải được sử dụng tới trong một stored procedure nào đó.
 
 ***
 >Câu Hỏi 19: Vị từ là gì ? Một vị từ đơn giản là gì ?
 
 >Đáp: Vị từ là Mệnh đề login có nhiều điều kiện 
 
 >Một vị từ đơn giản là vị từ có kiểu: MACN = 'CN1',... . Tức vế trái là tên thuộc tính và vế phải là tên giá trị.
 
 >Một vị từ sơ cấp: MACN = ( CN1 hội CN2 ).
 
 ***
 >Câu Hỏi 20:  Một vị từ "thích hợp" là gì ?
 
 >Đáp: Một vị từ "thích hợp" nghĩa là khi tạo ra 1 phân mảnh "thích hợp" thì phải có stored procedure sử dụng tới phân mảnh này.
 
 ***
 >Câu Hỏi 21:  Sự trong suốt phân tán là gì ?
 
 >Đáp: Sự trong suốt phân tán: khi 1 stored procedure( sp )  được thực thi ở 1 server phân mảnh bấy kì thì cũng hoạt động tốt trên các phân mảnh còn lại - người dùng không cảm thấy được sp đang chạy trên hệ thông phân tán.
 
 >Note:  Chúng ta đứng ở vị trí thứ 3 để lập trình. Luôn ưu tiên tìm ở phân mảnh cục bộ trước khi sang các phân mảnh khác. 
 
 ***
 >Câu Hỏi 22:  Có mấy mức độ trong suốt phân tán là gì ?
 
 >Đáp: Có 4 mức độ trong suốt phân tán
 
 >(1) Mức cao nhất: Không cần chỉ ra phân mảnh cần truy vấn. Người dùng không cảm giác là đang thao tác trên một câu truy vấn phân tán.
 
 >(2) Sự trong suốt vị trí: Chúng ta chỉ cần chỉ ra tên TABLE cần phải truy vấn.
 
 >(3) Sự trong suốt ánh xạ cục bộ: Chúng ta cần chỉ rõ tên phân mảnh và vị trí cấp phát của chúng
 
 >(4) Không trong suốt: Chúng ta phải viết lệnh để đến đúng vị trí database cần thao tác. Tuy nhiên, do chúng ta đã đặt tên các cơ sở dữ liệu giốngnhau ở mọi phân mảnh. Tên LINK server cũng trùng tên nên không phải bận tâm đến mức này

 > Note: người dùng sẽ sử dụng ứng dụng ở mức cao nhất. Còn người lập trình như chúng ta sẽ đứng ở mức thứ 3.
 
 ***
 >Câu Hỏi 23:  Điều kiện để có thể phân tán được cơ sở dữ liệu ? Có mấy bước để phân tán cơ sở dữ liệu ?
 
 >Đáp: có dịch vụ SQL Server Agent
 
 >Có 3 bước để thực hiện phân tán cơ sở dữ liệu
 
 >(1) Định nghĩa Server Distributor : chứa Database distribution
 
 >(2) Định nghĩa publication : 1 container chứa các article (table, view, stored procedure, UDF). 
  
 > Trong đó, phải chỉ rõ các server : 
 
 > Publisher - chứa bản gốc cơ sở dữ liệu
 
 > Distributor - điều phối phân tán dữ liệu
 
 >(3) Định nghĩa subscription (database): 1 container nhận publication. Trong đó, phải chỉ rõ server Subscriber - chứa cơ sở dữ liệu sau khi phân tán
 ***
 >Câu Hỏi 23: Có mấy hình thức phân mảnh ? 
 
 > Đáp: Có 3 hình thức phân mảnh gồm phân mảnh ngang, phân mảnh dọc & phân mảnh hỗn hợp.
 
 ***
 >Câu Hỏi 24: Nêu đặc điểm của phân mảnh ngang ? 
 
 > Đáp: Phân mảnh ngang là chia một quan hệ theo các bộ. Mỗi phân mảnh ngang là tập con của quan hệ. 
 
 > Trong phân mảnh ngang bao gồm phân mảnh ngang nguyên thủy &  phân mảnh ngang dẫn xuất
 
 > *Phân mảnh ngang nguyên thủy* là phân mảnh của 1 quan hệ dựa trên 1 vị từ được định nghĩa trên quan hệ đó
 
 > *Phân mảnh ngang dẫn xuất* là phân mảng của 1 quan hệ dựa trên vị từ được định nghĩa trên quan hệ khác.
 
 > Ví dụ với đề quản lý vật tư thì 
 
 > MaChiNhanh = 'CN1' -> phân mảnh ngang nguyên thủy
 
 > NHANVIEN.MaKho = KHOHANG.MaKho -> phân mảnh ngang dẫn xuất
 
 > Nói cách khác 'CN1' và 'CN2' là các vị từ.
 
 ***
 >Câu Hỏi 24: Nêu đặc điểm của phân mảnh dọc ? 
 
 > Đáp: Phân mảnh dọc là phân mảnh dựa trên khóa chính của một quan hệ ( phải có khóa chính để đảm bảo tính tái thiết)
 
 > Gỉa sử, NHANVIEN( id, ho , ten, dia chi, luong, ngay sinh, ma chi nhanh ) thì khi tạo phân mảnh dọc sẽ thành 
  
 > NHANVIEN(id, ho, ten, ngay sinh, ma chi nhanh) trong đó MaChiNhanh là khóa ngoại thì phải cho phép NULL
 
 ***
 >Câu Hỏi 25: Nêu đặc điểm của phân mảnh hỗn hợp ? 
 
 > Đáp: Là sự kết hợp của 2 cách phân mảnh ngang và dọc. Khi hợp các phân mảnh theo 2 cách này thì cơ sở dữ liệu tạo thành chính là cơ sở dữ liệu ban đầu.

 ***
 >Câu Hỏi 25: Có mấy quy tắc phân mảnh  ? 
 
 > Đáp: Có 3 quy tắc phân mảnh
 
 >(1) Tính đầy đủ: xét trên góc độ là QUAN HỆ. Mỗi mục dữ liệu ít nhất phải nằm ở 1 phân mảnh. Thì không bị mất thông tin
 
 >(2) Tính tái thiết: thường thì thỏa mản tính đầy đủ sẽ thỏa mãn tính tái thiết.
 
 >(3) Tính tách biệt: mỗi mục dữ liệu chỉ nằm ở một phân mảnh duy nhất. Khi ghép các phân mảnh thì database sẽ đầy đủ như ban đầu. Tức nếu TEN ở phân mảnh 1 thì sẽ không xuất hiện ở phân mảnh 2

 > Note Thực tế, tính tách biệt dễ bị vi phạm vì NHÂN BẢN giúp dữ liệu tồn tại ở cả 2 mảnh. Bắt buộc tính đầy đủ phải thỏa mãn. Nếu thỏa mãn thì tính tái thiết cũng sẽ được bảo đảm.

 ***
 >Câu Hỏi 26: Run on continue khác run on demand ở điểm nào  ? 
 
 > Đáp: Run on continue làm tính nhất quán cao, dữ liệu đồng bộ ngay lập tức. Run on demand tính tự quản cao. Các site có thể disconnect. Các thay đổi không phản ảnh tức thời tới site chủ

 ***
 >Câu Hỏi 27: Snapshot folder là gì ?  ? 
 
 > Đáp: Folder chứa dữ liệu trung gian để đồng bộ dữ liệu từ các phân mảnh về site chủ và ngược lại. Là folder chứa dữ liệu để đẩy qua đẩy lại. Phải là network path(shared folder)
 
 ***
 >Câu Hỏi 28: Tại sao trả về mã nhân viên khi dùng sp_DangNhap ? 
 
 > Đáp: để gán tự động cho các form có mã nhân viên 
 
 ***
 >Câu Hỏi 29: Bốn thuộc tính quan trọng của combo box ?
 
 > Đáp: 
 
 > data source chứa danh sách dữ liệu cung cấp cho nó
 
 > display member chứa tên field mình muốn hiển thị
 
 > value member chứa field dữ liệu mình muốn lấy
 
 > selected index change phương thức thay đổi giá trị 
 
 ***
 >Câu Hỏi 30: Vì sao ta phải dùng Remote Login ?
 
 > Đáp: Cho phép truy cập dữ liệu khi đứng từ server này sang server khác.
 
 ***
 >Câu Hỏi 31: Có những cách nào để tối ưu hóa truy vấn ?
 
 > Đáp: Có 5 cách để tối ưu hóa một câu truy vấn
 
 > 1. Dùng phép chọn, chiếu trước, phép kết sau
 
 > 2. Khử phép kết (nếu được)
 
 > 3. Nếu 1 điều kiện xuất hiện nhiều lần trong WHERE thì dùng các phép biến đổi tương đương để cho điều kiện đó xuất hiện 1 lần
 
 > 4. Trong mệnh đề AND, điều kiện nào có xác suất sai cao thì đặt ở đầu ; OR thì ngược lại.
 
 > 5. Field tham gia trong điều kiện truy vấn nên được sắp thứ tự trước & thứ tự này phải đc sử dụng trong mệnh đề truy vấn  với WITH (INDEX=ten_index)

 ***
 >Câu Hỏi 32: Thế nào là một Stored Procedure trong suốt ? Điều kiện để viết Stored Procedure trong suốt ?
 
 > Đáp: Stored Procedure được coi là trong suốt nếu ta cho thực thi ở 1 server thì vẫn cho thực thi được ở những server còn lại mà không cần chỉ rõ đường dẫn đến table cần truy xuất 
 
 > Hoặc có thể trả lời 
 
 > Stored Procedure trong suốt là Stored Procedure mà khi ta cho thực thi ở bất kì phân mảnh nào đều cho kết quả giống nhau
	
 > Điều kiện để viết Stored Procedure trong suốt là ta cần có LINK SERVER & tên database giống nhau
 
 ***
 >Câu Hỏi 33: Trong database, cái nào là nhân bản, cái nào là phân hoạch  ?
 
 > Đáp: Mở cây dẫn xuất ra xem, cái nào không có trong cây dẫn xuất là nhân bản, cái đầu tiên là phân mảnh ngang nguyên thủy
 
 ***
 >Câu Hỏi 34: Nếu đã phân tán xong cơ sở dữ liệu, muốn thay đổi cấu trúc | thứ tự các cột trong table của server gốc thì làm sao  ?
 
 > Đáp: Có thể thay đổi bằng cách viết stored procedure dùng lệnh ALTER TABLE ở server gốc sau đó đồng bộ xuống các server phân mảnh
 
 ***
 >Câu Hỏi 35: Dữ liệu sau khi nhập form sẽ được đẩy về đâu  ? 
 
 > Đáp: Đẩy về publisher sau đó đồng bộ xuống các subcriber.
 
 ***
 >Câu Hỏi 36: Trong các table, cái nào mang tính đầy dủ, cái nào vi phạm tính tách biệt   ? 
 
 > Đáp: Các table nhân bản thì vi phạm tính tách biệt, tất cả các table còn lại thì mang tính đầy đủ.
 
 ***
 >Câu Hỏi 37: Giao tác tập trung với giao tác phân tán giống và khác nhau như thế nào ?   
 
 > Đáp: 
 
 > Điểm khác : Giao tác thì thực thi trên môi trường cơ sở dữ liệu tập trung (gồm có giao tác phẳng và giao tác lồng), còn giao tác phân tán thì thực thi trên môi trường cơ sở dữ liệu phân tán. 
 
 > Điểm giống : 4 tính chất giao tác.
 
 ***
 >Câu Hỏi 38: Login Name nằm trong table nào? 
 
 > Đáp: Nằm trong table sys.sysuser trong Database đó
 
 ***
 >Câu Hỏi 39: Tại sao biết user liên kết với login nào? 
 
 > Đáp: Username và loginname liên kết với nhau qua trường sid (trên user và login đều có sid) nên từ loginname biết được username từ sid
 
 ***
 >Câu Hỏi 40: Tên nhóm quyền nằm trong table nào ? 
 
 > Đáp: Nằm trong table sys.sysuser trong Database đó
 
 ***
 >Câu Hỏi 41: Ưu | khuyết điểm của nhân bản ? 
 
 > Đáp: Truy xuất nhanh, đứng ở đâu cũng có thể select được. Nhưng update chậm vì có quá nhiều bản sao
 
 ***
 >Câu Hỏi 42: Ưu | khuyết điểm của phân hoạch  ? 
 
 > Đáp: Select chậm nhưng insert và update nhanh do chỉ thao thác trên server gốc hoặc server phân mảnh cần truy xuất.
 
 ***
 >Câu Hỏi 42: Tại sao table đó nhân bản?
 
 > Đáp: 
 
 > Trong đề vật tư thì vật tư nhân bản vì vật tư có thể có ở chi nhánh này cũng có thể có ở chi nhánh khác.

 > Trong đề trắc nghiệm thì giáo viên nhân bản vì giáo viên có thể dạy ở cở sở này cũng có thể dạy ở cơ sở khác, bộ đề đi theo giáo viên nên cũng nhân bản. Giáo viên cở sở 1 có thể dạy ở cở sở 2 nhưng không thể đăng kí thi cho lớp ở cơ sở 2.

 
 Note: Lời khuyên chân thành tới các bạn là hãy dành toàn bộ thời gian khi còn đang có tiết học môn Cơ Sở Dữ Liệu Phân Tán ở lớp thì hãy làm hết sức mình và nhanh nhất có thể để nếu như các bạn có khó khăn hoặc thắc mắc gì cần thầy giải đáp thì sẽ nhanh được thầy giải đáp hơn. Tại thời điểm mình viết những dòng này - Mon, 11-10-2021, tức đã hết tiết học ở lớp nhưng có rất nhiều bạn hỏi thầy ở nhóm chat ZALO. Thầy trả lời rất chậm và thường là "phải xem trực tiếp mới biết được" 🙄. Bởi lẽ những câu hỏi của các bạn nhiều câu hỏi rất tối nghĩa hoặc phức tạp, cần xem trực tiếp trên máy tính mới có thể giải đáp được. Thầy chỉ có thể trả lời những câu hỏi ngắn kiểu đúng hoặc sai như: Nhân viên 1 thì không được quyền sửa đơn đặt hàng của nhân viên 2 phải không ạ ? Do vậy, các bạn hãy làm quyết liệt ngay tư đầu như mình. Đến tiết học thì mình mở micro, hỏi thầy trực tiếp thì chắc chắn được thầy phản hồi ngay lập tức.

# [**Video**](#video)

Dưới đây là video tóm tắt phần đồ án của mình kèm theo những lưu ý cần thiết. Tiếp theo đó còn có hình thức thi vấn đáp với thầy Lưu Nguyễn Kì Thư nhé.

<div align="center">
	
  [![Video giới thiệu đồ án Quản lý vật tư của Nguyễn Thành Phong](https://img.youtube.com/vi/SEzoqzogl4Y/0.jpg)](https://www.youtube.com/watch?v=SEzoqzogl4Y)
	
</div>


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
 
  ## **Phase 3** : **16-09-2021 to 25-09-2021**
  1. Hoàn thiện toàn bộ tính năng của form vật tư
 
  2. Hoàn thiện toàn bộ tính năng cho form đơn đặt hàng kết hợp chi tiết đặt hàng.
 
  3. Hoàn thiện toàn bộ tính năng cho form phiếu nhập kết hợp chi tiết phiếu nhập.
 
  4. Hoàn thiện toàn bộ tính năng cho form phiếu xuât kết hợp chi tiết phiếu xuất.
 
  ## **Phase 4** : **26-09-2021 to 30-09-2021**
  1. Hoàn thiện toàn bộ báo cáo danh sách nhân viên
 
  2. Hoàn thiện toàn bộ báo cáo danh sách vật tư
 
  3. Hoàn thiện toàn bộ báo cáo hoạt động nhập xuất của nhân viên
 
  4. Hoàn thiện toàn bộ báo cáo đơn hàng không phiếu nhập
 
  5. Hoàn thiện toàn bộ báo cáo chi tiết số lượng - trị giá hàng hóa nhập xuất
  
  6. Hoàn thiện toàn bộ báo cáo tổng hợp nhập xuất
# [**Special Thank**](#special-thank)
 <table>
    <tr>
        <td align="center">
        <a href="https://github.com/ngdanghau">
            <br/>
            <img src="./avatar/Hau.jpg" width="100px;" alt=""/>
            <br />
            <sub><b>Nguyễn Đăng Hậu</b></sub>
        </a>
    </td>
    <td align="center">
        <a href="https://github.com/HuynhPhuocSang">
            <img src="./avatar/Sang.jpg" width="100px;" alt=""/>
            <br />
            <sub><b>Huỳnh Phước Sang</b></sub>
        </a>
    </td>
    <td align="center">
        <a href="https://github.com/trinhnhi1306">
            <img src="./avatar/Trinh.jpg" width="100px;" alt=""/>
            <br />
            <sub><b>Nguyễn Ngọc Phương Trinh</b></sub>
        </a>
    </td>
    <td align="center">
        <a href="https://github.com/Dau-Truong-Quan">
            <img src="./avatar/Quan.jpg" width="200px;" alt=""/>
            <br />
            <sub><b>Đậu Trường Quân</b></sub>
        </a>
    </td>
    </tr>
</table>
 
# [**Post Script**](#post-script)
 Ngày bắt đầu: 01-09-2021
 
 Ngày kết thúc: 30-09-2021
 
 6h42 PM ngày 30-09-2021: ui cha, cuối cùng mình cũng hoàn thành được cái của nợ này rồi. Một tháng ròng rã cuối cùng cũng có sản phẩm cuối cùng. Thật là hạnh phúc quá đi 🤪🤪🤪. Còn 1 buổi học nữa mới hết nhưng làm xong là zui rồi. Giờ còn đồ án lập trình mạng, lập trình web nữa. Haiz, cứ từ từ mà tính vậy. Đi nghỉ thôi. Chờ ngày thi môn này xong rồi vào cập nhật tiếp !
 
 3h42 PM ngày 04-10-2021: hmm, hôm nay buổi học cuối mất rồi. May quá coi kĩ lại mà mình đã bắt được mấy lỗi nhập dữ liệu đầu vào kiểu tên thì không có số. Nhanh quá. Chắc thêm một thoáng nữa là hết học kì mất 🤨
 
 03:40 PM ngày 25-11-2021: đến hôm nay là sắp thi rồi mà vẫn có nhiều đứa hỏi bài trên ZALO quớ (><). May mà làm từ đầu nên giờ nhàn ghê
# [**Tools**](#tools)
  
  **Visual Studio 2019** - cái này thì quen thuộc quá rồi, ai học đến năm 4 rồi mà chưa cài thì toang CMNR
  
  **DevExpress** - thư viện hỗ trợ làm Winform siêu đẹp, siên tiện. Các bạn nhấn vào [**đây**](https://drive.google.com/file/d/1Rik18mGgDjt2xVSKkcWv3HTw5raQ2lRn/view) để tải nha. Cái này đã crack tận 16 năm rồi, dùng tẹt cmn bô luôn.
  
  **SQL Server 2014** - cái này do thầy Thư chia sẻ cho sinh viên tụi mình. Bao uy tín. Tải tại [**đây**](https://drive.google.com/file/d/12r_yzyKRxnyIA1Q2ZajFsUAMAJ_6DoA8/view) nhé.
  
  **Database Script** - cái này là phần script tiêu chuẩn do chính thầy Thư gửi cho tụi mình nha. Tải tại [**đây**](https://drive.google.com/file/d/1ahRASX5mvGY8v4JLNmdPdiXirotPikhQ/view?usp=sharing)
  
  > Note: Mình rất khuyến khích các bạn cài đặt toàn bộ những phần mềm bên trên bởi trong quá trình học thì thầy hướng dẫn trên những phần mềm này. Ngoài ra, nếu chẳng may gặp lỗi gì đó, các bạn có thể hỏi thầy hoặc bạn bè của mình dễ hơn so với việc chọn làm bằng một phần mềm khác.


 
 # [**Made with 💘 and C# <img src="https://www.vectorlogo.zone/logos/dotnet/dotnet-ar21.svg" width="60">**](#made-with-love-and-c)
