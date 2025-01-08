using System;
using System.Collections.Generic;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Bimser.CSP.FormControls.Base;
using Bimser.CSP.FormControls.Common;
using Bimser.CSP.FormControls.Controls;
using Bimser.CSP.FormControls.RuleManager;
using Bimser.CSP.FormControls.Enums;
using Bimser.Framework.Entities;
using Bimser.Framework.Monitoring;
using Newtonsoft.Json;
using MasrafBeyanFormu.Entities;

namespace MasrafBeyanFormu.Forms {

    public partial class MasrafDetayFormu : Form<E_MasrafBeyanFormu_MasrafDetayFormuEntity> {

        // properties
        ComboBox MasrafTipi { get; set; }
DateTimePicker DateTimePicker1 { get; set; }
NumberBox KisiSayisi { get; set; }
Section Section1 { get; set; }
TextArea Aciklama { get; set; }
RelatedDocuments Documents { get; set; }
Column Column1 { get; set; }
NumberBox MasrafTutari { get; set; }


        // constructor
        public MasrafDetayFormu(FormHttpParameters httpParameters, IContext context)
 : base(httpParameters, context)
        {
        }

        // initialize members
        public override void InitMembers()
        {
            
MasrafTipi = new ComboBox {
ControlId = "a20c6b55-8827-bc2f-49db-9ec76a2e4557",
Name = "MasrafTipi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Masraf Tipi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "SL.MasrafTipi",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
DataSource = new DataSource {
Name = "MasrafTipleriniGetir",
ValueMember = "DGID",
DisplayMember = new List<string>{
"MasrafTipi",
},
DisplayFormat = "{{ MasrafTipi }}",
Culture = "",
CultureMember = "",
MultiLanguagePath = "",
RunAtServer = false,
Field = "",
Parameters = new List<DataSourceParameter>{
},
MultiLanguageLoadOptions = new List<MultiLanguageLoadOptions>{
},
ConnectionType = DataSourceConnectionType.MSSQL,
DefaultValue = null,
UseClientCachedData = true,
EnableMultiLanguageDisplayMember = false,
DisplayMemberML = new Dictionary<string, DisplayMemberML> {
},
},
DataSourceType = DataSourceType.Dynamic,
ValueType = PrimitiveType.String,
DateValueFormat = "",
DecimalValuePrecision = 0,
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
AllowClear = true,
ShowSearch = false,
SizeType = null,
IconMatchers = new List<IconMatchers>{
},
IconExpr = "",
HideForceRefreshButton = false,
};

Controls.Add(MasrafTipi);
MasrafTipi.Items = new ListItemCollection();

BaseComponent default_masraftipiComponent = new BaseComponent {
Id = "MasrafTipi",
Type = "ComboBox",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = MasrafTipi,
ViewProperties = "",
};

AddToViewItems("default", default_masraftipiComponent);

DateTimePicker1 = new DateTimePicker {
ControlId = "daee5ac7-9eca-5c47-1ac6-54bd6cebfbd1",
Name = "DateTimePicker1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Fiş Tarihi" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "DateTimePicker1",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
Format = "YYYY-MM-DD HH:mm",
SetTodayAsDefault = false,
ShowTime = true,
ShowToday = false,
AllowClear = true,
DisableBefore = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
DisableAfter = new DisableDate(){
Enabled = false,
Years = 0,
Months = 0,
Days = 0,
},
SizeType = null,
};

Controls.Add(DateTimePicker1);

BaseComponent default_datetimepicker1Component = new BaseComponent {
Id = "DateTimePicker1",
Type = "DateTimePicker",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = DateTimePicker1,
ViewProperties = "",
};

AddToViewItems("default", default_datetimepicker1Component);

KisiSayisi = new NumberBox {
ControlId = "38d41870-e568-ed73-a15d-def9f6108164",
Name = "KisiSayisi",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Kişi Sayısı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "KisiSayisi",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = 1M,
Max = 10M,
Step = 1M,
Precision = 0,
UseThousandSeparator = false,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(KisiSayisi);

BaseComponent default_kisisayisiComponent = new BaseComponent {
Id = "KisiSayisi",
Type = "NumberBox",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = KisiSayisi,
ViewProperties = "",
};

AddToViewItems("default", default_kisisayisiComponent);

Section1 = new Section {
ControlId = "22dc8b13-45e9-49e5-9436-c466d646d417",
Name = "Section1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_section1Component = new BaseComponent {
Id = "Section1",
Type = "Section",
ParentId = "MasrafDetayFormu",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Column1",
},
Properties = Section1,
ViewProperties = "",
};

AddToViewItems("default", default_section1Component);
Controls.Add(Section1);

Aciklama = new TextArea {
ControlId = "f2725e1e-517f-6614-fb94-86b1e3490c93",
Name = "Aciklama",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Açıklama" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "ML.Aciklama",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Left,
MaxLength = 250,
IsSecretData = false,
EnableMultiLanguageText = false,
ShowCharacterCounter = true,
MultiLanguageText = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Rows = 3
};

Controls.Add(Aciklama);

BaseComponent default_aciklamaComponent = new BaseComponent {
Id = "Aciklama",
Type = "TextArea",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Aciklama,
ViewProperties = "",
};

AddToViewItems("default", default_aciklamaComponent);

Documents = new RelatedDocuments {
ControlId = "dbb10474-ac03-e21f-0472-b2e7a6ecb61d",
Name = "Documents",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Dokümanlar" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Top,
Size = new Size {
Width = 120,
Height = 34
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
},
EntityPath = "RD.Documents",
ReadOnly = false,
DefaultReadOnly = false,
Required = false,
Indexable = false,
Categories = new List<RelatedDocumentCategory> {
new RelatedDocumentCategory {
Id = 0,
CategoryId = "595fb9f7-8377-90f9-cdcd-b42fb2bc8bf8",
Name = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
Description = new Dictionary<string, string> {
{ "tr-TR", "Varsayılan" },
},
MinFilesCount = 0,
MaxFilesCount = null,
MaxFileSize = null,
AllowedFileExtensions = new List<string> {
},
Enabled = true,
Path = "",
TargetId = ""
},
},
Files = new List<RelatedDocumentFile> {
},
AddingMode = RelatedDocumentsAddingMode.All,
ViewType = RelatedDocumentsViewType.Card,
AddNewEnabled = true,
DeleteEnabled = true,
Viewable = true,
CreateEnabled = false,
Path = "denemedepo1/yktest",
ShowCategoryDescription = false,
ShowFileDescription = false,
FileDescriptionIsRequired = false,
ShowContentForImageFiles = true,
ShowCreateDate = true,
ShowCreator = false,
ShowFileExtension = true,
ShowPath = true,
EnabledOCR = false,
TargetId = "124139",
AdvancedEdit = false,
};

Controls.Add(Documents);

BaseComponent default_documentsComponent = new BaseComponent {
Id = "Documents",
Type = "RelatedDocuments",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = Documents,
ViewProperties = "",
};

AddToViewItems("default", default_documentsComponent);

Column1 = new Column {
ControlId = "533f9b80-9669-4235-9755-d19f19baf4f5",
Name = "Column1",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
};


BaseComponent default_column1Component = new BaseComponent {
Id = "Column1",
Type = "Column",
ParentId = "Section1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"MasrafTipi",
"DateTimePicker1",
"KisiSayisi",
"MasrafTutari",
"Aciklama",
"Documents",
},
Properties = Column1,
ViewProperties = "",
};

AddToViewItems("default", default_column1Component);
Controls.Add(Column1);

MasrafTutari = new NumberBox {
ControlId = "c65c45ba-dc0c-d0b7-8a72-1d204333342a",
Name = "MasrafTutari",
ServerEvents = new List<EventItem> {
},
ClientEvents = new List<EventItem> {
},
Visible = true,
ClientVisible = true,
Enabled = true,
DefaultEnabled = true,
ClientEnabled = true,
DefaultClientEnabled = true,
Loading = false,
CustomClassName = "",
ContextMenuKey = "",
ContextMenuTarget = ContextMenuTarget.None,
ContextMenuColumnKey = "",
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
ContainerStyle = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
},
Title = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "Masraf Tutarı" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = true
},
EntityPath = "MasrafTutari",
ReadOnly = false,
DefaultReadOnly = false,
Required = true,
Indexable = false,
TabIndex = 0,
Value = null,
Text = "",
Placeholder = new MultiLanguageText(){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
TextAlign = HorizontalAlign.Right,
Min = 1M,
Max = 99999999999999M,
Step = 1M,
Precision = 0,
UseThousandSeparator = true,
OnlyNumber = false,
SizeType = null,
};

Controls.Add(MasrafTutari);

BaseComponent default_masraftutariComponent = new BaseComponent {
Id = "MasrafTutari",
Type = "NumberBox",
ParentId = "Column1",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
},
Properties = MasrafTutari,
ViewProperties = "",
};

