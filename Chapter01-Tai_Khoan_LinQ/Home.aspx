<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Chapter01_Tai_Khoan_LinQ.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="GridView1" runat="server" OnSelectedIndexChanged="gridselect" AutoGenerateSelectButton="true">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString1 %>" DeleteCommand="DELETE FROM [AccountType] WHERE [ACCOUNTTYPE] = @ACCOUNTTYPE" InsertCommand="INSERT INTO [AccountType] ([ACCOUNTTYPE], [TYPENAMENAME], [TYPEDESCRIPTION]) VALUES (@ACCOUNTTYPE, @TYPENAMENAME, @TYPEDESCRIPTION)" ProviderName="<%$ ConnectionStrings:ConnectionString1.ProviderName %>" SelectCommand="SELECT [ACCOUNTTYPE], [TYPENAMENAME], [TYPEDESCRIPTION] FROM [AccountType]" UpdateCommand="UPDATE [AccountType] SET [TYPENAMENAME] = @TYPENAMENAME, [TYPEDESCRIPTION] = @TYPEDESCRIPTION WHERE [ACCOUNTTYPE] = @ACCOUNTTYPE">
            <DeleteParameters>
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
                <asp:Parameter Name="TYPENAMENAME" Type="String" />
                <asp:Parameter Name="TYPEDESCRIPTION" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TYPENAMENAME" Type="String" />
                <asp:Parameter Name="TYPEDESCRIPTION" Type="String" />
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
    
    </div>
        <asp:GridView ID="GridView4" runat="server" AutoGenerateColumns="False" DataKeyNames="ACCOUNTTYPE" DataSourceID="SqlDataSource3" EmptyDataText="There are no data records to display.">
            <Columns>
                <asp:BoundField DataField="ACCOUNTTYPE" HeaderText="ACCOUNTTYPE" ReadOnly="True" SortExpression="ACCOUNTTYPE" />
                <asp:BoundField DataField="TYPENAMENAME" HeaderText="TYPENAMENAME" SortExpression="TYPENAMENAME" />
                <asp:BoundField DataField="TYPEDESCRIPTION" HeaderText="TYPEDESCRIPTION" SortExpression="TYPEDESCRIPTION" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ACCOUNT_LINQConnectionString %>" DeleteCommand="DELETE FROM [AccountType] WHERE [ACCOUNTTYPE] = @ACCOUNTTYPE" InsertCommand="INSERT INTO [AccountType] ([ACCOUNTTYPE], [TYPENAMENAME], [TYPEDESCRIPTION]) VALUES (@ACCOUNTTYPE, @TYPENAMENAME, @TYPEDESCRIPTION)" ProviderName="<%$ ConnectionStrings:ACCOUNT_LINQConnectionString.ProviderName %>" SelectCommand="SELECT [ACCOUNTTYPE], [TYPENAMENAME], [TYPEDESCRIPTION] FROM [AccountType]" UpdateCommand="UPDATE [AccountType] SET [TYPENAMENAME] = @TYPENAMENAME, [TYPEDESCRIPTION] = @TYPEDESCRIPTION WHERE [ACCOUNTTYPE] = @ACCOUNTTYPE">
            <DeleteParameters>
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
                <asp:Parameter Name="TYPENAMENAME" Type="String" />
                <asp:Parameter Name="TYPEDESCRIPTION" Type="String" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="TYPENAMENAME" Type="String" />
                <asp:Parameter Name="TYPEDESCRIPTION" Type="String" />
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ACCOUNT_LINQConnectionString %>" DeleteCommand="DELETE FROM [Account] WHERE [ACCOUNTID] = @ACCOUNTID" InsertCommand="INSERT INTO [Account] ([ACCOUNTID], [NAME], [PASSWORLD], [ACCOUNTTYPE]) VALUES (@ACCOUNTID, @NAME, @PASSWORLD, @ACCOUNTTYPE)" ProviderName="<%$ ConnectionStrings:ACCOUNT_LINQConnectionString.ProviderName %>" SelectCommand="SELECT [ACCOUNTID], [NAME], [PASSWORLD], [ACCOUNTTYPE] FROM [Account]" UpdateCommand="UPDATE [Account] SET [NAME] = @NAME, [PASSWORLD] = @PASSWORLD, [ACCOUNTTYPE] = @ACCOUNTTYPE WHERE [ACCOUNTID] = @ACCOUNTID">
            <DeleteParameters>
                <asp:Parameter Name="ACCOUNTID" Type="String" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="ACCOUNTID" Type="String" />
                <asp:Parameter Name="NAME" Type="String" />
                <asp:Parameter Name="PASSWORLD" Type="String" />
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="NAME" Type="String" />
                <asp:Parameter Name="PASSWORLD" Type="String" />
                <asp:Parameter Name="ACCOUNTTYPE" Type="Int32" />
                <asp:Parameter Name="ACCOUNTID" Type="String" />
            </UpdateParameters>
        </asp:SqlDataSource>
        <asp:Button ID="Button" runat="server" Text="Button" Onclick="Reset"/>
        <asp:Button ID="Button1" runat="server" Text="Button" Onclick="Delete"/>
    </form>
</body>
</html>
