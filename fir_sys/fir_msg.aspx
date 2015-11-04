<%@ Page Title="" Language="C#" MasterPageFile="~/olfir.master" AutoEventWireup="true" CodeFile="fir_msg.aspx.cs" Inherits="Default3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div  style="width:700px; box-shadow: 0px 0px 15px #888888;background-color:#F5F5F5">

    <br />
    <br />
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:Panel ID="Panel1" runat="server" Visible="False">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#0033CC" Text="FIR Laudged Successfully !"></asp:Label>
        <br />
        <br />
        <p style="margin:30px; font-family: 'Times New Roman', Times, serif; text-align: justify;">
            Your FIR has been successfully laudged.<br /> You will receive a confirmation 
            call within 24 hours of filling the FIR. If you do not receive such message, 
            please relodge the FIR [use Refile FIR button on the menu bar].</p>
        <p style="margin:30px; font-family: 'Times New Roman', Times, serif; text-align: justify;">
            Your FIR is registered at FIR Number :
            <asp:Label ID="Label3" runat="server" Font-Bold="True" ForeColor="Maroon" 
                Text="Label"></asp:Label>
            <br />
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" Visible="False">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#0033CC" Text="Grievance Report filed Successfully !"></asp:Label>
        <br />
        <br />
        <p style="margin:30px; font-family: 'Times New Roman', Times, serif; text-align: justify;">
            Your Police Grievance Report has been successfully laudged.<br /> Appropriate 
            action will be taken against the guilty person(s).<br />
            <br />
        </p>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    </asp:Panel>
        <asp:Panel ID="Panel3" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label4" runat="server" Font-Bold="True" Font-Size="X-Large" 
            ForeColor="#0033CC" Text="FIR ReLaudged Successfully !"></asp:Label>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Your FIR with FIR Number :
            <asp:Label ID="Label5" runat="server" Font-Bold="True" ForeColor="Maroon" 
                Text="Label"></asp:Label>
            &nbsp;has been successfully relaudged.<br />
            <br />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel4" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label6" runat="server" Font-Bold="True" Font-Size="X-Large" 
                ForeColor="Maroon" Text="Action Failed !"></asp:Label>
            <br />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; FIR can only be relaudged after 36 hours of initially laudging the FIR.<br /> 
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Please wait !!<br /> &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Time remaining :
            <asp:Label ID="Label7" runat="server" Font-Bold="True" ForeColor="Maroon" 
                Text="Label"></asp:Label>
            <asp:Label ID="Label8" runat="server" ForeColor="#0033CC" Text="day"></asp:Label>
            &nbsp;
            <asp:Label ID="Label9" runat="server" Font-Bold="True" ForeColor="Maroon" 
                Text="Label"></asp:Label>
            <asp:Label ID="Label10" runat="server" ForeColor="#0033CC" Text="h:"></asp:Label>
            <asp:Label ID="Label11" runat="server" Font-Bold="True" ForeColor="Maroon" 
                Text="Label"></asp:Label>
            <asp:Label ID="Label12" runat="server" ForeColor="#0033CC" Text="m:"></asp:Label>
            <asp:Label ID="Label13" runat="server" Font-Bold="True" ForeColor="Maroon" 
                Text="Label"></asp:Label>
            <asp:Label ID="Label14" runat="server" ForeColor="#0033CC" Text="s"></asp:Label>
            <br />
            <br />
            <br />
        </asp:Panel>
        <asp:Panel ID="Panel5" runat="server">
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="Label15" runat="server" Font-Bold="True" Font-Size="X-Large" 
                ForeColor="#0033CC" Text="FIR Laudged Successfully !"></asp:Label>
            <br />
            <br />
            <p style="margin:30px; font-family: 'Times New Roman', Times, serif; text-align: justify;">
                Your request to edit FIR has been filed.Your FIR has been successfully laudged.<br /> 
                In order to maintain security and preventing FIR to be changed by any person 
                other than the complainant or victim online editing FIR feature is not made 
                available.&nbsp;
            </p>
            <p style="margin:30px; font-family: 'Times New Roman', Times, serif; text-align: justify;">
                You will receive a confirmation call within 24 hours to collect the information 
                to be changed in the FIR.</p>
        </asp:Panel>
    <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
</div>
</asp:Content>

