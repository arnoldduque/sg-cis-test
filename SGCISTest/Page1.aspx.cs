using SGCISTest.SGCISService;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web.UI;
using Telerik.Web.UI;

namespace SGCISTest
{
    public partial class Page1 : Page
    {
        #region Variables

        private string gridMessage = null;
        private Person[] persons;
        private PersonType[] personTypes;
        PersonServiceClient serviceClient;

        #endregion

        #region Load Methods

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsCallback)
            {
                serviceClient = new PersonServiceClient();
                persons = serviceClient.GetPersons();
                personTypes = serviceClient.GetPersonTypes();
            }
        }

        protected void PersonsGrid_PreRender(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(gridMessage))
            {
                DisplayMessage(gridMessage);
            }
        }

        protected void PersonsGrid_NeedDataSource(object sender, GridNeedDataSourceEventArgs e)
        {
            List<Person> personList = new List<Person>();

            foreach (Person p in persons)
            {
                p.PersonType = personTypes.Where(t => t.Id == p.PersonTypeId).FirstOrDefault();
                personList.Add(p);
            }

            PersonsGrid.DataSource = personList;
        }

        protected void PersonsGrid_ItemDataBound(object sender, GridItemEventArgs e)
        {
            if (e.Item is GridEditableItem && (e.Item as GridEditableItem).IsInEditMode)
            {
                GridEditableItem editedItem = e.Item as GridEditableItem;
                GridEditManager manager = editedItem.EditManager;

                GridDropDownColumnEditor editor = manager.GetColumnEditor("PersonType") as GridDropDownColumnEditor;
                editor.DataSource = personTypes;
                editor.DataBind();

                if (manager.GetColumnEditor("PersonType.Description") is GridTextBoxColumnEditor personType && personType.Text != "")
                {
                    string typeId = personTypes.Where(t => t.Description == personType.Text).FirstOrDefault().Id.ToString();
                    editor.SelectedValue = typeId;
                }
            }

            if (e.Item is GridDataItem ditem)
            {
                var buttonTeacherDisplay = ditem["TeacherDisplay"].Controls[0];

                if (((Person)ditem.DataItem).PersonTypeId != 2)
                    buttonTeacherDisplay.Visible = false;
            }            
        }

        protected void PersonsGrid_ItemCommand(object sender, GridCommandEventArgs e)
        {
            if (e.CommandName == "Link")
            {
                GridDataItem item = (GridDataItem)e.Item;
                string url = "Page2.aspx?id=" + item["Id"].Text + "&name=" + item["Name"].Text + "&age=" + item["Age"].Text + "&type=" + item["PersonType.Description"].Text;
                string s = "window.open('" + url + "', 'popup_window', 'width=800,height=600,left=100,top=100,resizable=yes');";
                ClientScript.RegisterStartupScript(this.GetType(), "script", s, true);
            }
        }

        #endregion

        #region CRUD Methods

        protected void PersonsGrid_ItemInserted(object sender, GridInsertedEventArgs e)
        {
            if (e.Exception != null)
            {
                e.ExceptionHandled = true;
                SetMessage("Customer cannot be inserted. Reason: " + e.Exception.Message);
            }
            else
            {
                SetMessage("New customer is inserted!");
                persons = serviceClient.GetPersons();
            }
        }

        protected void PersonsGrid_InsertCommand(object sender, GridCommandEventArgs e)
        {
            if (e.Item is GridEditableItem)
            {
                GridEditableItem editedItem = e.Item as GridEditableItem;
                Hashtable newValues = new Hashtable();
                e.Item.OwnerTableView.ExtractValuesFromItem(newValues, editedItem);

                if (!int.TryParse(newValues["Age"].ToString(), out int age))
                {
                    SetMessage("Age must be an Integer.");
                    return;
                }

                if (!int.TryParse(newValues["PersonTypeId"].ToString(), out int personType))
                {
                    SetMessage("Person Type must be an Integer.");
                    return;
                }

                Person person = new Person
                {
                    Name = newValues["Name"].ToString(),
                    Age = age,
                    PersonTypeId = personType
                };

                serviceClient.CreatePerson(person.Name, person.Age, person.PersonTypeId);
            }
        }

        protected void PersonsGrid_UpdateCommand(object sender, GridCommandEventArgs e)
        {
            if (e.Item is GridEditableItem)
            {
                GridEditableItem editedItem = e.Item as GridEditableItem;
                Hashtable newValues = new Hashtable();
                e.Item.OwnerTableView.ExtractValuesFromItem(newValues, editedItem);

                if (!int.TryParse(newValues["Age"].ToString(), out int age))
                {
                    SetMessage("Age must be an Integer.");
                    return;
                }

                if (!int.TryParse(newValues["PersonTypeId"].ToString(), out int personType))
                {
                    SetMessage("Person Type must be an Integer.");
                    return;
                }

                Person person = new Person
                {
                    Id = int.Parse((e.Item as GridEditableItem).GetDataKeyValue("Id").ToString()),
                    Name = newValues["Name"].ToString(),
                    Age = age,
                    PersonTypeId = personType
                };

                serviceClient.UpdatePerson(person.Id, person.Name, person.Age, person.PersonTypeId);
                persons = serviceClient.GetPersons();
            }
        }

        protected void PersonsGrid_DeleteCommand(object sender, GridCommandEventArgs e)
        {
            int id = int.Parse((e.Item as GridEditableItem).GetDataKeyValue("Id").ToString());            
            serviceClient.DeletePerson(id);
            persons = serviceClient.GetPersons();
        }

        #endregion

        #region Other Methods

        private void SetMessage(string message)
        {
            gridMessage = message;
        }

        private void DisplayMessage(string text)
        {
            PersonsGrid.Controls.Add(new LiteralControl(string.Format("<span style='color:red'>{0}</span>", text)));
        }
       
        #endregion
    }
}