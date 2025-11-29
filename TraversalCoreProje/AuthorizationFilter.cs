using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Filters;

namespace TraversalCoreProje
{
    internal class AuthorizationFilter : IFilterMetadata
    {
        private AuthorizationPolicy policy;

        public AuthorizationFilter(AuthorizationPolicy policy)
        {
            this.policy = policy;
        }
    }
}