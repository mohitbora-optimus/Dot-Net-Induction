<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentDetailsInterface.aspx.cs" Inherits="TestingStudentPercentage.StudentDetailsInterface" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="font-family: Arial">
            <table border="1">
                <tr>
                    <td>
                        <asp:Label ID="lblPercentage" Text="Enter 10th percentage: " runat="server" />
                    </td>
                    <td>&nbsp;&nbsp&nbsp;
                        <asp:TextBox ID="txtPercentage" runat="server" />
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <asp:Button ID="btnSubmit" Text="Submit" runat="server" OnClick="btnSubmit_Click" />
        </div>
        <div>
            <asp:Label ID="lblStatus" runat="server" />
        </div>
    </form>
</body>
</html>
