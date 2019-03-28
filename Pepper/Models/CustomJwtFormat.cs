﻿using Microsoft.Owin.Security;
using Microsoft.Owin.Security.DataHandler.Encoder;
using Microsoft.Owin.Security.OAuth;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;

using System.Linq;
using System.Web;
using Thinktecture.IdentityModel.Tokens;

namespace Pepper.Models
{
    public class CustomJwtFormat : ISecureDataFormat<AuthenticationTicket>
    {
        private const string AudiencePropertyKey = "audience";

        private readonly string _issuer = string.Empty;

        public CustomJwtFormat(string issuer)
        {
            _issuer = issuer;
        }

        public string SignatureAlgorithm
        {
            get { return "http://www.w3.org/2001/04/xmldsig-more#hmac-sha256"; }
        }

        public string DigestAlgorithm
        {
            get { return "http://www.w3.org/2001/04/xmlenc#sha256"; }
        }

        public string Protect(AuthenticationTicket data)
        {
            if (data == null)
            {
                throw new ArgumentNullException("data");
            }

            

            

   
          

            


            var issuer = "localhost";
            var audience = "all";
            var key = Convert.FromBase64String("YW55IGNhcm5hbCBwbGVhc3Vy");
            var now = DateTime.UtcNow;
            var expires = now.AddMinutes(30);
            var securityKey = new Microsoft.IdentityModel.Tokens.SymmetricSecurityKey(key);

            var signingCredentials = new SigningCredentials(
                                        new InMemorySymmetricSecurityKey(key),
                                        SignatureAlgorithm,
                                        DigestAlgorithm);

           // var signingKey = new HmacSigningCredentials(key);
            var token = new JwtSecurityToken(issuer, audience, data.Identity.Claims,
                                         now, expires, signingCredentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public AuthenticationTicket Unprotect(string protectedText)
        {
            throw new NotImplementedException();
        }
    }
}