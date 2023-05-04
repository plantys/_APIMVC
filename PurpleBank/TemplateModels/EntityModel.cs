using System;
using System.Collections.Generic;




 namespace PurpleBank.TemplateModels {
  public class EntityModel {
   public string Namespace { get; set; }
   public string ClassName { get; set; }
   public Type EntityType { get; set; }
   public List<PropertyModel> Properties { get; set; }
  }
 }




 //public class EntityModel {
 // public string Namespace { get; set; }
 // public string ClassName { get; set; }
 // public List<PropertyModel> Properties { get; set; }
 //}

 //public class PropertyModel {
 // public string Type { get; set; }
 // public string Name { get; set; }
 //}


