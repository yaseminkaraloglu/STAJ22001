using Bimser.CSP.DataSource.Api;
using Bimser.CSP.DataSource.Api.Base;
using Bimser.CSP.DataSource.Api.Models;
using Bimser.Framework.AspNetCore.Mvc.Attributes;
using Bimser.Framework.Dependency;
using Bimser.Synergy.Entities.DataSource;
using Bimser.Synergy.Entities.DataSource.Providers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Newtonsoft.Json.Linq;
using System.Threading.Tasks;
using Bimser.Framework.Domain.Option;
using Bimser.Framework.Domain.Option.Filters;
using Bimser.Framework.Domain.Option.Pagination;
using Bimser.Framework.Domain.Option.Sorts;
using Bimser.Synergy.Entities.DataSource.Providers.Database;
using Bimser.Synergy.Entities.DataSource.Providers.Database.MSSQL;
using Bimser.Synergy.Entities.DataSource.Providers.Database.MYSQL;
using Bimser.Synergy.Entities.DataSource.Providers.Database.ODBC;
using Bimser.Synergy.Entities.DataSource.Providers.Database.Oracle;
using Bimser.Synergy.Entities.DataSource.Providers.GPT;
using Bimser.Synergy.Entities.DataSource.Providers.SAP;
using Bimser.Synergy.Entities.DataSource.Providers.WebService.Rest;
using Bimser.Synergy.Entities.DataSource.Providers.WebService.Soap.Objects;
using System.Collections.Generic;
using System.IO;

namespace yktest.DataSources 
{
    [Route("apps/yktest/latest/api/DataSource/[action]")]
    [Route("apps/yktest/{v:int:min(1)}/api/DataSource/[action]")]
    [Route("api/DataSource/[action]")]
    [Produces ("application/json")]
    [Authorize(AuthenticationSchemes = "BimserBearer")]
    public class DataSourceController : BaseDataSourceController 
    {

        #region [.ctor]

        public DataSourceController (IIocManager iocManager, string authorization = "", string bimserEncryptedData = "", string bimserLanguage = "", string bimserInstance = "") : base (iocManager, authorization, bimserEncryptedData, bimserLanguage, bimserInstance) 
        {

        }

        #endregion

        ///Actions
        [HttpPost]
[AcceptVerbs("POST")]
[ActionName("Flow1_ProcessItems")]
public async Task<object> Flow1_ProcessItems_Action([FromBody] Flow1_ProcessItemsRequest request)
{
    return await Flow1_ProcessItems(request);
}

[HttpPost]
[AcceptVerbs("POST")]
[ActionName("Kullanicilar")]
public async Task<object> Kullanicilar_Action([FromBody] KullanicilarRequest request)
{
    return await Kullanicilar(request);
}

        ///Handles
        internal async Task<DataSourceResponse<object>> Flow1_ProcessItems(Flow1_ProcessItemsRequest request)
{
    string queryName = "Flow1_ProcessItems";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

internal async Task<DataSourceResponse<object>> Kullanicilar(KullanicilarRequest request)
{
    string queryName = "Kullanicilar";

    JObject queryContent = await GetQueryContent(queryName);
    MSSQLExecuteRequest designTimeRequest = GetDesignTimeRequest<MSSQLExecuteRequest>(queryName, queryContent);
    DatabaseStructure structure = GetStructure(queryName, queryContent);

    Bimser.Synergy.Entities.Shared.Business.Objects.Context context = GetContextData();

    string connectionId = queryContent.Value<string>("connectionId");
    DataSourceConnectionObject connectionObj = await GetConnectionObject(connectionId, context);
    CurrentUserInfo currentUserInfo = await GetCurrentUserInfo(queryContent, context);

    IProvider<MSSQLExecuteRequest> provider = null;
    DataSourceResponse response = null;
    try
    {
        provider = DataSourceApi.CreateProvider<MSSQLExecuteRequest>(connectionObj.Properties, currentUserInfo, context.Language);

        provider.MergeParameters(request, designTimeRequest);
        designTimeRequest.Name = queryName;

        response = await provider.ExecuteAsync(designTimeRequest, structure);
    }
    finally
    {
        if (provider != null)
        {
            provider.Dispose();
            IocManager.Release(provider);
        }
    }
    return response;
}

        ///Iterators
        [NonAction]
public IEnumerable<Dictionary<string, object>> Flow1_ProcessItemsIterator(Flow1_ProcessItemsRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = Flow1_ProcessItems(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

[NonAction]
public IEnumerable<Dictionary<string, object>> KullanicilarIterator(KullanicilarRequest request)
{
    int pagingSkip = 0;
    int pagingTake = 100;
    int pageIndex = 0;
    var filters = new List<IFilter>();
    var sorts = new List<ISort>();

    bool endOfSource = false;
    while (!endOfSource)
    {
        if (request.LoadOptions != null)
        {
            filters = request.LoadOptions.Filters;
            sorts = request.LoadOptions.Sorts;
            if (pageIndex > 0 && request.LoadOptions.Pagination != null)
            {
                pagingSkip = request.LoadOptions.Pagination.Skip + request.LoadOptions.Pagination.Take;
                pagingTake = request.LoadOptions.Pagination.Take;
            }
        }

        request.LoadOptions = new DataSourceLoadOptions(filters, sorts, new Pagination(pagingSkip, pagingTake));

        var response = Kullanicilar(request).Result;
        endOfSource = response.IsEndOfSource;
        if (response.Success && response.Result != null)
        {
            if (response.Result is List<Dictionary<string, object>> list)
            {
                foreach (var item in list)
                {
                    yield return item;
                }
            }
            else if (response.Result is JArray jArray)
            {
                foreach (var item in jArray)
                {
                    var dataItem = item.ToObject<Dictionary<string, object>>();
                    yield return dataItem;
                }
            }
        }
        else
        {
            endOfSource = true;
        }

        pageIndex++;
    }
}

    }
}