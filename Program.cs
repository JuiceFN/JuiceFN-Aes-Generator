using System.Net;

WebClient aesGrabberClient = new WebClient();
string aesKey = aesGrabberClient.DownloadString("https://benbot.app/api/v1/aes");
Console.WriteLine("The generated AES key is: " + aesKey);
Console.WriteLine("USE CODE JUICEFN THIS TOOK ME ALOT OF TIME");
