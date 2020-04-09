#第二章作业

###P4. Consider the following string of ASCII characters that were captured by Wireshark when the browser sent an HTTP GET message (i.e., this is the actual content of an HTTP GET message). The characters <Cr><lf> are carriage return and line-feed characters (that is, the italized character string <cr> in the text below represents the single carriage-return character that was contained at that point in the HTTP header). Answer the following questions, indicating where in the HTTP GET message below you find the answer.

*GET /cs453/index.html HTTP/1.1 < cr >< lf >Host: gaia.cs.umass.edu< cr >< lf >User-Agent:Mozilla/5.0(Windows;U; Windows NT 5.1; en-US; rv:1.7.2) Gecko/20040804 Netscape/7.2 (ax) < cr >< lf >Accept :ext/xml, a pplication/xml, application/xhtml+xml, text/html;q=0.9, text/plain;q=0.8,image png,*/*;q=0 .5 < cr >< lf >Accept-Language:en-us,en;q=O.S< cr >< lf >AcceptEncoding: zip,deflate< cr >< lf >Accept- Charset:ISO-8859-1 ,u tf- 8 ; q=0.7,*;q=0.7<cr><1f>Keep- Alive : 300< cr >< lf >Connection:keep-alive<cr><1f><cr><1f>*

**a. What is the URL of the document requested by the browser?**

**b. What version of HTTP is the browser running?**

**c. Does the browser request a non-persistent or a persistent connection?**

**d. What is the IP address of the host on which the browser is running?**

**e. What type of browser initiates this message? Why is the browser type needed in an HTTP request message?**

答：

+ http://gaia.cs.umass.edu/cs453/index.html.host：
+ HTTP/1.1
+ persistent connection
+ 没说
+ Mozilla/5.0(Windows;U; Windows NT 5.1; en-US; rv:1.7.2)；
  不同的浏览器不同版本可能存在差异。
***

###P5. The text below shows the reply sent from the server in response to the HTTP GET message in the question above. Answer the following questions, indicating where in the message below you find the answer.

*HTTP/1.1 200 OK< cr >< lf >Date: Tue, 07 Mar 2008 12:39:45GMT< cr >< lf >Server : Apache/2.0.52 (Fedora)
< cr >< lf >Last-Modified : Sat, 10 Dec2005 18:27:46
GMT< cr >< lf >ETag : "526c3-f22-a88a4c80"< cr >< lf >AcceptRanges: bytes< cr >< lf >Content-Length : 3874 < cr >< lf >Keep-Alive: timeout=max=100< cr >< lf >Connection: Keep- Alive< cr >< lf >Content-Type : text/html: charset=IS0- 8859-1< cr >< lf >< cr >< lf >< !doctype html public"-//w3c//dtd html 4.0transitional//en">< lf >< html >< lf >
< head >< lf >< meta http-equiv="Content-Type" content="text/html; charset=iso- 8859-l" >< lf > < meta name="GENERATOR" content="Mozilla/4.79 [en] ) (Windows NT
5.0 ; U) Netscape)" >< lf > < title >CMPSCI 453/591/NTU-STSSOASpring 2005 homepage< /title >< lf >< /head >< lf >
< much more document text following here (not shown) >*

**a.Was the server able to successfully find the document or not? What time was the document reply provided?**

**b. When was the document last modified?**

**c. How many bytes are there in the document being returned?**

**d. What are the first 5 bytes of the document being returned? Did the server agree to a persistent connection?**

答：

+ 可以。状态码为200；Date: Tue, 07 Mar 2008 12:39:45GMT
+ last-Modified : Sat, 10 Dec2005 18:27:46GMT
+ 3874bytes
+ <!doc.


##P6. Obtain the HTTP/1.1 specification (RFC 2616). Answer the following questions:

**a. Explain the mechanism used for signaling between the client and server to indicate that a persistent connection is being closed. Can the client, the server, or both signal the close of a connection?**
**b. What encryption services are provided by HTTP?**
**c. Can a client open three or more simultaneous connections with a given server?**
**d. Either a server or a client may close a transport connection between them if either one detects the connection has been idle for some time. Is it possible that one side starts closing a connection while the other side is transmitting data via this connection? Explain.**

答：

+ rfc表示客户机或服务器可以向另一个表明它是将关闭永久连接。它通过包含连接令牌来实现“关闭”在http请求/回复的连接头字段中。
+ http不提供任何加密服务。
+ “使用持久连接的客户端应该限制同时维护到给定服务器的连接。单用户客户端与任何服务器或代理服务器的连接不应超过2个。”
+ 是。(来自RFC 2616)“在服务器决定关闭”空闲“连接的同时，客户端可能已经开始发送新请求。从服务器的角度来看，连接是在空闲时关闭的，但从客户端的角度来看，请求正在进行中。
