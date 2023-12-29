<!-- default file list -->
*Files to look at*:

* [EmbedHttpHandler.cs](./CS/App_Code/EmbedHttpHandler.cs) (VB: [EmbedHttpHandler.vb](./VB/App_Code/EmbedHttpHandler.vb))
* [Default.aspx](./CS/Default.aspx) (VB: [Default.aspx](./VB/Default.aspx))
* [Default.aspx.cs](./CS/Default.aspx.cs) (VB: [Default.aspx.vb](./VB/Default.aspx.vb))
<!-- default file list end -->
# Object type manual detection


<p>This demo shows how to display or play back a file in a multimedia format (flash, audio, video) when the file's filename extension is not specified. In this case, you need to know the file’s MIME type and manually set the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxObjectContainer_ObjectTypetopic">ASPxObjectContainer.ObjectType</a> property to a corresponding value (Audio, Video, Flash, or Image).</p>
<p> </p>
<p>In this example, you can see Flash loaded in <a href="https://documentation.devexpress.com/#AspNet/clsDevExpressWebASPxObjectContainertopic">ASPxObjectContainer</a>. The flash file is placed in the server file system, but you can use any form of data distribution: files from a database, files from the file system, etc. In <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebASPxObjectContainer_ObjectUrltopic">ASPxObjectContainer.ObjectUrl</a>, you specify the Embed.emb URL with query parameters, which a custom EmbedHttpHandler will process and load a corresponding object (for example, ~/Embed.emb?flash=true will load a flash file).<br /><br />Handler registration</p>


```xml
<system.web>
  ...
  <httpHandlers>
    ...
    <add type="EmbedHttpHandler" verb="*" path="Embed.ashx" validate="false" />
  </httpHandlers>
</system.web>
<system.webServer>
  ...
  <validation validateIntegratedModeConfiguration="false" />
  <handlers>
    ...
    <add type="EmbedHttpHandler" name="EmbedHttpHandler" verb="*" path="Embed.ashx" preCondition="integratedMode" />
  </handlers>
</system.webServer>

```



<br/>


