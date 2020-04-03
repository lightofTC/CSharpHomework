**a. A user requests a Web page that consists of some text and three images. For this page, the client will send one request message and receive four response messages.**

**b. Two distinct Web pages (for example, *www.mit.edu/* research *.html* and *www. mit. edu/students.html*) can be sent over the same persistent connection.**

**c. With nonpersistent connections between browser and origin server, it is possible for a single TCP segment to carry two distinct HTTP request messages.**

**d. The Date : header in the HTTP response message indicates when the object in the response was last modified.**

**e. HTTP response messages never have an empty message body.**

答：

+ F
+ T
+ F
+ F
+ T
***

##P2. Assume you open a browser and enter http://your business.com/about.html in the address bar. What happens until the webpage is displayed? Provide details about the protocol(s) used and a high-level description of the messages exchanged.
答：应用层协议：DNS和HTTP传输层协议：UDP用于DNS；TCP用于HTTP。