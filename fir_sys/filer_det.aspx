<%@ Page Title="" Language="C#" MasterPageFile="~/admin.master" AutoEventWireup="true" CodeFile="filer_det.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div style="position:absolute;left:250px; width:644px; height:494px; top:54px;box-shadow: 0px 0px 25px #888888;border-radius:1em;background-color:#F5F5F5">

    &nbsp;<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Label ID="Label10" runat="server" Font-Bold="True" Font-Size="Large" 
        ForeColor="Maroon" Text="Filer's Details"></asp:Label>
    <hr />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Filer Id&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="TextBox13" runat="server" Width="189px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label11" runat="server" Font-Bold="True" Font-Size="Small" 
            ForeColor="Red" Text="*Filer id does not exists" Visible="False"></asp:Label>
        <br />
    <br />
    &nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;&nbsp; <asp:Label ID="Label1" runat="server" 
            Text="Filer's Full Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:TextBox ID="TextBox1" runat="server" Width="189px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        &nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
&nbsp;<asp:Label ID="Label3" runat="server" Text="Father's/Husband's Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="TextBox3" runat="server" Width="189px"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Address&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox5" runat="server" Width="206px" Height="51px" 
            TextMode="MultiLine"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br __designer:mapid="211" />
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;
City/District&nbsp;
            &nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" Height="25px" 
            Width="207px" AutoPostBack="True">
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
    ID="TextBox9" runat="server" Width="166px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Mobile&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:TextBox 
    ID="TextBox12" runat="server" Width="156px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp; 
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<span style="color:Blue;font-size:12px"> (with 
        Area Code )</span><br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Email&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TextBox11" runat="server" Width="206px"></asp:TextBox>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" Text="Edit" onclick="Button1_Click" 
            BackColor="#333333" BorderColor="#666666" BorderStyle="Outset" Font-Bold="True" 
            ForeColor="White" Width="60px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button2" runat="server" Text="View" onclick="Button2_Click" 
            BackColor="#333333" BorderColor="#666666" BorderStyle="Outset" Font-Bold="True" 
            ForeColor="White" Width="60px" />

        <br />
        <asp:HiddenField ID="HiddenField1" runat="server" />

</div>
</asp:Content>

