# Completed
- https://identityserver4.readthedocs.io/en/latest/quickstarts/1_client_credentials.html
- https://identityserver4.readthedocs.io/en/latest/quickstarts/2_interactive_aspnetcore.html
- https://identityserver4.readthedocs.io/en/latest/quickstarts/3_aspnetcore_and_apis.html

# Working
- Added Scopes
	- customer-app
	- partner-os
- Created CustomerApp that checks if JWT has scope or not (only configuration done)
- Created PartnerOS that checks if OIDC has scope or not (only configuration done)
- Refresh Token received on token endpoint when `offline_access` scope was requested

# Not working
