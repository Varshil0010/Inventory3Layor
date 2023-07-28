<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="_3Layor.Order" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
     <h2> Welcome to Inventory Management Solutions!!</h2>

    <br /><br />
    <h1><span class="badge badge-success btn-lg btn-block">Existing Orders</span></h1>

    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <div class="form-group row">
        <label for="orderNo" class="col-sm-2 col-form-label">Order NO</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="orderID" runat="server" placeholder="id" ></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="purchAmt" class="col-sm-2 col-form-label">Purchase Amount</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtAmt" runat="server" placeholder="purchaseAmt"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="date" class="col-sm-2 col-form-label">Order Date</label>
        <div class="col-sm-10">
           <asp:TextBox class="form-control" ID="txtDate" TextMode="Date" runat="server" placeholder="Date"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="cID" class="col-sm-2 col-form-label">Customer ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCustomerID" runat="server" placeholder="CustomerID"></asp:TextBox>
        </div>
    </div>

    <div class="form-group row">
        <label for="salesmanID" class="col-sm-2 col-form-label">Salesman ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtSalesmanID" runat="server" placeholder="Salesman id"></asp:TextBox>
        </div>
    </div>

     <asp:Label ID="lblOrder" runat="server" ForeColor="Red"></asp:Label>

     <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Enter Customer" OnClick="btnSubmit_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-secondary" ID="btnUpdate" runat="server" Text="Update Customer" OnClick="btnUpdate_Click" ></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="Delete Customer" OnClick="btnDelete_Click"></asp:Button>&nbsp;&nbsp;
        </div>
    </div>

    <h1><span class="badge badge-success btn-lg btn-block">Existing Orders</span></h1>

    <asp:GridView ID="gvOrders" runat="server"></asp:GridView>
</asp:Content>