AddToViewItems("default", default_masraftutariComponent);

AddViews("default");
ClientVisible = true;
ProjectName = "MasrafBeyanFormu";
ProjectId = "20e14aec-b3c0-4f19-adad-e061995bf939";
EntityPath = "";
ActiveView = "default";
Version = 19;
ReadOnly = false;
DefaultReadOnly = false;
Text = new Dictionary<string, string> {
{ "tr-TR", "MasrafDetayFormu" },
{ "en-US", "MasrafDetayFormu" },
{ "ru-RU", "MasrafDetayFormu" },
{ "az-Latn-AZ", "MasrafDetayFormu" },
};
Name = "MasrafDetayFormu";
FormId = "af31dded-e714-4606-b707-a4f9d455957a";
FormType = FormType.Standard;
ServerEvents = new List<EventItem> {
};
ClientEvents = new List<EventItem> {
new EventItem {
Name = "OnBeforeSave",
MethodName = "MasrafDetayFormu_OnBeforeSave",
Async = null
},
new EventItem {
Name = "OnAfterSave",
MethodName = "MasrafDetayFormu_OnAfterSave",
Async = null
},
};
Statuses = new List<DocumentStatus> {
};
IdentityFormat = "<u>";
IdentityFormatId = 0;
PrintingEnabled = false;
PrintView = "default";
CopyPasteEnabled = false;
VersioningEnabled = false;
CanSaveAsDraft = false;
PanelSize = 2;
Style = new Style {
Padding = "10px 20px 10px 20px",
BackgroundColor = "rgba(255, 255, 255, 0)",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
};
PublicFields = new List<FormPublicField> {
};
ToolbarButtons = new List<ToolbarButton> {
new ToolbarButton {
Key = "toolbarSaveButton",
Name = "Kaydet",
Icon = "save",
Enabled = true,
DefaultEnabled = true,
Validate = true,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Kaydet" },
{ "en-US", "Save" },
{ "ru-RU", "Сохранять" },
{ "az-Latn-AZ", "Yadda Saxla" },
},
View = "",
IsServerPrint = false,
},
new ToolbarButton {
Key = "toolbarSaveAsButton",
Name = "Farklı Kaydet",
Icon = "save-as",
Enabled = false,
DefaultEnabled = false,
Validate = false,
Caption = new Dictionary<string, string> {
{ "tr-TR", "Farklı Kaydet" },
{ "en-US", "Save As" },
{ "ru-RU", "Сохранить как" },
{ "az-Latn-AZ", "Fərqli Saxla" },
},
View = "",
IsServerPrint = false,
},
};
Variables = new Dictionary<string, object> {
};
Rules = new Dictionary<string, Rule> {
{
"FormRequiredFields",
new Rule {
Id = "FormRequiredFields",
Name = "FormRequiredFields",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "FormRequiredFields_Statement_default_DateTimePicker1",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_DateTimePicker1",
Name = "DateTimePicker1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Fiş Tarihi: Gerekli alan"
},
{
"en-US",
"Fiş Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DateTimePicker1",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_DateTimePicker1",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_DateTimePicker1_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "DateTimePicker1",
PropertyName = "value",
Type = FieldValueType.Date,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_DateTimePicker1",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafDetayFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_KisiSayisi",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_KisiSayisi",
Name = "KisiSayisi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Kişi Sayısı: Gerekli alan"
},
{
"en-US",
"Kişi Sayısı: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"KisiSayisi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_KisiSayisi",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_KisiSayisi_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "KisiSayisi",
PropertyName = "value",
Type = FieldValueType.Number,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_KisiSayisi",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafDetayFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_MasrafTutari",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_MasrafTutari",
Name = "MasrafTutari_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Masraf Tutarı: Gerekli alan"
},
{
"en-US",
"Masraf Tutarı: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MasrafTutari",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_MasrafTutari",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_MasrafTutari_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafTutari",
PropertyName = "value",
Type = FieldValueType.Number,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_MasrafTutari",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafDetayFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_Aciklama",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_Aciklama",
Name = "Aciklama_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Açıklama: Gerekli alan"
},
{
"en-US",
"Açıklama: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Aciklama",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_Aciklama",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_Aciklama_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "Aciklama",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_Aciklama",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafDetayFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new IfStatement {
Id = "FormRequiredFields_Statement_default_MasrafTipi",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_MasrafTipi",
Name = "MasrafTipi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Masraf Tipi: Gerekli alan"
},
{
"en-US",
"Masraf Tipi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MasrafTipi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "FormRequiredFields_ConditionGroup_default_MasrafTipi",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "FormRequiredFields_Condition_default_MasrafTipi_value",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafTipi",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
new ValueEntryCondition {
Id = "FormRequiredFields_View_Condition_default_MasrafTipi",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafDetayFormu",
PropertyName = "activeView",
Type = FieldValueType.String,
},
Operation = OperationType.Equals,
Value = "default"
},
},
Children = new List<BaseConditionGroup> {
},
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_DateTimePicker1",
Name = "DateTimePicker1_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Fiş Tarihi: Gerekli alan"
},
{
"en-US",
"Fiş Tarihi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DateTimePicker1",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_KisiSayisi",
Name = "KisiSayisi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Kişi Sayısı: Gerekli alan"
},
{
"en-US",
"Kişi Sayısı: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"KisiSayisi",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_MasrafTutari",
Name = "MasrafTutari_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Masraf Tutarı: Gerekli alan"
},
{
"en-US",
"Masraf Tutarı: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MasrafTutari",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_Aciklama",
Name = "Aciklama_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Açıklama: Gerekli alan"
},
{
"en-US",
"Açıklama: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"Aciklama",
},
},
new ValidationFailureAction {
Id = "FormRequiredToasterMessage_default_MasrafTipi",
Name = "MasrafTipi_Required",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"Masraf Tipi: Gerekli alan"
},
{
"en-US",
"Masraf Tipi: Required field"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MasrafTipi",
},
},
},
TriggerEvents = new List<string> {
"MasrafDetayFormu.client.OnBeforeSave",
"MasrafDetayFormu.server.OnBeforeSave",
"MasrafDetayFormu.client.OnToolbarButtonClicked",
"MasrafDetayFormu.server.OnToolbarButtonClicked",
}
}
},
{
"5ef2b8da-f98a-4613-a2bd-efe60cc1dbdc",
new Rule {
Id = "5ef2b8da-f98a-4613-a2bd-efe60cc1dbdc",
Name = "MasrafTipi_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "c6463509-3f5f-4aed-bf39-be19578c4922",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "be92f452-8854-45fc-a357-aec547890ee1",
Name = "MasrafTipi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"MasrafTipi alanı zorunludur"
},
{
"en-US",
"MasrafTipi is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MasrafTipi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "82aadebe-5d49-43b1-bdfe-0997c1a45cb7",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "b58d474d-8a46-44ef-8c3f-c52326b5d3fa",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafTipi",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "526d8143-7cc9-4b14-a281-1e94fa8ce6af",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "be92f452-8854-45fc-a357-aec547890ee1",
Name = "MasrafTipi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"MasrafTipi alanı zorunludur"
},
{
"en-US",
"MasrafTipi is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"MasrafDetayFormu.server.OnBeforeSave",
}
}
},
{
"b47c3498-fb75-4bdc-bcac-a13d4f216637",
new Rule {
Id = "b47c3498-fb75-4bdc-bcac-a13d4f216637",
Name = "DateTimePicker1_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "b4d4dfba-e13a-4ccd-8936-2e2387f110ba",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "fbb4c313-0cd6-4c27-a1d1-7fdef210696e",
Name = "DateTimePicker1_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"DateTimePicker1 alanı zorunludur"
},
{
"en-US",
"DateTimePicker1 is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"DateTimePicker1",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "0b41201f-3296-4874-8fd2-8e167e1f4684",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "d8e14b3b-5409-40b7-84fe-92c37b87157f",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "DateTimePicker1",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "80379a60-353c-4567-bdb1-4a7d8603b1b7",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "fbb4c313-0cd6-4c27-a1d1-7fdef210696e",
Name = "DateTimePicker1_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"DateTimePicker1 alanı zorunludur"
},
{
"en-US",
"DateTimePicker1 is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"MasrafDetayFormu.server.OnBeforeSave",
}
}
},
{
"f7dffdc6-9038-4bb2-9ead-7829905570ca",
new Rule {
Id = "f7dffdc6-9038-4bb2-9ead-7829905570ca",
Name = "KisiSayisi_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "e2cb658c-5ea0-489e-b4e5-af1e131bd6e6",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "6898564e-c6d5-400b-a4a4-e8fa412e9ee5",
Name = "KisiSayisi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"KisiSayisi alanı zorunludur"
},
{
"en-US",
"KisiSayisi is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"KisiSayisi",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "c0308c8b-2d21-4fda-a900-058744ed0e2f",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "279820d8-99f2-4fed-b2eb-0671e4f93451",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "KisiSayisi",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "9188d127-8682-40d5-9ad5-896da648e1d1",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "6898564e-c6d5-400b-a4a4-e8fa412e9ee5",
Name = "KisiSayisi_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"KisiSayisi alanı zorunludur"
},
{
"en-US",
"KisiSayisi is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"MasrafDetayFormu.server.OnBeforeSave",
}
}
},
{
"98425db2-4c23-4eeb-bc94-63c5708236d4",
new Rule {
Id = "98425db2-4c23-4eeb-bc94-63c5708236d4",
Name = "MasrafTutari_RequirementRule",
Enabled = true,
OrderNo = 0,
Statements = new List<BaseStatement> {
new IfStatement {
Id = "e02ac7e1-744e-4c15-810a-97a91ffaae6a",
TypeName = StatementType.IfStatement,
Enabled = true,
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "7ea0a6b6-49f2-447b-b6e9-facbc84503d0",
Name = "MasrafTutari_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Warning,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"MasrafTutari alanı zorunludur"
},
{
"en-US",
"MasrafTutari is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
"MasrafTutari",
},
},
},
ConditionGroup = new AndConditionGroup {
Id = "11dcd6bd-af60-4ac8-b88d-71dbf7a849d8",
TypeName = ConjunctionType.AndConditionGroup,
Conditions = new List<BaseCondition> {
new ValueEntryCondition {
Id = "8579f4cd-f834-40a1-bbc6-a5df5bd3073d",
TypeName = ConditionType.ValueEntryCondition,
Field = new ConditionField {
Name = "MasrafTutari",
PropertyName = "value",
Type = FieldValueType.String,
},
Operation = OperationType.Null,
Value = null
},
},
Children = new List<BaseConditionGroup> {
},
},
},
new ElseStatement {
Id = "2309d6d8-83eb-45ee-9707-a28918bf18bd",
TypeName = StatementType.ElseStatement,
Enabled = true,
Actions = new List<BaseAction> {
},
},
},
Actions = new List<BaseAction> {
new ValidationFailureAction {
Id = "7ea0a6b6-49f2-447b-b6e9-facbc84503d0",
Name = "MasrafTutari_RequirementAction",
Enabled = true,
TypeName = ActionType.ValidationFailureAction,
AlertType = AlertType.Error,
DialogType = DialogType.Toaster,
Messages = new Dictionary<string, string> {
{
"tr-TR",
"MasrafTutari alanı zorunludur"
},
{
"en-US",
"MasrafTutari is required"
},
},
ApprovalActions = new List<BaseAction> {
},
RejectionActions = new List<BaseAction> {
},
HighlightList = new List<string> {
},
},
},
TriggerEvents = new List<string> {
"MasrafDetayFormu.server.OnBeforeSave",
}
}
},
};
CheckInCheckOut = new CheckInCheckOutOptions {
Enabled = false,
Timeout = 10,
AdditionalTime = 5,
};
SizeType = SizeType.Middle;
PaddingType = SizeType.Middle;
Caption = new ControlCaption {
Text = new MultiLanguageText(new Dictionary<string, string> {{ "tr-TR", "MasrafDetayFormu" },{ "en-US", "MasrafDetayFormu" },{ "ru-RU", "MasrafDetayFormu" },{ "az-Latn-AZ", "MasrafDetayFormu" },}){
EnableMultiLanguageText = true,
UserCulture = "",
DefaultCulture = "",
},
Position = Position.Left,
Size = new Size {
Width = 120,
Height = null
},
Font = new Font {
Family = "Source Sans Pro, sans-serif",
Size = "13",
Color = "#25241f",
Bold = false,
Italic = false,
Underline = false,
Strikethrough = false
},
Visible = true,
Ellipsis = true,
HorizontalAlign = HorizontalAlign.Left,
VerticalAlign = VerticalAlign.Middle,
MarkSettings = new MarkSettings {
Char = "",
Position = MarkPosition.AtFirst,
Style = new Style {
Padding = "",
BackgroundColor = "",
BackgroundImage = "",
BackgroundImageLayout = BackgroundImageLayout.None,
Height = null
}
},
ShowColon = false
};

Controls.Add(this);

BaseComponent default_masrafdetayformuComponent = new BaseComponent {
Id = "MasrafDetayFormu",
Type = "Form",
ParentId = "",
DesignerProps = new DesignerProps {
AllowAutoClear = true,
Layout = new ContainerLayout {
Width = null,
Visible = true,
ClientVisible = true,
Padding = "",
},
},
Items = new List<string> {
"Section1",
},
Properties = this,
ViewProperties = "",
};

AddToViewItems("default", default_masrafdetayformuComponent);

        }

        // initialize user events
        public override void InitUserEvents()
        {
            







        }
    }
}