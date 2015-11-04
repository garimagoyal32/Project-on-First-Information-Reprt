<%@ Page Title="" Language="C#" MasterPageFile="~/olfir.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    
    <div style="width:700px; box-shadow: 0px 0px 15px #888888;background-color:#F5F5F5"> 
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label22" runat="server" Font-Bold="True" Font-Size="Large" 
            ForeColor="Maroon" Text="Filer's Details"></asp:Label>
&nbsp;<hr />
        </p>
  
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label4" 
    runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
&nbsp;<asp:Label ID="Label1" runat="server" 
            Text="Filer's Full Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="189px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label5" runat="server" 
    ForeColor="#FF3300" Text="*"></asp:Label>
&nbsp;<asp:Label ID="Label3" runat="server" Text="Father's/Husband's Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="189px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Label ID="Label8" runat="server" 
    ForeColor="#FF3300" Text="*"></asp:Label>
        &nbsp;Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="206px" Height="51px" 
            TextMode="MultiLine"></asp:TextBox>
            &nbsp;&nbsp;<br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br __designer:mapid="211" />
            &nbsp;&nbsp;&nbsp; &nbsp;  
<asp:Label ID="Label9" runat="server" ForeColor="#FF3300" Text="*"></asp:Label>
City/District&nbsp;
            &nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" 
            Width="207px">
                <asp:ListItem>Select</asp:ListItem>
                <asp:ListItem>Bagalkot</asp:ListItem>
                <asp:ListItem>Bangalore city</asp:ListItem>
                <asp:ListItem>Bangalore District</asp:ListItem>
                <asp:ListItem>Belari</asp:ListItem>
                <asp:ListItem>Belgaun</asp:ListItem>
                <asp:ListItem>Bidar</asp:ListItem>
                <asp:ListItem>Bijapur</asp:ListItem>
                <asp:ListItem>Chamarajanagar</asp:ListItem>
                <asp:ListItem>Chikmagalur</asp:ListItem>
                <asp:ListItem>Chikkaballapura</asp:ListItem>
                <asp:ListItem>Chitradurga</asp:ListItem>
                <asp:ListItem>Dakshina Kannada</asp:ListItem>
                <asp:ListItem>Davanagere</asp:ListItem>
                <asp:ListItem>Dharwad</asp:ListItem>
                <asp:ListItem>Hassan</asp:ListItem>
                <asp:ListItem>Haveri</asp:ListItem>
                <asp:ListItem>Gulbarga</asp:ListItem>
                <asp:ListItem>Gadag</asp:ListItem>
                <asp:ListItem>Kodagu</asp:ListItem>
                <asp:ListItem>Kolar</asp:ListItem>
                <asp:ListItem>Koppal</asp:ListItem>
                <asp:ListItem>Mandya</asp:ListItem>
                <asp:ListItem>Mysore</asp:ListItem>
                <asp:ListItem>Raichur</asp:ListItem>
                <asp:ListItem>Ramanagara</asp:ListItem>
                <asp:ListItem>Shimoga</asp:ListItem>
                <asp:ListItem>Tumkur</asp:ListItem>
                <asp:ListItem>Udupi</asp:ListItem>
                <asp:ListItem>Uttara Kannada</asp:ListItem>
                <asp:ListItem>Yadgir</asp:ListItem>
        </asp:DropDownList>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp; 
        Phone no.&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox 
    ID="TextBox9" runat="server" Width="205px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mobile&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox 
    ID="TextBox12" runat="server" Width="201px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; 
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:Blue;font-size:12px"> (with 
        Area Code )</span><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox11" runat="server" Width="206px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" Text="Submit" onclick="Button1_Click" 
            BackColor="#333333" BorderColor="Gray" BorderStyle="Outset" Font-Bold="True" 
            ForeColor="White" Width="60px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" Text="Reset" onclick="Button2_Click" 
            BackColor="#333333" BorderColor="#666666" BorderStyle="Outset" Font-Bold="True" 
            ForeColor="White" Width="60px" />
        <br />
        <br />
        <hr />
        <p style=" text-align: justify;">
            <span style="color: blue; font-family: Verdana; font-size: 9px; font-style: normal; font-weight: bold; letter-spacing: normal;  text-indent: 0px; text-transform: none; white-space: normal; widows: auto; word-spacing: 0px; -webkit-text-stroke-width: 0px; display: inline !important; float: none;">
       &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
       All the fields marked with '<span style="color:Red"> * </span>' are mandatory to fill.</span></p>
        <p style=" text-align: justify;">
            &nbsp;</p>
        <p style=" text-align: justify;">
            &nbsp;</p>
</div>
    
</asp:Content>

