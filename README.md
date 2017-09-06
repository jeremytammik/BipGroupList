# BipGroupList

Revit C# .NET add-in to list all built-in parameter group enum values and labels.

A four-liner:

<pre>
<span style="color:#2b91af;">Array</span>&nbsp;a&nbsp;=&nbsp;<span style="color:#2b91af;">Enum</span>.GetValues(&nbsp;<span style="color:blue;">typeof</span>(&nbsp;<span style="color:#2b91af;">BuiltInParameterGroup</span>&nbsp;)&nbsp;);
 
<span style="color:#2b91af;">Debug</span>.Print(&nbsp;<span style="color:#a31515;">&quot;{0}&nbsp;built-in&nbsp;parameter&nbsp;groups:&quot;</span>,&nbsp;a.Length&nbsp;);
 
<span style="color:blue;">foreach</span>(&nbsp;<span style="color:#2b91af;">BuiltInParameterGroup</span>&nbsp;bipg&nbsp;<span style="color:blue;">in</span>&nbsp;a&nbsp;)
{
&nbsp;&nbsp;label&nbsp;=&nbsp;<span style="color:#2b91af;">LabelUtils</span>.GetLabelFor(&nbsp;bipg&nbsp;);
&nbsp;&nbsp;<span style="color:#2b91af;">Debug</span>.Print(&nbsp;<span style="color:#a31515;">&quot;{0}&nbsp;:&nbsp;{1}&quot;</span>,&nbsp;bipg.ToString(),&nbsp;label&nbsp;);
}
</pre>

## Author

Jeremy Tammik,
[The Building Coder](http://thebuildingcoder.typepad.com),
[ADN](http://www.autodesk.com/adn)
[Open](http://www.autodesk.com/adnopen),
[Autodesk Inc.](http://www.autodesk.com)


## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT).
Please see the [LICENSE](LICENSE) file for full details.
