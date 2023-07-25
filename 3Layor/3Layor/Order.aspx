<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="_3Layor.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     <h2> Welcome to Inventory Management Solutions!!</h2>

    <br /><br />
    <h1><span class="badge badge-success btn-lg btn-block">Existing Orders</span></h1>

    <p>&nbsp;</p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataKeyNames="order_no" DataSourceID="SqlDataSource1">
            <Columns>
                <asp:CommandField ShowDeleteButton="True" ShowEditButton="True" ShowSelectButton="True" />
                <asp:BoundField DataField="order_no" HeaderText="order_no" ReadOnly="True" SortExpression="order_no" />
                <asp:BoundField DataField="purch_amt" HeaderText="purch_amt" SortExpression="purch_amt" />
                <asp:BoundField DataField="ord_date" HeaderText="ord_date" SortExpression="ord_date" />
                <asp:BoundField DataField="customer_id" HeaderText="customer_id" SortExpression="customer_id" />
                <asp:BoundField DataField="salesman_id" HeaderText="salesman_id" SortExpression="salesman_id" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:InventoryConnectionString %>" DeleteCommand="DELETE FROM [orders] WHERE [order_no] = @order_no" InsertCommand="INSERT INTO [orders] ([order_no], [purch_amt], [ord_date], [customer_id], [salesman_id]) VALUES (@order_no, @purch_amt, @ord_date, @customer_id, @salesman_id)" SelectCommand="SELECT * FROM [orders]" UpdateCommand="UPDATE [orders] SET [purch_amt] = @purch_amt, [ord_date] = @ord_date, [customer_id] = @customer_id, [salesman_id] = @salesman_id WHERE [order_no] = @order_no">
            <DeleteParameters>
                <asp:Parameter Name="order_no" Type="Int32" />
            </DeleteParameters>
            <InsertParameters>
                <asp:Parameter Name="order_no" Type="Int32" />
                <asp:Parameter Name="purch_amt" Type="Double" />
                <asp:Parameter DbType="Date" Name="ord_date" />
                <asp:Parameter Name="customer_id" Type="Int32" />
                <asp:Parameter Name="salesman_id" Type="Int32" />
            </InsertParameters>
            <UpdateParameters>
                <asp:Parameter Name="purch_amt" Type="Double" />
                <asp:Parameter DbType="Date" Name="ord_date" />
                <asp:Parameter Name="customer_id" Type="Int32" />
                <asp:Parameter Name="salesman_id" Type="Int32" />
                <asp:Parameter Name="order_no" Type="Int32" />
            </UpdateParameters>
        </asp:SqlDataSource>
</asp:Content>
