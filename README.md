一个 C# 项目的例子代码，  用于 机翻 文章时使用。


涉及的知识点如下：


### Entity Framework Code First

文章，以 书籍-章节-行 的组织方式，存储在数据库中。

注意：
开发阶段，使用的数据库为 SQL Server Express.
目标用户使用的时候，数据库为 SQLite

需要去下载一个 SqlConverter	（sql server tosqlite db conveter） 来完成最后的处理。



###  LINQ to Entities 

查询语句，基本依靠  LINQ to Entities ， 但是存在某些细节的地方， 不同数据库之间，有略微的差异。




### XML Serialization

主要在 数据导出 / 导入 的时候使用。



### Reflection

LINQ to Entities 查询结果，好像直接拿去 XML Serialization 的时候，有些问题， 只好 反射 赋值之后， 再做 XML Serialization 。



### WebClient

主要从 目标网站，抓取文章时适用。



### WebBrowser

使用 WebClient， 从目标网站， 抓取回来的 HTML 片断， 放到 WebBrowser 控件中， 获取 可读的 文本字符。
（这里不自己去解析 HTML 了。）



