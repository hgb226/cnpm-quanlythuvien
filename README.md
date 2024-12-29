Tên đề tài: QUẢN LÝ THƯ VIỆN  
Mã lớp: SE104.P11  
  
Thành viên nhóm 3:  
21521023 - Nguyễn Đức Trung Kiên  
21520604 - Huỳnh Gia Bảo  
21522149 - Nguyễn Đặng Thanh Huy  
21522604 - Phùng Nam Thanh  
21522530 - Hoàng Tất Quý  

- Download Source Code from Github  
- Create an App.config file and change its content to your need  
```xml
<?xml version="1.0" encoding="utf-8"?>
<configuration>
    <startup> 
        <supportedRuntime version="v4.0" sku=".NETFramework,Version=v4.8"/>
    </startup>
  <connectionStrings>
    <add name="strConn" connectionString="Data Source=<DATA SOURCE>;Initial Catalog=DoAnQLTV;Integrated Security=True"/>
  </connectionStrings>
  <appSettings>
	<add key="ComboBoxItems" value="A,B,C" />
  </appSettings>
</configuration>
```
  
- Run database from Database/DoAnQLTV.sql  
- Run application  
