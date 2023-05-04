#nullable enable
#pragma warning disable 108 
#pragma warning disable 114 
#pragma warning disable 472 
#pragma warning disable 1573 
#pragma warning disable 1591 
#pragma warning disable 8073 
#pragma warning disable 3016 
#pragma warning disable 8603 
namespace PurpleBank {
 using Microsoft.AspNetCore.Mvc;
 using System = global::System;
 [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public interface IController {
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountListV2>> ListAccountsAsync(ProductCategory? product_category, OpenStatus open_status, bool? is_owned, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountsBalanceList>> ListBalancesBulkAsync(ProductCategory2? product_category, OpenStatus2 open_status, bool? is_owned, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountsBalanceList>> ListBalancesSpecificAccountsAsync(int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, RequestAccountIds body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountsBalanceById>> GetBalanceAsync(string accountId, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountByIdV3>> GetAccountDetailAsync(string accountId, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingTransactionList>> GetTransactionsAsync(string accountId, string? oldest_time, string? newest_time, string? min_amount, string? max_amount, string? text, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingTransactionById>> GetTransactionDetailAsync(string accountId, string transactionId, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingDirectDebitAuthorisationList>> ListDirectDebitsAsync(string accountId, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingDirectDebitAuthorisationList>> ListDirectDebitsBulkAsync(ProductCategory3? product_category, OpenStatus3 open_status, bool? is_owned, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingDirectDebitAuthorisationList>> ListDirectDebitsSpecificAccountsAsync(int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, RequestAccountIds body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingScheduledPaymentsList>> ListScheduledPaymentsAsync(string accountId, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingScheduledPaymentsList>> ListScheduledPaymentsBulkAsync(ProductCategory4? product_category, OpenStatus4 open_status, bool? is_owned, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingScheduledPaymentsList>> ListScheduledPaymentsSpecificAccountsAsync(int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, RequestAccountIds body, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingPayeeListV2>> ListPayeesAsync(Type type, int page, int page_size, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingPayeeByIdV2>> GetPayeeDetailAsync(string payeeId, string x_v, string? x_min_v, string? x_fapi_interaction_id, string? x_fapi_auth_date, string? x_fapi_customer_ip_address, string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingProductListV2>> ListProductsAsync(Effective effective, string? updated_since, string? brand, ProductCategory5? product_category, int page, int page_size, string x_v, string? x_min_v, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
  System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingProductByIdV4>> GetProductDetailAsync(string productId, string x_v, string? x_min_v, System.Threading.CancellationToken cancellationToken = default(System.Threading.CancellationToken));
 }
 [System.CodeDom.Compiler.GeneratedCode("NSwag", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 [Microsoft.AspNetCore.Mvc.Route("cds-au/v1")]
 public partial class Controller : ControllerBase {
  private IController _implementation;
  public Controller(IController implementation) {
   _implementation = implementation;
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountListV2>> ListAccounts([Microsoft.AspNetCore.Mvc.FromQuery(Name = "product-category")] ProductCategory? product_category, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "open-status")] OpenStatus? open_status, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "is-owned")] bool? is_owned, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListAccountsAsync(product_category, open_status ?? PurpleBank.OpenStatus.ALL, is_owned, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/balances")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountsBalanceList>> ListBalancesBulk([Microsoft.AspNetCore.Mvc.FromQuery(Name = "product-category")] ProductCategory2? product_category, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "open-status")] OpenStatus2? open_status, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "is-owned")] bool? is_owned, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListBalancesBulkAsync(product_category, open_status ?? PurpleBank.OpenStatus2.ALL, is_owned, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("banking/accounts/balances")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountsBalanceList>> ListBalancesSpecificAccounts([Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, [Microsoft.AspNetCore.Mvc.FromBody][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] RequestAccountIds body, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListBalancesSpecificAccountsAsync(page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, body, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/{accountId}/balance")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountsBalanceById>> GetBalance([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string accountId, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetBalanceAsync(accountId, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/{accountId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingAccountByIdV3>> GetAccountDetail([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string accountId, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetAccountDetailAsync(accountId, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/{accountId}/transactions")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingTransactionList>> GetTransactions([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string accountId, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "oldest-time")] string? oldest_time, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "newest-time")] string? newest_time, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "min-amount")] string? min_amount, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "max-amount")] string? max_amount, [Microsoft.AspNetCore.Mvc.FromQuery] string? text, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetTransactionsAsync(accountId, oldest_time, newest_time, min_amount, max_amount, text, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/{accountId}/transactions/{transactionId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingTransactionById>> GetTransactionDetail([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string accountId, [Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string transactionId, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetTransactionDetailAsync(accountId, transactionId, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/{accountId}/direct-debits")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingDirectDebitAuthorisationList>> ListDirectDebits([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string accountId, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListDirectDebitsAsync(accountId, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/direct-debits")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingDirectDebitAuthorisationList>> ListDirectDebitsBulk([Microsoft.AspNetCore.Mvc.FromQuery(Name = "product-category")] ProductCategory3? product_category, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "open-status")] OpenStatus3? open_status, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "is-owned")] bool? is_owned, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListDirectDebitsBulkAsync(product_category, open_status ?? PurpleBank.OpenStatus3.ALL, is_owned, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("banking/accounts/direct-debits")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingDirectDebitAuthorisationList>> ListDirectDebitsSpecificAccounts([Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, [Microsoft.AspNetCore.Mvc.FromBody][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] RequestAccountIds body, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListDirectDebitsSpecificAccountsAsync(page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, body, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/accounts/{accountId}/payments/scheduled")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingScheduledPaymentsList>> ListScheduledPayments([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string accountId, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListScheduledPaymentsAsync(accountId, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/payments/scheduled")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingScheduledPaymentsList>> ListScheduledPaymentsBulk([Microsoft.AspNetCore.Mvc.FromQuery(Name = "product-category")] ProductCategory4? product_category, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "open-status")] OpenStatus4? open_status, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "is-owned")] bool? is_owned, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListScheduledPaymentsBulkAsync(product_category, open_status ?? PurpleBank.OpenStatus4.ALL, is_owned, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpPost, Microsoft.AspNetCore.Mvc.Route("banking/payments/scheduled")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingScheduledPaymentsList>> ListScheduledPaymentsSpecificAccounts([Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, [Microsoft.AspNetCore.Mvc.FromBody][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] RequestAccountIds body, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListScheduledPaymentsSpecificAccountsAsync(page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, body, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/payees")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingPayeeListV2>> ListPayees([Microsoft.AspNetCore.Mvc.FromQuery] Type? type, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListPayeesAsync(type ?? PurpleBank.Type.ALL, page ?? 1, page_size ?? 25, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/payees/{payeeId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingPayeeByIdV2>> GetPayeeDetail([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string payeeId, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-interaction-id")] string? x_fapi_interaction_id, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-auth-date")] string? x_fapi_auth_date, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-fapi-customer-ip-address")] string? x_fapi_customer_ip_address, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-cds-client-headers")] string? x_cds_client_headers, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetPayeeDetailAsync(payeeId, x_v, x_min_v, x_fapi_interaction_id, x_fapi_auth_date, x_fapi_customer_ip_address, x_cds_client_headers, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/products")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingProductListV2>> ListProducts([Microsoft.AspNetCore.Mvc.FromQuery] Effective? effective, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "updated-since")] string? updated_since, [Microsoft.AspNetCore.Mvc.FromQuery] string? brand, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "product-category")] ProductCategory5? product_category, [Microsoft.AspNetCore.Mvc.FromQuery] int? page, [Microsoft.AspNetCore.Mvc.FromQuery(Name = "page-size")] int? page_size, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, System.Threading.CancellationToken cancellationToken) {
   return _implementation.ListProductsAsync(effective ?? PurpleBank.Effective.CURRENT, updated_since, brand, product_category, page ?? 1, page_size ?? 25, x_v, x_min_v, cancellationToken);
  }
  [Microsoft.AspNetCore.Mvc.HttpGet, Microsoft.AspNetCore.Mvc.Route("banking/products/{productId}")]
  public System.Threading.Tasks.Task<Microsoft.AspNetCore.Mvc.ActionResult<ResponseBankingProductByIdV4>> GetProductDetail([Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string productId, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-v")][Microsoft.AspNetCore.Mvc.ModelBinding.BindRequired] string x_v, [Microsoft.AspNetCore.Mvc.FromHeader(Name = "x-min-v")] string? x_min_v, System.Threading.CancellationToken cancellationToken) {
   return _implementation.GetProductDetailAsync(productId, x_v, x_min_v, cancellationToken);
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class RequestAccountIds {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public RequestAccountIds_data Data { get; set; } = new RequestAccountIds_data();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Meta? Meta { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingProductListV2 {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public ResponseBankingProductListV2_data Data { get; set; } = new ResponseBankingProductListV2_data();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public LinksPaginated Links { get; set; } = new LinksPaginated();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public MetaPaginated Meta { get; set; } = new MetaPaginated();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductV4 {
  [Newtonsoft.Json.JsonProperty("productId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string ProductId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("effectiveFrom", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? EffectiveFrom { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("effectiveTo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? EffectiveTo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lastUpdated", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string LastUpdated { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("productCategory", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductCategory ProductCategory { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Description { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("brand", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Brand { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("brandName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BrandName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("applicationUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ApplicationUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("isTailored", Required = Newtonsoft.Json.Required.Always)]
  public bool IsTailored { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInformation", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingProductAdditionalInformationV2? AdditionalInformation { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("cardArt", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductV4_cardArt>? CardArt { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductAdditionalInformationV2 {
  [Newtonsoft.Json.JsonProperty("overviewUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? OverviewUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("termsUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? TermsUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("eligibilityUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? EligibilityUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("feesAndPricingUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FeesAndPricingUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("bundleUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BundleUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalOverviewUris", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductAdditionalInformationV2_additionalInformationUris>? AdditionalOverviewUris { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalTermsUris", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductAdditionalInformationV2_additionalInformationUris>? AdditionalTermsUris { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalEligibilityUris", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductAdditionalInformationV2_additionalInformationUris>? AdditionalEligibilityUris { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalFeesAndPricingUris", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductAdditionalInformationV2_additionalInformationUris>? AdditionalFeesAndPricingUris { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalBundleUris", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductAdditionalInformationV2_additionalInformationUris>? AdditionalBundleUris { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductAdditionalInformationV2_additionalInformationUris {
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Description { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingProductByIdV4 {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  public BankingProductDetailV4 Data { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public Links Links { get; set; } = new Links();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Meta? Meta { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductDetailV4 : BankingProductV4 {
  [Newtonsoft.Json.JsonProperty("bundles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductBundle>? Bundles { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("features", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductFeatureV2>? Features { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("constraints", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductConstraint>? Constraints { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("eligibility", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductEligibility>? Eligibility { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductFee>? Fees { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("depositRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductDepositRate>? DepositRates { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lendingRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductLendingRateV2>? LendingRates { get; set; } = default!;
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductBundle {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Description { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("productIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<string>? ProductIds { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductFeatureV2 {
  [Newtonsoft.Json.JsonProperty("featureType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductFeatureV2FeatureType FeatureType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductConstraint {
  [Newtonsoft.Json.JsonProperty("constraintType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductConstraintConstraintType ConstraintType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductEligibility {
  [Newtonsoft.Json.JsonProperty("eligibilityType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductEligibilityEligibilityType EligibilityType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductFee {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("feeType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductFeeFeeType FeeType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Amount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("balanceRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BalanceRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("transactionRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? TransactionRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accruedRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AccruedRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accrualFrequency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AccrualFrequency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Currency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("discounts", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductDiscount>? Discounts { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductDiscount {
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Description { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("discountType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductDiscountDiscountType DiscountType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Amount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("balanceRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BalanceRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("transactionRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? TransactionRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accruedRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AccruedRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("feeRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FeeRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("eligibility", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductDiscountEligibility>? Eligibility { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductDiscountEligibility {
  [Newtonsoft.Json.JsonProperty("discountEligibilityType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductDiscountEligibilityDiscountEligibilityType DiscountEligibilityType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductDepositRate {
  [Newtonsoft.Json.JsonProperty("depositRateType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductDepositRateDepositRateType DepositRateType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Rate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("calculationFrequency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? CalculationFrequency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("applicationFrequency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ApplicationFrequency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("tiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductRateTierV3>? Tiers { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductLendingRateV2 {
  [Newtonsoft.Json.JsonProperty("lendingRateType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductLendingRateV2LendingRateType LendingRateType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("rate", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Rate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("comparisonRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ComparisonRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("calculationFrequency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? CalculationFrequency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("applicationFrequency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ApplicationFrequency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("interestPaymentDue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductLendingRateV2InterestPaymentDue? InterestPaymentDue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("repaymentType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductLendingRateV2RepaymentType? RepaymentType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("loanPurpose", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductLendingRateV2LoanPurpose? LoanPurpose { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("tiers", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductRateTierV3>? Tiers { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductRateTierV3 {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("unitOfMeasure", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductRateTierV3UnitOfMeasure UnitOfMeasure { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("minimumValue", Required = Newtonsoft.Json.Required.Always)]
  public double MinimumValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maximumValue", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public double? MaximumValue { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("rateApplicationMethod", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductRateTierV3RateApplicationMethod? RateApplicationMethod { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("applicabilityConditions", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingProductRateCondition? ApplicabilityConditions { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductRateCondition {
  [Newtonsoft.Json.JsonProperty("additionalInfo", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfo { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("additionalInfoUri", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AdditionalInfoUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingAccountListV2 {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public ResponseBankingAccountListV2_data Data { get; set; } = new ResponseBankingAccountListV2_data();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public LinksPaginated Links { get; set; } = new LinksPaginated();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public MetaPaginated Meta { get; set; } = new MetaPaginated();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingAccountV2 {
  [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AccountId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("creationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? CreationDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("displayName", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string DisplayName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("nickname", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Nickname { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("openStatus", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingAccountV2OpenStatus? OpenStatus { get; set; } = PurpleBank.BankingAccountV2OpenStatus.OPEN;
  [Newtonsoft.Json.JsonProperty("isOwned", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public bool? IsOwned { get; set; } = true;
  [Newtonsoft.Json.JsonProperty("accountOwnership", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingAccountV2AccountOwnership AccountOwnership { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maskedNumber", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string MaskedNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("productCategory", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingProductCategory ProductCategory { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("productName", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string ProductName { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingAccountByIdV3 {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  public BankingAccountDetailV3 Data { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public Links Links { get; set; } = new Links();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Meta? Meta { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingAccountDetailV3 : BankingAccountV2 {
  [Newtonsoft.Json.JsonProperty("bsb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Bsb { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accountNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AccountNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("bundleName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BundleName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("specificAccountUType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingAccountDetailV3SpecificAccountUType? SpecificAccountUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("termDeposit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingTermDepositAccount>? TermDeposit { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("creditCard", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingCreditCardAccount? CreditCard { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("loan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingLoanAccountV2? Loan { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("depositRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? DepositRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lendingRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? LendingRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("depositRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductDepositRate>? DepositRates { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lendingRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductLendingRateV2>? LendingRates { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("features", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<Features>? Features { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductFee>? Fees { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<CommonPhysicalAddress>? Addresses { get; set; } = default!;
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingTermDepositAccount {
  [Newtonsoft.Json.JsonProperty("lodgementDate", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string LodgementDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maturityDate", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string MaturityDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maturityAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MaturityAmount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maturityCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MaturityCurrency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maturityInstructions", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingTermDepositAccountMaturityInstructions MaturityInstructions { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingCreditCardAccount {
  [Newtonsoft.Json.JsonProperty("minPaymentAmount", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string MinPaymentAmount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("paymentDueAmount", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string PaymentDueAmount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("paymentCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PaymentCurrency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("paymentDueDate", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string PaymentDueDate { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingLoanAccountV2 {
  [Newtonsoft.Json.JsonProperty("originalStartDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? OriginalStartDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("originalLoanAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? OriginalLoanAmount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("originalLoanCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? OriginalLoanCurrency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("loanEndDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? LoanEndDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("nextInstalmentDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? NextInstalmentDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("minInstalmentAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MinInstalmentAmount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("minInstalmentCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MinInstalmentCurrency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maxRedraw", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MaxRedraw { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("maxRedrawCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MaxRedrawCurrency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("minRedraw", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MinRedraw { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("minRedrawCurrency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MinRedrawCurrency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("offsetAccountEnabled", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public bool? OffsetAccountEnabled { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("offsetAccountIds", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<string>? OffsetAccountIds { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("repaymentType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingLoanAccountV2RepaymentType? RepaymentType { get; set; } = PurpleBank.BankingLoanAccountV2RepaymentType.PRINCIPAL_AND_INTEREST;
  [Newtonsoft.Json.JsonProperty("repaymentFrequency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? RepaymentFrequency { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingTransactionList {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public ResponseBankingTransactionList_data Data { get; set; } = new ResponseBankingTransactionList_data();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public LinksPaginated Links { get; set; } = new LinksPaginated();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public MetaPaginated Meta { get; set; } = new MetaPaginated();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingTransaction {
  [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AccountId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("transactionId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? TransactionId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("isDetailAvailable", Required = Newtonsoft.Json.Required.Always)]
  public bool IsDetailAvailable { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingTransactionType Type { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingTransactionStatus Status { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Description { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("postingDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PostingDateTime { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("valueDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ValueDateTime { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("executionDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ExecutionDateTime { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Amount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Currency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("reference", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Reference { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("merchantName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MerchantName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("merchantCategoryCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MerchantCategoryCode { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("billerCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BillerCode { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("billerName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BillerName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Crn { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("apcaNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ApcaNumber { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingTransactionById {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  public BankingTransactionDetail Data { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public Links Links { get; set; } = new Links();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Meta? Meta { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingTransactionDetail : BankingTransaction {
  [Newtonsoft.Json.JsonProperty("extendedData", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingTransactionDetail_allOf_extendedData ExtendedData { get; set; } = new BankingTransactionDetail_allOf_extendedData();
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingAccountsBalanceList {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public ResponseBankingAccountsBalanceList_data Data { get; set; } = new ResponseBankingAccountsBalanceList_data();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public LinksPaginated Links { get; set; } = new LinksPaginated();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public MetaPaginated Meta { get; set; } = new MetaPaginated();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingAccountsBalanceById {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingBalance Data { get; set; } = new BankingBalance();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public Links Links { get; set; } = new Links();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Meta? Meta { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingBalance {
  [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AccountId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("currentBalance", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string CurrentBalance { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("availableBalance", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AvailableBalance { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("creditLimit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? CreditLimit { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("amortisedLimit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AmortisedLimit { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Currency { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("purses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingBalancePurse>? Purses { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingBalancePurse {
  [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Amount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Currency { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingPayeeListV2 {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public ResponseBankingPayeeListV2_data Data { get; set; } = new ResponseBankingPayeeListV2_data();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public LinksPaginated Links { get; set; } = new LinksPaginated();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public MetaPaginated Meta { get; set; } = new MetaPaginated();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingPayeeByIdV2 {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  public BankingPayeeDetailV2 Data { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public Links Links { get; set; } = new Links();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public Meta? Meta { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingPayeeV2 {
  [Newtonsoft.Json.JsonProperty("payeeId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string PayeeId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("nickname", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Nickname { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Description { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingPayeeV2Type Type { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("creationDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? CreationDate { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingPayeeDetailV2 : BankingPayeeV2 {
  [Newtonsoft.Json.JsonProperty("payeeUType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingPayeeDetailV2PayeeUType PayeeUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("biller", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingBillerPayee? Biller { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("domestic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDomesticPayee? Domestic { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("digitalWallet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDigitalWalletPayee? DigitalWallet { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("international", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingInternationalPayee? International { get; set; } = default!;
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingDomesticPayee {
  [Newtonsoft.Json.JsonProperty("payeeAccountUType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingDomesticPayeePayeeAccountUType PayeeAccountUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("account", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDomesticPayeeAccount? Account { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("card", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDomesticPayeeCard? Card { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("payId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDomesticPayeePayId? PayId { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingDomesticPayeeAccount {
  [Newtonsoft.Json.JsonProperty("accountName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AccountName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("bsb", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Bsb { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accountNumber", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AccountNumber { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingDomesticPayeeCard {
  [Newtonsoft.Json.JsonProperty("cardNumber", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string CardNumber { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingDomesticPayeePayId {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Identifier { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingDomesticPayeePayIdType Type { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingBillerPayee {
  [Newtonsoft.Json.JsonProperty("billerCode", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string BillerCode { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("crn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Crn { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("billerName", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string BillerName { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingInternationalPayee {
  [Newtonsoft.Json.JsonProperty("beneficiaryDetails", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingInternationalPayee_beneficiaryDetails BeneficiaryDetails { get; set; } = new BankingInternationalPayee_beneficiaryDetails();
  [Newtonsoft.Json.JsonProperty("bankDetails", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingInternationalPayee_bankDetails BankDetails { get; set; } = new BankingInternationalPayee_bankDetails();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingDigitalWalletPayee {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("identifier", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Identifier { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("type", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingDigitalWalletPayeeType Type { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("provider", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingDigitalWalletPayeeProvider Provider { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingDirectDebitAuthorisationList {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public ResponseBankingDirectDebitAuthorisationList_data Data { get; set; } = new ResponseBankingDirectDebitAuthorisationList_data();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public LinksPaginated Links { get; set; } = new LinksPaginated();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public MetaPaginated Meta { get; set; } = new MetaPaginated();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingDirectDebit {
  [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AccountId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("authorisedEntity", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingAuthorisedEntity AuthorisedEntity { get; set; } = new BankingAuthorisedEntity();
  [Newtonsoft.Json.JsonProperty("lastDebitDateTime", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? LastDebitDateTime { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lastDebitAmount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? LastDebitAmount { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingAuthorisedEntity {
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Description { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("financialInstitution", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FinancialInstitution { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("abn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Abn { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("acn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Acn { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("arbn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Arbn { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingScheduledPaymentsList {
  [Newtonsoft.Json.JsonProperty("data", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public ResponseBankingScheduledPaymentsList_data Data { get; set; } = new ResponseBankingScheduledPaymentsList_data();
  [Newtonsoft.Json.JsonProperty("links", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public LinksPaginated Links { get; set; } = new LinksPaginated();
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public MetaPaginated Meta { get; set; } = new MetaPaginated();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPayment {
  [Newtonsoft.Json.JsonProperty("scheduledPaymentId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string ScheduledPaymentId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("nickname", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Nickname { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("payerReference", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string PayerReference { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("payeeReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PayeeReference { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("status", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingScheduledPaymentStatus Status { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("from", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingScheduledPaymentFrom From { get; set; } = new BankingScheduledPaymentFrom();
  [Newtonsoft.Json.JsonProperty("paymentSet", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingScheduledPaymentSet> PaymentSet { get; set; } = new System.Collections.Generic.List<BankingScheduledPaymentSet>();
  [Newtonsoft.Json.JsonProperty("recurrence", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingScheduledPaymentRecurrence Recurrence { get; set; } = new BankingScheduledPaymentRecurrence();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentSet {
  [Newtonsoft.Json.JsonProperty("to", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingScheduledPaymentTo To { get; set; } = new BankingScheduledPaymentTo();
  [Newtonsoft.Json.JsonProperty("isAmountCalculated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public bool? IsAmountCalculated { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("amount", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Amount { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("currency", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Currency { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentTo {
  [Newtonsoft.Json.JsonProperty("toUType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingScheduledPaymentToToUType ToUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AccountId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("payeeId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PayeeId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("nickname", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Nickname { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("payeeReference", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PayeeReference { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("domestic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDomesticPayee? Domestic { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("biller", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingBillerPayee? Biller { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("international", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingInternationalPayee? International { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentFrom {
  [Newtonsoft.Json.JsonProperty("accountId", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AccountId { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentRecurrence {
  [Newtonsoft.Json.JsonProperty("nextPaymentDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? NextPaymentDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("recurrenceUType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingScheduledPaymentRecurrenceRecurrenceUType RecurrenceUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("onceOff", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingScheduledPaymentRecurrenceOnceOff? OnceOff { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("intervalSchedule", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingScheduledPaymentRecurrenceIntervalSchedule? IntervalSchedule { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lastWeekDay", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingScheduledPaymentRecurrenceLastWeekday? LastWeekDay { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("eventBased", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingScheduledPaymentRecurrenceEventBased? EventBased { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentRecurrenceOnceOff {
  [Newtonsoft.Json.JsonProperty("paymentDate", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string PaymentDate { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentRecurrenceIntervalSchedule {
  [Newtonsoft.Json.JsonProperty("finalPaymentDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FinalPaymentDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("paymentsRemaining", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public int? PaymentsRemaining { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("nonBusinessDayTreatment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingScheduledPaymentRecurrenceIntervalScheduleNonBusinessDayTreatment? NonBusinessDayTreatment { get; set; } = PurpleBank.BankingScheduledPaymentRecurrenceIntervalScheduleNonBusinessDayTreatment.ON;
  [Newtonsoft.Json.JsonProperty("intervals", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingScheduledPaymentInterval> Intervals { get; set; } = new System.Collections.Generic.List<BankingScheduledPaymentInterval>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentInterval {
  [Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Interval { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("dayInInterval", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? DayInInterval { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentRecurrenceLastWeekday {
  [Newtonsoft.Json.JsonProperty("finalPaymentDate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FinalPaymentDate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("paymentsRemaining", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public int? PaymentsRemaining { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("interval", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Interval { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lastWeekDay", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingScheduledPaymentRecurrenceLastWeekdayLastWeekDay LastWeekDay { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("nonBusinessDayTreatment", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingScheduledPaymentRecurrenceLastWeekdayNonBusinessDayTreatment? NonBusinessDayTreatment { get; set; } = PurpleBank.BankingScheduledPaymentRecurrenceLastWeekdayNonBusinessDayTreatment.ON;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingScheduledPaymentRecurrenceEventBased {
  [Newtonsoft.Json.JsonProperty("description", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Description { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class CommonPhysicalAddress {
  [Newtonsoft.Json.JsonProperty("addressUType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public CommonPhysicalAddressAddressUType AddressUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("simple", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public CommonSimpleAddress? Simple { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("paf", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public CommonPAFAddress? Paf { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class CommonSimpleAddress {
  [Newtonsoft.Json.JsonProperty("mailingName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? MailingName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("addressLine1", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AddressLine1 { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("addressLine2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AddressLine2 { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("addressLine3", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AddressLine3 { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("postcode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Postcode { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("city", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string City { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string State { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Country { get; set; } = "AUS";
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class CommonPAFAddress {
  [Newtonsoft.Json.JsonProperty("dpid", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Dpid { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("thoroughfareNumber1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public int? ThoroughfareNumber1 { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("thoroughfareNumber1Suffix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ThoroughfareNumber1Suffix { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("thoroughfareNumber2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public int? ThoroughfareNumber2 { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("thoroughfareNumber2Suffix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ThoroughfareNumber2Suffix { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("flatUnitType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FlatUnitType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("flatUnitNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FlatUnitNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("floorLevelType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FloorLevelType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("floorLevelNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FloorLevelNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lotNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? LotNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("buildingName1", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BuildingName1 { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("buildingName2", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BuildingName2 { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("streetName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? StreetName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("streetType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? StreetType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("streetSuffix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? StreetSuffix { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("postalDeliveryType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PostalDeliveryType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("postalDeliveryNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public int? PostalDeliveryNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("postalDeliveryNumberPrefix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PostalDeliveryNumberPrefix { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("postalDeliveryNumberSuffix", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PostalDeliveryNumberSuffix { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("localityName", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string LocalityName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("postcode", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Postcode { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("state", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string State { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Links {
  [Newtonsoft.Json.JsonProperty("self", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Self { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Meta {
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class LinksPaginated {
  [Newtonsoft.Json.JsonProperty("self", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Self { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("first", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? First { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("prev", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Prev { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("next", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Next { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("last", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Last { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class MetaPaginated {
  [Newtonsoft.Json.JsonProperty("totalRecords", Required = Newtonsoft.Json.Required.Always)]
  public int TotalRecords { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("totalPages", Required = Newtonsoft.Json.Required.Always)]
  public int TotalPages { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class MetaError {
  [Newtonsoft.Json.JsonProperty("urn", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Urn { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseErrorListV2 {
  [Newtonsoft.Json.JsonProperty("errors", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<ResponseErrorListV2_errors> Errors { get; set; } = new System.Collections.Generic.List<ResponseErrorListV2_errors>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductCategory {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS_LOANS")]
  BUSINESS_LOANS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CRED_AND_CHRG_CARDS")]
  CRED_AND_CHRG_CARDS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"LEASES")]
  LEASES = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MARGIN_LOANS")]
  MARGIN_LOANS = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OVERDRAFTS")]
  OVERDRAFTS = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PERS_LOANS")]
  PERS_LOANS = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"REGULATED_TRUST_ACCOUNTS")]
  REGULATED_TRUST_ACCOUNTS = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENTIAL_MORTGAGES")]
  RESIDENTIAL_MORTGAGES = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"TERM_DEPOSITS")]
  TERM_DEPOSITS = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"TRADE_FINANCE")]
  TRADE_FINANCE = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANS_AND_SAVINGS_ACCOUNTS")]
  TRANS_AND_SAVINGS_ACCOUNTS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"TRAVEL_CARDS")]
  TRAVEL_CARDS = 11,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class RequestAccountIds_data {
  [Newtonsoft.Json.JsonProperty("accountIds", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<string> AccountIds { get; set; } = new System.Collections.Generic.List<string>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingProductListV2_data {
  [Newtonsoft.Json.JsonProperty("products", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingProductV4> Products { get; set; } = new System.Collections.Generic.List<BankingProductV4>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductV4_cardArt {
  [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Title { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("imageUri", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string ImageUri { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingProductDetailV4_allOf {
  [Newtonsoft.Json.JsonProperty("bundles", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductBundle>? Bundles { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("features", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductFeatureV2>? Features { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("constraints", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductConstraint>? Constraints { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("eligibility", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductEligibility>? Eligibility { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductFee>? Fees { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("depositRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductDepositRate>? DepositRates { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lendingRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductLendingRateV2>? LendingRates { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingAccountListV2_data {
  [Newtonsoft.Json.JsonProperty("accounts", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingAccountV2> Accounts { get; set; } = new System.Collections.Generic.List<BankingAccountV2>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingAccountDetailV3_allOf {
  [Newtonsoft.Json.JsonProperty("bsb", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Bsb { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accountNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? AccountNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("bundleName", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BundleName { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("specificAccountUType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingAccountDetailV3SpecificAccountUType? SpecificAccountUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("termDeposit", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingTermDepositAccount>? TermDeposit { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("creditCard", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingCreditCardAccount? CreditCard { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("loan", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingLoanAccountV2? Loan { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("depositRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? DepositRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lendingRate", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? LendingRate { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("depositRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductDepositRate>? DepositRates { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("lendingRates", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductLendingRateV2>? LendingRates { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("features", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<Features>? Features { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("fees", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<BankingProductFee>? Fees { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("addresses", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public System.Collections.Generic.List<CommonPhysicalAddress>? Addresses { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingTransactionList_data {
  [Newtonsoft.Json.JsonProperty("transactions", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingTransaction> Transactions { get; set; } = new System.Collections.Generic.List<BankingTransaction>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingTransactionDetail_allOf_extendedData_x2p101Payload {
  [Newtonsoft.Json.JsonProperty("extendedDescription", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ExtendedDescription { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("endToEndId", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? EndToEndId { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("purposeCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? PurposeCode { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingTransactionDetail_allOf_extendedData {
  [Newtonsoft.Json.JsonProperty("payer", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Payer { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("payee", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Payee { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("extensionUType", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingTransactionDetail_allOf_extendedDataExtensionUType? ExtensionUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("x2p101Payload", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingTransactionDetail_allOf_extendedData_x2p101Payload? X2p101Payload { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("service", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingTransactionDetail_allOf_extendedDataService Service { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingTransactionDetail_allOf {
  [Newtonsoft.Json.JsonProperty("extendedData", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public BankingTransactionDetail_allOf_extendedData ExtendedData { get; set; } = new BankingTransactionDetail_allOf_extendedData();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingAccountsBalanceList_data {
  [Newtonsoft.Json.JsonProperty("balances", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingBalance> Balances { get; set; } = new System.Collections.Generic.List<BankingBalance>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingPayeeListV2_data {
  [Newtonsoft.Json.JsonProperty("payees", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingPayeeV2> Payees { get; set; } = new System.Collections.Generic.List<BankingPayeeV2>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingPayeeDetailV2_allOf {
  [Newtonsoft.Json.JsonProperty("payeeUType", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
  public BankingPayeeDetailV2PayeeUType PayeeUType { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("biller", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingBillerPayee? Biller { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("domestic", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDomesticPayee? Domestic { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("digitalWallet", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingDigitalWalletPayee? DigitalWallet { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("international", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingInternationalPayee? International { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingInternationalPayee_beneficiaryDetails {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Country { get; set; } = default!;
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
 public partial class BankingInternationalPayee_bankDetails_bankAddress {
  [Newtonsoft.Json.JsonProperty("name", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Name { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("address", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Address { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class BankingInternationalPayee_bankDetails {
  [Newtonsoft.Json.JsonProperty("country", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Country { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("accountNumber", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string AccountNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("bankAddress", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public BankingInternationalPayee_bankDetails_bankAddress? BankAddress { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("beneficiaryBankBIC", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? BeneficiaryBankBIC { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("fedWireNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? FedWireNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("sortCode", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? SortCode { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("chipNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? ChipNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("routingNumber", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? RoutingNumber { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("legalEntityIdentifier", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public string? LegalEntityIdentifier { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingDirectDebitAuthorisationList_data {
  [Newtonsoft.Json.JsonProperty("directDebitAuthorisations", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingDirectDebit> DirectDebitAuthorisations { get; set; } = new System.Collections.Generic.List<BankingDirectDebit>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseBankingScheduledPaymentsList_data {
  [Newtonsoft.Json.JsonProperty("scheduledPayments", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required]
  public System.Collections.Generic.List<BankingScheduledPayment> ScheduledPayments { get; set; } = new System.Collections.Generic.List<BankingScheduledPayment>();
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class ResponseErrorListV2_errors {
  [Newtonsoft.Json.JsonProperty("code", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Code { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("title", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Title { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("detail", Required = Newtonsoft.Json.Required.Always)]
  [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
  public string Detail { get; set; } = default!;
  [Newtonsoft.Json.JsonProperty("meta", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public MetaError? Meta { get; set; } = default!;
  private System.Collections.Generic.IDictionary<string, object>? _additionalProperties;
  [Newtonsoft.Json.JsonExtensionData]
  public System.Collections.Generic.IDictionary<string, object> AdditionalProperties {
   get { return _additionalProperties ?? (_additionalProperties = new System.Collections.Generic.Dictionary<string, object>()); }
   set { _additionalProperties = value; }
  }
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum ProductCategory {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS_LOANS")]
  BUSINESS_LOANS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CRED_AND_CHRG_CARDS")]
  CRED_AND_CHRG_CARDS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"LEASES")]
  LEASES = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MARGIN_LOANS")]
  MARGIN_LOANS = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OVERDRAFTS")]
  OVERDRAFTS = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PERS_LOANS")]
  PERS_LOANS = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"REGULATED_TRUST_ACCOUNTS")]
  REGULATED_TRUST_ACCOUNTS = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENTIAL_MORTGAGES")]
  RESIDENTIAL_MORTGAGES = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"TERM_DEPOSITS")]
  TERM_DEPOSITS = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"TRADE_FINANCE")]
  TRADE_FINANCE = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANS_AND_SAVINGS_ACCOUNTS")]
  TRANS_AND_SAVINGS_ACCOUNTS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"TRAVEL_CARDS")]
  TRAVEL_CARDS = 11,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum OpenStatus {
  [System.Runtime.Serialization.EnumMember(Value = @"ALL")]
  ALL = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CLOSED")]
  CLOSED = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"OPEN")]
  OPEN = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum ProductCategory2 {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS_LOANS")]
  BUSINESS_LOANS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CRED_AND_CHRG_CARDS")]
  CRED_AND_CHRG_CARDS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"LEASES")]
  LEASES = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MARGIN_LOANS")]
  MARGIN_LOANS = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OVERDRAFTS")]
  OVERDRAFTS = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PERS_LOANS")]
  PERS_LOANS = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"REGULATED_TRUST_ACCOUNTS")]
  REGULATED_TRUST_ACCOUNTS = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENTIAL_MORTGAGES")]
  RESIDENTIAL_MORTGAGES = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"TERM_DEPOSITS")]
  TERM_DEPOSITS = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"TRADE_FINANCE")]
  TRADE_FINANCE = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANS_AND_SAVINGS_ACCOUNTS")]
  TRANS_AND_SAVINGS_ACCOUNTS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"TRAVEL_CARDS")]
  TRAVEL_CARDS = 11,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum OpenStatus2 {
  [System.Runtime.Serialization.EnumMember(Value = @"ALL")]
  ALL = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CLOSED")]
  CLOSED = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"OPEN")]
  OPEN = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum ProductCategory3 {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS_LOANS")]
  BUSINESS_LOANS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CRED_AND_CHRG_CARDS")]
  CRED_AND_CHRG_CARDS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"LEASES")]
  LEASES = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MARGIN_LOANS")]
  MARGIN_LOANS = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OVERDRAFTS")]
  OVERDRAFTS = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PERS_LOANS")]
  PERS_LOANS = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"REGULATED_TRUST_ACCOUNTS")]
  REGULATED_TRUST_ACCOUNTS = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENTIAL_MORTGAGES")]
  RESIDENTIAL_MORTGAGES = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"TERM_DEPOSITS")]
  TERM_DEPOSITS = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"TRADE_FINANCE")]
  TRADE_FINANCE = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANS_AND_SAVINGS_ACCOUNTS")]
  TRANS_AND_SAVINGS_ACCOUNTS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"TRAVEL_CARDS")]
  TRAVEL_CARDS = 11,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum OpenStatus3 {
  [System.Runtime.Serialization.EnumMember(Value = @"ALL")]
  ALL = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CLOSED")]
  CLOSED = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"OPEN")]
  OPEN = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum ProductCategory4 {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS_LOANS")]
  BUSINESS_LOANS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CRED_AND_CHRG_CARDS")]
  CRED_AND_CHRG_CARDS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"LEASES")]
  LEASES = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MARGIN_LOANS")]
  MARGIN_LOANS = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OVERDRAFTS")]
  OVERDRAFTS = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PERS_LOANS")]
  PERS_LOANS = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"REGULATED_TRUST_ACCOUNTS")]
  REGULATED_TRUST_ACCOUNTS = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENTIAL_MORTGAGES")]
  RESIDENTIAL_MORTGAGES = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"TERM_DEPOSITS")]
  TERM_DEPOSITS = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"TRADE_FINANCE")]
  TRADE_FINANCE = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANS_AND_SAVINGS_ACCOUNTS")]
  TRANS_AND_SAVINGS_ACCOUNTS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"TRAVEL_CARDS")]
  TRAVEL_CARDS = 11,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum OpenStatus4 {
  [System.Runtime.Serialization.EnumMember(Value = @"ALL")]
  ALL = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CLOSED")]
  CLOSED = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"OPEN")]
  OPEN = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum Type {
  [System.Runtime.Serialization.EnumMember(Value = @"ALL")]
  ALL = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"BILLER")]
  BILLER = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"DIGITAL_WALLET")]
  DIGITAL_WALLET = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"DOMESTIC")]
  DOMESTIC = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"INTERNATIONAL")]
  INTERNATIONAL = 4,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum Effective {
  [System.Runtime.Serialization.EnumMember(Value = @"ALL")]
  ALL = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CURRENT")]
  CURRENT = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"FUTURE")]
  FUTURE = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum ProductCategory5 {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS_LOANS")]
  BUSINESS_LOANS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CRED_AND_CHRG_CARDS")]
  CRED_AND_CHRG_CARDS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"LEASES")]
  LEASES = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MARGIN_LOANS")]
  MARGIN_LOANS = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OVERDRAFTS")]
  OVERDRAFTS = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PERS_LOANS")]
  PERS_LOANS = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"REGULATED_TRUST_ACCOUNTS")]
  REGULATED_TRUST_ACCOUNTS = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENTIAL_MORTGAGES")]
  RESIDENTIAL_MORTGAGES = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"TERM_DEPOSITS")]
  TERM_DEPOSITS = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"TRADE_FINANCE")]
  TRADE_FINANCE = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANS_AND_SAVINGS_ACCOUNTS")]
  TRANS_AND_SAVINGS_ACCOUNTS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"TRAVEL_CARDS")]
  TRAVEL_CARDS = 11,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductFeatureV2FeatureType {
  [System.Runtime.Serialization.EnumMember(Value = @"ADDITIONAL_CARDS")]
  ADDITIONAL_CARDS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"BALANCE_TRANSFERS")]
  BALANCE_TRANSFERS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"BILL_PAYMENT")]
  BILL_PAYMENT = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"BONUS_REWARDS")]
  BONUS_REWARDS = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"CARD_ACCESS")]
  CARD_ACCESS = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"CASHBACK_OFFER")]
  CASHBACK_OFFER = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"COMPLEMENTARY_PRODUCT_DISCOUNTS")]
  COMPLEMENTARY_PRODUCT_DISCOUNTS = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"DIGITAL_BANKING")]
  DIGITAL_BANKING = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"DIGITAL_WALLET")]
  DIGITAL_WALLET = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"DONATE_INTEREST")]
  DONATE_INTEREST = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"EXTRA_REPAYMENTS")]
  EXTRA_REPAYMENTS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"FRAUD_PROTECTION")]
  FRAUD_PROTECTION = 11,
  [System.Runtime.Serialization.EnumMember(Value = @"FREE_TXNS")]
  FREE_TXNS = 12,
  [System.Runtime.Serialization.EnumMember(Value = @"FREE_TXNS_ALLOWANCE")]
  FREE_TXNS_ALLOWANCE = 13,
  [System.Runtime.Serialization.EnumMember(Value = @"GUARANTOR")]
  GUARANTOR = 14,
  [System.Runtime.Serialization.EnumMember(Value = @"INSURANCE")]
  INSURANCE = 15,
  [System.Runtime.Serialization.EnumMember(Value = @"INSTALMENT_PLAN")]
  INSTALMENT_PLAN = 16,
  [System.Runtime.Serialization.EnumMember(Value = @"INTEREST_FREE")]
  INTEREST_FREE = 17,
  [System.Runtime.Serialization.EnumMember(Value = @"INTEREST_FREE_TRANSFERS")]
  INTEREST_FREE_TRANSFERS = 18,
  [System.Runtime.Serialization.EnumMember(Value = @"LOYALTY_PROGRAM")]
  LOYALTY_PROGRAM = 19,
  [System.Runtime.Serialization.EnumMember(Value = @"NOTIFICATIONS")]
  NOTIFICATIONS = 20,
  [System.Runtime.Serialization.EnumMember(Value = @"NPP_ENABLED")]
  NPP_ENABLED = 21,
  [System.Runtime.Serialization.EnumMember(Value = @"NPP_PAYID")]
  NPP_PAYID = 22,
  [System.Runtime.Serialization.EnumMember(Value = @"OFFSET")]
  OFFSET = 23,
  [System.Runtime.Serialization.EnumMember(Value = @"OTHER")]
  OTHER = 24,
  [System.Runtime.Serialization.EnumMember(Value = @"OVERDRAFT")]
  OVERDRAFT = 25,
  [System.Runtime.Serialization.EnumMember(Value = @"REDRAW")]
  REDRAW = 26,
  [System.Runtime.Serialization.EnumMember(Value = @"RELATIONSHIP_MANAGEMENT")]
  RELATIONSHIP_MANAGEMENT = 27,
  [System.Runtime.Serialization.EnumMember(Value = @"UNLIMITED_TXNS")]
  UNLIMITED_TXNS = 28,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductConstraintConstraintType {
  [System.Runtime.Serialization.EnumMember(Value = @"MAX_BALANCE")]
  MAX_BALANCE = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"MAX_LIMIT")]
  MAX_LIMIT = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_BALANCE")]
  MIN_BALANCE = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_LIMIT")]
  MIN_LIMIT = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OPENING_BALANCE")]
  OPENING_BALANCE = 4,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductEligibilityEligibilityType {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS")]
  BUSINESS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"EMPLOYMENT_STATUS")]
  EMPLOYMENT_STATUS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"MAX_AGE")]
  MAX_AGE = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_AGE")]
  MIN_AGE = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_INCOME")]
  MIN_INCOME = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_TURNOVER")]
  MIN_TURNOVER = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"NATURAL_PERSON")]
  NATURAL_PERSON = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"OTHER")]
  OTHER = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"PENSION_RECIPIENT")]
  PENSION_RECIPIENT = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENCY_STATUS")]
  RESIDENCY_STATUS = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"STAFF")]
  STAFF = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"STUDENT")]
  STUDENT = 11,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductFeeFeeType {
  [System.Runtime.Serialization.EnumMember(Value = @"DEPOSIT")]
  DEPOSIT = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"EVENT")]
  EVENT = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"EXIT")]
  EXIT = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"PAYMENT")]
  PAYMENT = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"PERIODIC")]
  PERIODIC = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PURCHASE")]
  PURCHASE = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANSACTION")]
  TRANSACTION = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"UPFRONT")]
  UPFRONT = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"VARIABLE")]
  VARIABLE = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"WITHDRAWAL")]
  WITHDRAWAL = 9,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductDiscountDiscountType {
  [System.Runtime.Serialization.EnumMember(Value = @"BALANCE")]
  BALANCE = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"DEPOSITS")]
  DEPOSITS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"ELIGIBILITY_ONLY")]
  ELIGIBILITY_ONLY = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"FEE_CAP")]
  FEE_CAP = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"PAYMENTS")]
  PAYMENTS = 4,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductDiscountEligibilityDiscountEligibilityType {
  [System.Runtime.Serialization.EnumMember(Value = @"BUSINESS")]
  BUSINESS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"EMPLOYMENT_STATUS")]
  EMPLOYMENT_STATUS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"INTRODUCTORY")]
  INTRODUCTORY = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MAX_AGE")]
  MAX_AGE = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_AGE")]
  MIN_AGE = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_INCOME")]
  MIN_INCOME = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"MIN_TURNOVER")]
  MIN_TURNOVER = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"NATURAL_PERSON")]
  NATURAL_PERSON = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"OTHER")]
  OTHER = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"PENSION_RECIPIENT")]
  PENSION_RECIPIENT = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"RESIDENCY_STATUS")]
  RESIDENCY_STATUS = 10,
  [System.Runtime.Serialization.EnumMember(Value = @"STAFF")]
  STAFF = 11,
  [System.Runtime.Serialization.EnumMember(Value = @"STUDENT")]
  STUDENT = 12,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductDepositRateDepositRateType {
  [System.Runtime.Serialization.EnumMember(Value = @"BONUS")]
  BONUS = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"BUNDLE_BONUS")]
  BUNDLE_BONUS = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"FIXED")]
  FIXED = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"FLOATING")]
  FLOATING = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"INTRODUCTORY")]
  INTRODUCTORY = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"MARKET_LINKED")]
  MARKET_LINKED = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"VARIABLE")]
  VARIABLE = 6,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductLendingRateV2LendingRateType {
  [System.Runtime.Serialization.EnumMember(Value = @"BUNDLE_DISCOUNT_FIXED")]
  BUNDLE_DISCOUNT_FIXED = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"BUNDLE_DISCOUNT_VARIABLE")]
  BUNDLE_DISCOUNT_VARIABLE = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"CASH_ADVANCE")]
  CASH_ADVANCE = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"DISCOUNT")]
  DISCOUNT = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"FIXED")]
  FIXED = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"FLOATING")]
  FLOATING = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"INTRODUCTORY")]
  INTRODUCTORY = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"MARKET_LINKED")]
  MARKET_LINKED = 7,
  [System.Runtime.Serialization.EnumMember(Value = @"PENALTY")]
  PENALTY = 8,
  [System.Runtime.Serialization.EnumMember(Value = @"PURCHASE")]
  PURCHASE = 9,
  [System.Runtime.Serialization.EnumMember(Value = @"VARIABLE")]
  VARIABLE = 10,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductLendingRateV2InterestPaymentDue {
  [System.Runtime.Serialization.EnumMember(Value = @"IN_ADVANCE")]
  IN_ADVANCE = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"IN_ARREARS")]
  IN_ARREARS = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductLendingRateV2RepaymentType {
  [System.Runtime.Serialization.EnumMember(Value = @"INTEREST_ONLY")]
  INTEREST_ONLY = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"PRINCIPAL_AND_INTEREST")]
  PRINCIPAL_AND_INTEREST = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductLendingRateV2LoanPurpose {
  [System.Runtime.Serialization.EnumMember(Value = @"INVESTMENT")]
  INVESTMENT = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"OWNER_OCCUPIED")]
  OWNER_OCCUPIED = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductRateTierV3UnitOfMeasure {
  [System.Runtime.Serialization.EnumMember(Value = @"DAY")]
  DAY = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"DOLLAR")]
  DOLLAR = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"MONTH")]
  MONTH = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"PERCENT")]
  PERCENT = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingProductRateTierV3RateApplicationMethod {
  [System.Runtime.Serialization.EnumMember(Value = @"PER_TIER")]
  PER_TIER = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"WHOLE_BALANCE")]
  WHOLE_BALANCE = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingAccountV2OpenStatus {
  [System.Runtime.Serialization.EnumMember(Value = @"CLOSED")]
  CLOSED = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"OPEN")]
  OPEN = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingAccountV2AccountOwnership {
  [System.Runtime.Serialization.EnumMember(Value = @"UNKNOWN")]
  UNKNOWN = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"ONE_PARTY")]
  ONE_PARTY = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"TWO_PARTY")]
  TWO_PARTY = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"MANY_PARTY")]
  MANY_PARTY = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OTHER")]
  OTHER = 4,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingAccountDetailV3SpecificAccountUType {
  [System.Runtime.Serialization.EnumMember(Value = @"creditCard")]
  CreditCard = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"loan")]
  Loan = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"termDeposit")]
  TermDeposit = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public partial class Features : BankingProductFeatureV2 {
  [Newtonsoft.Json.JsonProperty("isActivated", Required = Newtonsoft.Json.Required.DisallowNull, NullValueHandling = Newtonsoft.Json.NullValueHandling.Ignore)]
  public bool? IsActivated { get; set; } = true;
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingTermDepositAccountMaturityInstructions {
  [System.Runtime.Serialization.EnumMember(Value = @"HOLD_ON_MATURITY")]
  HOLD_ON_MATURITY = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"PAID_OUT_AT_MATURITY")]
  PAID_OUT_AT_MATURITY = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"ROLLED_OVER")]
  ROLLED_OVER = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingLoanAccountV2RepaymentType {
  [System.Runtime.Serialization.EnumMember(Value = @"INTEREST_ONLY")]
  INTEREST_ONLY = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"PRINCIPAL_AND_INTEREST")]
  PRINCIPAL_AND_INTEREST = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingTransactionType {
  [System.Runtime.Serialization.EnumMember(Value = @"DIRECT_DEBIT")]
  DIRECT_DEBIT = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"FEE")]
  FEE = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"INTEREST_CHARGED")]
  INTEREST_CHARGED = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"INTEREST_PAID")]
  INTEREST_PAID = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"OTHER")]
  OTHER = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"PAYMENT")]
  PAYMENT = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_INCOMING")]
  TRANSFER_INCOMING = 6,
  [System.Runtime.Serialization.EnumMember(Value = @"TRANSFER_OUTGOING")]
  TRANSFER_OUTGOING = 7,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingTransactionStatus {
  [System.Runtime.Serialization.EnumMember(Value = @"PENDING")]
  PENDING = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"POSTED")]
  POSTED = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingPayeeV2Type {
  [System.Runtime.Serialization.EnumMember(Value = @"BILLER")]
  BILLER = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"DIGITAL_WALLET")]
  DIGITAL_WALLET = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"DOMESTIC")]
  DOMESTIC = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"INTERNATIONAL")]
  INTERNATIONAL = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingPayeeDetailV2PayeeUType {
  [System.Runtime.Serialization.EnumMember(Value = @"biller")]
  Biller = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"digitalWallet")]
  DigitalWallet = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"domestic")]
  Domestic = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"international")]
  International = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingDomesticPayeePayeeAccountUType {
  [System.Runtime.Serialization.EnumMember(Value = @"account")]
  Account = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"card")]
  Card = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"payId")]
  PayId = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingDomesticPayeePayIdType {
  [System.Runtime.Serialization.EnumMember(Value = @"ABN")]
  ABN = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"EMAIL")]
  EMAIL = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"ORG_IDENTIFIER")]
  ORG_IDENTIFIER = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"TELEPHONE")]
  TELEPHONE = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingDigitalWalletPayeeType {
  [System.Runtime.Serialization.EnumMember(Value = @"EMAIL")]
  EMAIL = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"CONTACT_NAME")]
  CONTACT_NAME = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"TELEPHONE")]
  TELEPHONE = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingDigitalWalletPayeeProvider {
  [System.Runtime.Serialization.EnumMember(Value = @"PAYPAL_AU")]
  PAYPAL_AU = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"OTHER")]
  OTHER = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingScheduledPaymentStatus {
  [System.Runtime.Serialization.EnumMember(Value = @"ACTIVE")]
  ACTIVE = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"INACTIVE")]
  INACTIVE = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"SKIP")]
  SKIP = 2,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingScheduledPaymentToToUType {
  [System.Runtime.Serialization.EnumMember(Value = @"accountId")]
  AccountId = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"biller")]
  Biller = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"domestic")]
  Domestic = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"international")]
  International = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"payeeId")]
  PayeeId = 4,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingScheduledPaymentRecurrenceRecurrenceUType {
  [System.Runtime.Serialization.EnumMember(Value = @"eventBased")]
  EventBased = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"intervalSchedule")]
  IntervalSchedule = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"lastWeekDay")]
  LastWeekDay = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"onceOff")]
  OnceOff = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingScheduledPaymentRecurrenceIntervalScheduleNonBusinessDayTreatment {
  [System.Runtime.Serialization.EnumMember(Value = @"AFTER")]
  AFTER = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"BEFORE")]
  BEFORE = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"ON")]
  ON = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"ONLY")]
  ONLY = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingScheduledPaymentRecurrenceLastWeekdayLastWeekDay {
  [System.Runtime.Serialization.EnumMember(Value = @"FRI")]
  FRI = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"MON")]
  MON = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"SAT")]
  SAT = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"SUN")]
  SUN = 3,
  [System.Runtime.Serialization.EnumMember(Value = @"THU")]
  THU = 4,
  [System.Runtime.Serialization.EnumMember(Value = @"TUE")]
  TUE = 5,
  [System.Runtime.Serialization.EnumMember(Value = @"WED")]
  WED = 6,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingScheduledPaymentRecurrenceLastWeekdayNonBusinessDayTreatment {
  [System.Runtime.Serialization.EnumMember(Value = @"AFTER")]
  AFTER = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"BEFORE")]
  BEFORE = 1,
  [System.Runtime.Serialization.EnumMember(Value = @"ON")]
  ON = 2,
  [System.Runtime.Serialization.EnumMember(Value = @"ONLY")]
  ONLY = 3,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum CommonPhysicalAddressAddressUType {
  [System.Runtime.Serialization.EnumMember(Value = @"paf")]
  Paf = 0,
  [System.Runtime.Serialization.EnumMember(Value = @"simple")]
  Simple = 1,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingTransactionDetail_allOf_extendedDataExtensionUType {
  [System.Runtime.Serialization.EnumMember(Value = @"x2p101Payload")]
  X2p101Payload = 0,
 }
 [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "13.18.2.0 (NJsonSchema v10.8.0.0 (Newtonsoft.Json v13.0.0.0))")]
 public enum BankingTransactionDetail_allOf_extendedDataService {
  [System.Runtime.Serialization.EnumMember(Value = @"X2P1.01")]
  X2P1_01 = 0,
 }
}
#pragma warning restore 1591
#pragma warning restore 1573
#pragma warning restore 472
#pragma warning restore 114
#pragma warning restore 108
#pragma warning restore 3016
#pragma warning restore 8603