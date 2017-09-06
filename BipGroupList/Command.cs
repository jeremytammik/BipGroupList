#region Namespaces
using System;
using System.Collections.Generic;
using System.Diagnostics;
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
#endregion

namespace BipGroupList
{
  [Transaction( TransactionMode.Manual )]
  public class Command : IExternalCommand
  {
    public Result Execute(
      ExternalCommandData commandData,
      ref string message,
      ElementSet elements )
    {
      string label;

      Array a = Enum.GetValues( typeof( BuiltInParameterGroup ) );

      Debug.Print( "{0} built-in parameter groups:", a.Length );

      //for( BuiltInParameterGroup bipg = BuiltInParameterGroup.INVALID;
      //  bipg <= BuiltInParameterGroup.PG_VISIBILITY; ++bipg )

      foreach( BuiltInParameterGroup bipg in a )
      {
        label = LabelUtils.GetLabelFor( bipg );
        Debug.Print( "{0} : {1}", bipg.ToString(), label );
      }
      return Result.Succeeded;
    }
  }
}
