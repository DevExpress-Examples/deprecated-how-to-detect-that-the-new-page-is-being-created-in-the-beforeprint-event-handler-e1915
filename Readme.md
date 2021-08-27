<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128600214/12.2.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1915)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/NewPageStarted/Form1.cs) (VB: [Form1.vb](./VB/NewPageStarted/Form1.vb))
* [Program.cs](./CS/NewPageStarted/Program.cs) (VB: [Program.vb](./VB/NewPageStarted/Program.vb))
* [XtraReport1.cs](./CS/NewPageStarted/XtraReport1.cs) (VB: [XtraReport1.vb](./VB/NewPageStarted/XtraReport1.vb))
<!-- default file list end -->
# How to detect that the new page is being created in the BeforePrint event handler


<p>Note: This example uses undocumented behavior of the XtraReports Suite, so we cannot guarantee that it will work correctly in the XtraReports Suite.</p><p>This example illustrates how to detect that a new page is being created and obtain the current page number within the BeforePrint event handler via the PrintingSystem.Document.PageCount property. Note that in this scenario, you should set the DetailBand.KeepTogether property to true.</p><p>Another (and more universal) approach to this task is demonstrated at <a href="https://www.devexpress.com/Support/Center/p/E1952">E1952</a>.</p><p>See also: <a href="https://www.devexpress.com/Support/Center/p/AS16487">AS16487</a>.</p>

<br/>


