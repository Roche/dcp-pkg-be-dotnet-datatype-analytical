using OpenDCP.Framework.DataTypes.Analytical.Requests.AnalyticalLabData;
using OpenDCP.Framework.DataTypes.Analytical.Responses.AnalyticalLabData;
using System.Threading;
using System.Threading.Tasks;

namespace OpenDCP.Framework.DataTypes.Analytical.Interfaces
{
    /// <summary>
    /// Defines operations for querying analytical laboratory data, including navigation hierarchies, sample set metadata, injections, peaks, and response curves.
    /// </summary>
    public interface IAnalyticalLabDataSource
    {
        /// <summary>
        /// Retrieves the root-level nodes of the laboratory data navigation tree.
        /// </summary>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation, containing the list of root tree nodes.</returns>
        public Task<TreeNodeListResponse> GetRootTreeAsync(CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the child nodes for a specified parent node within the navigation hierarchy.
        /// </summary>
        /// <param name="level">The hierarchical depth level of the children to retrieve.</param>
        /// <param name="parentPath">The unique path or identifier of the parent node.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation, containing the list of child tree nodes.</returns>
        public Task<TreeNodeListResponse> GetChildrenAsync(int level, string parentPath, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves metadata details for a specific sample set or sequence file.
        /// </summary>
        /// <param name="fileId">The unique file or entity identifier for the sample set.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation, containing the sample set metadata response.</returns>
        public Task<SampleSetResponse> GetSampleSetMetadataAsync(string fileId, CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves a paginated list of injections based on project name and optional filtering tags.
        /// </summary>
        /// <param name="model">The query criteria specifying search parameters such as project name and optional filtering tags.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation, containing the retrieved injections.</returns>
        public Task<InjectionResponse> GetInjectionsAsync(
           InjectionQueryDTO model,
           CancellationToken cancellationToken = default);

        /// <summary>
        /// Searches and retrieves chromatographic peaks matching the criteria specified in the query model.
        /// </summary>
        /// <param name="model">The query criteria specifying search parameters such as result identifiers or peak filters.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation, containing the matching peak results.</returns>
        public Task<PeakResponse> SearchPeaksAsync(
           PeakQueryDTO model,
           CancellationToken cancellationToken = default);

        /// <summary>
        /// Retrieves the analytical response curve data associated with a specific result identifier.
        /// </summary>
        /// <param name="resultId">The unique identifier of the analytical result whose curve is to be retrieved.</param>
        /// <param name="cancellationToken">A token to monitor for cancellation requests.</param>
        /// <returns>A task that represents the asynchronous operation, containing the response curve coordinates and metadata.</returns>
        public Task<ResponseCurveResponse> GetResponseCurveAsync(
            string resultId,
            CancellationToken cancellationToken = default);
    }
}
