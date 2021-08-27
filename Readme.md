<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128603877/16.2.3%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T453603)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/RegisterCustomFieldEditor/Form1.cs) (VB: [Form1.vb](./VB/RegisterCustomFieldEditor/Form1.vb))
<!-- default file list end -->
# How to use custom controls for editing report content in Print Preview


This example demonstrates how to create and register custom editors to be used for <a href="https://documentation.devexpress.com/#XtraReports/CustomDocument117343">editing the content of report controls in Print Preview</a>. In particular, it shows how to create a combo box editor, a date editor with a custom format and a standard text editor with a phone number mask.<br><br>The following image illustrates a custom combo box editor.<br><br><img src="https://raw.githubusercontent.com/DevExpress-Examples/how-to-use-custom-controls-for-editing-report-content-in-print-preview-t453603/16.2.3+/media/c60456ff-c06c-11e6-80bf-00155d62480c.png"><br><br>To implement a custom editor, create a new instance of an appropriate <a href="https://documentation.devexpress.com/#WindowsForms/clsDevExpressXtraEditorsRepositoryRepositoryItemtopic">RepositoryItem</a> descendant and specify its settings as required. Then, register this editor using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingPreviewEditingFieldExtensionsWin_RegisterEditortopic">EditingFieldExtensionsWin.RegisterEditor</a><strong> </strong>method. Enable editing of a control's content by setting the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUIEditOptions_Enabledtopic">EditOptions.Enabled</a><strong> </strong>property to <strong>true </strong>and assign the created editor to the <a href="https://documentation.devexpress.com/#XtraReports/DevExpressXtraReportsUITextEditOptions_EditorNametopic">EditorName</a><strong> </strong>property. <br><br>To register the standard text editor with a custom mask, use the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPrintingPreviewEditingFieldExtensionsWin_RegisterMaskEditortopic">EditingFieldExtensionsWin.RegisterMaskEditor</a><strong> </strong>method.

<br/>


