<%@ Page Title="" Language="C#" MasterPageFile="~/olfir.master" AutoEventWireup="true" CodeFile="refile.aspx.cs" Inherits="Default2" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div  style="width:700px; box-shadow: 0px 0px 15px #888888;background-color:#F5F5F5">

    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Relaudge FIR" Font-Bold="True" 
        Font-Size="Large" ForeColor="Maroon"></asp:Label>
    <hr />
    &nbsp;
    <br />
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
    FIR Number&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox1" runat="server" Width="193px"></asp:TextBox>
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label2" runat="server" Font-Size="Small" ForeColor="Red" 
        Text="* Please enter a valid FIR Number" Visible="False"></asp:Label>
    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
        BackColor="#333333" BorderColor="#666666" BorderStyle="Outset" Font-Bold="True" 
        ForeColor="White" Width="60px" />
    <br />
    <br />
    <br />
    <hr />
    <p style="margin: 20px; text-align: justify;color: rgb(0, 0, 255); font-family: Verdana; font-size: 9px; font-style: normal; font-variant: normal; font-weight: bold;">
    <span style="color:Red"> Rules for refiling FIR</span><br />
    -&nbsp;&nbsp;&nbsp; FIR can be relaudged after 36 hours of initially laudging the FIR only. However FIR can be relaudged after 24 hours if no<br />&nbsp;&nbsp;&nbsp;&nbsp; confirmation call/message is received by the filer within 24 hours of filing the FIR.<br />
    -&nbsp;&nbsp;&nbsp; Before refiling the FIR please check the status of the FIR. Relaudge the FIR only when its status is 'under processing'. 
    
    </p>
    <br />
    <br />
</div>
</asp:Content>

