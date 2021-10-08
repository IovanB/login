using System;

namespace Login.Application
{
    public class ApplicationException: Exception
    {
        public ApplicationException(string businessMessage)
           : base(businessMessage)
        {

        }
    }
}
