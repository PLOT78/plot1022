<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Main" %>
<%@ Register src="Top.ascx" tagname="Top" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    
    <link href="Content/Table.css" rel="stylesheet" type="text/css" />
    <link href="Content/jquery.sweet-modal.min.css" rel="stylesheet" type="text/css" />
    
    <script src="Scripts/jquery-1.10.2.js" type="text/javascript"></script>
    <script src="Scripts/jquery.sweet-modal.min.js" type="text/javascript"></script>

    <script src="Scripts/top.js" type="text/javascript"></script>

    <script type="text/javascript">

        var home = '<%= base.home %>';

        $(document).ready(function () {

            debugger;

            Top.DataBind(home);

        });

    </script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <uc1:Top ID="Top1" runat="server" />
        여기가 메인(HOME) 공사중
    </div>
    </form>
</body>
</html>
