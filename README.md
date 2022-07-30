# Completed
- https://identityserver4.readthedocs.io/en/latest/quickstarts/1_client_credentials.html
- https://identityserver4.readthedocs.io/en/latest/quickstarts/2_interactive_aspnetcore.html
- https://identityserver4.readthedocs.io/en/latest/quickstarts/3_aspnetcore_and_apis.html
- https://identityserver4.readthedocs.io/en/latest/quickstarts/4_javascript_client.html
- https://identityserver4.readthedocs.io/en/latest/quickstarts/5_entityframework.html
	- In migration commands, `ConfigurationDbContext` to be run before `PersistedGrantDbContext`
	- Ref: https://github.com/IdentityServer/IdentityServer4/issues/3684#issuecomment-553772889
- Integrating AspNetIdentity with IdentityServer4
	- https://deblokt.com/2019/09/23/04-part-1-identityserver4-asp-net-core-identity/ (for netcoreapp2.1)

# Working
- Added Scopes
	- customer-app
	- partner-os
- Created CustomerApp that checks if JWT has scope or not (only configuration done)
- Created PartnerOS that checks if OIDC has scope or not (only configuration done)
- Refresh Token received on token endpoint when `offline_access` scope was requested

# Not working
