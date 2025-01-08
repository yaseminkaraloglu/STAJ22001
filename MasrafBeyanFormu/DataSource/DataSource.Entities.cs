using System;
using System.Collections.Generic;
using System.Linq;
using Bimser.CSP.DataSource.Api.Models;
using Newtonsoft.Json;

namespace MasrafBeyanFormu.DataSources
{
   ///RequestEntities
  public class Flow1_ProcessItemsRequest : DataSourceFlowProcessItemsRequest
{
}

public class MasrafTipleriniGetirRequest : BaseDataSourceDatabaseRequest
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