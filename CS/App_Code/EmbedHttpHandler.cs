using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

public class EmbedHttpHandler : IHttpHandler {
    public bool IsReusable {
        get { return false; }
    }

    public void ProcessRequest(HttpContext context) {
        context.Response.Clear();
        context.Response.ContentType = "application/x-shockwave-flash";
        context.Response.BinaryWrite(GetByteFile(context.Server.MapPath("~/Files/FlashClocks.swf")));
        context.Response.End();
    }

    public static byte[] GetByteFile(string filePath) {
        using(Stream fileStream = File.OpenRead(filePath)) {
            byte[] bytes = new byte[fileStream.Length];
            fileStream.Read(bytes, 0, (int)fileStream.Length);
            return bytes;
        }
    }
}