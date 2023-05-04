using System.Collections.Generic;
using System.IO;
using PurpleBank.TemplateModels;
using Scriban;

namespace PurpleBank.CodeGeneration {

 public class ScribanCodeGenerator {

  public static List<string> GenerateCode(List<EntityModel> models) {
   var templateText = File.ReadAllText("Templates/EntityTemplate.sbn");
   var template = Template.Parse(templateText);

   var generatedEntities = new List<string>();

   string result = template.Render(new { models = models });

   foreach (var model in models) {
    var filePath = Path.Combine("GeneratedEntities", $"{model.ClassName}.cs");
    File.WriteAllText(filePath, result);
    generatedEntities.Add(filePath);
   }

   return generatedEntities;
  }
 }
}


/*using Scriban;

namespace PurpleBank.CodeGeneration {

 public class ScribanCodeGenerator {

  public static List<string> GenerateCode(List<System.Type> models) {
   var templateText = File.ReadAllText("Templates/EntityTemplate.sbn");
   var template = Template.Parse(templateText);

   var generatedEntities = new List<string>();
   foreach (var model in models) {
    string result = template.Render(new { entities = models }); 
    //var result = template.Render(new { Model = model }, member => member.Name);
    var filePath = Path.Combine("GeneratedEntities", $"{model.Name}.cs");
    File.WriteAllText(filePath, result);
    generatedEntities.Add(filePath);
   }

   return generatedEntities;
  }
 }
*/

//public class ScribanCodeGenerator {

// public static void GenerateCode(List<System.Type> models) {
//  var templateText = File.ReadAllText("Templates/EntityTemplate.sbn");
//  var template = Template.Parse(templateText);

//  foreach (var model in models) {
//   var result = template.Render(new { Model = model }, member => member.Name);
//   File.WriteAllText(Path.Combine("GeneratedEntities", $"{model.Name}.cs"), result);
//  }
// }
//}




//using Scriban;
//using System.Collections.Generic;
//using System.IO;
//using PurpleBank.Models;

//namespace PurpleBank.CodeGeneration {
// public class ScribanCodeGenerator {
//  public static void GenerateCode(List<Type> models) {
//   var templateText = File.ReadAllText("Templates/EntityTemplate.sbn");
//   var template = Template.Parse(templateText);

//   foreach (var model in models) {
//    var result = template.Render(new { Model = model }, member => member.Name);
//    File.WriteAllText(Path.Combine("GeneratedEntities", $"{model.Name}.cs"), result);
//   }
//  }
// }
//}

//using Scriban;
//using System.IO;
//using System.Collections.Generic;
//using PurpleBank.TemplateModels;

//public class ScribanCodeGenerator {
// public static Dictionary<string, string> GenerateCode(List<EntityModel> models) {
//  var templateText = File.ReadAllText("Templates/EntityTemplate.sbn");

//  //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
//  //string templatePath = Path.Combine(baseDirectory, "Templates", "EntityTemplate.sbn");
//  //var templateText = File.ReadAllText(templatePath);
//  var template = Template.Parse(templateText);

//  var generatedCode = new Dictionary<string, string>();

//  foreach (var model in models) {
//   var result = template.Render(new { Model = model }, member => member.Name.ToLowerInvariant());
//   generatedCode.Add(model.ClassName, result);
//  }

//  return generatedCode;
// }
//}