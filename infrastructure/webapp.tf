resource "azurerm_app_service_plan" "appserviceplan" {
  name = "swapi-app-plan"
  location = data.azurerm_resource_group.swapi_rg.location
  resource_group_name = data.azurerm_resource_group.swapi_rg.name
  kind = "Linux"
  reserved = true
  sku {
    tier = var.app_plan_tier
    size = var.app_plan_size
  }
}

resource "azurerm_app_service" "swapi_app_service" {
  name = "swapi-dotnet-app-${var.env_suffix}"
  location = data.azurerm_resource_group.swapi_rg.location
  resource_group_name = data.azurerm_resource_group.swapi_rg.name
  app_service_plan_id = azurerm_app_service_plan.appserviceplan.id

  site_config {
    dotnet_framework_version = "v6.0"
    linux_fx_version = "DOTNETCORE|6.0"
  }

  app_settings = {
      "APPLICATIONINSIGHTS_CONNECTION_STRING" = azurerm_application_insights.swapi_insights.connection_string
  }
}