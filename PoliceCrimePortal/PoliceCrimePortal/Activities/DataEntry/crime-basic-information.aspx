<%@ Page Title="Crime Basic Information" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="crime-basic-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.crime_basic_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter Crime information.</h2>
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
                <asp:Label runat="server" AssociatedControlID="rblCriminalStatus">Criminal Status:</asp:Label>
                <asp:RadioButtonList ID="rblCriminalStatus" runat="server" RepeatDirection="Horizontal" CssClass="inline-rb">
                    <asp:ListItem Text="Listed" Value="Listed"></asp:ListItem>
                    <asp:ListItem Text="Not Listed" Value="Not Listed"></asp:ListItem>
                </asp:RadioButtonList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtGangName">Gang/Group Name:</asp:Label>
                <asp:TextBox runat="server" ID="txtGangName" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="ddlCrimeType">Crime Type:</asp:Label>
                <asp:DropDownList ID="ddlCrimeType" runat="server">
                    <asp:ListItem Text="Muder for gain" Value="Muder for gain"></asp:ListItem>
                    <asp:ListItem Text="Dacoity" Value="Dacoity"></asp:ListItem>
                    <asp:ListItem Text="Prep & Assembly for Dacoity" Value="Prep & Assembly for Dacoity"></asp:ListItem>
                    <asp:ListItem Text="Robbery" Value="Robbery"></asp:ListItem>
                    <asp:ListItem Text="Burglary" Value="Burglary"></asp:ListItem>
                    <asp:ListItem Text="Theft" Value="Theft"></asp:ListItem>
                    <asp:ListItem Text="Murder" Value="Murder"></asp:ListItem>
                    <asp:ListItem Text="Attempt to commit murder" Value="Attempt to commit murder"></asp:ListItem>
                    <asp:ListItem Text="C.H.Not Amounting to murder" Value="C.H.Not Amounting to murder"></asp:ListItem>
                    <asp:ListItem Text="Hurt/Grievous Hurt" Value="Hurt/Grievous Hurt"></asp:ListItem>
                    <asp:ListItem Text="Roits" Value="Roits"></asp:ListItem>
                    <asp:ListItem Text="Rape" Value="Rape"></asp:ListItem>
                    <asp:ListItem Text="Dowry Death" Value="Dowry Death"></asp:ListItem>
                    <asp:ListItem Text="Molestation" Value="Molestation"></asp:ListItem>
                    <asp:ListItem Text="Sexual Harassment" Value="Sexual Harassment"></asp:ListItem>
                    <asp:ListItem Text="Cruelty by Husband and her relatives" Value="Cruelty by Husband and her relatives"></asp:ListItem>
                    <asp:ListItem Text="Kidnapping & Abduction of others" Value="Kidnapping & Abduction of others"></asp:ListItem>
                    <asp:ListItem Text="Criminal Breach of Trust" Value="Criminal Breach of Trust"></asp:ListItem>
                    <asp:ListItem Text="Arson" Value="Arson"></asp:ListItem>
                    <asp:ListItem Text="Cheating" Value="Cheating"></asp:ListItem>
                    <asp:ListItem Text="Counterfeiting" Value="Counterfeiting"></asp:ListItem>
                    <asp:ListItem Text="Other crime" Value="other Crime"></asp:ListItem>
                </asp:DropDownList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="rblIllegalArmsPossession">Illegal Arms Possession:</asp:Label>
                <asp:RadioButtonList ID="rblIllegalArmsPossession" runat="server" RepeatDirection="Horizontal" CssClass="inline-rb">
                    <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
                    <asp:ListItem Text="No" Value="0"></asp:ListItem>
                </asp:RadioButtonList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="rbllegalArmsPossession">legal Arms Possession:</asp:Label>
                <asp:RadioButtonList ID="rbllegalArmsPossession" runat="server" RepeatDirection="Horizontal" CssClass="inline-rb">
                    <asp:ListItem Text="Yes" Value="1"></asp:ListItem>
                    <asp:ListItem Text="No" Value="0"></asp:ListItem>
                </asp:RadioButtonList>
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRemarks">Remarks:</asp:Label>
                <asp:TextBox runat="server" TextMode="MultiLine" ID="txtRemarks" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtPriorityListGovt">Priority List Govt:</asp:Label>
                <asp:TextBox runat="server" ID="txtPriorityListGovt" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtCaseDetails">Case Details:</asp:Label>
                <asp:TextBox TextMode="MultiLine"  runat="server" ID="txtCaseDetails" />
                
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtLastState">Last State:</asp:Label>
                <asp:TextBox runat="server" ID="txtLastState" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save & Continue" OnClick="btnSave_Click" />
        <asp:Button runat="server" ID="btnskip" Text="Skip" OnClick="btnSkip_Click" />
    </fieldset>
</asp:Content>
