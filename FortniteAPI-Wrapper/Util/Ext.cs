using System;
using FortniteAPI.Models.v1;
using RestSharp;

namespace FortniteAPI.Util
{
    public static class Ext
    {
        public static IRestRequest ApplyParams(this IRestRequest request, Action<V1CosmeticListParams> param)
        {
            var p = new V1CosmeticListParams();
            param(p);

            if (p.Lang.HasValue)
            {
                request.AddParameter("lang", p.Lang.Value);
            }

            if (p.Id.HasValue)
            {
                request.AddParameter("id", p.Id.Value);
            }

            if (p.Name.HasValue)
            {
                request.AddParameter("name", p.Name.Value);
            }

            return request;
        }
    }
}