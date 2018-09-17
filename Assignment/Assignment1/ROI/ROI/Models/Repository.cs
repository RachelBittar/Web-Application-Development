using System;
using System.Collections.Generic;

namespace ROI.Models
{
    public static class Repository
    {
        private static List<UserDatas> responses = new List<UserDatas>(); //lista de respostas - responses

        public static IEnumerable<UserDatas> Responses
        {
            get { return responses; }
        }

        public static void AddResponse(UserDatas response)
        {
            responses.Add(response);
        }

    }
}
