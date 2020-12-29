using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Text.RegularExpressions;

namespace Auer_Find_Replace
{
    public partial class EditActions : Form
    {
        Auer_Find_Replace AFR;
        FormattingAction currentFormattingAction;
        List<ValidatingControl> AllvControls;
        Dictionary<ValidatingControl.CRUDcontrolTypes , Button> Tab_Submit_Pairs;


        public EditActions(Auer_Find_Replace afr){
            AFR = afr;
            InitializeComponent();
            SetupControlValidation();
            ResetForm();
            Show();
        }

        private void SetupControlValidation() {

            Tab_Submit_Pairs = new Dictionary<ValidatingControl.CRUDcontrolTypes, Button>()
            {
                { ValidatingControl.CRUDcontrolTypes.Create,CREATE_button_save},
                { ValidatingControl.CRUDcontrolTypes.Edit,EDIT_button_save}
            };

            AllvControls = new List<ValidatingControl>()
            {
                new ValidatingControl(CREATE_textbox_name,ValidatingControl.CRUDcontrolTypes.Create),
                new ValidatingControl(CREATE_dropdown_type,ValidatingControl.CRUDcontrolTypes.Create),
                new ValidatingControl(CREATE_dropdown_scope,ValidatingControl.CRUDcontrolTypes.Create),
                new ValidatingControl(CREATE_dropdown_file,ValidatingControl.CRUDcontrolTypes.Create),
                new ValidatingControl(CREATE_textbox_description,ValidatingControl.CRUDcontrolTypes.Create),
                new ValidatingControl(EDIT_textbox_name,ValidatingControl.CRUDcontrolTypes.Edit),
                new ValidatingControl(EDIT_type_dropdown,ValidatingControl.CRUDcontrolTypes.Edit),
                new ValidatingControl(EDIT_scope_dropdown,ValidatingControl.CRUDcontrolTypes.Edit),
                new ValidatingControl(EDIT_file_dropdown,ValidatingControl.CRUDcontrolTypes.Edit),
                new ValidatingControl(EDIT_textbox_description,ValidatingControl.CRUDcontrolTypes.Edit),
            };

            //--------Setup Dropdowns---------
            List<string> rS = DataManager.regExpressions.Keys.ToList();
            List<string> aT = DataManager.allActions.Keys.ToList();
            List<string> aF = DataManager.GetJsonDataFiles();
            //---Create---
            CREATE_dropdown_scope.Items.Clear();
            rS.ForEach(i => CREATE_dropdown_scope.Items.Add(i));
            CREATE_dropdown_type.Items.Clear();
            aT.ForEach(i => CREATE_dropdown_type.Items.Add(i));
            CREATE_dropdown_file.Items.Clear();
            aF.ForEach(i => CREATE_dropdown_file.Items.Add(i));
            //---Edit---
            EDIT_scope_dropdown.Items.Clear();
            rS.ForEach(i => EDIT_scope_dropdown.Items.Add(i));
            EDIT_type_dropdown.Items.Clear();
            aT.ForEach(i => EDIT_type_dropdown.Items.Add(i));
            EDIT_file_dropdown.Items.Clear();
            aF.ForEach(i => EDIT_file_dropdown.Items.Add(i));
        }



        private void ResetForm() {

            //Side Panel
            listActions.Items.Clear();
            Auer_Find_Replace.allFormattingActions.ForEach(fa => listActions.Items.Add(fa.myActionData.actionName));

            SetSelectedAction();
            UIInsertActionData();

            //AllvControls.ForEach(c => c.valueChanged());
            Validateforum(ValidatingControl.CRUDcontrolTypes.Create);
            Validateforum(ValidatingControl.CRUDcontrolTypes.Edit);

            tabsCRUD.SelectedTab = tabsCRUD.TabPages[0];
        }

        void SetSelectedAction() {
            if (listActions.Items.Count > 0)
            {
                if (currentFormattingAction == null) { listActions.SelectedItem = listActions.Items[0]; }
                else { listActions.SelectedItem = currentFormattingAction.myActionData.actionName;}
                SetCFA();
            }
            
        }

        private void CreateAction_FormClosing(object sender, FormClosingEventArgs e){AFR.OnWindowRefocus();}

        private void OpenDirectory_button_click(object sender, EventArgs e){DataManager.OpenDataDir();}

        private void listActions_SelectedValueChanged(object sender, EventArgs e){ SetCFA(); }

        private void SetCFA() {
            currentFormattingAction = Auer_Find_Replace.allFormattingActions.First(fa => fa.myActionData.actionName == listActions.SelectedItem.ToString());
            if (currentFormattingAction != null) { UIInsertActionData(); }
        }

