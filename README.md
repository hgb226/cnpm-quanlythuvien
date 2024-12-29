Tên đề tài: QUẢN LÝ THƯ VIỆN__
Mã lớp: SE104.P11__
__
Thành viên nhóm 3:__
21521023 - Nguyễn Đức Trung Kiên__
21520604 - Huỳnh Gia Bảo__
21522149 - Nguyễn Đặng Thanh Huy__
21522604 - Phùng Nam Thanh__
21522530 - Hoàng Tất Quý__

- Download Source Code from Github__
- Create an App.config file and change its content to your need__
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
__
- Run database from Database/DoAnQLTV.sql__
- Run application__
