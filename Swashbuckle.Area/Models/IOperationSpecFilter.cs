﻿using System.Web.Http.Description;

namespace Swashbuckle.WebApi.Models
{
    public interface IOperationSpecFilter
    {
        void UpdateSpec(ApiDescription apiDescription, ApiOperationSpec operationSpec);
    }
}