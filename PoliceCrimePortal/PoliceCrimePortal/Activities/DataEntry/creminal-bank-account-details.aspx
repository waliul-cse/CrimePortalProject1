<%@ Page Title="Creminal Bank Account Details" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="creminal-bank-account-details.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.creminal_bank_account_details" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter Bank account information.</h2>
    </hgroup>

    <p class="message-info">
        <span class="require">*</span> Require Field.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>
     <p class="message-success">
        <asp:Literal runat="server" ID="SuccessMessage" />
    </p>
    <fieldset>
        <legend>Criminal Bank Account Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtBankName">Bank Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtBankName" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtAccountNo">Account No:</asp:Label>
                <asp:TextBox runat="server" ID="txtAccountNo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtAccountType">Account Type:</asp:Label>
                <asp:TextBox runat="server" ID="txtAccountType" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCreditCardNo">Credit Card No:</asp:Label>
                <asp:TextBox runat="server" ID="txtCreditCardNo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtDebitCardNo">Debit Card No:</asp:Label>
                <asp:TextBox runat="server" ID="txtDebitCardNo" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnAddmore" Text="Add More" OnClick="btnAddmore_Click" />
        <asp:Button runat="server" ID="btnSave" Text="Save & Continue" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
