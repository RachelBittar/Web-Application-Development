using System;
using System.Collections.Generic;

namespace Class1.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>(); //lista de respostas

        public static IEnumerable<GuestResponse> Responses
        {
            get
            {
                return responses;
            }
        }//reading the results

        public static void AddResponse(GuestResponse response)
        {
            responses.Add(response);
        }
    }
}