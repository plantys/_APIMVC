{
  "openapi": "3.0.3",
  "info": {
    "title": "CDR Banking API",
    "description": "Consumer Data Standards APIs created by the Data Standards Body (DSB), with the Data Standards Chair as the decision maker to meet the needs of the Consumer Data Right",
    "contact": {
      "name": "Consumer Data Standards",
      "url": "https://consumerdatastandards.gov.au",
      "email": "contact@consumerdatastandards.gov.au"
    },
    "license": {
      "name": "MIT License",
      "url": "https://opensource.org/licenses/MIT"
    },
    "version": "1.23.0"
  },
  "servers": [
    {
      "url": "https://data.holder.com.au/cds-au/v1"
    }
  ],
  "paths": {
    "/banking/accounts": {
      "get": {
        "tags": [
          "Banking",
          "Accounts"
        ],
        "summary": "Get Accounts",
        "description": "Obtain a list of accounts.\n\nObsolete versions: [v1](includes/obsolete/get-accounts-v1.html)",
        "operationId": "listAccounts",
        "parameters": [
          {
            "name": "product-category",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.)",
            "schema": {
              "type": "string",
              "enum": [
                "BUSINESS_LOANS",
                "CRED_AND_CHRG_CARDS",
                "LEASES",
                "MARGIN_LOANS",
                "OVERDRAFTS",
                "PERS_LOANS",
                "REGULATED_TRUST_ACCOUNTS",
                "RESIDENTIAL_MORTGAGES",
                "TERM_DEPOSITS",
                "TRADE_FINANCE",
                "TRANS_AND_SAVINGS_ACCOUNTS",
                "TRAVEL_CARDS"
              ]
            }
          },
          {
            "name": "open-status",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed",
            "schema": {
              "type": "string",
              "default": "ALL",
              "enum": [
                "ALL",
                "CLOSED",
                "OPEN"
              ]
            }
          },
          {
            "name": "is-owned",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filters accounts based on whether they are owned by the authorised customer.  True for owned accounts, false for unowned accounts and absent for all accounts",
            "schema": {
              "type": "boolean",
              "x-cds-type": "Boolean"
            },
            "x-cds-type": "Boolean"
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingAccountListV2"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:accounts.basic:read"
        ],
        "x-version": "2"
      }
    },
    "/banking/accounts/balances": {
      "get": {
        "tags": [
          "Banking",
          "Accounts"
        ],
        "summary": "Get Bulk Balances",
        "description": "Obtain balances for multiple, filtered accounts",
        "operationId": "listBalancesBulk",
        "parameters": [
          {
            "name": "product-category",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.",
            "schema": {
              "type": "string",
              "enum": [
                "BUSINESS_LOANS",
                "CRED_AND_CHRG_CARDS",
                "LEASES",
                "MARGIN_LOANS",
                "OVERDRAFTS",
                "PERS_LOANS",
                "REGULATED_TRUST_ACCOUNTS",
                "RESIDENTIAL_MORTGAGES",
                "TERM_DEPOSITS",
                "TRADE_FINANCE",
                "TRANS_AND_SAVINGS_ACCOUNTS",
                "TRAVEL_CARDS"
              ]
            }
          },
          {
            "name": "open-status",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed",
            "schema": {
              "type": "string",
              "default": "ALL",
              "enum": [
                "ALL",
                "CLOSED",
                "OPEN"
              ]
            }
          },
          {
            "name": "is-owned",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filters accounts based on whether they are owned by the authorised customer.  True for owned accounts, false for unowned accounts and absent for all accounts",
            "schema": {
              "type": "boolean",
              "x-cds-type": "Boolean"
            },
            "x-cds-type": "Boolean"
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingAccountsBalanceList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:accounts.basic:read"
        ],
        "x-version": "1"
      },
      "post": {
        "tags": [
          "Banking",
          "Accounts"
        ],
        "summary": "Get Balances For Specific Accounts",
        "description": "Obtain balances for a specified list of accounts",
        "operationId": "listBalancesSpecificAccounts",
        "parameters": [
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "requestBody": {
          "description": "The list of account IDs to obtain balances for",
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/RequestAccountIds"
              }
            }
          },
          "required": true
        },
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingAccountsBalanceList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li><li>[422 - Unavailable Banking Account](#error-422-authorisation-unavailable-banking-account)</li><li>[422 - Invalid Banking Account](#error-422-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:accounts.basic:read"
        ],
        "x-version": "1",
        "x-codegen-request-body-name": "accountIds"
      }
    },
    "/banking/accounts/{accountId}/balance": {
      "get": {
        "tags": [
          "Banking",
          "Accounts"
        ],
        "summary": "Get Account Balance",
        "description": "Obtain the balance for a single specified account",
        "operationId": "getBalance",
        "parameters": [
          {
            "name": "accountId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "ID of the specific account requested",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingAccountsBalanceById"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Banking Account](#error-404-authorisation-unavailable-banking-account)</li><li>[404 - Invalid Banking Account](#error-404-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:accounts.basic:read"
        ],
        "x-version": "1"
      }
    },
    "/banking/accounts/{accountId}": {
      "get": {
        "tags": [
          "Banking",
          "Accounts"
        ],
        "summary": "Get Account Detail",
        "description": "Obtain detailed information on a single account.\n\nObsolete versions: [v1](includes/obsolete/get-account-detail-v1.html), [v2](includes/obsolete/get-account-detail-v2.html)",
        "operationId": "getAccountDetail",
        "parameters": [
          {
            "name": "accountId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "A tokenised identifier for the account which is unique but not shareable",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingAccountByIdV3"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Banking Account](#error-404-authorisation-unavailable-banking-account)</li><li>[404 - Invalid Banking Account](#error-404-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:accounts.detail:read"
        ],
        "x-version": "3"
      }
    },
    "/banking/accounts/{accountId}/transactions": {
      "get": {
        "tags": [
          "Banking",
          "Accounts"
        ],
        "summary": "Get Transactions For Account",
        "description": "Obtain transactions for a specific account.\n\nSome general notes that apply to all end points that retrieve transactions:\n\n- Where multiple transactions are returned, transactions should be ordered according to effective date in descending order\n- As the date and time for a transaction can alter depending on status and transaction type two separate date/times are included in the payload. There are still some scenarios where neither of these time stamps is available. For the purpose of filtering and ordering it is expected that the data holder will use the \"effective\" date/time which will be defined as:\n  - Posted date/time if available, then\n  - Execution date/time if available, then\n  - A reasonable date/time nominated by the data holder using internal data structures\n- For transaction amounts it should be assumed that a negative value indicates a reduction of the available balance on the account while a positive value indicates an increase in the available balance on the account\n- For aggregated transactions (ie. groups of sub transactions reported as a single entry for the account) only the aggregated information, with as much consistent information accross the subsidiary transactions as possible, is required to be shared",
        "operationId": "getTransactions",
        "parameters": [
          {
            "name": "accountId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "ID of the account to get transactions for.  Must have previously been returned by one of the account list end points.",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "oldest-time",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Constrain the transaction history request to transactions with effective time at or after this date/time. If absent defaults to newest-time minus 90 days.  Format is aligned to DateTimeString common type",
            "schema": {
              "type": "string",
              "x-cds-type": "DateTimeString"
            },
            "x-cds-type": "DateTimeString"
          },
          {
            "name": "newest-time",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Constrain the transaction history request to transactions with effective time at or before this date/time.  If absent defaults to today.  Format is aligned to DateTimeString common type",
            "schema": {
              "type": "string",
              "x-cds-type": "DateTimeString"
            },
            "x-cds-type": "DateTimeString"
          },
          {
            "name": "min-amount",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filter transactions to only transactions with amounts higher or equal to than this amount",
            "schema": {
              "type": "string",
              "x-cds-type": "AmountString"
            },
            "x-cds-type": "AmountString"
          },
          {
            "name": "max-amount",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filter transactions to only transactions with amounts less than or equal to than this amount",
            "schema": {
              "type": "string",
              "x-cds-type": "AmountString"
            },
            "x-cds-type": "AmountString"
          },
          {
            "name": "text",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filter transactions to only transactions where this string value is found as a substring of either the reference or description fields. Format is arbitrary ASCII string. This parameter is optionally implemented by data holders. If it is not implemented then a response should be provided as normal without text filtering applied and an additional boolean field named isQueryParamUnsupported should be included in the meta object and set to true (whether the text parameter is supplied or not)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingTransactionList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li><li>[400 - Invalid Date](#error-400-field-invalid-date-time)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Banking Account](#error-404-authorisation-unavailable-banking-account)</li><li>[404 - Invalid Banking Account](#error-404-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:transactions:read"
        ],
        "x-version": "1"
      }
    },
    "/banking/accounts/{accountId}/transactions/{transactionId}": {
      "get": {
        "tags": [
          "Banking",
          "Accounts"
        ],
        "summary": "Get Transaction Detail",
        "description": "Obtain detailed information on a transaction for a specific account",
        "operationId": "getTransactionDetail",
        "parameters": [
          {
            "name": "accountId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "ID of the account to get transactions for.  Must have previously been returned by one of the account list end points",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "transactionId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "ID of the transaction obtained from a previous call to one of the other transaction end points",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingTransactionById"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li><li>[400 - Invalid Date](#error-400-field-invalid-date-time)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Banking Account](#error-404-authorisation-unavailable-banking-account)</li><li>[404 - Invalid Banking Account](#error-404-authorisation-invalid-banking-account)</li><li>[404 - Unavailable Resource](#error-404-resource-unavailable)</li><li>[404 - Invalid Resource](#error-404-resource-invalid)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:transactions:read"
        ],
        "x-version": "1"
      }
    },
    "/banking/accounts/{accountId}/direct-debits": {
      "get": {
        "tags": [
          "Banking",
          "Direct Debits"
        ],
        "summary": "Get Direct Debits For Account",
        "description": "Obtain direct debit authorisations for a specific account",
        "operationId": "listDirectDebits",
        "parameters": [
          {
            "name": "accountId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "ID of the account to get direct debit authorisations for.  Must have previously been returned by one of the account list end points.",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingDirectDebitAuthorisationList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Banking Account](#error-404-authorisation-unavailable-banking-account)</li><li>[404 - Invalid Banking Account](#error-404-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:regular_payments:read"
        ],
        "x-version": "1"
      }
    },
    "/banking/accounts/direct-debits": {
      "get": {
        "tags": [
          "Banking",
          "Direct Debits"
        ],
        "summary": "Get Bulk Direct Debits",
        "description": "Obtain direct debit authorisations for multiple, filtered accounts",
        "operationId": "listDirectDebitsBulk",
        "parameters": [
          {
            "name": "product-category",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.",
            "schema": {
              "type": "string",
              "enum": [
                "BUSINESS_LOANS",
                "CRED_AND_CHRG_CARDS",
                "LEASES",
                "MARGIN_LOANS",
                "OVERDRAFTS",
                "PERS_LOANS",
                "REGULATED_TRUST_ACCOUNTS",
                "RESIDENTIAL_MORTGAGES",
                "TERM_DEPOSITS",
                "TRADE_FINANCE",
                "TRANS_AND_SAVINGS_ACCOUNTS",
                "TRAVEL_CARDS"
              ]
            }
          },
          {
            "name": "open-status",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed",
            "schema": {
              "type": "string",
              "default": "ALL",
              "enum": [
                "ALL",
                "CLOSED",
                "OPEN"
              ]
            }
          },
          {
            "name": "is-owned",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filters accounts based on whether they are owned by the authorised customer.  True for owned accounts, false for unowned accounts and absent for all accounts",
            "schema": {
              "type": "boolean",
              "x-cds-type": "Boolean"
            },
            "x-cds-type": "Boolean"
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingDirectDebitAuthorisationList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:regular_payments:read"
        ],
        "x-version": "1"
      },
      "post": {
        "tags": [
          "Banking",
          "Direct Debits"
        ],
        "summary": "Get Direct Debits For Specific Accounts",
        "description": "Obtain direct debit authorisations for a specified list of accounts",
        "operationId": "listDirectDebitsSpecificAccounts",
        "parameters": [
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "requestBody": {
          "description": "Array of specific accountIds to obtain authorisations for",
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/RequestAccountIds"
              }
            }
          },
          "required": true
        },
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingDirectDebitAuthorisationList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li><li>[422 - Unavailable Banking Account](#error-422-authorisation-unavailable-banking-account)</li><li>[422 - Invalid Banking Account](#error-422-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:regular_payments:read"
        ],
        "x-version": "1",
        "x-codegen-request-body-name": "accountIds"
      }
    },
    "/banking/accounts/{accountId}/payments/scheduled": {
      "get": {
        "tags": [
          "Banking",
          "Scheduled Payments"
        ],
        "summary": "Get Scheduled Payments for Account",
        "description": "Obtain scheduled, outgoing payments for a specific account",
        "operationId": "listScheduledPayments",
        "parameters": [
          {
            "name": "accountId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "ID of the account to get scheduled payments for. Must have previously been returned by one of the account list end points. The account specified is the source account for the payment",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingScheduledPaymentsList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Banking Account](#error-404-authorisation-unavailable-banking-account)</li><li>[404 - Invalid Banking Account](#error-404-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:regular_payments:read"
        ],
        "x-version": "1"
      }
    },
    "/banking/payments/scheduled": {
      "get": {
        "tags": [
          "Banking",
          "Scheduled Payments"
        ],
        "summary": "Get Scheduled Payments Bulk",
        "description": "Obtain scheduled payments for multiple, filtered accounts that are the source of funds for the payments",
        "operationId": "listScheduledPaymentsBulk",
        "parameters": [
          {
            "name": "product-category",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.",
            "schema": {
              "type": "string",
              "enum": [
                "BUSINESS_LOANS",
                "CRED_AND_CHRG_CARDS",
                "LEASES",
                "MARGIN_LOANS",
                "OVERDRAFTS",
                "PERS_LOANS",
                "REGULATED_TRUST_ACCOUNTS",
                "RESIDENTIAL_MORTGAGES",
                "TERM_DEPOSITS",
                "TRADE_FINANCE",
                "TRANS_AND_SAVINGS_ACCOUNTS",
                "TRAVEL_CARDS"
              ]
            }
          },
          {
            "name": "open-status",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed",
            "schema": {
              "type": "string",
              "default": "ALL",
              "enum": [
                "ALL",
                "CLOSED",
                "OPEN"
              ]
            }
          },
          {
            "name": "is-owned",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filters accounts based on whether they are owned by the authorised customer.  True for owned accounts, false for unowned accounts and absent for all accounts",
            "schema": {
              "type": "boolean",
              "x-cds-type": "Boolean"
            },
            "x-cds-type": "Boolean"
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingScheduledPaymentsList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:regular_payments:read"
        ],
        "x-version": "1"
      },
      "post": {
        "tags": [
          "Banking",
          "Scheduled Payments"
        ],
        "summary": "Get Scheduled Payments For Specific Accounts",
        "description": "Obtain scheduled payments for a specified list of accounts",
        "operationId": "listScheduledPaymentsSpecificAccounts",
        "parameters": [
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "requestBody": {
          "description": "Array of specific accountIds to obtain scheduled payments for.  The accounts specified are the source of funds for the payments returned",
          "content": {
            "application/json": {
              "schema": {
                "$ref": "#/components/schemas/RequestAccountIds"
              }
            }
          },
          "required": true
        },
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingScheduledPaymentsList"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li><li>[422 - Unavailable Banking Account](#error-422-authorisation-unavailable-banking-account)</li><li>[422 - Invalid Banking Account](#error-422-authorisation-invalid-banking-account)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:regular_payments:read"
        ],
        "x-version": "1",
        "x-codegen-request-body-name": "accountIds"
      }
    },
    "/banking/payees": {
      "get": {
        "tags": [
          "Banking",
          "Payees"
        ],
        "summary": "Get Payees",
        "description": "Obtain a list of pre-registered payees.\n\nObsolete versions: [v1](includes/obsolete/get-payees-v1.html)",
        "operationId": "listPayees",
        "parameters": [
          {
            "name": "type",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filter on the payee type field.  In addition to normal type field values, ALL can be specified to retrieve all payees.  If absent the assumed value is ALL",
            "schema": {
              "type": "string",
              "default": "ALL",
              "enum": [
                "ALL",
                "BILLER",
                "DIGITAL_WALLET",
                "DOMESTIC",
                "INTERNATIONAL"
              ]
            }
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingPayeeListV2"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:payees:read"
        ],
        "x-version": "2"
      }
    },
    "/banking/payees/{payeeId}": {
      "get": {
        "tags": [
          "Banking",
          "Payees"
        ],
        "summary": "Get Payee Detail",
        "description": "Obtain detailed information on a single payee.\n\nNote that the payee sub-structure should be selected to represent the payment destination only rather than any known characteristics of the payment recipient.\n\nObsolete versions: [v1](includes/obsolete/get-payee-detail-v1.html)",
        "operationId": "getPayeeDetail",
        "parameters": [
          {
            "name": "payeeId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "The ID used to locate the details of a particular payee",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-interaction-id",
            "in": "header",
            "style": "simple",
            "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-fapi-auth-date",
            "in": "header",
            "style": "simple",
            "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true
            },
            "x-conditional": true
          },
          {
            "name": "x-fapi-customer-ip-address",
            "in": "header",
            "style": "simple",
            "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-cds-client-headers",
            "in": "header",
            "style": "simple",
            "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
            "schema": {
              "type": "string",
              "x-conditional": true,
              "x-cds-type": "Base64"
            },
            "x-conditional": true,
            "x-cds-type": "Base64"
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              },
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingPayeeByIdV2"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Resource](#error-404-resource-unavailable)</li><li>[404 - Invalid Resource](#error-404-resource-invalid)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "headers": {
              "x-fapi-interaction-id": {
                "style": "simple",
                "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-scopes": [
          "bank:payees:read"
        ],
        "x-version": "2"
      }
    },
    "/banking/products": {
      "get": {
        "tags": [
          "Banking",
          "Products"
        ],
        "summary": "Get Products",
        "description": "Obtain a list of products that are currently openly offered to the market\n\nNote that the results returned by this end point are expected to be ordered in descending order according to ``lastUpdated``.\n\n### Conventions\nIn the product reference payloads there are a number of recurring conventions that are explained here, in one place.\n\n#### Arrays Of Features\n\nIn the product detail payload there are a number of arrays articulating generic features, constraints, prices, etc. The intent of these arrays is as follows:\n\n- Each element in an array has the same structure so that clients can reliably interpret the payloads\n- Each element as a type element that is an enumeration of the specific aspect of a product being described, such as types of fees.\n- Each element has a field name [additionalValue](#productfeaturetypedoc).  This is a generic field with contents that will vary based on the type of object being described. The contents of this field for the ADDITIONAL_CARDS feature is the number of cards allowed while the contents of this field for the MAX_LIMIT constraint would be the maximum credit limit allowed for the product.\n- An element in these arrays of the same type may appear more than once. For instance, a product may offer two separate loyalty programs that the customer can select from. A fixed term mortgage may have different rates for different term lengths.\n- An element in these arrays may contain an additionalInfo and additionalInfoUri field. The additionalInfo field is used to provide displayable text clarifying the purpose of the element in some way when the product is presented to a customer. The additionalInfoUri provides a link to externally hosted information specifically relevant to that feature of the product.\n- Depending on the type of data being represented there may be additional specific fields.\n\n#### URIs To More Information\n\nAs the complexities and nuances of a financial product can not easily be fully expressed in a data structure without a high degree of complexity it is necessary to provide additional reference information that a potential customer can access so that they are fully informed of the features and implications of the product. The payloads for product reference therefore contain numerous fields that are provided to allow the product holder to describe the product more fully using a web page hosted on their online channels.\n\nThese URIs do not need to all link to different pages. If desired, they can all link to a single hosted page and use difference HTML anchors to focus on a specific topic such as eligibility or fees.\n\n#### Linkage To Accounts\nFrom the moment that a customer applies for a product and an account is created the account and the product that spawned it will diverge.  Rates and features of the product may change and a discount may be negotiated for the account.\n\nFor this reason, while productCategory is a common field between accounts and products, there is no specific ID that can be used to link an account to a product within the regime.\n\nSimilarly, many of the fields and objects in the product payload will appear in the account detail payload but the structures and semantics are not identical as one refers to a product that can potentially be originated and one refers to an account that actual has been instantiated and created along with the associated decisions inherent in that process.\n\n#### Dates\nIt is expected that data consumers needing this data will call relatively frequently to ensure the data they have is representative of the current offering from a bank.  To minimise the volume and frequency of these calls the ability to set a lastUpdated field with the date and time of the last update to this product is included.  A call for a list of products can then be filtered to only return products that have been updated since the last time that data was obtained using the updated-since query parameter.\n\nIn addition, the concept of effective date and time has also been included.  This allows for a product to be marked for obsolescence, or introduction, from a certain time without the need for an update to show that a product has been changed.  The inclusion of these dates also removes the need to represent deleted products in the payload.  Products that are no long offered can be marked not effective for a few weeks before they are then removed from the product set as an option entirely.\n\nObsolete versions: [v1](includes/obsolete/get-products-v1.html) [v2](includes/obsolete/get-products-v2.html)",
        "operationId": "listProducts",
        "parameters": [
          {
            "name": "effective",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Allows for the filtering of products based on whether the current time is within the period of time defined as effective by the effectiveFrom and effectiveTo fields. Valid values are ‘CURRENT’, ‘FUTURE’ and ‘ALL’. If absent defaults to 'CURRENT'",
            "schema": {
              "type": "string",
              "default": "CURRENT",
              "enum": [
                "ALL",
                "CURRENT",
                "FUTURE"
              ]
            }
          },
          {
            "name": "updated-since",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Only include products that have been updated after the specified date and time. If absent defaults to include all products",
            "schema": {
              "type": "string",
              "x-cds-type": "DateTimeString"
            },
            "x-cds-type": "DateTimeString"
          },
          {
            "name": "brand",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Filter results based on a specific brand",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "product-category",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.",
            "schema": {
              "type": "string",
              "enum": [
                "BUSINESS_LOANS",
                "CRED_AND_CHRG_CARDS",
                "LEASES",
                "MARGIN_LOANS",
                "OVERDRAFTS",
                "PERS_LOANS",
                "REGULATED_TRUST_ACCOUNTS",
                "RESIDENTIAL_MORTGAGES",
                "TERM_DEPOSITS",
                "TRADE_FINANCE",
                "TRANS_AND_SAVINGS_ACCOUNTS",
                "TRAVEL_CARDS"
              ]
            }
          },
          {
            "name": "page",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page of results to request (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 1,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "page-size",
            "in": "query",
            "style": "form",
            "explode": true,
            "description": "Page size to request. Default is 25 (standard pagination)",
            "schema": {
              "type": "integer",
              "default": 25,
              "x-cds-type": "PositiveInteger"
            },
            "x-cds-type": "PositiveInteger"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingProductListV2"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Date](#error-400-field-invalid-date-time)</li><li>[400 - Invalid Page Size](#error-400-field-invalid-page-size)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "422": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[422 - Invalid Page](#error-422-field-invalid-page)</li></ul>",
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-version": "3"
      }
    },
    "/banking/products/{productId}": {
      "get": {
        "tags": [
          "Banking",
          "Products"
        ],
        "summary": "Get Product Detail",
        "description": "Obtain detailed information on a single product offered openly to the market.\n\nObsolete versions: [v1](includes/obsolete/get-product-detail-v1.html) [v2](includes/obsolete/get-product-detail-v2.html) [v3](includes/obsolete/get-product-detail-v3.html)",
        "operationId": "getProductDetail",
        "parameters": [
          {
            "name": "productId",
            "in": "path",
            "style": "simple",
            "required": true,
            "description": "ID of the specific product requested",
            "schema": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            },
            "x-cds-type": "ASCIIString"
          },
          {
            "name": "x-v",
            "in": "header",
            "style": "simple",
            "required": true,
            "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
            "schema": {
              "type": "string"
            }
          },
          {
            "name": "x-min-v",
            "in": "header",
            "style": "simple",
            "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
            "schema": {
              "type": "string"
            }
          }
        ],
        "responses": {
          "200": {
            "description": "Success",
            "headers": {
              "x-v": {
                "style": "simple",
                "description": "The [version](#response-headers) of the API end point that the data holder has responded with.",
                "schema": {
                  "type": "string"
                }
              }
            },
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseBankingProductByIdV4"
                }
              }
            }
          },
          "400": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[400 - Invalid Field](#error-400-field-invalid)</li><li>[400 - Invalid Version](#error-400-header-invalid-version)</li></ul>",
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "404": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[404 - Unavailable Resource](#error-404-resource-unavailable)</li><li>[404 - Invalid Resource](#error-404-resource-invalid)</li></ul>",
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          },
          "406": {
            "description": "The following error codes MUST be supported:<br/><ul class=\"error-code-list\"><li>[406 - Unsupported Version](#error-406-header-unsupported-version)</li></ul>",
            "content": {
              "application/json": {
                "schema": {
                  "$ref": "#/components/schemas/ResponseErrorListV2"
                }
              }
            }
          }
        },
        "x-version": "4"
      }
    }
  },
  "components": {
    "schemas": {
      "RequestAccountIds": {
        "type": "object",
        "required": [
          "data"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/RequestAccountIds_data"
          },
          "meta": {
            "$ref": "#/components/schemas/Meta"
          }
        }
      },
      "ResponseBankingProductListV2": {
        "type": "object",
        "required": [
          "data",
          "links",
          "meta"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/ResponseBankingProductListV2_data"
          },
          "links": {
            "$ref": "#/components/schemas/LinksPaginated"
          },
          "meta": {
            "$ref": "#/components/schemas/MetaPaginated"
          }
        }
      },
      "BankingProductV4": {
        "type": "object",
        "required": [
          "brand",
          "description",
          "isTailored",
          "lastUpdated",
          "name",
          "productCategory",
          "productId"
        ],
        "properties": {
          "productId": {
            "type": "string",
            "description": "A data holder specific unique identifier for this product. This identifier must be unique to a product but does not otherwise need to adhere to ID permanence guidelines.",
            "x-cds-type": "ASCIIString"
          },
          "effectiveFrom": {
            "type": "string",
            "description": "The date and time from which this product is effective (ie. is available for origination).  Used to enable the articulation of products to the regime before they are available for customers to originate",
            "x-cds-type": "DateTimeString"
          },
          "effectiveTo": {
            "type": "string",
            "description": "The date and time at which this product will be retired and will no longer be offered.  Used to enable the managed deprecation of products",
            "x-cds-type": "DateTimeString"
          },
          "lastUpdated": {
            "type": "string",
            "description": "The last date and time that the information for this product was changed (or the creation date for the product if it has never been altered)",
            "x-cds-type": "DateTimeString"
          },
          "productCategory": {
            "$ref": "#/components/schemas/BankingProductCategory"
          },
          "name": {
            "type": "string",
            "description": "The display name of the product"
          },
          "description": {
            "type": "string",
            "description": "A description of the product"
          },
          "brand": {
            "type": "string",
            "description": "A label of the brand for the product. Able to be used for filtering. For data holders with single brands this value is still required"
          },
          "brandName": {
            "type": "string",
            "description": "An optional display name of the brand"
          },
          "applicationUri": {
            "type": "string",
            "description": "A link to an application web page where this product can be applied for.",
            "x-cds-type": "URIString"
          },
          "isTailored": {
            "type": "boolean",
            "description": "Indicates whether the product is specifically tailored to a circumstance.  In this case fees and prices are significantly negotiated depending on context. While all products are open to a degree of tailoring this flag indicates that tailoring is expected and thus that the provision of specific fees and rates is not applicable",
            "x-cds-type": "Boolean"
          },
          "additionalInformation": {
            "$ref": "#/components/schemas/BankingProductAdditionalInformationV2"
          },
          "cardArt": {
            "type": "array",
            "description": "An array of card art images",
            "items": {
              "$ref": "#/components/schemas/BankingProductV4_cardArt"
            }
          }
        }
      },
      "BankingProductAdditionalInformationV2": {
        "type": "object",
        "description": "Object that contains links to additional information on specific topics",
        "properties": {
          "overviewUri": {
            "type": "string",
            "description": "General overview of the product. Mandatory if `additionalOverviewUris` includes one or more supporting documents.",
            "x-cds-type": "URIString"
          },
          "termsUri": {
            "type": "string",
            "description": "Terms and conditions for the product. Mandatory if `additionalTermsUris` includes one or more supporting documents.",
            "x-cds-type": "URIString"
          },
          "eligibilityUri": {
            "type": "string",
            "description": "Eligibility rules and criteria for the product. Mandatory if `additionalEligibilityUris` includes one or more supporting documents.",
            "x-cds-type": "URIString"
          },
          "feesAndPricingUri": {
            "type": "string",
            "description": "Description of fees, pricing, discounts, exemptions and bonuses for the product. Mandatory if `additionalFeesAndPricingUris` includes one or more supporting documents.",
            "x-cds-type": "URIString"
          },
          "bundleUri": {
            "type": "string",
            "description": "Description of a bundle that this product can be part of. Mandatory if `additionalBundleUris` includes one or more supporting documents.",
            "x-cds-type": "URIString"
          },
          "additionalOverviewUris": {
            "type": "array",
            "description": "An array of additional general overviews for the product or features of the product, if applicable. To be treated as secondary documents to the `overviewUri`. Only to be used if there is a primary `overviewUri`.",
            "items": {
              "$ref": "#/components/schemas/BankingProductAdditionalInformationV2_additionalInformationUris"
            }
          },
          "additionalTermsUris": {
            "type": "array",
            "description": "An array of additional terms and conditions for the product, if applicable. To be treated as secondary documents to the `termsUri`. Only to be used if there is a primary `termsUri`.",
            "items": {
              "$ref": "#/components/schemas/BankingProductAdditionalInformationV2_additionalInformationUris"
            }
          },
          "additionalEligibilityUris": {
            "type": "array",
            "description": "An array of additional eligibility rules and criteria for the product, if applicable. To be treated as secondary documents to the `eligibilityUri`. Only to be used if there is a primary `eligibilityUri`.",
            "items": {
              "$ref": "#/components/schemas/BankingProductAdditionalInformationV2_additionalInformationUris"
            }
          },
          "additionalFeesAndPricingUris": {
            "type": "array",
            "description": "An array of additional fees, pricing, discounts, exemptions and bonuses for the product, if applicable. To be treated as secondary documents to the `feesAndPricingUri`. Only to be used if there is a primary `feesAndPricingUri`.",
            "items": {
              "$ref": "#/components/schemas/BankingProductAdditionalInformationV2_additionalInformationUris"
            }
          },
          "additionalBundleUris": {
            "type": "array",
            "description": "An array of additional bundles for the product, if applicable. To be treated as secondary documents to the `bundleUri`. Only to be used if there is a primary `bundleUri`.",
            "items": {
              "$ref": "#/components/schemas/BankingProductAdditionalInformationV2_additionalInformationUris"
            }
          }
        },
        "x-conditional": [
          "overviewUri",
          "termsUri",
          "eligibilityUri",
          "feesAndPricingUri",
          "bundleUri"
        ]
      },
      "BankingProductAdditionalInformationV2_additionalInformationUris": {
        "type": "object",
        "required": [
          "additionalInfoUri"
        ],
        "properties": {
          "description": {
            "type": "string",
            "description": "Display text providing more information about the document URI"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "The URI describing the additional information",
            "x-cds-type": "URIString"
          }
        }
      },
      "ResponseBankingProductByIdV4": {
        "type": "object",
        "required": [
          "data",
          "links"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/BankingProductDetailV4"
          },
          "links": {
            "$ref": "#/components/schemas/Links"
          },
          "meta": {
            "$ref": "#/components/schemas/Meta"
          }
        }
      },
      "BankingProductDetailV4": {
        "allOf": [
          {
            "$ref": "#/components/schemas/BankingProductV4"
          },
          {
            "$ref": "#/components/schemas/BankingProductDetailV4_allOf"
          }
        ]
      },
      "BankingProductBundle": {
        "type": "object",
        "required": [
          "description",
          "name"
        ],
        "properties": {
          "name": {
            "type": "string",
            "description": "Name of the bundle"
          },
          "description": {
            "type": "string",
            "description": "Description of the bundle"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the bundle"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on the bundle criteria and benefits",
            "x-cds-type": "URIString"
          },
          "productIds": {
            "type": "array",
            "description": "Array of product IDs for products included in the bundle that are available via the product end points.  Note that this array is not intended to represent a comprehensive model of the products included in the bundle and some products available for the bundle may not be available via the product reference end points",
            "items": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            }
          }
        }
      },
      "BankingProductFeatureV2": {
        "type": "object",
        "required": [
          "featureType"
        ],
        "properties": {
          "featureType": {
            "type": "string",
            "description": "The type of feature described",
            "enum": [
              "ADDITIONAL_CARDS",
              "BALANCE_TRANSFERS",
              "BILL_PAYMENT",
              "BONUS_REWARDS",
              "CARD_ACCESS",
              "CASHBACK_OFFER",
              "COMPLEMENTARY_PRODUCT_DISCOUNTS",
              "DIGITAL_BANKING",
              "DIGITAL_WALLET",
              "DONATE_INTEREST",
              "EXTRA_REPAYMENTS",
              "FRAUD_PROTECTION",
              "FREE_TXNS",
              "FREE_TXNS_ALLOWANCE",
              "GUARANTOR",
              "INSURANCE",
              "INSTALMENT_PLAN",
              "INTEREST_FREE",
              "INTEREST_FREE_TRANSFERS",
              "LOYALTY_PROGRAM",
              "NOTIFICATIONS",
              "NPP_ENABLED",
              "NPP_PAYID",
              "OFFSET",
              "OTHER",
              "OVERDRAFT",
              "REDRAW",
              "RELATIONSHIP_MANAGEMENT",
              "UNLIMITED_TXNS"
            ]
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [featureType](#tocSproductfeaturetypedoc) specified. Whether mandatory or not is dependent on the value of the [featureType.](#tocSproductfeaturetypedoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the feature. Mandatory if the [feature type](#tocSproductfeaturetypedoc) is set to OTHER"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this feature",
            "x-cds-type": "URIString"
          }
        },
        "x-conditional": [
          "additionalValue",
          "additionalInfo"
        ]
      },
      "BankingProductConstraint": {
        "type": "object",
        "required": [
          "constraintType"
        ],
        "properties": {
          "constraintType": {
            "type": "string",
            "description": "The type of constraint described.  See the next section for an overview of valid values and their meaning",
            "enum": [
              "MAX_BALANCE",
              "MAX_LIMIT",
              "MIN_BALANCE",
              "MIN_LIMIT",
              "OPENING_BALANCE"
            ]
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [constraintType](#tocSproductconstrainttypedoc) specified.  Whether mandatory or not is dependent on the value of [constraintType](#tocSproductconstrainttypedoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information the constraint"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on the constraint",
            "x-cds-type": "URIString"
          }
        },
        "x-conditional": [
          "additionalValue"
        ]
      },
      "BankingProductEligibility": {
        "type": "object",
        "required": [
          "eligibilityType"
        ],
        "properties": {
          "eligibilityType": {
            "type": "string",
            "description": "The type of eligibility criteria described.  See the next section for an overview of valid values and their meaning",
            "enum": [
              "BUSINESS",
              "EMPLOYMENT_STATUS",
              "MAX_AGE",
              "MIN_AGE",
              "MIN_INCOME",
              "MIN_TURNOVER",
              "NATURAL_PERSON",
              "OTHER",
              "PENSION_RECIPIENT",
              "RESIDENCY_STATUS",
              "STAFF",
              "STUDENT"
            ]
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [eligibilityType](#tocSproducteligibilitytypedoc) specified. Whether mandatory or not is dependent on the value of [eligibilityType](#tocSproducteligibilitytypedoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the [eligibility](#tocSproducteligibilitytypedoc) criteria. Mandatory if the field is set to OTHER"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this eligibility criteria",
            "x-cds-type": "URIString"
          }
        },
        "x-conditional": [
          "additionalValue",
          "additionalInfo"
        ]
      },
      "BankingProductFee": {
        "type": "object",
        "required": [
          "feeType",
          "name"
        ],
        "properties": {
          "name": {
            "type": "string",
            "description": "Name of the fee"
          },
          "feeType": {
            "type": "string",
            "description": "The type of fee",
            "enum": [
              "DEPOSIT",
              "EVENT",
              "EXIT",
              "PAYMENT",
              "PERIODIC",
              "PURCHASE",
              "TRANSACTION",
              "UPFRONT",
              "VARIABLE",
              "WITHDRAWAL"
            ]
          },
          "amount": {
            "type": "string",
            "description": "The amount charged for the fee. One of amount, balanceRate, transactionRate and accruedRate is mandatory unless the *feeType* \"VARIABLE\" is supplied",
            "x-cds-type": "AmountString"
          },
          "balanceRate": {
            "type": "string",
            "description": "A fee rate calculated based on a proportion of the balance. One of amount, balanceRate, transactionRate and accruedRate is mandatory unless the *feeType* \"VARIABLE\" is supplied.",
            "x-cds-type": "RateString"
          },
          "transactionRate": {
            "type": "string",
            "description": "A fee rate calculated based on a proportion of a transaction. One of amount, balanceRate, transactionRate and accruedRate is mandatory unless the *feeType* \"VARIABLE\" is supplied",
            "x-cds-type": "RateString"
          },
          "accruedRate": {
            "type": "string",
            "description": "A fee rate calculated based on a proportion of the calculated interest accrued on the account. One of amount, balanceRate, transactionRate and accruedRate is mandatory unless the *feeType* \"VARIABLE\" is supplied",
            "x-cds-type": "RateString"
          },
          "accrualFrequency": {
            "type": "string",
            "description": "The indicative frequency with which the fee is calculated on the account. Only applies if balanceRate or accruedRate is also present. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)",
            "x-cds-type": "ExternalRef"
          },
          "currency": {
            "type": "string",
            "description": "The currency the fee will be charged in. Assumes AUD if absent",
            "x-cds-type": "CurrencyString"
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [feeType](#tocSproductfeetypedoc) specified. Whether mandatory or not is dependent on the value of [feeType](#tocSproductfeetypedoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the fee"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this fee",
            "x-cds-type": "URIString"
          },
          "discounts": {
            "type": "array",
            "description": "An optional list of discounts to this fee that may be available",
            "items": {
              "$ref": "#/components/schemas/BankingProductDiscount"
            }
          }
        },
        "x-conditional": [
          "additionalValue",
          "amount",
          "balanceRate",
          "transactionRate",
          "accruedRate"
        ]
      },
      "BankingProductDiscount": {
        "type": "object",
        "required": [
          "description",
          "discountType"
        ],
        "properties": {
          "description": {
            "type": "string",
            "description": "Description of the discount"
          },
          "discountType": {
            "type": "string",
            "description": "The type of discount. See the next section for an overview of valid values and their meaning",
            "enum": [
              "BALANCE",
              "DEPOSITS",
              "ELIGIBILITY_ONLY",
              "FEE_CAP",
              "PAYMENTS"
            ]
          },
          "amount": {
            "type": "string",
            "description": "Dollar value of the discount. One of amount, balanceRate, transactionRate, accruedRate and feeRate is mandatory.",
            "x-cds-type": "AmountString"
          },
          "balanceRate": {
            "type": "string",
            "description": "A discount rate calculated based on a proportion of the balance. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate, accruedRate and feeRate is mandatory. Unless noted in additionalInfo, assumes the application and calculation frequency are the same as the corresponding fee",
            "x-cds-type": "RateString"
          },
          "transactionRate": {
            "type": "string",
            "description": "A discount rate calculated based on a proportion of a transaction. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate, accruedRate and feeRate is mandatory",
            "x-cds-type": "RateString"
          },
          "accruedRate": {
            "type": "string",
            "description": "A discount rate calculated based on a proportion of the calculated interest accrued on the account. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate, accruedRate and feeRate is mandatory. Unless noted in additionalInfo, assumes the application and calculation frequency are the same as the corresponding fee",
            "x-cds-type": "RateString"
          },
          "feeRate": {
            "type": "string",
            "description": "A discount rate calculated based on a proportion of the fee to which this discount is attached. Note that the currency of the fee discount is expected to be the same as the currency of the fee itself. One of amount, balanceRate, transactionRate, accruedRate and feeRate is mandatory. Unless noted in additionalInfo, assumes the application and calculation frequency are the same as the corresponding fee",
            "x-cds-type": "RateString"
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [discountType](#tocSproductdiscounttypedoc) specified. Whether mandatory or not is dependent on the value of [discountType](#tocSproductdiscounttypedoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the discount"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this discount",
            "x-cds-type": "URIString"
          },
          "eligibility": {
            "type": "array",
            "description": "Eligibility constraints that apply to this discount. Mandatory if ``discountType`` is ``ELIGIBILITY_ONLY``.",
            "items": {
              "$ref": "#/components/schemas/BankingProductDiscountEligibility"
            }
          }
        },
        "x-conditional": [
          "accruedRate",
          "additionalValue",
          "amount",
          "balanceRate",
          "eligibility",
          "feeRate",
          "transactionRate"
        ]
      },
      "BankingProductDiscountEligibility": {
        "type": "object",
        "required": [
          "discountEligibilityType"
        ],
        "properties": {
          "discountEligibilityType": {
            "type": "string",
            "description": "The type of the specific eligibility constraint for a discount",
            "enum": [
              "BUSINESS",
              "EMPLOYMENT_STATUS",
              "INTRODUCTORY",
              "MAX_AGE",
              "MIN_AGE",
              "MIN_INCOME",
              "MIN_TURNOVER",
              "NATURAL_PERSON",
              "OTHER",
              "PENSION_RECIPIENT",
              "RESIDENCY_STATUS",
              "STAFF",
              "STUDENT"
            ]
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [discountEligibilityType](#tocSproductdiscounteligibilitydoc) specified. Whether mandatory or not is dependent on the value of [discountEligibilityType](#tocSproductdiscounteligibilitydoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on this eligibility constraint. Whether mandatory or not is dependent on the value of [discountEligibilityType](#tocSproductdiscounteligibilitydoc)"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this eligibility constraint",
            "x-cds-type": "URIString"
          }
        },
        "x-conditional": [
          "additionalInfo",
          "additionalValue"
        ]
      },
      "BankingProductDepositRate": {
        "type": "object",
        "required": [
          "depositRateType",
          "rate"
        ],
        "properties": {
          "depositRateType": {
            "type": "string",
            "description": "The type of rate (base, bonus, etc). See the next section for an overview of valid values and their meaning",
            "enum": [
              "BONUS",
              "BUNDLE_BONUS",
              "FIXED",
              "FLOATING",
              "INTRODUCTORY",
              "MARKET_LINKED",
              "VARIABLE"
            ]
          },
          "rate": {
            "type": "string",
            "description": "The rate to be applied",
            "x-cds-type": "RateString"
          },
          "calculationFrequency": {
            "type": "string",
            "description": "The period after which the rate is applied to the balance to calculate the amount due for the period. Calculation of the amount is often daily (as balances may change) but accumulated until the total amount is 'applied' to the account (see applicationFrequency). Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)",
            "x-cds-type": "ExternalRef"
          },
          "applicationFrequency": {
            "type": "string",
            "description": "The period after which the calculated amount(s) (see calculationFrequency) are 'applied' (i.e. debited or credited) to the account. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)",
            "x-cds-type": "ExternalRef"
          },
          "tiers": {
            "type": "array",
            "description": "Rate tiers applicable for this rate",
            "items": {
              "$ref": "#/components/schemas/BankingProductRateTierV3"
            }
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [depositRateType](#tocSproductdepositratetypedoc) specified. Whether mandatory or not is dependent on the value of [depositRateType](#tocSproductdepositratetypedoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the rate"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this rate",
            "x-cds-type": "URIString"
          }
        },
        "x-conditional": [
          "additionalValue"
        ]
      },
      "BankingProductLendingRateV2": {
        "type": "object",
        "required": [
          "lendingRateType",
          "rate"
        ],
        "properties": {
          "lendingRateType": {
            "type": "string",
            "description": "The type of rate (fixed, variable, etc). See the next section for an overview of valid values and their meaning",
            "enum": [
              "BUNDLE_DISCOUNT_FIXED",
              "BUNDLE_DISCOUNT_VARIABLE",
              "CASH_ADVANCE",
              "DISCOUNT",
              "FIXED",
              "FLOATING",
              "INTRODUCTORY",
              "MARKET_LINKED",
              "PENALTY",
              "PURCHASE",
              "VARIABLE"
            ]
          },
          "rate": {
            "type": "string",
            "description": "The rate to be applied",
            "x-cds-type": "RateString"
          },
          "comparisonRate": {
            "type": "string",
            "description": "A comparison rate equivalent for this rate",
            "x-cds-type": "RateString"
          },
          "calculationFrequency": {
            "type": "string",
            "description": "The period after which the rate is applied to the balance to calculate the amount due for the period. Calculation of the amount is often daily (as balances may change) but accumulated until the total amount is 'applied' to the account (see applicationFrequency). Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)",
            "x-cds-type": "ExternalRef"
          },
          "applicationFrequency": {
            "type": "string",
            "description": "The period after which the calculated amount(s) (see calculationFrequency) are 'applied' (i.e. debited or credited) to the account. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)",
            "x-cds-type": "ExternalRef"
          },
          "interestPaymentDue": {
            "type": "string",
            "description": "When loan payments are due to be paid within each period. The investment benefit of earlier payments affect the rate that can be offered",
            "enum": [
              "IN_ADVANCE",
              "IN_ARREARS"
            ]
          },
          "repaymentType": {
            "type": "string",
            "description": "Options in place for repayments. If absent, the lending rate is applicable to all repayment types",
            "enum": [
              "INTEREST_ONLY",
              "PRINCIPAL_AND_INTEREST"
            ]
          },
          "loanPurpose": {
            "type": "string",
            "description": "The reason for taking out the loan. If absent, the lending rate is applicable to all loan purposes",
            "enum": [
              "INVESTMENT",
              "OWNER_OCCUPIED"
            ]
          },
          "tiers": {
            "type": "array",
            "description": "Rate tiers applicable for this rate",
            "items": {
              "$ref": "#/components/schemas/BankingProductRateTierV3"
            }
          },
          "additionalValue": {
            "type": "string",
            "description": "Generic field containing additional information relevant to the [lendingRateType](#tocSproductlendingratetypedoc) specified. Whether mandatory or not is dependent on the value of [lendingRateType](#tocSproductlendingratetypedoc)"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the rate."
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this rate",
            "x-cds-type": "URIString"
          }
        },
        "x-conditional": [
          "additionalValue"
        ]
      },
      "BankingProductRateTierV3": {
        "type": "object",
        "description": "Defines the criteria and conditions for which a rate applies",
        "required": [
          "minimumValue",
          "name",
          "unitOfMeasure"
        ],
        "properties": {
          "name": {
            "type": "string",
            "description": "A display name for the tier"
          },
          "unitOfMeasure": {
            "type": "string",
            "description": "The unit of measure that applies to the tierValueMinimum and tierValueMaximum values e.g. a **DOLLAR** amount. **PERCENT** (in the case of loan-to-value ratio or LVR). Tier term period representing a discrete number of **MONTH**'s or **DAY**'s (in the case of term deposit tiers)",
            "enum": [
              "DAY",
              "DOLLAR",
              "MONTH",
              "PERCENT"
            ]
          },
          "minimumValue": {
            "type": "number",
            "description": "The number of tierUnitOfMeasure units that form the lower bound of the tier. The tier should be inclusive of this value",
            "x-cds-type": "Number"
          },
          "maximumValue": {
            "type": "number",
            "description": "The number of tierUnitOfMeasure units that form the upper bound of the tier or band. For a tier with a discrete value (as opposed to a range of values e.g. 1 month) this must be the same as tierValueMinimum. Where this is the same as the tierValueMinimum value of the next-higher tier the referenced tier should be exclusive of this value. For example a term deposit of 2 months falls into the upper tier of the following tiers: (1 – 2 months, 2 – 3 months). If absent the tier's range has no upper bound.",
            "x-cds-type": "Number"
          },
          "rateApplicationMethod": {
            "type": "string",
            "description": "The method used to calculate the amount to be applied using one or more tiers. A single rate may be applied to the entire balance or each applicable tier rate is applied to the portion of the balance that falls into that tier (referred to as 'bands' or 'steps')",
            "enum": [
              "PER_TIER",
              "WHOLE_BALANCE"
            ]
          },
          "applicabilityConditions": {
            "$ref": "#/components/schemas/BankingProductRateCondition"
          },
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the rate tier."
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this rate tier",
            "x-cds-type": "URIString"
          }
        }
      },
      "BankingProductRateCondition": {
        "type": "object",
        "description": "Defines a condition for the applicability of a tiered rate",
        "properties": {
          "additionalInfo": {
            "type": "string",
            "description": "Display text providing more information on the condition"
          },
          "additionalInfoUri": {
            "type": "string",
            "description": "Link to a web page with more information on this condition",
            "x-cds-type": "URIString"
          }
        }
      },
      "ResponseBankingAccountListV2": {
        "type": "object",
        "required": [
          "data",
          "links",
          "meta"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/ResponseBankingAccountListV2_data"
          },
          "links": {
            "$ref": "#/components/schemas/LinksPaginated"
          },
          "meta": {
            "$ref": "#/components/schemas/MetaPaginated"
          }
        }
      },
      "BankingAccountV2": {
        "type": "object",
        "required": [
          "accountId",
          "accountOwnership",
          "displayName",
          "maskedNumber",
          "productCategory",
          "productName"
        ],
        "properties": {
          "accountId": {
            "type": "string",
            "description": "A unique ID of the account adhering to the standards for ID permanence",
            "x-cds-type": "ASCIIString"
          },
          "creationDate": {
            "type": "string",
            "description": "Date that the account was created (if known)",
            "x-cds-type": "DateString"
          },
          "displayName": {
            "type": "string",
            "description": "The display name of the account as defined by the bank. This should not incorporate account numbers or PANs. If it does the values should be masked according to the rules of the MaskedAccountString common type."
          },
          "nickname": {
            "type": "string",
            "description": "A customer supplied nick name for the account"
          },
          "openStatus": {
            "type": "string",
            "description": "Open or closed status for the account. If not present then OPEN is assumed",
            "default": "OPEN",
            "enum": [
              "CLOSED",
              "OPEN"
            ]
          },
          "isOwned": {
            "type": "boolean",
            "description": "Flag indicating that the customer associated with the authorisation is an owner of the account. Does not indicate sole ownership, however. If not present then 'true' is assumed",
            "default": true,
            "x-cds-type": "Boolean"
          },
          "accountOwnership": {
            "type": "string",
            "description": "Value indicating the number of customers that have ownership of the account, according to the data holder's definition of account ownership. Does not indicate that all account owners are eligible consumers",
            "enum": [
              "UNKNOWN",
              "ONE_PARTY",
              "TWO_PARTY",
              "MANY_PARTY",
              "OTHER"
            ]
          },
          "maskedNumber": {
            "type": "string",
            "description": "A masked version of the account. Whether BSB/Account Number, Credit Card PAN or another number",
            "x-cds-type": "MaskedAccountString"
          },
          "productCategory": {
            "$ref": "#/components/schemas/BankingProductCategory"
          },
          "productName": {
            "type": "string",
            "description": "The unique identifier of the account as defined by the data holder (akin to model number for the account)"
          }
        }
      },
      "ResponseBankingAccountByIdV3": {
        "type": "object",
        "required": [
          "data",
          "links"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/BankingAccountDetailV3"
          },
          "links": {
            "$ref": "#/components/schemas/Links"
          },
          "meta": {
            "$ref": "#/components/schemas/Meta"
          }
        }
      },
      "BankingAccountDetailV3": {
        "allOf": [
          {
            "$ref": "#/components/schemas/BankingAccountV2"
          },
          {
            "$ref": "#/components/schemas/BankingAccountDetailV3_allOf"
          }
        ]
      },
      "BankingTermDepositAccount": {
        "type": "object",
        "required": [
          "lodgementDate",
          "maturityDate",
          "maturityInstructions"
        ],
        "properties": {
          "lodgementDate": {
            "type": "string",
            "description": "The lodgement date of the original deposit",
            "x-cds-type": "DateString"
          },
          "maturityDate": {
            "type": "string",
            "description": "Maturity date for the term deposit",
            "x-cds-type": "DateString"
          },
          "maturityAmount": {
            "type": "string",
            "description": "Amount to be paid upon maturity. If absent it implies the amount to paid is variable and cannot currently be calculated",
            "x-cds-type": "AmountString"
          },
          "maturityCurrency": {
            "type": "string",
            "description": "If absent assumes AUD",
            "x-cds-type": "CurrencyString"
          },
          "maturityInstructions": {
            "type": "string",
            "description": "Current instructions on action to be taken at maturity. This includes default actions that may be specified in the terms and conditions for the product e.g. roll-over to the same term and frequency of interest payments",
            "enum": [
              "HOLD_ON_MATURITY",
              "PAID_OUT_AT_MATURITY",
              "ROLLED_OVER"
            ]
          }
        }
      },
      "BankingCreditCardAccount": {
        "type": "object",
        "required": [
          "minPaymentAmount",
          "paymentDueAmount",
          "paymentDueDate"
        ],
        "properties": {
          "minPaymentAmount": {
            "type": "string",
            "description": "The minimum payment amount due for the next card payment",
            "x-cds-type": "AmountString"
          },
          "paymentDueAmount": {
            "type": "string",
            "description": "The amount due for the next card payment",
            "x-cds-type": "AmountString"
          },
          "paymentCurrency": {
            "type": "string",
            "description": "If absent assumes AUD",
            "x-cds-type": "CurrencyString"
          },
          "paymentDueDate": {
            "type": "string",
            "description": "Date that the next payment for the card is due",
            "x-cds-type": "DateString"
          }
        }
      },
      "BankingLoanAccountV2": {
        "type": "object",
        "properties": {
          "originalStartDate": {
            "type": "string",
            "description": "Optional original start date for the loan",
            "x-cds-type": "DateString"
          },
          "originalLoanAmount": {
            "type": "string",
            "description": "Optional original loan value",
            "x-cds-type": "AmountString"
          },
          "originalLoanCurrency": {
            "type": "string",
            "description": "If absent assumes AUD",
            "x-cds-type": "CurrencyString"
          },
          "loanEndDate": {
            "type": "string",
            "description": "Date that the loan is due to be repaid in full",
            "x-cds-type": "DateString"
          },
          "nextInstalmentDate": {
            "type": "string",
            "description": "Next date that an instalment is required",
            "x-cds-type": "DateString"
          },
          "minInstalmentAmount": {
            "type": "string",
            "description": "Minimum amount of next instalment",
            "x-cds-type": "AmountString"
          },
          "minInstalmentCurrency": {
            "type": "string",
            "description": "If absent assumes AUD",
            "x-cds-type": "CurrencyString"
          },
          "maxRedraw": {
            "type": "string",
            "description": "Maximum amount of funds that can be redrawn. If not present redraw is not available even if the feature exists for the account",
            "x-cds-type": "AmountString"
          },
          "maxRedrawCurrency": {
            "type": "string",
            "description": "If absent assumes AUD",
            "x-cds-type": "CurrencyString"
          },
          "minRedraw": {
            "type": "string",
            "description": "Minimum redraw amount",
            "x-cds-type": "AmountString"
          },
          "minRedrawCurrency": {
            "type": "string",
            "description": "If absent assumes AUD",
            "x-cds-type": "CurrencyString"
          },
          "offsetAccountEnabled": {
            "type": "boolean",
            "description": "Set to true if one or more offset accounts are configured for this loan account",
            "x-cds-type": "Boolean"
          },
          "offsetAccountIds": {
            "type": "array",
            "description": "The accountIDs of the configured offset accounts attached to this loan. Only offset accounts that can be accessed under the current authorisation should be included. It is expected behaviour that offsetAccountEnabled is set to true but the offsetAccountIds field is absent or empty. This represents a situation where an offset account exists but details can not be accessed under the current authorisation",
            "items": {
              "type": "string",
              "x-cds-type": "ASCIIString"
            }
          },
          "repaymentType": {
            "type": "string",
            "description": "Options in place for repayments. If absent defaults to PRINCIPAL_AND_INTEREST",
            "default": "PRINCIPAL_AND_INTEREST",
            "enum": [
              "INTEREST_ONLY",
              "PRINCIPAL_AND_INTEREST"
            ]
          },
          "repaymentFrequency": {
            "type": "string",
            "description": "The expected or required repayment frequency. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax)",
            "x-cds-type": "ExternalRef"
          }
        }
      },
      "ResponseBankingTransactionList": {
        "type": "object",
        "required": [
          "data",
          "links",
          "meta"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/ResponseBankingTransactionList_data"
          },
          "links": {
            "$ref": "#/components/schemas/LinksPaginated"
          },
          "meta": {
            "$ref": "#/components/schemas/MetaPaginated"
          }
        }
      },
      "BankingTransaction": {
        "type": "object",
        "required": [
          "accountId",
          "amount",
          "description",
          "isDetailAvailable",
          "reference",
          "status",
          "type"
        ],
        "properties": {
          "accountId": {
            "type": "string",
            "description": "ID of the account for which transactions are provided",
            "x-cds-type": "ASCIIString"
          },
          "transactionId": {
            "type": "string",
            "description": "A unique ID of the transaction adhering to the standards for ID permanence.  This is mandatory (through hashing if necessary) unless there are specific and justifiable technical reasons why a transaction cannot be uniquely identified for a particular account type. It is mandatory if `isDetailAvailable` is set to true.",
            "x-cds-type": "ASCIIString"
          },
          "isDetailAvailable": {
            "type": "boolean",
            "description": "True if extended information is available using the transaction detail end point. False if extended data is not available",
            "x-cds-type": "Boolean"
          },
          "type": {
            "type": "string",
            "description": "The type of the transaction",
            "enum": [
              "DIRECT_DEBIT",
              "FEE",
              "INTEREST_CHARGED",
              "INTEREST_PAID",
              "OTHER",
              "PAYMENT",
              "TRANSFER_INCOMING",
              "TRANSFER_OUTGOING"
            ]
          },
          "status": {
            "type": "string",
            "description": "Status of the transaction whether pending or posted. Note that there is currently no provision in the standards to guarantee the ability to correlate a pending transaction with an associated posted transaction",
            "enum": [
              "PENDING",
              "POSTED"
            ]
          },
          "description": {
            "type": "string",
            "description": "The transaction description as applied by the financial institution"
          },
          "postingDateTime": {
            "type": "string",
            "description": "The time the transaction was posted. This field is Mandatory if the transaction has status POSTED.  This is the time that appears on a standard statement",
            "x-cds-type": "DateTimeString"
          },
          "valueDateTime": {
            "type": "string",
            "description": "Date and time at which assets become available to the account owner in case of a credit entry, or cease to be available to the account owner in case of a debit transaction entry",
            "x-cds-type": "DateTimeString"
          },
          "executionDateTime": {
            "type": "string",
            "description": "The time the transaction was executed by the originating customer, if available",
            "x-cds-type": "DateTimeString"
          },
          "amount": {
            "type": "string",
            "description": "The value of the transaction. Negative values mean money was outgoing from the account",
            "x-cds-type": "AmountString"
          },
          "currency": {
            "type": "string",
            "description": "The currency for the transaction amount. AUD assumed if not present",
            "x-cds-type": "CurrencyString"
          },
          "reference": {
            "type": "string",
            "description": "The reference for the transaction provided by the originating institution. Empty string if no data provided"
          },
          "merchantName": {
            "type": "string",
            "description": "Name of the merchant for an outgoing payment to a merchant"
          },
          "merchantCategoryCode": {
            "type": "string",
            "description": "The merchant category code (or MCC) for an outgoing payment to a merchant"
          },
          "billerCode": {
            "type": "string",
            "description": "BPAY Biller Code for the transaction (if available)"
          },
          "billerName": {
            "type": "string",
            "description": "Name of the BPAY biller for the transaction (if available)"
          },
          "crn": {
            "type": "string",
            "description": "BPAY CRN for the transaction (if available).<br/>Where the CRN contains sensitive information, it should be masked in line with how the Data Holder currently displays account identifiers in their existing online banking channels. If the contents of the CRN match the format of a Credit Card PAN they should be masked according to the rules applicable for MaskedPANString. If the contents are are otherwise sensitive, then it should be masked using the rules applicable for the MaskedAccountString common type."
          },
          "apcaNumber": {
            "type": "string",
            "description": "6 Digit APCA number for the initiating institution. The field is fixed-width and padded with leading zeros if applicable."
          }
        },
        "x-conditional": [
          "transactionId",
          "postingDateTime",
          "crn"
        ]
      },
      "ResponseBankingTransactionById": {
        "type": "object",
        "required": [
          "data",
          "links"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/BankingTransactionDetail"
          },
          "links": {
            "$ref": "#/components/schemas/Links"
          },
          "meta": {
            "$ref": "#/components/schemas/Meta"
          }
        }
      },
      "BankingTransactionDetail": {
        "allOf": [
          {
            "$ref": "#/components/schemas/BankingTransaction"
          },
          {
            "$ref": "#/components/schemas/BankingTransactionDetail_allOf"
          }
        ]
      },
      "ResponseBankingAccountsBalanceList": {
        "type": "object",
        "required": [
          "data",
          "links",
          "meta"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/ResponseBankingAccountsBalanceList_data"
          },
          "links": {
            "$ref": "#/components/schemas/LinksPaginated"
          },
          "meta": {
            "$ref": "#/components/schemas/MetaPaginated"
          }
        }
      },
      "ResponseBankingAccountsBalanceById": {
        "type": "object",
        "required": [
          "data",
          "links"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/BankingBalance"
          },
          "links": {
            "$ref": "#/components/schemas/Links"
          },
          "meta": {
            "$ref": "#/components/schemas/Meta"
          }
        }
      },
      "BankingBalance": {
        "type": "object",
        "required": [
          "accountId",
          "availableBalance",
          "currentBalance"
        ],
        "properties": {
          "accountId": {
            "type": "string",
            "description": "A unique ID of the account adhering to the standards for ID permanence",
            "x-cds-type": "ASCIIString"
          },
          "currentBalance": {
            "type": "string",
            "description": "The balance of the account at this time. Should align to the balance available via other channels such as Internet Banking. Assumed to be negative if the customer has money owing",
            "x-cds-type": "AmountString"
          },
          "availableBalance": {
            "type": "string",
            "description": "Balance representing the amount of funds available for transfer. Assumed to be zero or positive",
            "x-cds-type": "AmountString"
          },
          "creditLimit": {
            "type": "string",
            "description": "Object representing the maximum amount of credit that is available for this account. Assumed to be zero if absent",
            "x-cds-type": "AmountString"
          },
          "amortisedLimit": {
            "type": "string",
            "description": "Object representing the available limit amortised according to payment schedule. Assumed to be zero if absent",
            "x-cds-type": "AmountString"
          },
          "currency": {
            "type": "string",
            "description": "The currency for the balance amounts. If absent assumed to be AUD",
            "x-cds-type": "CurrencyString"
          },
          "purses": {
            "type": "array",
            "description": "Optional array of balances for the account in other currencies. Included to support accounts that support multi-currency purses such as Travel Cards",
            "items": {
              "$ref": "#/components/schemas/BankingBalancePurse"
            }
          }
        }
      },
      "BankingBalancePurse": {
        "type": "object",
        "required": [
          "amount"
        ],
        "properties": {
          "amount": {
            "type": "string",
            "description": "The balance available for this additional currency purse",
            "x-cds-type": "AmountString"
          },
          "currency": {
            "type": "string",
            "description": "The currency for the purse",
            "x-cds-type": "CurrencyString"
          }
        }
      },
      "ResponseBankingPayeeListV2": {
        "type": "object",
        "required": [
          "data",
          "links",
          "meta"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/ResponseBankingPayeeListV2_data"
          },
          "links": {
            "$ref": "#/components/schemas/LinksPaginated"
          },
          "meta": {
            "$ref": "#/components/schemas/MetaPaginated"
          }
        }
      },
      "ResponseBankingPayeeByIdV2": {
        "type": "object",
        "required": [
          "data",
          "links"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/BankingPayeeDetailV2"
          },
          "links": {
            "$ref": "#/components/schemas/Links"
          },
          "meta": {
            "$ref": "#/components/schemas/Meta"
          }
        }
      },
      "BankingPayeeV2": {
        "type": "object",
        "required": [
          "nickname",
          "payeeId",
          "type"
        ],
        "properties": {
          "payeeId": {
            "type": "string",
            "description": "ID of the payee adhering to the rules of ID permanence",
            "x-cds-type": "ASCIIString"
          },
          "nickname": {
            "type": "string",
            "description": "The short display name of the payee as provided by the customer. Where a customer has not provided a nickname, a display name derived by the bank for the payee consistent with existing digital banking channels"
          },
          "description": {
            "type": "string",
            "description": "A description of the payee provided by the customer"
          },
          "type": {
            "type": "string",
            "description": "The type of payee.<br/>DOMESTIC means a registered payee for domestic payments including NPP. <br/>INTERNATIONAL means a registered payee for international payments. <br/>BILLER means a registered payee for BPAY. <br/>DIGITAL_WALLET means a registered payee for a bank's digital wallet",
            "enum": [
              "BILLER",
              "DIGITAL_WALLET",
              "DOMESTIC",
              "INTERNATIONAL"
            ]
          },
          "creationDate": {
            "type": "string",
            "description": "The date the payee was created by the customer",
            "x-cds-type": "DateString"
          }
        }
      },
      "BankingPayeeDetailV2": {
        "allOf": [
          {
            "$ref": "#/components/schemas/BankingPayeeV2"
          },
          {
            "$ref": "#/components/schemas/BankingPayeeDetailV2_allOf"
          }
        ]
      },
      "BankingDomesticPayee": {
        "type": "object",
        "required": [
          "payeeAccountUType"
        ],
        "properties": {
          "payeeAccountUType": {
            "type": "string",
            "description": "Type of account object included. Valid values are: **account** A standard Australian account defined by BSB/Account Number. **card** A credit or charge card to pay to (note that PANs are masked). **payId** A PayID recognised by NPP",
            "enum": [
              "account",
              "card",
              "payId"
            ]
          },
          "account": {
            "$ref": "#/components/schemas/BankingDomesticPayeeAccount"
          },
          "card": {
            "$ref": "#/components/schemas/BankingDomesticPayeeCard"
          },
          "payId": {
            "$ref": "#/components/schemas/BankingDomesticPayeePayId"
          }
        },
        "x-conditional": [
          "account",
          "card",
          "payId"
        ]
      },
      "BankingDomesticPayeeAccount": {
        "type": "object",
        "required": [
          "accountNumber",
          "bsb"
        ],
        "properties": {
          "accountName": {
            "type": "string",
            "description": "Name of the account to pay to"
          },
          "bsb": {
            "type": "string",
            "description": "BSB of the account to pay to"
          },
          "accountNumber": {
            "type": "string",
            "description": "Number of the account to pay to"
          }
        }
      },
      "BankingDomesticPayeeCard": {
        "type": "object",
        "required": [
          "cardNumber"
        ],
        "properties": {
          "cardNumber": {
            "type": "string",
            "description": "Name of the account to pay to",
            "x-cds-type": "MaskedPANString"
          }
        }
      },
      "BankingDomesticPayeePayId": {
        "type": "object",
        "required": [
          "identifier",
          "type"
        ],
        "properties": {
          "name": {
            "type": "string",
            "description": "The name assigned to the PayID by the owner of the PayID"
          },
          "identifier": {
            "type": "string",
            "description": "The identifier of the PayID (dependent on type)"
          },
          "type": {
            "type": "string",
            "description": "The type of the PayID",
            "enum": [
              "ABN",
              "EMAIL",
              "ORG_IDENTIFIER",
              "TELEPHONE"
            ]
          }
        }
      },
      "BankingBillerPayee": {
        "type": "object",
        "required": [
          "billerCode",
          "billerName"
        ],
        "properties": {
          "billerCode": {
            "type": "string",
            "description": "BPAY Biller Code of the Biller"
          },
          "crn": {
            "type": "string",
            "description": "BPAY CRN of the Biller (if available).<br/>Where the CRN contains sensitive information, it should be masked in line with how the Data Holder currently displays account identifiers in their existing online banking channels. If the contents of the CRN match the format of a Credit Card PAN they should be masked according to the rules applicable for MaskedPANString. If the contents are are otherwise sensitive, then it should be masked using the rules applicable for the MaskedAccountString common type."
          },
          "billerName": {
            "type": "string",
            "description": "Name of the Biller"
          }
        },
        "x-conditional": [
          "crn"
        ]
      },
      "BankingInternationalPayee": {
        "type": "object",
        "required": [
          "bankDetails",
          "beneficiaryDetails"
        ],
        "properties": {
          "beneficiaryDetails": {
            "$ref": "#/components/schemas/BankingInternationalPayee_beneficiaryDetails"
          },
          "bankDetails": {
            "$ref": "#/components/schemas/BankingInternationalPayee_bankDetails"
          }
        }
      },
      "BankingDigitalWalletPayee": {
        "type": "object",
        "required": [
          "identifier",
          "name",
          "provider",
          "type"
        ],
        "properties": {
          "name": {
            "type": "string",
            "description": "The name assigned to the digital wallet by the owner of the wallet, else the display name provided by the digital wallet provider"
          },
          "identifier": {
            "type": "string",
            "description": "The identifier of the digital wallet (dependent on type)"
          },
          "type": {
            "type": "string",
            "description": "The type of the digital wallet identifier",
            "enum": [
              "EMAIL",
              "CONTACT_NAME",
              "TELEPHONE"
            ]
          },
          "provider": {
            "type": "string",
            "description": "The provider of the digital wallet",
            "enum": [
              "PAYPAL_AU",
              "OTHER"
            ]
          }
        }
      },
      "ResponseBankingDirectDebitAuthorisationList": {
        "type": "object",
        "required": [
          "data",
          "links",
          "meta"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/ResponseBankingDirectDebitAuthorisationList_data"
          },
          "links": {
            "$ref": "#/components/schemas/LinksPaginated"
          },
          "meta": {
            "$ref": "#/components/schemas/MetaPaginated"
          }
        }
      },
      "BankingDirectDebit": {
        "type": "object",
        "required": [
          "accountId",
          "authorisedEntity"
        ],
        "properties": {
          "accountId": {
            "type": "string",
            "description": "A unique ID of the account adhering to the standards for ID permanence.",
            "x-cds-type": "ASCIIString"
          },
          "authorisedEntity": {
            "$ref": "#/components/schemas/BankingAuthorisedEntity"
          },
          "lastDebitDateTime": {
            "type": "string",
            "description": "The date and time of the last debit executed under this authorisation",
            "x-cds-type": "DateTimeString"
          },
          "lastDebitAmount": {
            "type": "string",
            "description": "The amount of the last debit executed under this authorisation",
            "x-cds-type": "AmountString"
          }
        }
      },
      "BankingAuthorisedEntity": {
        "type": "object",
        "properties": {
          "description": {
            "type": "string",
            "description": "Description of the authorised entity derived from previously executed direct debits"
          },
          "financialInstitution": {
            "type": "string",
            "description": "Name of the financial institution through which the direct debit will be executed. Is required unless the payment is made via a credit card scheme"
          },
          "abn": {
            "type": "string",
            "description": "Australian Business Number for the authorised entity"
          },
          "acn": {
            "type": "string",
            "description": "Australian Company Number for the authorised entity"
          },
          "arbn": {
            "type": "string",
            "description": "Australian Registered Body Number for the authorised entity"
          }
        },
        "x-conditional": [
          "financialInstitution"
        ]
      },
      "ResponseBankingScheduledPaymentsList": {
        "type": "object",
        "required": [
          "data",
          "links",
          "meta"
        ],
        "properties": {
          "data": {
            "$ref": "#/components/schemas/ResponseBankingScheduledPaymentsList_data"
          },
          "links": {
            "$ref": "#/components/schemas/LinksPaginated"
          },
          "meta": {
            "$ref": "#/components/schemas/MetaPaginated"
          }
        }
      },
      "BankingScheduledPayment": {
        "type": "object",
        "required": [
          "from",
          "payerReference",
          "paymentSet",
          "recurrence",
          "scheduledPaymentId",
          "status"
        ],
        "properties": {
          "scheduledPaymentId": {
            "type": "string",
            "description": "A unique ID of the scheduled payment adhering to the standards for ID permanence",
            "x-cds-type": "ASCIIString"
          },
          "nickname": {
            "type": "string",
            "description": "The short display name of the scheduled payment as provided by the customer if provided. Where a customer has not provided a nickname, a display name derived by the bank for the scheduled payment should be provided that is consistent with existing digital banking channels"
          },
          "payerReference": {
            "type": "string",
            "description": "The reference for the transaction that will be used by the originating institution for the purposes of constructing a statement narrative on the payer’s account. Empty string if no data provided"
          },
          "payeeReference": {
            "type": "string",
            "description": "The reference for the transaction, if applicable, that will be provided by the originating institution for all payments in the payment set. Empty string if no data provided"
          },
          "status": {
            "type": "string",
            "description": "Indicates whether the schedule is currently active. The value SKIP is equivalent to ACTIVE except that the customer has requested the next normal occurrence to be skipped.",
            "enum": [
              "ACTIVE",
              "INACTIVE",
              "SKIP"
            ]
          },
          "from": {
            "$ref": "#/components/schemas/BankingScheduledPaymentFrom"
          },
          "paymentSet": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/BankingScheduledPaymentSet"
            }
          },
          "recurrence": {
            "$ref": "#/components/schemas/BankingScheduledPaymentRecurrence"
          }
        },
        "x-conditional": [
          "payeeReference"
        ]
      },
      "BankingScheduledPaymentSet": {
        "type": "object",
        "description": "The set of payment amounts and destination accounts for this payment accommodating multi-part payments. A single entry indicates a simple payment with one destination account. Must have at least one entry",
        "required": [
          "to"
        ],
        "properties": {
          "to": {
            "$ref": "#/components/schemas/BankingScheduledPaymentTo"
          },
          "isAmountCalculated": {
            "type": "boolean",
            "description": "Flag indicating whether the amount of the payment is calculated based on the context of the event. For instance a payment to reduce the balance of a credit card to zero. If absent then false is assumed",
            "x-cds-type": "Boolean"
          },
          "amount": {
            "type": "string",
            "description": "The amount of the next payment if known. Mandatory unless the isAmountCalculated field is set to true. Must be zero or positive if present",
            "x-cds-type": "AmountString"
          },
          "currency": {
            "type": "string",
            "description": "The currency for the payment. AUD assumed if not present",
            "x-cds-type": "CurrencyString"
          }
        },
        "x-conditional": [
          "amount"
        ]
      },
      "BankingScheduledPaymentTo": {
        "type": "object",
        "description": "Object containing details of the destination of the payment. Used to specify a variety of payment destination types",
        "required": [
          "toUType"
        ],
        "properties": {
          "toUType": {
            "type": "string",
            "description": "The type of object provided that specifies the destination of the funds for the payment.",
            "enum": [
              "accountId",
              "biller",
              "domestic",
              "international",
              "payeeId"
            ]
          },
          "accountId": {
            "type": "string",
            "description": "Present if toUType is set to accountId. Indicates that the payment is to another account that is accessible under the current consent",
            "x-cds-type": "ASCIIString"
          },
          "payeeId": {
            "type": "string",
            "description": "Present if toUType is set to payeeId. Indicates that the payment is to registered payee that can be accessed using the payee end point. If the Bank Payees scope has not been consented to then a payeeId should not be provided and the full payee details should be provided instead",
            "x-cds-type": "ASCIIString"
          },
          "nickname": {
            "type": "string",
            "description": "The short display name of the payee as provided by the customer unless toUType is set to payeeId. Where a customer has not provided a nickname, a display name derived by the bank for payee should be provided that is consistent with existing digital banking channels"
          },
          "payeeReference": {
            "type": "string",
            "description": "The reference for the transaction, if applicable, that will be provided by the originating institution for the specific payment. If not empty, it overrides the value provided at the BankingScheduledPayment level."
          },
          "domestic": {
            "$ref": "#/components/schemas/BankingDomesticPayee"
          },
          "biller": {
            "$ref": "#/components/schemas/BankingBillerPayee"
          },
          "international": {
            "$ref": "#/components/schemas/BankingInternationalPayee"
          }
        },
        "x-conditional": [
          "accountId",
          "payeeId",
          "domestic",
          "biller",
          "international",
          "nickname",
          "payeeReference"
        ]
      },
      "BankingScheduledPaymentFrom": {
        "type": "object",
        "description": "Object containing details of the source of the payment. Currently only specifies an account ID but provided as an object to facilitate future extensibility and consistency with the to object",
        "required": [
          "accountId"
        ],
        "properties": {
          "accountId": {
            "type": "string",
            "description": "ID of the account that is the source of funds for the payment",
            "x-cds-type": "ASCIIString"
          }
        }
      },
      "BankingScheduledPaymentRecurrence": {
        "type": "object",
        "description": "Object containing the detail of the schedule for the payment",
        "required": [
          "recurrenceUType"
        ],
        "properties": {
          "nextPaymentDate": {
            "type": "string",
            "description": "The date of the next payment under the recurrence schedule",
            "x-cds-type": "DateString"
          },
          "recurrenceUType": {
            "type": "string",
            "description": "The type of recurrence used to define the schedule",
            "enum": [
              "eventBased",
              "intervalSchedule",
              "lastWeekDay",
              "onceOff"
            ]
          },
          "onceOff": {
            "$ref": "#/components/schemas/BankingScheduledPaymentRecurrenceOnceOff"
          },
          "intervalSchedule": {
            "$ref": "#/components/schemas/BankingScheduledPaymentRecurrenceIntervalSchedule"
          },
          "lastWeekDay": {
            "$ref": "#/components/schemas/BankingScheduledPaymentRecurrenceLastWeekday"
          },
          "eventBased": {
            "$ref": "#/components/schemas/BankingScheduledPaymentRecurrenceEventBased"
          }
        },
        "x-conditional": [
          "onceOff",
          "intervalSchedule",
          "lastWeekDay",
          "eventBased"
        ]
      },
      "BankingScheduledPaymentRecurrenceOnceOff": {
        "type": "object",
        "description": "Indicates that the payment is a once off payment on a specific future date. Mandatory if recurrenceUType is set to onceOff",
        "required": [
          "paymentDate"
        ],
        "properties": {
          "paymentDate": {
            "type": "string",
            "description": "The scheduled date for the once off payment",
            "x-cds-type": "DateString"
          }
        }
      },
      "BankingScheduledPaymentRecurrenceIntervalSchedule": {
        "type": "object",
        "description": "Indicates that the schedule of payments is defined by a series of intervals. Mandatory if recurrenceUType is set to intervalSchedule",
        "required": [
          "intervals"
        ],
        "properties": {
          "finalPaymentDate": {
            "type": "string",
            "description": "The limit date after which no more payments should be made using this schedule. If both finalPaymentDate and paymentsRemaining are present then payments will stop according to the most constraining value. If neither field is present the payments will continue indefinitely",
            "x-cds-type": "DateString"
          },
          "paymentsRemaining": {
            "type": "integer",
            "description": "Indicates the number of payments remaining in the schedule. If both finalPaymentDate and paymentsRemaining are present then payments will stop according to the most constraining value, If neither field is present the payments will continue indefinitely",
            "example": 1,
            "x-cds-type": "PositiveInteger"
          },
          "nonBusinessDayTreatment": {
            "type": "string",
            "description": "Enumerated field giving the treatment where a scheduled payment date is not a business day. If absent assumed to be ON.<br/>**AFTER** - If a scheduled payment date is a non-business day the payment will be made on the first business day after the scheduled payment date.<br/>**BEFORE** - If a scheduled payment date is a non-business day the payment will be made on the first business day before the scheduled payment date.<br/>**ON** - If a scheduled payment date is a non-business day the payment will be made on that day regardless.<br/>**ONLY** - Payments only occur on business days. If a scheduled payment date is a non-business day the payment will be ignored",
            "default": "ON",
            "enum": [
              "AFTER",
              "BEFORE",
              "ON",
              "ONLY"
            ]
          },
          "intervals": {
            "type": "array",
            "description": "An array of interval objects defining the payment schedule.  Each entry in the array is additive, in that it adds payments to the overall payment schedule.  If multiple intervals result in a payment on the same day then only one payment will be made. Must have at least one entry",
            "items": {
              "$ref": "#/components/schemas/BankingScheduledPaymentInterval"
            }
          }
        }
      },
      "BankingScheduledPaymentInterval": {
        "type": "object",
        "required": [
          "interval"
        ],
        "properties": {
          "interval": {
            "type": "string",
            "description": "An interval for the payment. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations)  (excludes recurrence syntax) with components less than a day in length ignored. This duration defines the period between payments starting with nextPaymentDate",
            "x-cds-type": "ExternalRef"
          },
          "dayInInterval": {
            "type": "string",
            "description": "Uses an interval to define the ordinal day within the interval defined by the interval field on which the payment occurs. If the resulting duration is 0 days in length or larger than the number of days in the interval then the payment will occur on the last day of the interval. A duration of 1 day indicates the first day of the interval. If absent the assumed value is P1D. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) with components less than a day in length ignored. The first day of a week is considered to be Monday.",
            "x-cds-type": "ExternalRef"
          }
        }
      },
      "BankingScheduledPaymentRecurrenceLastWeekday": {
        "type": "object",
        "description": "Indicates that the schedule of payments is defined according to the last occurrence of a specific weekday in an interval. Mandatory if recurrenceUType is set to lastWeekDay",
        "required": [
          "interval",
          "lastWeekDay"
        ],
        "properties": {
          "finalPaymentDate": {
            "type": "string",
            "description": "The limit date after which no more payments should be made using this schedule. If both finalPaymentDate and paymentsRemaining are present then payments will stop according to the most constraining value. If neither field is present the payments will continue indefinitely",
            "x-cds-type": "DateString"
          },
          "paymentsRemaining": {
            "type": "integer",
            "description": "Indicates the number of payments remaining in the schedule. If both finalPaymentDate and paymentsRemaining are present then payments will stop according to the most constraining value. If neither field is present the payments will continue indefinitely",
            "example": 1,
            "x-cds-type": "PositiveInteger"
          },
          "interval": {
            "type": "string",
            "description": "The interval for the payment. Formatted according to [ISO 8601 Durations](https://en.wikipedia.org/wiki/ISO_8601#Durations) (excludes recurrence syntax) with components less than a day in length ignored. This duration defines the period between payments starting with nextPaymentDate",
            "x-cds-type": "ExternalRef"
          },
          "lastWeekDay": {
            "type": "string",
            "description": "The weekDay specified. The payment will occur on the last occurrence of this weekday in the interval.",
            "enum": [
              "FRI",
              "MON",
              "SAT",
              "SUN",
              "THU",
              "TUE",
              "WED"
            ]
          },
          "nonBusinessDayTreatment": {
            "type": "string",
            "description": "Enumerated field giving the treatment where a scheduled payment date is not a business day. If absent assumed to be ON.<br/>**AFTER** - If a scheduled payment date is a non-business day the payment will be made on the first business day after the scheduled payment date.<br/>**BEFORE** - If a scheduled payment date is a non-business day the payment will be made on the first business day before the scheduled payment date.<br/>**ON** - If a scheduled payment date is a non-business day the payment will be made on that day regardless.<br/>**ONLY** - Payments only occur on business days. If a scheduled payment date is a non-business day the payment will be ignored",
            "default": "ON",
            "enum": [
              "AFTER",
              "BEFORE",
              "ON",
              "ONLY"
            ]
          }
        }
      },
      "BankingScheduledPaymentRecurrenceEventBased": {
        "type": "object",
        "description": "Indicates that the schedule of payments is defined according to an external event that cannot be predetermined. Mandatory if recurrenceUType is set to eventBased",
        "required": [
          "description"
        ],
        "properties": {
          "description": {
            "type": "string",
            "description": "Description of the event and conditions that will result in the payment. Expected to be formatted for display to a customer"
          }
        }
      },
      "CommonPhysicalAddress": {
        "type": "object",
        "required": [
          "addressUType"
        ],
        "properties": {
          "addressUType": {
            "type": "string",
            "description": "The type of address object present",
            "enum": [
              "paf",
              "simple"
            ]
          },
          "simple": {
            "$ref": "#/components/schemas/CommonSimpleAddress"
          },
          "paf": {
            "$ref": "#/components/schemas/CommonPAFAddress"
          }
        },
        "x-conditional": [
          "simple",
          "paf"
        ]
      },
      "CommonSimpleAddress": {
        "type": "object",
        "required": [
          "addressLine1",
          "city",
          "state"
        ],
        "properties": {
          "mailingName": {
            "type": "string",
            "description": "Name of the individual or business formatted for inclusion in an address used for physical mail"
          },
          "addressLine1": {
            "type": "string",
            "description": "First line of the standard address object"
          },
          "addressLine2": {
            "type": "string",
            "description": "Second line of the standard address object"
          },
          "addressLine3": {
            "type": "string",
            "description": "Third line of the standard address object"
          },
          "postcode": {
            "type": "string",
            "description": "Mandatory for Australian addresses"
          },
          "city": {
            "type": "string",
            "description": "Name of the city or locality"
          },
          "state": {
            "type": "string",
            "description": "Free text if the country is not Australia. If country is Australia then must be one of the values defined by the [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf) in the PAF file format. NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT"
          },
          "country": {
            "type": "string",
            "description": "A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code. Australia (AUS) is assumed if country is not present.",
            "default": "AUS",
            "x-cds-type": "ExternalRef"
          }
        },
        "x-conditional": [
          "postcode"
        ]
      },
      "CommonPAFAddress": {
        "type": "object",
        "description": "Australian address formatted according to the file format defined by the [PAF file format](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf)",
        "required": [
          "localityName",
          "postcode",
          "state"
        ],
        "properties": {
          "dpid": {
            "type": "string",
            "description": "Unique identifier for an address as defined by Australia Post.  Also known as Delivery Point Identifier"
          },
          "thoroughfareNumber1": {
            "type": "integer",
            "description": "Thoroughfare number for a property (first number in a property ranged address)",
            "x-cds-type": "PositiveInteger"
          },
          "thoroughfareNumber1Suffix": {
            "type": "string",
            "description": "Suffix for the thoroughfare number. Only relevant is thoroughfareNumber1 is populated"
          },
          "thoroughfareNumber2": {
            "type": "integer",
            "description": "Second thoroughfare number (only used if the property has a ranged address eg 23-25)",
            "x-cds-type": "PositiveInteger"
          },
          "thoroughfareNumber2Suffix": {
            "type": "string",
            "description": "Suffix for the second thoroughfare number. Only relevant is thoroughfareNumber2 is populated"
          },
          "flatUnitType": {
            "type": "string",
            "description": "Type of flat or unit for the address"
          },
          "flatUnitNumber": {
            "type": "string",
            "description": "Unit number (including suffix, if applicable)"
          },
          "floorLevelType": {
            "type": "string",
            "description": "Type of floor or level for the address"
          },
          "floorLevelNumber": {
            "type": "string",
            "description": "Floor or level number (including alpha characters)"
          },
          "lotNumber": {
            "type": "string",
            "description": "Allotment number for the address"
          },
          "buildingName1": {
            "type": "string",
            "description": "Building/Property name 1"
          },
          "buildingName2": {
            "type": "string",
            "description": "Building/Property name 2"
          },
          "streetName": {
            "type": "string",
            "description": "The name of the street"
          },
          "streetType": {
            "type": "string",
            "description": "The street type. Valid enumeration defined by Australia Post PAF code file"
          },
          "streetSuffix": {
            "type": "string",
            "description": "The street type suffix. Valid enumeration defined by Australia Post PAF code file"
          },
          "postalDeliveryType": {
            "type": "string",
            "description": "Postal delivery type. (eg. PO BOX). Valid enumeration defined by Australia Post PAF code file"
          },
          "postalDeliveryNumber": {
            "type": "integer",
            "description": "Postal delivery number if the address is a postal delivery type",
            "x-cds-type": "PositiveInteger"
          },
          "postalDeliveryNumberPrefix": {
            "type": "string",
            "description": "Postal delivery number prefix related to the postal delivery number"
          },
          "postalDeliveryNumberSuffix": {
            "type": "string",
            "description": "Postal delivery number suffix related to the postal delivery number"
          },
          "localityName": {
            "type": "string",
            "description": "Full name of locality"
          },
          "postcode": {
            "type": "string",
            "description": "Postcode for the locality"
          },
          "state": {
            "type": "string",
            "description": "State in which the address belongs. Valid enumeration defined by Australia Post PAF code file [State Type Abbreviation](https://auspost.com.au/content/dam/auspost_corp/media/documents/australia-post-data-guide.pdf). NSW, QLD, VIC, NT, WA, SA, TAS, ACT, AAT"
          }
        }
      },
      "Links": {
        "type": "object",
        "required": [
          "self"
        ],
        "properties": {
          "self": {
            "type": "string",
            "description": "Fully qualified link that generated the current response document",
            "x-cds-type": "URIString"
          }
        }
      },
      "Meta": {
        "type": "object"
      },
      "LinksPaginated": {
        "type": "object",
        "required": [
          "self"
        ],
        "properties": {
          "self": {
            "type": "string",
            "description": "Fully qualified link that generated the current response document",
            "x-cds-type": "URIString"
          },
          "first": {
            "type": "string",
            "description": "URI to the first page of this set. Mandatory if this response is not the first page",
            "x-cds-type": "URIString"
          },
          "prev": {
            "type": "string",
            "description": "URI to the previous page of this set. Mandatory if this response is not the first page",
            "x-cds-type": "URIString"
          },
          "next": {
            "type": "string",
            "description": "URI to the next page of this set. Mandatory if this response is not the last page",
            "x-cds-type": "URIString"
          },
          "last": {
            "type": "string",
            "description": "URI to the last page of this set. Mandatory if this response is not the last page",
            "x-cds-type": "URIString"
          }
        },
        "x-conditional": [
          "prev",
          "next",
          "first",
          "last"
        ]
      },
      "MetaPaginated": {
        "type": "object",
        "required": [
          "totalPages",
          "totalRecords"
        ],
        "properties": {
          "totalRecords": {
            "type": "integer",
            "description": "The total number of records in the full set. See [pagination](#pagination).",
            "x-cds-type": "NaturalNumber"
          },
          "totalPages": {
            "type": "integer",
            "description": "The total number of pages in the full set. See [pagination](#pagination).",
            "x-cds-type": "NaturalNumber"
          }
        }
      },
      "MetaError": {
        "type": "object",
        "description": "Additional data for customised error codes",
        "properties": {
          "urn": {
            "type": "string",
            "description": "The CDR error code URN which the application-specific error code extends. Mandatory if the error `code` is an application-specific error rather than a standardised error code."
          }
        },
        "x-conditional": [
          "urn"
        ]
      },
      "ResponseErrorListV2": {
        "type": "object",
        "required": [
          "errors"
        ],
        "properties": {
          "errors": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/ResponseErrorListV2_errors"
            }
          }
        },
        "x-conditional": [
          "meta"
        ]
      },
      "BankingProductCategory": {
        "type": "string",
        "description": "The category to which a product or account belongs. See [here](#product-categories) for more details",
        "enum": [
          "BUSINESS_LOANS",
          "CRED_AND_CHRG_CARDS",
          "LEASES",
          "MARGIN_LOANS",
          "OVERDRAFTS",
          "PERS_LOANS",
          "REGULATED_TRUST_ACCOUNTS",
          "RESIDENTIAL_MORTGAGES",
          "TERM_DEPOSITS",
          "TRADE_FINANCE",
          "TRANS_AND_SAVINGS_ACCOUNTS",
          "TRAVEL_CARDS"
        ]
      },
      "RequestAccountIds_data": {
        "type": "object",
        "required": [
          "accountIds"
        ],
        "properties": {
          "accountIds": {
            "type": "array",
            "items": {
              "type": "string",
              "description": "Array of specific accountIds to obtain authorisations for",
              "x-cds-type": "ASCIIString"
            }
          }
        }
      },
      "ResponseBankingProductListV2_data": {
        "type": "object",
        "required": [
          "products"
        ],
        "properties": {
          "products": {
            "type": "array",
            "description": "The list of products returned.  If the filter results in an empty set then this array may have no records",
            "items": {
              "$ref": "#/components/schemas/BankingProductV4"
            }
          }
        }
      },
      "BankingProductV4_cardArt": {
        "type": "object",
        "required": [
          "imageUri"
        ],
        "properties": {
          "title": {
            "type": "string",
            "description": "Display label for the specific image"
          },
          "imageUri": {
            "type": "string",
            "description": "URI reference to a PNG, JPG or GIF image with proportions defined by ISO 7810 ID-1 and width no greater than 512 pixels. The URI reference may be a link or url-encoded data URI according to **[[RFC2397]](#nref-RFC2397)**",
            "x-cds-type": "URIString"
          }
        }
      },
      "BankingProductDetailV4_allOf": {
        "type": "object",
        "properties": {
          "bundles": {
            "type": "array",
            "description": "An array of bundles that this product participates in.  Each bundle is described by free form information but also by a list of product IDs of the other products that are included in the bundle.  It is assumed that the current product is included in the bundle also",
            "items": {
              "$ref": "#/components/schemas/BankingProductBundle"
            }
          },
          "features": {
            "type": "array",
            "description": "Array of features available for the product",
            "items": {
              "$ref": "#/components/schemas/BankingProductFeatureV2"
            }
          },
          "constraints": {
            "type": "array",
            "description": "Constraints on the application for or operation of the product such as minimum balances or limit thresholds",
            "items": {
              "$ref": "#/components/schemas/BankingProductConstraint"
            }
          },
          "eligibility": {
            "type": "array",
            "description": "Eligibility criteria for the product",
            "items": {
              "$ref": "#/components/schemas/BankingProductEligibility"
            }
          },
          "fees": {
            "type": "array",
            "description": "Fees applicable for the product",
            "items": {
              "$ref": "#/components/schemas/BankingProductFee"
            }
          },
          "depositRates": {
            "type": "array",
            "description": "Interest rates available for deposits",
            "items": {
              "$ref": "#/components/schemas/BankingProductDepositRate"
            }
          },
          "lendingRates": {
            "type": "array",
            "description": "Interest rates charged against lending balances",
            "items": {
              "$ref": "#/components/schemas/BankingProductLendingRateV2"
            }
          }
        }
      },
      "ResponseBankingAccountListV2_data": {
        "type": "object",
        "required": [
          "accounts"
        ],
        "properties": {
          "accounts": {
            "type": "array",
            "description": "The list of accounts returned. If the filter results in an empty set then this array may have no records",
            "items": {
              "$ref": "#/components/schemas/BankingAccountV2"
            }
          }
        }
      },
      "BankingAccountDetailV3_allOf": {
        "type": "object",
        "properties": {
          "bsb": {
            "type": "string",
            "description": "The unmasked BSB for the account. Is expected to be formatted as digits only with leading zeros included and no punctuation or spaces"
          },
          "accountNumber": {
            "type": "string",
            "description": "The unmasked account number for the account. Should not be supplied if the account number is a PAN requiring PCI compliance. Is expected to be formatted as digits only with leading zeros included and no punctuation or spaces"
          },
          "bundleName": {
            "type": "string",
            "description": "Optional field to indicate if this account is part of a bundle that is providing additional benefit for to the customer"
          },
          "specificAccountUType": {
            "type": "string",
            "description": "The type of structure to present account specific fields.",
            "enum": [
              "creditCard",
              "loan",
              "termDeposit"
            ]
          },
          "termDeposit": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/BankingTermDepositAccount"
            }
          },
          "creditCard": {
            "$ref": "#/components/schemas/BankingCreditCardAccount"
          },
          "loan": {
            "$ref": "#/components/schemas/BankingLoanAccountV2"
          },
          "depositRate": {
            "type": "string",
            "description": "current rate to calculate interest earned being applied to deposit balances as it stands at the time of the API call",
            "x-cds-type": "RateString"
          },
          "lendingRate": {
            "type": "string",
            "description": "The current rate to calculate interest payable being applied to lending balances as it stands at the time of the API call",
            "x-cds-type": "RateString"
          },
          "depositRates": {
            "type": "array",
            "description": "Fully described deposit rates for this account based on the equivalent structure in Product Reference",
            "items": {
              "$ref": "#/components/schemas/BankingProductDepositRate"
            }
          },
          "lendingRates": {
            "type": "array",
            "description": "Fully described deposit rates for this account based on the equivalent structure in Product Reference",
            "items": {
              "$ref": "#/components/schemas/BankingProductLendingRateV2"
            }
          },
          "features": {
            "type": "array",
            "description": "Array of features of the account based on the equivalent structure in Product Reference with the following additional field",
            "items": {
              "type": "object",
              "allOf": [
                {
                  "$ref": "#/components/schemas/BankingProductFeatureV2"
                },
                {
                  "type": "object",
                  "properties": {
                    "isActivated": {
                      "type": "boolean",
                      "description": "True if the feature is already activated and false if the feature is available for activation. Defaults to true if absent. (note this is an additional field appended to the feature object defined in the Product Reference payload)",
                      "default": true,
                      "x-cds-type": "Boolean"
                    }
                  }
                }
              ]
            }
          },
          "fees": {
            "type": "array",
            "description": "Fees and charges applicable to the account based on the equivalent structure in Product Reference",
            "items": {
              "$ref": "#/components/schemas/BankingProductFee"
            }
          },
          "addresses": {
            "type": "array",
            "description": "The addresses for the account to be used for correspondence",
            "items": {
              "$ref": "#/components/schemas/CommonPhysicalAddress"
            }
          }
        },
        "x-conditional": [
          "termDeposit",
          "creditCard",
          "loan"
        ]
      },
      "ResponseBankingTransactionList_data": {
        "type": "object",
        "required": [
          "transactions"
        ],
        "properties": {
          "transactions": {
            "type": "array",
            "items": {
              "$ref": "#/components/schemas/BankingTransaction"
            }
          }
        }
      },
      "BankingTransactionDetail_allOf_extendedData_x2p101Payload": {
        "type": "object",
        "properties": {
          "extendedDescription": {
            "type": "string",
            "description": "An extended string description. Required if the extensionUType field is `x2p101Payload`"
          },
          "endToEndId": {
            "type": "string",
            "description": "An end to end ID for the payment created at initiation"
          },
          "purposeCode": {
            "type": "string",
            "description": "Purpose of the payment.  Format is defined by NPP standards for the x2p1.01 overlay service"
          }
        },
        "x-conditional": [
          "extendedDescription"
        ]
      },
      "BankingTransactionDetail_allOf_extendedData": {
        "type": "object",
        "required": [
          "service"
        ],
        "properties": {
          "payer": {
            "type": "string",
            "description": "Label of the originating payer. Mandatory for inbound payment"
          },
          "payee": {
            "type": "string",
            "description": "Label of the target PayID.  Mandatory for an outbound payment. The name assigned to the BSB/Account Number or PayID (by the owner of the PayID)"
          },
          "extensionUType": {
            "type": "string",
            "description": "Optional extended data specific to transactions originated via NPP",
            "enum": [
              "x2p101Payload"
            ]
          },
          "x2p101Payload": {
            "$ref": "#/components/schemas/BankingTransactionDetail_allOf_extendedData_x2p101Payload"
          },
          "service": {
            "type": "string",
            "description": "Identifier of the applicable overlay service. Valid values are: X2P1.01",
            "enum": [
              "X2P1.01"
            ]
          }
        },
        "x-conditional": [
          "payer",
          "payee",
          "x2p101Payload"
        ]
      },
      "BankingTransactionDetail_allOf": {
        "type": "object",
        "required": [
          "extendedData"
        ],
        "properties": {
          "extendedData": {
            "$ref": "#/components/schemas/BankingTransactionDetail_allOf_extendedData"
          }
        }
      },
      "ResponseBankingAccountsBalanceList_data": {
        "type": "object",
        "required": [
          "balances"
        ],
        "properties": {
          "balances": {
            "type": "array",
            "description": "The list of balances returned",
            "items": {
              "$ref": "#/components/schemas/BankingBalance"
            }
          }
        }
      },
      "ResponseBankingPayeeListV2_data": {
        "type": "object",
        "required": [
          "payees"
        ],
        "properties": {
          "payees": {
            "type": "array",
            "description": "The list of payees returned",
            "items": {
              "$ref": "#/components/schemas/BankingPayeeV2"
            }
          }
        }
      },
      "BankingPayeeDetailV2_allOf": {
        "type": "object",
        "required": [
          "payeeUType"
        ],
        "properties": {
          "payeeUType": {
            "type": "string",
            "description": "Type of object included that describes the payee in detail",
            "enum": [
              "biller",
              "digitalWallet",
              "domestic",
              "international"
            ]
          },
          "biller": {
            "$ref": "#/components/schemas/BankingBillerPayee"
          },
          "domestic": {
            "$ref": "#/components/schemas/BankingDomesticPayee"
          },
          "digitalWallet": {
            "$ref": "#/components/schemas/BankingDigitalWalletPayee"
          },
          "international": {
            "$ref": "#/components/schemas/BankingInternationalPayee"
          }
        },
        "x-conditional": [
          "biller",
          "digitalWallet",
          "domestic",
          "international"
        ]
      },
      "BankingInternationalPayee_beneficiaryDetails": {
        "type": "object",
        "required": [
          "country"
        ],
        "properties": {
          "name": {
            "type": "string",
            "description": "Name of the beneficiary"
          },
          "country": {
            "type": "string",
            "description": "Country where the beneficiary resides. A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code",
            "x-cds-type": "ExternalRef"
          },
          "message": {
            "type": "string",
            "description": "Response message for the payment"
          }
        }
      },
      "BankingInternationalPayee_bankDetails_bankAddress": {
        "type": "object",
        "required": [
          "address",
          "name"
        ],
        "properties": {
          "name": {
            "type": "string",
            "description": "Name of the recipient Bank"
          },
          "address": {
            "type": "string",
            "description": "Address of the recipient Bank"
          }
        }
      },
      "BankingInternationalPayee_bankDetails": {
        "type": "object",
        "required": [
          "accountNumber",
          "country"
        ],
        "properties": {
          "country": {
            "type": "string",
            "description": "Country of the recipient institution. A valid [ISO 3166 Alpha-3](https://www.iso.org/iso-3166-country-codes.html) country code",
            "x-cds-type": "ExternalRef"
          },
          "accountNumber": {
            "type": "string",
            "description": "Account Targeted for payment"
          },
          "bankAddress": {
            "$ref": "#/components/schemas/BankingInternationalPayee_bankDetails_bankAddress"
          },
          "beneficiaryBankBIC": {
            "type": "string",
            "description": "Swift bank code.  Aligns with standard [ISO 9362](https://www.iso.org/standard/60390.html)",
            "x-cds-type": "ExternalRef"
          },
          "fedWireNumber": {
            "type": "string",
            "description": "Number for Fedwire payment (Federal Reserve Wire Network)"
          },
          "sortCode": {
            "type": "string",
            "description": "Sort code used for account identification in some jurisdictions"
          },
          "chipNumber": {
            "type": "string",
            "description": "Number for the Clearing House Interbank Payments System"
          },
          "routingNumber": {
            "type": "string",
            "description": "International bank routing number"
          },
          "legalEntityIdentifier": {
            "type": "string",
            "description": "The legal entity identifier (LEI) for the beneficiary.  Aligns with [ISO 17442](https://www.iso.org/standard/59771.html)",
            "x-cds-type": "ExternalRef"
          }
        }
      },
      "ResponseBankingDirectDebitAuthorisationList_data": {
        "type": "object",
        "required": [
          "directDebitAuthorisations"
        ],
        "properties": {
          "directDebitAuthorisations": {
            "type": "array",
            "description": "The list of authorisations returned",
            "items": {
              "$ref": "#/components/schemas/BankingDirectDebit"
            }
          }
        }
      },
      "ResponseBankingScheduledPaymentsList_data": {
        "type": "object",
        "required": [
          "scheduledPayments"
        ],
        "properties": {
          "scheduledPayments": {
            "type": "array",
            "description": "The list of scheduled payments to return",
            "items": {
              "$ref": "#/components/schemas/BankingScheduledPayment"
            }
          }
        }
      },
      "ResponseErrorListV2_errors": {
        "type": "object",
        "required": [
          "code",
          "detail",
          "title"
        ],
        "properties": {
          "code": {
            "type": "string",
            "description": "The code of the error encountered. Where the error is specific to the respondent, an application-specific error code, expressed as a string value. If the error is application-specific, the URN code that the specific error extends must be provided in the meta object. Otherwise, the value is the error code URN."
          },
          "title": {
            "type": "string",
            "description": "A short, human-readable summary of the problem that MUST NOT change from occurrence to occurrence of the problem represented by the error code."
          },
          "detail": {
            "type": "string",
            "description": "A human-readable explanation specific to this occurrence of the problem."
          },
          "meta": {
            "$ref": "#/components/schemas/MetaError"
          }
        }
      }
    },
    "parameters": {
      "RequestHeader_x-v": {
        "name": "x-v",
        "in": "header",
        "style": "simple",
        "required": true,
        "description": "Version of the API end point requested by the client. Must be set to a positive integer. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If the value of [x-min-v](#request-headers) is equal to or higher than the value of [x-v](#request-headers) then the [x-min-v](#request-headers) header should be treated as absent. If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable. See [HTTP Headers](#request-headers)",
        "schema": {
          "type": "string"
        }
      },
      "RequestHeader_x-min-v": {
        "name": "x-min-v",
        "in": "header",
        "style": "simple",
        "description": "Minimum version of the API end point requested by the client. Must be set to a positive integer if provided. The data holder should respond with the highest supported version between [x-min-v](#request-headers) and [x-v](#request-headers). If all versions requested are not supported then the data holder must respond with a 406 Not Acceptable.",
        "schema": {
          "type": "string"
        }
      },
      "RequestHeader_x-fapi-interaction-id": {
        "name": "x-fapi-interaction-id",
        "in": "header",
        "style": "simple",
        "description": "An **[[RFC4122]](#nref-RFC4122)** UUID used as a correlation id. If provided, the data holder must play back this value in the x-fapi-interaction-id response header. If not provided a **[[RFC4122]](#nref-RFC4122)** UUID value is required to be provided in the response header to track the interaction.",
        "schema": {
          "type": "string"
        }
      },
      "RequestHeader_x-fapi-auth-date": {
        "name": "x-fapi-auth-date",
        "in": "header",
        "style": "simple",
        "description": "The time when the customer last logged in to the Data Recipient Software Product as described in **[[FAPI-R-Draft]](#nref-FAPI-R-Draft)**.  Required for all resource calls (customer present and unattended). Not required for unauthenticated calls.",
        "schema": {
          "type": "string",
          "x-conditional": true
        },
        "x-conditional": true
      },
      "RequestHeader_x-fapi-customer-ip-address": {
        "name": "x-fapi-customer-ip-address",
        "in": "header",
        "style": "simple",
        "description": "The customer's original IP address if the customer is currently logged in to the Data Recipient Software Product. The presence of this header indicates that the API is being called in a customer present context. Not to be included for unauthenticated calls.",
        "schema": {
          "type": "string"
        }
      },
      "RequestHeader_x-cds-client-headers": {
        "name": "x-cds-client-headers",
        "in": "header",
        "style": "simple",
        "description": "The customer's original standard http headers [Base64](#common-field-types) encoded, including the original User Agent header, if the customer is currently logged in to the Data Recipient Software Product. Mandatory for customer present calls.  Not required for unattended or unauthenticated calls.",
        "schema": {
          "type": "string",
          "x-conditional": true,
          "x-cds-type": "Base64"
        },
        "x-conditional": true,
        "x-cds-type": "Base64"
      },
      "ParamAccountOpenStatus": {
        "name": "open-status",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Used to filter results according to open/closed status. Values can be OPEN, CLOSED or ALL. If absent then ALL is assumed",
        "schema": {
          "type": "string",
          "default": "ALL",
          "enum": [
            "ALL",
            "CLOSED",
            "OPEN"
          ]
        }
      },
      "ParamProductCategory": {
        "name": "product-category",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Used to filter results on the productCategory field applicable to accounts. Any one of the valid values for this field can be supplied. If absent then all accounts returned.",
        "schema": {
          "type": "string",
          "enum": [
            "BUSINESS_LOANS",
            "CRED_AND_CHRG_CARDS",
            "LEASES",
            "MARGIN_LOANS",
            "OVERDRAFTS",
            "PERS_LOANS",
            "REGULATED_TRUST_ACCOUNTS",
            "RESIDENTIAL_MORTGAGES",
            "TERM_DEPOSITS",
            "TRADE_FINANCE",
            "TRANS_AND_SAVINGS_ACCOUNTS",
            "TRAVEL_CARDS"
          ]
        }
      },
      "ParamAccountIsOwned": {
        "name": "is-owned",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Filters accounts based on whether they are owned by the authorised customer.  True for owned accounts, false for unowned accounts and absent for all accounts",
        "schema": {
          "type": "boolean",
          "x-cds-type": "Boolean"
        },
        "x-cds-type": "Boolean"
      },
      "ParamPage": {
        "name": "page",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Page of results to request (standard pagination)",
        "schema": {
          "type": "integer",
          "default": 1,
          "x-cds-type": "PositiveInteger"
        },
        "x-cds-type": "PositiveInteger"
      },
      "ParamPageSize": {
        "name": "page-size",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Page size to request. Default is 25 (standard pagination)",
        "schema": {
          "type": "integer",
          "default": 25,
          "x-cds-type": "PositiveInteger"
        },
        "x-cds-type": "PositiveInteger"
      },
      "ParamTransactionNewestTime": {
        "name": "newest-time",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Constrain the transaction history request to transactions with effective time at or before this date/time.  If absent defaults to today.  Format is aligned to DateTimeString common type",
        "schema": {
          "type": "string",
          "x-cds-type": "DateTimeString"
        },
        "x-cds-type": "DateTimeString"
      },
      "ParamTransactionOldestTime": {
        "name": "oldest-time",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Constrain the transaction history request to transactions with effective time at or after this date/time. If absent defaults to newest-time minus 90 days.  Format is aligned to DateTimeString common type",
        "schema": {
          "type": "string",
          "x-cds-type": "DateTimeString"
        },
        "x-cds-type": "DateTimeString"
      },
      "ParamTransactionMinAmount": {
        "name": "min-amount",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Filter transactions to only transactions with amounts higher or equal to than this amount",
        "schema": {
          "type": "string",
          "x-cds-type": "AmountString"
        },
        "x-cds-type": "AmountString"
      },
      "ParamTransactionMaxAmount": {
        "name": "max-amount",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Filter transactions to only transactions with amounts less than or equal to than this amount",
        "schema": {
          "type": "string",
          "x-cds-type": "AmountString"
        },
        "x-cds-type": "AmountString"
      },
      "ParamTransactionText": {
        "name": "text",
        "in": "query",
        "style": "form",
        "explode": true,
        "description": "Filter transactions to only transactions where this string value is found as a substring of either the reference or description fields. Format is arbitrary ASCII string. This parameter is optionally implemented by data holders. If it is not implemented then a response should be provided as normal without text filtering applied and an additional boolean field named isQueryParamUnsupported should be included in the meta object and set to true (whether the text parameter is supplied or not)",
        "schema": {
          "type": "string"
        }
      }
    }
  }
}