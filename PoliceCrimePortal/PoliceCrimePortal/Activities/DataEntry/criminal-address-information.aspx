<%@ Page Title="Criminal Address Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="criminal-address-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.criminal_Address_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter address information.</h2>
    </hgroup>

    <p class="message-info">
        <span class="require">*</span> Require Field.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <fieldset>
        <legend>Criminal Address Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtperDistrict">Permanent District:</asp:Label>
                <asp:TextBox runat="server" ID="txtperDistrict" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPerUplozila">Permanent Upozila/Thana:</asp:Label>
                <asp:TextBox runat="server" ID="txtPerUplozila" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPerUnion">Permanent Union/Ward:</asp:Label>
                <asp:TextBox runat="server" ID="txtPerUnion" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPerVillage">Permanent Village:</asp:Label>
                <asp:TextBox ID="txtPerVillage" runat="server" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPreDistrict">Present District:</asp:Label>
                <asp:TextBox runat="server" ID="txtPreDistrict" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPreUpozila">Present Upoliza/Thana:</asp:Label>
                <asp:TextBox runat="server" ID="txtPreUpozila" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPreUnion">Present Union/Ward:</asp:Label>
                <asp:TextBox runat="server" ID="txtPreUnion" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPreVillage">Present Village:</asp:Label>
                <asp:TextBox runat="server" ID="txtPreVillage" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtLastAddressRegion">Last Address Region:</asp:Label>
                <asp:TextBox runat="server" ID="txtLastAddressRegion" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDurationofStay">Duration of Stay:</asp:Label>
                <asp:TextBox runat="server" ID="txtDurationofStay" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRemarks">Remarks:</asp:Label>
                <asp:TextBox runat="server" ID="txtRemarks" />
            </li>

            <li>
                <asp:Label runat="server" AssociatedControlID="txtWorkingArea">Working Area:</asp:Label>
                <asp:TextBox runat="server" ID="txtWorkingArea" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPhoneNo">Phone No:</asp:Label>
                <asp:TextBox runat="server" ID="txtPhoneNo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtMobileNo">Mobile No:</asp:Label>
                <asp:TextBox runat="server" ID="txtMobileNo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtEmail">Email:</asp:Label>
                <asp:TextBox runat="server" ID="txtEmail" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>

</asp:Content>
