<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Salesman.aspx.cs" Inherits="_3Layor.Salesman" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder" runat="server">
    <h2>Welcome to Salesman Page!!</h2>

    <br />

    <h2><span class="badge badge-info btn-lg btn-block">Enter a New Salesman</span></h2>
    <br />
    <asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
    <div class="form-group row">
        <label for="salesmanNo" class="col-sm-2 col-form-label">Salesman Number</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtID" runat="server" placeholder="id"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="salesmanName" class="col-sm-2 col-form-label">Salesman Name</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtSalesmanName" runat="server" placeholder="salesmanName"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="city" class="col-sm-2 col-form-label">City</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCity" runat="server" placeholder="city"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <label for="commission" class="col-sm-2 col-form-label">Commission</label>
        <div class="col-sm-10">
            <asp:TextBox class="form-control" ID="txtCommission" runat="server" placeholder="Commission"></asp:TextBox>
        </div>
    </div>
    <div class="form-group row">
        <div class="col-sm-10">
            <asp:Button CssClass="btn btn-primary" ID="btnSubmit" runat="server" Text="Enter Salesman" OnClick="btnSubmit_Click"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-secondary" ID="btnUpdate" runat="server" Text="Update Salesman"></asp:Button>&nbsp;&nbsp;
            <asp:Button CssClass="btn btn-danger" ID="btnDelete" runat="server" Text="Delete Salesman"></asp:Button>&nbsp;&nbsp;
            <asp:Label ID="lblSalesmanResult" runat="server" Text=""></asp:Label>
        </div>
    </div>

    <h1><span class="badge badge-success btn-lg btn-block">Existing Salesman</span></h1>

    <br />
    <asp:GridView ID="gvSalesman" runat="server"></asp:GridView>

</asp:Content>
