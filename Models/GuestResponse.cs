using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace PartyRSVP.Models
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class GuestResponse
    {
		public int Id { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public string Email { get; set; }
		public string Phone { get; set; }
		public bool? WillAttend { get; set; }

        public string FullName ()
		{
			return this.FirstName + " " + this.LastName;
		}
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class GuestResponseExtensions
    {
        public static IApplicationBuilder UseMiddlewareClassTemplate(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<GuestResponse>();
        }
    }
}
