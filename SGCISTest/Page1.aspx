<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Page1.aspx.cs" Inherits="SGCISTest.Page1" %>

<%@ Register Assembly="Telerik.Web.UI" Namespace="Telerik.Web.UI" TagPrefix="telerik" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1, shrink-to-fit=no" />

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css" integrity="sha384-ggOyR0iXCbMQv3Xipma34MD+dH/1fQ784/j6cY/iJTQUOhcWr7x9JvoRxT2MZw1T" crossorigin="anonymous" />

    <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.7/umd/popper.min.js" integrity="sha384-UO2eT0CpHqdSJQ6hJty5KVphtPhzWj9WO1clHTMGa3JDZwrnQq4sF86dIHNDz0W1" crossorigin="anonymous"></script>
    <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/js/bootstrap.min.js" integrity="sha384-JjSmVgyd0p3pXB1rRibZUAYoIIy6OrQ6VrjIEaFf/nJGzIxFDsf4x0xIM+B07jRM" crossorigin="anonymous"></script>

    <title>SGCIS Test Page 1</title>
</head>
<body>
    <form runat="server">
        <nav class="navbar navbar-expand-lg navbar-light bg-light">
            <button class="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarTogglerDemo01" aria-controls="navbarTogglerDemo01" aria-expanded="false" aria-label="Toggle navigation">
                <span class="navbar-toggler-icon"></span>
            </button>
            <div class="collapse navbar-collapse" id="navbarTogglerDemo01">
                <a class="navbar-brand" href="#">SGCIS Test</a>
                <ul class="navbar-nav mr-auto mt-2 mt-lg-0">
                    <li class="nav-item active">
                        <a class="nav-link" href="#">Page 1<span class="sr-only">(current)</span></a>
                    </li>
                </ul>
            </div>
        </nav>

        <telerik:RadScriptManager runat="server" ID="RadScriptManager" />

        <br />
        <div style="width: 90%; margin: 0 auto;">
            <h1>SGCIS Test Page 1</h1>
            <hr />
            <telerik:RadGrid ID="PersonsGrid" RenderMode="Lightweight"  runat="server" AllowPaging="true" AutoGenerateColumns="false"
                AllowSorting="true" AllowFilteringByColumn="true" OnItemDataBound="PersonsGrid_ItemDataBound" OnItemInserted="PersonsGrid_ItemInserted"
                OnInsertCommand="PersonsGrid_InsertCommand" OnPreRender="PersonsGrid_PreRender" OnNeedDataSource="PersonsGrid_NeedDataSource" 
                OnUpdateCommand="PersonsGrid_UpdateCommand" OnDeleteCommand="PersonsGrid_DeleteCommand" MasterTableView-EditFormSettings-EditColumn-SortAscImageUrl="MySortAscImage.gif"
                OnItemCommand="PersonsGrid_ItemCommand">
                <MasterTableView ClientDataKeyNames="Id" CommandItemDisplay="Top">
                    <Columns>
                        <telerik:GridBoundColumn DataField="Id" HeaderText="Id" ReadOnly="true">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Name" HeaderText="Name" ColumnEditorID="GridTextBoxEditor">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn DataField="Age" HeaderText="Age" ColumnEditorID="GridTextBoxEditor">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn ReadOnly="true" DataField="PersonType.Description" HeaderText="Person Type" ColumnEditorID="GridComboBoxEditor">
                        </telerik:GridBoundColumn>
                        <telerik:GridBoundColumn ReadOnly="true" Visible="false" DataField="PersonTypeId" ColumnEditorID="GridComboBoxEditor">
                        </telerik:GridBoundColumn>
                        <telerik:GridDropDownColumn UniqueName="PersonType" DataField="PersonTypeId" ListTextField="Description" ListValueField="Id"
                            HeaderText="Person Type" Visible="false">
                        </telerik:GridDropDownColumn>
                        <telerik:GridEditCommandColumn />
                        <telerik:GridButtonColumn ConfirmText="Delete this person?" ConfirmDialogType="RadWindow"
                            ConfirmTitle="Delete" ButtonType="FontIconButton" CommandName="Delete" />
                        
                        <telerik:GridButtonColumn ButtonType="ImageButton" HeaderButtonType="LinkButton" UniqueName="TeacherDisplay" CommandName="Link" 
                            ImageUrl="./Images/pages.jpg" /> 
                    </Columns>
                </MasterTableView>
            </telerik:RadGrid>
        </div>
    </form>
</body>
</html>
