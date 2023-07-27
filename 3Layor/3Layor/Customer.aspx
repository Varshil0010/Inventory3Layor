<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Customer.aspx.cs" Inherits="_3Layor.Customer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2>Customer Page</h2>

    <br />

    <h2><span class="badge badge-info btn-lg btn-block">Enter a New Customer here</span></h2>
    <br />
    <asp:Label ID="Label1" runat="server" Text="" ForeColor="Red"></asp:Label>
    <div class="form-group row">
        <label for="customerNo" class="col-sm-2 col-form-label">Customer ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtID" runat="server" placeholder="id" ></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="customerName" class="col-sm-2 col-form-label">Customer Name</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtName" runat="server" placeholder="customerName"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="city" class="col-sm-2 col-form-label">City</label>
        <div class="col-sm-10">
           <asp:TextBox class="form-control" ID="txtCity" runat="server" placeholder="City"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="grade" class="col-sm-2 col-form-label">Grade</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtGrade" runat="server" placeholder="Grade"></asp:TextBox>
        </div>
    </div>

    <div class="form-group row">
        <label for="salesmanNo" class="col-sm-2 col-form-label">Salesman ID</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtSalesmanID" runat="server" placeholder="Salesman id"></asp:TextBox>
        </div>
    </div>

     <asp:Label ID="lblCustomer" runat="server" ForeColor="Red"></asp:Label>

     <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Enter Customer" OnClick="btnSubmit_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-secondary" ID="btnUpdate" runat="server" Text="Update Customer" OnClick="btnUpdate_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="Delete Customer" OnClick="btnDelete_Click"></asp:Button>&nbsp;&nbsp;
        </div>
    </div>

    <h1><span class="badge badge-success btn-lg btn-block">Existing Salesman</span></h1>

    <asp:GridView ID="gvCustomer" runat="server"></asp:GridView>
</asp:Content>
