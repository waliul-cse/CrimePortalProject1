<%@ Page Title="Criminal Physical Inoformation" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="criminal-physical-information.aspx.cs" Inherits="PoliceCrimePortal.Activities.DataEntry.criminal_physical_information" %>

<asp:Content ID="Content3" ContentPlaceHolderID="MainContent" runat="server">
    <hgroup class="title">
        <h1><%: Title %>.</h1>
        <h2>Use the form below to enter Physical information.</h2>
    </hgroup>

    <p class="message-info">
        <span class="require">*</span> Require Field.
    </p>

    <p class="validation-summary-errors">
        <asp:Literal runat="server" ID="ErrorMessage" />
    </p>

    <fieldset>
        <legend>Criminal Physical Information Form</legend>
        <ol>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtRefNo">Reference No:<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ReadOnly="true" ID="txtRefNo" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtRefNo"
                    CssClass="field-validation-error" ErrorMessage="The Reference No field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtheight">Height(Inch):<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ID="txtheight" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtheight"
                    CssClass="field-validation-error" ErrorMessage="The Height field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtWeight">Weight(Kg):<span class="require">*</span></asp:Label>
                <asp:TextBox runat="server" ID="txtWeight" />
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtWeight"
                    CssClass="field-validation-error" ErrorMessage="The Weight field is required." />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtEyeColor">Eye Color:</asp:Label>
                <asp:TextBox runat="server" ID="txtEyeColor" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="fuEyeIamge">Eye Image:</asp:Label>
                <asp:FileUpload ID="fuEyeIamge" runat="server" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtLips">Lips:</asp:Label>
                <asp:TextBox runat="server" ID="txtLips" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtIrregularitiesOnEye">Irregularities on Eye:</asp:Label>
                <asp:TextBox runat="server" ID="txtIrregularitiesOnEye" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtSkinColor">Skin Color:</asp:Label>
                <asp:TextBox runat="server" ID="txtSkinColor" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtNose">Nose:</asp:Label>
                <asp:TextBox runat="server" ID="txtNose" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtShapeOfBody">Shape of Body:</asp:Label>
                <asp:TextBox runat="server" ID="txtShapeOfBody" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtShapeOfHead">Shape of Head:</asp:Label>
                <asp:TextBox runat="server" ID="txtShapeOfHead" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtTeeth">Teeth:</asp:Label>
                <asp:TextBox runat="server" ID="txtTeeth" />
            </li>

            <li>
                <asp:Label runat="server" AssociatedControlID="txtHairColor">Hair Color:</asp:Label>
                <asp:TextBox runat="server" ID="txtHairColor" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtTypeOfHair">Type of Hair:</asp:Label>
                <asp:TextBox runat="server" ID="txtTypeOfHair" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtTattoo">Tattoo:</asp:Label>
                <asp:TextBox runat="server" ID="txtTattoo" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtEar">Ear:</asp:Label>
                <asp:TextBox runat="server" ID="txtEar" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtTypeOfFace">Type of Face:</asp:Label>
                <asp:TextBox runat="server" ID="txtTypeOfFace" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtScarsAndHandicap">Scars & Handicap:</asp:Label>
                <asp:TextBox runat="server" ID="txtScarsAndHandicap" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtForehead">Forehead:</asp:Label>
                <asp:TextBox runat="server" ID="txtForehead" />
            </li>
            <li>
                <asp:Label runat="server" AssociatedControlID="txtIdentificationMark">Identification Mark:</asp:Label>
                <asp:TextBox runat="server" ID="txtIdentificationMark" />
            </li>
             <li>
                <asp:Label runat="server" AssociatedControlID="fuPicture">Picture:</asp:Label>
                <asp:FileUpload ID="fuPicture" runat="server" />
            </li>
        </ol>
        <asp:Button runat="server" ID="btnSave" Text="Save" OnClick="btnSave_Click" />
    </fieldset>
</asp:Content>
