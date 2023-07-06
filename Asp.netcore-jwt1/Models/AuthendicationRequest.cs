using System;

namespace AuthendicationJWTToken
{
    [Serializable]
    public class AuthendicationRequest
    {
        public string UserName { get; set; }
        public string Password { get; set; }    
    }
}