        private void UIInsertActionData() {
            DataManager.actionData mad = currentFormattingAction.myActionData;

            READ_labelval_name.Text = mad.actionName;
            READ_labelval_type.Text = mad.actionType;
            READ_labelval_file.Text = mad.fileName;
            READ_labelval_scope.Text = mad.scopeLimitingREGEX;
            READ_labelval_desc.Text = mad.actionDescription;

            EDIT_textbox_name.Text = mad.actionName;
            EDIT_type_dropdown.SelectedItem = mad.actionType;
            EDIT_scope_dropdown.SelectedItem = mad.scopeLimitingREGEX;
            EDIT_file_dropdown.SelectedItem = mad.fileName;
            EDIT_textbox_description.Lines = Regex.Split(mad.actionDescription, "\r\n|\r|\n");

            DELETE_label_name.Text = mad.actionName;
            DELETE_label_desc.Text = mad.actionDescription;
        }

        //==================================================CRUD BUTTON ACTIONS================================================
        private void DELETE_button_Click(object sender, EventArgs e)
        {
            if (currentFormattingAction == null) { return; }
            Auer_Find_Replace.allFormattingActions.Remove(currentFormattingAction);
            DataManager.SerializeActions();
            currentFormattingAction = null;
            ResetForm();
            
        }

        private void EDIT_button_save_Click(object sender, EventArgs e)
        {
            if (currentFormattingAction == null) { return; }
            currentFormattingAction.myActionData.actionName = EDIT_textbox_name.Text;
            currentFormattingAction.myActionData.actionType = EDIT_type_dropdown.SelectedItem.ToString();
            currentFormattingAction.myActionData.scopeLimitingREGEX = EDIT_scope_dropdown.SelectedItem.ToString();
            currentFormattingAction.myActionData.fileName = EDIT_file_dropdown.SelectedItem.ToString();
            currentFormattingAction.myActionData.actionDescription = EDIT_textbox_description.Text;
            DataManager.SerializeActions();
            ResetForm();
        }

        private void CREATE_button_save_Click(object sender, EventArgs e)
        {
            DataManager.actionData mad = new DataManager.actionData();

            mad.actionName = CREATE_textbox_name.Text;
            mad.actionType = CREATE_dropdown_type.SelectedItem.ToString();
            mad.scopeLimitingREGEX = CREATE_dropdown_scope.SelectedItem.ToString();
            mad.fileName = CREATE_dropdown_file.SelectedItem.ToString();
            mad.actionDescription = CREATE_textbox_description.Text;

            currentFormattingAction = new FormattingAction(mad);

            Auer_Find_Replace.allFormattingActions.Add(currentFormattingAction);
            DataManager.SerializeActions();
            ResetForm();
        }

        //-------------------USER INPUT VALUE CHANGED---------------------

        private void ValidateControl(Control con) {
            ValidatingControl VC = AllvControls.First(i => i.myControl == con);
            VC.valueChanged();
            Validateforum(VC.myCrudType);

        }

        //Check all vContols if they are valid
        private void Validateforum(ValidatingControl.CRUDcontrolTypes CCT){ SubmitButtonUpdate(Tab_Submit_Pairs[CCT], AllvControls.Where(c => c.myCrudType == CCT).All(c => c.isValid));}
        
        //Change the status of the submit button on current tab
        private void SubmitButtonUpdate(Button btn , bool state) {
            btn.Enabled = state;
            if (state) { btn.BackColor = Color.White; }
            else { btn.BackColor = Color.PaleVioletRed; }
        }

        //------------------ON INPUT CHANGED-------------------
        private void CREATE_textbox_name_TextChanged(object sender, EventArgs e){ ValidateControl(CREATE_textbox_name); }
        private void CREATE_dropdown_type_SelectedValueChanged(object sender, EventArgs e){ ValidateControl(CREATE_dropdown_type); toolTip1.SetToolTip(CREATE_about_type_label, DataManager.allActions[CREATE_dropdown_type.SelectedItem.ToString()]); }
        private void CREATE_dropdown_scope_SelectedValueChanged(object sender, EventArgs e) { ValidateControl( CREATE_dropdown_scope); }
        private void CREATE_dropdown_file_SelectedValueChanged(object sender, EventArgs e){ ValidateControl(CREATE_dropdown_file); }
        private void CREATE_textbox_description_TextChanged(object sender, EventArgs e){ ValidateControl(CREATE_textbox_description); }
        private void EDIT_textbox_name_TextChanged(object sender, EventArgs e){ ValidateControl(EDIT_textbox_name); }
        private void EDIT_type_dropdown_SelectedValueChanged(object sender, EventArgs e){ ValidateControl(EDIT_type_dropdown); toolTip1.SetToolTip( EDIT_about_type_label, DataManager.allActions[EDIT_type_dropdown.SelectedItem.ToString()]); }
        private void EDIT_scope_dropdown_SelectedValueChanged(object sender, EventArgs e) { ValidateControl(EDIT_scope_dropdown); }
        private void EDIT_file_dropdown_SelectedValueChanged(object sender, EventArgs e){ ValidateControl(EDIT_file_dropdown); }
        private void EDIT_textbox_description_TextChanged(object sender, EventArgs e){ ValidateControl(EDIT_textbox_description); }

        //----------------------ON HOVER-------------------

    }
}
