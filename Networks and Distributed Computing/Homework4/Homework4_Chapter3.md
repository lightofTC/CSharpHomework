#Homework-Chapter3

###Pl. Suppose Client A requests a web page from Server S through HTTP and its socket is associated with port 33000.
**a. What are the source and destination ports for the segments sent from A to S?**

**b. What are the source and destination ports for the segments sent from S to A?**

**c. Can Client A contact to Server S using UDP as the transport protocol?**

**d. Can Client A request multiple resources in a single TCP connection?**

答：

+ 服务器S的端口没说
+ 端口33000
+ 可以，但不可靠
+ 可以，TCP连接不断开可重复使用

###Consider Figure 3.5. What are the source and destination port values in the segments flowing from the server back to the clients' processes? What are the IP addresses in the network-layer datagrams carrying the transport-layer segments?
答：从服务器回到客户主机时，发送端口为80，目的端口为建立该连接的主机端口，图中网络客户主机C的端口分别为7532与26145，此时源IP地址为服务器B的IP地址，目的IP地址为客户主机C的IP地址。

##验算结果截图
![](https://github.com/lightofTC/WHUHomework/blob/master/Networks%20and%20Distributed%20Computing/Homework4/2020-4-9.png)

