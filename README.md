# BipGroupList

Revit C# .NET add-in to list all built-in parameter group enum values and labels.

These values are reformatted into a JavaScript dictionary for use in
the [Forge meta property editor](Tohttp://meta-editor.autodesk.link).

It implements a round-trip workflow between Revit and Forge via
the [RvtMetaProp add-in](https://github.com/jeremytammik/rvtmetaprop).

The entire functionality is provided by a four-liner:

<pre>
<span style="color:#2b91af;">Array</span>&nbsp;a&nbsp;=&nbsp;<span style="color:#2b91af;">Enum</span>.GetValues(&nbsp;<span style="color:blue;">typeof</span>(&nbsp;<span style="color:#2b91af;">BuiltInParameterGroup</span>&nbsp;)&nbsp;);
 
<span style="color:#2b91af;">Debug</span>.Print(&nbsp;<span style="color:#a31515;">&quot;{0}&nbsp;built-in&nbsp;parameter&nbsp;groups:&quot;</span>,&nbsp;a.Length&nbsp;);
 
<span style="color:blue;">foreach</span>(&nbsp;<span style="color:#2b91af;">BuiltInParameterGroup</span>&nbsp;bipg&nbsp;<span style="color:blue;">in</span>&nbsp;a&nbsp;)
{
&nbsp;&nbsp;label&nbsp;=&nbsp;<span style="color:#2b91af;">LabelUtils</span>.GetLabelFor(&nbsp;bipg&nbsp;);
&nbsp;&nbsp;<span style="color:#2b91af;">Debug</span>.Print(&nbsp;<span style="color:#a31515;">&quot;{0}&nbsp;:&nbsp;{1}&quot;</span>,&nbsp;bipg.ToString(),&nbsp;label&nbsp;);
}
</pre>

**Question:** Could you reformat the list as follows?

```
{ id: 'PG_GEO_LOCATION', name: 'Geolocation'},
```

It will save me a lot of time typing all these!

**Answer:** Sure. Just run the following regular expression on the list:

- Search for `(.*) : (.*)\n`
- Replace with `{ id: '\1', name: '\2'},\n`


## Author

Jeremy Tammik,
[The Building Coder](http://thebuildingcoder.typepad.com),
[ADN](http://www.autodesk.com/adn)
[Open](http://www.autodesk.com/adnopen),
[Autodesk Inc.](http://www.autodesk.com)


## License

This sample is licensed under the terms of the [MIT License](http://opensource.org/licenses/MIT).
Please see the [LICENSE](LICENSE) file for full details.
