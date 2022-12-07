<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="ASPxperience_ObjectContainer_ObjectType_ObjectType" %>

<%@ Register Assembly="DevExpress.Web.v15.1, Version=15.1.15.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" Namespace="DevExpress.Web" TagPrefix="dx" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Object type manual detection</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <dx:ASPxObjectContainer runat="server" ID="FlashObjectContainer"
                Width="320px"
                Height="284px"
                ObjectUrl="~/Embed.ashx"
                ObjectType="Flash">
            </dx:ASPxObjectContainer>
        </div>
    </form>
</body>
</html>
