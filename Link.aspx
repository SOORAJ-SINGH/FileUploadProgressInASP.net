<%@ Page Title="DownloadLink by STPL" Language="C#" MasterPageFile="MasterPage.master" AutoEventWireup="true" CodeFile="Link.aspx.cs" Inherits="Link" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
    <link href="Styles/StyleSheet.css" rel="stylesheet" type="text/css" />
    <script type="text/javascript">
        window.history.forward();
        function noBack() {
            window.history.forward();
        }
    </script>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="download" runat="server">
        <%--<div class="heading">File Management</div>--%>

        <div class="downloadimage" runat="server">
            <div class="heading1">Your Files are here:</div>
            <asp:HyperLink ID="link" runat="server" NavigateUrl=""></asp:HyperLink>
            <div class="goto">
            </div>
        </div>
    </div>
</asp:Content>

