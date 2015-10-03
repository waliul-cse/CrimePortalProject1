<%@ Page Title="Basic Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="criminal-Basic-Information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.Criminal_Basic_Information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter Basic information.</h2>
    </hgroup>

    <p class="message-info">
        <span class="require">*</span> Require Field.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <fieldset>
        <legend>Criminal Basic Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtFullName">Full Name:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ID="txtFullName" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtFullName"
                    CssClass="field-validation-error" ErrorMessage="The Full Name field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtNickName">Nick Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtNickName" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCriminalName">Criminal Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtCriminalName" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ddlGender">Gender:<span class="require">*</span></asp:Label>
                <asp:DropDownList ID="ddlGender" runat="server" Width="315px">
                    <asp:ListItem Text="Male" Value="Male"></asp:ListItem>
                    <asp:ListItem Text="Female" Value="Female"></asp:ListItem>
                </asp:DropDownList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtReligion">Religion:</asp:Label>
                <asp:TextBox runat="server" ID="txtReligion" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ddlBloodGroup">Blood Group:</asp:Label>
                <asp:DropDownList ID="ddlBloodGroup" runat="server" Width="315px">
                    <asp:ListItem Text="A(+)" Value="A(+)"></asp:ListItem>
                    <asp:ListItem Text="A(-)" Value="A(-)"></asp:ListItem>
                    <asp:ListItem Text="B(+)" Value="B(+)"></asp:ListItem>
                    <asp:ListItem Text="B(-)" Value="B(-)"></asp:ListItem>
                    <asp:ListItem Text="AB(+)" Value="AB(+)"></asp:ListItem>
                    <asp:ListItem Text="AB(-)" Value="AB(-)"></asp:ListItem>
                    <asp:ListItem Text="O(+)" Value="O(+)"></asp:ListItem>
                    <asp:ListItem Text="O(-)" Value="O(-)"></asp:ListItem>
                </asp:DropDownList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDOB">Date of Birth:</asp:Label>
                <asp:TextBox runat="server" ID="txtDOB" /><span>DD-MM-YYYY</span>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRegionofBirth">Region of Birth:</asp:Label>
                <asp:TextBox runat="server" ID="txtRegionofBirth" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtUsualDressUp">Usual Dress Up:</asp:Label>
                <asp:TextBox runat="server" ID="txtUsualDressUp" />
            </li>

            <li>
                <asp:Label runat="server" AssociatedControlID="txtMaritalStatus">Marital Status:</asp:Label>
                <asp:DropDownList ID="txtMaritalStatus" runat="server" Width="315px">
                    <asp:ListItem Text="Single" Value="Single"></asp:ListItem>
                    <asp:ListItem Text="Married " Value="Married "></asp:ListItem>
                    <asp:ListItem Text="Separated" Value="Separated"></asp:ListItem>
                    <asp:ListItem Text="Divorced " Value="Divorced "></asp:ListItem>
                    <asp:ListItem Text="Widowed " Value="Widowed"></asp:ListItem>
                </asp:DropDownList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDialectAccent">Dialect Accent:</asp:Label>
                <asp:TextBox runat="server" ID="txtDialectAccent" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDrivingLicenseNo">Driving License No:</asp:Label>
                <asp:TextBox runat="server" ID="txtDrivingLicenseNo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtNationalID">National ID:</asp:Label>
                <asp:TextBox runat="server" ID="txtNationalID" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPassportNo">Passport No:</asp:Label>
                <asp:TextBox runat="server" ID="txtPassportNo" />
            </li>
        </ol>
        <asp:Button runat="server" Text="Save" ID="btnSave" OnClick="btnSave_Click" />
    </fieldset>

</asp:Content>
