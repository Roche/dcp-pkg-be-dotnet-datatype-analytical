using OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalData;
using OpenDCP.Framework.DataTypes.Analytical.Responses.AnalyticalData;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDCP.Framework.DataTypes.Analytical.Interfaces
{
    public interface IAnalyticalDataSource
    {
        Task<AttributeListResponse> GetAttributesAsync(string webId, CancellationToken cancellationToken = default);
        Task<AttributeDataResponse> GetAnalyticalDataAsync(AttributeDataQueryDTO model, CancellationToken cancellationToken = default);

    }
}
