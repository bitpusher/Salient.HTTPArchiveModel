// #DONE

namespace Salient.HTTPArchiveModel
{
    /// <summary>
    /// This objects contains info about a request coming from browser cache.
    /// </summary>
    public class Cache
    {
        public Cache()
        {
            beforeRequest = null;
            afterRequest = null;
        }

        /// <summary>
        /// beforeRequest [object, optional]
        /// State of a cache entry before the request. 
        /// Leave out this field if the information is not available.
        /// </summary>
        public CacheItem beforeRequest { get; set; }

        /// <summary>
        /// afterRequest [object, optional]
        /// State of a cache entry after the request. 
        /// Leave out this field if the information is not available.
        /// </summary>
        public CacheItem afterRequest { get; set; }

        /// <summary>
        /// comment [string, optional] (new in 1.2)
        /// A comment provided by the user or the application.
        /// </summary>
        public string comment { get; set; }
    }
}