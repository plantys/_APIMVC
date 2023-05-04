using PurpleBank.Controllers;
using PurpleBank.Models;
using PurpleBank.TemplateModels;
using System;
using System.Collections.Generic;
using PurpleBank.Models;
using System.Reflection;
using SystemType = System.Type;
using Microsoft.AspNetCore.Mvc.ApplicationModels;

namespace PurpleBank.CodeGeneration {

 public class ModelBuilder {
  public static List<EntityModel> BuildModels() {
   var models = new List<EntityModel>();

   // Use reflection to load all types in the PurpleBank.Models namespace
   Assembly assembly = typeof(PurpleBank.Models.BankingAccountV2).Assembly;
   SystemType[] types = assembly.GetTypes();

   // Loop through the types and build an EntityModel for each one
   foreach (SystemType type in types) {
    if (type.Namespace == "PurpleBank.Models") {
     var entityModel = BuildEntityModel(type);
     models.Add(entityModel);
    }
   }

   return models;
  }

  private static EntityModel BuildEntityModel(SystemType entityType) {
   var entityModel = new EntityModel {
    Namespace = entityType.Namespace,
    ClassName = entityType.Name,
    EntityType = entityType,
    Properties = new List<PurpleBank.TemplateModels.PropertyModel>()
   };

   PropertyInfo[] properties = entityType.GetProperties();

   // Loop through the properties and build a PropertyModel for each one
   foreach (PropertyInfo property in properties) {
    var propertyModel = new PurpleBank.TemplateModels.PropertyModel {
     Type = property.PropertyType.Name,
     Name = property.Name
    };

    entityModel.Properties.Add(propertyModel);
   }

   return entityModel;
  }
 }
}
