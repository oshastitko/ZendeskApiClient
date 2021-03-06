using System.Threading.Tasks;
using ZendeskApi.Client.Models;
using ZendeskApi.Client.Responses;

namespace ZendeskApi.Client.Resources
{
    public interface IJobStatusResource
    {
        #region List
        
        /// <summary>
        /// Shows the current statuses for background jobs running.
        /// </summary>
        Task<IPagination<JobStatusResponse>> ListAsync(PagerParameters pagerParameters = null);
        
        #endregion

        #region Show

        /// <summary>
        /// Shows the status of a background job.
        /// A job may no longer exist to query. Zendesk only logs the last 100 jobs. Jobs also expire within an hour.
        /// </summary>
        /// <param name="statusId">ID of the requested job status.</param>
        /// <returns></returns>
        Task<JobStatusResponse> GetAsync(string statusId);
        
        /// <summary>
        /// Shows the status of multiple background jobs.
        /// A job may no longer exist to query. Zendesk only logs the last 100 jobs. Jobs also expire within an hour.
        /// </summary>
        /// <param name="statusIds">Array of IDs of requested job statuses.</param>
        Task<IPagination<JobStatusResponse>> GetAsync(string[] statusIds, PagerParameters pagerParameters = null);        

        #endregion
    }
}