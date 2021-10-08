using System;

namespace Login.Infrastructure
{
    public class InfrastructureException: Exception
    {
        public InfrastructureException(string businessMessage)
           : base(businessMessage)
        {

        }
    }
}
