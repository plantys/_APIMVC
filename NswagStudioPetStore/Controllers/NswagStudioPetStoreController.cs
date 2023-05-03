#nullable enable
#pragma warning disable 108 
#pragma warning disable 114 
#pragma warning disable 472 
#pragma warning disable 1573 
#pragma warning disable 1591 
#pragma warning disable 8073 
#pragma warning disable 3016 
#pragma warning disable 8603 
namespace PetStore {
 using Microsoft.AspNetCore.Mvc;
 using System = global::System;
 [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public interface IController {
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> AddPetAsync(long cookieParam, string accept_Language, object? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdatePetAsync(long cookieParam, string accept_Language, object? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Pet>> GetPetByIdAsync(long petId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdatePetWithFormAsync(long petId, Body? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeletePetAsync(long petId, string? api_key = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ApiResponse>> UploadFileAsync(long petId, Microsoft.AspNetCore.Http.IFormFile body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Pet>>> FindPetsByStatusAsync(System.Collections.Generic.IEnumerable<Anonymous> status, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  [System.Obsolete]
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Pet>>> FindPetsByTagsAsync(System.Collections.Generic.IEnumerable<string> tags, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IDictionary<string, int>>> GetInventoryAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Order>> PlaceOrderAsync(Order body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Order>> GetOrderByIdAsync(long orderId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteOrderAsync(string orderId, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Response>> SubscribeAsync(Body2? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CreateUserAsync(User body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<User>> GetUserByNameAsync(string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateUserAsync(string username, User body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteUserAsync(string username, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CreateUsersWithArrayInputAsync(object? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CreateUsersWithListInputAsync(object? body = null, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<string>> LoginUserAsync(string username, string password, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> LogoutUserAsync(System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
 }
 [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 [Microsoft.AspNetCore.Mvc.Route("petstore.swagger.io/v2")]
 public partial class Controller : ControllerBase {
  private IController _implementation;
  public Controller(IController implementation) {
   _implementation = implementation;
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("pet")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> AddPet([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] long cookieParam, System.Threading.CancellationToken cancellationToken, [Microsoft.AspNetCore.Mvc.FromBody] string? body = null, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "Accept-Language")] string? accept_Language = null) {
   return _implementation.AddPetAsync(cookieParam, body, accept_Language ?? "en-AU", cancellationToken);
  }

  [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("pet")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdatePet([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] long cookieParam, [Microsoft.AspNetCore.Mvc.FromBody] string? body, System.Threading.CancellationToken cancellationToken, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "Accept-Language")] string? accept_Language = null) {
   return _implementation.UpdatePetAsync(cookieParam, body, accept_Language ?? "en-AU", cancellationToken);
  }


  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pet/{petId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Pet>> GetPetById([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] long petId, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetPetByIdAsync(petId, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("pet/{petId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdatePetWithForm(
    [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] long petId,
    System.Threading.CancellationToken cancellationToken,
    [Microsoft.AspNetCore.Mvc.FromBody] Body? body = null) {
   return _implementation.UpdatePetWithFormAsync(petId, body, cancellationToken);
  }

  [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("pet/{petId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeletePet([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] long petId, System.Threading.CancellationToken cancellationToken, [Microsoft.AspNetCore.Mvc.FromHeader] string? api_key = null) {
   return _implementation.DeletePetAsync(petId, api_key, cancellationToken);
  }

  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("pet/{petId}/uploadImage")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ApiResponse>> UploadFile([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] long petId, System.Threading.CancellationToken cancellationToken, Microsoft.AspNetCore.Http.IFormFile body = null) {
   return _implementation.UploadFileAsync(petId, body, cancellationToken);
  }

  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pet/findByStatus")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Pet>>> FindPetsByStatus([Microsoft.AspNetCore.Mvc.FromQuery][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Collections.Generic.IEnumerable<Anonymous> status, System.Threading.CancellationToken cancellationToken) {
   return _implementation.FindPetsByStatusAsync(status, cancellationToken);
  }
  [System.Obsolete]
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("pet/findByTags")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.ICollection<Pet>>> FindPetsByTags([Microsoft.AspNetCore.Mvc.FromQuery][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] System.Collections.Generic.IEnumerable<string> tags, System.Threading.CancellationToken cancellationToken) {
   return _implementation.FindPetsByTagsAsync(tags, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("store/inventory")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<System.Collections.Generic.IDictionary<string, int>>> GetInventory(System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetInventoryAsync(cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("store/order")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Order>> PlaceOrder([Microsoft.AspNetCore.Mvc.FromBody][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] Order body, System.Threading.CancellationToken cancellationToken) {
   return _implementation.PlaceOrderAsync(body, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("store/order/{orderId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Order>> GetOrderById([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] long orderId, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetOrderByIdAsync(orderId, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("store/order/{orderId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteOrder([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string orderId, System.Threading.CancellationToken cancellationToken) {
   return _implementation.DeleteOrderAsync(orderId, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("store/subscribe")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<Response>> Subscribe(System.Threading.CancellationToken cancellationToken, [Microsoft.AspNetCore.Mvc.FromBody] Body2? body = null) {
   return _implementation.SubscribeAsync(body, cancellationToken);
  }

  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("user")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CreateUser([Microsoft.AspNetCore.Mvc.FromBody][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] User body, System.Threading.CancellationToken cancellationToken) {
   return _implementation.CreateUserAsync(body, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("user/{username}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<User>> GetUserByName([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string username, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetUserByNameAsync(username, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPut, Microsoft.AspNetCore.Mvc.Route("user/{username}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> UpdateUser([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string username, [Microsoft.AspNetCore.Mvc.FromBody][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] User body, System.Threading.CancellationToken cancellationToken) {
   return _implementation.UpdateUserAsync(username, body, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpDelete, Microsoft.AspNetCore.Mvc.Route("user/{username}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> DeleteUser([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string username, System.Threading.CancellationToken cancellationToken) {
   return _implementation.DeleteUserAsync(username, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("user/createWithArray")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CreateUsersWithArrayInput(
    System.Threading.CancellationToken cancellationToken,
    [Microsoft.AspNetCore.Mvc.FromBody] object? body = null) {
   return _implementation.CreateUsersWithArrayInputAsync(body, cancellationToken);
  }

  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("user/createWithList")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> CreateUsersWithListInput(System.Threading.CancellationToken cancellationToken, [Microsoft.AspNetCore.Mvc.FromBody] object? body = null) {
   return _implementation.CreateUsersWithListInputAsync(body, cancellationToken);
  }

  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("user/login")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<string>> LoginUser([Microsoft.AspNetCore.Mvc.FromQuery][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string username, [Microsoft.AspNetCore.Mvc.FromQuery][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string password, System.Threading.CancellationToken cancellationToken) {
   return _implementation.LoginUserAsync(username, password, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("user/logout")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.IActionResult> LogoutUser(System.Threading.CancellationToken cancellationToken) {
   return _implementation.LogoutUserAsync(cancellationToken);
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ApiResponse {
  [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public int? Code { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Type { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("message", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Message { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Cat : Pet {
  [Newtonsoft.Json.JsonProperty("huntingSkill", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public CatHuntingSkill HuntingSkill { get; set; } = PetStore.CatHuntingSkill.Lazy;
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Category {
  [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public long Id { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
  public string? Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("sub", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Sub? Sub { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Dog : Pet {
  [Newtonsoft.Json.JsonProperty("packSize", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Range(1, int.MaxValue)]
  public int PackSize { get; set; } = 1;
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class HoneyBee : Pet {
  [Newtonsoft.Json.JsonProperty("honeyPerDay", Required = Newtonsoft.Json.Required.Always)]
  public double HoneyPerDay { get; set; } = default!;
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Order {
  [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public long Id { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("petId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public long PetId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("quantity", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.Range(1, int.MaxValue)]
  public int? Quantity { get; set; } = 1;
  [Newtonsoft.Json.JsonProperty("shipDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.DateTimeOffset? ShipDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public OrderStatus? Status { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("complete", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public bool? Complete { get; set; } = false;
  [Newtonsoft.Json.JsonProperty("requestId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? RequestId { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [Newtonsoft.Json.JsonConverter(typeof(JsonInheritanceConverter), "petType")]
 [JsonInheritanceAttribute("cat", typeof(Cat))]
 [JsonInheritanceAttribute("dog", typeof(Dog))]
 [JsonInheritanceAttribute("bee", typeof(HoneyBee))]
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Pet {
  [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public long Id { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("category", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Category? Category { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("photoUrls", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  [System.ComponentModel.DataAnnotations.MaxLength(20)]
  public System.Collections.Generic.List<string> PhotoUrls { get; set; } = new System.Collections.Generic.List<string>();
  [Newtonsoft.Json.JsonProperty("friend", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Pet? Friend { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("tags", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.MinLength(1)]
  public System.Collections.Generic.List<Tag>? Tags { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public PetStatus? Status { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Tag {
  [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public long Id { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
  public string? Name { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class User {
  [Newtonsoft.Json.JsonProperty("id", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public long Id { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("pet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Pet Pet { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("username", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 4)]
  public string? Username { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("firstName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
  public string? FirstName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lastName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 1)]
  public string? LastName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("email", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Email { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("password", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue, MinimumLength = 8)]
  [System.ComponentModel.DataAnnotations.RegularExpression(@"/(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])/")]
  public string? Password { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("phone", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.RegularExpression(@"/^\+(?:[0-9]-?){6,14}[0-9]$/")]
  public string? Phone { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("userStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public int? UserStatus { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Tuple<Anonymous2, double>? Addresses { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Body {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Status { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum Anonymous {
  [System.Runtime.Serialization.EnumMember(Value = @"available")]
  Available = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"pending")]
  Pending = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"sold")]
  Sold = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Body2 {
  [Newtonsoft.Json.JsonProperty("callbackUrl", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public System.Uri CallbackUrl { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("eventName", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public Body2EventName EventName { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Response {
  [Newtonsoft.Json.JsonProperty("subscriptionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? SubscriptionId { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum CatHuntingSkill {
  [System.Runtime.Serialization.EnumMember(Value = @"clueless")]
  Clueless = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"lazy")]
  Lazy = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"adventurous")]
  Adventurous = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"aggressive")]
  Aggressive = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Sub {
  [Newtonsoft.Json.JsonProperty("prop1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Prop1 { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum OrderStatus {
  [System.Runtime.Serialization.EnumMember(Value = @"placed")]
  Placed = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"approved")]
  Approved = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"delivered")]
  Delivered = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum PetStatus {
  [System.Runtime.Serialization.EnumMember(Value = @"available")]
  Available = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"pending")]
  Pending = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"sold")]
  Sold = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Anonymous2 {
  [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue)]
  public string? City { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue)]
  public string? Country { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("street", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [System.ComponentModel.DataAnnotations.StringLength(int.MaxValue)]
  public string? Street { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum Body2EventName {
  [System.Runtime.Serialization.EnumMember(Value = @"orderInProgress")]
  OrderInProgress = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"orderShipped")]
  OrderShipped = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"orderDelivered")]
  OrderDelivered = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 [System.AttributeUsage(System.AttributeTargets.Class | System.AttributeTargets.Interface, AllowMultiple = true)]
 internal class JsonInheritanceAttribute : System.Attribute {
  public JsonInheritanceAttribute(string key, System.Type type) {
   Key = key;
   Type = type;
  }
  public string Key { get; }
  public System.Type Type { get; }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public class JsonInheritanceConverter : Newtonsoft.Json.JsonConverter {
  internal static readonly string DefaultDiscriminatorName = "discriminator";
  private readonly string _discriminatorName;
  [System.ThreadStatic]
  private static bool _isReading;
  [System.ThreadStatic]
  private static bool _isWriting;
  public JsonInheritanceConverter() {
   _discriminatorName = DefaultDiscriminatorName;
  }
  public JsonInheritanceConverter(string discriminatorName) {
   _discriminatorName = discriminatorName;
  }
  public string DiscriminatorName { get { return _discriminatorName; } }
  public override void WriteJson(Newtonsoft.Json.JsonWriter writer, object value, Newtonsoft.Json.JsonSerializer serializer) {
   try {
    _isWriting = true;
    var jObject = Newtonsoft.Json.Linq.JObject.FromObject(value, serializer);
    jObject.AddFirst(new Newtonsoft.Json.Linq.JProperty(_discriminatorName, GetSubtypeDiscriminator(value.GetType())));
    writer.WriteToken(jObject.CreateReader());
   } finally {
    _isWriting = false;
   }
  }
  public override bool CanWrite {
   get {
    if (_isWriting) {
     _isWriting = false;
     return false;
    }
    return true;
   }
  }
  public override bool CanRead {
   get {
    if (_isReading) {
     _isReading = false;
     return false;
    }
    return true;
   }
  }
  public override bool CanConvert(System.Type objectType) {
   return true;
  }
  public override object ReadJson(Newtonsoft.Json.JsonReader reader, System.Type objectType, object existingValue, Newtonsoft.Json.JsonSerializer serializer) {
   var jObject = serializer.Deserialize<Newtonsoft.Json.Linq.JObject>(reader);
   if (jObject == null)
    return null;
   var discriminatorValue = jObject.GetValue(_discriminatorName);
   var discriminator = discriminatorValue != null ? Newtonsoft.Json.Linq.Extensions.Value<string>(discriminatorValue) : null;
   var subtype = GetObjectSubtype(objectType, discriminator);
   var objectContract = serializer.ContractResolver.ResolveContract(subtype) as Newtonsoft.Json.Serialization.JsonObjectContract;
   if (objectContract == null || System.Linq.Enumerable.All(objectContract.Properties, p => p.PropertyName != _discriminatorName)) {
    jObject.Remove(_discriminatorName);
   }
   try {
    _isReading = true;
    return serializer.Deserialize(jObject.CreateReader(), subtype);
   } finally {
    _isReading = false;
   }
  }
  private System.Type GetObjectSubtype(System.Type objectType, string discriminator) {
   foreach (var attribute in System.Reflection.CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType), true)) {
    if (attribute.Key == discriminator)
     return attribute.Type;
   }
   return objectType;
  }
  private string GetSubtypeDiscriminator(System.Type objectType) {
   foreach (var attribute in System.Reflection.CustomAttributeExtensions.GetCustomAttributes<JsonInheritanceAttribute>(System.Reflection.IntrospectionExtensions.GetTypeInfo(objectType), true)) {
    if (attribute.Type == objectType)
     return attribute.Key;
   }
   return objectType.Name;
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class FileParameter {
  public FileParameter(System.IO.Stream data)
      : this(data, null, null) {
  }
  public FileParameter(System.IO.Stream data, string? fileName)
      : this(data, fileName, null) {
  }
  public FileParameter(System.IO.Stream data, string? fileName, string? contentType) {
   Data = data;
   FileName = fileName;
   ContentType = contentType;
  }
  public System.IO.Stream Data { get; private set; }
  public string? FileName { get; private set; }
  public string? ContentType { get; private set; }
 }
}
#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore 472
#pragma warning restore 114
#pragma warning restore 108
#pragma warning restore 3016
#pragma warning restore 8603