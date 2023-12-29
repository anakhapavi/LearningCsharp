using System.Buffers;
using System.Security.AccessControl;

Multicast obj = new Multicast();
myDelegate d1 = obj.Method1;
//multicast
d1 += obj.Method2;
d1("hi multicast delegates!");

