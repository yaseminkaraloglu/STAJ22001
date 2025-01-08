using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace Seyahat.DataSources
{
   ///RequestEntities
  public class SehirleriGetirRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            
        };
    }
}

public class Flow1_ProcessItemsRequest : DataSourceFlowProcessItemsRequest
{
}

public class UcusStandartiGetirRequest : BaseDataSourceDatabaseRequest
{
    ///Properties
    

    public override Dictionary<string, object> GetProperties()
    {
        return new Dictionary<string, object>()
        {
            
        };
    }
}
}