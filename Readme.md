<!-- default file list -->
*Files to look at*:

* [FilterCriteriaChangedHelper.cs](./CS/DXSLSample/FilterCriteriaChangedHelper.cs) (VB: [FilterCriteriaChangedHelper.vb](./VB/DXSLSample/FilterCriteriaChangedHelper.vb))
* **[MainPage.xaml](./CS/DXSLSample/MainPage.xaml) (VB: [MainPage.xaml](./VB/DXSLSample/MainPage.xaml))**
* [MainPage.xaml.cs](./CS/DXSLSample/MainPage.xaml.cs) (VB: [MainPage.xaml](./VB/DXSLSample/MainPage.xaml))
* [View.xaml](./CS/DXSLSample/View.xaml) (VB: [View.xaml](./VB/DXSLSample/View.xaml))
* [View.xaml.cs](./CS/DXSLSample/View.xaml.cs) (VB: [View.xaml](./VB/DXSLSample/View.xaml))
<!-- default file list end -->
# How to track filter criteria changes in the unbound FilterControl


<p>By default, the FilterControl's <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfEditorsFilteringFilterControl_FilterCriteriatopic"><u>FilterCriteria</u></a> property is updated only after the ApplyFilter method has been called, while the <a href="http://documentation.devexpress.com/#WPF/DevExpressXpfEditorsFilteringFilterControl_ActualFilterCriteriatopic"><u>ActualFilterCriteria</u></a> property does not send notifications when the user changes the filter.</p>
<p>This sample project shows how to force an unbound FilterControl to update its FilterCriteria property and bind another control or a view model to this property.</p>
<p> <br />To learn more on how to implement similar functionality in <strong>WPF,</strong> refer to the <a href="https://www.devexpress.com/Support/Center/p/E3766">E3766</a> example.</p>

<br/>


